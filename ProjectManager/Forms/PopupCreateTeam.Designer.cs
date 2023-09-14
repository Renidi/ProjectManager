namespace ProjectManager.Forms
{
    partial class PopupCreateTeam
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
            this.label2 = new System.Windows.Forms.Label();
            this.txGroupName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txGroupDescription = new System.Windows.Forms.RichTextBox();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group Description : ";
            // 
            // txGroupName
            // 
            this.txGroupName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txGroupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txGroupName.DefaultText = "";
            this.txGroupName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txGroupName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txGroupName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txGroupName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txGroupName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txGroupName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txGroupName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txGroupName.Location = new System.Drawing.Point(262, 84);
            this.txGroupName.Name = "txGroupName";
            this.txGroupName.PasswordChar = '\0';
            this.txGroupName.PlaceholderText = "";
            this.txGroupName.SelectedText = "";
            this.txGroupName.Size = new System.Drawing.Size(200, 36);
            this.txGroupName.TabIndex = 2;
            // 
            // txGroupDescription
            // 
            this.txGroupDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txGroupDescription.Location = new System.Drawing.Point(263, 143);
            this.txGroupDescription.Name = "txGroupDescription";
            this.txGroupDescription.Size = new System.Drawing.Size(199, 105);
            this.txGroupDescription.TabIndex = 34;
            this.txGroupDescription.Text = "";
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateTeam.Location = new System.Drawing.Point(196, 292);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(125, 36);
            this.btnCreateTeam.TabIndex = 42;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(337, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 36);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Image = global::ProjectManager.Properties.Resources.delete;
            this.pbExit.Location = new System.Drawing.Point(639, 3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 32);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 44;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Silver;
            this.guna2Panel1.Controls.Add(this.txGroupName);
            this.guna2Panel1.Controls.Add(this.pbExit);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnCancel);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btnCreateTeam);
            this.guna2Panel1.Controls.Add(this.txGroupDescription);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(5, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(674, 351);
            this.guna2Panel1.TabIndex = 45;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // PopupCreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupCreateTeam";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "PopupCreateTeam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PopupCreateTeam_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PopupCreateTeam_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txGroupName;
        private System.Windows.Forms.RichTextBox txGroupDescription;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbExit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}