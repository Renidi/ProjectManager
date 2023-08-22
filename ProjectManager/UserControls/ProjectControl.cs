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
            lblProjectDescription.MaximumSize = new Size(300, 0);
            lblProjectDescription.AutoSize = true;
            this.Width = 0; 
            this.Height = 0;

            this.Width = Math.Max(lblProjectName.Width, lblProjectDescription.Width);
            this.Height = lblProjectName.Height + lblProjectDescription.Height;
        }
    }
}
