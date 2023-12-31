﻿using ProjectManager.Entities;
using ProjectManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class Tasks : Form
    {
        User user = new User();
        public Tasks(User recUser)
        {
            InitializeComponent();
            user = recUser;
            GenericSqlHelper<User> genericSqlHelper = new GenericSqlHelper<User>();
            user = genericSqlHelper.ReadById(user);
            openChildFormTasks(new RelatingTasks(user,this));
        }
        private void Tasks_Load(object sender, EventArgs e)
        {
            GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
            user = genericUser.ReadById(user);
            DoubleBuffered = true;
        }
        private Form activeForm = null;
        private void openChildFormTasks(Form childForm)
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
        public void PerformEditTask(int taskId)
        {
            openChildFormTasks(new CreateTask(user, taskId));
        }
        private void btnNewTask_Click(object sender, EventArgs e)
        {
            openChildFormTasks(new CreateTask(user));
        }

        private void btnMyTasks_Click(object sender, EventArgs e)
        {
            openChildFormTasks(new RelatingTasks(user, this, user.UserId));
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            openChildFormTasks(new RelatingTasks(user, this));
        }
    }

}
