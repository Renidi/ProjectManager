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
        User user = new User();
        UserGroup userGroup = new UserGroup();
        GenericSqlHelper<UserGroup> genericUserGroup = new GenericSqlHelper<UserGroup>();
        List<UserGroup> groups = new List<UserGroup>();
        public int btnGroupId;

        public Teams(int userId)
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserMouse | ControlStyles.Selectable, true);
            user.UserId = userId;
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
            pnlTeams.AutoScroll = false;
            groups = genericUserGroup.ReadList(user);
            foreach (UserGroup inGroup in groups)
            {
                if (inGroup.UserGroupAuthorization>0)
                {
                    TeamControl teamControl = new TeamControl(inGroup, this, user.UserId);
                    pnlTeams.Controls.Add(teamControl);
                }else
                {
                    TeamControl teamControl = new TeamControl(inGroup, this, user.UserId);
                    pnlRequests.Controls.Add(teamControl);
                }
                
            }
            pnlTeams.AutoScroll = true;
        }
        
        public void DisplayTeamUsers(List<User> userList,List<UserGroup> userGroupInfo,int authLevel)
        {
            pnlMemebers.Controls.Clear();
            pnlRequests.Controls.Clear();
            pnlMemebers.AutoScroll = false;
            for (int i = 0; i < userList.Count; i++)
            {
                user = userList[i]; 
                userGroup = userGroupInfo[i];
                UserControlTeams userControlTeams = new UserControlTeams(userGroup,user,authLevel);
                pnlMemebers.Controls.Add(userControlTeams);
            }
            pnlMemebers.AutoScroll=true;

        }

        private void btnNewTeam_Click(object sender, EventArgs e)
        {
            Form popUpForm = new PopupCreateTeam(user.UserId,this);
            popUpForm.ShowDialog();

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Form popUpInviteMember = new PopupAddMembeer(user,groups);
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
                MessageBox.Show("Joined Team");

            }
            else
            {
                MessageBox.Show("Error");
            }
            DisplayTeams();
        }

        private void btnRejectRequest_Click(object sender, EventArgs e)
        {

        }
    }
}
