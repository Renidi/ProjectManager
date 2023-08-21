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

namespace ProjectManager
{
    public partial class Projects : Form
    {
        SqlDbHelper sqlDbHelper = new SqlDbHelper();
        Project project = new Project();
        User user = new User();
        Log log = new Log();
        Team team = new Team();
        Group group = new Group();
        public string Mail { get; set; }

        public int varId;

        public Projects(string userMail)
        {
            InitializeComponent();
            Mail = userMail;
            openChildForm(new RelatingProjects(userMail));
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlActive.Controls.Add(childForm);
            pnlActive.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            this.DoubleBuffered = true;
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            // SHOW PROJECTS WITH USER CONTROL 
            user.UserMail = Mail;
            user = sqlDbHelper.UserInfo(user);

            List<Team> tempTeamList = sqlDbHelper.TakeTeams(user.UserId);
            for (int i = 0; i< tempTeamList.Count; i++)
            {
                group.GroupId = tempTeamList[i].GroupId;
                group = sqlDbHelper.TakeInformationOfGroup(group);

            }

        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            openChildForm(new RelatingProjects(user.UserMail));
        }

        private void btnMyProjects_Click(object sender, EventArgs e)
        {
            // !!??
            openChildForm(new RelatingProjects(user.UserMail));
            // !!??
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            openChildForm(new CreateProject(user.UserMail));
        }
    }
}
