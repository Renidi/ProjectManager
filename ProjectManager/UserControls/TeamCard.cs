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

namespace ProjectManager.Forms
{
    public partial class TeamCard : UserControl
    {
        Project project = new Project();
        User user = new User();
        User groupFounder = new User();
        Log log = new Log();
        Group group = new Group();
        UserGroup userGroup = new UserGroup();
        GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
        GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
        GenericSqlHelper<UserGroup> genericUserGroup = new GenericSqlHelper<UserGroup>();
        private Teams teams;
        public TeamCard(UserGroup x, Teams formTeams,int userId)
        {
            InitializeComponent();
            userGroup = x;
            user.UserId = userId;
            user = genericUser.ReadById(user);
            teams = formTeams;
        }

        private void TeamsControl_Load(object sender, EventArgs e)
        {
            group.GroupId = userGroup.GroupId;
            group = genericGroup.ReadById(group);
            lblTeamName.Text = group.GroupName;
            groupFounder = new User(){ UserId = group.GroupManagerId };
            groupFounder =  genericUser.ReadById(groupFounder);
            lblTeamLeaderMail.Text = groupFounder!=null ? "Team Leader: " + groupFounder.UserMail : "NOPE";
            var counter = genericUser.GetProjectAndTaskCounts(group.GroupId);
            lblTaskProjectCount.Text = counter.Item1 + " Project , " + counter.Item2 + " Task";

            lblDescription.AutoSize = true;
            lblDescription.Text = "    "+group.GroupDescription;
            lblDescription.AutoSize = false;
        }

        private void lblDescription_TextChanged(object sender, EventArgs e)
        {
            lblDescription.Size = lblDescription.PreferredSize;
            AdjustFormSize();
        }
        private void AdjustFormSize()
        {
            int desiredHeight = lblDescription.Height-30;
            Height += desiredHeight;
        }
        private void ClickOn()
        {
            if (userGroup.UserGroupAuthorization > 0)
            {
                List<User> userList = genericUser.ReadList(user, group.GroupId);
                List<UserGroup> userGroups = genericUserGroup.ReadList(user, group.GroupId);
                teams.DisplayTeamUsers(userList, userGroups, user.UserId, this);
                teams.disableConclusion();
            }
            else
            {
                teams.enableConclusion(group.GroupId);
            }
        }
        private void pnlMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClickOn();
        }
        public void refreshTeamUsers(int test=0) // 1 for refresh userList otherwise 0 or nothing
        {
            List<User> userList = genericUser.ReadList(user, group.GroupId);
            List<UserGroup> userGroups = genericUserGroup.ReadList(user, group.GroupId);
            teams.DisplayTeams();
            if (test > 0)
            {
                teams.DisplayTeamUsers(userList, userGroups, user.UserId, this);
            }
            else
            {
                teams.ClearTeamUsers();
            }
            teams.disableConclusion();
        }
        private void lblDescription_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClickOn();
        }

        private void lblTeamName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClickOn();
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu();
        }
        private void ShowSubMenu()
        {
            ContextMenuStrip myMenu = new ContextMenuStrip();
            if (user.UserId == groupFounder.UserId)
            {
                myMenu.Items.Add("Edit", null, menuEdit_Click);
                myMenu.Items.Add("Close Team", null, menuClose_Click);
            }
            myMenu.Items.Add("Leave", null, menuLeave_Click);
            if(user.UserId == groupFounder.UserId)
            {

                myMenu.Items[2].Enabled = false;
            }
            
            myMenu.Show(pbMenu, new Point(-15, pbMenu.Height / 2 + 15));
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dou you want to close this team ?", "Close Team ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                group.GroupStatus = "Closed";
                group.GroupManagerId = 0;
                group.GroupFormationDate = DateTime.Now;
                genericGroup.Update(group);
                List<UserGroup> userGroups = genericUserGroup.ReadList(user, group.GroupId);
                for(int i= userGroups.Count-1 ;i>=0 ;i--)
                {
                    UserGroup userGroupInfo = userGroups[i];
                    userGroupInfo.UserGroupAuthorization = 0;
                    userGroupInfo.ProcessDate = DateTime.Now;
                    userGroupInfo.InviteSenderId = user.UserId;
                    userGroupInfo.InviteStatus = "Kicked";
                    genericUserGroup.Update(userGroupInfo);
                }

                refreshTeamUsers();
            }
            else
            {
                MessageBox.Show("Cancelled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            Form popupForm = new PopupEditTeam(group,user,teams);
            popupForm.ShowDialog();
        }

        private void menuLeave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dou you want to leave this team ?","Leave Team ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                UserGroup userGroupInfo = new UserGroup() { GroupId = group.GroupId, UserId = user.UserId };
                userGroupInfo = genericUserGroup.ReadById(userGroupInfo);
                userGroupInfo.UserGroupAuthorization = 0;
                userGroupInfo.ProcessDate = DateTime.Now;
                userGroupInfo.InviteStatus = "Left";
                if (genericUserGroup.Update(userGroupInfo))
                {
                    MessageBox.Show("You have left the team", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshTeamUsers(0);
                }
                else
                {
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Cancelled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblTeamName_Click(object sender, EventArgs e)
        {
            ClickOn();
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
            ClickOn();
        }

        private void lblTeamLeaderMail_Click(object sender, EventArgs e)
        {
            ClickOn();
        }

        private void lblTaskProjectCount_Click(object sender, EventArgs e)
        {
            ClickOn();
        }
    }
}
