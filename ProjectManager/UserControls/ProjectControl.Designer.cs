namespace ProjectManager.UserControls
{
    partial class ProjectControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectControl));
            this.pnlMainProject = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblProjectDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblProjectTeam = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProjectStatus = new System.Windows.Forms.Label();
            this.lblStartEndDate = new System.Windows.Forms.Label();
            this.pnlMainProject.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainProject
            // 
            this.pnlMainProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.pnlMainProject.Controls.Add(this.panel5);
            this.pnlMainProject.Controls.Add(this.panel1);
            this.pnlMainProject.Controls.Add(this.panel2);
            this.pnlMainProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainProject.Location = new System.Drawing.Point(0, 0);
            this.pnlMainProject.Name = "pnlMainProject";
            this.pnlMainProject.Size = new System.Drawing.Size(357, 279);
            this.pnlMainProject.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblProjectDescription);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 161);
            this.panel5.TabIndex = 11;
            // 
            // lblProjectDescription
            // 
            this.lblProjectDescription.AutoSize = true;
            this.lblProjectDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProjectDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectDescription.ForeColor = System.Drawing.Color.Linen;
            this.lblProjectDescription.Location = new System.Drawing.Point(0, 0);
            this.lblProjectDescription.Name = "lblProjectDescription";
            this.lblProjectDescription.Padding = new System.Windows.Forms.Padding(15);
            this.lblProjectDescription.Size = new System.Drawing.Size(190, 45);
            this.lblProjectDescription.TabIndex = 4;
            this.lblProjectDescription.Text = "Project Iron Man description";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbMenu);
            this.panel1.Controls.Add(this.lblProjectName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 52);
            this.panel1.TabIndex = 10;
            // 
            // pbMenu
            // 
            this.pbMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(309, 0);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(48, 52);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMenu.TabIndex = 9;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectName.ForeColor = System.Drawing.Color.Black;
            this.lblProjectName.Location = new System.Drawing.Point(0, 0);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(15);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Padding = new System.Windows.Forms.Padding(5);
            this.lblProjectName.Size = new System.Drawing.Size(259, 52);
            this.lblProjectName.TabIndex = 3;
            this.lblProjectName.Text = "Project Iron Man";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 66);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblProjectTeam);
            this.panel4.Controls.Add(this.lblPriority);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 38);
            this.panel4.TabIndex = 12;
            // 
            // lblProjectTeam
            // 
            this.lblProjectTeam.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProjectTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectTeam.ForeColor = System.Drawing.Color.Linen;
            this.lblProjectTeam.Location = new System.Drawing.Point(0, 0);
            this.lblProjectTeam.Name = "lblProjectTeam";
            this.lblProjectTeam.Size = new System.Drawing.Size(158, 38);
            this.lblProjectTeam.TabIndex = 10;
            this.lblProjectTeam.Text = "Project Team";
            this.lblProjectTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriority
            // 
            this.lblPriority.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPriority.ForeColor = System.Drawing.Color.Linen;
            this.lblPriority.Location = new System.Drawing.Point(240, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(117, 38);
            this.lblPriority.TabIndex = 9;
            this.lblPriority.Text = "Project Priority";
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblProjectStatus);
            this.panel3.Controls.Add(this.lblStartEndDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 28);
            this.panel3.TabIndex = 11;
            // 
            // lblProjectStatus
            // 
            this.lblProjectStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProjectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectStatus.ForeColor = System.Drawing.Color.Linen;
            this.lblProjectStatus.Location = new System.Drawing.Point(0, 0);
            this.lblProjectStatus.Name = "lblProjectStatus";
            this.lblProjectStatus.Size = new System.Drawing.Size(106, 28);
            this.lblProjectStatus.TabIndex = 11;
            this.lblProjectStatus.Text = "Project Status";
            this.lblProjectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartEndDate
            // 
            this.lblStartEndDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStartEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartEndDate.ForeColor = System.Drawing.Color.Linen;
            this.lblStartEndDate.Location = new System.Drawing.Point(182, 0);
            this.lblStartEndDate.Name = "lblStartEndDate";
            this.lblStartEndDate.Size = new System.Drawing.Size(175, 28);
            this.lblStartEndDate.TabIndex = 8;
            this.lblStartEndDate.Text = "TarihTarih xx/ Tarih Tarih xx";
            this.lblStartEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.Controls.Add(this.pnlMainProject);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "ProjectControl";
            this.Size = new System.Drawing.Size(357, 279);
            this.pnlMainProject.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainProject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblProjectTeam;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblProjectStatus;
        private System.Windows.Forms.Label lblStartEndDate;
        private System.Windows.Forms.Label lblProjectDescription;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
    }
}
