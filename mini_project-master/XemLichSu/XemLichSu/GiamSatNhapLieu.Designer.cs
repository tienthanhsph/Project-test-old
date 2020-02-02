namespace XemLichSu
{
    partial class GiamSatNhapLieu
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtDanhMuc = new System.Windows.Forms.TextBox();
            this.txtThaoTac = new System.Windows.Forms.TextBox();
            this.dtpNgayThaoTac = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(113, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(109, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtMaHoSo
            // 
            this.txtMaHoSo.Location = new System.Drawing.Point(223, 30);
            this.txtMaHoSo.Name = "txtMaHoSo";
            this.txtMaHoSo.Size = new System.Drawing.Size(109, 20);
            this.txtMaHoSo.TabIndex = 2;
            this.txtMaHoSo.TextChanged += new System.EventHandler(this.txtMaHoSo_TextChanged);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(553, 30);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(202, 20);
            this.txtNoiDung.TabIndex = 3;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // txtDanhMuc
            // 
            this.txtDanhMuc.Location = new System.Drawing.Point(443, 30);
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.Size = new System.Drawing.Size(109, 20);
            this.txtDanhMuc.TabIndex = 5;
            this.txtDanhMuc.TextChanged += new System.EventHandler(this.txtDanhMuc_TextChanged);
            // 
            // txtThaoTac
            // 
            this.txtThaoTac.Location = new System.Drawing.Point(333, 30);
            this.txtThaoTac.Name = "txtThaoTac";
            this.txtThaoTac.Size = new System.Drawing.Size(109, 20);
            this.txtThaoTac.TabIndex = 4;
            this.txtThaoTac.TextChanged += new System.EventHandler(this.txtThaoTac_TextChanged);
            // 
            // dtpNgayThaoTac
            // 
            this.dtpNgayThaoTac.Checked = false;
            this.dtpNgayThaoTac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThaoTac.Location = new System.Drawing.Point(2, 30);
            this.dtpNgayThaoTac.Name = "dtpNgayThaoTac";
            this.dtpNgayThaoTac.ShowCheckBox = true;
            this.dtpNgayThaoTac.Size = new System.Drawing.Size(109, 20);
            this.dtpNgayThaoTac.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ngày thao tác";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã hồ sơ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thao tác";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Danh mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nội dung";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(758, 365);
            this.dataGridView1.TabIndex = 13;
            // 
            // GiamSatNhapLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 435);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayThaoTac);
            this.Controls.Add(this.txtDanhMuc);
            this.Controls.Add(this.txtThaoTac);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtMaHoSo);
            this.Controls.Add(this.txtUsername);
            this.Name = "GiamSatNhapLieu";
            this.Text = "Giám sát nhập liệu";
            this.Load += new System.EventHandler(this.GiamSatNhapLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtDanhMuc;
        private System.Windows.Forms.TextBox txtThaoTac;
        private System.Windows.Forms.DateTimePicker dtpNgayThaoTac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}