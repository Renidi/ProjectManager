using ProjectManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager.UserControls
{
    public partial class TaskCard : UserControl
    {
        Task task = new Task();
        public TaskCard(Task taskInfo)
        {
            InitializeComponent();
            task = taskInfo;
            DoubleBuffered = true;
        }
        private void TaskCard_Load(object sender, EventArgs e)
        {
            lblProjectName.Text = task.TaskName;
            lblContent.Text = task.TaskDescription;
            GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
            Group group = new Group() { GroupId = task.TaskGroupId };
            group = task.TaskGroupId!=0 ? genericGroup.ReadById(group) : group;
            lblProjectGroupName.Text = group.GroupName ?? "No Group";
            lblProjectGroupName.Visible = false;

            Width = Math.Max(lblProjectName.Width, lblContent.Width) > 245 ? Math.Max(lblProjectName.Width, lblContent.Width) : 200;
            Height = (lblProjectName.Height + lblContent.Height) > 105 ? lblContent.Width - 60 : 200;
        }
        public void ShowSubMenu()
        {
            ContextMenuStrip myMenu = new ContextMenuStrip();
            myMenu.Items.Add("Edit", null, menuItem1_Click);
            myMenu.Items.Add("Delete", null, menuItem2_Click);
            myMenu.Items.Add("Assign", null, menuItem3_Click);
            myMenu.Show(pbMenu, new Point(-15, pbMenu.Height / 2 + 15));
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu();
        }

        private void menuItem1_Click(object sender,EventArgs e)
        {

        }
        private void menuItem2_Click(object sender, EventArgs e)
        {

        }
        private void menuItem3_Click(object sender, EventArgs e)
        {

        }

        private void lblContent_MouseEnter(object sender, EventArgs e)
        {
            lblProjectGroupName.Visible = true;
        }

        private void lblContent_MouseLeave(object sender, EventArgs e)
        {
            lblProjectGroupName.Visible = false;
        }
    }
}
