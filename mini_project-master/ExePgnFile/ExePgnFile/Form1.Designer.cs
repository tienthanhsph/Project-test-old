namespace ExePgnFile
{
    partial class Form1
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.cmbNguoiChoi = new System.Windows.Forms.ComboBox();
            this.chkWin = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ELO = new System.Windows.Forms.NumericUpDown();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.rBTrang = new System.Windows.Forms.RadioButton();
            this.rBDen = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkLoaiBoTranHoa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ELO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Location = new System.Drawing.Point(815, 13);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(65, 21);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cmbNguoiChoi
            // 
            this.cmbNguoiChoi.AllowDrop = true;
            this.cmbNguoiChoi.FormattingEnabled = true;
            this.cmbNguoiChoi.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbNguoiChoi.Location = new System.Drawing.Point(75, 13);
            this.cmbNguoiChoi.Name = "cmbNguoiChoi";
            this.cmbNguoiChoi.Size = new System.Drawing.Size(143, 21);
            this.cmbNguoiChoi.TabIndex = 1;
            // 
            // chkWin
            // 
            this.chkWin.AutoSize = true;
            this.chkWin.Location = new System.Drawing.Point(234, 15);
            this.chkWin.Name = "chkWin";
            this.chkWin.Size = new System.Drawing.Size(57, 17);
            this.chkWin.TabIndex = 2;
            this.chkWin.Text = "Thắng";
            this.chkWin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Người chơi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ELO";
            // 
            // ELO
            // 
            this.ELO.Location = new System.Drawing.Point(417, 14);
            this.ELO.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.ELO.Name = "ELO";
            this.ELO.Size = new System.Drawing.Size(74, 20);
            this.ELO.TabIndex = 6;
            // 
            // btnKetQua
            // 
            this.btnKetQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetQua.Location = new System.Drawing.Point(75, 89);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(75, 21);
            this.btnKetQua.TabIndex = 7;
            this.btnKetQua.Text = "Kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Location = new System.Drawing.Point(815, 40);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(65, 21);
            this.btnXuatFile.TabIndex = 10;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // rBTrang
            // 
            this.rBTrang.AutoSize = true;
            this.rBTrang.Location = new System.Drawing.Point(81, 43);
            this.rBTrang.Name = "rBTrang";
            this.rBTrang.Size = new System.Drawing.Size(53, 17);
            this.rBTrang.TabIndex = 11;
            this.rBTrang.Text = "Trắng";
            this.rBTrang.UseVisualStyleBackColor = true;
            // 
            // rBDen
            // 
            this.rBDen.AutoSize = true;
            this.rBDen.Location = new System.Drawing.Point(155, 43);
            this.rBDen.Name = "rBDen";
            this.rBDen.Size = new System.Drawing.Size(45, 17);
            this.rBDen.TabIndex = 12;
            this.rBDen.Text = "Đen";
            this.rBDen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(867, 394);
            this.dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(784, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 21);
            this.button1.TabIndex = 16;
            this.button1.Text = "Xem ván đấu...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(815, 100);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 21);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "Khởi tạo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // chkLoaiBoTranHoa
            // 
            this.chkLoaiBoTranHoa.AutoSize = true;
            this.chkLoaiBoTranHoa.Location = new System.Drawing.Point(234, 44);
            this.chkLoaiBoTranHoa.Name = "chkLoaiBoTranHoa";
            this.chkLoaiBoTranHoa.Size = new System.Drawing.Size(103, 17);
            this.chkLoaiBoTranHoa.TabIndex = 19;
            this.chkLoaiBoTranHoa.Text = "Loại bỏ trận hòa";
            this.chkLoaiBoTranHoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 591);
            this.Controls.Add(this.chkLoaiBoTranHoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rBDen);
            this.Controls.Add(this.rBTrang);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.ELO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkWin);
            this.Controls.Add(this.cmbNguoiChoi);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Xử lý file PGN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ELO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.ComboBox cmbNguoiChoi;
        private System.Windows.Forms.CheckBox chkWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ELO;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.RadioButton rBTrang;
        private System.Windows.Forms.RadioButton rBDen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkLoaiBoTranHoa;
    }
}

