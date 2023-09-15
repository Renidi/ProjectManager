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

        public int editId;
        public CreateProject(User recUser,int varEditId =0)
        {
            InitializeComponent();
            user = recUser;
            user = genericUser.ReadById(user);
            editId = varEditId;
        }
        private void CreateProject_Load(object sender, EventArgs e)
        {
            dtProjectStartDate.Value = DateTime.Now;
            dtProjectEndDate.Value = DateTime.Now;
            Group group = new Group();

            List<UserGroup> tempTeamList = genericUserGroup.ReadList(user).Where(r => r.InviteStatus == "Accepted").ToList();
            for (int i = 0; i < tempTeamList.Count; i++)
            {
                group.GroupId = tempTeamList[i].GroupId;
                group = genericGroup.ReadById(group);
                cmbTeam.Items.Add(group.GroupName);
                cmbProjectTeamIdHidden.Items.Add(group.GroupId);
            }
            lblStartEndDate.Text = dtProjectStartDate.Value.ToString("dd/MM/yyy") + " / " + dtProjectEndDate.Value.ToString("dd/MM/yy");
            lblPriority.Text = cmbProjectPriority.Text;
            lblProjectStatus.Text = cmbProjectStatus.Text;
            btnEdit.Enabled = editId>0;
            if (editId > 0)
            {
                project = new Project() { ProjectId = editId};
                project = genericProject.ReadById(project);
                txProjectName.Text = project.ProjectName;
                txProjectComment.Text = project.ProjectDescription;
                dtProjectStartDate.Value = project.ProjectStartDate;
                dtProjectEndDate.Value = project.ProjectEndDate;
                cmbProjectStatus.SelectedItem = project.ProjectStatus;
                cmbProjectPriority.SelectedItem = project.ProjectPriority;
                cmbProjectTeamIdHidden.SelectedItem = project.ProjectGroupId> 0 ? project.ProjectGroupId : -1;
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

                    log.LogSource = "Project";
                    log.LogType = "Save";
                    log.LogDate = DateTime.Now;
                    log.LogUser = user.UserMail;
                    log.LogDescription = "Add Project " + project.ProjectName;
                    GenericSqlHelper<Project> genericProject = new GenericSqlHelper<Project>();
                    log.LogStatus = genericProject.Create(project).ToString();

                    genericLog.Create(log);
                }
                else
                    MessageBox.Show("Cancelled", "Cancel" , MessageBoxButtons.OK);
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
                project.ProjectId = editId;
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
                    MessageBox.Show("Cancelled", "Cancel", MessageBoxButtons.OK);
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
                project.ProjectId = editId;

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
                    MessageBox.Show("Cancelled", "Cancel", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Select Project First","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmbTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbProjectTeamIdHidden.SelectedIndex = cmbTeam.SelectedIndex;
            lblProjectTeam.Text = cmbTeam.Text;
            if (cmbTeam.Text == "")
                lblProjectTeam.Text = "Project Team";
        }

        private void cmbProjectTeamIdHidden_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTeam.SelectedIndex = cmbProjectTeamIdHidden.SelectedIndex;
        }

        private void txProjectName_TextChanged(object sender, EventArgs e)
        {
            lblProjectName.Text = txProjectName.Text;
            if (txProjectName.Text.Trim() == "")
                lblProjectName.Text = "Project Name";
        }

        private void dtProjectStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblStartEndDate.Text = dtProjectStartDate.Value.ToString("dd/MM/yyy") + " / " + dtProjectEndDate.Value.ToString("dd/MM/yy");
        }

        private void dtProjectEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblStartEndDate.Text = dtProjectStartDate.Value.ToString("dd/MM/yyy") + " / " + dtProjectEndDate.Value.ToString("dd/MM/yy");
        }

        private void cmbProjectStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            lblProjectStatus.Text = cmbProjectStatus.Text;
        }

        private void cmbProjectPriority_SelectedValueChanged(object sender, EventArgs e)
        {
            lblPriority.Text = cmbProjectPriority.Text;
        }

        private void txProjectComment_TextChanged(object sender, EventArgs e)
        {
            lblProjectDescription.Text = txProjectComment.Text;
            if (txProjectComment.Text.Trim() == "")
                lblProjectDescription.Text = "Project Description";

            pnlMainProject.Height = (lblProjectName.Height + lblProjectDescription.Height + pnlProjectBottom.Height) > 180 ? (lblProjectName.Height + lblProjectDescription.Height + pnlProjectBottom.Height) : 180;
            pnlMainProject.Height = pnlMainProject.Height > 366 ? 366 : pnlMainProject.Height;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            cmbProjectTeamIdHidden.SelectedIndex = -1;
            cmbTeam.SelectedIndex = -1;
        }

        private void txProjectComment_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 500;
            if(txProjectComment.Text.Length > maxLength)
                e.Handled = true;
        }
    }
}
