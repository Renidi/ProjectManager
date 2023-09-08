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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTasks = new System.Windows.Forms.Panel();
            this.dtTaskStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTaskTeam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTaskEmployee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTaskProject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txTaskComment = new System.Windows.Forms.RichTextBox();
            this.dtTaskEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbTaskStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTaskPriority = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txTaskName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvActiveTasks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTasks
            // 
            this.pnlTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pnlTasks.Controls.Add(this.btnClear);
            this.pnlTasks.Controls.Add(this.btnDelete);
            this.pnlTasks.Controls.Add(this.btnEdit);
            this.pnlTasks.Controls.Add(this.btnSave);
            this.pnlTasks.Controls.Add(this.dtTaskStartDate);
            this.pnlTasks.Controls.Add(this.label9);
            this.pnlTasks.Controls.Add(this.label8);
            this.pnlTasks.Controls.Add(this.cmbTaskTeam);
            this.pnlTasks.Controls.Add(this.label2);
            this.pnlTasks.Controls.Add(this.label7);
            this.pnlTasks.Controls.Add(this.label6);
            this.pnlTasks.Controls.Add(this.cmbTaskEmployee);
            this.pnlTasks.Controls.Add(this.cmbTaskProject);
            this.pnlTasks.Controls.Add(this.txTaskComment);
            this.pnlTasks.Controls.Add(this.dtTaskEndDate);
            this.pnlTasks.Controls.Add(this.cmbTaskStatus);
            this.pnlTasks.Controls.Add(this.cmbTaskPriority);
            this.pnlTasks.Controls.Add(this.label5);
            this.pnlTasks.Controls.Add(this.label4);
            this.pnlTasks.Controls.Add(this.label3);
            this.pnlTasks.Controls.Add(this.label1);
            this.pnlTasks.Controls.Add(this.txTaskName);
            this.pnlTasks.Controls.Add(this.dgvActiveTasks);
            this.pnlTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTasks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlTasks.Location = new System.Drawing.Point(0, 0);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(1150, 551);
            this.pnlTasks.TabIndex = 2;
            // 
            // dtTaskStartDate
            // 
            this.dtTaskStartDate.Checked = true;
            this.dtTaskStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.dtTaskStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTaskStartDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtTaskStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTaskStartDate.Location = new System.Drawing.Point(218, 366);
            this.dtTaskStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTaskStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTaskStartDate.Name = "dtTaskStartDate";
            this.dtTaskStartDate.Size = new System.Drawing.Size(200, 36);
            this.dtTaskStartDate.TabIndex = 45;
            this.dtTaskStartDate.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(215, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Task Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(627, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Task Team";
            // 
            // cmbTaskTeam
            // 
            this.cmbTaskTeam.BackColor = System.Drawing.Color.Transparent;
            this.cmbTaskTeam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskTeam.Enabled = false;
            this.cmbTaskTeam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskTeam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskTeam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTaskTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbTaskTeam.ItemHeight = 30;
            this.cmbTaskTeam.Location = new System.Drawing.Point(630, 366);
            this.cmbTaskTeam.Name = "cmbTaskTeam";
            this.cmbTaskTeam.Size = new System.Drawing.Size(199, 36);
            this.cmbTaskTeam.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(832, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Task Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(627, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Task Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(422, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Task Project";
            // 
            // cmbTaskEmployee
            // 
            this.cmbTaskEmployee.BackColor = System.Drawing.Color.Transparent;
            this.cmbTaskEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskEmployee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskEmployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTaskEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbTaskEmployee.ItemHeight = 30;
            this.cmbTaskEmployee.Location = new System.Drawing.Point(630, 435);
            this.cmbTaskEmployee.Name = "cmbTaskEmployee";
            this.cmbTaskEmployee.Size = new System.Drawing.Size(199, 36);
            this.cmbTaskEmployee.TabIndex = 38;
            // 
            // cmbTaskProject
            // 
            this.cmbTaskProject.BackColor = System.Drawing.Color.Transparent;
            this.cmbTaskProject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskProject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskProject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskProject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTaskProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTaskProject.ItemHeight = 30;
            this.cmbTaskProject.Location = new System.Drawing.Point(425, 435);
            this.cmbTaskProject.Name = "cmbTaskProject";
            this.cmbTaskProject.Size = new System.Drawing.Size(199, 36);
            this.cmbTaskProject.TabIndex = 37;
            this.cmbTaskProject.SelectedIndexChanged += new System.EventHandler(this.cmbTaskProject_SelectedIndexChanged);
            // 
            // txTaskComment
            // 
            this.txTaskComment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txTaskComment.Location = new System.Drawing.Point(835, 366);
            this.txTaskComment.Name = "txTaskComment";
            this.txTaskComment.Size = new System.Drawing.Size(303, 105);
            this.txTaskComment.TabIndex = 33;
            this.txTaskComment.Text = "";
            // 
            // dtTaskEndDate
            // 
            this.dtTaskEndDate.Checked = true;
            this.dtTaskEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.dtTaskEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTaskEndDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtTaskEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTaskEndDate.Location = new System.Drawing.Point(424, 366);
            this.dtTaskEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTaskEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTaskEndDate.Name = "dtTaskEndDate";
            this.dtTaskEndDate.Size = new System.Drawing.Size(200, 36);
            this.dtTaskEndDate.TabIndex = 32;
            this.dtTaskEndDate.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            // 
            // cmbTaskStatus
            // 
            this.cmbTaskStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbTaskStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTaskStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbTaskStatus.ItemHeight = 30;
            this.cmbTaskStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "ON HOLD",
            "CANCELLED",
            "COMPLETED"});
            this.cmbTaskStatus.Location = new System.Drawing.Point(12, 435);
            this.cmbTaskStatus.Name = "cmbTaskStatus";
            this.cmbTaskStatus.Size = new System.Drawing.Size(200, 36);
            this.cmbTaskStatus.StartIndex = 0;
            this.cmbTaskStatus.TabIndex = 31;
            // 
            // cmbTaskPriority
            // 
            this.cmbTaskPriority.BackColor = System.Drawing.Color.Transparent;
            this.cmbTaskPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskPriority.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskPriority.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskPriority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTaskPriority.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbTaskPriority.ItemHeight = 30;
            this.cmbTaskPriority.Items.AddRange(new object[] {
            "LOW",
            "MEDIUM",
            "HIGH"});
            this.cmbTaskPriority.Location = new System.Drawing.Point(219, 435);
            this.cmbTaskPriority.Name = "cmbTaskPriority";
            this.cmbTaskPriority.Size = new System.Drawing.Size(200, 36);
            this.cmbTaskPriority.StartIndex = 0;
            this.cmbTaskPriority.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(215, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Task Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(9, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Task Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(421, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Task End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Task Name";
            // 
            // txTaskName
            // 
            this.txTaskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txTaskName.DefaultText = "";
            this.txTaskName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txTaskName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txTaskName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txTaskName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txTaskName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txTaskName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txTaskName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txTaskName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txTaskName.Location = new System.Drawing.Point(12, 366);
            this.txTaskName.Name = "txTaskName";
            this.txTaskName.PasswordChar = '\0';
            this.txTaskName.PlaceholderText = "";
            this.txTaskName.SelectedText = "";
            this.txTaskName.Size = new System.Drawing.Size(200, 36);
            this.txTaskName.TabIndex = 19;
            // 
            // dgvActiveTasks
            // 
            this.dgvActiveTasks.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvActiveTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvActiveTasks.ColumnHeadersHeight = 4;
            this.dgvActiveTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActiveTasks.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvActiveTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActiveTasks.Location = new System.Drawing.Point(12, 6);
            this.dgvActiveTasks.Name = "dgvActiveTasks";
            this.dgvActiveTasks.ReadOnly = true;
            this.dgvActiveTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActiveTasks.RowHeadersVisible = false;
            this.dgvActiveTasks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvActiveTasks.Size = new System.Drawing.Size(1126, 330);
            this.dgvActiveTasks.TabIndex = 14;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvActiveTasks.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.dgvActiveTasks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
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
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(481, 494);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 45);
            this.btnClear.TabIndex = 110;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(325, 494);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 45);
            this.btnDelete.TabIndex = 109;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(169, 494);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 45);
            this.btnEdit.TabIndex = 108;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(13, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
            this.btnSave.TabIndex = 107;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 551);
            this.Controls.Add(this.pnlTasks);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.Load += new System.EventHandler(this.CreateTask_Load);
            this.pnlTasks.ResumeLayout(false);
            this.pnlTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTasks;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTaskStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskEmployee;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskProject;
        private System.Windows.Forms.RichTextBox txTaskComment;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTaskEndDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txTaskName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvActiveTasks;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
    }
}