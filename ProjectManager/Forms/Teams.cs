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
        SqlHelper sqlHelper = new SqlHelper();
        Project project = new Project();
        User user = new User();
        UserGroup userGroup = new UserGroup();  
        Log log = new Log();
        public string Mail { get; set; }
        public int varId;

        public Teams(string userMail)
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserMouse | ControlStyles.Selectable, true);
            Mail = userMail;
            user.UserMail = Mail;
            user = sqlHelper.GetUserInfo(-1, user.UserMail);
        }
        
        private void Teams_Load(object sender, EventArgs e)
        {
            DisplayTeams();
        }
        public void DisplayTeams()
        {
            pnlTeams.Controls.Clear();
            pnlTeams.AutoScroll = false;
            List<UserGroup> groups = sqlHelper.GetTeams(user.UserId);
            foreach (UserGroup inGroup in groups)
            {
                TeamControl teamControl = new TeamControl(inGroup,this,user.UserId);
                pnlTeams.Controls.Add(teamControl);
            }
            pnlTeams.AutoScroll = true;
        }
        
        public void DisplayTeamUsers(List<User> userList,List<UserGroup> userGroupInfo)
        {
            pnlMemebers.Controls.Clear();
            pnlMemebers.AutoScroll = false;
            for (int i = 0; i < userList.Count; i++)
            {
                user = userList[i]; 
                userGroup = userGroupInfo[i];
                UserControlTeams userControlTeams = new UserControlTeams(userGroup,user);
                pnlMemebers.Controls.Add(userControlTeams);
            }
            pnlMemebers.AutoScroll=true;

        }

        private void btnNewTeam_Click(object sender, EventArgs e)
        {
            Form popUpForm = new PopupCreateTeam(user.UserId,this);
            popUpForm.ShowDialog();

        }
    }
}
