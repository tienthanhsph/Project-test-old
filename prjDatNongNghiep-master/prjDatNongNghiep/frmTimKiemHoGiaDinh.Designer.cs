/*
 * Created by SharpDevelop.
 * User: viet
 * Date: 8/17/2015
 * Time: 4:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace prjDatNongNghiep
{
	partial class frmTimKiemHoGiaDinh
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblDiaChi;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtCMND;
		private System.Windows.Forms.TextBox txtTenNguoi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCMND;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnChonHoGiaDinh;
		
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
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenNguoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnChonHoGiaDinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(49, 53);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 14);
            this.lblDiaChi.TabIndex = 21;
            this.lblDiaChi.Text = "Địa chỉ ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(101, 50);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(436, 20);
            this.txtDiaChi.TabIndex = 20;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(427, 26);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(110, 20);
            this.txtCMND.TabIndex = 17;
            // 
            // txtTenNguoi
            // 
            this.txtTenNguoi.Location = new System.Drawing.Point(101, 26);
            this.txtTenNguoi.Name = "txtTenNguoi";
            this.txtTenNguoi.Size = new System.Drawing.Size(200, 20);
            this.txtTenNguoi.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên người";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(378, 29);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(36, 14);
            this.lblCMND.TabIndex = 18;
            this.lblCMND.Text = "CMND";
            // 
            // btnTim
            // 
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Location = new System.Drawing.Point(101, 85);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(98, 23);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.BtnTimClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(744, 379);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1CellMouseClick);
            // 
            // btnChonHoGiaDinh
            // 
            this.btnChonHoGiaDinh.Location = new System.Drawing.Point(340, 513);
            this.btnChonHoGiaDinh.Name = "btnChonHoGiaDinh";
            this.btnChonHoGiaDinh.Size = new System.Drawing.Size(75, 25);
            this.btnChonHoGiaDinh.TabIndex = 23;
            this.btnChonHoGiaDinh.Text = "Chọn";
            this.btnChonHoGiaDinh.UseVisualStyleBackColor = true;
            this.btnChonHoGiaDinh.Click += new System.EventHandler(this.BtnChonHoGiaDinhClick);
            // 
            // frmTimKiemHoGiaDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(771, 550);
            this.Controls.Add(this.btnChonHoGiaDinh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtTenNguoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.btnTim);
            this.Name = "frmTimKiemHoGiaDinh";
            this.Text = "Tìm kiếm hộ gia đình";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
