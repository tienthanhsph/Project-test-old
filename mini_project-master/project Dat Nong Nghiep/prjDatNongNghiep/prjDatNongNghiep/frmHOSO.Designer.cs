namespace prjDatNongNghiep
{
    partial class frmHOSO
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkDone = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapGCNDatNN = new System.Windows.Forms.Button();
            this.btnXetGiaoDatNN = new System.Windows.Forms.Button();
            this.btnXetQSDD = new System.Windows.Forms.Button();
            this.btnKeKhai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHoGiaDinh = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNopThue = new System.Windows.Forms.Label();
            this.lblThue = new System.Windows.Forms.Label();
            this.lblSoKhau = new System.Windows.Forms.Label();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.lblChuHS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctrlXetGiaoDatNN1 = new prjDatNongNghiep.ctrlXetGiaoDatNN();
            this.ctrlXetQSDD1 = new prjDatNongNghiep.ctrlXetQSDD();
            this.ctrlCapGCNDatNN1 = new prjDatNongNghiep.ctrlCapGCNDatNN();
            this.ctrlKeKhai1 = new prjDatNongNghiep.ctrlKeKhai();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tạoHồSơMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1034, 695);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Controls.Add(this.chkDone);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 638);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 57);
            this.panel4.TabIndex = 2;
            // 
            // chkDone
            // 
            this.chkDone.AutoSize = true;
            this.chkDone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDone.ForeColor = System.Drawing.Color.Green;
            this.chkDone.Location = new System.Drawing.Point(16, 25);
            this.chkDone.Name = "chkDone";
            this.chkDone.Size = new System.Drawing.Size(164, 22);
            this.chkDone.TabIndex = 12;
            this.chkDone.Text = "Xong bước hiện tại";
            this.chkDone.UseVisualStyleBackColor = true;
            this.chkDone.CheckedChanged += new System.EventHandler(this.chkDone_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Controls.Add(this.btnCapGCNDatNN);
            this.panel3.Controls.Add(this.btnXetGiaoDatNN);
            this.panel3.Controls.Add(this.btnXetQSDD);
            this.panel3.Controls.Add(this.btnKeKhai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 291);
            this.panel3.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(12, 240);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 26);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Báo xóa hồ sơ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(12, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(168, 33);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnCapGCNDatNN
            // 
            this.btnCapGCNDatNN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapGCNDatNN.Location = new System.Drawing.Point(12, 159);
            this.btnCapGCNDatNN.Name = "btnCapGCNDatNN";
            this.btnCapGCNDatNN.Size = new System.Drawing.Size(168, 33);
            this.btnCapGCNDatNN.TabIndex = 3;
            this.btnCapGCNDatNN.Text = "Cấp GCN";
            this.btnCapGCNDatNN.UseVisualStyleBackColor = true;
            this.btnCapGCNDatNN.Click += new System.EventHandler(this.btnCapGCNDatNN_Click);
            // 
            // btnXetGiaoDatNN
            // 
            this.btnXetGiaoDatNN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXetGiaoDatNN.Location = new System.Drawing.Point(12, 125);
            this.btnXetGiaoDatNN.Name = "btnXetGiaoDatNN";
            this.btnXetGiaoDatNN.Size = new System.Drawing.Size(168, 33);
            this.btnXetGiaoDatNN.TabIndex = 2;
            this.btnXetGiaoDatNN.Text = "Xét giao đất nông nghiệp";
            this.btnXetGiaoDatNN.UseVisualStyleBackColor = true;
            this.btnXetGiaoDatNN.Click += new System.EventHandler(this.btnXetGiaoDatNN_Click);
            // 
            // btnXetQSDD
            // 
            this.btnXetQSDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXetQSDD.Location = new System.Drawing.Point(12, 91);
            this.btnXetQSDD.Name = "btnXetQSDD";
            this.btnXetQSDD.Size = new System.Drawing.Size(168, 33);
            this.btnXetQSDD.TabIndex = 1;
            this.btnXetQSDD.Text = "Xét quyền sử dụng đất";
            this.btnXetQSDD.UseVisualStyleBackColor = true;
            this.btnXetQSDD.Click += new System.EventHandler(this.btnXetQSDD_Click);
            // 
            // btnKeKhai
            // 
            this.btnKeKhai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeKhai.Location = new System.Drawing.Point(12, 57);
            this.btnKeKhai.Name = "btnKeKhai";
            this.btnKeKhai.Size = new System.Drawing.Size(168, 33);
            this.btnKeKhai.TabIndex = 0;
            this.btnKeKhai.Text = "Nội dung hồ sơ";
            this.btnKeKhai.UseVisualStyleBackColor = true;
            this.btnKeKhai.Click += new System.EventHandler(this.btnKeKhai_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btnHoGiaDinh);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblDiaChi);
            this.panel1.Controls.Add(this.lblNopThue);
            this.panel1.Controls.Add(this.lblThue);
            this.panel1.Controls.Add(this.lblSoKhau);
            this.panel1.Controls.Add(this.lblDienTich);
            this.panel1.Controls.Add(this.lblChuHS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 324);
            this.panel1.TabIndex = 0;
            // 
            // btnHoGiaDinh
            // 
            this.btnHoGiaDinh.AutoSize = true;
            this.btnHoGiaDinh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHoGiaDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoGiaDinh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoGiaDinh.Location = new System.Drawing.Point(11, 226);
            this.btnHoGiaDinh.Name = "btnHoGiaDinh";
            this.btnHoGiaDinh.Size = new System.Drawing.Size(79, 26);
            this.btnHoGiaDinh.TabIndex = 9;
            this.btnHoGiaDinh.Text = "Hộ gia đình";
            this.btnHoGiaDinh.UseVisualStyleBackColor = true;
            this.btnHoGiaDinh.Click += new System.EventHandler(this.btnHoGiaDinh_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.MediumBlue;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(8, 264);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(229, 47);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AllowDrop = true;
            this.lblDiaChi.Location = new System.Drawing.Point(8, 74);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(209, 44);
            this.lblDiaChi.TabIndex = 7;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblNopThue
            // 
            this.lblNopThue.AutoSize = true;
            this.lblNopThue.Location = new System.Drawing.Point(9, 188);
            this.lblNopThue.Name = "lblNopThue";
            this.lblNopThue.Size = new System.Drawing.Size(69, 14);
            this.lblNopThue.TabIndex = 6;
            this.lblNopThue.Text = "Đã nộp thuế:";
            // 
            // lblThue
            // 
            this.lblThue.AutoSize = true;
            this.lblThue.Location = new System.Drawing.Point(8, 168);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(54, 14);
            this.lblThue.TabIndex = 5;
            this.lblThue.Text = "Tiền thuế:";
            // 
            // lblSoKhau
            // 
            this.lblSoKhau.AutoSize = true;
            this.lblSoKhau.Location = new System.Drawing.Point(8, 148);
            this.lblSoKhau.Name = "lblSoKhau";
            this.lblSoKhau.Size = new System.Drawing.Size(46, 14);
            this.lblSoKhau.TabIndex = 4;
            this.lblSoKhau.Text = "Số khẩu";
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(8, 127);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(54, 14);
            this.lblDienTich.TabIndex = 2;
            this.lblDienTich.Text = "Diện tích: ";
            // 
            // lblChuHS
            // 
            this.lblChuHS.AutoSize = true;
            this.lblChuHS.Location = new System.Drawing.Point(8, 53);
            this.lblChuHS.Name = "lblChuHS";
            this.lblChuHS.Size = new System.Drawing.Size(32, 14);
            this.lblChuHS.TabIndex = 1;
            this.lblChuHS.Text = "Chủ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN HỒ SƠ HIỆN TẠI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.ctrlXetGiaoDatNN1);
            this.panel2.Controls.Add(this.ctrlXetQSDD1);
            this.panel2.Controls.Add(this.ctrlCapGCNDatNN1);
            this.panel2.Controls.Add(this.ctrlKeKhai1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 695);
            this.panel2.TabIndex = 0;
            // 
            // ctrlXetGiaoDatNN1
            // 
            this.ctrlXetGiaoDatNN1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlXetGiaoDatNN1.Location = new System.Drawing.Point(0, 0);
            this.ctrlXetGiaoDatNN1.Name = "ctrlXetGiaoDatNN1";
            this.ctrlXetGiaoDatNN1.Size = new System.Drawing.Size(818, 695);
            this.ctrlXetGiaoDatNN1.TabIndex = 5;
            // 
            // ctrlXetQSDD1
            // 
            this.ctrlXetQSDD1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlXetQSDD1.Location = new System.Drawing.Point(0, 0);
            this.ctrlXetQSDD1.Name = "ctrlXetQSDD1";
            this.ctrlXetQSDD1.Size = new System.Drawing.Size(818, 695);
            this.ctrlXetQSDD1.TabIndex = 4;
            // 
            // ctrlCapGCNDatNN1
            // 
            this.ctrlCapGCNDatNN1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlCapGCNDatNN1.Location = new System.Drawing.Point(0, 0);
            this.ctrlCapGCNDatNN1.Name = "ctrlCapGCNDatNN1";
            this.ctrlCapGCNDatNN1.Size = new System.Drawing.Size(818, 695);
            this.ctrlCapGCNDatNN1.TabIndex = 3;
            // 
            // ctrlKeKhai1
            // 
            this.ctrlKeKhai1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlKeKhai1.Location = new System.Drawing.Point(0, 0);
            this.ctrlKeKhai1.Name = "ctrlKeKhai1";
            this.ctrlKeKhai1.Size = new System.Drawing.Size(818, 695);
            this.ctrlKeKhai1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoHồSơMớiToolStripMenuItem,
            this.quảnLýHồSơToolStripMenuItem,
            this.thoátChươngTrìnhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tạoHồSơMớiToolStripMenuItem
            // 
            this.tạoHồSơMớiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tạoHồSơMớiToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.tạoHồSơMớiToolStripMenuItem.Name = "tạoHồSơMớiToolStripMenuItem";
            this.tạoHồSơMớiToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.tạoHồSơMớiToolStripMenuItem.Text = "Tạo hồ sơ mới";
            this.tạoHồSơMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoHồSơMớiToolStripMenuItem_Click);
            // 
            // quảnLýHồSơToolStripMenuItem
            // 
            this.quảnLýHồSơToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.quảnLýHồSơToolStripMenuItem.Name = "quảnLýHồSơToolStripMenuItem";
            this.quảnLýHồSơToolStripMenuItem.Size = new System.Drawing.Size(94, 23);
            this.quảnLýHồSơToolStripMenuItem.Text = "Quản lý hồ sơ";
            this.quảnLýHồSơToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHồSơToolStripMenuItem_Click);
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            this.thoátChươngTrìnhToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            this.thoátChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(127, 23);
            this.thoátChươngTrìnhToolStripMenuItem.Text = "Thoát chương trình";
            this.thoátChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.thoátChươngTrìnhToolStripMenuItem_Click);
            // 
            // frmHOSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 722);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1050, 760);
            this.Name = "frmHOSO";
            this.Text = "Hồ sơ đất nông nghiệp";
            this.Load += new System.EventHandler(this.frmHOSO_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXetQSDD;
        private System.Windows.Forms.Button btnKeKhai;
        private System.Windows.Forms.Button btnXetGiaoDatNN;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCapGCNDatNN;
        private ctrlKeKhai ctrlKeKhai1;
        private ctrlCapGCNDatNN ctrlCapGCNDatNN1;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNopThue;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label lblSoKhau;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.Label lblChuHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnHoGiaDinh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chkDone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tạoHồSơMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private ctrlXetGiaoDatNN ctrlXetGiaoDatNN1;
        private ctrlXetQSDD ctrlXetQSDD1;
    }
}