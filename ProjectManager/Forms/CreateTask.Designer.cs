namespace ProjectManager.Forms
{
    partial class CreateTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTasks = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.txTaskComment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txTaskName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clb2 = new System.Windows.Forms.CheckedListBox();
            this.cmbTaskPriority = new Guna.UI2.WinForms.Guna2ComboBox();
            this.clb1 = new System.Windows.Forms.CheckedListBox();
            this.cmbTaskStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtTaskStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtTaskEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTaskProject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTaskTeam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTaskEmployee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlMid = new Guna.UI2.WinForms.Guna2Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTaskDate = new System.Windows.Forms.Label();
            this.lblTaskGroupName = new System.Windows.Forms.Label();
            this.lblTaskOwner = new System.Windows.Forms.Label();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlBadge = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTasks.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.pnlMid.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTasks
            // 
            this.pnlTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.pnlTasks.Controls.Add(this.pnlLeft);
            this.pnlTasks.Controls.Add(this.pnlRight);
            this.pnlTasks.Controls.Add(this.panel1);
            this.pnlTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTasks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlTasks.Location = new System.Drawing.Point(0, 0);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(1150, 516);
            this.pnlTasks.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.txTaskComment);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.txTaskName);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.label8);
            this.pnlLeft.Controls.Add(this.label5);
            this.pnlLeft.Controls.Add(this.clb2);
            this.pnlLeft.Controls.Add(this.cmbTaskPriority);
            this.pnlLeft.Controls.Add(this.clb1);
            this.pnlLeft.Controls.Add(this.cmbTaskStatus);
            this.pnlLeft.Controls.Add(this.dtTaskStartDate);
            this.pnlLeft.Controls.Add(this.dtTaskEndDate);
            this.pnlLeft.Controls.Add(this.label9);
            this.pnlLeft.Controls.Add(this.cmbTaskProject);
            this.pnlLeft.Controls.Add(this.cmbTaskTeam);
            this.pnlLeft.Controls.Add(this.cmbTaskEmployee);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.label6);
            this.pnlLeft.Controls.Add(this.label7);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(578, 457);
            this.pnlLeft.TabIndex = 118;
            // 
            // txTaskComment
            // 
            this.txTaskComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.txTaskComment.Location = new System.Drawing.Point(293, 240);
            this.txTaskComment.Name = "txTaskComment";
            this.txTaskComment.Size = new System.Drawing.Size(201, 131);
            this.txTaskComment.TabIndex = 116;
            this.txTaskComment.Text = "";
            this.txTaskComment.TextChanged += new System.EventHandler(this.txTaskComment_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(87, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Task Name";
            // 
            // txTaskName
            // 
            this.txTaskName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.txTaskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txTaskName.DefaultText = "";
            this.txTaskName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txTaskName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txTaskName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txTaskName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txTaskName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.txTaskName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txTaskName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txTaskName.ForeColor = System.Drawing.Color.White;
            this.txTaskName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txTaskName.Location = new System.Drawing.Point(87, 43);
            this.txTaskName.Name = "txTaskName";
            this.txTaskName.PasswordChar = '\0';
            this.txTaskName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.txTaskName.PlaceholderText = "";
            this.txTaskName.SelectedText = "";
            this.txTaskName.Size = new System.Drawing.Size(200, 36);
            this.txTaskName.TabIndex = 19;
            this.txTaskName.TextChanged += new System.EventHandler(this.txTaskName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(290, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Task End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(84, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Task Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(84, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 114;
            this.label8.Text = "Task Badges";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(290, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Task Priority";
            // 
            // clb2
            // 
            this.clb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.clb2.ForeColor = System.Drawing.Color.White;
            this.clb2.FormattingEnabled = true;
            this.clb2.Items.AddRange(new object[] {
            "Planning",
            "Design",
            "Frontend",
            "Backend"});
            this.clb2.Location = new System.Drawing.Point(174, 307);
            this.clb2.Name = "clb2";
            this.clb2.Size = new System.Drawing.Size(87, 64);
            this.clb2.TabIndex = 113;
            this.clb2.ThreeDCheckBoxes = true;
            this.clb2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb2_ItemCheck);
            this.clb2.Click += new System.EventHandler(this.clb2_Click);
            // 
            // cmbTaskPriority
            // 
            this.cmbTaskPriority.BackColor = System.Drawing.Color.Transparent;
            this.cmbTaskPriority.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbTaskPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskPriority.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbTaskPriority.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskPriority.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskPriority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTaskPriority.ForeColor = System.Drawing.Color.White;
            this.cmbTaskPriority.ItemHeight = 30;
            this.cmbTaskPriority.Items.AddRange(new object[] {
            "LOW",
            "MEDIUM",
            "HIGH"});
            this.cmbTaskPriority.Location = new System.Drawing.Point(293, 112);
            this.cmbTaskPriority.Name = "cmbTaskPriority";
            this.cmbTaskPriority.Size = new System.Drawing.Size(201, 36);
            this.cmbTaskPriority.StartIndex = 0;
            this.cmbTaskPriority.TabIndex = 30;
            this.cmbTaskPriority.SelectedIndexChanged += new System.EventHandler(this.cmbTaskPriority_SelectedIndexChanged);
            // 
            // clb1
            // 
            this.clb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.clb1.ForeColor = System.Drawing.Color.White;
            this.clb1.FormattingEnabled = true;
            this.clb1.Items.AddRange(new object[] {
            "Research",
            "Website",
            "App",
            "Mobile App"});
            this.clb1.Location = new System.Drawing.Point(93, 307);
            this.clb1.Name = "clb1";
            this.clb1.Size = new System.Drawing.Size(87, 64);
            this.clb1.TabIndex = 112;
            this.clb1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb1_ItemCheck);
            this.clb1.Click += new System.EventHandler(this.clb1_Click);
            // 
            // cmbTaskStatus
            // 
            this.cmbTaskStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbTaskStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbTaskStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbTaskStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTaskStatus.ForeColor = System.Drawing.Color.White;
            this.cmbTaskStatus.ItemHeight = 30;
            this.cmbTaskStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "ON HOLD",
            "CANCELLED",
            "COMPLETED"});
            this.cmbTaskStatus.Location = new System.Drawing.Point(87, 112);
            this.cmbTaskStatus.Name = "cmbTaskStatus";
            this.cmbTaskStatus.Size = new System.Drawing.Size(200, 36);
            this.cmbTaskStatus.StartIndex = 0;
            this.cmbTaskStatus.TabIndex = 31;
            this.cmbTaskStatus.SelectedIndexChanged += new System.EventHandler(this.cmbTaskStatus_SelectedIndexChanged);
            // 
            // dtTaskStartDate
            // 
            this.dtTaskStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.dtTaskStartDate.Checked = true;
            this.dtTaskStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.dtTaskStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTaskStartDate.ForeColor = System.Drawing.Color.White;
            this.dtTaskStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTaskStartDate.Location = new System.Drawing.Point(87, 177);
            this.dtTaskStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTaskStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTaskStartDate.Name = "dtTaskStartDate";
            this.dtTaskStartDate.Size = new System.Drawing.Size(200, 36);
            this.dtTaskStartDate.TabIndex = 45;
            this.dtTaskStartDate.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            this.dtTaskStartDate.ValueChanged += new System.EventHandler(this.dtTaskStartDate_ValueChanged);
            // 
            // dtTaskEndDate
            // 
            this.dtTaskEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.dtTaskEndDate.Checked = true;
            this.dtTaskEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.dtTaskEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTaskEndDate.ForeColor = System.Drawing.Color.White;
            this.dtTaskEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTaskEndDate.Location = new System.Drawing.Point(293, 177);
            this.dtTaskEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTaskEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTaskEndDate.Name = "dtTaskEndDate";
            this.dtTaskEndDate.Size = new System.Drawing.Size(201, 36);
            this.dtTaskEndDate.TabIndex = 32;
            this.dtTaskEndDate.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            this.dtTaskEndDate.ValueChanged += new System.EventHandler(this.dtTaskEndDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(84, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Task Start Date";
            // 
            // cmbTaskProject
            // 
            this.cmbTaskProject.BackColor = System.Drawing.Color.Transparent;
            this.cmbTaskProject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbTaskProject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskProject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbTaskProject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskProject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskProject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTaskProject.ForeColor = System.Drawing.Color.White;
            this.cmbTaskProject.ItemHeight = 30;
            this.cmbTaskProject.Location = new System.Drawing.Point(293, 43);
            this.cmbTaskProject.Name = "cmbTaskProject";
            this.cmbTaskProject.Size = new System.Drawing.Size(201, 36);
            this.cmbTaskProject.TabIndex = 37;
            this.cmbTaskProject.SelectedIndexChanged += new System.EventHandler(this.cmbTaskProject_SelectedIndexChanged);
            // 
            // cmbTaskTeam
            // 
            this.cmbTaskTeam.BackColor = System.Drawing.Color.Transparent;
            this.cmbTaskTeam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbTaskTeam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskTeam.Enabled = false;
            this.cmbTaskTeam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbTaskTeam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskTeam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskTeam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTaskTeam.ForeColor = System.Drawing.Color.White;
            this.cmbTaskTeam.ItemHeight = 30;
            this.cmbTaskTeam.Location = new System.Drawing.Point(294, 43);
            this.cmbTaskTeam.Name = "cmbTaskTeam";
            this.cmbTaskTeam.Size = new System.Drawing.Size(199, 36);
            this.cmbTaskTeam.TabIndex = 42;
            this.cmbTaskTeam.Visible = false;
            // 
            // cmbTaskEmployee
            // 
            this.cmbTaskEmployee.BackColor = System.Drawing.Color.Transparent;
            this.cmbTaskEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbTaskEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbTaskEmployee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskEmployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTaskEmployee.ForeColor = System.Drawing.Color.White;
            this.cmbTaskEmployee.ItemHeight = 30;
            this.cmbTaskEmployee.Location = new System.Drawing.Point(87, 240);
            this.cmbTaskEmployee.Name = "cmbTaskEmployee";
            this.cmbTaskEmployee.Size = new System.Drawing.Size(200, 36);
            this.cmbTaskEmployee.TabIndex = 38;
            this.cmbTaskEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbTaskEmployee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(289, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Task Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(291, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Task Project";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(84, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Task Employee";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlFill);
            this.pnlRight.Location = new System.Drawing.Point(584, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRight.Size = new System.Drawing.Size(566, 457);
            this.pnlRight.TabIndex = 117;
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.pnlFill.Controls.Add(this.pnlMid);
            this.pnlFill.Controls.Add(this.pnlBottom);
            this.pnlFill.Controls.Add(this.pnlTop);
            this.pnlFill.Location = new System.Drawing.Point(133, 85);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(265, 246);
            this.pnlFill.TabIndex = 1;
            // 
            // pnlMid
            // 
            this.pnlMid.BackColor = System.Drawing.Color.Transparent;
            this.pnlMid.Controls.Add(this.lblContent);
            this.pnlMid.Controls.Add(this.lblTaskName);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(0, 45);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(265, 146);
            this.pnlMid.TabIndex = 2;
            // 
            // lblContent
            // 
            this.lblContent.BackColor = System.Drawing.Color.Transparent;
            this.lblContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContent.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContent.ForeColor = System.Drawing.Color.Linen;
            this.lblContent.Location = new System.Drawing.Point(0, 30);
            this.lblContent.Name = "lblContent";
            this.lblContent.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblContent.Size = new System.Drawing.Size(265, 116);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "Task Description";
            // 
            // lblTaskName
            // 
            this.lblTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTaskName.Location = new System.Drawing.Point(0, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTaskName.Size = new System.Drawing.Size(265, 30);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Task Name";
            this.lblTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Controls.Add(this.lblTaskDate);
            this.pnlBottom.Controls.Add(this.lblTaskGroupName);
            this.pnlBottom.Controls.Add(this.lblTaskOwner);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 191);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(265, 55);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblTaskDate
            // 
            this.lblTaskDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTaskDate.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskDate.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblTaskDate.Location = new System.Drawing.Point(105, 0);
            this.lblTaskDate.Name = "lblTaskDate";
            this.lblTaskDate.Size = new System.Drawing.Size(160, 27);
            this.lblTaskDate.TabIndex = 2;
            this.lblTaskDate.Text = "Task Date";
            this.lblTaskDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskGroupName
            // 
            this.lblTaskGroupName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskGroupName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTaskGroupName.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskGroupName.ForeColor = System.Drawing.Color.Gold;
            this.lblTaskGroupName.Location = new System.Drawing.Point(0, 0);
            this.lblTaskGroupName.Name = "lblTaskGroupName";
            this.lblTaskGroupName.Size = new System.Drawing.Size(105, 27);
            this.lblTaskGroupName.TabIndex = 1;
            this.lblTaskGroupName.Text = "Project Team";
            this.lblTaskGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskOwner
            // 
            this.lblTaskOwner.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskOwner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTaskOwner.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskOwner.ForeColor = System.Drawing.Color.LightGreen;
            this.lblTaskOwner.Location = new System.Drawing.Point(0, 27);
            this.lblTaskOwner.Name = "lblTaskOwner";
            this.lblTaskOwner.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTaskOwner.Size = new System.Drawing.Size(265, 28);
            this.lblTaskOwner.TabIndex = 2;
            this.lblTaskOwner.Text = "Task Employee";
            this.lblTaskOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.pnlBadge);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(3);
            this.pnlTop.Size = new System.Drawing.Size(265, 45);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlBadge
            // 
            this.pnlBadge.BackColor = System.Drawing.Color.Transparent;
            this.pnlBadge.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBadge.Location = new System.Drawing.Point(3, 3);
            this.pnlBadge.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBadge.Name = "pnlBadge";
            this.pnlBadge.Size = new System.Drawing.Size(259, 39);
            this.pnlBadge.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 457);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(65, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(1150, 59);
            this.panel1.TabIndex = 116;
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 15;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(349, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 49);
            this.btnClear.TabIndex = 110;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 15;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(207, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 49);
            this.btnEdit.TabIndex = 108;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BorderRadius = 15;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(65, 0);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(142, 49);
            this.btnCreate.TabIndex = 107;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1150, 516);
            this.Controls.Add(this.pnlTasks);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.Load += new System.EventHandler(this.CreateTask_Load);
            this.pnlTasks.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            this.pnlMid.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTasks;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTaskStartDate;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskEmployee;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskProject;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTaskEndDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txTaskName;
        private System.Windows.Forms.CheckedListBox clb1;
        private System.Windows.Forms.CheckedListBox clb2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.RichTextBox txTaskComment;
        private System.Windows.Forms.Panel pnlFill;
        private Guna.UI2.WinForms.Guna2Panel pnlMid;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblTaskName;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private System.Windows.Forms.Label lblTaskDate;
        private System.Windows.Forms.Label lblTaskGroupName;
        private System.Windows.Forms.Label lblTaskOwner;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Panel pnlBadge;
    }
}