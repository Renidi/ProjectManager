namespace ProjectManager.UserControls
{
    partial class ForgotPasswordComponent
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
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.lblLoginRegister = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txSecretWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BorderRadius = 15;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(50, 170);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 45);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset Password";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblLoginRegister
            // 
            this.lblLoginRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoginRegister.AutoSize = true;
            this.lblLoginRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoginRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblLoginRegister.Location = new System.Drawing.Point(187, 237);
            this.lblLoginRegister.Name = "lblLoginRegister";
            this.lblLoginRegister.Size = new System.Drawing.Size(46, 13);
            this.lblLoginRegister.TabIndex = 19;
            this.lblLoginRegister.Text = "Register";
            this.lblLoginRegister.Click += new System.EventHandler(this.lblLoginRegister_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblLogin.Location = new System.Drawing.Point(72, 237);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 20;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // txMail
            // 
            this.txMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txMail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txMail.BorderRadius = 15;
            this.txMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txMail.DefaultText = "";
            this.txMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txMail.Location = new System.Drawing.Point(50, 63);
            this.txMail.Name = "txMail";
            this.txMail.PasswordChar = '\0';
            this.txMail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txMail.PlaceholderText = "Mail";
            this.txMail.SelectedText = "";
            this.txMail.Size = new System.Drawing.Size(200, 36);
            this.txMail.TabIndex = 21;
            // 
            // txSecretWord
            // 
            this.txSecretWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txSecretWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txSecretWord.BorderRadius = 15;
            this.txSecretWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txSecretWord.DefaultText = "";
            this.txSecretWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txSecretWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txSecretWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txSecretWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txSecretWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txSecretWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txSecretWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txSecretWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txSecretWord.Location = new System.Drawing.Point(50, 115);
            this.txSecretWord.Name = "txSecretWord";
            this.txSecretWord.PasswordChar = '\0';
            this.txSecretWord.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txSecretWord.PlaceholderText = "Secret Word";
            this.txSecretWord.SelectedText = "";
            this.txSecretWord.Size = new System.Drawing.Size(200, 36);
            this.txSecretWord.TabIndex = 22;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(20)))), ((int)(((byte)(104)))));
            this.lblTitle.Location = new System.Drawing.Point(82, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 20);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Reset Password";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txMail);
            this.Controls.Add(this.txSecretWord);
            this.Controls.Add(this.lblLoginRegister);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnReset);
            this.Name = "ForgotPassword";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.Label lblLoginRegister;
        private System.Windows.Forms.Label lblLogin;
        private Guna.UI2.WinForms.Guna2TextBox txMail;
        private Guna.UI2.WinForms.Guna2TextBox txSecretWord;
        private System.Windows.Forms.Label lblTitle;
    }
}
