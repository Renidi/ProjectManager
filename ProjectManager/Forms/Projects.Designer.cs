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
            this.btnNewProject = new Guna.UI2.WinForms.Guna2Button();
            this.btnProject = new Guna.UI2.WinForms.Guna2Button();
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
            this.pnlActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.pnlActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActive.Location = new System.Drawing.Point(135, 0);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(1145, 551);
            this.pnlActive.TabIndex = 44;
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(176)))), ((int)(((byte)(165)))));
            this.pnlControls.Controls.Add(this.btnNewProject);
            this.pnlControls.Controls.Add(this.btnProject);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(10, 30, 10, 0);
            this.pnlControls.Size = new System.Drawing.Size(135, 551);
            this.pnlControls.TabIndex = 43;
            // 
            // btnNewProject
            // 
            this.btnNewProject.BorderRadius = 15;
            this.btnNewProject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewProject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewProject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(167)))), ((int)(((byte)(189)))));
            this.btnNewProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNewProject.ForeColor = System.Drawing.Color.White;
            this.btnNewProject.Location = new System.Drawing.Point(10, 85);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(115, 53);
            this.btnNewProject.TabIndex = 3;
            this.btnNewProject.Text = "New Project";
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // btnProject
            // 
            this.btnProject.BorderRadius = 15;
            this.btnProject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(167)))), ((int)(((byte)(189)))));
            this.btnProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProject.ForeColor = System.Drawing.Color.White;
            this.btnProject.Location = new System.Drawing.Point(10, 30);
            this.btnProject.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(115, 55);
            this.btnProject.TabIndex = 2;
            this.btnProject.Text = "Projects";
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
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
        private System.Windows.Forms.Panel pnlActive;
        private Guna.UI2.WinForms.Guna2Button btnNewProject;
        private Guna.UI2.WinForms.Guna2Button btnProject;
    }
}