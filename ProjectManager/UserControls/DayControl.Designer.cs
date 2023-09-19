namespace ProjectManager
{
    partial class DayControl
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
            this.lbl = new System.Windows.Forms.Label();
            this.lblProject1 = new System.Windows.Forms.Label();
            this.lblProject2 = new System.Windows.Forms.Label();
            this.lblProject3 = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(4, 4);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(21, 16);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "00";
            // 
            // lblProject1
            // 
            this.lblProject1.AutoSize = true;
            this.lblProject1.Location = new System.Drawing.Point(7, 24);
            this.lblProject1.Name = "lblProject1";
            this.lblProject1.Size = new System.Drawing.Size(0, 13);
            this.lblProject1.TabIndex = 1;
            // 
            // lblProject2
            // 
            this.lblProject2.AutoSize = true;
            this.lblProject2.Location = new System.Drawing.Point(7, 37);
            this.lblProject2.Name = "lblProject2";
            this.lblProject2.Size = new System.Drawing.Size(0, 13);
            this.lblProject2.TabIndex = 2;
            // 
            // lblProject3
            // 
            this.lblProject3.AutoSize = true;
            this.lblProject3.Location = new System.Drawing.Point(7, 50);
            this.lblProject3.Name = "lblProject3";
            this.lblProject3.Size = new System.Drawing.Size(0, 13);
            this.lblProject3.TabIndex = 3;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(112, 56);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(0, 13);
            this.lblExtra.TabIndex = 4;
            // 
            // DayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.lblProject3);
            this.Controls.Add(this.lblProject2);
            this.Controls.Add(this.lblProject1);
            this.Controls.Add(this.lbl);
            this.Name = "DayControl";
            this.Size = new System.Drawing.Size(150, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblProject1;
        private System.Windows.Forms.Label lblProject2;
        private System.Windows.Forms.Label lblProject3;
        private System.Windows.Forms.Label lblExtra;
    }
}
