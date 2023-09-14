namespace ProjectManager.Forms
{
    partial class TeamControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamControl));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTaskProjectCount = new System.Windows.Forms.Label();
            this.lblTeamLeaderMail = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.pnlMain.Controls.Add(this.lblDescription);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnlMain.Size = new System.Drawing.Size(223, 135);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDoubleClick);
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(3, 40);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.lblDescription.Size = new System.Drawing.Size(217, 47);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            this.lblDescription.TextChanged += new System.EventHandler(this.lblDescription_TextChanged);
            this.lblDescription.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblDescription_MouseDoubleClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblTaskProjectCount);
            this.pnlBottom.Controls.Add(this.lblTeamLeaderMail);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(3, 87);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlBottom.Size = new System.Drawing.Size(217, 48);
            this.pnlBottom.TabIndex = 10;
            // 
            // lblTaskProjectCount
            // 
            this.lblTaskProjectCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTaskProjectCount.ForeColor = System.Drawing.Color.White;
            this.lblTaskProjectCount.Location = new System.Drawing.Point(0, 30);
            this.lblTaskProjectCount.Name = "lblTaskProjectCount";
            this.lblTaskProjectCount.Size = new System.Drawing.Size(217, 13);
            this.lblTaskProjectCount.TabIndex = 6;
            this.lblTaskProjectCount.Text = "XXX Proje   XXX Task";
            this.lblTaskProjectCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamLeaderMail
            // 
            this.lblTeamLeaderMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTeamLeaderMail.ForeColor = System.Drawing.Color.White;
            this.lblTeamLeaderMail.Location = new System.Drawing.Point(0, 0);
            this.lblTeamLeaderMail.Margin = new System.Windows.Forms.Padding(3);
            this.lblTeamLeaderMail.Name = "lblTeamLeaderMail";
            this.lblTeamLeaderMail.Size = new System.Drawing.Size(217, 21);
            this.lblTeamLeaderMail.TabIndex = 8;
            this.lblTeamLeaderMail.Text = "Team Leader : a.hakan1818@hotmail.com";
            this.lblTeamLeaderMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pbMenu);
            this.pnlTop.Controls.Add(this.lblTeamName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(217, 37);
            this.pnlTop.TabIndex = 9;
            // 
            // pbMenu
            // 
            this.pbMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(169, 0);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(48, 37);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMenu.TabIndex = 7;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // lblTeamName
            // 
            this.lblTeamName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeamName.ForeColor = System.Drawing.Color.White;
            this.lblTeamName.Location = new System.Drawing.Point(0, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(163, 37);
            this.lblTeamName.TabIndex = 6;
            this.lblTeamName.Text = "Tringle.io Dev Team";
            this.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTeamName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblTeamName_MouseDoubleClick);
            // 
            // TeamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "TeamControl";
            this.Size = new System.Drawing.Size(223, 135);
            this.Load += new System.EventHandler(this.TeamsControl_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTaskProjectCount;
        private System.Windows.Forms.Label lblTeamLeaderMail;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pbMenu;
    }
}
