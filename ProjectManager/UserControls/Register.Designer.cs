namespace ProjectManager.UserControls
{
    partial class Register
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
            this.txRegisterName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txRegisterMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txRegisterSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txRegisterSecretWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.txRegisterPasswordFirst = new Guna.UI2.WinForms.Guna2TextBox();
            this.txRegisterPasswordSecond = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblDoYouHaveAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txRegisterName
            // 
            this.txRegisterName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txRegisterName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterName.BorderRadius = 15;
            this.txRegisterName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txRegisterName.DefaultText = "";
            this.txRegisterName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txRegisterName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txRegisterName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txRegisterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterName.Location = new System.Drawing.Point(49, 19);
            this.txRegisterName.Name = "txRegisterName";
            this.txRegisterName.PasswordChar = '\0';
            this.txRegisterName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterName.PlaceholderText = "Name";
            this.txRegisterName.SelectedText = "";
            this.txRegisterName.Size = new System.Drawing.Size(200, 36);
            this.txRegisterName.TabIndex = 31;
            // 
            // txRegisterMail
            // 
            this.txRegisterMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txRegisterMail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterMail.BorderRadius = 15;
            this.txRegisterMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txRegisterMail.DefaultText = "";
            this.txRegisterMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txRegisterMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txRegisterMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txRegisterMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterMail.Location = new System.Drawing.Point(49, 113);
            this.txRegisterMail.Name = "txRegisterMail";
            this.txRegisterMail.PasswordChar = '\0';
            this.txRegisterMail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterMail.PlaceholderText = "Mail";
            this.txRegisterMail.SelectedText = "";
            this.txRegisterMail.Size = new System.Drawing.Size(200, 36);
            this.txRegisterMail.TabIndex = 33;
            // 
            // txRegisterSurname
            // 
            this.txRegisterSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txRegisterSurname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterSurname.BorderRadius = 15;
            this.txRegisterSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txRegisterSurname.DefaultText = "";
            this.txRegisterSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txRegisterSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txRegisterSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txRegisterSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterSurname.Location = new System.Drawing.Point(49, 66);
            this.txRegisterSurname.Name = "txRegisterSurname";
            this.txRegisterSurname.PasswordChar = '\0';
            this.txRegisterSurname.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterSurname.PlaceholderText = "Surname";
            this.txRegisterSurname.SelectedText = "";
            this.txRegisterSurname.Size = new System.Drawing.Size(200, 36);
            this.txRegisterSurname.TabIndex = 32;
            // 
            // txRegisterSecretWord
            // 
            this.txRegisterSecretWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txRegisterSecretWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterSecretWord.BorderRadius = 15;
            this.txRegisterSecretWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txRegisterSecretWord.DefaultText = "";
            this.txRegisterSecretWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txRegisterSecretWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txRegisterSecretWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterSecretWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterSecretWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterSecretWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txRegisterSecretWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterSecretWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterSecretWord.Location = new System.Drawing.Point(49, 160);
            this.txRegisterSecretWord.Name = "txRegisterSecretWord";
            this.txRegisterSecretWord.PasswordChar = '\0';
            this.txRegisterSecretWord.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterSecretWord.PlaceholderText = "Secret Word";
            this.txRegisterSecretWord.SelectedText = "";
            this.txRegisterSecretWord.Size = new System.Drawing.Size(200, 36);
            this.txRegisterSecretWord.TabIndex = 34;
            // 
            // txRegisterPasswordFirst
            // 
            this.txRegisterPasswordFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txRegisterPasswordFirst.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterPasswordFirst.BorderRadius = 15;
            this.txRegisterPasswordFirst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txRegisterPasswordFirst.DefaultText = "";
            this.txRegisterPasswordFirst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txRegisterPasswordFirst.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txRegisterPasswordFirst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterPasswordFirst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterPasswordFirst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterPasswordFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txRegisterPasswordFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterPasswordFirst.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterPasswordFirst.Location = new System.Drawing.Point(49, 207);
            this.txRegisterPasswordFirst.Name = "txRegisterPasswordFirst";
            this.txRegisterPasswordFirst.PasswordChar = '\0';
            this.txRegisterPasswordFirst.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterPasswordFirst.PlaceholderText = "Password";
            this.txRegisterPasswordFirst.SelectedText = "";
            this.txRegisterPasswordFirst.Size = new System.Drawing.Size(200, 36);
            this.txRegisterPasswordFirst.TabIndex = 35;
            // 
            // txRegisterPasswordSecond
            // 
            this.txRegisterPasswordSecond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txRegisterPasswordSecond.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterPasswordSecond.BorderRadius = 15;
            this.txRegisterPasswordSecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txRegisterPasswordSecond.DefaultText = "";
            this.txRegisterPasswordSecond.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txRegisterPasswordSecond.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txRegisterPasswordSecond.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterPasswordSecond.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterPasswordSecond.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterPasswordSecond.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txRegisterPasswordSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterPasswordSecond.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterPasswordSecond.Location = new System.Drawing.Point(49, 254);
            this.txRegisterPasswordSecond.Name = "txRegisterPasswordSecond";
            this.txRegisterPasswordSecond.PasswordChar = '\0';
            this.txRegisterPasswordSecond.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.txRegisterPasswordSecond.PlaceholderText = "Confirm Password";
            this.txRegisterPasswordSecond.SelectedText = "";
            this.txRegisterPasswordSecond.Size = new System.Drawing.Size(200, 36);
            this.txRegisterPasswordSecond.TabIndex = 36;
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
            this.btnReset.Location = new System.Drawing.Point(36, 304);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(231, 45);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "Register";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.lblLogin.Location = new System.Drawing.Point(184, 364);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(50, 16);
            this.lblLogin.TabIndex = 39;
            this.lblLogin.Text = "LOG IN";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblDoYouHaveAccount
            // 
            this.lblDoYouHaveAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDoYouHaveAccount.AutoSize = true;
            this.lblDoYouHaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoYouHaveAccount.Location = new System.Drawing.Point(64, 366);
            this.lblDoYouHaveAccount.Name = "lblDoYouHaveAccount";
            this.lblDoYouHaveAccount.Size = new System.Drawing.Size(121, 13);
            this.lblDoYouHaveAccount.TabIndex = 40;
            this.lblDoYouHaveAccount.Text = "Do You Have Account?";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(212)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.lblDoYouHaveAccount);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txRegisterPasswordFirst);
            this.Controls.Add(this.txRegisterPasswordSecond);
            this.Controls.Add(this.txRegisterSurname);
            this.Controls.Add(this.txRegisterSecretWord);
            this.Controls.Add(this.txRegisterName);
            this.Controls.Add(this.txRegisterMail);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(301, 387);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txRegisterName;
        private Guna.UI2.WinForms.Guna2TextBox txRegisterMail;
        private Guna.UI2.WinForms.Guna2TextBox txRegisterSurname;
        private Guna.UI2.WinForms.Guna2TextBox txRegisterSecretWord;
        private Guna.UI2.WinForms.Guna2TextBox txRegisterPasswordFirst;
        private Guna.UI2.WinForms.Guna2TextBox txRegisterPasswordSecond;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblDoYouHaveAccount;
    }
}
