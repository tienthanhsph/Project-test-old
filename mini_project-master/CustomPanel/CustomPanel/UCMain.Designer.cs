namespace CustomPanel
{
    partial class UCMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Work = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Work
            // 
            this.Work.BackColor = System.Drawing.Color.DarkRed;
            this.Work.Dock = System.Windows.Forms.DockStyle.Top;
            this.Work.ForeColor = System.Drawing.Color.White;
            this.Work.Location = new System.Drawing.Point(0, 0);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(406, 13);
            this.Work.TabIndex = 0;
            this.Work.Text = "Main";
            this.Work.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "ThongTinThem",
            "Status",
            "ThongTinThem+Status",
            "ThongTinThem+Status+"});
            this.comboBox1.Location = new System.Drawing.Point(40, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Work);
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(406, 254);
            this.Load += new System.EventHandler(this.UCMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Work;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
