namespace ProjectManager.Forms
{
    partial class CreateProject
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
            this.cmbProjectTeamIdHidden = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txProjectName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProjectPriority = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProjectStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTeam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtProjectEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtProjectStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvActiveProjects = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txProjectComment = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveProjects)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbProjectTeamIdHidden
            // 
            this.cmbProjectTeamIdHidden.BackColor = System.Drawing.Color.Transparent;
            this.cmbProjectTeamIdHidden.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbProjectTeamIdHidden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProjectTeamIdHidden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectTeamIdHidden.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbProjectTeamIdHidden.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProjectTeamIdHidden.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProjectTeamIdHidden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProjectTeamIdHidden.ForeColor = System.Drawing.Color.White;
            this.cmbProjectTeamIdHidden.ItemHeight = 30;
            this.cmbProjectTeamIdHidden.Location = new System.Drawing.Point(430, 126);
            this.cmbProjectTeamIdHidden.Name = "cmbProjectTeamIdHidden";
            this.cmbProjectTeamIdHidden.Size = new System.Drawing.Size(200, 36);
            this.cmbProjectTeamIdHidden.TabIndex = 101;
            this.cmbProjectTeamIdHidden.Visible = false;
            this.cmbProjectTeamIdHidden.SelectedIndexChanged += new System.EventHandler(this.cmbProjectTeamIdHidden_SelectedIndexChanged);
            // 
            // txProjectName
            // 
            this.txProjectName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.txProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txProjectName.DefaultText = "";
            this.txProjectName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txProjectName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txProjectName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txProjectName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txProjectName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.txProjectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txProjectName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txProjectName.ForeColor = System.Drawing.Color.White;
            this.txProjectName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txProjectName.Location = new System.Drawing.Point(17, 57);
            this.txProjectName.Name = "txProjectName";
            this.txProjectName.PasswordChar = '\0';
            this.txProjectName.PlaceholderText = "";
            this.txProjectName.SelectedText = "";
            this.txProjectName.Size = new System.Drawing.Size(200, 36);
            this.txProjectName.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(640, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Project Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Project Name";
            // 
            // cmbProjectPriority
            // 
            this.cmbProjectPriority.BackColor = System.Drawing.Color.Transparent;
            this.cmbProjectPriority.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbProjectPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProjectPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectPriority.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbProjectPriority.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProjectPriority.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProjectPriority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProjectPriority.ForeColor = System.Drawing.Color.White;
            this.cmbProjectPriority.ItemHeight = 30;
            this.cmbProjectPriority.Items.AddRange(new object[] {
            "LOW",
            "MEDIUM",
            "HIGH"});
            this.cmbProjectPriority.Location = new System.Drawing.Point(223, 126);
            this.cmbProjectPriority.Name = "cmbProjectPriority";
            this.cmbProjectPriority.Size = new System.Drawing.Size(200, 36);
            this.cmbProjectPriority.StartIndex = 0;
            this.cmbProjectPriority.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(426, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Project Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(228, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Project Date";
            // 
            // cmbProjectStatus
            // 
            this.cmbProjectStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbProjectStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbProjectStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProjectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbProjectStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProjectStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProjectStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProjectStatus.ForeColor = System.Drawing.Color.White;
            this.cmbProjectStatus.ItemHeight = 30;
            this.cmbProjectStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "ON HOLD",
            "CANCELLED",
            "COMPLETED"});
            this.cmbProjectStatus.Location = new System.Drawing.Point(17, 126);
            this.cmbProjectStatus.Name = "cmbProjectStatus";
            this.cmbProjectStatus.Size = new System.Drawing.Size(200, 36);
            this.cmbProjectStatus.StartIndex = 0;
            this.cmbProjectStatus.TabIndex = 95;
            // 
            // cmbTeam
            // 
            this.cmbTeam.BackColor = System.Drawing.Color.Transparent;
            this.cmbTeam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbTeam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.cmbTeam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTeam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTeam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTeam.ForeColor = System.Drawing.Color.White;
            this.cmbTeam.ItemHeight = 30;
            this.cmbTeam.Location = new System.Drawing.Point(430, 126);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(200, 36);
            this.cmbTeam.TabIndex = 102;
            this.cmbTeam.SelectedValueChanged += new System.EventHandler(this.cmbTeam_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(436, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Project End Date";
            // 
            // dtProjectEndDate
            // 
            this.dtProjectEndDate.Checked = true;
            this.dtProjectEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.dtProjectEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtProjectEndDate.ForeColor = System.Drawing.Color.White;
            this.dtProjectEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtProjectEndDate.Location = new System.Drawing.Point(430, 57);
            this.dtProjectEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtProjectEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtProjectEndDate.Name = "dtProjectEndDate";
            this.dtProjectEndDate.Size = new System.Drawing.Size(200, 36);
            this.dtProjectEndDate.TabIndex = 98;
            this.dtProjectEndDate.Value = new System.DateTime(2023, 7, 31, 20, 42, 17, 902);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(220, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Project Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "Project Status";
            // 
            // dtProjectStartDate
            // 
            this.dtProjectStartDate.Checked = true;
            this.dtProjectStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.dtProjectStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtProjectStartDate.ForeColor = System.Drawing.Color.White;
            this.dtProjectStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtProjectStartDate.Location = new System.Drawing.Point(223, 57);
            this.dtProjectStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtProjectStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtProjectStartDate.Name = "dtProjectStartDate";
            this.dtProjectStartDate.Size = new System.Drawing.Size(200, 36);
            this.dtProjectStartDate.TabIndex = 97;
            this.dtProjectStartDate.Value = new System.DateTime(2023, 7, 31, 20, 42, 17, 902);
            // 
            // dgvActiveProjects
            // 
            this.dgvActiveProjects.AllowUserToAddRows = false;
            this.dgvActiveProjects.AllowUserToDeleteRows = false;
            this.dgvActiveProjects.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveProjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActiveProjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvActiveProjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActiveProjects.ColumnHeadersHeight = 4;
            this.dgvActiveProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActiveProjects.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActiveProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveProjects.GridColor = System.Drawing.Color.White;
            this.dgvActiveProjects.Location = new System.Drawing.Point(10, 10);
            this.dgvActiveProjects.Name = "dgvActiveProjects";
            this.dgvActiveProjects.ReadOnly = true;
            this.dgvActiveProjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActiveProjects.RowHeadersVisible = false;
            this.dgvActiveProjects.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvActiveProjects.Size = new System.Drawing.Size(1130, 217);
            this.dgvActiveProjects.TabIndex = 87;
            this.dgvActiveProjects.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveProjects.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvActiveProjects.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvActiveProjects.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvActiveProjects.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvActiveProjects.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.dgvActiveProjects.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvActiveProjects.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvActiveProjects.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActiveProjects.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvActiveProjects.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvActiveProjects.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvActiveProjects.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvActiveProjects.ThemeStyle.ReadOnly = true;
            this.dgvActiveProjects.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveProjects.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvActiveProjects.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvActiveProjects.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveProjects.ThemeStyle.RowsStyle.Height = 22;
            this.dgvActiveProjects.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActiveProjects.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveProjects_CellContentClick);
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
            this.panel1.TabIndex = 108;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvActiveProjects);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1150, 237);
            this.panel2.TabIndex = 109;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txProjectComment);
            this.panel3.Controls.Add(this.txProjectName);
            this.panel3.Controls.Add(this.cmbProjectPriority);
            this.panel3.Controls.Add(this.dtProjectStartDate);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbProjectTeamIdHidden);
            this.panel3.Controls.Add(this.dtProjectEndDate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbProjectStatus);
            this.panel3.Controls.Add(this.cmbTeam);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 220);
            this.panel3.TabIndex = 110;
            // 
            // txProjectComment
            // 
            this.txProjectComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.txProjectComment.Location = new System.Drawing.Point(643, 57);
            this.txProjectComment.Name = "txProjectComment";
            this.txProjectComment.Size = new System.Drawing.Size(257, 105);
            this.txProjectComment.TabIndex = 104;
            this.txProjectComment.Text = "";
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1150, 516);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateProject";
            this.Text = "CreateProject";
            this.Load += new System.EventHandler(this.CreateProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveProjects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cmbProjectTeamIdHidden;
        private Guna.UI2.WinForms.Guna2TextBox txProjectName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProjectPriority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProjectStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTeam;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtProjectEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtProjectStartDate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvActiveProjects;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txProjectComment;
    }
}