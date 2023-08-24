﻿using ProjectManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class Tasks : Form
    {
        SqlHelper sqlHelper = new SqlHelper();
        User user = new User();
        Task task = new Task();
        Log log = new Log();

        List<Project> projectsList;
        List<User> userList;
        public string Mail { get; set; }
        public int varId;
        public Tasks(string mail)
        {
            Mail = mail;
            InitializeComponent();
        }
        private void Tasks_Load(object sender, EventArgs e)
        {
            user = sqlHelper.GetUserInfo(-1,Mail);
            projectsList = sqlHelper.GetProjects(user.UserId);

            for(int i=0; i<projectsList.Count; i++)
            {
                cmbTaskProject.Items.Add(projectsList[i].ProjectName);
            }

            userList = sqlHelper.GetUserList(user.UserId);
            for(int i =0; i<userList.Count; i++)
            {
                cmbTaskEmployee.Items.Add(userList[i].UserMail);
            }

            DoubleBuffered = true;
            Dt();
        }
        private void Dt()
        {
            dgvActiveTasks.DataSource = sqlHelper.GetDataTable("TASK", user.UserId);
            //dgvActiveTasks.Columns["TASK_ID"].Visible = false;

            for(int i = 1; i < dgvActiveTasks.Columns.Count; i++)
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
            task.TaskDuration = Convert.ToInt32(Math.Ceiling((dtTaskEndDate.Value - dtTaskStartDate.Value).TotalDays)); // Düzenlenecek total task süresini gösteriyor ama sadece kalan olacak ve db den silinecek
            task.TaskOwnerId = cmbTaskEmployee.SelectedIndex!= -1 ? userList[cmbTaskEmployee.SelectedIndex].UserId : user.UserId;
            task.TaskProjectId = projectsList[cmbTaskProject.SelectedIndex].ProjectId;
            task.TaskDescription = txTaskComment.Text;

            DialogResult result = MessageBox.Show("Are you sure you want to add" + task.TaskName+" to tasks ?", "Add Task ", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                log.LogSource = "Task";
                log.LogType = "Save";
                log.LogDate = DateTime.Now;
                log.LogUser = user.UserMail;
                log.LogDescription = "Add " + task.TaskName + " and Id : " + task.TaskId;
                log.LogStatus = sqlHelper.NewTask(task).ToString();

                sqlHelper.DataLog(log);
            }
            else
                MessageBox.Show("Cancelled");

            Dt();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            task.TaskName = txTaskName.Text;
            task.TaskStatus = cmbTaskStatus.Text;
            task.TaskPriority = cmbTaskPriority.Text;
            task.TaskStartDate = dtTaskStartDate.Value;
            task.TaskEndDate = dtTaskEndDate.Value;
            task.TaskDuration = Convert.ToInt32(Math.Ceiling((dtTaskEndDate.Value - dtTaskStartDate.Value).TotalDays));
            task.TaskOwnerId = userList[cmbTaskEmployee.SelectedIndex].UserId;
            task.TaskProjectId = projectsList[cmbTaskProject.SelectedIndex].ProjectId;
            task.TaskDescription = txTaskComment.Text;
            task.TaskId = varId;

            DialogResult result = MessageBox.Show("Are you sure edit " + task.TaskName, "Edit Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // sqlDbHelper.EditTask(task); to 111

                log.LogSource = "Task";
                log.LogType = "Edit";
                log.LogDate = DateTime.Now;
                log.LogUser = user.UserMail;
                log.LogDescription = "Changes on " + task.TaskName + " and Id : "+ task.TaskId;
                log.LogStatus = sqlHelper.EditData(null,task).ToString();

                sqlHelper.DataLog(log);
            }
            else
                MessageBox.Show("Cancelled");

            Dt();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete " + task.TaskName,"Delete Task",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                log.LogSource = "Task";
                log.LogType = "Delete";
                log.LogDate = DateTime.Now;
                log.LogUser = user.UserMail;
                log.LogDescription = "Deleted " + task.TaskName + " and Id : " + task.TaskId;
                log.LogStatus = sqlHelper.DeleteData("TASK",task.TaskId).ToString();

                sqlHelper.DataLog(log);
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

        private void dgvActiveTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                varId = Convert.ToInt32(dgvActiveTasks.SelectedRows[0].Cells[0].Value);
                task = sqlHelper.GetTaskInfo(varId);
                Project project = sqlHelper.GetProjectInfo(task.TaskProjectId);
                User user = sqlHelper.GetUserInfo(task.TaskOwnerId);
                Entities.Group group = sqlHelper.GetGroupInfo(task.TaskGroupId);

                txTaskName.Text = task.TaskName;
                cmbTaskStatus.Text = task.TaskStatus;
                dtTaskStartDate.Value = task.TaskStartDate;
                dtTaskEndDate.Value = task.TaskEndDate;
                cmbTaskProject.Text = project.ProjectName;
                cmbTaskEmployee.Text = user.UserName;
                cmbTaskTeam.Text = group.GroupName;

            }
            catch{ }
  
        }

        private void cmbTaskProject_SelectedValueChanged(object sender, EventArgs e)
        {
            userList.Clear();
            cmbTaskEmployee.Items.Clear();

            userList = sqlHelper.GetUserList(user.UserId, projectsList[cmbTaskProject.SelectedIndex].ProjectId);
            for (int i = 0; i < userList.Count; i++)
            {
                cmbTaskEmployee.Items.Add(userList[i].UserMail);
            }
        }

        private void cmbTaskProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SIKINTILI
            cmbTaskEmployee.Items.Clear();
            List<User> tempUserList = sqlHelper.GetUserList(user.UserId)!= null ? sqlHelper.GetUserList(user.UserId) : new List<User>();

            for (int i = 0; i < tempUserList.Count; i++)
            {
                cmbTaskEmployee.Items.Add(tempUserList[i].UserName);
            }
        }
    }

}
