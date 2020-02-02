namespace BaoCaoDong
{
    partial class QuanLyThongSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyThongSo));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnCbBox = new System.Windows.Forms.Button();
            this.btnGanKieu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.28213F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.71787F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 194);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnHide);
            this.panel2.Controls.Add(this.btnCbBox);
            this.panel2.Controls.Add(this.btnGanKieu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 188);
            this.panel2.TabIndex = 3;
            // 
            // btnHide
            // 
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Location = new System.Drawing.Point(34, 81);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(193, 23);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Ẩn hiện các cột";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnCbBox
            // 
            this.btnCbBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCbBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCbBox.Location = new System.Drawing.Point(34, 52);
            this.btnCbBox.Name = "btnCbBox";
            this.btnCbBox.Size = new System.Drawing.Size(193, 23);
            this.btnCbBox.TabIndex = 1;
            this.btnCbBox.Text = "Gán Items cho các ComboBox";
            this.btnCbBox.UseVisualStyleBackColor = true;
            this.btnCbBox.Click += new System.EventHandler(this.btnCbBox_Click);
            // 
            // btnGanKieu
            // 
            this.btnGanKieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGanKieu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanKieu.Location = new System.Drawing.Point(34, 23);
            this.btnGanKieu.Name = "btnGanKieu";
            this.btnGanKieu.Size = new System.Drawing.Size(193, 23);
            this.btnGanKieu.TabIndex = 0;
            this.btnGanKieu.Text = "Gán kiểu tìm kiếm cho cột";
            this.btnGanKieu.UseVisualStyleBackColor = true;
            this.btnGanKieu.Click += new System.EventHandler(this.btnGanKieu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblRefresh);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(259, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 188);
            this.panel1.TabIndex = 4;
            // 
            // lblRefresh
            // 
            this.lblRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRefresh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefresh.Location = new System.Drawing.Point(21, 9);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(336, 53);
            this.lblRefresh.TabIndex = 1;
            this.lblRefresh.Text = "Làm  mới lại thông tin \\n Bạn sẽ phải đợi một vài phút.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // QuanLyThongSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 194);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLyThongSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom";
            this.Load += new System.EventHandler(this.QuanLyThongSo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCbBox;
        private System.Windows.Forms.Button btnGanKieu;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}