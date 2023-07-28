namespace ProjectManager
{
    partial class Entry
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.lblRegisterReset = new System.Windows.Forms.Label();
            this.lblRegisterLogin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.txRegisterMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txRegisterSecretWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.txRegisterSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txRegisterPasswordSecond = new Guna.UI2.WinForms.Guna2TextBox();
            this.txRegisterName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txRegisterPasswordFirst = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelReset = new System.Windows.Forms.Panel();
            this.lblResetRegister = new System.Windows.Forms.Label();
            this.lblResetLogin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.txResetMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txResetSecretWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelResetPassword = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUserMail = new System.Windows.Forms.Label();
            this.btnResetPasswordAndLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txResetPasswordFirst = new Guna.UI2.WinForms.Guna2TextBox();
            this.txResetPasswordSecond = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.cbRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblLoginRegister = new System.Windows.Forms.Label();
            this.lblLoginReset = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txLoginMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txLoginPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.exitApp = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.panelReset.SuspendLayout();
            this.panelResetPassword.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Silver;
            this.panelMain.Controls.Add(this.panelRegister);
            this.panelMain.Controls.Add(this.panelReset);
            this.panelMain.Controls.Add(this.panelResetPassword);
            this.panelMain.Controls.Add(this.panelLogin);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(480, 450);
            this.panelMain.TabIndex = 4;
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.Silver;
            this.panelRegister.Controls.Add(this.lblRegisterReset);
            this.panelRegister.Controls.Add(this.lblRegisterLogin);
            this.panelRegister.Controls.Add(this.label7);
            this.panelRegister.Controls.Add(this.label8);
            this.panelRegister.Controls.Add(this.label9);
            this.panelRegister.Controls.Add(this.label10);
            this.panelRegister.Controls.Add(this.label11);
            this.panelRegister.Controls.Add(this.label12);
            this.panelRegister.Controls.Add(this.btnRegister);
            this.panelRegister.Controls.Add(this.txRegisterMail);
            this.panelRegister.Controls.Add(this.txRegisterSecretWord);
            this.panelRegister.Controls.Add(this.txRegisterSurname);
            this.panelRegister.Controls.Add(this.txRegisterPasswordSecond);
            this.panelRegister.Controls.Add(this.txRegisterName);
            this.panelRegister.Controls.Add(this.txRegisterPasswordFirst);
            this.panelRegister.Location = new System.Drawing.Point(368, 12);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(109, 87);
            this.panelRegister.TabIndex = 17;
            this.panelRegister.Visible = false;
            // 
            // lblRegisterReset
            // 
            this.lblRegisterReset.AutoSize = true;
            this.lblRegisterReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegisterReset.Location = new System.Drawing.Point(412, 360);
            this.lblRegisterReset.Name = "lblRegisterReset";
            this.lblRegisterReset.Size = new System.Drawing.Size(35, 13);
            this.lblRegisterReset.TabIndex = 21;
            this.lblRegisterReset.Text = "Reset";
            this.lblRegisterReset.Click += new System.EventHandler(this.lblRegisterReset_Click);
            // 
            // lblRegisterLogin
            // 
            this.lblRegisterLogin.AutoSize = true;
            this.lblRegisterLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegisterLogin.Location = new System.Drawing.Point(28, 360);
            this.lblRegisterLogin.Name = "lblRegisterLogin";
            this.lblRegisterLogin.Size = new System.Drawing.Size(33, 13);
            this.lblRegisterLogin.TabIndex = 20;
            this.lblRegisterLogin.Text = "Login";
            this.lblRegisterLogin.Click += new System.EventHandler(this.lblRegisterLogin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Secret Word";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Surname";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Name";
            // 
            // btnRegister
            // 
            this.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(31, 312);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(416, 45);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txRegisterMail
            // 
            this.txRegisterMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txRegisterMail.DefaultText = "";
            this.txRegisterMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txRegisterMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txRegisterMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txRegisterMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterMail.Location = new System.Drawing.Point(31, 190);
            this.txRegisterMail.Name = "txRegisterMail";
            this.txRegisterMail.PasswordChar = '\0';
            this.txRegisterMail.PlaceholderText = "";
            this.txRegisterMail.SelectedText = "";
            this.txRegisterMail.Size = new System.Drawing.Size(200, 36);
            this.txRegisterMail.TabIndex = 13;
            // 
            // txRegisterSecretWord
            // 
            this.txRegisterSecretWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txRegisterSecretWord.DefaultText = "";
            this.txRegisterSecretWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txRegisterSecretWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txRegisterSecretWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterSecretWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterSecretWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterSecretWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txRegisterSecretWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterSecretWord.Location = new System.Drawing.Point(247, 190);
            this.txRegisterSecretWord.Name = "txRegisterSecretWord";
            this.txRegisterSecretWord.PasswordChar = '\0';
            this.txRegisterSecretWord.PlaceholderText = "";
            this.txRegisterSecretWord.SelectedText = "";
            this.txRegisterSecretWord.Size = new System.Drawing.Size(200, 36);
            this.txRegisterSecretWord.TabIndex = 11;
            // 
            // txRegisterSurname
            // 
            this.txRegisterSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txRegisterSurname.DefaultText = "";
            this.txRegisterSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txRegisterSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txRegisterSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txRegisterSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterSurname.Location = new System.Drawing.Point(247, 124);
            this.txRegisterSurname.Name = "txRegisterSurname";
            this.txRegisterSurname.PasswordChar = '\0';
            this.txRegisterSurname.PlaceholderText = "";
            this.txRegisterSurname.SelectedText = "";
            this.txRegisterSurname.Size = new System.Drawing.Size(200, 36);
            this.txRegisterSurname.TabIndex = 7;
            // 
            // txRegisterPasswordSecond
            // 
            this.txRegisterPasswordSecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txRegisterPasswordSecond.DefaultText = "";
            this.txRegisterPasswordSecond.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txRegisterPasswordSecond.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txRegisterPasswordSecond.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterPasswordSecond.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterPasswordSecond.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterPasswordSecond.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txRegisterPasswordSecond.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterPasswordSecond.Location = new System.Drawing.Point(247, 253);
            this.txRegisterPasswordSecond.Name = "txRegisterPasswordSecond";
            this.txRegisterPasswordSecond.PasswordChar = '\0';
            this.txRegisterPasswordSecond.PlaceholderText = "";
            this.txRegisterPasswordSecond.SelectedText = "";
            this.txRegisterPasswordSecond.Size = new System.Drawing.Size(200, 36);
            this.txRegisterPasswordSecond.TabIndex = 8;
            // 
            // txRegisterName
            // 
            this.txRegisterName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txRegisterName.DefaultText = "";
            this.txRegisterName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txRegisterName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txRegisterName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txRegisterName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterName.Location = new System.Drawing.Point(31, 124);
            this.txRegisterName.Name = "txRegisterName";
            this.txRegisterName.PasswordChar = '\0';
            this.txRegisterName.PlaceholderText = "";
            this.txRegisterName.SelectedText = "";
            this.txRegisterName.Size = new System.Drawing.Size(200, 36);
            this.txRegisterName.TabIndex = 0;
            // 
            // txRegisterPasswordFirst
            // 
            this.txRegisterPasswordFirst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txRegisterPasswordFirst.DefaultText = "";
            this.txRegisterPasswordFirst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txRegisterPasswordFirst.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txRegisterPasswordFirst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterPasswordFirst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txRegisterPasswordFirst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterPasswordFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txRegisterPasswordFirst.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txRegisterPasswordFirst.Location = new System.Drawing.Point(31, 253);
            this.txRegisterPasswordFirst.Name = "txRegisterPasswordFirst";
            this.txRegisterPasswordFirst.PasswordChar = '\0';
            this.txRegisterPasswordFirst.PlaceholderText = "";
            this.txRegisterPasswordFirst.SelectedText = "";
            this.txRegisterPasswordFirst.Size = new System.Drawing.Size(200, 36);
            this.txRegisterPasswordFirst.TabIndex = 1;
            // 
            // panelReset
            // 
            this.panelReset.BackColor = System.Drawing.Color.Silver;
            this.panelReset.Controls.Add(this.lblResetRegister);
            this.panelReset.Controls.Add(this.lblResetLogin);
            this.panelReset.Controls.Add(this.label5);
            this.panelReset.Controls.Add(this.label2);
            this.panelReset.Controls.Add(this.btnReset);
            this.panelReset.Controls.Add(this.txResetMail);
            this.panelReset.Controls.Add(this.txResetSecretWord);
            this.panelReset.Location = new System.Drawing.Point(3, 12);
            this.panelReset.Name = "panelReset";
            this.panelReset.Size = new System.Drawing.Size(99, 87);
            this.panelReset.TabIndex = 16;
            this.panelReset.Visible = false;
            // 
            // lblResetRegister
            // 
            this.lblResetRegister.AutoSize = true;
            this.lblResetRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResetRegister.Location = new System.Drawing.Point(283, 317);
            this.lblResetRegister.Name = "lblResetRegister";
            this.lblResetRegister.Size = new System.Drawing.Size(46, 13);
            this.lblResetRegister.TabIndex = 14;
            this.lblResetRegister.Text = "Register";
            this.lblResetRegister.Click += new System.EventHandler(this.lblResetRegister_Click);
            // 
            // lblResetLogin
            // 
            this.lblResetLogin.AutoSize = true;
            this.lblResetLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResetLogin.Location = new System.Drawing.Point(126, 317);
            this.lblResetLogin.Name = "lblResetLogin";
            this.lblResetLogin.Size = new System.Drawing.Size(33, 13);
            this.lblResetLogin.TabIndex = 13;
            this.lblResetLogin.Text = "Login";
            this.lblResetLogin.Click += new System.EventHandler(this.lblResetLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Secret Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mail";
            // 
            // btnReset
            // 
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(129, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 45);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset Password";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txResetMail
            // 
            this.txResetMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txResetMail.DefaultText = "";
            this.txResetMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txResetMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txResetMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txResetMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txResetMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txResetMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txResetMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txResetMail.Location = new System.Drawing.Point(129, 152);
            this.txResetMail.Name = "txResetMail";
            this.txResetMail.PasswordChar = '\0';
            this.txResetMail.PlaceholderText = "";
            this.txResetMail.SelectedText = "";
            this.txResetMail.Size = new System.Drawing.Size(200, 36);
            this.txResetMail.TabIndex = 0;
            // 
            // txResetSecretWord
            // 
            this.txResetSecretWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txResetSecretWord.DefaultText = "";
            this.txResetSecretWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txResetSecretWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txResetSecretWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txResetSecretWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txResetSecretWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txResetSecretWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txResetSecretWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txResetSecretWord.Location = new System.Drawing.Point(129, 218);
            this.txResetSecretWord.Name = "txResetSecretWord";
            this.txResetSecretWord.PasswordChar = '\0';
            this.txResetSecretWord.PlaceholderText = "";
            this.txResetSecretWord.SelectedText = "";
            this.txResetSecretWord.Size = new System.Drawing.Size(200, 36);
            this.txResetSecretWord.TabIndex = 1;
            // 
            // panelResetPassword
            // 
            this.panelResetPassword.BackColor = System.Drawing.Color.Silver;
            this.panelResetPassword.Controls.Add(this.label6);
            this.panelResetPassword.Controls.Add(this.label4);
            this.panelResetPassword.Controls.Add(this.lblUserMail);
            this.panelResetPassword.Controls.Add(this.btnResetPasswordAndLogin);
            this.panelResetPassword.Controls.Add(this.txResetPasswordFirst);
            this.panelResetPassword.Controls.Add(this.txResetPasswordSecond);
            this.panelResetPassword.Location = new System.Drawing.Point(3, 372);
            this.panelResetPassword.Name = "panelResetPassword";
            this.panelResetPassword.Size = new System.Drawing.Size(99, 66);
            this.panelResetPassword.TabIndex = 15;
            this.panelResetPassword.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirm Password";
            // 
            // lblUserMail
            // 
            this.lblUserMail.AutoSize = true;
            this.lblUserMail.Location = new System.Drawing.Point(201, 86);
            this.lblUserMail.Name = "lblUserMail";
            this.lblUserMail.Size = new System.Drawing.Size(25, 13);
            this.lblUserMail.TabIndex = 7;
            this.lblUserMail.Text = "mail";
            // 
            // btnResetPasswordAndLogin
            // 
            this.btnResetPasswordAndLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPasswordAndLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPasswordAndLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetPasswordAndLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetPasswordAndLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetPasswordAndLogin.ForeColor = System.Drawing.Color.White;
            this.btnResetPasswordAndLogin.Location = new System.Drawing.Point(132, 253);
            this.btnResetPasswordAndLogin.Name = "btnResetPasswordAndLogin";
            this.btnResetPasswordAndLogin.Size = new System.Drawing.Size(200, 45);
            this.btnResetPasswordAndLogin.TabIndex = 6;
            this.btnResetPasswordAndLogin.Text = "Reset Password and Login";
            this.btnResetPasswordAndLogin.Click += new System.EventHandler(this.btnResetPasswordAndLogin_Click);
            // 
            // txResetPasswordFirst
            // 
            this.txResetPasswordFirst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txResetPasswordFirst.DefaultText = "";
            this.txResetPasswordFirst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txResetPasswordFirst.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txResetPasswordFirst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txResetPasswordFirst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txResetPasswordFirst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txResetPasswordFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txResetPasswordFirst.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txResetPasswordFirst.Location = new System.Drawing.Point(132, 136);
            this.txResetPasswordFirst.Name = "txResetPasswordFirst";
            this.txResetPasswordFirst.PasswordChar = '\0';
            this.txResetPasswordFirst.PlaceholderText = "";
            this.txResetPasswordFirst.SelectedText = "";
            this.txResetPasswordFirst.Size = new System.Drawing.Size(200, 36);
            this.txResetPasswordFirst.TabIndex = 0;
            // 
            // txResetPasswordSecond
            // 
            this.txResetPasswordSecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txResetPasswordSecond.DefaultText = "";
            this.txResetPasswordSecond.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txResetPasswordSecond.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txResetPasswordSecond.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txResetPasswordSecond.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txResetPasswordSecond.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txResetPasswordSecond.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txResetPasswordSecond.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txResetPasswordSecond.Location = new System.Drawing.Point(132, 202);
            this.txResetPasswordSecond.Name = "txResetPasswordSecond";
            this.txResetPasswordSecond.PasswordChar = '\0';
            this.txResetPasswordSecond.PlaceholderText = "";
            this.txResetPasswordSecond.SelectedText = "";
            this.txResetPasswordSecond.Size = new System.Drawing.Size(200, 36);
            this.txResetPasswordSecond.TabIndex = 1;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Silver;
            this.panelLogin.Controls.Add(this.cbRememberMe);
            this.panelLogin.Controls.Add(this.lblLoginRegister);
            this.panelLogin.Controls.Add(this.lblLoginReset);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txLoginMail);
            this.panelLogin.Controls.Add(this.txLoginPassword);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(480, 450);
            this.panelLogin.TabIndex = 6;
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.CheckedState.BorderColor = System.Drawing.Color.Yellow;
            this.cbRememberMe.CheckedState.BorderRadius = 0;
            this.cbRememberMe.CheckedState.BorderThickness = 0;
            this.cbRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRememberMe.Location = new System.Drawing.Point(128, 260);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(95, 17);
            this.cbRememberMe.TabIndex = 16;
            this.cbRememberMe.Text = "Remember Me";
            this.cbRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbRememberMe.UncheckedState.BorderRadius = 0;
            this.cbRememberMe.UncheckedState.BorderThickness = 0;
            this.cbRememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lblLoginRegister
            // 
            this.lblLoginRegister.AutoSize = true;
            this.lblLoginRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoginRegister.Location = new System.Drawing.Point(283, 329);
            this.lblLoginRegister.Name = "lblLoginRegister";
            this.lblLoginRegister.Size = new System.Drawing.Size(46, 13);
            this.lblLoginRegister.TabIndex = 0;
            this.lblLoginRegister.Text = "Register";
            this.lblLoginRegister.Click += new System.EventHandler(this.lblLoginRegister_Click);
            // 
            // lblLoginReset
            // 
            this.lblLoginReset.AutoSize = true;
            this.lblLoginReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoginReset.Location = new System.Drawing.Point(126, 329);
            this.lblLoginReset.Name = "lblLoginReset";
            this.lblLoginReset.Size = new System.Drawing.Size(35, 13);
            this.lblLoginReset.TabIndex = 0;
            this.lblLoginReset.Text = "Reset";
            this.lblLoginReset.Click += new System.EventHandler(this.lblLoginReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mail";
            // 
            // btnLogin
            // 
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(129, 281);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 45);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txLoginMail
            // 
            this.txLoginMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txLoginMail.DefaultText = "";
            this.txLoginMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txLoginMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txLoginMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txLoginMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txLoginMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txLoginMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txLoginMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txLoginMail.Location = new System.Drawing.Point(129, 152);
            this.txLoginMail.Name = "txLoginMail";
            this.txLoginMail.PasswordChar = '\0';
            this.txLoginMail.PlaceholderText = "";
            this.txLoginMail.SelectedText = "";
            this.txLoginMail.Size = new System.Drawing.Size(200, 36);
            this.txLoginMail.TabIndex = 0;
            // 
            // txLoginPassword
            // 
            this.txLoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txLoginPassword.DefaultText = "";
            this.txLoginPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txLoginPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txLoginPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txLoginPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txLoginPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txLoginPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txLoginPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txLoginPassword.Location = new System.Drawing.Point(129, 218);
            this.txLoginPassword.Name = "txLoginPassword";
            this.txLoginPassword.PasswordChar = '\0';
            this.txLoginPassword.PlaceholderText = "";
            this.txLoginPassword.SelectedText = "";
            this.txLoginPassword.Size = new System.Drawing.Size(200, 36);
            this.txLoginPassword.TabIndex = 1;
            // 
            // exitApp
            // 
            this.exitApp.Image = global::ProjectManager.Properties.Resources.delete;
            this.exitApp.Location = new System.Drawing.Point(756, 12);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(32, 32);
            this.exitApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitApp.TabIndex = 5;
            this.exitApp.TabStop = false;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // Entry
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitApp);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entry";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Entry_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Entry_MouseMove);
            this.panelMain.ResumeLayout(false);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.panelReset.ResumeLayout(false);
            this.panelReset.PerformLayout();
            this.panelResetPassword.ResumeLayout(false);
            this.panelResetPassword.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox exitApp;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblLoginRegister;
        private System.Windows.Forms.Label lblLoginReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txLoginMail;
        private Guna.UI2.WinForms.Guna2TextBox txLoginPassword;
        private System.Windows.Forms.Panel panelResetPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUserMail;
        private Guna.UI2.WinForms.Guna2Button btnResetPasswordAndLogin;
        private Guna.UI2.WinForms.Guna2TextBox txResetPasswordFirst;
        private Guna.UI2.WinForms.Guna2TextBox txResetPasswordSecond;
        private System.Windows.Forms.Panel panelReset;
        private System.Windows.Forms.Label lblResetRegister;
        private System.Windows.Forms.Label lblResetLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2TextBox txResetMail;
        private Guna.UI2.WinForms.Guna2TextBox txResetSecretWord;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label lblRegisterReset;
        private System.Windows.Forms.Label lblRegisterLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Guna.UI2.WinForms.Guna2TextBox txRegisterMail;
        private Guna.UI2.WinForms.Guna2TextBox txRegisterSecretWord;
        private Guna.UI2.WinForms.Guna2TextBox txRegisterSurname;
        private Guna.UI2.WinForms.Guna2TextBox txRegisterPasswordSecond;
        private Guna.UI2.WinForms.Guna2TextBox txRegisterName;
        private Guna.UI2.WinForms.Guna2TextBox txRegisterPasswordFirst;
        private Guna.UI2.WinForms.Guna2CheckBox cbRememberMe;
    }
}

