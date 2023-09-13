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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTasks = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvActiveTasks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.txTaskComment = new System.Windows.Forms.RichTextBox();
            this.pnlTasks.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveTasks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTasks
            // 
            this.pnlTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.pnlTasks.Controls.Add(this.panel3);
            this.pnlTasks.Controls.Add(this.panel2);
            this.pnlTasks.Controls.Add(this.panel1);
            this.pnlTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTasks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlTasks.Location = new System.Drawing.Point(0, 0);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(1150, 516);
            this.pnlTasks.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txTaskComment);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txTaskName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.clb2);
            this.panel3.Controls.Add(this.cmbTaskPriority);
            this.panel3.Controls.Add(this.clb1);
            this.panel3.Controls.Add(this.cmbTaskStatus);
            this.panel3.Controls.Add(this.dtTaskStartDate);
            this.panel3.Controls.Add(this.dtTaskEndDate);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbTaskProject);
            this.panel3.Controls.Add(this.cmbTaskTeam);
            this.panel3.Controls.Add(this.cmbTaskEmployee);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 195);
            this.panel3.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 39);
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
            this.txTaskName.Location = new System.Drawing.Point(16, 55);
            this.txTaskName.Name = "txTaskName";
            this.txTaskName.PasswordChar = '\0';
            this.txTaskName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.txTaskName.PlaceholderText = "";
            this.txTaskName.SelectedText = "";
            this.txTaskName.Size = new System.Drawing.Size(200, 36);
            this.txTaskName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(425, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Task End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Task Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(631, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 114;
            this.label8.Text = "Task Badges";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(219, 108);
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
            this.clb2.Location = new System.Drawing.Point(721, 122);
            this.clb2.Name = "clb2";
            this.clb2.Size = new System.Drawing.Size(85, 64);
            this.clb2.TabIndex = 113;
            this.clb2.ThreeDCheckBoxes = true;
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
            this.cmbTaskPriority.Location = new System.Drawing.Point(223, 124);
            this.cmbTaskPriority.Name = "cmbTaskPriority";
            this.cmbTaskPriority.Size = new System.Drawing.Size(200, 36);
            this.cmbTaskPriority.StartIndex = 0;
            this.cmbTaskPriority.TabIndex = 30;
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
            this.clb1.Location = new System.Drawing.Point(640, 122);
            this.clb1.Name = "clb1";
            this.clb1.Size = new System.Drawing.Size(85, 64);
            this.clb1.TabIndex = 112;
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
            this.cmbTaskStatus.Location = new System.Drawing.Point(16, 124);
            this.cmbTaskStatus.Name = "cmbTaskStatus";
            this.cmbTaskStatus.Size = new System.Drawing.Size(200, 36);
            this.cmbTaskStatus.StartIndex = 0;
            this.cmbTaskStatus.TabIndex = 31;
            // 
            // dtTaskStartDate
            // 
            this.dtTaskStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.dtTaskStartDate.Checked = true;
            this.dtTaskStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.dtTaskStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTaskStartDate.ForeColor = System.Drawing.Color.White;
            this.dtTaskStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTaskStartDate.Location = new System.Drawing.Point(222, 55);
            this.dtTaskStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTaskStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTaskStartDate.Name = "dtTaskStartDate";
            this.dtTaskStartDate.Size = new System.Drawing.Size(200, 36);
            this.dtTaskStartDate.TabIndex = 45;
            this.dtTaskStartDate.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            // 
            // dtTaskEndDate
            // 
            this.dtTaskEndDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.dtTaskEndDate.Checked = true;
            this.dtTaskEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.dtTaskEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTaskEndDate.ForeColor = System.Drawing.Color.White;
            this.dtTaskEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTaskEndDate.Location = new System.Drawing.Point(428, 55);
            this.dtTaskEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTaskEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTaskEndDate.Name = "dtTaskEndDate";
            this.dtTaskEndDate.Size = new System.Drawing.Size(200, 36);
            this.dtTaskEndDate.TabIndex = 32;
            this.dtTaskEndDate.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(219, 39);
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
            this.cmbTaskProject.Location = new System.Drawing.Point(429, 124);
            this.cmbTaskProject.Name = "cmbTaskProject";
            this.cmbTaskProject.Size = new System.Drawing.Size(199, 36);
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
            this.cmbTaskTeam.Location = new System.Drawing.Point(429, 124);
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
            this.cmbTaskEmployee.Location = new System.Drawing.Point(634, 55);
            this.cmbTaskEmployee.Name = "cmbTaskEmployee";
            this.cmbTaskEmployee.Size = new System.Drawing.Size(199, 36);
            this.cmbTaskEmployee.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(836, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Task Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(426, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Task Project";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(631, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Task Employee";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvActiveTasks);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1150, 262);
            this.panel2.TabIndex = 117;
            // 
            // dgvActiveTasks
            // 
            this.dgvActiveTasks.AllowUserToAddRows = false;
            this.dgvActiveTasks.AllowUserToDeleteRows = false;
            this.dgvActiveTasks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActiveTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvActiveTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActiveTasks.ColumnHeadersHeight = 4;
            this.dgvActiveTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActiveTasks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActiveTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveTasks.GridColor = System.Drawing.Color.White;
            this.dgvActiveTasks.Location = new System.Drawing.Point(10, 10);
            this.dgvActiveTasks.Name = "dgvActiveTasks";
            this.dgvActiveTasks.ReadOnly = true;
            this.dgvActiveTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActiveTasks.RowHeadersVisible = false;
            this.dgvActiveTasks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvActiveTasks.Size = new System.Drawing.Size(1130, 242);
            this.dgvActiveTasks.TabIndex = 111;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvActiveTasks.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.dgvActiveTasks.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvActiveTasks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvActiveTasks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActiveTasks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvActiveTasks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvActiveTasks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvActiveTasks.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvActiveTasks.ThemeStyle.ReadOnly = true;
            this.dgvActiveTasks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveTasks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActiveTasks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvActiveTasks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveTasks.ThemeStyle.RowsStyle.Height = 22;
            this.dgvActiveTasks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActiveTasks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveTasks_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 457);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
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
            this.btnClear.Location = new System.Drawing.Point(436, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 49);
            this.btnClear.TabIndex = 110;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(294, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 49);
            this.btnDelete.TabIndex = 109;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(152, 0);
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
            this.btnCreate.Location = new System.Drawing.Point(10, 0);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(142, 49);
            this.btnCreate.TabIndex = 107;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txTaskComment
            // 
            this.txTaskComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.txTaskComment.Location = new System.Drawing.Point(839, 55);
            this.txTaskComment.Name = "txTaskComment";
            this.txTaskComment.Size = new System.Drawing.Size(301, 131);
            this.txTaskComment.TabIndex = 116;
            this.txTaskComment.Text = "";
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveTasks)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvActiveTasks;
        private System.Windows.Forms.CheckedListBox clb1;
        private System.Windows.Forms.CheckedListBox clb2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txTaskComment;
    }
}