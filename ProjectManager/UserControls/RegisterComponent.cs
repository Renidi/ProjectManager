using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager.UserControls
{
    public partial class RegisterComponent : UserControl
    {
        LoginPage entry;
        User user = new User();
        Log log = new Log();
        public RegisterComponent(LoginPage recieve)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            entry = recieve;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            entry.SetPanelSettings("Login");
        }

        private void btnReset_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Registration Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    entry.SetPanelSettings("Login");
                }
                else
                    MessageBox.Show("Passwords do not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
