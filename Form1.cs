using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WirelessAdbPackageManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            if (Program.ADB.Install())
            {
                InitializeComponent();
            }
            else
            {
                Program.ShowError("Unable to install ADB, cannot proceed.");
            }
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ConnectButton.Text.Equals("DISCONNECT"))
            {
                await Program.DisconnectDevice();
            }
            else
            {
                bool formValidated = await Program.ValidateForm();
                if (formValidated)
                {
                    await Program.HandleConnection();
                }
            }
        }

        private async void InstallButton_Click(object sender, EventArgs e)
        {
            await Program.InstallPackage();
        }

        private async void UninstallButton_Click(object sender, EventArgs e)
        {
            await Program.PerformPackageOperation(checkedListBox1.CheckedItems, "uninstall -k --user 0", "Success", "Uninstalled", "Unable to uninstall");
        }

        private async void DisableButton_Click(object sender, EventArgs e)
        {
            await Program.PerformPackageOperation(checkedListBox1.CheckedItems, "disable-user --user 0", "new state:", "Disabled", "Unable to disable");
        }

        private async void EnableButton_Click(object sender, EventArgs e)
        {
            await Program.PerformPackageOperation(checkedListBox2.CheckedItems, "enable", "new state:", "Enabled", "Unable to enable");
        }

        private void EnabledPackagesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UninstallButton.Enabled = DisableButton.Enabled = (checkedListBox1.CheckedItems.Count > 0);
        }

        private void DisabledPackagesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButton.Enabled = (checkedListBox2.CheckedItems.Count > 0);
        }

        private void EnabledPackageFilter_TextChanged(object sender, EventArgs e)
        {
            Program.FilterEnabledPackages(textBox5.Text);
        }

        private void DisabledPackageFilter_TextChanged(object sender, EventArgs e)
        {
            Program.FilterDisabledPackages(textBox6.Text);
        }        
    }
}