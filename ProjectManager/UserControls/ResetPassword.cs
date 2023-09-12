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
    public partial class ResetPassword : UserControl
    {
        Entry entry;
        User user = new User();
        public ResetPassword(Entry recieve,User recUser)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            entry = recieve;
            user = recUser;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            entry.SetPanelSettings("Login");
        }

        private void btnResetPasswordAndLogin_Click(object sender, EventArgs e)
        {
            if (txPassword.Text != "" && txConfirmPassword.Text != "")
            {
                if (txPassword.Text == txConfirmPassword.Text)
                {
                    user.UserPassword = txPassword.Text;
                    GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
                    if (genericUser.Update(user))
                    {
                        MessageBox.Show("Password Successfully Changed");
                        Clear();
                        Events events = new Events(user.UserId,entry);
                        events.Show();
                        entry.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Please Fill all required places.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
