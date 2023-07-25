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
        public string Mail { get; set; }
        public int varId;
        public Tasks(string mail)
        {
            Mail = mail;
            InitializeComponent();
        }
        private void Tasks_Load(object sender, EventArgs e)
        {
            dtTaskFinishDate.Value = DateTime.Now;
            user.UserMail = Mail;
            List<string> tempList = new List<string>();
            tempList = sqlDbHelper.TakeProjectsName("ProjectsTbl");

            for(int i=0; i<tempList.Count; i++)
            {
                cmbTaskProject.Items.Add(tempList[i]);
                
            }

            List<string> tempUserList = new List<string>();
            tempUserList = sqlDbHelper.TakeEmployeeMails();

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
            dgvActiveTasks.DataSource = sqlDbHelper.LoadData("TasksTbl",user.UserMail);
            dgvActiveTasks.Columns["Id"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            task.TaskName = txTaskName.Text;
            task.TaskStatus = cmbTaskStatus.Text;
            task.TaskPriority = cmbTaskPriority.Text;
            task.TaskStartDate = DateTime.Now;
            task.TaskFinishDate= dtTaskFinishDate.Value;
            task.TaskOwner = cmbTaskEmployee.Text;
            task.TaskProject = cmbTaskProject.Text;
            task.TaskDescription = txTaskComment.Text;

            DialogResult result = MessageBox.Show("Are you sure you want to add" + task.TaskName +" to tasks ?", "Add Task ", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sqlDbHelper.SaveTask(task);
                
                sqlDbHelper.DataLog(sqlDbHelper.Transmitter(task.TaskName, "TasksTbl", "Add", DateTime.Now.ToString(), "Task", user.UserMail, "2"));
            
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
            task.TaskFinishDate = dtTaskFinishDate.Value;
            task.TaskOwner = user.UserMail;
            task.TaskProject = cmbTaskProject.Text;
            task.TaskDescription = txTaskComment.Text;
            task.Id = varId;

            DialogResult result = MessageBox.Show("Are you sure edit " + task.TaskName, "Edit Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sqlDbHelper.EditTask(task);
                
                sqlDbHelper.DataLog(sqlDbHelper.Transmitter(task.TaskName, "TasksTbl", "Edit", DateTime.Now.ToString(), "Task", user.UserMail, "2"));
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
                sqlDbHelper.DataLog(sqlDbHelper.Transmitter(task.TaskName, "TasksTbl", "Delete", DateTime.Now.ToString(), "Task", user.UserMail, "2"));

                sqlDbHelper.Delete("TasksTbl", null, task);
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
            dtTaskFinishDate.Value = DateTime.Now;
        }

        bool CheckTask(Task task)
        {
            

            return false;
        }

        private void dgvActiveTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                task.TaskName = txTaskName.Text = dgvActiveTasks.SelectedRows[0].Cells[1].Value.ToString();
                task.TaskOwner = cmbTaskEmployee.Text = dgvActiveTasks.Rows[0].Cells[6].Value.ToString();
                task.TaskStatus = cmbTaskStatus.Text = dgvActiveTasks.SelectedRows[0].Cells[2].Value.ToString();
                task.TaskPriority = cmbTaskPriority.Text = dgvActiveTasks.SelectedRows[0].Cells[3].Value.ToString();
                task.TaskFinishDate = dtTaskFinishDate.Value = Convert.ToDateTime(dgvActiveTasks.SelectedRows[0].Cells[5].Value);
                task.TaskProject = cmbTaskProject.Text = dgvActiveTasks.SelectedRows[0].Cells[7].Value.ToString();
                task.TaskDescription = txTaskComment.Text = dgvActiveTasks.SelectedRows[0].Cells[8].Value.ToString();
                task.Id = varId = Convert.ToInt32(dgvActiveTasks.SelectedRows[0].Cells[0].Value);
            }
            catch{ }
  
            
        }

    }

}
