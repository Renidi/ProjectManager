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
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProjectName.Location = new System.Drawing.Point(0, 0);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(15);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Padding = new System.Windows.Forms.Padding(5);
            this.lblProjectName.Size = new System.Drawing.Size(88, 23);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Proje Star Trak";
            // 
            // lblProjectDescription
            // 
            this.lblProjectDescription.AutoSize = true;
            this.lblProjectDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProjectDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblProjectDescription.Location = new System.Drawing.Point(0, 23);
            this.lblProjectDescription.Name = "lblProjectDescription";
            this.lblProjectDescription.Padding = new System.Windows.Forms.Padding(15);
            this.lblProjectDescription.Size = new System.Drawing.Size(164, 43);
            this.lblProjectDescription.TabIndex = 1;
            this.lblProjectDescription.Text = "Proje Star Trak Description";
            // 
            // ProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.lblProjectDescription);
            this.Controls.Add(this.lblProjectName);
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "ProjectControl";
            this.Size = new System.Drawing.Size(245, 169);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblProjectDescription;
    }
}
