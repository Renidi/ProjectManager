using ProjectManager.Entities;
using ProjectManager.Forms;
using ProjectManager.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace ProjectManager
{
    
    public partial class Teams : Form
    {
        User user;
        UserGroup userGroup = new UserGroup();
        GenericSqlHelper<UserGroup> genericUserGroup = new GenericSqlHelper<UserGroup>();
        List<UserGroup> groups = new List<UserGroup>();
        public int btnGroupId;

        public Teams(User recUser)
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserMouse | ControlStyles.Selectable, true);
            user = recUser;
            GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
            user = genericUser.ReadById(user);
        }
        
        private void Teams_Load(object sender, EventArgs e)
        {
            DisplayTeams();
        }
        public void DisplayTeams()
        {
            pnlTeams.Controls.Clear();
            pnlRequests.Controls.Clear();
            pnlTeams.AutoScroll = false;
            groups = genericUserGroup.ReadList(user).Where(r => (r.InviteStatus == "Accepted" || r.InviteStatus == "Waiting")).ToList();
            foreach (UserGroup inGroup in groups)
            {
                if (inGroup.UserGroupAuthorization>0)
                {
                    TeamCard teamControl = new TeamCard(inGroup, this, user.UserId);
                    pnlTeams.Controls.Add(teamControl);
                }else if(inGroup.InviteStatus == "Waiting")
                {
                    TeamCard teamControl = new TeamCard(inGroup, this, user.UserId);
                    pnlRequests.Controls.Add(teamControl);
                }
                
            }
            pnlTeams.AutoScroll = true;
        }
        
        public void DisplayTeamUsers(List<User> userList,List<UserGroup> userGroupInfo,int authUserId,TeamCard teamC)
        {
            pnlMemebers.Controls.Clear();
            pnlMemebers.AutoScroll = false;
            User newUser;
            UserGroup newUserGroup = new UserGroup();
            for (int i = 0; i < userList.Count; i++)
            {
                newUser = userList[i];
                foreach(UserGroup ugi in userGroupInfo)
                {
                    if(ugi.UserId == newUser.UserId)
                    {
                        newUserGroup = ugi;
                        break;
                    }
                }
                UserTeamCard userControlTeams = new UserTeamCard(newUserGroup,newUser,authUserId,teamC);
                pnlMemebers.Controls.Add(userControlTeams);
            }
            pnlMemebers.AutoScroll=true;

        }
        public void ClearTeamUsers()
        {
            pnlMemebers.Controls.Clear();
        }

        private void btnNewTeam_Click(object sender, EventArgs e)
        {
            Form popUpForm = new PopupCreateTeam(user,this);
            popUpForm.ShowDialog();

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Form popUpInviteMember = new PopupAddMember(user,groups);
            popUpInviteMember.ShowDialog();
        }
        public void enableConclusion(int groupID)
        {
            btnJoinRequest.Enabled = true;
            btnRejectRequest.Enabled = true;
            btnGroupId = groupID;
        }
        public void disableConclusion()
        {
            btnJoinRequest.Enabled = false;
            btnRejectRequest.Enabled = false;
        }

        private void btnJoinRequest_Click(object sender, EventArgs e)
        {
            UserGroup userGroupInfo = new UserGroup() {GroupId = btnGroupId , UserId=user.UserId};
            userGroupInfo = genericUserGroup.ReadById(userGroupInfo);
            userGroupInfo.UserGroupAuthorization = 1;
            userGroupInfo.ProcessDate = DateTime.Now;
            userGroupInfo.InviteStatus = "Accepted";
            if (genericUserGroup.Update(userGroupInfo))
            {
                MessageBox.Show("Joined Team", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DisplayTeams();
            disableConclusion();
        }

        private void btnRejectRequest_Click(object sender, EventArgs e)
        {
            UserGroup userGroupInfo = new UserGroup() { GroupId = btnGroupId, UserId = user.UserId };
            userGroupInfo = genericUserGroup.ReadById(userGroupInfo);
            userGroupInfo.ProcessDate = DateTime.Now;
            userGroupInfo.InviteStatus = "Rejected";
            if (genericUserGroup.Update(userGroupInfo))
                MessageBox.Show("Rejected Invite", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DisplayTeams();
            disableConclusion();
        }

    }
}
