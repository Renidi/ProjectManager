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
            //lblProjectDescription.Text = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
            //                               "Etiam scelerisque erat vel varius malesuada. Donec pharetra, quam interdum scelerisque pharetra," +
            //                               " nunc mi imperdiet metus, eget ultrices dui mauris in mi. Pellentesque a erat nec ipsum congue iaculis a id ipsum." +
            //                               " Maecenas ut quam volutpat, luctus arcu eget, ornare diam. Duis eget vehicula dui. Vestibulum ac diam ultricies, " +
            //                               "facilisis nunc at, sodales elit. Integer et sollicitudin tortor, et facilisis urna. Donec faucibus pulvinar magna, " +
            //                               "a porttitor tellus condimentum eget. Donec a orci ac tellus mattis congue at eu orci. Mauris facilisis leo sit amet" +
            //                               " ante sagittis elementum. Sed tincidunt facilisis enim, ac aliquet nibh commodo eget. ";
            lblProjectName.Text = project.ProjectName;
            lblProjectDescription.Text = project.ProjectDescription;
            lblProjectDescription.MaximumSize = new Size(240, 0);
            lblProjectDescription.AutoSize = true;

            lblTaskCount.Text = sqlHelper.GetTaskCounts(project.ProjectId) + " Task";
            lblStartEndDate.Text = project.ProjectStartDate.ToString("dd/MM/yyyy") + " / " + project.ProjectEndDate.ToString("dd/MM/yyyy");
            Width = Math.Max(lblProjectName.Width, lblProjectDescription.Width)>245 ? Math.Max(lblProjectName.Width, lblProjectDescription.Width) : 245;
            Height = (lblProjectName.Height + lblProjectDescription.Height)>105 ? Math.Max(lblProjectName.Width, lblProjectDescription.Width) : 105;
        }

        private void ProjectControl_Load(object sender, EventArgs e)
        {

        }
    }
}
