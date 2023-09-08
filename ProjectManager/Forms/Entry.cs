﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class Entry : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Entry_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public Entry()
        {
            InitializeComponent();
        }

        private void Entry_Load(object sender, EventArgs e)
        {

            txLoginMail.Text = Properties.Settings.Default.UserMail;
            txLoginPassword.Text = Properties.Settings.Default.UserPassword;

            if(txLoginMail.Text != "")
                cbRememberMe.Checked = true;
            else
                cbRememberMe.Checked = false;
            
        }
        public void SHOW(Panel frontPanel)
        {
            // Hide other panels
            List<Panel> list = new List<Panel> {panelLogin , panelRegister , panelReset , panelResetPassword };
            
            foreach (Panel item in list)
            {
                item.Dock = DockStyle.None;
                item.Size = new Size(0, 0);
                item.Visible = false;
                item.Hide();
            }

            //Show only wanted panel
            frontPanel.Size = new Size(480, 450);
            frontPanel.Dock = DockStyle.Fill;
            frontPanel.Visible = true;
            frontPanel.Show();

        }
        private void Clear()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        // -----------------------------------------------------------------------------------------------------------------------------------
        SqlHelper sqlHelper = new SqlHelper();
        User user = new User();
        Log log = new Log();

        private void lblResetLogin_Click(object sender, EventArgs e)
        {
            SHOW(panelLogin);
        }
        private void lblResetRegister_Click(object sender, EventArgs e)
        {
            SHOW(panelRegister);
        }
        private void lblRegisterLogin_Click(object sender, EventArgs e)
        {
            SHOW(panelLogin);
        }
        private void lblRegisterReset_Click(object sender, EventArgs e)
        {
            SHOW(panelReset);
        }
        private void lblLoginReset_Click(object sender, EventArgs e)
        {
            SHOW(panelReset);
        }
        private void lblLoginRegister_Click(object sender, EventArgs e)
        {
            SHOW(panelRegister);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txResetMail.Text != "" && txResetSecretWord.Text != "")
            {
                GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
                user.UserMail= txResetMail.Text;
                user.UserSecretWord = txResetSecretWord.Text;
                user = genericUser.ReadById(user);
                if (user.UserId != 0) // sqlHelper.SecretWordCheck(txResetMail.Text, txResetSecretWord.Text) // userId ==0 ise bilgiler yanlış
                {
                    SHOW(panelResetPassword);
                    lblUserMail.Text = user.UserMail;
                }
                else
                {
                    MessageBox.Show("Wrong Info");
                }
            }
            else
            {
                MessageBox.Show("Missing Info");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txLoginPassword.Text) && !String.IsNullOrEmpty(txLoginMail.Text))
            {
                GenericSqlHelper<User> genericLogin = new GenericSqlHelper<User>();
                int loginStatus = genericLogin.Login(txLoginMail.Text, txLoginPassword.Text); // If login succesful loginStatus will get userId
                if (loginStatus>0)
                {
                    user.UserId = loginStatus;
                    user = genericLogin.ReadById(user);
                    //user = sqlHelper.GetUserInfo(-1, txLoginMail.Text);

                    log.LogSource = "User";
                    log.LogType = "Login";
                    log.LogDate = DateTime.Now;
                    log.LogUser = txLoginMail.Text;
                    log.LogUserId = user.UserId;
                    log.LogDescription = "Login";
                    log.LogStatus = loginStatus+"";

                    GenericSqlHelper<Log> genericLog = new GenericSqlHelper<Log>();
                    genericLog.Create(log);
                    //sqlHelper.DataLog(log);

                    if (cbRememberMe.Checked)
                    {
                        Properties.Settings.Default.UserMail = txLoginMail.Text;
                        Properties.Settings.Default.UserPassword = txLoginPassword.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.UserMail = "";
                        Properties.Settings.Default.UserPassword = "";
                        Properties.Settings.Default.Save();
                    }

                    Clear();
                    Events events = new Events(user.UserId);
                    events.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Missing Info");
            }
        }
        private void btnResetPasswordAndLogin_Click(object sender, EventArgs e)
        {
            if (txResetPasswordFirst.Text != "" && txResetPasswordSecond.Text != "")
            {
                if (txResetPasswordFirst.Text == txResetPasswordSecond.Text)
                {
                    user.UserPassword = txResetPasswordFirst.Text;
                    GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
                    if(genericUser.Update(user))
                    {
                        MessageBox.Show("Password Successfully Changed");
                        Clear();
                        Events events = new Events(user.UserId);
                        events.Show();
                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Missing Info");
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txRegisterMail.Text != "" && txRegisterName.Text != "" && txRegisterPasswordFirst.Text != "" &&
                txRegisterPasswordSecond.Text != "" && txRegisterSecretWord.Text != "" && txRegisterSurname.Text != "")
            {
                if (txRegisterPasswordSecond.Text == txRegisterPasswordFirst.Text)
                {
                    user.UserName = txRegisterName.Text;
                    user.UserSurname = txRegisterSurname.Text;
                    user.UserMail = txRegisterMail.Text;
                    user.UserPassword = txRegisterPasswordSecond.Text;
                    user.UserSecretWord = txRegisterSecretWord.Text;
                    user.UserLastLoginDate = DateTime.Now;
                    user.UserRegisterDate = DateTime.Now;

                    GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
                    log.LogSource = "User";
                    log.LogType = "Login";
                    log.LogDate = DateTime.Now;
                    log.LogUser = user.UserMail;
                    log.LogUserId = user.UserId;
                    log.LogDescription = "Login";
                    log.LogStatus = genericUser.Create(user).ToString();
                    GenericSqlHelper<Log> genericLog = new GenericSqlHelper<Log>();
                    genericLog.Create(log);

                    Clear();
                    MessageBox.Show("Registration Successful");
                    SHOW(panelLogin);
                }
                else
                    MessageBox.Show("Passwords do not match");
            }
            else
            {
                MessageBox.Show("Missing info");
            }
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            if (!cbRememberMe.Checked || txLoginMail.Text == "" || txLoginPassword.Text == "")
            {
                Properties.Settings.Default.UserMail = "";
                Properties.Settings.Default.UserPassword = "";
                Properties.Settings.Default.Save();
            }
            Application.Exit();
        }

    }
}
