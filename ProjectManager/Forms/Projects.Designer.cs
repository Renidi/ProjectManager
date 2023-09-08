namespace ProjectManager
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
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnMyProjects = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.pnlMiddle.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.Black;
            this.pnlMiddle.Controls.Add(this.pnlActive);
            this.pnlMiddle.Controls.Add(this.pnlControls);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 0);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1280, 551);
            this.pnlMiddle.TabIndex = 3;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pnlActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActive.Location = new System.Drawing.Point(124, 0);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(1156, 551);
            this.pnlActive.TabIndex = 44;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Black;
            this.pnlControls.Controls.Add(this.btnMyProjects);
            this.pnlControls.Controls.Add(this.btnNewProject);
            this.pnlControls.Controls.Add(this.btnProjects);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(124, 551);
            this.pnlControls.TabIndex = 43;
            // 
            // btnMyProjects
            // 
            this.btnMyProjects.Location = new System.Drawing.Point(12, 53);
            this.btnMyProjects.Name = "btnMyProjects";
            this.btnMyProjects.Size = new System.Drawing.Size(94, 36);
            this.btnMyProjects.TabIndex = 2;
            this.btnMyProjects.Text = "MyProjects";
            this.btnMyProjects.UseVisualStyleBackColor = true;
            this.btnMyProjects.Click += new System.EventHandler(this.btnMyProjects_Click_1);
            // 
            // btnNewProject
            // 
            this.btnNewProject.Location = new System.Drawing.Point(12, 501);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(94, 38);
            this.btnNewProject.TabIndex = 1;
            this.btnNewProject.Text = "New Project";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click_1);
            // 
            // btnProjects
            // 
            this.btnProjects.Location = new System.Drawing.Point(12, 6);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(94, 41);
            this.btnProjects.TabIndex = 0;
            this.btnProjects.Text = "Projects";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click_1);
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
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnMyProjects;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Panel pnlActive;
    }
}