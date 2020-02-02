namespace CustomPanel
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Left = new System.Windows.Forms.Panel();
            this.Bottom1 = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.Bottom3 = new System.Windows.Forms.Panel();
            this.Right = new System.Windows.Forms.Panel();
            this.Bottom2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.Black;
            this.Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left.Location = new System.Drawing.Point(0, 24);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(188, 403);
            this.Left.TabIndex = 4;
            // 
            // Bottom1
            // 
            this.Bottom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bottom1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom1.Location = new System.Drawing.Point(0, 427);
            this.Bottom1.Name = "Bottom1";
            this.Bottom1.Size = new System.Drawing.Size(761, 60);
            this.Bottom1.TabIndex = 3;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(188, 24);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(373, 203);
            this.Main.TabIndex = 8;
            // 
            // Bottom3
            // 
            this.Bottom3.BackColor = System.Drawing.Color.Silver;
            this.Bottom3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom3.Location = new System.Drawing.Point(188, 227);
            this.Bottom3.Name = "Bottom3";
            this.Bottom3.Size = new System.Drawing.Size(373, 100);
            this.Bottom3.TabIndex = 7;
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.White;
            this.Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right.Location = new System.Drawing.Point(561, 24);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(200, 303);
            this.Right.TabIndex = 6;
            // 
            // Bottom2
            // 
            this.Bottom2.BackColor = System.Drawing.Color.Gray;
            this.Bottom2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom2.Location = new System.Drawing.Point(188, 327);
            this.Bottom2.Name = "Bottom2";
            this.Bottom2.Size = new System.Drawing.Size(573, 100);
            this.Bottom2.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 487);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Bottom3);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Bottom2);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Bottom1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel Bottom1;
       
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel Bottom3;
        private System.Windows.Forms.Panel Right;
        private System.Windows.Forms.Panel Bottom2;
        public System.Windows.Forms.Panel Left;
    }
}