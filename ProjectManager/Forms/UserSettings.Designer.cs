namespace ProjectManager
{
    partial class UserSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetPassword = new Guna.UI2.WinForms.Guna2Button();
            this.txNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txNewPasswordSecond = new Guna.UI2.WinForms.Guna2TextBox();
            this.txCurrentPasswordOrSecretWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPasswordOrSecretWord = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserMail = new System.Windows.Forms.Label();
            this.cbPasswordOrSecret = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(487, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Change Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirm New Password";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(461, 398);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(200, 45);
            this.btnResetPassword.TabIndex = 17;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // txNewPassword
            // 
            this.txNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txNewPassword.DefaultText = "";
            this.txNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txNewPassword.Location = new System.Drawing.Point(461, 301);
            this.txNewPassword.Name = "txNewPassword";
            this.txNewPassword.PasswordChar = '\0';
            this.txNewPassword.PlaceholderText = "";
            this.txNewPassword.SelectedText = "";
            this.txNewPassword.Size = new System.Drawing.Size(200, 36);
            this.txNewPassword.TabIndex = 15;
            // 
            // txNewPasswordSecond
            // 
            this.txNewPasswordSecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txNewPasswordSecond.DefaultText = "";
            this.txNewPasswordSecond.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txNewPasswordSecond.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txNewPasswordSecond.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txNewPasswordSecond.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txNewPasswordSecond.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txNewPasswordSecond.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txNewPasswordSecond.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txNewPasswordSecond.Location = new System.Drawing.Point(461, 356);
            this.txNewPasswordSecond.Name = "txNewPasswordSecond";
            this.txNewPasswordSecond.PasswordChar = '\0';
            this.txNewPasswordSecond.PlaceholderText = "";
            this.txNewPasswordSecond.SelectedText = "";
            this.txNewPasswordSecond.Size = new System.Drawing.Size(200, 36);
            this.txNewPasswordSecond.TabIndex = 16;
            // 
            // txCurrentPasswordOrSecretWord
            // 
            this.txCurrentPasswordOrSecretWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txCurrentPasswordOrSecretWord.DefaultText = "";
            this.txCurrentPasswordOrSecretWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txCurrentPasswordOrSecretWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txCurrentPasswordOrSecretWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCurrentPasswordOrSecretWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txCurrentPasswordOrSecretWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCurrentPasswordOrSecretWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txCurrentPasswordOrSecretWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txCurrentPasswordOrSecretWord.Location = new System.Drawing.Point(461, 211);
            this.txCurrentPasswordOrSecretWord.Name = "txCurrentPasswordOrSecretWord";
            this.txCurrentPasswordOrSecretWord.PasswordChar = '\0';
            this.txCurrentPasswordOrSecretWord.PlaceholderText = "";
            this.txCurrentPasswordOrSecretWord.SelectedText = "";
            this.txCurrentPasswordOrSecretWord.Size = new System.Drawing.Size(200, 36);
            this.txCurrentPasswordOrSecretWord.TabIndex = 20;
            // 
            // lblPasswordOrSecretWord
            // 
            this.lblPasswordOrSecretWord.AutoSize = true;
            this.lblPasswordOrSecretWord.Location = new System.Drawing.Point(458, 195);
            this.lblPasswordOrSecretWord.Name = "lblPasswordOrSecretWord";
            this.lblPasswordOrSecretWord.Size = new System.Drawing.Size(90, 13);
            this.lblPasswordOrSecretWord.TabIndex = 21;
            this.lblPasswordOrSecretWord.Text = "Current Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(561, 55);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 22;
            this.lblUserName.Text = "label7";
            // 
            // lblUserMail
            // 
            this.lblUserMail.AutoSize = true;
            this.lblUserMail.Location = new System.Drawing.Point(561, 83);
            this.lblUserMail.Name = "lblUserMail";
            this.lblUserMail.Size = new System.Drawing.Size(35, 13);
            this.lblUserMail.TabIndex = 23;
            this.lblUserMail.Text = "label8";
            // 
            // cbPasswordOrSecret
            // 
            this.cbPasswordOrSecret.AutoSize = true;
            this.cbPasswordOrSecret.Location = new System.Drawing.Point(461, 253);
            this.cbPasswordOrSecret.Name = "cbPasswordOrSecret";
            this.cbPasswordOrSecret.Size = new System.Drawing.Size(108, 17);
            this.cbPasswordOrSecret.TabIndex = 33;
            this.cbPasswordOrSecret.Text = "Use Secret Word";
            this.cbPasswordOrSecret.UseVisualStyleBackColor = true;
            this.cbPasswordOrSecret.CheckedChanged += new System.EventHandler(this.cbPasswordOrSecret_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 512);
            this.panel1.TabIndex = 34;
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1264, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbPasswordOrSecret);
            this.Controls.Add(this.lblUserMail);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPasswordOrSecretWord);
            this.Controls.Add(this.txCurrentPasswordOrSecretWord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.txNewPassword);
            this.Controls.Add(this.txNewPasswordSecond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSettings";
            this.Text = "UserSettings";
            this.Load += new System.EventHandler(this.UserSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnResetPassword;
        private Guna.UI2.WinForms.Guna2TextBox txNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txNewPasswordSecond;
        private Guna.UI2.WinForms.Guna2TextBox txCurrentPasswordOrSecretWord;
        private System.Windows.Forms.Label lblPasswordOrSecretWord;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserMail;
        private System.Windows.Forms.CheckBox cbPasswordOrSecret;
        private System.Windows.Forms.Panel panel1;
    }
}