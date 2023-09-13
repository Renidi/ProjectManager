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
            this.pnlTasks = new System.Windows.Forms.Panel();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnTasks = new Guna.UI2.WinForms.Guna2Button();
            this.btnMyTasks = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewTask = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTasks.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTasks
            // 
            this.pnlTasks.BackColor = System.Drawing.Color.Silver;
            this.pnlTasks.Controls.Add(this.pnlActive);
            this.pnlTasks.Controls.Add(this.pnlControls);
            this.pnlTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTasks.Location = new System.Drawing.Point(0, 0);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(1280, 551);
            this.pnlTasks.TabIndex = 1;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.pnlActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActive.Location = new System.Drawing.Point(135, 0);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(1145, 551);
            this.pnlActive.TabIndex = 45;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(176)))), ((int)(((byte)(165)))));
            this.pnlControls.Controls.Add(this.btnNewTask);
            this.pnlControls.Controls.Add(this.btnMyTasks);
            this.pnlControls.Controls.Add(this.btnTasks);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.pnlControls.Size = new System.Drawing.Size(135, 551);
            this.pnlControls.TabIndex = 44;
            // 
            // btnTasks
            // 
            this.btnTasks.BorderRadius = 15;
            this.btnTasks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTasks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTasks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTasks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(167)))), ((int)(((byte)(189)))));
            this.btnTasks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTasks.ForeColor = System.Drawing.Color.White;
            this.btnTasks.Location = new System.Drawing.Point(10, 30);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(115, 55);
            this.btnTasks.TabIndex = 3;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnMyTasks
            // 
            this.btnMyTasks.BorderRadius = 15;
            this.btnMyTasks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMyTasks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMyTasks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMyTasks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMyTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyTasks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(167)))), ((int)(((byte)(189)))));
            this.btnMyTasks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMyTasks.ForeColor = System.Drawing.Color.White;
            this.btnMyTasks.Location = new System.Drawing.Point(10, 85);
            this.btnMyTasks.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnMyTasks.Name = "btnMyTasks";
            this.btnMyTasks.Size = new System.Drawing.Size(115, 55);
            this.btnMyTasks.TabIndex = 4;
            this.btnMyTasks.Text = "My Tasks";
            this.btnMyTasks.Click += new System.EventHandler(this.btnMyTasks_Click);
            // 
            // btnNewTask
            // 
            this.btnNewTask.BorderRadius = 15;
            this.btnNewTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewTask.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNewTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(167)))), ((int)(((byte)(189)))));
            this.btnNewTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNewTask.ForeColor = System.Drawing.Color.White;
            this.btnNewTask.Location = new System.Drawing.Point(10, 466);
            this.btnNewTask.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(115, 55);
            this.btnNewTask.TabIndex = 5;
            this.btnNewTask.Text = "New Task";
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1280, 551);
            this.Controls.Add(this.pnlTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.pnlTasks.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTasks;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlActive;
        private Guna.UI2.WinForms.Guna2Button btnNewTask;
        private Guna.UI2.WinForms.Guna2Button btnMyTasks;
        private Guna.UI2.WinForms.Guna2Button btnTasks;
    }
}