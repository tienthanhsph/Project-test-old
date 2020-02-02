namespace ThangMayHoatDong
{
    partial class frmHoatDong
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
            this.components = new System.ComponentModel.Container();
            this.pnlThangMay = new System.Windows.Forms.Panel();
            this.grpBangDieuKhien = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tmrRealTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlThangMay
            // 
            this.pnlThangMay.BackColor = System.Drawing.Color.Silver;
            this.pnlThangMay.Location = new System.Drawing.Point(581, 12);
            this.pnlThangMay.Name = "pnlThangMay";
            this.pnlThangMay.Size = new System.Drawing.Size(95, 629);
            this.pnlThangMay.TabIndex = 0;
            // 
            // grpBangDieuKhien
            // 
            this.grpBangDieuKhien.Location = new System.Drawing.Point(454, 466);
            this.grpBangDieuKhien.Name = "grpBangDieuKhien";
            this.grpBangDieuKhien.Size = new System.Drawing.Size(121, 175);
            this.grpBangDieuKhien.TabIndex = 1;
            this.grpBangDieuKhien.TabStop = false;
            this.grpBangDieuKhien.Text = "Control IN";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(698, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control OUT";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 321);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng thái";
            // 
            // frmHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBangDieuKhien);
            this.Controls.Add(this.pnlThangMay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHoatDong";
            this.Text = "Hoạt động";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThangMay;
        private System.Windows.Forms.GroupBox grpBangDieuKhien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer tmrRealTime;
    }
}

