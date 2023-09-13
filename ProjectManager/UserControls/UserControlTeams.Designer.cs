namespace ProjectManager.UserControls
{
    partial class UserControlTeams
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAuth = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.cmbAuth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(13, 13);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(105, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Ahmet Hakan Demir ";
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Location = new System.Drawing.Point(268, 13);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(38, 13);
            this.lblAuth.TabIndex = 1;
            this.lblAuth.Text = "Owner";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(124, 13);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(138, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "A.hakan1818@hotmail.com";
            // 
            // cmbAuth
            // 
            this.cmbAuth.FormattingEnabled = true;
            this.cmbAuth.Items.AddRange(new object[] {
            "Remove Member",
            "Member",
            "Admin",
            "Owner"});
            this.cmbAuth.Location = new System.Drawing.Point(312, 10);
            this.cmbAuth.Name = "cmbAuth";
            this.cmbAuth.Size = new System.Drawing.Size(121, 21);
            this.cmbAuth.TabIndex = 5;
            this.cmbAuth.SelectedIndexChanged += new System.EventHandler(this.cmbAuth_SelectedIndexChanged);
            // 
            // UserControlTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbAuth);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.lblFullName);
            this.Name = "UserControlTeams";
            this.Size = new System.Drawing.Size(446, 40);
            this.Load += new System.EventHandler(this.UserControlTeams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ComboBox cmbAuth;
    }
}
