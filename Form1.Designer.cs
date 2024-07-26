namespace WirelessAdbPackageManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            IpAddressTextBox = new TextBox();
            PortTextBox = new TextBox();
            PairingCodeTextBox = new TextBox();
            EnabledPackagesCheckBoxList = new CheckedListBox();
            ConnectButton = new Button();
            LogsTextBox = new TextBox();
            UninstallButton = new Button();
            DisableButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DisabledPackagesCheckBoxList = new CheckedListBox();
            EnableButton = new Button();
            EnabledPackagesSearchTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            DisabledPackagesSearchTextBox = new TextBox();
            InstallButton = new Button();
            SuspendLayout();
            // 
            // IpAddressTextBox
            // 
            IpAddressTextBox.BackColor = Color.FromArgb(250, 250, 250);
            IpAddressTextBox.Location = new Point(12, 27);
            IpAddressTextBox.MaxLength = 15;
            IpAddressTextBox.Name = "IpAddressTextBox";
            IpAddressTextBox.Size = new Size(103, 23);
            IpAddressTextBox.TabIndex = 0;
            IpAddressTextBox.Text = "192.168.0.5";
            // 
            // PortTextBox
            // 
            PortTextBox.BackColor = Color.FromArgb(250, 250, 250);
            PortTextBox.Location = new Point(121, 27);
            PortTextBox.MaxLength = 5;
            PortTextBox.Name = "PortTextBox";
            PortTextBox.Size = new Size(50, 23);
            PortTextBox.TabIndex = 1;
            PortTextBox.Text = "45033";
            // 
            // PairingCodeTextBox
            // 
            PairingCodeTextBox.BackColor = Color.FromArgb(250, 250, 250);
            PairingCodeTextBox.Location = new Point(177, 27);
            PairingCodeTextBox.MaxLength = 6;
            PairingCodeTextBox.Name = "PairingCodeTextBox";
            PairingCodeTextBox.Size = new Size(75, 23);
            PairingCodeTextBox.TabIndex = 2;
            PairingCodeTextBox.Text = "879502";
            // 
            // EnabledPackagesCheckBoxList
            // 
            EnabledPackagesCheckBoxList.CheckOnClick = true;
            EnabledPackagesCheckBoxList.FormattingEnabled = true;
            EnabledPackagesCheckBoxList.Location = new Point(12, 79);
            EnabledPackagesCheckBoxList.Name = "EnabledPackagesCheckBoxList";
            EnabledPackagesCheckBoxList.ScrollAlwaysVisible = true;
            EnabledPackagesCheckBoxList.Size = new Size(351, 310);
            EnabledPackagesCheckBoxList.Sorted = true;
            EnabledPackagesCheckBoxList.TabIndex = 3;
            EnabledPackagesCheckBoxList.SelectedIndexChanged += EnabledPackagesList_SelectedIndexChanged;
            // 
            // ConnectButton
            // 
            ConnectButton.BackColor = Color.FromArgb(54, 153, 232);
            ConnectButton.FlatAppearance.BorderSize = 0;
            ConnectButton.FlatStyle = FlatStyle.Flat;
            ConnectButton.Location = new Point(258, 27);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(118, 23);
            ConnectButton.TabIndex = 4;
            ConnectButton.Text = "CONNECT";
            ConnectButton.UseVisualStyleBackColor = false;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // LogsTextBox
            // 
            LogsTextBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogsTextBox.Location = new Point(12, 442);
            LogsTextBox.Multiline = true;
            LogsTextBox.Name = "LogsTextBox";
            LogsTextBox.ReadOnly = true;
            LogsTextBox.ScrollBars = ScrollBars.Vertical;
            LogsTextBox.Size = new Size(708, 152);
            LogsTextBox.TabIndex = 5;
            // 
            // UninstallButton
            // 
            UninstallButton.BackColor = Color.FromArgb(184, 76, 74);
            UninstallButton.Enabled = false;
            UninstallButton.FlatAppearance.BorderSize = 0;
            UninstallButton.FlatStyle = FlatStyle.Flat;
            UninstallButton.ForeColor = Color.White;
            UninstallButton.Location = new Point(207, 395);
            UninstallButton.Name = "UninstallButton";
            UninstallButton.Size = new Size(75, 23);
            UninstallButton.TabIndex = 6;
            UninstallButton.Text = "UNINSTALL";
            UninstallButton.UseVisualStyleBackColor = false;
            UninstallButton.Click += UninstallButton_Click;
            // 
            // DisableButton
            // 
            DisableButton.BackColor = Color.FromArgb(54, 153, 232);
            DisableButton.Enabled = false;
            DisableButton.FlatAppearance.BorderSize = 0;
            DisableButton.FlatStyle = FlatStyle.Flat;
            DisableButton.ForeColor = Color.White;
            DisableButton.Location = new Point(288, 395);
            DisableButton.Name = "DisableButton";
            DisableButton.Size = new Size(75, 23);
            DisableButton.TabIndex = 7;
            DisableButton.Text = "DISABLE";
            DisableButton.UseVisualStyleBackColor = false;
            DisableButton.Click += DisableButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 8;
            label1.Text = "IP Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 9);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 9;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 9);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 10;
            label3.Text = "Pairing Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 61);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 11;
            label4.Text = "Enabled Packages";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 424);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 12;
            label5.Text = "Logs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 61);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 14;
            label6.Text = "Disabled Packages";
            // 
            // DisabledPackagesCheckBoxList
            // 
            DisabledPackagesCheckBoxList.CheckOnClick = true;
            DisabledPackagesCheckBoxList.FormattingEnabled = true;
            DisabledPackagesCheckBoxList.Location = new Point(369, 79);
            DisabledPackagesCheckBoxList.Name = "DisabledPackagesCheckBoxList";
            DisabledPackagesCheckBoxList.ScrollAlwaysVisible = true;
            DisabledPackagesCheckBoxList.Size = new Size(351, 310);
            DisabledPackagesCheckBoxList.Sorted = true;
            DisabledPackagesCheckBoxList.TabIndex = 13;
            DisabledPackagesCheckBoxList.SelectedIndexChanged += DisabledPackagesList_SelectedIndexChanged;
            // 
            // EnableButton
            // 
            EnableButton.BackColor = Color.FromArgb(54, 153, 232);
            EnableButton.Enabled = false;
            EnableButton.FlatAppearance.BorderSize = 0;
            EnableButton.FlatStyle = FlatStyle.Flat;
            EnableButton.ForeColor = Color.White;
            EnableButton.Location = new Point(645, 395);
            EnableButton.Name = "EnableButton";
            EnableButton.Size = new Size(75, 23);
            EnableButton.TabIndex = 15;
            EnableButton.Text = "ENABLE";
            EnableButton.UseVisualStyleBackColor = false;
            EnableButton.Click += EnableButton_Click;
            // 
            // EnabledPackagesSearchTextBox
            // 
            EnabledPackagesSearchTextBox.BackColor = Color.FromArgb(250, 250, 250);
            EnabledPackagesSearchTextBox.Location = new Point(60, 395);
            EnabledPackagesSearchTextBox.MaxLength = 100;
            EnabledPackagesSearchTextBox.Name = "EnabledPackagesSearchTextBox";
            EnabledPackagesSearchTextBox.Size = new Size(103, 23);
            EnabledPackagesSearchTextBox.TabIndex = 16;
            EnabledPackagesSearchTextBox.TextChanged += EnabledPackageFilter_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 399);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 17;
            label7.Text = "Search";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(369, 399);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 18;
            label8.Text = "Search";
            // 
            // DisabledPackagesSearchTextBox
            // 
            DisabledPackagesSearchTextBox.BackColor = Color.FromArgb(250, 250, 250);
            DisabledPackagesSearchTextBox.Location = new Point(417, 395);
            DisabledPackagesSearchTextBox.MaxLength = 100;
            DisabledPackagesSearchTextBox.Name = "DisabledPackagesSearchTextBox";
            DisabledPackagesSearchTextBox.Size = new Size(103, 23);
            DisabledPackagesSearchTextBox.TabIndex = 19;
            DisabledPackagesSearchTextBox.TextChanged += DisabledPackageFilter_TextChanged;
            // 
            // InstallButton
            // 
            InstallButton.BackColor = Color.FromArgb(255, 231, 145);
            InstallButton.Enabled = false;
            InstallButton.FlatAppearance.BorderSize = 0;
            InstallButton.FlatStyle = FlatStyle.Flat;
            InstallButton.ForeColor = Color.Black;
            InstallButton.Location = new Point(601, 27);
            InstallButton.Name = "InstallButton";
            InstallButton.Size = new Size(118, 23);
            InstallButton.TabIndex = 20;
            InstallButton.Text = "INSTALL APK";
            InstallButton.UseVisualStyleBackColor = false;
            InstallButton.Click += InstallButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(731, 612);
            Controls.Add(InstallButton);
            Controls.Add(DisabledPackagesSearchTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(EnabledPackagesSearchTextBox);
            Controls.Add(EnableButton);
            Controls.Add(label6);
            Controls.Add(DisabledPackagesCheckBoxList);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DisableButton);
            Controls.Add(UninstallButton);
            Controls.Add(LogsTextBox);
            Controls.Add(ConnectButton);
            Controls.Add(EnabledPackagesCheckBoxList);
            Controls.Add(PairingCodeTextBox);
            Controls.Add(PortTextBox);
            Controls.Add(IpAddressTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wireless Adb Package Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox IpAddressTextBox;
        public TextBox PortTextBox;
        public TextBox PairingCodeTextBox;
        public CheckedListBox EnabledPackagesCheckBoxList;
        public Button ConnectButton;
        public TextBox LogsTextBox;
        public Button UninstallButton;
        public Button DisableButton;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public CheckedListBox DisabledPackagesCheckBoxList;
        public Button EnableButton;
        public TextBox EnabledPackagesSearchTextBox;
        public Label label7;
        public Label label8;
        public TextBox DisabledPackagesSearchTextBox;
        public Button InstallButton;
    }
}
