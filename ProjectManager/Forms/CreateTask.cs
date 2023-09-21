using ProjectManager.Entities;
using ProjectManager.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProjectManager.Forms
{
    public partial class CreateTask : Form
    {
        User user;
        User taskOwner = new User();
        Task task = new Task();
        Project project = new Project();
        Log log = new Log();
        List<User> users = new List<User>();
        List<Project> projectList = new List<Project>();
        GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
        GenericSqlHelper<Project> genericProject = new GenericSqlHelper<Project>();
        GenericSqlHelper<Task> genericTask = new GenericSqlHelper<Task>();
        public int editTaskId = 0; 
        public CreateTask(User recUser,int taskId=0)
        {
            InitializeComponent();
            user = recUser;
            
            user = genericUser.ReadById(user);
            editTaskId = taskId;
            task.TaskPriority = cmbTaskPriority.Text;
            ManageTags();
        }

        private void CreateTask_Load(object sender, EventArgs e)
        {   // Task Badges mechanic gonna be change 247
            dtTaskEndDate.Value = DateTime.Now;
            dtTaskStartDate.Value = DateTime.Now;
            users.Add(user);

            projectList = genericProject.ReadList(user);

            for (int i = 0; i < projectList.Count; i++)
            {
                cmbTaskProject.Items.Add(projectList[i].ProjectName);
            }
            cmbTaskEmployee.Items.Clear();
            users = genericUser.ReadList(user);
            users = users.GroupBy(user => user.UserId).Select(group => group.First()).ToList();
            for (int i = 0; i < users.Count; i++)
            {
                cmbTaskEmployee.Items.Add(users[i].UserMail);
            }
            task.TaskPriority = cmbTaskPriority.Text;
            task.TaskStatus = cmbTaskStatus.Text;
            DoubleBuffered = true;
            btnEdit.Enabled = editTaskId > 0;
            if (editTaskId > 0)
            {
                task.TaskId = editTaskId;
                task = genericTask.ReadById(task);
                project.ProjectId = task.TaskProjectId;
                project = genericProject.ReadById(project);
                taskOwner.UserId = task.TaskOwnerId;
                taskOwner = genericUser.ReadById(taskOwner);
                txTaskName.Text = task.TaskName;
                cmbTaskProject.Text = project.ProjectName;
                cmbTaskStatus.Text = task.TaskStatus;
                cmbTaskPriority.Text = task.TaskPriority;
                dtTaskStartDate.Value = task.TaskStartDate;
                dtTaskEndDate.Value = task.TaskEndDate;
                cmbTaskEmployee.Text = taskOwner.UserMail;
                txTaskComment.Text = task.TaskDescription;
                task.TaskBadges = task.TaskBadges == null || task.TaskBadges == "" ? ConvertToTagName(task.TaskPriority) : ConvertToTagName(task.TaskPriority) + ", " + task.TaskBadges;
                List<string> badgeNames = new List<string>(task.TaskBadges.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
                foreach (string badgeName in badgeNames)
                {
                    for (int i = 0; i < clb1.Items.Count; i++)
                    {
                        string listItem = clb1.Items[i].ToString();
                        if (listItem.ToLower().Trim() == badgeName.ToLower().Trim())
                        {
                            clb1.SetItemChecked(i, true);
                            break;
                        }
                    }
                    for (int i = 0; i < clb2.Items.Count; i++)
                    {
                        string listItem = clb2.Items[i].ToString();
                        if (listItem.ToLower().Trim() == badgeName.ToLower().Trim())
                        {
                            clb2.SetItemChecked(i, true);
                            break;
                        }
                    }
                }

                ManageTags();
            }
        }
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txTaskName.Text!="" && cmbTaskProject.SelectedIndex != -1 && cmbTaskEmployee.SelectedIndex != -1)
            {
                task.TaskName = txTaskName.Text;
                task.TaskStatus = cmbTaskStatus.Text;
                task.TaskPriority = cmbTaskPriority.Text;
                task.TaskStartDate = dtTaskStartDate.Value;
                task.TaskEndDate = dtTaskEndDate.Value;
                task.TaskOwnerId = users[cmbTaskEmployee.SelectedIndex].UserId;
                task.TaskProjectId = projectList[cmbTaskProject.SelectedIndex].ProjectId;
                task.TaskDescription = txTaskComment.Text;
                task.TaskGroupId = projectList[cmbTaskProject.SelectedIndex].ProjectGroupId;
                task.TaskBadges = string.Join(", ", clb1.CheckedItems.Cast<string>()) + string.Join(", ", clb2.CheckedItems.Cast<string>());

                DialogResult result = MessageBox.Show("Are you sure you want to add" + task.TaskName + " to tasks ?", "Add Task ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    log.LogSource = "Task";
                    log.LogType = "Save";
                    log.LogDate = DateTime.Now;
                    log.LogUser = user.UserMail;
                    log.LogDescription = "Add " + task.TaskName + " and Id : " + task.TaskId;
                    //log.LogStatus = sqlHelper.NewTask(task).ToString();
                    GenericSqlHelper<Task> genericSqlHelper = new GenericSqlHelper<Task>();
                    log.LogStatus = genericSqlHelper.Create(task).ToString();

                    GenericSqlHelper<Log> genericLog = new GenericSqlHelper<Log>();
                    genericLog.Create(log);
                }
            }
            else
            {
                if (txTaskName.Text == "")
                    MessageBox.Show("Task name field cannot be left blank","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else if (cmbTaskProject.SelectedIndex == -1)
                    MessageBox.Show("Task project is not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (cmbTaskEmployee.SelectedIndex == -1)
                    MessageBox.Show("Task owner not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txTaskName.Text != "" && cmbTaskProject.SelectedIndex != -1 && cmbTaskEmployee.SelectedIndex != -1)
            {
                task.TaskName = txTaskName.Text;
                task.TaskStatus = cmbTaskStatus.Text;
                task.TaskPriority = cmbTaskPriority.Text;
                task.TaskStartDate = dtTaskStartDate.Value;
                task.TaskEndDate = dtTaskEndDate.Value;
                task.TaskOwnerId = users[cmbTaskEmployee.SelectedIndex].UserId;
                task.TaskProjectId = projectList[cmbTaskProject.SelectedIndex].ProjectId;
                task.TaskDescription = txTaskComment.Text;
                task.TaskBadges = string.Join(", ", clb1.CheckedItems.Cast<string>()) + string.Join(", ", clb2.CheckedItems.Cast<string>());

                DialogResult result = MessageBox.Show("Are you sure edit " + task.TaskName, "Edit Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    log.LogSource = "Task";
                    log.LogType = "Edit";
                    log.LogDate = DateTime.Now;
                    log.LogUser = user.UserMail;
                    log.LogDescription = "Changes on " + task.TaskName + " and Id : " + task.TaskId;
                    GenericSqlHelper<Task> genericTask = new GenericSqlHelper<Task>();
                    log.LogStatus = genericTask.Update(task).ToString();

                    GenericSqlHelper<Log> genericLog = new GenericSqlHelper<Log>();
                    genericLog.Create(log);
                }
                else
                    MessageBox.Show("Cancelled","Warning",MessageBoxButtons.OK);

            }
            else
            {
                if (txTaskName.Text == "")
                    MessageBox.Show("Task name field cannot be left blank","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (cmbTaskProject.SelectedIndex == -1)
                    MessageBox.Show("Task project is not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (cmbTaskEmployee.SelectedIndex == -1)
                    MessageBox.Show("Task owner not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Unexpected Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            void func(Control.ControlCollection controls)
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
            }
            func(Controls);
            txTaskComment.Text = string.Empty;
            dtTaskEndDate.Value = DateTime.Now;
            dtTaskStartDate.Value = DateTime.Now;
            for(int i =0; i < clb1.Items.Count; i++)
            {
                clb1.SetItemChecked(i, false);
                clb2.SetItemChecked(i, false);
            }
        }

        private void cmbTaskProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTaskEmployee.Items.Clear();
            users.Clear();
            cmbTaskTeam.Items.Clear();
            GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
            Group groupInfo = new Group() { GroupId = projectList[cmbTaskProject.SelectedIndex].ProjectGroupId };
            groupInfo = genericGroup.ReadById(groupInfo);
            if (groupInfo.GroupId != 0)
            {
                cmbTaskTeam.Items.Add(groupInfo.GroupName);
                cmbTaskTeam.SelectedIndex = 0;
                GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();  
                users = genericUser.ReadList(user, projectList[cmbTaskProject.SelectedIndex].ProjectGroupId);
                users = users.GroupBy(x => x.UserId).Select(group => group.First()).ToList();
                for (int i = 0; i < users.Count; i++)
                {
                    cmbTaskEmployee.Items.Add(users[i].UserMail);
                }
            }
            else
                cmbTaskEmployee.Items.Add(user.UserMail);
                users.Add(user);
            lblTaskGroupName.Text = groupInfo.GroupName;
        }
             
        private void ManageTags()
        {   // Size problem
            List<string> startSelectedVal = new List<string>() { ConvertToTagName(task.TaskPriority) };
            for (int i = 0; i < clb1.Items.Count;i++)
            {
                string item = clb1.Items[i].ToString();
                if (clb1.GetItemChecked(i))
                    startSelectedVal.Add(item);
            }
            for (int i = 0; i < clb1.Items.Count; i++)
            {
                string item = clb2.Items[i].ToString();
                if (clb2.GetItemChecked(i))
                    startSelectedVal.Add(item);
            }
            string taskBadges = string.Join(",", startSelectedVal);
            pnlBadge.Controls.Clear();

            int badgeSpacing = 5;
            int panelWidth = pnlBadge.Width;
            int xPosition = 0;
            int yPosition = 0;
            int panelHeight = pnlBadge.Height;
            List<string> badgeNames = new List<string>(taskBadges.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));

            foreach (string badgeName in badgeNames)
            {
                TaskBadges badgeControl = new TaskBadges(badgeName);
                pnlTop.Controls.Add(badgeControl);
                if (xPosition + badgeControl.Width + badgeSpacing > panelWidth)
                {
                    xPosition = 0;
                    yPosition += badgeControl.Height + badgeSpacing;
                }
                badgeControl.Location = new Point(xPosition, yPosition);
                pnlBadge.Controls.Add(badgeControl);
                xPosition += badgeControl.Width + badgeSpacing;
                if (yPosition + badgeControl.Height > panelHeight+badgeSpacing)
                {
                    panelHeight += badgeControl.Height + badgeSpacing;
                    pnlBadge.Height = panelHeight;
                    pnlTop.Height = panelHeight;
                    pnlFill.Height += badgeControl.Height;
                }
                else if (panelHeight > badgeControl.Height + yPosition + badgeSpacing)
                {
                    panelHeight = badgeControl.Height + badgeSpacing;
                    pnlBadge.Height = panelHeight;
                    pnlTop.Height = panelHeight;
                    pnlFill.Height += badgeControl.Height;
                }

            }

            pnlFill.Height = (lblTaskName.Height + lblContent.Height + pnlTop.Height) > 246 ? (lblContent.Height + lblTaskName.Height + pnlTop.Height) -25 : 246;
        }
        private string ConvertToTagName(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            string firstLetter = char.ToUpper(input[0]).ToString();
            string rest = input.Substring(1).ToLower().Replace("ı", "i");
            return firstLetter + rest;
        }
        private void txTaskName_TextChanged(object sender, EventArgs e)
        {
            lblTaskName.Text = txTaskName.Text;
        }

        private void cmbTaskStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageTags();
        }

        private void cmbTaskPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            task.TaskPriority = cmbTaskPriority.Text;
            ManageTags();
        }

        private void dtTaskStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblTaskDate.Text = dtTaskStartDate.Value.ToString("dd/MM/yyy") + " / " + dtTaskEndDate.Value.ToString("dd/MM/yy");
        }

        private void dtTaskEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblTaskDate.Text = dtTaskStartDate.Value.ToString("dd/MM/yyy") + " / " + dtTaskEndDate.Value.ToString("dd/MM/yy");
        }

        private void txTaskComment_TextChanged(object sender, EventArgs e)
        {
            lblContent.Text = txTaskComment.Text;
        }

        private void cmbTaskEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTaskOwner.Text = cmbTaskEmployee.Text;
        }

        private void clb1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ManageTags();
        }

        private void clb2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ManageTags();
        }

        private void clb2_Click(object sender, EventArgs e)
        {
           ManageTags();
        }

        private void clb1_Click(object sender, EventArgs e)
        {
            ManageTags();
        }

        private void clb2_MouseEnter(object sender, EventArgs e)
        {
            ManageTags();
        }

        private void clb1_MouseEnter(object sender, EventArgs e)
        {
            ManageTags();
        }

    }
}
