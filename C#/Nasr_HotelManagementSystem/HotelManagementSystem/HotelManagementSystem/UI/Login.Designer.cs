namespace HotelManagementSystem.UI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            usernameLabel = new MetroFramework.Controls.MetroLabel();
            passwordLabel = new MetroFramework.Controls.MetroLabel();
            signinButton = new MetroFramework.Controls.MetroButton();
            passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            usernameTextBox = new MetroFramework.Controls.MetroTextBox();
            LicenseCallButton = new MetroFramework.Controls.MetroButton();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            usernameLabel.ForeColor = Color.Black;
            usernameLabel.Location = new Point(272, 183);
            usernameLabel.Margin = new Padding(5, 0, 5, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(71, 19);
            usernameLabel.Style = MetroFramework.MetroColorStyle.Blue;
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            usernameLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            usernameLabel.Visible = false;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            passwordLabel.Location = new Point(270, 294);
            passwordLabel.Margin = new Padding(5, 0, 5, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(67, 19);
            passwordLabel.Style = MetroFramework.MetroColorStyle.Blue;
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password";
            passwordLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            passwordLabel.Visible = false;
            // 
            // signinButton
            // 
            signinButton.DisplayFocus = true;
            signinButton.Location = new Point(275, 448);
            signinButton.Margin = new Padding(5, 6, 5, 6);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(338, 58);
            signinButton.Style = MetroFramework.MetroColorStyle.Green;
            signinButton.TabIndex = 6;
            signinButton.Text = "Sign in";
            signinButton.Theme = MetroFramework.MetroThemeStyle.Light;
            signinButton.UseCustomForeColor = true;
            signinButton.UseSelectable = true;
            signinButton.UseStyleColors = true;
            signinButton.Click += signinButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            passwordTextBox.Icon = (Image)resources.GetObject("passwordTextBox.Icon");
            passwordTextBox.Location = new Point(273, 337);
            passwordTextBox.Margin = new Padding(5, 6, 5, 6);
            passwordTextBox.MaxLength = 32767;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PromptText = "Password";
            passwordTextBox.ScrollBars = ScrollBars.None;
            passwordTextBox.SelectedText = "";
            passwordTextBox.Size = new Size(340, 56);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.UseSelectable = true;
            passwordTextBox.UseStyleColors = true;
            passwordTextBox.Click += passwordTextBox_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(225, 225, 225);
            usernameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            usernameTextBox.Icon = (Image)resources.GetObject("usernameTextBox.Icon");
            usernameTextBox.Location = new Point(273, 231);
            usernameTextBox.Margin = new Padding(5, 6, 5, 6);
            usernameTextBox.MaxLength = 32767;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PasswordChar = '\0';
            usernameTextBox.PromptText = "Username";
            usernameTextBox.ScrollBars = ScrollBars.None;
            usernameTextBox.SelectedText = "";
            usernameTextBox.Size = new Size(340, 56);
            usernameTextBox.Style = MetroFramework.MetroColorStyle.Blue;
            usernameTextBox.TabIndex = 0;
            usernameTextBox.Theme = MetroFramework.MetroThemeStyle.Light;
            usernameTextBox.UseSelectable = true;
            usernameTextBox.UseStyleColors = true;
            usernameTextBox.Click += usernameTextBox_Click;
            // 
            // LicenseCallButton
            // 
            LicenseCallButton.Location = new Point(780, 681);
            LicenseCallButton.Margin = new Padding(5, 6, 5, 6);
            LicenseCallButton.Name = "LicenseCallButton";
            LicenseCallButton.Size = new Size(80, 44);
            LicenseCallButton.TabIndex = 7;
            LicenseCallButton.Text = "License";
            LicenseCallButton.UseSelectable = true;
            LicenseCallButton.Click += LicenseCallButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 725);
            Controls.Add(LicenseCallButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(signinButton);
            Controls.Add(usernameTextBox);
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "Login";
            Padding = new Padding(33, 115, 33, 38);
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.Teal;
            Text = "Login";
            FormClosing += login_FormClosing;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox usernameTextBox;
        private MetroFramework.Controls.MetroButton signinButton;
        private MetroFramework.Controls.MetroLabel usernameLabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroButton LicenseCallButton;
        
       
    }
}

