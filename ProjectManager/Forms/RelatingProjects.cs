using ProjectManager.Entities;
using ProjectManager.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager.Forms
{
    public partial class RelatingProjects : Form
    {
        SqlDbHelper sqlDbHelper = new SqlDbHelper();
        Project project = new Project();
        User user = new User();
        Log log = new Log();
        Team team = new Team();
        Group group = new Group();
        public string Mail { get; set; }

        public int varId;
        public RelatingProjects(string userMail)
        {
            InitializeComponent();
            Mail = userMail;
        }

        private void RelatingProjects_Load(object sender, EventArgs e)
        {
            DisplayProjects();
            user.UserMail = Mail;
        }

        public void DisplayProjects()
        {
            pnlActive.Controls.Clear();
            pnlComplete.Controls.Clear();
            pnlOnHold.Controls.Clear();

            ProjectControl projectControl = new ProjectControl();
            pnlActive.Controls.Add(projectControl);

            var tempList1 = sqlDbHelper.TakeProjectList(user.UserMail,"ACTIVE");
            var tempList2 = sqlDbHelper.TakeProjectList(user.UserMail,"ON HOLD");
            var tempList3 = sqlDbHelper.TakeProjectList(user.UserMail,"CANCELLED");
            var tempList4 = sqlDbHelper.TakeProjectList(user.UserMail,"COMPLETED");

        }
    }
}
