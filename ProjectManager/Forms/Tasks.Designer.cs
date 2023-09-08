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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnMyTasks = new System.Windows.Forms.Button();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.pnlActive = new System.Windows.Forms.Panel();
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
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Black;
            this.pnlControls.Controls.Add(this.btnMyTasks);
            this.pnlControls.Controls.Add(this.btnNewTask);
            this.pnlControls.Controls.Add(this.btnTasks);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(124, 551);
            this.pnlControls.TabIndex = 44;
            // 
            // btnMyTasks
            // 
            this.btnMyTasks.Location = new System.Drawing.Point(12, 53);
            this.btnMyTasks.Name = "btnMyTasks";
            this.btnMyTasks.Size = new System.Drawing.Size(94, 36);
            this.btnMyTasks.TabIndex = 2;
            this.btnMyTasks.Text = "MyTasks";
            this.btnMyTasks.UseVisualStyleBackColor = true;
            this.btnMyTasks.Click += new System.EventHandler(this.btnMyTasks_Click);
            // 
            // btnNewTask
            // 
            this.btnNewTask.Location = new System.Drawing.Point(12, 501);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(94, 38);
            this.btnNewTask.TabIndex = 1;
            this.btnNewTask.Text = "New Task";
            this.btnNewTask.UseVisualStyleBackColor = true;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(12, 6);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(94, 41);
            this.btnTasks.TabIndex = 0;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pnlActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActive.Location = new System.Drawing.Point(124, 0);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(1156, 551);
            this.pnlActive.TabIndex = 45;
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
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTasks;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnMyTasks;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Panel pnlActive;
    }
}