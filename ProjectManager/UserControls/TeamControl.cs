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
            User groupFounder = new User(){ UserId = group.GroupManagerId };
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
                teams.DisplayTeamUsers(userList, userGroups, userGroup.UserGroupAuthorization);
                teams.disableConclusion();
            }
            else
            {
                teams.enableConclusion(group.GroupId);
            }
            
        }

        private void lblDescription_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnlMain_MouseDoubleClick(sender, e);
        }

        private void lblTeamName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnlMain_MouseDoubleClick(sender, e);
        }
    }
}
