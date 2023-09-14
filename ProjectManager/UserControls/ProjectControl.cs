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

namespace ProjectManager.UserControls
{
    public partial class ProjectControl : UserControl
    {
        User user;
        Projects frmProjects;
        Project project;
        GenericSqlHelper<Project> genericProject = new GenericSqlHelper<Project>();
        GenericSqlHelper<Log> genericLog = new GenericSqlHelper<Log>();
        
        public ProjectControl(Project recProject,User recUser,Projects recProjects)
        {
            InitializeComponent();
            user = recUser; 
            project = recProject;
            frmProjects = recProjects;
            lblProjectName.Text = project.ProjectName;
            lblProjectDescription.Text = project.ProjectDescription;
            lblProjectDescription.MaximumSize = new Size(240, 0);
            lblProjectDescription.AutoSize = true;

            lblStartEndDate.Text = project.ProjectStartDate.ToString("dd/MM/yyyy") + " / " + project.ProjectEndDate.ToString("dd/MM/yyyy");
            Width = Math.Max(lblProjectName.Width, lblProjectDescription.Width)>245 ? Math.Max(lblProjectName.Width, lblProjectDescription.Width) : 245;
            Height = (lblProjectName.Height + lblProjectDescription.Height)>160 ? lblProjectDescription.Width-30 : 160;
        }
        private void ShowSubMenu()
        {
            ContextMenuStrip myMenu = new ContextMenuStrip();
            myMenu.Items.Add("Edit", null, menuEdit_Click);
            myMenu.Items.Add("Delete", null, menuDelete_Click);
            myMenu.Show(pbMenu, new Point(-15, pbMenu.Height / 2 + 15));
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete " + project.ProjectName +" ?", "Delete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Log log = new Log();
                log.LogSource = "Task";
                log.LogType = "Delete";
                log.LogDate = DateTime.Now;
                log.LogUser = user.UserMail;
                log.LogDescription = "Deleted " + project.ProjectName + " and Id : " + project.ProjectId;
                log.LogStatus = genericProject.Delete(project).ToString();
                genericLog.Create(log);
                this.Parent.Controls.Remove(this);
            }
            else
                MessageBox.Show("Cancelled");
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            frmProjects.PerformEditProject(project.ProjectId);
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu();
        }

    }
}
