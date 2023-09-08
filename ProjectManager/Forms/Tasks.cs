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

        public Tasks(int userId)
        {
            InitializeComponent();
            user.UserId = userId;
            GenericSqlHelper<User> genericSqlHelper = new GenericSqlHelper<User>();
            user = genericSqlHelper.ReadById(user);
            openChildForm(new RelatingTasks(user.UserId));
        }
        private void Tasks_Load(object sender, EventArgs e)
        {
            GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
            user = genericUser.ReadById(user);
            DoubleBuffered = true;
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

        private void btnTasks_Click(object sender, EventArgs e)
        {
            openChildForm(new RelatingTasks(user.UserId));
        }

        private void btnMyTasks_Click(object sender, EventArgs e)
        {
            openChildForm(new RelatingTasks(user.UserId));
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            openChildForm(new CreateTask(user.UserId));
        }
    }

}
