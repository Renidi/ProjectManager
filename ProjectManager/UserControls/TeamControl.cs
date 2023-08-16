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
        SqlDbHelper sqlDbHelper = new SqlDbHelper();
        Project project = new Project();
        User user = new User();
        Log log = new Log();
        Team Team = new Team();
        Group group = new Group();
        private Teams teams;
        public TeamControl(Team x, Teams formTeams)
        {
            InitializeComponent();
            Team = x;
            teams = formTeams;
        }

        private void TeamsControl_Load(object sender, EventArgs e)
        {
            group.GroupId = Team.GroupId;
            group = sqlDbHelper.TakeInformationOfGroup(group);
            user.UserId = group.GroupManagerId;
            user = sqlDbHelper.UserInfo(user);
            label1.Text = group.GroupName;
            label2.Text = "Team Leader: " + user.UserMail;
            label3.Text = sqlDbHelper.GetCount("PROJECT",group.GroupId)+" Project , " + sqlDbHelper.GetCount("TASK", group.GroupId)+ " Task";
        }

        private void TeamControl_DoubleClick(object sender, EventArgs e)
        {
            List<User> userList = sqlDbHelper.TakeUserListForComboBox(group);
            List<UserGroup> userGroups = sqlDbHelper.TakeUserGroupInfo(userList,group.GroupId);
            teams.DisplayTeamUsers(userList,userGroups);
        }
    }
}
