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
        SqlDbHelper sqlDbHelper = new SqlDbHelper();
        User user = new User();
        UserGroup userGroup = new UserGroup();
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
            cmbAuth.SelectedIndex = userGroup.UserGroupAuthorization;
            lblAuth.Text = cmbAuth.Text;
        }

        private void cmbAuth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
