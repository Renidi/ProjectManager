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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team";
            // 
            // cmbTeams
            // 
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(203, 29);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(121, 21);
            this.cmbTeams.TabIndex = 1;
            this.cmbTeams.SelectedIndexChanged += new System.EventHandler(this.cmbTeams_SelectedIndexChanged);
            // 
            // txInviteUserMail
            // 
            this.txInviteUserMail.Location = new System.Drawing.Point(203, 130);
            this.txInviteUserMail.Name = "txInviteUserMail";
            this.txInviteUserMail.Size = new System.Drawing.Size(121, 20);
            this.txInviteUserMail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Mail";
            // 
            // btnInvite
            // 
            this.btnInvite.Location = new System.Drawing.Point(221, 183);
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
            this.label3.Location = new System.Drawing.Point(107, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Team Description";
            // 
            // rtxDes
            // 
            this.rtxDes.Enabled = false;
            this.rtxDes.Location = new System.Drawing.Point(203, 56);
            this.rtxDes.Name = "rtxDes";
            this.rtxDes.Size = new System.Drawing.Size(121, 68);
            this.rtxDes.TabIndex = 6;
            this.rtxDes.Text = "";
            // 
            // PopupAddMembeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 282);
            this.Controls.Add(this.rtxDes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInvite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txInviteUserMail);
            this.Controls.Add(this.cmbTeams);
            this.Controls.Add(this.label1);
            this.Name = "PopupAddMembeer";
            this.Text = "PopupAddMembeer";
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
    }
}