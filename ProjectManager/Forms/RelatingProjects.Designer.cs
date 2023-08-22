namespace ProjectManager.Forms
{
    partial class RelatingProjects
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
            this.pnlComplete = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlActive = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOnHold = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCancelled = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.pnlCancelled);
            this.pnlMiddle.Controls.Add(this.pnlComplete);
            this.pnlMiddle.Controls.Add(this.pnlActive);
            this.pnlMiddle.Controls.Add(this.pnlOnHold);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 0);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1150, 551);
            this.pnlMiddle.TabIndex = 0;
            // 
            // pnlComplete
            // 
            this.pnlComplete.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlComplete.Location = new System.Drawing.Point(520, 0);
            this.pnlComplete.Name = "pnlComplete";
            this.pnlComplete.Size = new System.Drawing.Size(260, 551);
            this.pnlComplete.TabIndex = 2;
            // 
            // pnlActive
            // 
            this.pnlActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlActive.Location = new System.Drawing.Point(260, 0);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(260, 551);
            this.pnlActive.TabIndex = 1;
            // 
            // pnlOnHold
            // 
            this.pnlOnHold.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOnHold.Location = new System.Drawing.Point(0, 0);
            this.pnlOnHold.Name = "pnlOnHold";
            this.pnlOnHold.Size = new System.Drawing.Size(260, 551);
            this.pnlOnHold.TabIndex = 0;
            // 
            // pnlCancelled
            // 
            this.pnlCancelled.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCancelled.Location = new System.Drawing.Point(780, 0);
            this.pnlCancelled.Name = "pnlCancelled";
            this.pnlCancelled.Size = new System.Drawing.Size(260, 551);
            this.pnlCancelled.TabIndex = 3;
            // 
            // RelatingProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1150, 551);
            this.Controls.Add(this.pnlMiddle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatingProjects";
            this.Text = "RelatingProjects";
            this.Load += new System.EventHandler(this.RelatingProjects_Load);
            this.pnlMiddle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.FlowLayoutPanel pnlOnHold;
        private System.Windows.Forms.FlowLayoutPanel pnlComplete;
        private System.Windows.Forms.FlowLayoutPanel pnlActive;
        private System.Windows.Forms.FlowLayoutPanel pnlCancelled;
    }
}