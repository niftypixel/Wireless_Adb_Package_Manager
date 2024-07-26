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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            ConnectButton = new Button();
            textBox4 = new TextBox();
            UninstallButton = new Button();
            DisableButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkedListBox2 = new CheckedListBox();
            EnableButton = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            InstallButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(250, 250, 250);
            textBox1.Location = new Point(12, 27);
            textBox1.MaxLength = 15;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "192.168.0.5";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(250, 250, 250);
            textBox2.Location = new Point(121, 27);
            textBox2.MaxLength = 5;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(50, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "45033";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(250, 250, 250);
            textBox3.Location = new Point(177, 27);
            textBox3.MaxLength = 6;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "879502";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 79);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.ScrollAlwaysVisible = true;
            checkedListBox1.Size = new Size(351, 310);
            checkedListBox1.Sorted = true;
            checkedListBox1.TabIndex = 3;
            checkedListBox1.SelectedIndexChanged += EnabledPackagesList_SelectedIndexChanged;
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
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(12, 442);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.ScrollBars = ScrollBars.Vertical;
            textBox4.Size = new Size(708, 152);
            textBox4.TabIndex = 5;
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
            // checkedListBox2
            // 
            checkedListBox2.CheckOnClick = true;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(369, 79);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.ScrollAlwaysVisible = true;
            checkedListBox2.Size = new Size(351, 310);
            checkedListBox2.Sorted = true;
            checkedListBox2.TabIndex = 13;
            checkedListBox2.SelectedIndexChanged += DisabledPackagesList_SelectedIndexChanged;
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
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(250, 250, 250);
            textBox5.Location = new Point(60, 395);
            textBox5.MaxLength = 100;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(103, 23);
            textBox5.TabIndex = 16;
            textBox5.TextChanged += EnabledPackageFilter_TextChanged;
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
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(250, 250, 250);
            textBox6.Location = new Point(417, 395);
            textBox6.MaxLength = 100;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(103, 23);
            textBox6.TabIndex = 19;
            textBox6.TextChanged += DisabledPackageFilter_TextChanged;
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
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(EnableButton);
            Controls.Add(label6);
            Controls.Add(checkedListBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DisableButton);
            Controls.Add(UninstallButton);
            Controls.Add(textBox4);
            Controls.Add(ConnectButton);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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

        public TextBox textBox1;
        public TextBox textBox2;
        public TextBox textBox3;
        public CheckedListBox checkedListBox1;
        public Button ConnectButton;
        public TextBox textBox4;
        public Button UninstallButton;
        public Button DisableButton;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public CheckedListBox checkedListBox2;
        public Button EnableButton;
        public TextBox textBox5;
        public Label label7;
        public Label label8;
        public TextBox textBox6;
        public Button InstallButton;
    }
}
