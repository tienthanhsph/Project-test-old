namespace prjDatNongNghiep
{
    partial class frmTimKiem
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
            this.txtTenNguoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblTBD = new System.Windows.Forms.Label();
            this.lblThua = new System.Windows.Forms.Label();
            this.txtTBD = new System.Windows.Forms.TextBox();
            this.txtThua = new System.Windows.Forms.TextBox();
            this.btnTim1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnHoSo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTim2 = new System.Windows.Forms.Button();
            this.ChkHoSoConHieuLuc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenNguoi
            // 
            this.txtTenNguoi.Location = new System.Drawing.Point(109, 19);
            this.txtTenNguoi.Name = "txtTenNguoi";
            this.txtTenNguoi.Size = new System.Drawing.Size(200, 20);
            this.txtTenNguoi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên người";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(61, 44);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(36, 14);
            this.lblCMND.TabIndex = 3;
            this.lblCMND.Text = "CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(109, 41);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(110, 20);
            this.txtCMND.TabIndex = 2;
            // 
            // lblTBD
            // 
            this.lblTBD.AutoSize = true;
            this.lblTBD.Location = new System.Drawing.Point(44, 22);
            this.lblTBD.Name = "lblTBD";
            this.lblTBD.Size = new System.Drawing.Size(56, 14);
            this.lblTBD.TabIndex = 4;
            this.lblTBD.Text = "Tờ bản đồ";
            // 
            // lblThua
            // 
            this.lblThua.AutoSize = true;
            this.lblThua.Location = new System.Drawing.Point(226, 22);
            this.lblThua.Name = "lblThua";
            this.lblThua.Size = new System.Drawing.Size(45, 14);
            this.lblThua.TabIndex = 5;
            this.lblThua.Text = "Số thửa";
            // 
            // txtTBD
            // 
            this.txtTBD.Location = new System.Drawing.Point(109, 19);
            this.txtTBD.Name = "txtTBD";
            this.txtTBD.Size = new System.Drawing.Size(76, 20);
            this.txtTBD.TabIndex = 6;
            // 
            // txtThua
            // 
            this.txtThua.Location = new System.Drawing.Point(277, 19);
            this.txtThua.Name = "txtThua";
            this.txtThua.Size = new System.Drawing.Size(76, 20);
            this.txtThua.TabIndex = 7;
            // 
            // btnTim1
            // 
            this.btnTim1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim1.Location = new System.Drawing.Point(109, 72);
            this.btnTim1.Name = "btnTim1";
            this.btnTim1.Size = new System.Drawing.Size(98, 23);
            this.btnTim1.TabIndex = 8;
            this.btnTim1.Text = "Tìm";
            this.btnTim1.UseVisualStyleBackColor = true;
            this.btnTim1.Click += new System.EventHandler(this.btnTim1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(819, 356);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnHoSo
            // 
            this.btnHoSo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoSo.Location = new System.Drawing.Point(778, 563);
            this.btnHoSo.Name = "btnHoSo";
            this.btnHoSo.Size = new System.Drawing.Size(67, 24);
            this.btnHoSo.TabIndex = 14;
            this.btnHoSo.Text = "HỒ SƠ ";
            this.btnHoSo.UseVisualStyleBackColor = true;
            this.btnHoSo.Click += new System.EventHandler(this.btnHoSo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 130);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Lavender;
            this.tabPage1.Controls.Add(this.lblDiaChi);
            this.tabPage1.Controls.Add(this.txtDiaChi);
            this.tabPage1.Controls.Add(this.txtCMND);
            this.tabPage1.Controls.Add(this.txtTenNguoi);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblCMND);
            this.tabPage1.Controls.Add(this.btnTim1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 135);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm theo chủ";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(337, 41);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 14);
            this.lblDiaChi.TabIndex = 14;
            this.lblDiaChi.Text = "Địa chỉ ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(389, 38);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(375, 20);
            this.txtDiaChi.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.btnTim2);
            this.tabPage2.Controls.Add(this.txtThua);
            this.tabPage2.Controls.Add(this.lblTBD);
            this.tabPage2.Controls.Add(this.lblThua);
            this.tabPage2.Controls.Add(this.txtTBD);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(811, 103);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tờ bản đồ, số thửa";
            // 
            // btnTim2
            // 
            this.btnTim2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim2.Location = new System.Drawing.Point(109, 72);
            this.btnTim2.Name = "btnTim2";
            this.btnTim2.Size = new System.Drawing.Size(98, 23);
            this.btnTim2.TabIndex = 13;
            this.btnTim2.Text = "Tìm";
            this.btnTim2.UseVisualStyleBackColor = true;
            this.btnTim2.Click += new System.EventHandler(this.btnTim2_Click);
            // 
            // ChkHoSoConHieuLuc
            // 
            this.ChkHoSoConHieuLuc.AutoSize = true;
            this.ChkHoSoConHieuLuc.Location = new System.Drawing.Point(629, 148);
            this.ChkHoSoConHieuLuc.Name = "ChkHoSoConHieuLuc";
            this.ChkHoSoConHieuLuc.Size = new System.Drawing.Size(216, 18);
            this.ChkHoSoConHieuLuc.TabIndex = 15;
            this.ChkHoSoConHieuLuc.Text = "Tìm cả những hồ sơ không còn hiệu lực";
            this.ChkHoSoConHieuLuc.UseVisualStyleBackColor = true;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(872, 600);
            this.Controls.Add(this.ChkHoSoConHieuLuc);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnHoSo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNguoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblTBD;
        private System.Windows.Forms.Label lblThua;
        private System.Windows.Forms.TextBox txtTBD;
        private System.Windows.Forms.TextBox txtThua;
        private System.Windows.Forms.Button btnTim1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHoSo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTim2;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.CheckBox ChkHoSoConHieuLuc;
    }
}