using ProjectManager.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class UserSettings : Form
    {

        SqlHelper sqlHelper = new SqlHelper();
        User user = new User();
        public string Mail { get; set; }

        public UserSettings(int userId)
        {
            user.UserId = userId;
            GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
            user = genericUser.ReadById(user);
            InitializeComponent();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            user.UserMail = Mail;
            user = sqlHelper.GetUserInfo(-1, user.UserMail);
            lblUserMail.Text = user.UserMail;
            lblUserName.Text = user.UserName + " " + user.UserSurname;
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

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if(txNewPassword.Text != "" &&  txNewPasswordSecond.Text != "" && txCurrentPasswordOrSecretWord.Text != "")
            {
                if (txNewPassword.Text == txNewPasswordSecond.Text)
                {
                    if (!cbPasswordOrSecret.Checked) 
                    {
                        if (sqlHelper.Login(Mail, txCurrentPasswordOrSecretWord.Text))
                        {
                            sqlHelper.ChangePassword(Mail, txNewPassword.Text);
                            MessageBox.Show("Password Successfully Changed");
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password");
                        }
                    }
                    else
                    {
                        if (sqlHelper.SecretWordCheck(user.UserMail, txCurrentPasswordOrSecretWord.Text))
                        {
                            sqlHelper.ChangePassword(user.UserMail, txNewPassword.Text);
                            MessageBox.Show("Password Successfully Changed");
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Secret Word");
                        }
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

        private void cbPasswordOrSecret_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            if(!cbPasswordOrSecret.Checked)
            {
                lblPasswordOrSecretWord.Text = "Current Password";
                cbPasswordOrSecret.Text = "Use Secret Word";
            }
            else
            {
                lblPasswordOrSecretWord.Text = "Secret Word";
                cbPasswordOrSecret.Text = "Use Current Password";
            }
        }
    }
}
