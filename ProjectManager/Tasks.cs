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
            dtTaskStartDate.Value = DateTime.Now;
            dtTaskFinishDate.Value = DateTime.Now;
            user.UserMail = Mail;
            List<string> tempList = new List<string>();
            tempList = sqlDbHelper.TakeProjectsName();

            for(int i=0; i<tempList.Count; i++)
            {
                cmbTaskProject.Items.Add(tempList[i]);
                
            }
            
            cmbTaskProject.StartIndex = 0;
            DoubleBuffered = true;
            Dt();
        }
        private void Dt()
        {
            dgvActiveTasks.DataSource = sqlDbHelper.LoadData("TasksTbl",user.UserMail);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            task.TaskName = txTaskName.Text;
            task.TaskStatus = cmbTaskStatus.Text;
            task.TaskPriority = cmbTaskPriority.Text;
            task.TaskFinishDate= dtTaskFinishDate.Value;
            task.TaskOwner = user.UserMail;
            task.TaskProject = cmbTaskProject.Text;
            task.TaskDescription = txTaskComment.Text;

            sqlDbHelper.SaveTask(task);
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
            sqlDbHelper.EditTask(task);
            Dt() ;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlDbHelper.Delete("TasksTbl", null ,task);
            Dt() ;
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
            dtTaskStartDate.Value = DateTime.Now;
            dtTaskFinishDate.Value = DateTime.Now;
        }

        private void btnCommitComment_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelComment_Click(object sender, EventArgs e)
        {
            //txTaskComment.Text
        }

        private void dgvActiveTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            task.TaskName =txTaskName.Text = dgvActiveTasks.SelectedRows[0].Cells[1].Value.ToString();
            task.TaskStatus = cmbTaskStatus.Text = dgvActiveTasks.SelectedRows[0].Cells[2].Value.ToString();
            task.TaskPriority = cmbTaskPriority.Text = dgvActiveTasks.SelectedRows[0].Cells[3].Value.ToString();
            task.TaskStartDate = dtTaskStartDate.Value = Convert.ToDateTime(dgvActiveTasks.SelectedRows[0].Cells[4].Value);
            task.TaskFinishDate = dtTaskFinishDate.Value = Convert.ToDateTime(dgvActiveTasks.SelectedRows[0].Cells[5].Value);
            task.TaskProject = cmbTaskProject.Text = dgvActiveTasks.SelectedRows[0].Cells[7].Value.ToString();
            task.TaskDescription = txTaskComment.Text = dgvActiveTasks.SelectedRows[0].Cells[8].Value.ToString();
            task.Id = varId = Convert.ToInt32(dgvActiveTasks.SelectedRows[0].Cells[0].Value);
        }

    }

}
