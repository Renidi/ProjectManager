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
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblProjectDescription = new System.Windows.Forms.Label();
            this.lblStartEndDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectName.ForeColor = System.Drawing.Color.Black;
            this.lblProjectName.Location = new System.Drawing.Point(0, 0);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(15);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Padding = new System.Windows.Forms.Padding(5);
            this.lblProjectName.Size = new System.Drawing.Size(107, 26);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Proje Star Trak";
            // 
            // lblProjectDescription
            // 
            this.lblProjectDescription.AutoSize = true;
            this.lblProjectDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProjectDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectDescription.ForeColor = System.Drawing.Color.Linen;
            this.lblProjectDescription.Location = new System.Drawing.Point(0, 26);
            this.lblProjectDescription.Name = "lblProjectDescription";
            this.lblProjectDescription.Padding = new System.Windows.Forms.Padding(15);
            this.lblProjectDescription.Size = new System.Drawing.Size(183, 45);
            this.lblProjectDescription.TabIndex = 1;
            this.lblProjectDescription.Text = "Proje Star Trak Description";
            // 
            // lblStartEndDate
            // 
            this.lblStartEndDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStartEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartEndDate.ForeColor = System.Drawing.Color.Linen;
            this.lblStartEndDate.Location = new System.Drawing.Point(0, 161);
            this.lblStartEndDate.Name = "lblStartEndDate";
            this.lblStartEndDate.Size = new System.Drawing.Size(345, 23);
            this.lblStartEndDate.TabIndex = 2;
            this.lblStartEndDate.Text = "TarihTarih xx/ Tarih Tarih xx";
            this.lblStartEndDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.Controls.Add(this.lblStartEndDate);
            this.Controls.Add(this.lblProjectDescription);
            this.Controls.Add(this.lblProjectName);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "ProjectControl";
            this.Size = new System.Drawing.Size(345, 184);
            this.Load += new System.EventHandler(this.ProjectControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblProjectDescription;
        private System.Windows.Forms.Label lblStartEndDate;
    }
}
