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
    public partial class ForgotPasswordComponent : UserControl
    {
        LoginPage entry = new LoginPage();
        User user = new User();
        public ForgotPasswordComponent(LoginPage recieve)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            entry = recieve;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            entry.SetPanelSettings("Login");
        }

        private void lblLoginRegister_Click(object sender, EventArgs e)
        {
            entry.SetPanelSettings("Register"); // Register page
        }

        private void btnReset_Click(object sender, EventArgs e)  
        {
            if (txMail.Text != "" && txSecretWord.Text != "")
            {
                GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
                user.UserMail = txMail.Text;
                user.UserSecretWord = txSecretWord.Text;
                user = genericUser.ReadById(user);
                if (user.UserId != 0) // if information true we will recieve userId > 0
                {
                    entry.SetPanelSettings("ResetPassword",user);
                    lblTitle.Text = user.UserMail;
                }
                else
                {
                    MessageBox.Show("Wrong Info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Missing Info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
