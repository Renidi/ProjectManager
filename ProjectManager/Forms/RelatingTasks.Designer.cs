namespace ProjectManager.Forms
{
    partial class RelatingTasks
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
            this.pnlOut = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCancelled = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlComplete = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlActive = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOnHold = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOut.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOut
            // 
            this.pnlOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pnlOut.Controls.Add(this.pnlMain);
            this.pnlOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOut.Location = new System.Drawing.Point(0, 0);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Size = new System.Drawing.Size(1156, 551);
            this.pnlOut.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1156, 551);
            this.pnlMain.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlCancelled);
            this.panel1.Controls.Add(this.pnlComplete);
            this.panel1.Controls.Add(this.pnlActive);
            this.panel1.Controls.Add(this.pnlOnHold);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 551);
            this.panel1.TabIndex = 7;
            // 
            // pnlCancelled
            // 
            this.pnlCancelled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.pnlCancelled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCancelled.Location = new System.Drawing.Point(867, 0);
            this.pnlCancelled.Name = "pnlCancelled";
            this.pnlCancelled.Size = new System.Drawing.Size(289, 551);
            this.pnlCancelled.TabIndex = 7;
            // 
            // pnlComplete
            // 
            this.pnlComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.pnlComplete.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlComplete.Location = new System.Drawing.Point(578, 0);
            this.pnlComplete.Name = "pnlComplete";
            this.pnlComplete.Size = new System.Drawing.Size(289, 551);
            this.pnlComplete.TabIndex = 6;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.pnlActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlActive.Location = new System.Drawing.Point(289, 0);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(289, 551);
            this.pnlActive.TabIndex = 5;
            // 
            // pnlOnHold
            // 
            this.pnlOnHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(199)))), ((int)(((byte)(190)))));
            this.pnlOnHold.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOnHold.Location = new System.Drawing.Point(0, 0);
            this.pnlOnHold.Name = "pnlOnHold";
            this.pnlOnHold.Size = new System.Drawing.Size(289, 551);
            this.pnlOnHold.TabIndex = 4;
            // 
            // RelatingTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 551);
            this.Controls.Add(this.pnlOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RelatingTasks";
            this.Text = "RelatingTasks";
            this.Load += new System.EventHandler(this.RelatingTasks_Load);
            this.pnlOut.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOut;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlCancelled;
        private System.Windows.Forms.FlowLayoutPanel pnlComplete;
        private System.Windows.Forms.FlowLayoutPanel pnlActive;
        private System.Windows.Forms.FlowLayoutPanel pnlOnHold;
    }
}