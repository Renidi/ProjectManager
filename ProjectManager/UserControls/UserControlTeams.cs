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
        GenericSqlHelper<UserGroup> genericUserGroup = new GenericSqlHelper<UserGroup>();
        GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
        public int authL = 0;

        public UserControlTeams(UserGroup userGroups,User users,int authLevel)
        {
            InitializeComponent();
            userGroup = userGroups;
            user = users;
            authL = authLevel;
        }

        private void UserControlTeams_Load(object sender, EventArgs e)
        {
            lblFullName.Text = user.UserName +" "+ user.UserSurname;
            lblMail.Text = user.UserMail;
            cmbAuth.SelectedIndex = userGroup.UserGroupAuthorization-1;
            lblAuth.Text = cmbAuth.Text;
            if (authL > 1)
            {
                cmbAuth.Enabled = true;
                if (authL < 3)
                {
                    cmbAuth.Items.Remove("Owner");
                }
                else{
                    if (!cmbAuth.Items.Contains("Owner"))
                        cmbAuth.Items.Add("Owner");
                }
            }
            else
            {
                cmbAuth.Enabled = false;
            }
        }

        private void cmbAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAuth.SelectedIndex+1 != userGroup.UserGroupAuthorization)
            {
                DialogResult dialog = MessageBox.Show("R u sure ?","Title", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == dialog)
                {
                    userGroup.UserGroupAuthorization = cmbAuth.SelectedIndex+1;
                    if (genericUserGroup.Update(userGroup))
                    {
                        lblAuth.Text = cmbAuth.Text;
                        if(cmbAuth.Text == "Owner")
                        {
                            Group group = new Group() { GroupId = userGroup.GroupId};
                            group = genericGroup.ReadById(group);
                            if (group.GroupManagerId != 0) 
                            {
                                UserGroup changeOwner = new UserGroup() { UserId = group.GroupManagerId , GroupId = group.GroupId};
                                changeOwner = genericUserGroup.ReadById(changeOwner);
                                if (changeOwner.UserId != 0)
                                {
                                    changeOwner.UserGroupAuthorization = 1;
                                    genericUserGroup.Update(changeOwner);
                                    group.GroupManagerId = userGroup.UserId;
                                    genericGroup.Update(group);
                                }

                            }
                        }
                    }
                }
                else if(dialog == DialogResult.No)
                {
                    cmbAuth.SelectedIndex = userGroup.UserGroupAuthorization - 1;
                }
            }
        }
    }
}
