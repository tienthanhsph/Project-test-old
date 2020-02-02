namespace prjDatNongNghiep
{
    partial class CtrlDangKyBienDong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTaoHoSoMoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLichSuBienDong = new System.Windows.Forms.Button();
            this.dtpNgayQuyetDinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCoQuanQuyetDinh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoQuyetDinh = new System.Windows.Forms.TextBox();
            this.grpQuyetDinh = new System.Windows.Forms.GroupBox();
            this.btnXoaQD = new System.Windows.Forms.Button();
            this.btnThemQD = new System.Windows.Forms.Button();
            this.dtgrvQuyetDinh = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNguoiDangKy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbNoiDungBienDong = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLoaiBienDong = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpQuyetDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvQuyetDinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaoHoSoMoi
            // 
            this.btnTaoHoSoMoi.Location = new System.Drawing.Point(478, 644);
            this.btnTaoHoSoMoi.Name = "btnTaoHoSoMoi";
            this.btnTaoHoSoMoi.Size = new System.Drawing.Size(196, 23);
            this.btnTaoHoSoMoi.TabIndex = 4;
            this.btnTaoHoSoMoi.Text = "Tạo hồ sơ thay thể hồ sơ cũ";
            this.btnTaoHoSoMoi.UseVisualStyleBackColor = true;
            this.btnTaoHoSoMoi.Click += new System.EventHandler(this.btnTaoHoSoMoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(18, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 172);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng hợp các biến động";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(797, 149);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Location = new System.Drawing.Point(269, 644);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Hủy lệnh";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.Location = new System.Drawing.Point(209, 644);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(117, 644);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Location = new System.Drawing.Point(72, 644);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(21, 644);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(46, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLichSuBienDong
            // 
            this.btnLichSuBienDong.Location = new System.Drawing.Point(680, 644);
            this.btnLichSuBienDong.Name = "btnLichSuBienDong";
            this.btnLichSuBienDong.Size = new System.Drawing.Size(138, 23);
            this.btnLichSuBienDong.TabIndex = 15;
            this.btnLichSuBienDong.Text = "Lịch sử biến động";
            this.btnLichSuBienDong.UseVisualStyleBackColor = true;
            this.btnLichSuBienDong.Click += new System.EventHandler(this.btnLichSuBienDong_Click);
            // 
            // dtpNgayQuyetDinh
            // 
            this.dtpNgayQuyetDinh.Checked = false;
            this.dtpNgayQuyetDinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayQuyetDinh.Location = new System.Drawing.Point(627, 26);
            this.dtpNgayQuyetDinh.Name = "dtpNgayQuyetDinh";
            this.dtpNgayQuyetDinh.ShowCheckBox = true;
            this.dtpNgayQuyetDinh.Size = new System.Drawing.Size(125, 20);
            this.dtpNgayQuyetDinh.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(45, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Cơ quan quyết định ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(533, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ngày quyết định";
            // 
            // txtCoQuanQuyetDinh
            // 
            this.txtCoQuanQuyetDinh.Location = new System.Drawing.Point(151, 52);
            this.txtCoQuanQuyetDinh.Name = "txtCoQuanQuyetDinh";
            this.txtCoQuanQuyetDinh.ReadOnly = true;
            this.txtCoQuanQuyetDinh.Size = new System.Drawing.Size(291, 20);
            this.txtCoQuanQuyetDinh.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(72, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Số quyết định";
            // 
            // txtSoQuyetDinh
            // 
            this.txtSoQuyetDinh.Location = new System.Drawing.Point(151, 28);
            this.txtSoQuyetDinh.Name = "txtSoQuyetDinh";
            this.txtSoQuyetDinh.ReadOnly = true;
            this.txtSoQuyetDinh.Size = new System.Drawing.Size(93, 20);
            this.txtSoQuyetDinh.TabIndex = 40;
            // 
            // grpQuyetDinh
            // 
            this.grpQuyetDinh.Controls.Add(this.btnXoaQD);
            this.grpQuyetDinh.Controls.Add(this.btnThemQD);
            this.grpQuyetDinh.Controls.Add(this.dtgrvQuyetDinh);
            this.grpQuyetDinh.Controls.Add(this.txtSoQuyetDinh);
            this.grpQuyetDinh.Controls.Add(this.label8);
            this.grpQuyetDinh.Controls.Add(this.txtCoQuanQuyetDinh);
            this.grpQuyetDinh.Controls.Add(this.label6);
            this.grpQuyetDinh.Controls.Add(this.label7);
            this.grpQuyetDinh.Controls.Add(this.dtpNgayQuyetDinh);
            this.grpQuyetDinh.Location = new System.Drawing.Point(18, 208);
            this.grpQuyetDinh.Name = "grpQuyetDinh";
            this.grpQuyetDinh.Size = new System.Drawing.Size(803, 236);
            this.grpQuyetDinh.TabIndex = 42;
            this.grpQuyetDinh.TabStop = false;
            this.grpQuyetDinh.Text = "Quyết định";
            // 
            // btnXoaQD
            // 
            this.btnXoaQD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoaQD.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaQD.Location = new System.Drawing.Point(714, 207);
            this.btnXoaQD.Name = "btnXoaQD";
            this.btnXoaQD.Size = new System.Drawing.Size(38, 23);
            this.btnXoaQD.TabIndex = 47;
            this.btnXoaQD.Text = "Xóa";
            this.btnXoaQD.UseVisualStyleBackColor = false;
            this.btnXoaQD.Click += new System.EventHandler(this.btnXoaQD_Click);
            // 
            // btnThemQD
            // 
            this.btnThemQD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemQD.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemQD.Location = new System.Drawing.Point(662, 207);
            this.btnThemQD.Name = "btnThemQD";
            this.btnThemQD.Size = new System.Drawing.Size(46, 23);
            this.btnThemQD.TabIndex = 45;
            this.btnThemQD.Text = "Thêm";
            this.btnThemQD.UseVisualStyleBackColor = false;
            this.btnThemQD.Click += new System.EventHandler(this.btnThemQD_Click);
            // 
            // dtgrvQuyetDinh
            // 
            this.dtgrvQuyetDinh.AllowUserToAddRows = false;
            this.dtgrvQuyetDinh.AllowUserToDeleteRows = false;
            this.dtgrvQuyetDinh.AllowUserToResizeRows = false;
            this.dtgrvQuyetDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvQuyetDinh.Location = new System.Drawing.Point(72, 82);
            this.dtgrvQuyetDinh.Name = "dtgrvQuyetDinh";
            this.dtgrvQuyetDinh.ReadOnly = true;
            this.dtgrvQuyetDinh.RowHeadersVisible = false;
            this.dtgrvQuyetDinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvQuyetDinh.Size = new System.Drawing.Size(680, 119);
            this.dtgrvQuyetDinh.TabIndex = 44;
            this.dtgrvQuyetDinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvQuyetDinh_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNguoiDangKy);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpNgayDangKy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rtbNoiDungBienDong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbLoaiBienDong);
            this.panel1.Location = new System.Drawing.Point(18, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 187);
            this.panel1.TabIndex = 45;
            // 
            // txtNguoiDangKy
            // 
            this.txtNguoiDangKy.Location = new System.Drawing.Point(119, 10);
            this.txtNguoiDangKy.Name = "txtNguoiDangKy";
            this.txtNguoiDangKy.Size = new System.Drawing.Size(320, 20);
            this.txtNguoiDangKy.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 51;
            this.label4.Text = "Người đăng ký";
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Checked = false;
            this.dtpNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDangKy.Location = new System.Drawing.Point(627, 37);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.ShowCheckBox = true;
            this.dtpNgayDangKy.Size = new System.Drawing.Size(125, 20);
            this.dtpNgayDangKy.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 14);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ngày đăng ký biến động";
            // 
            // rtbNoiDungBienDong
            // 
            this.rtbNoiDungBienDong.Location = new System.Drawing.Point(119, 61);
            this.rtbNoiDungBienDong.Name = "rtbNoiDungBienDong";
            this.rtbNoiDungBienDong.Size = new System.Drawing.Size(633, 119);
            this.rtbNoiDungBienDong.TabIndex = 48;
            this.rtbNoiDungBienDong.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nội dung biến động";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 46;
            this.label1.Text = "Loại biến động";
            // 
            // cmbLoaiBienDong
            // 
            this.cmbLoaiBienDong.FormattingEnabled = true;
            this.cmbLoaiBienDong.Location = new System.Drawing.Point(119, 35);
            this.cmbLoaiBienDong.Name = "cmbLoaiBienDong";
            this.cmbLoaiBienDong.Size = new System.Drawing.Size(320, 22);
            this.cmbLoaiBienDong.TabIndex = 45;
            // 
            // CtrlDangKyBienDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpQuyetDinh);
            this.Controls.Add(this.btnLichSuBienDong);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTaoHoSoMoi);
            this.Name = "CtrlDangKyBienDong";
            this.Size = new System.Drawing.Size(842, 695);
            this.Load += new System.EventHandler(this.CtrlDangKyBienDong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpQuyetDinh.ResumeLayout(false);
            this.grpQuyetDinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvQuyetDinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaoHoSoMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLichSuBienDong;
        private System.Windows.Forms.DateTimePicker dtpNgayQuyetDinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCoQuanQuyetDinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoQuyetDinh;
        private System.Windows.Forms.GroupBox grpQuyetDinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNguoiDangKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbNoiDungBienDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoaiBienDong;
        private System.Windows.Forms.DataGridView dtgrvQuyetDinh;
        private System.Windows.Forms.Button btnXoaQD;
        private System.Windows.Forms.Button btnThemQD;
    }
}
