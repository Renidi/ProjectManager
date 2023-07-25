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

        SqlDbHelper sqlDbHelper = new SqlDbHelper();
        User user = new User();
        public string Mail { get; set; }

        public UserSettings(string mail)
        {
            Mail = mail;
            InitializeComponent();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            user.UserMail = Mail;
            user = sqlDbHelper.UserInfo(user);
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
                        if (sqlDbHelper.Login(Mail, txCurrentPasswordOrSecretWord.Text))
                        {
                            sqlDbHelper.ChangePassword(Mail, txNewPassword.Text);
                            MessageBox.Show("Password Succesfully Changed");
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password");
                        }
                    }
                    else
                    {
                        if (sqlDbHelper.CheckSecretWord(user.UserMail, txCurrentPasswordOrSecretWord.Text))
                        {
                            sqlDbHelper.ChangePassword(user.UserMail, txNewPassword.Text);
                            MessageBox.Show("Password Succesfully Changed");
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
