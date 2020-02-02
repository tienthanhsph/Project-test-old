namespace XemLichSu
{
    partial class Main
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
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.từĐiểnQuyềnHạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giámSátNhậpLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơToolStripMenuItem,
            this.phânQuyềnToolStripMenuItem,
            this.từĐiểnQuyềnHạnToolStripMenuItem,
            this.giámSátNhậpLiệuToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.hồSơToolStripMenuItem.Text = "Hồ sơ";
            this.hồSơToolStripMenuItem.Click += new System.EventHandler(this.hồSơToolStripMenuItem_Click);
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.phânQuyềnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.phânQuyềnToolStripMenuItem.Click += new System.EventHandler(this.phânQuyềnToolStripMenuItem_Click);
            // 
            // từĐiểnQuyềnHạnToolStripMenuItem
            // 
            this.từĐiểnQuyềnHạnToolStripMenuItem.Name = "từĐiểnQuyềnHạnToolStripMenuItem";
            this.từĐiểnQuyềnHạnToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.từĐiểnQuyềnHạnToolStripMenuItem.Text = "Từ điển quyền hạn";
            this.từĐiểnQuyềnHạnToolStripMenuItem.Click += new System.EventHandler(this.từĐiểnQuyềnHạnToolStripMenuItem_Click);
            // 
            // giámSátNhậpLiệuToolStripMenuItem
            // 
            this.giámSátNhậpLiệuToolStripMenuItem.Name = "giámSátNhậpLiệuToolStripMenuItem";
            this.giámSátNhậpLiệuToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.giámSátNhậpLiệuToolStripMenuItem.Text = "Giám sát nhập liệu";
            this.giámSátNhậpLiệuToolStripMenuItem.Click += new System.EventHandler(this.giámSátNhậpLiệuToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 315);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giámSátNhậpLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem từĐiểnQuyềnHạnToolStripMenuItem;


    }
}