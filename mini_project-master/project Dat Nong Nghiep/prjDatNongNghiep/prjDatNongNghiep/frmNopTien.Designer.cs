namespace prjDatNongNghiep
{
    partial class frmNopTien
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
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnThue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(181, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 14);
            this.label18.TabIndex = 37;
            this.label18.Text = "(VNĐ)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(39, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 14);
            this.label19.TabIndex = 35;
            this.label19.Text = "Tiền nộp";
            // 
            // btnThue
            // 
            this.btnThue.Location = new System.Drawing.Point(93, 70);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(63, 24);
            this.btnThue.TabIndex = 34;
            this.btnThue.Text = "Đồng ý";
            this.btnThue.UseVisualStyleBackColor = true;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // frmNopTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 106);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnThue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNopTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nộp tiền";
            this.Load += new System.EventHandler(this.frmNopTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnThue;
    }
}