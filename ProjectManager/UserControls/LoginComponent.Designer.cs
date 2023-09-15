namespace ProjectManager.UserControls
{
    partial class LoginComponent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txLoginMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txLoginPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.cbRememberMe);
            this.panel1.Controls.Add(this.lblRegister);
            this.panel1.Controls.Add(this.lblReset);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txLoginMail);
            this.panel1.Controls.Add(this.txLoginPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 284);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(20)))), ((int)(((byte)(104)))));
            this.lblTitle.Location = new System.Drawing.Point(79, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 20);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Project Manager ";
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.CheckedState.BorderColor = System.Drawing.Color.Yellow;
            this.cbRememberMe.CheckedState.BorderRadius = 0;
            this.cbRememberMe.CheckedState.BorderThickness = 0;
            this.cbRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.cbRememberMe.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(181)))));
            this.cbRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbRememberMe.Location = new System.Drawing.Point(58, 143);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(95, 17);
            this.cbRememberMe.TabIndex = 24;
            this.cbRememberMe.Text = "Remember Me";
            this.cbRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.cbRememberMe.UncheckedState.BorderRadius = 0;
            this.cbRememberMe.UncheckedState.BorderThickness = 0;
            this.cbRememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            // 
            // lblRegister
            // 
            this.lblRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblRegister.Location = new System.Drawing.Point(189, 225);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(46, 13);
            this.lblRegister.TabIndex = 17;
            this.lblRegister.Text = "Register";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // lblReset
            // 
            this.lblReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReset.AutoSize = true;
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblReset.Location = new System.Drawing.Point(59, 226);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(35, 13);
            this.lblReset.TabIndex = 18;
            this.lblReset.Text = "Reset";
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(47, 168);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 45);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txLoginMail
            // 
            this.txLoginMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txLoginMail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txLoginMail.BorderRadius = 15;
            this.txLoginMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txLoginMail.DefaultText = "";
            this.txLoginMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txLoginMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txLoginMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txLoginMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txLoginMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txLoginMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txLoginMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txLoginMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txLoginMail.Location = new System.Drawing.Point(47, 47);
            this.txLoginMail.Name = "txLoginMail";
            this.txLoginMail.PasswordChar = '\0';
            this.txLoginMail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txLoginMail.PlaceholderText = "Mail";
            this.txLoginMail.SelectedText = "";
            this.txLoginMail.Size = new System.Drawing.Size(200, 36);
            this.txLoginMail.TabIndex = 19;
            // 
            // txLoginPassword
            // 
            this.txLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txLoginPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txLoginPassword.BorderRadius = 15;
            this.txLoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txLoginPassword.DefaultText = "";
            this.txLoginPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txLoginPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txLoginPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txLoginPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txLoginPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txLoginPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txLoginPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txLoginPassword.Location = new System.Drawing.Point(47, 101);
            this.txLoginPassword.Name = "txLoginPassword";
            this.txLoginPassword.PasswordChar = '\0';
            this.txLoginPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txLoginPassword.PlaceholderText = "Password";
            this.txLoginPassword.SelectedText = "";
            this.txLoginPassword.Size = new System.Drawing.Size(200, 36);
            this.txLoginPassword.TabIndex = 20;
            // 
            // LoginCompanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LoginCompanets";
            this.Size = new System.Drawing.Size(302, 284);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CheckBox cbRememberMe;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblReset;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txLoginMail;
        private Guna.UI2.WinForms.Guna2TextBox txLoginPassword;
        private System.Windows.Forms.Label lblTitle;
    }
}
