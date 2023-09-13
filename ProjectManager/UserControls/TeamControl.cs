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
    public partial class TeamControl : UserControl
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
        public TeamControl(UserGroup x, Teams formTeams,int userId)
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
            lblTeamLeaderMail.Text = "Team Leader: " + groupFounder.UserMail;
            var counter = genericUser.GetProjectAndTaskCounts(group.GroupId);
            lblTaskProjectCount.Text = counter.Item1 + " Project , " + counter.Item2 + " Task";

            lblDescription.AutoSize = true;
            lblDescription.Text = group.GroupDescription;
            lblDescription.AutoSize = false;
        }

        private void lblDescription_TextChanged(object sender, EventArgs e)
        {
            lblDescription.Size = lblDescription.PreferredSize;
            AdjustFormSize();
        }
        private void AdjustFormSize()
        {
            int desiredHeight = lblDescription.Height-20;
            Height += desiredHeight;
        }

        private void pnlMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (userGroup.UserGroupAuthorization>0)
            {
                List<User> userList = genericUser.ReadList(user, group.GroupId);
                List<UserGroup> userGroups = genericUserGroup.ReadList(user, group.GroupId);
                teams.DisplayTeamUsers(userList, userGroups, user.UserId,this);
                teams.disableConclusion();
            }
            else
            {
                teams.enableConclusion(group.GroupId);
            }
            
        }
        public void refreshTeamUsers(int test=0)
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
            pnlMain_MouseDoubleClick(sender, e);
        }

        private void lblTeamName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnlMain_MouseDoubleClick(sender, e);
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
            }
            myMenu.Items.Add("Leave", null, menuLeave_Click);
            if(user.UserId == groupFounder.UserId)
            {

                myMenu.Items[1].Enabled = false;
            }
            
            myMenu.Show(pbMenu, new Point(-15, pbMenu.Height / 2 + 15));
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            Form popupForm = new PopupEditTeam(group,user.UserId,teams);
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
                    MessageBox.Show("Ok");
                    refreshTeamUsers(0);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {

            }
        }
    }
}
