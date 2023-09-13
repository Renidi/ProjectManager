namespace ProjectManager.UserControls
{
    partial class ResetPassword
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserMail = new System.Windows.Forms.Label();
            this.btnResetPasswordAndLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserMail
            // 
            this.lblUserMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserMail.AutoSize = true;
            this.lblUserMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(20)))), ((int)(((byte)(104)))));
            this.lblUserMail.Location = new System.Drawing.Point(63, 48);
            this.lblUserMail.Name = "lblUserMail";
            this.lblUserMail.Size = new System.Drawing.Size(123, 20);
            this.lblUserMail.TabIndex = 18;
            this.lblUserMail.Text = "test@gmail.com";
            // 
            // btnResetPasswordAndLogin
            // 
            this.btnResetPasswordAndLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetPasswordAndLogin.BorderRadius = 15;
            this.btnResetPasswordAndLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPasswordAndLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPasswordAndLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetPasswordAndLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetPasswordAndLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnResetPasswordAndLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetPasswordAndLogin.ForeColor = System.Drawing.Color.White;
            this.btnResetPasswordAndLogin.Location = new System.Drawing.Point(32, 187);
            this.btnResetPasswordAndLogin.Name = "btnResetPasswordAndLogin";
            this.btnResetPasswordAndLogin.Size = new System.Drawing.Size(200, 45);
            this.btnResetPasswordAndLogin.TabIndex = 23;
            this.btnResetPasswordAndLogin.Text = "Reset Password and Login";
            this.btnResetPasswordAndLogin.Click += new System.EventHandler(this.btnResetPasswordAndLogin_Click);
            // 
            // txPassword
            // 
            this.txPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txPassword.BorderRadius = 15;
            this.txPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txPassword.DefaultText = "";
            this.txPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txPassword.Location = new System.Drawing.Point(32, 88);
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '\0';
            this.txPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txPassword.PlaceholderText = "New Password";
            this.txPassword.SelectedText = "";
            this.txPassword.Size = new System.Drawing.Size(200, 36);
            this.txPassword.TabIndex = 21;
            // 
            // txConfirmPassword
            // 
            this.txConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txConfirmPassword.BorderRadius = 15;
            this.txConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txConfirmPassword.DefaultText = "";
            this.txConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txConfirmPassword.Location = new System.Drawing.Point(32, 140);
            this.txConfirmPassword.Name = "txConfirmPassword";
            this.txConfirmPassword.PasswordChar = '\0';
            this.txConfirmPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txConfirmPassword.PlaceholderText = "Confrim Password";
            this.txConfirmPassword.SelectedText = "";
            this.txConfirmPassword.Size = new System.Drawing.Size(200, 36);
            this.txConfirmPassword.TabIndex = 22;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblLogin.Location = new System.Drawing.Point(112, 243);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 23;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txConfirmPassword);
            this.Controls.Add(this.lblUserMail);
            this.Controls.Add(this.btnResetPasswordAndLogin);
            this.Name = "ResetPassword";
            this.Size = new System.Drawing.Size(261, 270);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserMail;
        private Guna.UI2.WinForms.Guna2Button btnResetPasswordAndLogin;
        private Guna.UI2.WinForms.Guna2TextBox txPassword;
        private Guna.UI2.WinForms.Guna2TextBox txConfirmPassword;
        private System.Windows.Forms.Label lblLogin;
    }
}
