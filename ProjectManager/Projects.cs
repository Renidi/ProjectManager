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
        public string Mail { get; set; }

        int varId;
        public Projects(string userMail)
        {
            InitializeComponent();

            Mail = userMail;
        }
        private void Projects_Load(object sender, EventArgs e)
        {
            dtProjectStartDate.Value = DateTime.Now;
            dtProjectFinishDate.Value = DateTime.Now;

            user.UserMail = Mail;
            DoubleBuffered = true;
            Dt();
        }
        
        private void Dt()
        {
            dgvActiveProjects.DataSource = sqlDbHelper.LoadData("ProjectsTbl");
            dgvActiveProjects.Columns["Id"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            project.ProjectName = txProjectName.Text;
            project.ProjectStatus = cmbProjectStatus.Text;
            project.ProjectPriority = cmbProjectPriority.Text;
            project.ProjectOwner = user.UserMail;
            project.ProjectFinishDate = dtProjectFinishDate.Value;
            DialogResult result = MessageBox.Show("Are you sure to add " + project.ProjectName,"Add Project",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sqlDbHelper.SaveProject(project);

                sqlDbHelper.DataLog(sqlDbHelper.Transmitter(project.ProjectName,"ProjectsTbl","Add", DateTime.Now.ToString(),"Project",user.UserMail,"2"));
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
            project.ProjectOwner = user.UserMail;
            project.ProjectFinishDate = dtProjectFinishDate.Value;
            project.Id = varId;

            DialogResult result = MessageBox.Show("Are you sure to edit " + project.ProjectName, "Edit Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sqlDbHelper.EditProject(project);
                sqlDbHelper.DataLog(sqlDbHelper.Transmitter(project.ProjectName, "ProjectsTbl", "Edit", DateTime.Now.ToString(), "Project", user.UserMail,"2"));
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
            project.ProjectOwner = user.UserMail;
            project.ProjectFinishDate = dtProjectFinishDate.Value;
            project.Id = varId;

            DialogResult result = MessageBox.Show("Are you sure to delete " + project.ProjectName, "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sqlDbHelper.DataLog(sqlDbHelper.Transmitter(project.ProjectName, "ProjectsTbl", "Delete", DateTime.Now.ToString(), "Project", user.UserMail, "2"));

                sqlDbHelper.Delete("ProjectsTbl", project);
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
            dtProjectFinishDate.Value = DateTime.Now;
        }

        private void dgvActiveProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txProjectName.Text = dgvActiveProjects.SelectedRows[0].Cells[1].Value.ToString();
                cmbProjectStatus.SelectedItem = dgvActiveProjects.SelectedRows[0].Cells[2].Value.ToString();
                cmbProjectPriority.SelectedItem = dgvActiveProjects.SelectedRows[0].Cells[3].Value.ToString();
                dtProjectStartDate.Value = Convert.ToDateTime(dgvActiveProjects.SelectedRows[0].Cells[4].Value);
                dtProjectFinishDate.Value = Convert.ToDateTime(dgvActiveProjects.SelectedRows[0].Cells[5].Value);
                varId = Convert.ToInt32(dgvActiveProjects.SelectedRows[0].Cells[0].Value);
            }
            catch { }


        }

    }
}
