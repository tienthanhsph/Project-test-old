namespace AlarmClock
{
    partial class ThoiGian
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
            this.numericUpDownGio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPhut = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhut)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownGio
            // 
            this.numericUpDownGio.Location = new System.Drawing.Point(12, 28);
            this.numericUpDownGio.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownGio.Name = "numericUpDownGio";
            this.numericUpDownGio.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownGio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giờ";
            // 
            // numericUpDownPhut
            // 
            this.numericUpDownPhut.Location = new System.Drawing.Point(80, 28);
            this.numericUpDownPhut.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownPhut.Name = "numericUpDownPhut";
            this.numericUpDownPhut.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownPhut.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phút";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(31, 56);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 91);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownPhut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownGio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThoiGian";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThoiGian";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownGio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPhut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
    }
}