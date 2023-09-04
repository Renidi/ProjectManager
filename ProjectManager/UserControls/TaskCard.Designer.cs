namespace ProjectManager.UserControls
{
    partial class TaskCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskCard));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlMid = new Guna.UI2.WinForms.Guna2Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBadge = new Guna.UI2.WinForms.Guna2Panel();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.badge1 = new ProjectManager.UserControls.Badge();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.pnlFill.SuspendLayout();
            this.pnlMid.SuspendLayout();
            this.pnlBadge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.pnlMid);
            this.pnlFill.Controls.Add(this.pnlBottom);
            this.pnlFill.Controls.Add(this.pnlBadge);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(298, 265);
            this.pnlFill.TabIndex = 0;
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.lblContent);
            this.pnlMid.Controls.Add(this.lblTitle);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(0, 48);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(298, 162);
            this.pnlMid.TabIndex = 2;
            // 
            // lblContent
            // 
            this.lblContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContent.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.lblContent.Location = new System.Drawing.Point(0, 39);
            this.lblContent.Name = "lblContent";
            this.lblContent.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblContent.Size = new System.Drawing.Size(298, 123);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = resources.GetString("lblContent.Text");
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(298, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "First design concept";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBadge
            // 
            this.pnlBadge.Controls.Add(this.badge1);
            this.pnlBadge.Controls.Add(this.pbMenu);
            this.pnlBadge.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBadge.Location = new System.Drawing.Point(0, 0);
            this.pnlBadge.Name = "pnlBadge";
            this.pnlBadge.Size = new System.Drawing.Size(298, 48);
            this.pnlBadge.TabIndex = 0;
            // 
            // pbMenu
            // 
            this.pbMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(250, 0);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(48, 48);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMenu.TabIndex = 2;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // badge1
            // 
            this.badge1.Location = new System.Drawing.Point(15, 11);
            this.badge1.Name = "badge1";
            this.badge1.Size = new System.Drawing.Size(85, 26);
            this.badge1.TabIndex = 3;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.badge1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblProjectName);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 210);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(298, 55);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblProjectName
            // 
            this.lblProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProjectName.Location = new System.Drawing.Point(0, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblProjectName.Size = new System.Drawing.Size(298, 39);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "Project V";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.pnlFill);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(298, 265);
            this.pnlFill.ResumeLayout(false);
            this.pnlMid.ResumeLayout(false);
            this.pnlBadge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel pnlFill;
        private Guna.UI2.WinForms.Guna2Panel pnlMid;
        private Guna.UI2.WinForms.Guna2Panel pnlBadge;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbMenu;
        private Badge badge1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private System.Windows.Forms.Label lblProjectName;
    }
}
