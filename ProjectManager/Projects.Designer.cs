﻿namespace ProjectManager
{
    partial class Projects
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.txProjectComment = new System.Windows.Forms.RichTextBox();
            this.cmbProjectStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbProjectPriority = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvActiveProjects = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txProjectName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtProjectStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtProjectFinishDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbTeam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.Silver;
            this.pnlMiddle.Controls.Add(this.label6);
            this.pnlMiddle.Controls.Add(this.cmbTeam);
            this.pnlMiddle.Controls.Add(this.dtProjectFinishDate);
            this.pnlMiddle.Controls.Add(this.dtProjectStartDate);
            this.pnlMiddle.Controls.Add(this.txProjectComment);
            this.pnlMiddle.Controls.Add(this.cmbProjectStatus);
            this.pnlMiddle.Controls.Add(this.cmbProjectPriority);
            this.pnlMiddle.Controls.Add(this.dgvActiveProjects);
            this.pnlMiddle.Controls.Add(this.btnDelete);
            this.pnlMiddle.Controls.Add(this.btnEdit);
            this.pnlMiddle.Controls.Add(this.btnSave);
            this.pnlMiddle.Controls.Add(this.btnClear);
            this.pnlMiddle.Controls.Add(this.label5);
            this.pnlMiddle.Controls.Add(this.label4);
            this.pnlMiddle.Controls.Add(this.label3);
            this.pnlMiddle.Controls.Add(this.label2);
            this.pnlMiddle.Controls.Add(this.label1);
            this.pnlMiddle.Controls.Add(this.txProjectName);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 0);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1280, 551);
            this.pnlMiddle.TabIndex = 3;
            // 
            // txProjectComment
            // 
            this.txProjectComment.Location = new System.Drawing.Point(849, 366);
            this.txProjectComment.Name = "txProjectComment";
            this.txProjectComment.Size = new System.Drawing.Size(419, 173);
            this.txProjectComment.TabIndex = 34;
            this.txProjectComment.Text = "";
            // 
            // cmbProjectStatus
            // 
            this.cmbProjectStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbProjectStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProjectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProjectStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProjectStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProjectStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbProjectStatus.ItemHeight = 30;
            this.cmbProjectStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "ON HOLD",
            "CANCELLED",
            "COMPLETED"});
            this.cmbProjectStatus.Location = new System.Drawing.Point(12, 435);
            this.cmbProjectStatus.Name = "cmbProjectStatus";
            this.cmbProjectStatus.Size = new System.Drawing.Size(200, 36);
            this.cmbProjectStatus.StartIndex = 0;
            this.cmbProjectStatus.TabIndex = 17;
            // 
            // cmbProjectPriority
            // 
            this.cmbProjectPriority.BackColor = System.Drawing.Color.Transparent;
            this.cmbProjectPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProjectPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectPriority.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProjectPriority.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProjectPriority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProjectPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbProjectPriority.ItemHeight = 30;
            this.cmbProjectPriority.Items.AddRange(new object[] {
            "LOW",
            "MEDIUM",
            "HIGH"});
            this.cmbProjectPriority.Location = new System.Drawing.Point(218, 435);
            this.cmbProjectPriority.Name = "cmbProjectPriority";
            this.cmbProjectPriority.Size = new System.Drawing.Size(200, 36);
            this.cmbProjectPriority.StartIndex = 0;
            this.cmbProjectPriority.TabIndex = 16;
            // 
            // dgvActiveProjects
            // 
            this.dgvActiveProjects.AllowUserToAddRows = false;
            this.dgvActiveProjects.AllowUserToDeleteRows = false;
            this.dgvActiveProjects.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvActiveProjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvActiveProjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvActiveProjects.ColumnHeadersHeight = 4;
            this.dgvActiveProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActiveProjects.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvActiveProjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvActiveProjects.Location = new System.Drawing.Point(12, 6);
            this.dgvActiveProjects.Name = "dgvActiveProjects";
            this.dgvActiveProjects.ReadOnly = true;
            this.dgvActiveProjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvActiveProjects.RowHeadersVisible = false;
            this.dgvActiveProjects.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvActiveProjects.Size = new System.Drawing.Size(1256, 323);
            this.dgvActiveProjects.TabIndex = 14;
            this.dgvActiveProjects.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveProjects.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvActiveProjects.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvActiveProjects.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvActiveProjects.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvActiveProjects.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvActiveProjects.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
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
            // btnDelete
            // 
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(324, 494);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 45);
            this.btnDelete.TabIndex = 13;
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
            this.btnEdit.Location = new System.Drawing.Point(168, 494);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 45);
            this.btnEdit.TabIndex = 12;
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
            this.btnSave.TabIndex = 11;
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
            this.btnClear.Location = new System.Drawing.Point(480, 494);
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
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Project Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Project Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project Finish Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Project Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project Name";
            // 
            // txProjectName
            // 
            this.txProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txProjectName.DefaultText = "";
            this.txProjectName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txProjectName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txProjectName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txProjectName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txProjectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txProjectName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txProjectName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txProjectName.Location = new System.Drawing.Point(12, 366);
            this.txProjectName.Name = "txProjectName";
            this.txProjectName.PasswordChar = '\0';
            this.txProjectName.PlaceholderText = "";
            this.txProjectName.SelectedText = "";
            this.txProjectName.Size = new System.Drawing.Size(200, 36);
            this.txProjectName.TabIndex = 0;
            // 
            // dtProjectStartDate
            // 
            this.dtProjectStartDate.Checked = true;
            this.dtProjectStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.dtProjectStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtProjectStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtProjectStartDate.Location = new System.Drawing.Point(218, 366);
            this.dtProjectStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtProjectStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtProjectStartDate.Name = "dtProjectStartDate";
            this.dtProjectStartDate.Size = new System.Drawing.Size(200, 36);
            this.dtProjectStartDate.TabIndex = 35;
            this.dtProjectStartDate.Value = new System.DateTime(2023, 7, 31, 20, 42, 17, 902);
            // 
            // dtProjectFinishDate
            // 
            this.dtProjectFinishDate.Checked = true;
            this.dtProjectFinishDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.dtProjectFinishDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtProjectFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtProjectFinishDate.Location = new System.Drawing.Point(425, 366);
            this.dtProjectFinishDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtProjectFinishDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtProjectFinishDate.Name = "dtProjectFinishDate";
            this.dtProjectFinishDate.Size = new System.Drawing.Size(200, 36);
            this.dtProjectFinishDate.TabIndex = 36;
            this.dtProjectFinishDate.Value = new System.DateTime(2023, 7, 31, 20, 42, 17, 902);
            // 
            // cmbTeam
            // 
            this.cmbTeam.BackColor = System.Drawing.Color.Transparent;
            this.cmbTeam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTeam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTeam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTeam.ItemHeight = 30;
            this.cmbTeam.Location = new System.Drawing.Point(425, 435);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(200, 36);
            this.cmbTeam.StartIndex = 0;
            this.cmbTeam.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Project Team";
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 551);
            this.Controls.Add(this.pnlMiddle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Projects";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.Projects_Load);
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMiddle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProjectStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProjectPriority;
        private Guna.UI2.WinForms.Guna2DataGridView dgvActiveProjects;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txProjectName;
        private System.Windows.Forms.RichTextBox txProjectComment;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtProjectStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtProjectFinishDate;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTeam;
    }
}