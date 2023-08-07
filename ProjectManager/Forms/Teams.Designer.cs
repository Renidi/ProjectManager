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
            this.btnDeleteTeam = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateTeam = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTeams = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMemebers = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.Silver;
            this.pnlMiddle.Controls.Add(this.pnlMemebers);
            this.pnlMiddle.Controls.Add(this.flowLayoutPanel2);
            this.pnlMiddle.Controls.Add(this.pnlTeams);
            this.pnlMiddle.Controls.Add(this.btnDeleteTeam);
            this.pnlMiddle.Controls.Add(this.btnCreateTeam);
            this.pnlMiddle.Controls.Add(this.label3);
            this.pnlMiddle.Controls.Add(this.label2);
            this.pnlMiddle.Controls.Add(this.label1);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 0);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1280, 551);
            this.pnlMiddle.TabIndex = 4;
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTeam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteTeam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteTeam.Enabled = false;
            this.btnDeleteTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteTeam.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTeam.Location = new System.Drawing.Point(198, 460);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(180, 45);
            this.btnDeleteTeam.TabIndex = 8;
            this.btnDeleteTeam.Text = "Delete Team";
            this.btnDeleteTeam.UseTransparentBackground = true;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateTeam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateTeam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateTeam.ForeColor = System.Drawing.Color.White;
            this.btnCreateTeam.Location = new System.Drawing.Point(12, 460);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(180, 45);
            this.btnCreateTeam.TabIndex = 7;
            this.btnCreateTeam.Text = "New Team";
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(938, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grup İstekleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Üyeler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teams";
            // 
            // pnlTeams
            // 
            this.pnlTeams.Location = new System.Drawing.Point(12, 25);
            this.pnlTeams.Name = "pnlTeams";
            this.pnlTeams.Size = new System.Drawing.Size(158, 429);
            this.pnlTeams.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(895, 25);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(158, 429);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // pnlMemebers
            // 
            this.pnlMemebers.Location = new System.Drawing.Point(176, 25);
            this.pnlMemebers.Name = "pnlMemebers";
            this.pnlMemebers.Size = new System.Drawing.Size(713, 429);
            this.pnlMemebers.TabIndex = 11;
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 551);
            this.Controls.Add(this.pnlMiddle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teams";
            this.Text = "Teams";
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMiddle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnCreateTeam;
        private Guna.UI2.WinForms.Guna2Button btnDeleteTeam;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel pnlTeams;
        private System.Windows.Forms.FlowLayoutPanel pnlMemebers;
    }
}