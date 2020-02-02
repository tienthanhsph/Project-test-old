namespace Combobox
{
    partial class frmDemoComboxBox
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
            this.comboBoxNhanVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbThongTin = new System.Windows.Forms.Label();
            this.lbThongTinNV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxNhanVien
            // 
            this.comboBoxNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNhanVien.FormattingEnabled = true;
            this.comboBoxNhanVien.Location = new System.Drawing.Point(119, 9);
            this.comboBoxNhanVien.Name = "comboBoxNhanVien";
            this.comboBoxNhanVien.Size = new System.Drawing.Size(170, 32);
            this.comboBoxNhanVien.TabIndex = 0;
            this.comboBoxNhanVien.SelectedIndexChanged += new System.EventHandler(this.comboBoxNhanVien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân viên:";
            // 
            // lbThongTin
            // 
            this.lbThongTin.AutoSize = true;
            this.lbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTin.Location = new System.Drawing.Point(3, 54);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(74, 20);
            this.lbThongTin.TabIndex = 1;
            this.lbThongTin.Text = "Chức vụ: ";
            // 
            // lbThongTinNV
            // 
            this.lbThongTinNV.AutoSize = true;
            this.lbThongTinNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinNV.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbThongTinNV.Location = new System.Drawing.Point(104, 54);
            this.lbThongTinNV.Name = "lbThongTinNV";
            this.lbThongTinNV.Size = new System.Drawing.Size(0, 20);
            this.lbThongTinNV.TabIndex = 2;
            // 
            // frmDemoComboxBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 103);
            this.Controls.Add(this.lbThongTinNV);
            this.Controls.Add(this.lbThongTin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNhanVien);
            this.Name = "frmDemoComboxBox";
            this.Text = "Demo ComboBox";
            this.Load += new System.EventHandler(this.frmDemoComboxBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbThongTin;
        private System.Windows.Forms.Label lbThongTinNV;
    }
}

