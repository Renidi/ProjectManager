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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group Description : ";
            // 
            // txGroupName
            // 
            this.txGroupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txGroupName.DefaultText = "";
            this.txGroupName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txGroupName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txGroupName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txGroupName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txGroupName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txGroupName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txGroupName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txGroupName.Location = new System.Drawing.Point(266, 41);
            this.txGroupName.Name = "txGroupName";
            this.txGroupName.PasswordChar = '\0';
            this.txGroupName.PlaceholderText = "";
            this.txGroupName.SelectedText = "";
            this.txGroupName.Size = new System.Drawing.Size(200, 36);
            this.txGroupName.TabIndex = 2;
            // 
            // txGroupDescription
            // 
            this.txGroupDescription.Location = new System.Drawing.Point(267, 100);
            this.txGroupDescription.Name = "txGroupDescription";
            this.txGroupDescription.Size = new System.Drawing.Size(199, 105);
            this.txGroupDescription.TabIndex = 34;
            this.txGroupDescription.Text = "";
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(200, 249);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(125, 36);
            this.btnCreateTeam.TabIndex = 42;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(341, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 36);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PopupCreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.txGroupDescription);
            this.Controls.Add(this.txGroupName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PopupCreateTeam";
            this.Text = "PopupCreateTeam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PopupCreateTeam_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txGroupName;
        private System.Windows.Forms.RichTextBox txGroupDescription;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.Button btnCancel;
    }
}