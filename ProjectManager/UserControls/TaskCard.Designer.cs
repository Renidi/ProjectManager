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
            this.lblProjectName = new System.Windows.Forms.Label();
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProjectGroupName = new System.Windows.Forms.Label();
            this.pnlBadge = new Guna.UI2.WinForms.Guna2Panel();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.badge1 = new ProjectManager.UserControls.Badge();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlFill.SuspendLayout();
            this.pnlMid.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlBadge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(25)))));
            this.pnlFill.Controls.Add(this.pnlMid);
            this.pnlFill.Controls.Add(this.pnlBottom);
            this.pnlFill.Controls.Add(this.pnlBadge);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(270, 207);
            this.pnlFill.TabIndex = 0;
            // 
            // pnlMid
            // 
            this.pnlMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(25)))));
            this.pnlMid.Controls.Add(this.lblContent);
            this.pnlMid.Controls.Add(this.lblProjectName);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(0, 48);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(270, 104);
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
            this.lblContent.Size = new System.Drawing.Size(270, 65);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = resources.GetString("lblContent.Text");
            this.lblContent.MouseEnter += new System.EventHandler(this.lblContent_MouseEnter);
            this.lblContent.MouseLeave += new System.EventHandler(this.lblContent_MouseLeave);
            // 
            // lblProjectName
            // 
            this.lblProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProjectName.Location = new System.Drawing.Point(0, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblProjectName.Size = new System.Drawing.Size(270, 39);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "First design concept";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(25)))));
            this.pnlBottom.Controls.Add(this.lblProjectGroupName);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 152);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(270, 55);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblProjectGroupName
            // 
            this.lblProjectGroupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(25)))));
            this.lblProjectGroupName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectGroupName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectGroupName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProjectGroupName.Location = new System.Drawing.Point(0, 0);
            this.lblProjectGroupName.Name = "lblProjectGroupName";
            this.lblProjectGroupName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblProjectGroupName.Size = new System.Drawing.Size(270, 39);
            this.lblProjectGroupName.TabIndex = 1;
            this.lblProjectGroupName.Text = "Project V";
            this.lblProjectGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBadge
            // 
            this.pnlBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(25)))));
            this.pnlBadge.Controls.Add(this.badge1);
            this.pnlBadge.Controls.Add(this.pbMenu);
            this.pnlBadge.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBadge.Location = new System.Drawing.Point(0, 0);
            this.pnlBadge.Name = "pnlBadge";
            this.pnlBadge.Size = new System.Drawing.Size(270, 48);
            this.pnlBadge.TabIndex = 0;
            // 
            // pbMenu
            // 
            this.pbMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(222, 0);
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
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.pnlFill);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(270, 207);
            this.Load += new System.EventHandler(this.TaskCard_Load);
            this.pnlFill.ResumeLayout(false);
            this.pnlMid.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBadge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel pnlFill;
        private Guna.UI2.WinForms.Guna2Panel pnlMid;
        private Guna.UI2.WinForms.Guna2Panel pnlBadge;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.PictureBox pbMenu;
        private Badge badge1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private System.Windows.Forms.Label lblProjectGroupName;
    }
}
