namespace ProjectManager
{
    partial class Teams
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
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.btnRejectRequest = new Guna.UI2.WinForms.Guna2Button();
            this.btnJoinRequest = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMember = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMemebers = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTeams = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewTeam = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.pnlMiddle.Controls.Add(this.btnRejectRequest);
            this.pnlMiddle.Controls.Add(this.btnJoinRequest);
            this.pnlMiddle.Controls.Add(this.btnAddMember);
            this.pnlMiddle.Controls.Add(this.pnlMemebers);
            this.pnlMiddle.Controls.Add(this.pnlRequests);
            this.pnlMiddle.Controls.Add(this.pnlTeams);
            this.pnlMiddle.Controls.Add(this.btnNewTeam);
            this.pnlMiddle.Controls.Add(this.label3);
            this.pnlMiddle.Controls.Add(this.label2);
            this.pnlMiddle.Controls.Add(this.label1);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 0);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1280, 551);
            this.pnlMiddle.TabIndex = 4;
            // 
            // btnRejectRequest
            // 
            this.btnRejectRequest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRejectRequest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRejectRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRejectRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRejectRequest.Enabled = false;
            this.btnRejectRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRejectRequest.ForeColor = System.Drawing.Color.White;
            this.btnRejectRequest.Location = new System.Drawing.Point(853, 460);
            this.btnRejectRequest.Name = "btnRejectRequest";
            this.btnRejectRequest.Size = new System.Drawing.Size(115, 45);
            this.btnRejectRequest.TabIndex = 14;
            this.btnRejectRequest.Text = "Reject";
            this.btnRejectRequest.Click += new System.EventHandler(this.btnRejectRequest_Click);
            // 
            // btnJoinRequest
            // 
            this.btnJoinRequest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJoinRequest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJoinRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJoinRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJoinRequest.Enabled = false;
            this.btnJoinRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnJoinRequest.ForeColor = System.Drawing.Color.White;
            this.btnJoinRequest.Location = new System.Drawing.Point(722, 460);
            this.btnJoinRequest.Name = "btnJoinRequest";
            this.btnJoinRequest.Size = new System.Drawing.Size(115, 45);
            this.btnJoinRequest.TabIndex = 13;
            this.btnJoinRequest.Text = "Join";
            this.btnJoinRequest.Click += new System.EventHandler(this.btnJoinRequest_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMember.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMember.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Location = new System.Drawing.Point(143, 460);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(115, 45);
            this.btnAddMember.TabIndex = 12;
            this.btnAddMember.Text = "Invite Member";
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // pnlMemebers
            // 
            this.pnlMemebers.BackColor = System.Drawing.Color.Gray;
            this.pnlMemebers.Location = new System.Drawing.Point(264, 25);
            this.pnlMemebers.Name = "pnlMemebers";
            this.pnlMemebers.Size = new System.Drawing.Size(452, 429);
            this.pnlMemebers.TabIndex = 11;
            // 
            // pnlRequests
            // 
            this.pnlRequests.BackColor = System.Drawing.Color.Gray;
            this.pnlRequests.Location = new System.Drawing.Point(722, 25);
            this.pnlRequests.Name = "pnlRequests";
            this.pnlRequests.Size = new System.Drawing.Size(246, 429);
            this.pnlRequests.TabIndex = 10;
            // 
            // pnlTeams
            // 
            this.pnlTeams.BackColor = System.Drawing.Color.Gray;
            this.pnlTeams.Location = new System.Drawing.Point(12, 25);
            this.pnlTeams.Name = "pnlTeams";
            this.pnlTeams.Size = new System.Drawing.Size(246, 429);
            this.pnlTeams.TabIndex = 9;
            // 
            // btnNewTeam
            // 
            this.btnNewTeam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewTeam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNewTeam.ForeColor = System.Drawing.Color.White;
            this.btnNewTeam.Location = new System.Drawing.Point(12, 460);
            this.btnNewTeam.Name = "btnNewTeam";
            this.btnNewTeam.Size = new System.Drawing.Size(115, 45);
            this.btnNewTeam.TabIndex = 7;
            this.btnNewTeam.Text = "New Team";
            this.btnNewTeam.Click += new System.EventHandler(this.btnNewTeam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(802, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Group Requests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teams";
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1280, 551);
            this.Controls.Add(this.pnlMiddle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teams";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMiddle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnNewTeam;
        private System.Windows.Forms.FlowLayoutPanel pnlRequests;
        private System.Windows.Forms.FlowLayoutPanel pnlTeams;
        private System.Windows.Forms.FlowLayoutPanel pnlMemebers;
        private Guna.UI2.WinForms.Guna2Button btnAddMember;
        private Guna.UI2.WinForms.Guna2Button btnRejectRequest;
        private Guna.UI2.WinForms.Guna2Button btnJoinRequest;
    }
}