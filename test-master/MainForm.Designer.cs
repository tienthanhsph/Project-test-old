namespace SH.Crawler
{
    partial class MainForm
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
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemCraw = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemBaseData = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.kếtQuảToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemCraw});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.danhMụcToolStripMenuItem.Text = "Chương trình";
            // 
            // tsMenuItemCraw
            // 
            this.tsMenuItemCraw.Name = "tsMenuItemCraw";
            this.tsMenuItemCraw.Size = new System.Drawing.Size(152, 22);
            this.tsMenuItemCraw.Text = "Kéo giá";
            // 
            // kếtQuảToolStripMenuItem
            // 
            this.kếtQuảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemBaseData});
            this.kếtQuảToolStripMenuItem.Name = "kếtQuảToolStripMenuItem";
            this.kếtQuảToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.kếtQuảToolStripMenuItem.Text = "Kết quả";
            // 
            // tsMenuItemBaseData
            // 
            this.tsMenuItemBaseData.Name = "tsMenuItemBaseData";
            this.tsMenuItemBaseData.Size = new System.Drawing.Size(161, 22);
            this.tsMenuItemBaseData.Text = "Xem kết quả thô";
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(781, 352);
            this.MainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 376);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Chương trình kéo giá web";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemCraw;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemBaseData;
        private System.Windows.Forms.Panel MainPanel;

    }
}