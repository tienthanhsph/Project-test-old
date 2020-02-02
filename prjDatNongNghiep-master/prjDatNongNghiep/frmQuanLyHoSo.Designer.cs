namespace prjDatNongNghiep
{
    partial class frmQuanLyHoSo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkHoSoBaoXoa = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbThon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTrangThaiHS = new System.Windows.Forms.ComboBox();
            this.cmbLoaiThoiHan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDVHC = new System.Windows.Forms.ComboBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnXoaHoSo = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNguoi = new System.Windows.Forms.TextBox();
            this.txtTBD = new System.Windows.Forms.TextBox();
            this.lblThua = new System.Windows.Forms.Label();
            this.lblTBD = new System.Windows.Forms.Label();
            this.txtThua = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(957, 429);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtThua);
            this.groupBox1.Controls.Add(this.lblTBD);
            this.groupBox1.Controls.Add(this.lblThua);
            this.groupBox1.Controls.Add(this.txtTBD);
            this.groupBox1.Controls.Add(this.txtTenNguoi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkHoSoBaoXoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbThon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTrangThaiHS);
            this.groupBox1.Controls.Add(this.cmbLoaiThoiHan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDVHC);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 131);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // chkHoSoBaoXoa
            // 
            this.chkHoSoBaoXoa.AutoSize = true;
            this.chkHoSoBaoXoa.Location = new System.Drawing.Point(854, 19);
            this.chkHoSoBaoXoa.Name = "chkHoSoBaoXoa";
            this.chkHoSoBaoXoa.Size = new System.Drawing.Size(97, 18);
            this.chkHoSoBaoXoa.TabIndex = 15;
            this.chkHoSoBaoXoa.Text = "Hồ sơ báo xóa";
            this.chkHoSoBaoXoa.UseVisualStyleBackColor = true;
            this.chkHoSoBaoXoa.CheckedChanged += new System.EventHandler(this.chkHoSoBaoXoa_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Thôn";
            // 
            // cmbThon
            // 
            this.cmbThon.FormattingEnabled = true;
            this.cmbThon.Location = new System.Drawing.Point(215, 17);
            this.cmbThon.Name = "cmbThon";
            this.cmbThon.Size = new System.Drawing.Size(116, 22);
            this.cmbThon.TabIndex = 13;
            this.cmbThon.SelectedIndexChanged += new System.EventHandler(this.cmbThon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Loại thời hạn";
            // 
            // cmbTrangThaiHS
            // 
            this.cmbTrangThaiHS.FormattingEnabled = true;
            this.cmbTrangThaiHS.Location = new System.Drawing.Point(658, 17);
            this.cmbTrangThaiHS.Name = "cmbTrangThaiHS";
            this.cmbTrangThaiHS.Size = new System.Drawing.Size(143, 22);
            this.cmbTrangThaiHS.TabIndex = 5;
            this.cmbTrangThaiHS.SelectedIndexChanged += new System.EventHandler(this.cmbTrangThaiHS_SelectedIndexChanged);
            // 
            // cmbLoaiThoiHan
            // 
            this.cmbLoaiThoiHan.FormattingEnabled = true;
            this.cmbLoaiThoiHan.Location = new System.Drawing.Point(435, 17);
            this.cmbLoaiThoiHan.Name = "cmbLoaiThoiHan";
            this.cmbLoaiThoiHan.Size = new System.Drawing.Size(104, 22);
            this.cmbLoaiThoiHan.TabIndex = 10;
            this.cmbLoaiThoiHan.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiThoiHan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Xã";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trạng thái hồ sơ";
            // 
            // cmbDVHC
            // 
            this.cmbDVHC.FormattingEnabled = true;
            this.cmbDVHC.Location = new System.Drawing.Point(35, 17);
            this.cmbDVHC.Name = "cmbDVHC";
            this.cmbDVHC.Size = new System.Drawing.Size(116, 22);
            this.cmbDVHC.TabIndex = 7;
            this.cmbDVHC.SelectedIndexChanged += new System.EventHandler(this.cmbDVHC_SelectedIndexChanged);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.ForeColor = System.Drawing.Color.Maroon;
            this.lblKQ.Location = new System.Drawing.Point(212, 598);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(77, 19);
            this.lblKQ.TabIndex = 13;
            this.lblKQ.Text = "Tổng số: ";
            // 
            // btnXoaHoSo
            // 
            this.btnXoaHoSo.Location = new System.Drawing.Point(894, 594);
            this.btnXoaHoSo.Name = "btnXoaHoSo";
            this.btnXoaHoSo.Size = new System.Drawing.Size(75, 23);
            this.btnXoaHoSo.TabIndex = 14;
            this.btnXoaHoSo.Text = "Xóa hồ sơ";
            this.btnXoaHoSo.UseVisualStyleBackColor = true;
            this.btnXoaHoSo.Click += new System.EventHandler(this.btnXoaHoSo_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(12, 598);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 15;
            this.Refresh.Text = "Đổi quyền";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tên người";
            // 
            // txtTenNguoi
            // 
            this.txtTenNguoi.Location = new System.Drawing.Point(82, 83);
            this.txtTenNguoi.Name = "txtTenNguoi";
            this.txtTenNguoi.Size = new System.Drawing.Size(182, 20);
            this.txtTenNguoi.TabIndex = 16;
            this.txtTenNguoi.TextChanged += new System.EventHandler(this.txtTenNguoi_TextChanged);
            // 
            // txtTBD
            // 
            this.txtTBD.Location = new System.Drawing.Point(725, 83);
            this.txtTBD.Name = "txtTBD";
            this.txtTBD.Size = new System.Drawing.Size(76, 20);
            this.txtTBD.TabIndex = 22;
            this.txtTBD.TextChanged += new System.EventHandler(this.txtTBD_TextChanged);
            // 
            // lblThua
            // 
            this.lblThua.AutoSize = true;
            this.lblThua.Location = new System.Drawing.Point(824, 86);
            this.lblThua.Name = "lblThua";
            this.lblThua.Size = new System.Drawing.Size(45, 14);
            this.lblThua.TabIndex = 21;
            this.lblThua.Text = "Số thửa";
            // 
            // lblTBD
            // 
            this.lblTBD.AutoSize = true;
            this.lblTBD.Location = new System.Drawing.Point(660, 86);
            this.lblTBD.Name = "lblTBD";
            this.lblTBD.Size = new System.Drawing.Size(56, 14);
            this.lblTBD.TabIndex = 20;
            this.lblTBD.Text = "Tờ bản đồ";
            // 
            // txtThua
            // 
            this.txtThua.Location = new System.Drawing.Point(875, 83);
            this.txtThua.Name = "txtThua";
            this.txtThua.Size = new System.Drawing.Size(76, 20);
            this.txtThua.TabIndex = 23;
            this.txtThua.TextChanged += new System.EventHandler(this.txtThua_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(364, 83);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(175, 20);
            this.txtDiaChi.TabIndex = 24;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(312, 86);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 14);
            this.lblDiaChi.TabIndex = 25;
            this.lblDiaChi.Text = "Địa chỉ ";
            // 
            // frmQuanLyHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 632);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.btnXoaHoSo);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmQuanLyHoSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hồ sơ cấp giấy chứng nhận đất nông nghiệp";
            this.Load += new System.EventHandler(this.frmQuanLyHoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDVHC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTrangThaiHS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLoaiThoiHan;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.CheckBox chkHoSoBaoXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbThon;
        private System.Windows.Forms.Button btnXoaHoSo;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtThua;
        private System.Windows.Forms.Label lblTBD;
        private System.Windows.Forms.Label lblThua;
        private System.Windows.Forms.TextBox txtTBD;
        private System.Windows.Forms.TextBox txtTenNguoi;
        private System.Windows.Forms.Label label5;
    }
}