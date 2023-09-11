using ProjectManager.Entities;
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
        User user = new User();
        Task task = new Task();
        Log log = new Log();
        List<User> users = new List<User>();
        List<Project> projectList = new List<Project>();
        public int editTaskId = 0; 
        public CreateTask(int userId,int taskId=0)
        {
            InitializeComponent();
            user.UserId = userId;
            GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
            user = genericUser.ReadById(user);
            editTaskId = taskId;
        }

        private void CreateTask_Load(object sender, EventArgs e)
        {
            dtTaskEndDate.Value = DateTime.Now;
            dtTaskStartDate.Value = DateTime.Now;

            GenericSqlHelper<Project> genericSqlProject = new GenericSqlHelper<Project>();
            projectList = genericSqlProject.ReadList(user);

            for (int i = 0; i < projectList.Count; i++)
            {
                cmbTaskProject.Items.Add(projectList[i].ProjectName);
            }

            GenericSqlHelper<User> genericSqlUser = new GenericSqlHelper<User>();
            users = genericSqlUser.ReadList(user);
            users = genericSqlUser.ReadList(user);
            for (int i = 0; i < users.Count; i++)
            {
                cmbTaskEmployee.Items.Add(users[i].UserMail);
            }

            DoubleBuffered = true;
            Dt();
            if (editTaskId > 0)
            {
                foreach (DataGridViewRow row in dgvActiveTasks.Rows)
                {
                    int rowId = Convert.ToInt32(row.Cells[0].Value);
                    if (rowId == editTaskId)
                    {
                        dgvActiveTasks.CurrentCell = dgvActiveTasks.Rows[row.Index].Cells[0];
                        dgvActiveTasks_CellContentClick(dgvActiveTasks, new DataGridViewCellEventArgs(0, row.Index));
                    }
                }
            }
        }

        private void dgvActiveTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                task.TaskId = Convert.ToInt32(dgvActiveTasks.SelectedRows[0].Cells[0].Value);
                GenericSqlHelper<Task> genericTask = new GenericSqlHelper<Task>();
                task = genericTask.ReadById(task);

                Project projectInfo = new Project() {ProjectId = task.TaskProjectId };
                User userInfo = new User() { UserId = task.TaskOwnerId };
                Group groupInfo = new Group();
                if (task.TaskGroupId > 0)
                {
                    groupInfo.GroupId = task.TaskGroupId;
                    GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
                    groupInfo = genericGroup.ReadById(groupInfo);
                }
                else
                {
                    groupInfo.GroupName = "No Group";
                }

                GenericSqlHelper<Project> genericProject = new GenericSqlHelper<Project>();
                projectInfo = genericProject.ReadById(projectInfo);
                GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
                userInfo = genericUser.ReadById(userInfo);
                
                txTaskName.Text = task.TaskName;
                cmbTaskStatus.Text = task.TaskStatus;
                dtTaskStartDate.Value = task.TaskStartDate;
                dtTaskEndDate.Value = task.TaskEndDate;
                cmbTaskProject.Text = projectInfo.ProjectName;
                cmbTaskEmployee.Text = userInfo.UserMail;
                cmbTaskTeam.Text = groupInfo.GroupName;
                cmbTaskPriority.Text = task.TaskPriority;
                txTaskComment.Text = task.TaskDescription;
                if(task.TaskBadges != null)
                {
                    for (int i = 0; i < clb1.Items.Count; i++)
                    {
                        string itemText = clb1.Items[i].ToString();
                        if (task.TaskBadges.Contains(itemText))
                        {
                            clb1.SetItemChecked(i, true);
                        }
                    }
                    for (int i = 0; i < clb2.Items.Count; i++)
                    {
                        string itemText = clb2.Items[i].ToString();
                        if (task.TaskBadges.Contains(itemText))
                        {
                            clb2.SetItemChecked(i, true);
                        }
                    }

                }


            }
            catch { }
        }
        private void Dt()
        {
            GenericSqlHelper<Task> genericTask = new GenericSqlHelper<Task>();
            dgvActiveTasks.DataSource = genericTask.ReadTable(user);
            for (int i = 0; i < dgvActiveTasks.Columns.Count; i++)
            {
                dgvActiveTasks.Columns[i].HeaderText = dgvActiveTasks.Columns[i].HeaderText.Replace('_', ' ');
            }
            dtTaskEndDate.Value = DateTime.Now;
            dtTaskStartDate.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            task.TaskBadges = string.Join(", ", clb1.CheckedItems.Cast<string>() ) + string.Join(", ", clb2.CheckedItems.Cast<string>());

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
            Dt();
        }
        private void btnEdit_Click(object sender, EventArgs e)
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
                MessageBox.Show("Cancelled");

            Dt();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete " + task.TaskName, "Delete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                log.LogSource = "Task";
                log.LogType = "Delete";
                log.LogDate = DateTime.Now;
                log.LogUser = user.UserMail;
                log.LogDescription = "Deleted " + task.TaskName + " and Id : " + task.TaskId;
                GenericSqlHelper<Task> genericTask = new GenericSqlHelper<Task>();
                log.LogStatus = genericTask.Delete(task).ToString();

                GenericSqlHelper<Log> genericLog = new GenericSqlHelper<Log>();
                genericLog.Create(log);
            }
            else
                MessageBox.Show("Cancelled");
            Dt();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
            txTaskComment.Text = string.Empty;
            dtTaskEndDate.Value = DateTime.Now;
            dtTaskStartDate.Value = DateTime.Now;
        }

        private void cmbTaskProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTaskEmployee.Items.Clear();
            users.Clear();
            cmbTaskTeam.Items.Clear();
            GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
            Group groupInfo = new Group() { GroupId = projectList[cmbTaskProject.SelectedIndex].ProjectGroupId };
            groupInfo = genericGroup.ReadById(groupInfo);
            if (groupInfo != null)
            {
                cmbTaskTeam.Items.Add(groupInfo.GroupName);
                cmbTaskTeam.SelectedIndex = 0;
                GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();  
                users = genericUser.ReadList(user, projectList[cmbTaskProject.SelectedIndex].ProjectGroupId);
                for (int i = 0; i < users.Count; i++)
                {
                    cmbTaskEmployee.Items.Add(users[i].UserMail);
                }
            }
            else
                cmbTaskEmployee.Items.Add(user.UserMail);
        }

    }
}
