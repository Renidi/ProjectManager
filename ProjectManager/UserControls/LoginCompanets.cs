using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager.UserControls
{
    public partial class LoginCompanets : UserControl
    {
        Entry entry = new Entry();
        User user = new User();
        Log log = new Log();
        public LoginCompanets(Entry recieve)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            entry = recieve;
            txLoginMail.Text = Properties.Settings.Default.mail;
            txLoginPassword.Text = Properties.Settings.Default.password;

            if (txLoginMail.Text != "")
                cbRememberMe.Checked = true;
            else
                cbRememberMe.Checked = false;
        }
        private void lblReset_Click(object sender, EventArgs e)
        {
            entry.SetPanelSettings("Reset");
        }
        private void lblRegister_Click(object sender, EventArgs e)
        {
            entry.SetPanelSettings("Register");
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(txLoginPassword.Text) && !String.IsNullOrEmpty(txLoginMail.Text))
            {
                GenericSqlHelper<User> genericLogin = new GenericSqlHelper<User>();
                int loginStatus = genericLogin.Login(txLoginMail.Text, txLoginPassword.Text); // If login succesful loginStatus will get userId
                if (loginStatus > 0)
                {
                    user.UserId = loginStatus;
                    user = genericLogin.ReadById(user);

                    log.LogSource = "User";
                    log.LogType = "Login";
                    log.LogDate = DateTime.Now;
                    log.LogUser = txLoginMail.Text;
                    log.LogUserId = user.UserId;
                    log.LogDescription = "Login";
                    log.LogStatus = loginStatus + "";

                    GenericSqlHelper<Log> genericLog = new GenericSqlHelper<Log>();
                    genericLog.Create(log);

                    if (cbRememberMe.Checked)
                    {
                        Properties.Settings.Default.mail = txLoginMail.Text;
                        Properties.Settings.Default.password = txLoginPassword.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.mail = "";
                        Properties.Settings.Default.password = "";
                        Properties.Settings.Default.Save();
                    }

                    Clear();
                    Events events = new Events(user,entry);
                    events.Show();
                    if (!cbRememberMe.Checked || txLoginMail.Text == "" || txLoginPassword.Text == "")
                    {
                        Properties.Settings.Default.mail = "";
                        Properties.Settings.Default.password = "";
                        Properties.Settings.Default.Save();
                    }
                    entry.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Missing Info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void Clear()
        {
            void func(ControlCollection controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
            }

            func(Controls);
        }

    }
}
