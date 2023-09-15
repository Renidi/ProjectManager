using ProjectManager.Entities;
using ProjectManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        User user = new User();
        User taskOwner = new User();
        Log log = new Log();
        GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
        GenericSqlHelper<Task> genericTask = new GenericSqlHelper<Task>();
        GenericSqlHelper<Log> genericLog = new GenericSqlHelper<Log>();
        Tasks frmTasks;
        public TaskCard(Task taskInfo,int userId,Tasks frmTask)
        {
            frmTasks = frmTask;
            user.UserId = userId;
            user = genericUser.ReadById(user);
            InitializeComponent();
            task = taskInfo;
            lblProjectName.Text = task.TaskName;
            lblContent.Text = task.TaskDescription;
            GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
            Group group = new Group() { GroupId = task.TaskGroupId };
            group = task.TaskGroupId != 0 ? genericGroup.ReadById(group) : group;
            taskOwner.UserId = task.TaskOwnerId;
            taskOwner = genericUser.ReadById(taskOwner);
            lblTaskOwner.Text = taskOwner.UserMail;
            lblProjectGroupName.Text = group.GroupName==null ? taskOwner.UserMail : group.GroupName + " - " + taskOwner.UserMail;
            lblTaskDate.Text = task.TaskStartDate.ToString("dd/M/yyyy", CultureInfo.InvariantCulture) +  " - " + task.TaskEndDate.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
            task.TaskBadges = task.TaskBadges == null || task.TaskBadges == "" ? ConvertToTagName(task.TaskPriority) : ConvertToTagName(task.TaskPriority) + ", " + task.TaskBadges; 
            if (task.TaskBadges != null)
            {
                int badgeSpacing = 5;
                int xPosition = 0;
                int yPosition = 0;
                int panelWidth = 210;
                int panelHeight = 42;
                List<string> badgeNames = new List<string>(task.TaskBadges.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)) ;
                
                foreach (string badgeName in badgeNames)
                {
                    TaskBadges badgeControl = new TaskBadges(badgeName);
                    pnlTop.Controls.Add(badgeControl);
                    if(xPosition+badgeControl.Width + badgeSpacing > panelWidth)
                    {
                        xPosition = 0;
                        yPosition += badgeControl.Height + badgeSpacing;
                    }
                    badgeControl.Location = new Point(xPosition, yPosition);
                    pnlBadge.Controls.Add(badgeControl);
                    xPosition += badgeControl.Width + badgeSpacing;
                    if (yPosition + badgeControl.Height > panelHeight)
                    {
                        panelHeight += badgeControl.Height + badgeSpacing;
                        pnlBadge.Height = panelHeight;
                        pnlTop.Height = panelHeight;
                    }
                    
                }
                Height += panelHeight + 100;

                Width = 260;
                Height = (lblProjectName.Height + lblContent.Height + pnlTop.Height) > 105 ? lblContent.Height + lblProjectName.Height + pnlTop.Height - 125 : 200;
            }
            else
            {
                Width = 260;
                Height = (lblProjectName.Height + lblContent.Height + pnlTop.Height) > 105 ? lblContent.Height + lblProjectName.Height + pnlTop.Height - 125 : 200;
            }
            
        }
        private void ShowSubMenu()
        {
            ContextMenuStrip myMenu = new ContextMenuStrip();
            myMenu.Items.Add("Edit", null, menuEdit_Click);
            myMenu.Items.Add("Delete", null, menuDelete_Click);
            myMenu.Show(pbMenu, new Point(-15, pbMenu.Height / 2 + 15));
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu();
        }
        private void menuEdit_Click(object sender,EventArgs e)
        {
            frmTasks.PerformEditTask(task.TaskId);

        }
        private void menuDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete " + task.TaskName, "Delete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {   
                log.LogSource = "Task";
                log.LogType = "Delete";
                log.LogDate = DateTime.Now;
                log.LogUser = user.UserMail;
                log.LogDescription = "Deleted " + task.TaskName + " and Id : " + task.TaskId;
                log.LogStatus = genericTask.Delete(task).ToString();
                genericLog.Create(log);
                this.Parent.Controls.Remove(this);
            }
            else
                MessageBox.Show("Cancelled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
        private string ConvertToTagName(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            string firstLetter = char.ToUpper(input[0]).ToString();
            string rest = input.Substring(1).ToLower().Replace("ı", "i");
            return firstLetter + rest;
        }

    }
}
