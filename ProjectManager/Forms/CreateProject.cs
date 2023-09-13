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
        Project project = new Project();
        User user = new User();
        Log log = new Log();

        GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
        GenericSqlHelper<UserGroup> genericUserGroup = new GenericSqlHelper<UserGroup>();
        GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
        GenericSqlHelper<Project> genericProject = new GenericSqlHelper<Project>();
        GenericSqlHelper<Log> genericLog = new GenericSqlHelper<Log>();

        public int varId;
        public CreateProject(int userId)
        {
            InitializeComponent();
            user.UserId = userId;
            
            user = genericUser.ReadById(user);
        }
        private void CreateProject_Load(object sender, EventArgs e)
        {
            dtProjectStartDate.Value = DateTime.Now;
            dtProjectEndDate.Value = DateTime.Now;
            Group group = new Group();

            Dt();

            List<UserGroup> tempTeamList = genericUserGroup.ReadList(user);
            for (int i = 0; i < tempTeamList.Count; i++)
            {
                group.GroupId = tempTeamList[i].GroupId;
                group = genericGroup.ReadById(group);
                cmbTeam.Items.Add(group.GroupName);
                cmbProjectTeamIdHidden.Items.Add(group.GroupId);
            }
        }
        private void dgvActiveProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                project.ProjectId = Convert.ToInt32(dgvActiveProjects.SelectedRows[0].Cells[0].Value);
                project = genericProject.ReadById(project);
                txProjectName.Text = project.ProjectName;
                cmbProjectStatus.SelectedItem = project.ProjectStatus;
                cmbProjectPriority.SelectedItem = project.ProjectPriority;
                dtProjectStartDate.Value = project.ProjectStartDate;
                dtProjectEndDate.Value = project.ProjectEndDate;
                txProjectComment.Text = project.ProjectDescription;
                cmbProjectTeamIdHidden.SelectedItem = project.ProjectGroupId;
            }
            catch {  }
        }
        private void Dt()
        {
            
            dgvActiveProjects.DataSource = genericProject.ReadTable(user);
            
            if (dgvActiveProjects.Columns["PROJECT GROUP"]!=null)
                dgvActiveProjects.Columns["PROJECT GROUP"].DisplayIndex = 7;

            for (int i = 1; i < dgvActiveProjects.Columns.Count; i++)
            {
                dgvActiveProjects.Columns[i].HeaderText = dgvActiveProjects.Columns[i].HeaderText.Replace('_', ' ');
            }
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
            dtProjectStartDate.Value = DateTime.Now;
            dtProjectEndDate.Value = DateTime.Now;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txProjectName.Text !="")
            {
                project.ProjectName = txProjectName.Text;
                project.ProjectStatus = cmbProjectStatus.Text;
                project.ProjectPriority = cmbProjectPriority.Text;
                project.ProjectCreatorId = user.UserId;
                project.ProjectStartDate = dtProjectStartDate.Value;
                project.ProjectEndDate = dtProjectEndDate.Value;
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
                    //log.LogStatus = sqlHelper.NewProject(project).ToString();
                    GenericSqlHelper<Project> genericProject = new GenericSqlHelper<Project>();
                    log.LogStatus = genericProject.Create(project).ToString();

                    genericLog.Create(log);
                }
                else
                    MessageBox.Show("Cancelled");
                Dt();
            }
            else
            {
                MessageBox.Show("Missing Info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txProjectName.Text != "")
            {
                project.ProjectName = txProjectName.Text;
                project.ProjectStatus = cmbProjectStatus.Text;
                project.ProjectPriority = cmbProjectPriority.Text;
                project.ProjectEndDate = dtProjectEndDate.Value;
                project.ProjectDescription = txProjectComment.Text;
                project.ProjectId = varId;
                project.ProjectGroupId = cmbProjectTeamIdHidden.Text != "" ? Convert.ToInt32(cmbProjectTeamIdHidden.Text) : -1;

                DialogResult result = MessageBox.Show("Are you sure to edit " + project.ProjectName, "Edit Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    log.LogSource = "Project";
                    log.LogType = "Edit";
                    log.LogDate = DateTime.Now;
                    log.LogUser = user.UserMail;
                    log.LogDescription = "Changes on " + project.ProjectName + ", Id : " + project.ProjectId;
                    GenericSqlHelper<Project> genericProject = new GenericSqlHelper<Project>();
                    log.LogStatus = genericProject.Update(project).ToString();

                    genericLog.Create(log);
                }
                else
                    MessageBox.Show("Cancelled");

                Dt();
            }
            else
            {
                MessageBox.Show("Missing Info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (project.ProjectId !=0)
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
                    log.LogStatus = genericProject.Delete(project).ToString();
                    genericLog.Create(log);

                }
                else
                    MessageBox.Show("Cancelled");

                Dt();
            }
            else
            {
                MessageBox.Show("Select Project First");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmbTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbProjectTeamIdHidden.SelectedIndex = cmbTeam.SelectedIndex;
        }

        private void cmbProjectTeamIdHidden_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTeam.SelectedIndex = cmbProjectTeamIdHidden.SelectedIndex;
        }
    }
}
