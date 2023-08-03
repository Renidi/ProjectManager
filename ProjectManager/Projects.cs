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
    public partial class Projects : Form
    {
        SqlDbHelper sqlDbHelper = new SqlDbHelper();
        Project project = new Project();
        User user = new User();
        Log log = new Log();
        public string Mail { get; set; }

        public int varId;

        public Projects(string userMail)
        {
            InitializeComponent();

            Mail = userMail;
        }
        private void Projects_Load(object sender, EventArgs e)
        {
            dtProjectStartDate.Value = DateTime.Now;
            dtProjectEndDate.Value = DateTime.Now;

            user.UserMail = Mail;
            Dt();

        }
        
        private void Dt()
        {
            dgvActiveProjects.DataSource = sqlDbHelper.LoadData("PROJECT");
            dgvActiveProjects.Columns["PROJECT_ID"].Visible = false;
            for (int i = 1; i < dgvActiveProjects.Columns.Count; i++)
            {
                dgvActiveProjects.Columns[i].HeaderText = dgvActiveProjects.Columns[i].HeaderText.Replace('_', ' ');
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            project.ProjectName = txProjectName.Text;
            project.ProjectStatus = cmbProjectStatus.Text;
            project.ProjectPriority  = cmbProjectPriority.Text;
            project.ProjectCreator = user.UserMail;
            project.ProjectStartDate = dtProjectStartDate.Value;
            project.ProjectEndDate = dtProjectEndDate.Value;
            project.ProjectDuration = Convert.ToInt32(Math.Ceiling((dtProjectEndDate.Value - dtProjectStartDate.Value).TotalDays));
            project.ProjectDescription = txProjectComment.Text;

            DialogResult result = MessageBox.Show("Are you sure to add " + project.ProjectName,"Add Project",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // sqlDbHelper.SaveProject(project) to 61

                log.LogSource = "Project";
                log.LogType = "Save";
                log.LogDate = DateTime.Now;
                log.LogUser = user.UserMail;
                log.LogDescription= "Add Project " + project.ProjectName;
                log.LogStatus = sqlDbHelper.SaveProject(project).ToString() ;

                sqlDbHelper.DataLog(log);
            }
            else
                MessageBox.Show("Cancelled");
            Dt();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            project.ProjectName = txProjectName.Text;
            project.ProjectStatus = cmbProjectStatus.Text;
            project.ProjectPriority = cmbProjectPriority.Text;
            project.ProjectCreator = user.UserMail;
            project.ProjectEndDate= dtProjectEndDate.Value;
            project.ProjectDuration = Convert.ToInt32(Math.Ceiling((dtProjectEndDate.Value - dtProjectStartDate.Value).TotalDays));
            project.ProjectDescription = txProjectComment.Text;
            project.ProjectId= varId;

            DialogResult result = MessageBox.Show("Are you sure to edit " + project.ProjectName, "Edit Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                log.LogSource = "Project";
                log.LogType = "Edit";
                log.LogDate = DateTime.Now;
                log.LogUser = user.UserMail;
                log.LogDescription = "Changes on " + project.ProjectName + ", Id : " + project.ProjectId;
                log.LogStatus = sqlDbHelper.EditProject(project).ToString();

                // sqlDbHelper.EditProject(project);
                sqlDbHelper.DataLog(log);
            }
            else
                MessageBox.Show("Cancelled");

            Dt();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            project.ProjectName = txProjectName.Text;
            project.ProjectStatus = cmbProjectStatus.Text;
            project.ProjectPriority = cmbProjectPriority.Text;
            project.ProjectCreator = user.UserMail;
            project.ProjectEndDate = dtProjectEndDate.Value;
            project.ProjectId = varId;

            DialogResult result = MessageBox.Show("Are you sure to delete " + project.ProjectName, "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                log.LogSource = "Project";
                log.LogType = "Delete";
                log.LogDate = DateTime.Now;
                log.LogUser = user.UserMail;
                log.LogDescription = "Deleted " + project.ProjectName + ", Id : " + project.ProjectId;
                log.LogStatus = sqlDbHelper.Delete("PROJECT", project).ToString();

                sqlDbHelper.DataLog(log);
                
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
            dtProjectStartDate.Value = DateTime.Now;
            dtProjectEndDate.Value = DateTime.Now;
        }

        private void dgvActiveProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txProjectName.Text = dgvActiveProjects.SelectedRows[0].Cells[1].Value.ToString();
                cmbProjectStatus.SelectedItem = dgvActiveProjects.SelectedRows[0].Cells[2].Value.ToString();
                cmbProjectPriority.SelectedItem = dgvActiveProjects.SelectedRows[0].Cells[3].Value.ToString();
                dtProjectStartDate.Value = Convert.ToDateTime(dgvActiveProjects.SelectedRows[0].Cells[4].Value);
                dtProjectEndDate.Value = Convert.ToDateTime(dgvActiveProjects.SelectedRows[0].Cells[5].Value);
                txProjectComment.Text = dgvActiveProjects.SelectedRows[0].Cells[8].Value.ToString();
                varId = Convert.ToInt32(dgvActiveProjects.SelectedRows[0].Cells[0].Value);
            }
            catch { }


        }

    }
}
