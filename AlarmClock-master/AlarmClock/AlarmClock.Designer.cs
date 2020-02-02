namespace AlarmClock
{
    partial class AlarmClock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmClock));
            this.notifyIconClock = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripClock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ẩnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblThoigian = new System.Windows.Forms.Label();
            this.timerThoigian = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxChucnang = new System.Windows.Forms.ComboBox();
            this.groupBoxChucnang = new System.Windows.Forms.GroupBox();
            this.btnThongtin = new System.Windows.Forms.Button();
            this.btnAn = new System.Windows.Forms.Button();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnNhacchuong = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialogClock = new System.Windows.Forms.OpenFileDialog();
            this.timerHengio = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripClock.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxChucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIconClock
            // 
            this.notifyIconClock.ContextMenuStrip = this.contextMenuStripClock;
            this.notifyIconClock.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconClock.Icon")));
            this.notifyIconClock.Text = "AlarmClock";
            this.notifyIconClock.Visible = true;
            this.notifyIconClock.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconClock_MouseDoubleClick);
            // 
            // contextMenuStripClock
            // 
            this.contextMenuStripClock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ẩnToolStripMenuItem,
            this.hiệnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.contextMenuStripClock.Name = "contextMenuStripClock";
            this.contextMenuStripClock.Size = new System.Drawing.Size(106, 70);
            // 
            // ẩnToolStripMenuItem
            // 
            this.ẩnToolStripMenuItem.Name = "ẩnToolStripMenuItem";
            this.ẩnToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.ẩnToolStripMenuItem.Text = "Ẩn";
            this.ẩnToolStripMenuItem.Click += new System.EventHandler(this.ẩnToolStripMenuItem_Click);
            // 
            // hiệnToolStripMenuItem
            // 
            this.hiệnToolStripMenuItem.Name = "hiệnToolStripMenuItem";
            this.hiệnToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.hiệnToolStripMenuItem.Text = "Hiện";
            this.hiệnToolStripMenuItem.Click += new System.EventHandler(this.hiệnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // lblThoigian
            // 
            this.lblThoigian.AutoSize = true;
            this.lblThoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoigian.Location = new System.Drawing.Point(3, 12);
            this.lblThoigian.Name = "lblThoigian";
            this.lblThoigian.Size = new System.Drawing.Size(56, 25);
            this.lblThoigian.TabIndex = 1;
            this.lblThoigian.Text = "time";
            // 
            // timerThoigian
            // 
            this.timerThoigian.Interval = 1000;
            this.timerThoigian.Tick += new System.EventHandler(this.timerThoigian_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Controls.Add(this.lblThoigian);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 50);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxChucnang
            // 
            this.comboBoxChucnang.FormattingEnabled = true;
            this.comboBoxChucnang.Location = new System.Drawing.Point(6, 19);
            this.comboBoxChucnang.Name = "comboBoxChucnang";
            this.comboBoxChucnang.Size = new System.Drawing.Size(136, 21);
            this.comboBoxChucnang.TabIndex = 3;
            this.comboBoxChucnang.SelectedIndexChanged += new System.EventHandler(this.comboBoxChucnang_SelectedIndexChanged);
            // 
            // groupBoxChucnang
            // 
            this.groupBoxChucnang.Controls.Add(this.btnNhacchuong);
            this.groupBoxChucnang.Controls.Add(this.btnHuy);
            this.groupBoxChucnang.Controls.Add(this.btnXacnhan);
            this.groupBoxChucnang.Controls.Add(this.comboBoxChucnang);
            this.groupBoxChucnang.Location = new System.Drawing.Point(164, 13);
            this.groupBoxChucnang.Name = "groupBoxChucnang";
            this.groupBoxChucnang.Size = new System.Drawing.Size(187, 79);
            this.groupBoxChucnang.TabIndex = 4;
            this.groupBoxChucnang.TabStop = false;
            this.groupBoxChucnang.Text = "Chức năng";
            // 
            // btnThongtin
            // 
            this.btnThongtin.Location = new System.Drawing.Point(12, 69);
            this.btnThongtin.Name = "btnThongtin";
            this.btnThongtin.Size = new System.Drawing.Size(70, 23);
            this.btnThongtin.TabIndex = 5;
            this.btnThongtin.Text = "Thông tin";
            this.btnThongtin.UseVisualStyleBackColor = true;
            this.btnThongtin.Click += new System.EventHandler(this.btnThongtin_Click);
            // 
            // btnAn
            // 
            this.btnAn.Location = new System.Drawing.Point(88, 69);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(70, 23);
            this.btnAn.TabIndex = 6;
            this.btnAn.Text = "Ẩn";
            this.btnAn.UseVisualStyleBackColor = true;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Enabled = false;
            this.btnXacnhan.Location = new System.Drawing.Point(7, 47);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(64, 23);
            this.btnXacnhan.TabIndex = 4;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(78, 47);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(64, 23);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnNhacchuong
            // 
            this.btnNhacchuong.Enabled = false;
            this.btnNhacchuong.Location = new System.Drawing.Point(149, 17);
            this.btnNhacchuong.Name = "btnNhacchuong";
            this.btnNhacchuong.Size = new System.Drawing.Size(32, 23);
            this.btnNhacchuong.TabIndex = 6;
            this.btnNhacchuong.Text = "..";
            this.btnNhacchuong.UseVisualStyleBackColor = true;
            this.btnNhacchuong.Click += new System.EventHandler(this.btnNhacchuong_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(80, 5);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(59, 34);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // openFileDialogClock
            // 
            this.openFileDialogClock.FileName = "openFileDialogClock";
            // 
            // timerHengio
            // 
            this.timerHengio.Interval = 1000;
            this.timerHengio.Tick += new System.EventHandler(this.timerHengio_Tick);
            // 
            // AlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 101);
            this.Controls.Add(this.btnThongtin);
            this.Controls.Add(this.btnAn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxChucnang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlarmClock";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlarmClock";
            this.Load += new System.EventHandler(this.AlarmClock_Load);
            this.SizeChanged += new System.EventHandler(this.AlarmClock_SizeChanged);
            this.contextMenuStripClock.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxChucnang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconClock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClock;
        private System.Windows.Forms.ToolStripMenuItem ẩnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label lblThoigian;
        private System.Windows.Forms.Timer timerThoigian;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxChucnang;
        private System.Windows.Forms.GroupBox groupBoxChucnang;
        private System.Windows.Forms.Button btnThongtin;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnNhacchuong;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialogClock;
        private System.Windows.Forms.Timer timerHengio;
    }
}

