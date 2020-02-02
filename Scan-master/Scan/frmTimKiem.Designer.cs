namespace Scan
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
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.btnError = new System.Windows.Forms.Button();
        	this.btnTimKiem = new System.Windows.Forms.Button();
        	this.chkChonBanDo = new System.Windows.Forms.CheckBox();
        	this.textBox3 = new System.Windows.Forms.TextBox();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.btnTimQuyetDinh = new System.Windows.Forms.Button();
        	this.cmbQuyetDinh = new System.Windows.Forms.ComboBox();
        	this.btnMoveFile = new System.Windows.Forms.Button();
        	this.btnXemThuMucAnh = new System.Windows.Forms.Button();
        	this.panel3 = new System.Windows.Forms.Panel();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.panel1.SuspendLayout();
        	this.panel2.SuspendLayout();
        	this.panel3.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.btnError);
        	this.panel1.Controls.Add(this.btnTimKiem);
        	this.panel1.Controls.Add(this.chkChonBanDo);
        	this.panel1.Controls.Add(this.textBox3);
        	this.panel1.Controls.Add(this.textBox2);
        	this.panel1.Controls.Add(this.textBox1);
        	this.panel1.Controls.Add(this.label3);
        	this.panel1.Controls.Add(this.label2);
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        	this.panel1.Location = new System.Drawing.Point(0, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(751, 138);
        	this.panel1.TabIndex = 0;
        	// 
        	// btnError
        	// 
        	this.btnError.BackColor = System.Drawing.SystemColors.ControlDark;
        	this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnError.ForeColor = System.Drawing.Color.White;
        	this.btnError.Location = new System.Drawing.Point(711, 25);
        	this.btnError.Name = "btnError";
        	this.btnError.Size = new System.Drawing.Size(37, 23);
        	this.btnError.TabIndex = 42;
        	this.btnError.Text = "***";
        	this.btnError.UseVisualStyleBackColor = false;
        	this.btnError.Click += new System.EventHandler(this.BtnErrorClick);
        	// 
        	// btnTimKiem
        	// 
        	this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnTimKiem.Location = new System.Drawing.Point(126, 87);
        	this.btnTimKiem.Name = "btnTimKiem";
        	this.btnTimKiem.Size = new System.Drawing.Size(66, 24);
        	this.btnTimKiem.TabIndex = 40;
        	this.btnTimKiem.Text = "Tìm";
        	this.btnTimKiem.UseVisualStyleBackColor = true;
        	this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
        	// 
        	// chkChonBanDo
        	// 
        	this.chkChonBanDo.AutoSize = true;
        	this.chkChonBanDo.Checked = true;
        	this.chkChonBanDo.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.chkChonBanDo.Location = new System.Drawing.Point(498, 94);
        	this.chkChonBanDo.Name = "chkChonBanDo";
        	this.chkChonBanDo.Size = new System.Drawing.Size(150, 17);
        	this.chkChonBanDo.TabIndex = 38;
        	this.chkChonBanDo.Text = "Đã có bản đồ hành chính";
        	this.chkChonBanDo.UseVisualStyleBackColor = true;
        	this.chkChonBanDo.CheckedChanged += new System.EventHandler(this.chkChonBanDo_CheckedChanged);
        	// 
        	// textBox3
        	// 
        	this.textBox3.Location = new System.Drawing.Point(125, 55);
        	this.textBox3.Name = "textBox3";
        	this.textBox3.Size = new System.Drawing.Size(523, 20);
        	this.textBox3.TabIndex = 5;
        	// 
        	// textBox2
        	// 
        	this.textBox2.Location = new System.Drawing.Point(316, 28);
        	this.textBox2.Name = "textBox2";
        	this.textBox2.Size = new System.Drawing.Size(87, 20);
        	this.textBox2.TabIndex = 4;
        	// 
        	// textBox1
        	// 
        	this.textBox1.Location = new System.Drawing.Point(125, 28);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(91, 20);
        	this.textBox1.TabIndex = 3;
        	// 
        	// label3
        	// 
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(49, 58);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(100, 23);
        	this.label3.TabIndex = 2;
        	this.label3.Text = "Địa chỉ đất";
        	// 
        	// label2
        	// 
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(257, 31);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(100, 23);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "Số thửa";
        	// 
        	// label1
        	// 
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(49, 31);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(100, 23);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Tờ bản đồ";
        	// 
        	// panel2
        	// 
        	this.panel2.Controls.Add(this.btnTimQuyetDinh);
        	this.panel2.Controls.Add(this.cmbQuyetDinh);
        	this.panel2.Controls.Add(this.btnMoveFile);
        	this.panel2.Controls.Add(this.btnXemThuMucAnh);
        	this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.panel2.Location = new System.Drawing.Point(0, 385);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(751, 56);
        	this.panel2.TabIndex = 1;
        	// 
        	// btnTimQuyetDinh
        	// 
        	this.btnTimQuyetDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnTimQuyetDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnTimQuyetDinh.Location = new System.Drawing.Point(647, 17);
        	this.btnTimQuyetDinh.Name = "btnTimQuyetDinh";
        	this.btnTimQuyetDinh.Size = new System.Drawing.Size(101, 24);
        	this.btnTimQuyetDinh.TabIndex = 41;
        	this.btnTimQuyetDinh.Text = "Tìm quyết định";
        	this.btnTimQuyetDinh.UseVisualStyleBackColor = true;
        	this.btnTimQuyetDinh.Click += new System.EventHandler(this.BtnTimQuyetDinhClick);
        	// 
        	// cmbQuyetDinh
        	// 
        	this.cmbQuyetDinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        	this.cmbQuyetDinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        	this.cmbQuyetDinh.FormattingEnabled = true;
        	this.cmbQuyetDinh.Location = new System.Drawing.Point(558, 19);
        	this.cmbQuyetDinh.Name = "cmbQuyetDinh";
        	this.cmbQuyetDinh.Size = new System.Drawing.Size(82, 21);
        	this.cmbQuyetDinh.TabIndex = 2;
        	this.cmbQuyetDinh.SelectedIndexChanged += new System.EventHandler(this.CmbQuyetDinhSelectedIndexChanged);
        	// 
        	// btnMoveFile
        	// 
        	this.btnMoveFile.BackColor = System.Drawing.Color.Green;
        	this.btnMoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnMoveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnMoveFile.ForeColor = System.Drawing.Color.White;
        	this.btnMoveFile.Location = new System.Drawing.Point(107, 7);
        	this.btnMoveFile.Name = "btnMoveFile";
        	this.btnMoveFile.Size = new System.Drawing.Size(277, 37);
        	this.btnMoveFile.TabIndex = 1;
        	this.btnMoveFile.Text = "SAVE SCAN...";
        	this.btnMoveFile.UseVisualStyleBackColor = false;
        	this.btnMoveFile.Click += new System.EventHandler(this.btnMoveFile_Click);
        	// 
        	// btnXemThuMucAnh
        	// 
        	this.btnXemThuMucAnh.BackColor = System.Drawing.Color.Maroon;
        	this.btnXemThuMucAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnXemThuMucAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnXemThuMucAnh.ForeColor = System.Drawing.Color.White;
        	this.btnXemThuMucAnh.Location = new System.Drawing.Point(3, 7);
        	this.btnXemThuMucAnh.Name = "btnXemThuMucAnh";
        	this.btnXemThuMucAnh.Size = new System.Drawing.Size(106, 37);
        	this.btnXemThuMucAnh.TabIndex = 0;
        	this.btnXemThuMucAnh.Text = "Ảnh hồ sơ";
        	this.btnXemThuMucAnh.UseVisualStyleBackColor = false;
        	this.btnXemThuMucAnh.Click += new System.EventHandler(this.btnXemThuMucAnh_Click);
        	// 
        	// panel3
        	// 
        	this.panel3.Controls.Add(this.dataGridView1);
        	this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel3.Location = new System.Drawing.Point(0, 138);
        	this.panel3.Name = "panel3";
        	this.panel3.Size = new System.Drawing.Size(751, 247);
        	this.panel3.TabIndex = 2;
        	// 
        	// dataGridView1
        	// 
        	this.dataGridView1.AllowUserToAddRows = false;
        	this.dataGridView1.AllowUserToDeleteRows = false;
        	this.dataGridView1.AllowUserToResizeRows = false;
        	this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.dataGridView1.Location = new System.Drawing.Point(0, 0);
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
        	this.dataGridView1.Size = new System.Drawing.Size(751, 247);
        	this.dataGridView1.TabIndex = 0;
        	this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        	this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
        	// 
        	// frmTimKiem
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(751, 441);
        	this.Controls.Add(this.panel3);
        	this.Controls.Add(this.panel2);
        	this.Controls.Add(this.panel1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        	this.Name = "frmTimKiem";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Search...";
        	this.Load += new System.EventHandler(this.frmTimKiem_Load);
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.panel2.ResumeLayout(false);
        	this.panel3.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        internal System.Windows.Forms.CheckBox chkChonBanDo;
        private System.Windows.Forms.Button btnMoveFile;
        private System.Windows.Forms.Button btnXemThuMucAnh;
        private System.Windows.Forms.Button btnTimQuyetDinh;
        private System.Windows.Forms.ComboBox cmbQuyetDinh;
        private System.Windows.Forms.Button btnError;
    }
}