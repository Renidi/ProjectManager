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
            this.lblTeamName = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblDescription);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnlMain.Size = new System.Drawing.Size(223, 108);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDoubleClick);
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(3, 31);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.lblDescription.Size = new System.Drawing.Size(217, 29);
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
            this.pnlBottom.Location = new System.Drawing.Point(3, 60);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(217, 48);
            this.pnlBottom.TabIndex = 10;
            // 
            // lblTaskProjectCount
            // 
            this.lblTaskProjectCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTaskProjectCount.Location = new System.Drawing.Point(0, 35);
            this.lblTaskProjectCount.Name = "lblTaskProjectCount";
            this.lblTaskProjectCount.Size = new System.Drawing.Size(217, 13);
            this.lblTaskProjectCount.TabIndex = 6;
            this.lblTaskProjectCount.Text = "XXX Proje   XXX Task";
            this.lblTaskProjectCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamLeaderMail
            // 
            this.lblTeamLeaderMail.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.pnlTop.Controls.Add(this.lblTeamName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(217, 28);
            this.pnlTop.TabIndex = 9;
            // 
            // lblTeamName
            // 
            this.lblTeamName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeamName.Location = new System.Drawing.Point(0, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(217, 28);
            this.lblTeamName.TabIndex = 6;
            this.lblTeamName.Text = "Tringle.io Dev Team";
            this.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTeamName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblTeamName_MouseDoubleClick);
            // 
            // TeamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.pnlMain);
            this.Name = "TeamControl";
            this.Size = new System.Drawing.Size(223, 108);
            this.Load += new System.EventHandler(this.TeamsControl_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
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
    }
}
