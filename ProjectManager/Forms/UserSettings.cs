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

        User user = new User();
        GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();

        public UserSettings(User recUser)
        {
            user = recUser;
            user = genericUser.ReadById(user);

            InitializeComponent();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
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
                        if (genericUser.Login(user.UserMail,txCurrentPasswordOrSecretWord.Text)!=0)
                        {
                            user.UserPassword = txNewPassword.Text;
                            genericUser.Update(user);
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
                        User testUser = genericUser.ReadById(user);
                        bool test = testUser.UserSecretWord == txCurrentPasswordOrSecretWord.Text ? true : false;
                        if (test)
                        {
                            user.UserPassword = txNewPassword.Text;
                            genericUser.Update(user);
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
                MessageBox.Show("Missing Info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
