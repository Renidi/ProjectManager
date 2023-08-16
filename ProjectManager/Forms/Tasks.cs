using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class Tasks : Form
    {
        SqlDbHelper sqlDbHelper = new SqlDbHelper();
        Project project = new Project();
        Task task = new Task();
        User user = new User();
        Log log = new Log();
        public string Mail { get; set; }
        public int varId;
        public Tasks(string mail)
        {
            Mail = mail;
            InitializeComponent();
        }
        private void Tasks_Load(object sender, EventArgs e)
        {
            dtTaskEndDate.Value = DateTime.Now;
            dtTaskStartDate.Value = DateTime.Now;
            user.UserMail = Mail;
            List<string> tempList = new List<string>();
            tempList = sqlDbHelper.TakeProjectsName("PROJECT");

            for(int i=0; i<tempList.Count; i++)
            {
                cmbTaskProject.Items.Add(tempList[i]);
                
            }

            List<string> tempUserList = sqlDbHelper.TakeEmployeeMails();

            for (int i = 0; i < tempUserList.Count; i++)
            {
                cmbTaskEmployee.Items.Add(tempUserList[i]);
            }

            cmbTaskProject.StartIndex = 0;
            DoubleBuffered = true;
            Dt();
        }
        private void Dt()
        {
            dgvActiveTasks.DataSource = sqlDbHelper.LoadData("TASK",user.UserMail);
            dgvActiveTasks.Columns["TASK_ID"].Visible = false;

            for(int i = 1; i < dgvActiveTasks.Columns.Count; i++)
            {
                dgvActiveTasks.Columns[i].HeaderText = dgvActiveTasks.Columns[i].HeaderText.Replace('_', ' ');
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            task.TaskName = txTaskName.Text;
            task.TaskStatus = cmbTaskStatus.Text;
            task.TaskPriority = cmbTaskPriority.Text;
            task.TaskStartDate = dtTaskStartDate.Value;
            task.TaskEndDate = dtTaskEndDate.Value;
            task.TaskDuration = Convert.ToInt32(Math.Ceiling((dtTaskEndDate.Value - dtTaskStartDate.Value).TotalDays));
            task.TaskOwner = cmbTaskEmployee.Text;
            task.TaskProject = cmbTaskProject.Text;
            task.TaskDescription = txTaskComment.Text;

            DialogResult result = MessageBox.Show("Are you sure you want to add" + task.TaskName+" to tasks ?", "Add Task ", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // sqlDbHelper.SaveTask(task);

                log.LogSource = "Task";
                log.LogType = "Save";
                log.LogDate = DateTime.Now;
                log.LogUser = user.UserMail;
                log.LogDescription = "Add " + task.TaskName + " and Id : " + task.TaskId;
                log.LogStatus = sqlDbHelper.SaveTask(task).ToString(); 

                sqlDbHelper.DataLog(log);
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
            task.TaskOwner = user.UserMail;
            task.TaskProject = cmbTaskProject.Text;
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
                log.LogStatus = sqlDbHelper.EditTask(task).ToString();

                sqlDbHelper.DataLog(log);
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
                log.LogStatus = sqlDbHelper.Delete("TASK",null,task).ToString();

                sqlDbHelper.DataLog(log);

                //sqlDbHelper.Delete("TASK", null, task);
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
                task.TaskName = txTaskName.Text = dgvActiveTasks.SelectedRows[0].Cells[1].Value.ToString();
                task.TaskOwner = cmbTaskEmployee.Text = dgvActiveTasks.Rows[0].Cells[6].Value.ToString();
                task.TaskStatus = cmbTaskStatus.Text = dgvActiveTasks.SelectedRows[0].Cells[2].Value.ToString();
                task.TaskPriority = cmbTaskPriority.Text = dgvActiveTasks.SelectedRows[0].Cells[3].Value.ToString();
                task.TaskEndDate = dtTaskEndDate.Value = Convert.ToDateTime(dgvActiveTasks.SelectedRows[0].Cells[5].Value);
                task.TaskProject = cmbTaskProject.Text = dgvActiveTasks.SelectedRows[0].Cells[7].Value.ToString();
                task.TaskDescription = txTaskComment.Text = dgvActiveTasks.SelectedRows[0].Cells[8].Value.ToString();
                task.TaskId = varId = Convert.ToInt32(dgvActiveTasks.SelectedRows[0].Cells[0].Value);
            }
            catch{ }
  
        }

        private void cmbTaskProject_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbTaskTeam.Items.Add("TAKIM"); // FROM DB PROJECT 
        }
    }

}
