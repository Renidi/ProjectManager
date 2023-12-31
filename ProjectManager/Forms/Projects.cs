﻿using ProjectManager.Entities;
using ProjectManager.Forms;
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
        User user = new User();
        Group group = new Group();

        public Projects(User recUser)
        {
            InitializeComponent();
            user = recUser;
            GenericSqlHelper<User> genericSqlHelper = new GenericSqlHelper<User>();
            user = genericSqlHelper.ReadById(user);
            openChildForm(new RelatingProjects(user,this));
        }
        private void Projects_Load(object sender, EventArgs e)
        {
            GenericSqlHelper<UserGroup> genericUserGroup = new GenericSqlHelper<UserGroup>();
            List<UserGroup> tempTeamList = genericUserGroup.ReadList(user);
            for (int i = 0; i < tempTeamList.Count; i++)
            {
                group.GroupId = tempTeamList[i].GroupId;
                GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
                group = genericGroup.ReadById(group);
            }

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlActive.Controls.Add(childForm);
            pnlActive.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            this.DoubleBuffered = true;
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            openChildForm(new RelatingProjects(user, this));
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            openChildForm(new CreateProject(user));
        }

        internal void PerformEditProject(int projectId)
        {
            openChildForm(new CreateProject(user, projectId));
        }
    }
}
