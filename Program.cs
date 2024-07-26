using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WirelessAdbPackageManager
{
    public static class Program
    {
        public static List<string> enabledPackages = new();
        public static List<string> disabledPackages = new();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(UI.form);
        }

        public static async Task HandleConnection()
        {
            await CheckIfAlreadyPaired(UI.form.textBox1.Text);

            if (Connectivity.IsPaired && Connectivity.IsConnected)
            {
                string deviceType = await GetDeviceType();
                string msg = string.IsNullOrEmpty(deviceType) ? $"Successfully connected to your device" : $"Successfully connected to your {deviceType}";
                UpdateLog(msg);
                UpdateUIForConnectedState();
                await RetrievePackageLists();
                return;
            }

            if (Connectivity.IsPaired)
            {
                bool isConnected = await ConnectToDevice(UI.form.textBox1.Text, UI.form.textBox2.Text);
                if (isConnected)
                {
                    UpdateUIForConnectedState();
                    await RetrievePackageLists();
                }
            }
            else
            {
                UI.form.ConnectButton.Enabled = false;
                bool isPaired = await PairWithDevice(UI.form.textBox1.Text, UI.form.textBox2.Text, UI.form.textBox3.Text);
                if (isPaired)
                {
                    Connectivity.IsPaired = true;
                    ShowInfo("Adb has paired with your device!\r\nUpdate the port as needed and hit Connect again to continue.");
                }
                else
                {
                    ShowError("Unable to pair with your device, please try again.");
                }
                UI.form.ConnectButton.Enabled = true;
            }
        }

        private static async Task<string> GetDeviceType()
        {
            string result = await RunCommandAsync($@"{Path.GetTempPath()}adb.exe devices -l");
            var split = result.Split("\r\n").ToList();
            var deviceLine = split.FirstOrDefault(item => item.Contains(UI.form.textBox1.Text));
            if (deviceLine != null)
            {
                split = deviceLine.Split(" ").ToList();
                var deviceName = split.FirstOrDefault(item => item.Contains("model:"));
                if (deviceName != null)
                    return deviceName.Replace("model:", "");
            }
            return null;
        }

        private static async Task<bool> CheckIfAlreadyPaired(string ip)
        {
            UpdateLog("Checking for existing pair with device");
            string result = await RunCommandAsync($@"{Path.GetTempPath()}adb.exe devices");

            if (!result.Contains("List of devices attached")) return false;

            var connectedDevices = result.Split("\r\n").Where(s => s.Contains(":")).ToList();

            foreach (var device in connectedDevices)
            {
                if (device.Contains(ip) && !device.Contains("offline"))
                {
                    var port = device.Split(":")[1].Replace("device", "").Trim();
                    UI.form.textBox2.Text = port;
                    Connectivity.IsPaired = true;
                    Connectivity.IsConnected = true;
                    UpdateLog($"Previously paired with device, updated port to {port}");
                    return true;
                }
            }

            UpdateLog("No previous connections detected");
            return false;
        }

        private static async Task<bool> PairWithDevice(string ip, string port, string pairingCode)
        {
            UpdateLog($"Attempting to pair with {ip}");
            await RunCommandAsync($@"{Path.GetTempPath()}adb.exe disconnect");
            await RunCommandAsync($@"{Path.GetTempPath()}adb.exe kill-server");
            string result = await RunCommandAsync($@"{Path.GetTempPath()}adb.exe pair {ip}:{port} {pairingCode}");
            return result.Contains($"Successfully paired to {ip}:{port}");
        }

        private static async Task<bool> ConnectToDevice(string ip, string port)
        {
            UpdateLog($"Attempting to connect to {ip}");
            string result = await RunCommandAsync($@"{Path.GetTempPath()}adb.exe connect {ip}:{port}");
            UpdateLog($"ADB: {result}");
            return result.Contains($"connected to {ip}:{port}");
        }

        public static async Task DisconnectDevice()
        {
            await RunCommandAsync($@"{Path.GetTempPath()}adb.exe disconnect");
            await RunCommandAsync($@"{Path.GetTempPath()}adb.exe kill-server");
            UpdateLog("Disconnected from device");
            ClearPackageLists();
            UI.form.ConnectButton.Text = "CONNECT";
            UpdateUIForDisconnectedState();
        }

        public static async Task InstallPackage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "APK Files (*.apk)|*.apk",
                Title = "Select an APK File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                await PerformPackageOperation(null, $"install {selectedFilePath}", "Success", $"Installed {openFileDialog.FileName}", $"Unable to install {openFileDialog.FileName}");
            }
            return;
        }

        public static async Task PerformPackageOperation(CheckedListBox.CheckedItemCollection items, string command, string expectedResult, string successMessage, string errorMessage)
        {
            if (items == null)
            {
                string result = await RunCommandAsync($@"{Path.GetTempPath()}adb.exe {command}");
                if (result.Contains(expectedResult))
                {
                    UpdateLog($"{successMessage}");
                }
                else
                {
                    MessageBox.Show($"{errorMessage}", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                foreach (object item in items)
                {
                    string packageName = GetPackageName(item);
                    string result = await RunCommandAsync($@"{Path.GetTempPath()}adb.exe shell pm {command} com.{packageName}");
                    if (result.Contains(expectedResult))
                    {
                        UpdateLog($"{successMessage} {packageName}");
                    }
                    else
                    {
                        MessageBox.Show($"{errorMessage} {packageName}", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            await RetrievePackageLists();
        }

        private static async Task RetrievePackageLists()
        {
            ClearPackageLists();

            string disabledPackagesResult = await RunCommandAsync($@"{Path.GetTempPath()}adb.exe shell pm list packages -d");
            if (disabledPackagesResult.Contains("package:com."))
            {
                disabledPackages = ExtractPackages(disabledPackagesResult);
                UI.form.checkedListBox2.Items.AddRange(disabledPackages.ToArray());
            }

            string enabledPackagesResult = await RunCommandAsync($@"{Path.GetTempPath()}adb.exe shell pm list packages");
            if (enabledPackagesResult.Contains("package:com."))
            {
                UpdateLog("Updating current package lists");
                enabledPackages = ExtractPackages(enabledPackagesResult).Except(disabledPackages).ToList();
                UI.form.checkedListBox1.Items.AddRange(enabledPackages.ToArray());
            }
            else
            {
                UpdateLog("No packages could be found, try reconnecting.");
            }

            FilterEnabledPackages(UI.form.textBox5.Text);
        }

        private static List<string> ExtractPackages(string result)
        {
            return result.Split("\r\n").Select(s => s.Replace("package:com.", "")).ToList();
        }

        private static void UpdateUIForConnectedState()
        {
            UI.form.InstallButton.Enabled = true;
            UI.form.textBox1.Enabled = false;
            UI.form.textBox2.Enabled = false;
            UI.form.textBox3.Enabled = false;
            UI.form.ConnectButton.Text = "DISCONNECT";
        }

        private static void UpdateUIForDisconnectedState()
        {
            UI.form.InstallButton.Enabled = false;
            UI.form.textBox1.Enabled = true;
            UI.form.textBox2.Enabled = true;
            UI.form.textBox3.Enabled = true;
            UI.form.ConnectButton.Text = "CONNECT";
        }

        public static async Task<bool> ValidateForm()
        {
            bool result;

            result = await IsValidIPAddress(UI.form.textBox1.Text);
            if (!result)
            {
                ShowError("Invalid IP Address");
                return false;
            }

            result = await IsNumericAndLength(UI.form.textBox2.Text, 5);
            if (!result)
            {
                ShowError("Invalid Port");
                return false;
            }

            result = await IsNumericAndLength(UI.form.textBox3.Text, 6);
            if (!result)
            {
                ShowError("Invalid Pairing Code");
                return false;
            }

            return true;
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void UpdateLog(string message)
        {
            string timestamp = DateTime.Now.ToString("hh:mm:ss tt");
            UI.form.textBox4.Text = string.IsNullOrEmpty(UI.form.textBox4.Text)
                ? $"{timestamp} - {message}"
                : $"{timestamp} - {message}\r\n{UI.form.textBox4.Text}";
        }

        private static void ClearPackageLists()
        {
            UI.form.checkedListBox1.Items.Clear();
            UI.form.checkedListBox2.Items.Clear();
            disabledPackages.Clear();
            enabledPackages.Clear();
        }

        private static void ToggleUIElements(bool enable)
        {
            UI.form.textBox1.Enabled = UI.form.textBox2.Enabled = UI.form.textBox3.Enabled = UI.form.textBox4.Enabled = UI.form.textBox5.Enabled = UI.form.textBox6.Enabled = UI.form.ConnectButton.Enabled = UI.form.InstallButton.Enabled = enable;
        }

        private static string GetPackageName(object item)
        {
            return item.ToString().Replace("package:com.", "");
        }

        public static void FilterEnabledPackages(string searchTerm)
        {
            FilterPackages(enabledPackages, UI.form.checkedListBox1, searchTerm);
        }

        public static void FilterDisabledPackages(string searchTerm)
        {
            FilterPackages(disabledPackages, UI.form.checkedListBox2, searchTerm);
        }

        private static void FilterPackages(List<string> packageList, CheckedListBox checkedListBox, string searchTerm)
        {
            checkedListBox.Items.Clear();
            var filteredItems = string.IsNullOrEmpty(searchTerm)
                ? packageList
                : packageList.Where(item => item.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();

            if (filteredItems.Any())
            {
                checkedListBox.Items.AddRange(filteredItems.ToArray());
            }
        }

        private static async Task<bool> IsValidIPAddress(string input)
        {
            const string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
                                   @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
                                   @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\." +
                                   @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

            return Regex.IsMatch(input, pattern);
        }

        private static async Task<bool> IsNumericAndLength(string input, int length)
        {
            return !string.IsNullOrEmpty(input) && input.Length == length && input.All(char.IsDigit);
        }

        private static async Task<string> RunCommandAsync(string command)
        {
            using var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();

            string output = await process.StandardOutput.ReadToEndAsync();
            string error = await process.StandardError.ReadToEndAsync();

            await process.WaitForExitAsync();

            return process.ExitCode == 0 ? output.Trim() : $"ERROR: {error.Trim()}";
        }

        public class ADB
        {
            public static bool Install()
            {
                try
                {
                    var tempPath = Path.GetTempPath();
                    DumpResourceToFile("adb.exe", WirelessAdbPackageManager.Properties.Resources.Adb, tempPath);
                    DumpResourceToFile("AdbWinApi.dll", WirelessAdbPackageManager.Properties.Resources.AdbWinApi, tempPath);
                    DumpResourceToFile("AdbWinUsbApi.dll", WirelessAdbPackageManager.Properties.Resources.AdbWinUsbApi, tempPath);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public static bool Uninstall()
            {
                var resources = new List<string> { "adb.exe", "AdbWinApi.dll", "AdbWinUsbApi.dll" };
                try
                {
                    foreach (var resource in resources)
                    {
                        File.Delete(Path.Combine(Path.GetTempPath(), resource));
                    }
                    return true;
                }
                catch
                {
                    MessageBox.Show("Unable to uninstall adb resources.", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            public static void DumpResourceToFile(string fileName, byte[] resource, string tempPath)
            {
                var filePath = Path.Combine(tempPath, fileName);
                if (!File.Exists(filePath))
                {
                    File.WriteAllBytes(filePath, resource);
                }
            }
        }
    }

    public class Connectivity
    {
        public static bool IsPaired { get; set; }
        public static bool IsConnected { get; set; }
    }

    public static class UI
    {
        public static Form1 form { get; set; } = new();
    }
}