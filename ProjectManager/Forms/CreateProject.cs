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

namespace ProjectManager.Forms
{
    public partial class CreateProject : Form
    {
        SqlHelper sqlHelper = new SqlHelper();
        Project project = new Project();
        User user = new User();
        Log log = new Log();
        Group group = new Group();
        public string Mail { get; set; }

        public int varId;

        public CreateProject(string userMail)
        {
            InitializeComponent();
            Mail = userMail;
        }
        private void CreateProject_Load(object sender, EventArgs e)
        {
            dtProjectStartDate.Value = DateTime.Now;
            dtProjectEndDate.Value = DateTime.Now;

            user.UserMail = Mail;
            user = sqlHelper.GetUserInfo(-1,user.UserMail);
            Dt();

            List<UserGroup> tempTeamList = sqlHelper.GetTeams(user.UserId);
            for (int i = 0; i < tempTeamList.Count; i++)
            {
                group.GroupId = tempTeamList[i].GroupId;
                group = sqlHelper.GetGroupInfo(group.GroupId);
                cmbTeam.Items.Add(group.GroupName);
                cmbProjectTeamIdHidden.Items.Add(group.GroupId);
            }
        }
        private void dgvActiveProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                varId = Convert.ToInt32(dgvActiveProjects.SelectedRows[0].Cells[0].Value);
                project = sqlHelper.GetProjectInfo(varId);

                txProjectName.Text = project.ProjectName;
                cmbProjectStatus.SelectedItem = project.ProjectStatus;
                cmbProjectPriority.SelectedItem = project.ProjectPriority;
                dtProjectStartDate.Value = project.ProjectStartDate;
                dtProjectEndDate.Value = project.ProjectEndDate;
                txProjectComment.Text = project.ProjectDescription;
            }
            catch { }
        }
        private void Dt()
        {
            dgvActiveProjects.DataSource = sqlHelper.GetDataTable("PROJECT",user.UserId);
            if(dgvActiveProjects.Columns["PROJECT_ID"]!= null)
                dgvActiveProjects.Columns["PROJECT_ID"].Visible = false;
            if(dgvActiveProjects.Columns["PROJECT_GROUP_ID"]!=null)
                dgvActiveProjects.Columns["PROJECT_GROUP_ID"].Visible = false;
            if(dgvActiveProjects.Columns["PROJECT GROUP"]!=null)
                dgvActiveProjects.Columns["PROJECT GROUP"].DisplayIndex = 7;

            for (int i = 1; i < dgvActiveProjects.Columns.Count; i++)
            {
                dgvActiveProjects.Columns[i].HeaderText = dgvActiveProjects.Columns[i].HeaderText.Replace('_', ' ');
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            project.ProjectName = txProjectName.Text;
            project.ProjectStatus = cmbProjectStatus.Text;
            project.ProjectPriority = cmbProjectPriority.Text;
            project.ProjectCreatorId = user.UserId;
            project.ProjectStartDate = dtProjectStartDate.Value;
            project.ProjectEndDate = dtProjectEndDate.Value;
            project.ProjectDuration = Convert.ToInt32(Math.Ceiling((dtProjectEndDate.Value - dtProjectStartDate.Value).TotalDays)); // Düzenlenecek
            project.ProjectDescription = txProjectComment.Text;
            project.ProjectGroupId = cmbProjectTeamIdHidden.Text != "" ? Convert.ToInt32(cmbProjectTeamIdHidden.Text) : -1; 
            
            DialogResult result = MessageBox.Show("Are you sure to add " + project.ProjectName, "Add Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // sqlDbHelper.SaveProject(project) to 61

                log.LogSource = "Project";
                log.LogType = "Save";
                log.LogDate = DateTime.Now;
                log.LogUser = user.UserMail;
                log.LogDescription = "Add Project " + project.ProjectName;
                log.LogStatus = sqlHelper.NewProject(project).ToString();

                sqlHelper.DataLog(log);
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
            project.ProjectEndDate = dtProjectEndDate.Value;
            project.ProjectDuration = Convert.ToInt32(Math.Ceiling((dtProjectEndDate.Value - dtProjectStartDate.Value).TotalDays));  // Değişecek mantığı
            project.ProjectDescription = txProjectComment.Text;
            project.ProjectId = varId;
            project.ProjectGroupId = Convert.ToInt32(cmbProjectTeamIdHidden.Text);

            DialogResult result = MessageBox.Show("Are you sure to edit " + project.ProjectName, "Edit Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                log.LogSource = "Project";
                log.LogType = "Edit";
                log.LogDate = DateTime.Now;
                log.LogUser = user.UserMail;
                log.LogDescription = "Changes on " + project.ProjectName + ", Id : " + project.ProjectId;
                log.LogStatus = sqlHelper.EditData(project).ToString();

                // sqlDbHelper.EditProject(project);
                sqlHelper.DataLog(log);
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
            project.ProjectCreatorId = user.UserId;
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
                log.LogStatus = sqlHelper.DeleteData("PROJECT", project.ProjectId).ToString();

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

        private void cmbTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbProjectTeamIdHidden.SelectedIndex = cmbTeam.SelectedIndex;
        }
    }
}
