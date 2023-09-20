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
        Projects frmProjects;
        GenericSqlHelper<Project> SqlHelper = new GenericSqlHelper<Project>();
        public RelatingProjects(User recUser,Projects recProjects)
        {
            InitializeComponent();
            user = recUser;
            frmProjects = recProjects;
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
        private void FillPanel()
        {
            ClearPanels();
            List<FlowLayoutPanel> pnlList = new List<FlowLayoutPanel>{pnlActive, pnlOnHold, pnlCancelled, pnlComplete};
            List<string> statusList = new List<string>{"ACTIVE", "ON HOLD", "CANCELLED", "COMPLETED"};
            List<Project> projectList = SqlHelper.ReadList(user);

            for(int i = 0; i<projectList.Count; i++)
            {
                Project project = projectList[i];
                if(project.ProjectStatus == statusList[0])
                {
                    ProjectCard projectControl = new ProjectCard(project,user,frmProjects);
                    pnlList[0].Controls.Add(projectControl);
                }
                else if (project.ProjectStatus == statusList[1])
                {
                    ProjectCard projectControl = new ProjectCard(project, user,frmProjects);
                    pnlList[1].Controls.Add(projectControl);
                }
                else if (project.ProjectStatus == statusList[2])
                {
                    ProjectCard projectControl = new ProjectCard(project, user,frmProjects);
                    pnlList[2].Controls.Add(projectControl);
                }
                else
                {
                    ProjectCard projectControl = new ProjectCard(project, user, frmProjects);
                    pnlList[3].Controls.Add(projectControl);
                }
            }
        }
    }
}
