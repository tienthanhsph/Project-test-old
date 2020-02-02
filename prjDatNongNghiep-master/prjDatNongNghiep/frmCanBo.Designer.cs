namespace prjDatNongNghiep
{
    partial class frmCanBo
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHoiDong = new System.Windows.Forms.Button();
            this.btnChonNguoi = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Lavender;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.cmbDanhMuc);
            this.panel5.Controls.Add(this.txtChucVu);
            this.panel5.Controls.Add(this.txtTen);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(606, 415);
            this.panel5.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "Bộ phận";
            // 
            // cmbDanhMuc
            // 
            this.cmbDanhMuc.FormattingEnabled = true;
            this.cmbDanhMuc.Items.AddRange(new object[] {
            "Cán bộ UBND",
            "Cán bộ cơ quan địa chính",
            "Cán bộ Hội đồng giao đất nông nghiệp",
            "Tiêu đề ký"});
            this.cmbDanhMuc.Location = new System.Drawing.Point(170, 14);
            this.cmbDanhMuc.Name = "cmbDanhMuc";
            this.cmbDanhMuc.Size = new System.Drawing.Size(254, 22);
            this.cmbDanhMuc.TabIndex = 9;
            this.cmbDanhMuc.TextChanged += new System.EventHandler(this.cmbDanhMuc_TextChanged);
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(170, 69);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(128, 20);
            this.txtChucVu.TabIndex = 8;
            this.txtChucVu.TextChanged += new System.EventHandler(this.txtChucVu_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(170, 43);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(254, 20);
            this.txtTen.TabIndex = 7;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "Chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.Lavender;
            this.dataGridView1.Location = new System.Drawing.Point(0, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(606, 294);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(382, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(37, 24);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(306, 453);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 24);
            this.btnOK.TabIndex = 65;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(152, 453);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 24);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(111, 453);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(39, 24);
            this.btnSua.TabIndex = 63;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(8, 453);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 24);
            this.btnThem.TabIndex = 62;
            this.btnThem.Text = "Thêm người";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Lavender;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(644, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(268, 372);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 14);
            this.label1.TabIndex = 67;
            this.label1.Text = "Thành viên hội đồng";
            // 
            // btnHoiDong
            // 
            this.btnHoiDong.Location = new System.Drawing.Point(841, 453);
            this.btnHoiDong.Name = "btnHoiDong";
            this.btnHoiDong.Size = new System.Drawing.Size(71, 24);
            this.btnHoiDong.TabIndex = 68;
            this.btnHoiDong.Text = "Lưu lại";
            this.btnHoiDong.UseVisualStyleBackColor = true;
            this.btnHoiDong.Click += new System.EventHandler(this.btnHoiDong_Click);
            // 
            // btnChonNguoi
            // 
            this.btnChonNguoi.Location = new System.Drawing.Point(477, 453);
            this.btnChonNguoi.Name = "btnChonNguoi";
            this.btnChonNguoi.Size = new System.Drawing.Size(137, 24);
            this.btnChonNguoi.TabIndex = 69;
            this.btnChonNguoi.Text = "CHỌN";
            this.btnChonNguoi.UseVisualStyleBackColor = true;
            this.btnChonNguoi.Click += new System.EventHandler(this.btnChonNguoi_Click);
            // 
            // frmCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(943, 508);
            this.Controls.Add(this.btnChonNguoi);
            this.Controls.Add(this.btnHoiDong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel5);
            this.Name = "frmCanBo";
            this.Text = "Danh sách cán bộ";
            this.Load += new System.EventHandler(this.frmCanBo_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHoiDong;
        private System.Windows.Forms.Button btnChonNguoi;
        public System.Windows.Forms.ComboBox cmbDanhMuc;
    }
}