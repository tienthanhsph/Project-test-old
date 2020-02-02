namespace Backup_n_Restore
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.btnBienDong = new System.Windows.Forms.Button();
            this.btnCapGCN = new System.Windows.Forms.Button();
            this.btnKeKhai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlButtom = new System.Windows.Forms.Panel();
            this.lblDVHC = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlButtom.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlStatus);
            this.splitContainer1.Panel1.Controls.Add(this.pnlMenu);
            this.splitContainer1.Panel1.Controls.Add(this.pnlInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlMain);
            this.splitContainer1.Panel2.Controls.Add(this.pnlButtom);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(847, 633);
            this.splitContainer1.SplitterDistance = 141;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatus.Location = new System.Drawing.Point(0, 548);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(141, 85);
            this.pnlStatus.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenu.Controls.Add(this.btnPerson);
            this.pnlMenu.Controls.Add(this.btnLichSu);
            this.pnlMenu.Controls.Add(this.btnBienDong);
            this.pnlMenu.Controls.Add(this.btnCapGCN);
            this.pnlMenu.Controls.Add(this.btnKeKhai);
            this.pnlMenu.Controls.Add(this.btnTimKiem);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 174);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(141, 374);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnLichSu
            // 
            this.btnLichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichSu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLichSu.Location = new System.Drawing.Point(0, 120);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(141, 30);
            this.btnLichSu.TabIndex = 5;
            this.btnLichSu.Text = "History";
            this.btnLichSu.UseVisualStyleBackColor = true;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // btnBienDong
            // 
            this.btnBienDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBienDong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBienDong.Location = new System.Drawing.Point(0, 90);
            this.btnBienDong.Name = "btnBienDong";
            this.btnBienDong.Size = new System.Drawing.Size(141, 30);
            this.btnBienDong.TabIndex = 4;
            this.btnBienDong.Text = "Change";
            this.btnBienDong.UseVisualStyleBackColor = true;
            this.btnBienDong.Click += new System.EventHandler(this.btnBienDong_Click);
            // 
            // btnCapGCN
            // 
            this.btnCapGCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCapGCN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCapGCN.Location = new System.Drawing.Point(0, 60);
            this.btnCapGCN.Name = "btnCapGCN";
            this.btnCapGCN.Size = new System.Drawing.Size(141, 30);
            this.btnCapGCN.TabIndex = 3;
            this.btnCapGCN.Text = "Accept";
            this.btnCapGCN.UseVisualStyleBackColor = true;
            this.btnCapGCN.Click += new System.EventHandler(this.btnCapGCN_Click);
            // 
            // btnKeKhai
            // 
            this.btnKeKhai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKeKhai.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKeKhai.Location = new System.Drawing.Point(0, 30);
            this.btnKeKhai.Name = "btnKeKhai";
            this.btnKeKhai.Size = new System.Drawing.Size(141, 30);
            this.btnKeKhai.TabIndex = 2;
            this.btnKeKhai.Text = "Content";
            this.btnKeKhai.UseVisualStyleBackColor = true;
            this.btnKeKhai.Click += new System.EventHandler(this.btnKeKhai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTimKiem.Location = new System.Drawing.Point(0, 0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(141, 30);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Search";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(141, 174);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(13, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(118, 162);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "label1";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Lavender;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(702, 577);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlButtom
            // 
            this.pnlButtom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlButtom.Controls.Add(this.lblDVHC);
            this.pnlButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtom.Location = new System.Drawing.Point(0, 601);
            this.pnlButtom.Name = "pnlButtom";
            this.pnlButtom.Size = new System.Drawing.Size(702, 32);
            this.pnlButtom.TabIndex = 0;
            // 
            // lblDVHC
            // 
            this.lblDVHC.BackColor = System.Drawing.SystemColors.Info;
            this.lblDVHC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDVHC.Location = new System.Drawing.Point(0, 0);
            this.lblDVHC.Name = "lblDVHC";
            this.lblDVHC.Size = new System.Drawing.Size(702, 32);
            this.lblDVHC.TabIndex = 0;
            this.lblDVHC.Text = "label1";
            this.lblDVHC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.managmentToolStripMenuItem,
            this.personToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // managmentToolStripMenuItem
            // 
            this.managmentToolStripMenuItem.Name = "managmentToolStripMenuItem";
            this.managmentToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.managmentToolStripMenuItem.Text = "Managment";
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.personToolStripMenuItem.Text = "Person";
            this.personToolStripMenuItem.Click += new System.EventHandler(this.personToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPerson.Location = new System.Drawing.Point(0, 150);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(141, 30);
            this.btnPerson.TabIndex = 1;
            this.btnPerson.Text = "Person";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 633);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlButtom.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlButtom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.Button btnBienDong;
        private System.Windows.Forms.Button btnCapGCN;
        private System.Windows.Forms.Button btnKeKhai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDVHC;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
        private System.Windows.Forms.Button btnPerson;
    }
}

