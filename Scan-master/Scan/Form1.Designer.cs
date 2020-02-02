namespace Scan
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
        	this.btnOK = new System.Windows.Forms.Button();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.btnSetup = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// btnOK
        	// 
        	this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnOK.ForeColor = System.Drawing.Color.White;
        	this.btnOK.Location = new System.Drawing.Point(145, 103);
        	this.btnOK.Name = "btnOK";
        	this.btnOK.Size = new System.Drawing.Size(71, 23);
        	this.btnOK.TabIndex = 0;
        	this.btnOK.Text = "Begin";
        	this.btnOK.UseVisualStyleBackColor = true;
        	this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.FormattingEnabled = true;
        	this.comboBox1.Location = new System.Drawing.Point(115, 51);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(129, 21);
        	this.comboBox1.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.ForeColor = System.Drawing.Color.White;
        	this.label1.Location = new System.Drawing.Point(57, 54);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(52, 13);
        	this.label1.TabIndex = 2;
        	this.label1.Text = "Chọn xã :";
        	// 
        	// btnSetup
        	// 
        	this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnSetup.Location = new System.Drawing.Point(280, 174);
        	this.btnSetup.Name = "btnSetup";
        	this.btnSetup.Size = new System.Drawing.Size(31, 14);
        	this.btnSetup.TabIndex = 3;
        	this.btnSetup.Text = "...";
        	this.btnSetup.UseVisualStyleBackColor = true;
        	this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.Maroon;
        	this.ClientSize = new System.Drawing.Size(321, 200);
        	this.Controls.Add(this.btnSetup);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.comboBox1);
        	this.Controls.Add(this.btnOK);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        	this.Name = "Form1";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Load += new System.EventHandler(this.Form1_Load);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetup;
    }
}

