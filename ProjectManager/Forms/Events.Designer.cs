namespace ProjectManager
{
    partial class Events
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pbTask = new System.Windows.Forms.PictureBox();
            this.pbUserSettings = new System.Windows.Forms.PictureBox();
            this.pbTeams = new System.Windows.Forms.PictureBox();
            this.pbProject = new System.Windows.Forms.PictureBox();
            this.pbCalender = new System.Windows.Forms.PictureBox();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalender)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.lblAdSoyad);
            this.pnlTop.Controls.Add(this.lblMail);
            this.pnlTop.Controls.Add(this.pbExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1280, 83);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdSoyad.Location = new System.Drawing.Point(1052, 33);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(116, 20);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "User Ad Soyad";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(1052, 57);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(75, 20);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "User Mail";
            // 
            // pbExit
            // 
            this.pbExit.Image = global::ProjectManager.Properties.Resources.delete;
            this.pbExit.Location = new System.Drawing.Point(1236, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 32);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 0;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBottom.Controls.Add(this.pbTask);
            this.pnlBottom.Controls.Add(this.pbUserSettings);
            this.pnlBottom.Controls.Add(this.pbTeams);
            this.pnlBottom.Controls.Add(this.pbProject);
            this.pnlBottom.Controls.Add(this.pbCalender);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 634);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1280, 86);
            this.pnlBottom.TabIndex = 4;
            // 
            // pbTask
            // 
            this.pbTask.Image = global::ProjectManager.Properties.Resources.work_process;
            this.pbTask.Location = new System.Drawing.Point(554, 28);
            this.pbTask.Name = "pbTask";
            this.pbTask.Size = new System.Drawing.Size(32, 32);
            this.pbTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTask.TabIndex = 1;
            this.pbTask.TabStop = false;
            this.pbTask.Click += new System.EventHandler(this.pbTask_Click);
            // 
            // pbUserSettings
            // 
            this.pbUserSettings.Image = global::ProjectManager.Properties.Resources.user;
            this.pbUserSettings.Location = new System.Drawing.Point(760, 28);
            this.pbUserSettings.Name = "pbUserSettings";
            this.pbUserSettings.Size = new System.Drawing.Size(32, 32);
            this.pbUserSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserSettings.TabIndex = 4;
            this.pbUserSettings.TabStop = false;
            this.pbUserSettings.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pbTeams
            // 
            this.pbTeams.Image = global::ProjectManager.Properties.Resources.teamwork;
            this.pbTeams.Location = new System.Drawing.Point(692, 28);
            this.pbTeams.Name = "pbTeams";
            this.pbTeams.Size = new System.Drawing.Size(32, 32);
            this.pbTeams.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTeams.TabIndex = 3;
            this.pbTeams.TabStop = false;
            // 
            // pbProject
            // 
            this.pbProject.Image = global::ProjectManager.Properties.Resources.project_management;
            this.pbProject.Location = new System.Drawing.Point(479, 28);
            this.pbProject.Name = "pbProject";
            this.pbProject.Size = new System.Drawing.Size(32, 32);
            this.pbProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProject.TabIndex = 2;
            this.pbProject.TabStop = false;
            this.pbProject.Click += new System.EventHandler(this.pbProject_Click);
            // 
            // pbCalender
            // 
            this.pbCalender.Image = global::ProjectManager.Properties.Resources.calendar;
            this.pbCalender.Location = new System.Drawing.Point(623, 28);
            this.pbCalender.Name = "pbCalender";
            this.pbCalender.Size = new System.Drawing.Size(32, 32);
            this.pbCalender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCalender.TabIndex = 1;
            this.pbCalender.TabStop = false;
            this.pbCalender.Click += new System.EventHandler(this.pbCalender_Click);
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.Silver;
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 83);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1280, 551);
            this.pnlMiddle.TabIndex = 2;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMiddle);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbUserSettings;
        private System.Windows.Forms.PictureBox pbTeams;
        private System.Windows.Forms.PictureBox pbProject;
        private System.Windows.Forms.PictureBox pbCalender;
        private System.Windows.Forms.PictureBox pbTask;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Label lblAdSoyad;
    }
}