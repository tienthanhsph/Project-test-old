namespace CustomPanel
{
    partial class UCBottom1
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
            this.SuspendLayout();
            // 
            // Work
            // 
            this.Work.BackColor = System.Drawing.Color.DarkRed;
            this.Work.Dock = System.Windows.Forms.DockStyle.Top;
            this.Work.ForeColor = System.Drawing.Color.White;
            this.Work.Location = new System.Drawing.Point(0, 0);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(150, 13);
            this.Work.TabIndex = 1;
            this.Work.Text = "Bottom1";
            this.Work.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UCBottom1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Work);
            this.Name = "UCBottom1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Work;
    }
}
