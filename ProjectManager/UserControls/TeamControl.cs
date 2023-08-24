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
        SqlHelper sqlHelper = new SqlHelper();
        Project project = new Project();
        User user = new User();
        Log log = new Log();
        Group group = new Group();
        UserGroup userGroup = new UserGroup();
        public int getUserId { get; set; }
        private Teams teams;
        public TeamControl(UserGroup x, Teams formTeams,int userId)
        {
            InitializeComponent();
            userGroup = x;
            getUserId = userId;
            user = sqlHelper.GetUserInfo(getUserId);
            teams = formTeams;
        }

        private void TeamsControl_Load(object sender, EventArgs e)
        {
            user = sqlHelper.GetUserInfo(getUserId);
            group.GroupId = userGroup.GroupId;
            group = sqlHelper.GetGroupInfo(group.GroupId);

            user.UserId = group.GroupManagerId;
            user = sqlHelper.GetUserInfo(user.UserId);
            label1.Text = group.GroupName;
            label2.Text = "Team Leader: " + user.UserMail;
            var counter = sqlHelper.GetProjectAndTaskCounts(group.GroupId);
            label3.Text = counter.Item1+" Project , "+ counter.Item2 + " Task";
        }

        private void TeamControl_DoubleClick(object sender, EventArgs e)
        {
            List<User> userList = sqlHelper.GetUserList(user.UserId, group.GroupId);
            List<UserGroup> userGroups = sqlHelper.GetTeams(user.UserId, group.GroupId);
            teams.DisplayTeamUsers(userList,userGroups);
        }
    }
}
