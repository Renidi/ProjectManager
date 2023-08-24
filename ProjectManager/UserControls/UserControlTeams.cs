using ProjectManager.Entities;
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
    public partial class UserControlTeams : UserControl
    {
        User user = new User();
        UserGroup userGroup = new UserGroup();
        SqlHelper sqlHelper = new SqlHelper();
        public UserControlTeams(UserGroup userGroups,User users)
        {
            InitializeComponent();
            userGroup = userGroups;
            user = users;
        }

        private void UserControlTeams_Load(object sender, EventArgs e)
        {
            lblFullName.Text = user.UserName +" "+ user.UserSurname;
            lblMail.Text = user.UserMail;
            cmbAuth.SelectedIndex = userGroup.UserGroupAuthorization-1;
            lblAuth.Text = cmbAuth.Text;
        }

        private void cmbAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAuth.SelectedIndex+1 != userGroup.UserGroupAuthorization)
            {
                DialogResult dialog = MessageBox.Show("R u sure ?","Title", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == dialog)
                {
                    sqlHelper.EditData(null,null,userGroup);
                }
                else if(dialog == DialogResult.No)
                {
                    cmbAuth.SelectedIndex = userGroup.UserGroupAuthorization - 1;
                }
            }
        }
    }
}
