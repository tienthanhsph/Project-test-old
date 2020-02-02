/*
 * Created by SharpDevelop.
 * User: viet
 * Date: 8/25/2015
 * Time: 3:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace prjDatNongNghiep
{
	partial class frmQuyetDinhCapGCNDatNN
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.DataGridView dgrQuyetDinh;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dateNgayGiaoDat;
		private System.Windows.Forms.ComboBox cboNoiDung;
		private System.Windows.Forms.TextBox txtToTrinh;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dateNgayTrinh;
		private System.Windows.Forms.TextBox txtSoQuyetDinh;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnTraCuuCoQuan;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpNgayQuyetDinh;
		private System.Windows.Forms.TextBox txtCoQuanQuyetDinh;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCQQDXa;
		private System.Windows.Forms.TextBox txtToTrinhXa;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DateTimePicker DateToTrinhXa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCQQD;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Button btnLoad;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.dgrQuyetDinh = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.txtCQQDXa = new System.Windows.Forms.TextBox();
			this.txtToTrinhXa = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.DateToTrinhXa = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCQQD = new System.Windows.Forms.TextBox();
			this.dateNgayGiaoDat = new System.Windows.Forms.DateTimePicker();
			this.cboNoiDung = new System.Windows.Forms.ComboBox();
			this.txtToTrinh = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dateNgayTrinh = new System.Windows.Forms.DateTimePicker();
			this.txtSoQuyetDinh = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnTraCuuCoQuan = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpNgayQuyetDinh = new System.Windows.Forms.DateTimePicker();
			this.txtCoQuanQuyetDinh = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgrQuyetDinh)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnTim);
			this.groupBox1.Controls.Add(this.btnLoad);
			this.groupBox1.Controls.Add(this.btnOK);
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Controls.Add(this.btnSua);
			this.groupBox1.Controls.Add(this.btnCancel);
			this.groupBox1.Controls.Add(this.btnXoa);
			this.groupBox1.Location = new System.Drawing.Point(11, 235);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(613, 48);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			// 
			// btnTim
			// 
			this.btnTim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnTim.BackColor = System.Drawing.SystemColors.Control;
			this.btnTim.Location = new System.Drawing.Point(42, 19);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(63, 21);
			this.btnTim.TabIndex = 13;
			this.btnTim.Text = "Tìm Kiếm";
			this.btnTim.UseVisualStyleBackColor = false;
			this.btnTim.Click += new System.EventHandler(this.BtnTimClick);
			// 
			// btnLoad
			// 
			this.btnLoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnLoad.Location = new System.Drawing.Point(111, 19);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(58, 21);
			this.btnLoad.TabIndex = 14;
			this.btnLoad.Text = "Tất Cả";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.BtlLoadClick);
			// 
			// btnOK
			// 
			this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnOK.Enabled = false;
			this.btnOK.Location = new System.Drawing.Point(479, 19);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(53, 21);
			this.btnOK.TabIndex = 11;
			this.btnOK.Text = "Đồng ý";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnThem
			// 
			this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnThem.BackColor = System.Drawing.SystemColors.Control;
			this.btnThem.Enabled = false;
			this.btnThem.Location = new System.Drawing.Point(291, 19);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(46, 21);
			this.btnThem.TabIndex = 8;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnSua.Enabled = false;
			this.btnSua.Location = new System.Drawing.Point(342, 19);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(38, 21);
			this.btnSua.TabIndex = 9;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(539, 19);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(61, 21);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Hủy lệnh";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
			this.btnXoa.Enabled = false;
			this.btnXoa.Location = new System.Drawing.Point(387, 19);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(38, 21);
			this.btnXoa.TabIndex = 10;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// dgrQuyetDinh
			// 
			this.dgrQuyetDinh.AllowUserToAddRows = false;
			this.dgrQuyetDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgrQuyetDinh.Location = new System.Drawing.Point(11, 289);
			this.dgrQuyetDinh.Name = "dgrQuyetDinh";
			this.dgrQuyetDinh.Size = new System.Drawing.Size(613, 143);
			this.dgrQuyetDinh.TabIndex = 18;
			this.dgrQuyetDinh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgrQuyetDinhMouseClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txtCQQDXa);
			this.panel1.Controls.Add(this.txtToTrinhXa);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.DateToTrinhXa);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtCQQD);
			this.panel1.Controls.Add(this.dateNgayGiaoDat);
			this.panel1.Controls.Add(this.cboNoiDung);
			this.panel1.Controls.Add(this.txtToTrinh);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.dateNgayTrinh);
			this.panel1.Controls.Add(this.txtSoQuyetDinh);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.btnTraCuuCoQuan);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dtpNgayQuyetDinh);
			this.panel1.Controls.Add(this.txtCoQuanQuyetDinh);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(612, 217);
			this.panel1.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(386, 166);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 20);
			this.label9.TabIndex = 41;
			this.label9.Text = "CQQĐ";
			// 
			// txtCQQDXa
			// 
			this.txtCQQDXa.Location = new System.Drawing.Point(439, 166);
			this.txtCQQDXa.Name = "txtCQQDXa";
			this.txtCQQDXa.Size = new System.Drawing.Size(132, 20);
			this.txtCQQDXa.TabIndex = 40;
			// 
			// txtToTrinhXa
			// 
			this.txtToTrinhXa.Location = new System.Drawing.Point(131, 166);
			this.txtToTrinhXa.Name = "txtToTrinhXa";
			this.txtToTrinhXa.Size = new System.Drawing.Size(69, 20);
			this.txtToTrinhXa.TabIndex = 39;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(206, 166);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(55, 23);
			this.label10.TabIndex = 38;
			this.label10.Text = "Ngày trình";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(25, 168);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 37;
			this.label11.Text = "Tờ trình";
			// 
			// DateToTrinhXa
			// 
			this.DateToTrinhXa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateToTrinhXa.Location = new System.Drawing.Point(264, 166);
			this.DateToTrinhXa.Name = "DateToTrinhXa";
			this.DateToTrinhXa.ShowCheckBox = true;
			this.DateToTrinhXa.Size = new System.Drawing.Size(115, 20);
			this.DateToTrinhXa.TabIndex = 36;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(386, 132);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 20);
			this.label1.TabIndex = 35;
			this.label1.Text = "CQQĐ";
			// 
			// txtCQQD
			// 
			this.txtCQQD.Location = new System.Drawing.Point(439, 132);
			this.txtCQQD.Name = "txtCQQD";
			this.txtCQQD.Size = new System.Drawing.Size(132, 20);
			this.txtCQQD.TabIndex = 34;
			// 
			// dateNgayGiaoDat
			// 
			this.dateNgayGiaoDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateNgayGiaoDat.Location = new System.Drawing.Point(131, 106);
			this.dateNgayGiaoDat.Name = "dateNgayGiaoDat";
			this.dateNgayGiaoDat.ShowCheckBox = true;
			this.dateNgayGiaoDat.Size = new System.Drawing.Size(120, 20);
			this.dateNgayGiaoDat.TabIndex = 33;
			// 
			// cboNoiDung
			// 
			this.cboNoiDung.FormattingEnabled = true;
			this.cboNoiDung.Location = new System.Drawing.Point(130, 79);
			this.cboNoiDung.Name = "cboNoiDung";
			this.cboNoiDung.Size = new System.Drawing.Size(441, 21);
			this.cboNoiDung.TabIndex = 32;
			// 
			// txtToTrinh
			// 
			this.txtToTrinh.Location = new System.Drawing.Point(131, 132);
			this.txtToTrinh.Name = "txtToTrinh";
			this.txtToTrinh.Size = new System.Drawing.Size(69, 20);
			this.txtToTrinh.TabIndex = 31;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(206, 132);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 23);
			this.label7.TabIndex = 30;
			this.label7.Text = "Ngày trình";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(25, 134);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 29;
			this.label8.Text = "Tờ trình";
			// 
			// dateNgayTrinh
			// 
			this.dateNgayTrinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateNgayTrinh.Location = new System.Drawing.Point(264, 132);
			this.dateNgayTrinh.Name = "dateNgayTrinh";
			this.dateNgayTrinh.ShowCheckBox = true;
			this.dateNgayTrinh.Size = new System.Drawing.Size(115, 20);
			this.dateNgayTrinh.TabIndex = 28;
			// 
			// txtSoQuyetDinh
			// 
			this.txtSoQuyetDinh.Location = new System.Drawing.Point(130, 23);
			this.txtSoQuyetDinh.Name = "txtSoQuyetDinh";
			this.txtSoQuyetDinh.Size = new System.Drawing.Size(121, 20);
			this.txtSoQuyetDinh.TabIndex = 27;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(25, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 26;
			this.label6.Text = "Ngày giao đất";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(25, 83);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 24;
			this.label5.Text = "Nội Dung";
			// 
			// btnTraCuuCoQuan
			// 
			this.btnTraCuuCoQuan.Location = new System.Drawing.Point(538, 53);
			this.btnTraCuuCoQuan.Name = "btnTraCuuCoQuan";
			this.btnTraCuuCoQuan.Size = new System.Drawing.Size(29, 22);
			this.btnTraCuuCoQuan.TabIndex = 19;
			this.btnTraCuuCoQuan.Text = "...";
			this.btnTraCuuCoQuan.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(276, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "Ngày quyết định";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(25, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "Cơ quan quyết định ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(51, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "Số quyết định";
			// 
			// dtpNgayQuyetDinh
			// 
			this.dtpNgayQuyetDinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayQuyetDinh.Location = new System.Drawing.Point(373, 25);
			this.dtpNgayQuyetDinh.Name = "dtpNgayQuyetDinh";
			this.dtpNgayQuyetDinh.ShowCheckBox = true;
			this.dtpNgayQuyetDinh.Size = new System.Drawing.Size(115, 20);
			this.dtpNgayQuyetDinh.TabIndex = 15;
			// 
			// txtCoQuanQuyetDinh
			// 
			this.txtCoQuanQuyetDinh.Location = new System.Drawing.Point(131, 55);
			this.txtCoQuanQuyetDinh.Name = "txtCoQuanQuyetDinh";
			this.txtCoQuanQuyetDinh.Size = new System.Drawing.Size(400, 20);
			this.txtCoQuanQuyetDinh.TabIndex = 14;
			// 
			// frmQuyetDinhCapGCNDatNN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 444);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgrQuyetDinh);
			this.Controls.Add(this.panel1);
			this.Name = "frmQuyetDinhCapGCNDatNN";
			this.Text = "frmQuyetDinhCapGCNDatNN";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgrQuyetDinh)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
