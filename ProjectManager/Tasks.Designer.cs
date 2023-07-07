namespace ProjectManager
{
    partial class Tasks
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
            this.cmbTaskProject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txTaskComment = new System.Windows.Forms.RichTextBox();
            this.dtTaskFinishDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbTaskStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTaskPriority = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtTaskStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txTaskName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvActiveTasks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTasks
            // 
            this.pnlTasks.BackColor = System.Drawing.Color.Silver;
            this.pnlTasks.Controls.Add(this.cmbTaskProject);
            this.pnlTasks.Controls.Add(this.txTaskComment);
            this.pnlTasks.Controls.Add(this.dtTaskFinishDate);
            this.pnlTasks.Controls.Add(this.cmbTaskStatus);
            this.pnlTasks.Controls.Add(this.cmbTaskPriority);
            this.pnlTasks.Controls.Add(this.dtTaskStartDate);
            this.pnlTasks.Controls.Add(this.btnDelete);
            this.pnlTasks.Controls.Add(this.btnEdit);
            this.pnlTasks.Controls.Add(this.btnSave);
            this.pnlTasks.Controls.Add(this.btnClear);
            this.pnlTasks.Controls.Add(this.label5);
            this.pnlTasks.Controls.Add(this.label4);
            this.pnlTasks.Controls.Add(this.label3);
            this.pnlTasks.Controls.Add(this.label2);
            this.pnlTasks.Controls.Add(this.label1);
            this.pnlTasks.Controls.Add(this.txTaskName);
            this.pnlTasks.Controls.Add(this.dgvActiveTasks);
            this.pnlTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTasks.Location = new System.Drawing.Point(0, 0);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(1280, 551);
            this.pnlTasks.TabIndex = 1;
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
            // 
            // txTaskComment
            // 
            this.txTaskComment.Location = new System.Drawing.Point(849, 366);
            this.txTaskComment.Name = "txTaskComment";
            this.txTaskComment.Size = new System.Drawing.Size(419, 173);
            this.txTaskComment.TabIndex = 33;
            this.txTaskComment.Text = "";
            // 
            // dtTaskFinishDate
            // 
            this.dtTaskFinishDate.Checked = true;
            this.dtTaskFinishDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.dtTaskFinishDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTaskFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTaskFinishDate.Location = new System.Drawing.Point(424, 366);
            this.dtTaskFinishDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTaskFinishDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTaskFinishDate.Name = "dtTaskFinishDate";
            this.dtTaskFinishDate.Size = new System.Drawing.Size(200, 36);
            this.dtTaskFinishDate.TabIndex = 32;
            this.dtTaskFinishDate.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            // 
            // cmbTaskStatus
            // 
            this.cmbTaskStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbTaskStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTaskStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTaskStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTaskStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
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
            this.cmbTaskPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
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
            // dtTaskStartDate
            // 
            this.dtTaskStartDate.Checked = true;
            this.dtTaskStartDate.Enabled = false;
            this.dtTaskStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.dtTaskStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTaskStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTaskStartDate.Location = new System.Drawing.Point(218, 366);
            this.dtTaskStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTaskStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTaskStartDate.Name = "dtTaskStartDate";
            this.dtTaskStartDate.Size = new System.Drawing.Size(200, 36);
            this.dtTaskStartDate.TabIndex = 29;
            this.dtTaskStartDate.Value = new System.DateTime(2023, 7, 4, 0, 0, 0, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(480, 494);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 45);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(324, 494);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 45);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 494);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(168, 494);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 45);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Task Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Task Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Task Finish Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Task Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActiveTasks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActiveTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActiveTasks.Location = new System.Drawing.Point(12, 6);
            this.dgvActiveTasks.Name = "dgvActiveTasks";
            this.dgvActiveTasks.ReadOnly = true;
            this.dgvActiveTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActiveTasks.RowHeadersVisible = false;
            this.dgvActiveTasks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvActiveTasks.Size = new System.Drawing.Size(1256, 323);
            this.dgvActiveTasks.TabIndex = 14;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvActiveTasks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvActiveTasks.ThemeStyle.BackColor = System.Drawing.Color.White;
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
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 551);
            this.Controls.Add(this.pnlTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.pnlTasks.ResumeLayout(false);
            this.pnlTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTasks;
        private Guna.UI2.WinForms.Guna2DataGridView dgvActiveTasks;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTaskFinishDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskPriority;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTaskStartDate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txTaskName;
        private System.Windows.Forms.RichTextBox txTaskComment;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTaskProject;
    }
}