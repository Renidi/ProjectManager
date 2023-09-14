using ProjectManager.Entities;
using ProjectManager.Forms;
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
        User authUser = new User();
        UserGroup userGroup;
        UserGroup authUserGroup;
        GenericSqlHelper<UserGroup> genericUserGroup = new GenericSqlHelper<UserGroup>();
        GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
        GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
        TeamControl teamControl;
        public UserControlTeams(UserGroup userGroups,User users,int authUserId,TeamControl teamC) // auth level must to be loginned user
        {
            InitializeComponent();
            userGroup = userGroups;
            user = users;
            authUser.UserId = authUserId;
            teamControl = teamC;
        }

        private void UserControlTeams_Load(object sender, EventArgs e)
        {
            lblFullName.Text = user.UserName +" "+ user.UserSurname;
            lblMail.Text = user.UserMail;
            cmbAuth.SelectedIndex = userGroup.UserGroupAuthorization;
            lblAuth.Text = cmbAuth.Text;
            authUser = genericUser.ReadById(authUser);
            authUserGroup = new UserGroup() { UserId = authUser.UserId, GroupId = userGroup.GroupId };
            authUserGroup = genericUserGroup.ReadById(authUserGroup);
            if (authUserGroup.UserGroupAuthorization > 1 && authUser.UserId != user.UserId)
            {
                cmbAuth.Enabled = true;
                if (authUserGroup.UserGroupAuthorization < 3)
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
            authUser = genericUser.ReadById(authUser);
            authUserGroup = new UserGroup() { UserId = authUser.UserId , GroupId = userGroup.GroupId};
            authUserGroup = genericUserGroup.ReadById(authUserGroup);
            if (cmbAuth.SelectedIndex != userGroup.UserGroupAuthorization && authUserGroup.UserGroupAuthorization > 1)
            {
                DialogResult dialog = MessageBox.Show("R u sure ?","Title", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == dialog)
                {
                    userGroup.UserGroupAuthorization = cmbAuth.SelectedIndex;
                    if(cmbAuth.Text == "Remove Member")
                    {
                        userGroup.InviteStatus = "Kicked";
                        userGroup.InviteSenderId = user.UserId;
                    }
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
                    else
                    {
                        MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK);
                    }
                    teamControl.refreshTeamUsers(1);
                }
                else if(dialog == DialogResult.No)
                {
                    cmbAuth.SelectedIndex = userGroup.UserGroupAuthorization;
                }
            }
            
        }
    }
}
