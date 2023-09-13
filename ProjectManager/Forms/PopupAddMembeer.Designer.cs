namespace ProjectManager.Forms
{
    partial class PopupAddMembeer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.txInviteUserMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInvite = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxDes = new System.Windows.Forms.RichTextBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team";
            // 
            // cmbTeams
            // 
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(196, 52);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(121, 21);
            this.cmbTeams.TabIndex = 1;
            this.cmbTeams.SelectedIndexChanged += new System.EventHandler(this.cmbTeams_SelectedIndexChanged);
            // 
            // txInviteUserMail
            // 
            this.txInviteUserMail.Location = new System.Drawing.Point(196, 153);
            this.txInviteUserMail.Name = "txInviteUserMail";
            this.txInviteUserMail.Size = new System.Drawing.Size(121, 20);
            this.txInviteUserMail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Mail";
            // 
            // btnInvite
            // 
            this.btnInvite.Location = new System.Drawing.Point(214, 206);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Size = new System.Drawing.Size(75, 23);
            this.btnInvite.TabIndex = 4;
            this.btnInvite.Text = "Invite";
            this.btnInvite.UseVisualStyleBackColor = true;
            this.btnInvite.Click += new System.EventHandler(this.btnInvite_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Team Description";
            // 
            // rtxDes
            // 
            this.rtxDes.Enabled = false;
            this.rtxDes.Location = new System.Drawing.Point(196, 79);
            this.rtxDes.Name = "rtxDes";
            this.rtxDes.Size = new System.Drawing.Size(121, 68);
            this.rtxDes.TabIndex = 6;
            this.rtxDes.Text = "";
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Image = global::ProjectManager.Properties.Resources.delete;
            this.pbExit.Location = new System.Drawing.Point(469, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 32);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 7;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // PopupAddMembeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(513, 282);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.rtxDes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInvite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txInviteUserMail);
            this.Controls.Add(this.cmbTeams);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupAddMembeer";
            this.Text = "PopupAddMembeer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PopupAddMembeer_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTeams;
        private System.Windows.Forms.TextBox txInviteUserMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInvite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxDes;
        private System.Windows.Forms.PictureBox pbExit;
    }
}