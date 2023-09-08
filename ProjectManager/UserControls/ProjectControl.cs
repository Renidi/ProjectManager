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
        SqlHelper sqlHelper = new SqlHelper();
        public ProjectControl(Project project)
        {
            InitializeComponent();
            lblProjectName.Text = project.ProjectName;
            lblProjectDescription.Text = project.ProjectDescription;
            lblProjectDescription.MaximumSize = new Size(240, 0);
            lblProjectDescription.AutoSize = true;

            lblTaskCount.Text = sqlHelper.GetTaskCounts(project.ProjectId) + " Task";
            lblStartEndDate.Text = project.ProjectStartDate.ToString("dd/MM/yyyy") + " / " + project.ProjectEndDate.ToString("dd/MM/yyyy");
            Width = Math.Max(lblProjectName.Width, lblProjectDescription.Width)>245 ? Math.Max(lblProjectName.Width, lblProjectDescription.Width) : 245;
            Height = (lblProjectName.Height + lblProjectDescription.Height)>105 ? lblProjectDescription.Width-60 : 105;
        }

        private void ProjectControl_Load(object sender, EventArgs e)
        {

        }
    }
}
