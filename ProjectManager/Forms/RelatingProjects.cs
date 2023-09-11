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
        User user = new User();
        public RelatingProjects(int userId)
        {
            InitializeComponent();
            user.UserId = userId;
        }
        private void RelatingProjects_Load(object sender, EventArgs e)
        {
            GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
            user = genericUser.ReadById(user);
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
            pnlCancelled.Controls.Clear();
        }
        void FillPanel()
        {
            ClearPanels();
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
            GenericSqlHelper<Project> genericSqlHelper = new GenericSqlHelper<Project>();
            List<Project> projectList = genericSqlHelper.ReadList(user);

            for(int i = 0; i<projectList.Count; i++)
            {
                Project project = projectList[i];
                if(project.ProjectStatus == statusList[0])
                {
                    ProjectControl projectControl = new ProjectControl(project);
                    pnlList[0].Controls.Add(projectControl);
                }
                else if (project.ProjectStatus == statusList[1])
                {
                    ProjectControl projectControl = new ProjectControl(project);
                    pnlList[1].Controls.Add(projectControl);
                }
                else if (project.ProjectStatus == statusList[2])
                {
                    ProjectControl projectControl = new ProjectControl(project);
                    pnlList[2].Controls.Add(projectControl);
                }
                else
                {
                    ProjectControl projectControl = new ProjectControl(project);
                    pnlList[3].Controls.Add(projectControl);
                }
            }
        }
    }
}
