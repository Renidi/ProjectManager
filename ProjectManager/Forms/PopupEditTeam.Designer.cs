namespace ProjectManager.Forms
{
    partial class PopupEditTeam
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.txGroupDescription = new System.Windows.Forms.RichTextBox();
            this.txGroupName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(273, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 36);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditTeam.Location = new System.Drawing.Point(132, 252);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(125, 36);
            this.btnEditTeam.TabIndex = 48;
            this.btnEditTeam.Text = "Edit Team";
            this.btnEditTeam.UseVisualStyleBackColor = true;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // txGroupDescription
            // 
            this.txGroupDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txGroupDescription.Location = new System.Drawing.Point(199, 103);
            this.txGroupDescription.Name = "txGroupDescription";
            this.txGroupDescription.Size = new System.Drawing.Size(199, 105);
            this.txGroupDescription.TabIndex = 47;
            this.txGroupDescription.Text = "";
            // 
            // txGroupName
            // 
            this.txGroupName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txGroupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txGroupName.DefaultText = "";
            this.txGroupName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txGroupName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txGroupName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txGroupName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txGroupName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txGroupName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txGroupName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txGroupName.Location = new System.Drawing.Point(198, 44);
            this.txGroupName.Name = "txGroupName";
            this.txGroupName.PasswordChar = '\0';
            this.txGroupName.PlaceholderText = "";
            this.txGroupName.SelectedText = "";
            this.txGroupName.Size = new System.Drawing.Size(200, 36);
            this.txGroupName.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Group Description : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Group Name : ";
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Image = global::ProjectManager.Properties.Resources.delete;
            this.pbExit.Location = new System.Drawing.Point(535, 3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 32);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 50;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txGroupName);
            this.panel1.Controls.Add(this.pbExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEditTeam);
            this.panel1.Controls.Add(this.txGroupDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 350);
            this.panel1.TabIndex = 51;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // PopupEditTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(155)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(578, 358);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupEditTeam";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "PopupEditTeam";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PopupEditTeam_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditTeam;
        private System.Windows.Forms.RichTextBox txGroupDescription;
        private Guna.UI2.WinForms.Guna2TextBox txGroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel panel1;
    }
}