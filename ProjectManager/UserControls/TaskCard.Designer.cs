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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskCard));
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlMid = new Guna.UI2.WinForms.Guna2Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTaskDate = new System.Windows.Forms.Label();
            this.lblProjectGroupName = new System.Windows.Forms.Label();
            this.lblTaskOwner = new System.Windows.Forms.Label();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlBadge = new System.Windows.Forms.Panel();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pnlFill.SuspendLayout();
            this.pnlMid.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.pnlFill.Controls.Add(this.pnlMid);
            this.pnlFill.Controls.Add(this.pnlBottom);
            this.pnlFill.Controls.Add(this.pnlTop);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(265, 246);
            this.pnlFill.TabIndex = 0;
            // 
            // pnlMid
            // 
            this.pnlMid.BackColor = System.Drawing.Color.Transparent;
            this.pnlMid.Controls.Add(this.lblContent);
            this.pnlMid.Controls.Add(this.lblProjectName);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(0, 45);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(265, 146);
            this.pnlMid.TabIndex = 2;
            // 
            // lblContent
            // 
            this.lblContent.BackColor = System.Drawing.Color.Transparent;
            this.lblContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContent.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContent.ForeColor = System.Drawing.Color.Linen;
            this.lblContent.Location = new System.Drawing.Point(0, 30);
            this.lblContent.Name = "lblContent";
            this.lblContent.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblContent.Size = new System.Drawing.Size(265, 116);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = resources.GetString("lblContent.Text");
            // 
            // lblProjectName
            // 
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProjectName.Location = new System.Drawing.Point(0, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblProjectName.Size = new System.Drawing.Size(265, 30);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "First design concept";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Controls.Add(this.lblTaskDate);
            this.pnlBottom.Controls.Add(this.lblProjectGroupName);
            this.pnlBottom.Controls.Add(this.lblTaskOwner);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 191);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(265, 55);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblTaskDate
            // 
            this.lblTaskDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTaskDate.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskDate.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblTaskDate.Location = new System.Drawing.Point(105, 0);
            this.lblTaskDate.Name = "lblTaskDate";
            this.lblTaskDate.Size = new System.Drawing.Size(160, 27);
            this.lblTaskDate.TabIndex = 2;
            this.lblTaskDate.Text = "2023-09-10 - 2023-09-10 ";
            this.lblTaskDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProjectGroupName
            // 
            this.lblProjectGroupName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectGroupName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProjectGroupName.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectGroupName.ForeColor = System.Drawing.Color.Gold;
            this.lblProjectGroupName.Location = new System.Drawing.Point(0, 0);
            this.lblProjectGroupName.Name = "lblProjectGroupName";
            this.lblProjectGroupName.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblProjectGroupName.Size = new System.Drawing.Size(105, 27);
            this.lblProjectGroupName.TabIndex = 1;
            this.lblProjectGroupName.Text = "Project V";
            this.lblProjectGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskOwner
            // 
            this.lblTaskOwner.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskOwner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTaskOwner.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskOwner.ForeColor = System.Drawing.Color.LightGreen;
            this.lblTaskOwner.Location = new System.Drawing.Point(0, 27);
            this.lblTaskOwner.Name = "lblTaskOwner";
            this.lblTaskOwner.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTaskOwner.Size = new System.Drawing.Size(265, 28);
            this.lblTaskOwner.TabIndex = 2;
            this.lblTaskOwner.Text = "A.hakan1818@hotmail.com";
            this.lblTaskOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.pnlBadge);
            this.pnlTop.Controls.Add(this.pbMenu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(3);
            this.pnlTop.Size = new System.Drawing.Size(265, 45);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlBadge
            // 
            this.pnlBadge.BackColor = System.Drawing.Color.Transparent;
            this.pnlBadge.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBadge.Location = new System.Drawing.Point(3, 3);
            this.pnlBadge.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBadge.Name = "pnlBadge";
            this.pnlBadge.Size = new System.Drawing.Size(201, 39);
            this.pnlBadge.TabIndex = 3;
            // 
            // pbMenu
            // 
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(204, 3);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(48, 42);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMenu.TabIndex = 2;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.Controls.Add(this.pnlFill);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(265, 246);
            this.pnlFill.ResumeLayout(false);
            this.pnlMid.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFill;
        private Guna.UI2.WinForms.Guna2Panel pnlMid;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.PictureBox pbMenu;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private System.Windows.Forms.Label lblProjectGroupName;
        private System.Windows.Forms.Label lblTaskDate;
        private System.Windows.Forms.Panel pnlBadge;
        private System.Windows.Forms.Label lblTaskOwner;
    }
}
