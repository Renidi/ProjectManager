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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.rtxDes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInvite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txInviteUserMail = new System.Windows.Forms.TextBox();
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pbExit);
            this.panel1.Controls.Add(this.rtxDes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnInvite);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txInviteUserMail);
            this.panel1.Controls.Add(this.cmbTeams);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 278);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Image = global::ProjectManager.Properties.Resources.delete;
            this.pbExit.Location = new System.Drawing.Point(477, 0);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 32);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 15;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // rtxDes
            // 
            this.rtxDes.Enabled = false;
            this.rtxDes.Location = new System.Drawing.Point(188, 67);
            this.rtxDes.Name = "rtxDes";
            this.rtxDes.Size = new System.Drawing.Size(121, 68);
            this.rtxDes.TabIndex = 14;
            this.rtxDes.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Team Description";
            // 
            // btnInvite
            // 
            this.btnInvite.Location = new System.Drawing.Point(206, 194);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Size = new System.Drawing.Size(75, 23);
            this.btnInvite.TabIndex = 12;
            this.btnInvite.Text = "Invite";
            this.btnInvite.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "User Mail";
            // 
            // txInviteUserMail
            // 
            this.txInviteUserMail.Location = new System.Drawing.Point(188, 141);
            this.txInviteUserMail.Name = "txInviteUserMail";
            this.txInviteUserMail.Size = new System.Drawing.Size(121, 20);
            this.txInviteUserMail.TabIndex = 10;
            // 
            // cmbTeams
            // 
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(188, 40);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(121, 21);
            this.cmbTeams.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Team";
            // 
            // PopupAddMembeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(513, 282);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupAddMembeer";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "PopupAddMembeer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PopupAddMembeer_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.RichTextBox rtxDes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInvite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txInviteUserMail;
        private System.Windows.Forms.ComboBox cmbTeams;
        private System.Windows.Forms.Label label1;
    }
}