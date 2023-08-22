using ProjectManager.Entities;
using ProjectManager.UserControls;
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
    public partial class RelatingProjects : Form
    {
        SqlDbHelper sqlDbHelper = new SqlDbHelper();
        Project project = new Project();
        User user = new User();
        Log log = new Log();
        Team team = new Team();
        Group group = new Group();
        public string Mail { get; set; }

        public int varId;
        public RelatingProjects(string userMail)
        {
            InitializeComponent();
            Mail = userMail;
        }

        private void RelatingProjects_Load(object sender, EventArgs e)
        {
            user.UserMail = Mail;
            DisplayProjects();
        }

        public void DisplayProjects()
        {
            ClearPanels();
            FillPanel();
        }

        void ClearPanels()
        {
            pnlActive.Controls.Clear();
            pnlComplete.Controls.Clear();
            pnlOnHold.Controls.Clear();
        }

        void FillPanel()
        { // OR without group
            List<FlowLayoutPanel> pnlList = new List<FlowLayoutPanel>
            {
                pnlActive,
                pnlOnHold,
                pnlCancelled,
                pnlComplete
            };
            List<string> statusList = new List<string>
            {
                "ACTIVE",
                "ON HOLD",
                "CANCELLED",
                "COMPLETED"
            };

            for (int i = 0; i<pnlList.Count; i++)
            {
                var projectList = sqlDbHelper.TakeProjectList(user.UserMail, statusList[i]);
                foreach (var project in projectList)
                {
                    ProjectControl projectControl = new ProjectControl(project);
                    pnlList[i].Controls.Add(projectControl);
                }
            }
        }
    }
}
