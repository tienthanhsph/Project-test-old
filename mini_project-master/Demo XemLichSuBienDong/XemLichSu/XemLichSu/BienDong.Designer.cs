namespace XemLichSu
{
    partial class BienDong
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayBienDong = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLoaiBienDong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaBienDong = new System.Windows.Forms.TextBox();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaoHoSoMoi = new System.Windows.Forms.Button();
            this.btnLichSuBienDong = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(32, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 185);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(689, 166);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbNoiDung);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpNgayBienDong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbLoaiBienDong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaBienDong);
            this.groupBox1.Controls.Add(this.txtMaHoSo);
            this.groupBox1.Location = new System.Drawing.Point(32, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 154);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Location = new System.Drawing.Point(100, 77);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(578, 75);
            this.rtbNoiDung.TabIndex = 11;
            this.rtbNoiDung.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nội dung";
            // 
            // dtpNgayBienDong
            // 
            this.dtpNgayBienDong.Checked = false;
            this.dtpNgayBienDong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBienDong.Location = new System.Drawing.Point(569, 28);
            this.dtpNgayBienDong.Name = "dtpNgayBienDong";
            this.dtpNgayBienDong.ShowCheckBox = true;
            this.dtpNgayBienDong.Size = new System.Drawing.Size(109, 20);
            this.dtpNgayBienDong.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày biến động";
            // 
            // cmbLoaiBienDong
            // 
            this.cmbLoaiBienDong.FormattingEnabled = true;
            this.cmbLoaiBienDong.Location = new System.Drawing.Point(485, 52);
            this.cmbLoaiBienDong.Name = "cmbLoaiBienDong";
            this.cmbLoaiBienDong.Size = new System.Drawing.Size(193, 21);
            this.cmbLoaiBienDong.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại biến động";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã biến động";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hồ sơ";
            // 
            // txtMaBienDong
            // 
            this.txtMaBienDong.Location = new System.Drawing.Point(100, 52);
            this.txtMaBienDong.Name = "txtMaBienDong";
            this.txtMaBienDong.ReadOnly = true;
            this.txtMaBienDong.Size = new System.Drawing.Size(76, 20);
            this.txtMaBienDong.TabIndex = 2;
            // 
            // txtMaHoSo
            // 
            this.txtMaHoSo.Location = new System.Drawing.Point(100, 28);
            this.txtMaHoSo.Name = "txtMaHoSo";
            this.txtMaHoSo.ReadOnly = true;
            this.txtMaHoSo.Size = new System.Drawing.Size(76, 20);
            this.txtMaHoSo.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(324, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 21);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(265, 393);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(57, 21);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(132, 393);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(38, 21);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(85, 393);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 21);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(32, 393);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(51, 21);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaoHoSoMoi
            // 
            this.btnTaoHoSoMoi.Location = new System.Drawing.Point(511, 391);
            this.btnTaoHoSoMoi.Name = "btnTaoHoSoMoi";
            this.btnTaoHoSoMoi.Size = new System.Drawing.Size(93, 23);
            this.btnTaoHoSoMoi.TabIndex = 14;
            this.btnTaoHoSoMoi.Text = "Tạo hồ sơ mới";
            this.btnTaoHoSoMoi.UseVisualStyleBackColor = true;
            this.btnTaoHoSoMoi.Click += new System.EventHandler(this.btnTaoHoSoMoi_Click);
            // 
            // btnLichSuBienDong
            // 
            this.btnLichSuBienDong.Location = new System.Drawing.Point(610, 391);
            this.btnLichSuBienDong.Name = "btnLichSuBienDong";
            this.btnLichSuBienDong.Size = new System.Drawing.Size(114, 23);
            this.btnLichSuBienDong.TabIndex = 15;
            this.btnLichSuBienDong.Text = "Lịch sử biến động";
            this.btnLichSuBienDong.UseVisualStyleBackColor = true;
            this.btnLichSuBienDong.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // BienDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 435);
            this.Controls.Add(this.btnLichSuBienDong);
            this.Controls.Add(this.btnTaoHoSoMoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "BienDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Biến động";
            this.Load += new System.EventHandler(this.BienDong_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaBienDong;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayBienDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLoaiBienDong;
        private System.Windows.Forms.Button btnTaoHoSoMoi;
        private System.Windows.Forms.Button btnLichSuBienDong;
    }
}