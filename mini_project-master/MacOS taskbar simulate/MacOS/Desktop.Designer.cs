namespace MacOS
{
    partial class Desktop
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
            this.Menu = new System.Windows.Forms.Panel();
            this.Screen = new System.Windows.Forms.Panel();
            this.Taskbar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.DimGray;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(783, 24);
            this.Menu.TabIndex = 0;
            // 
            // Screen
            // 
            this.Screen.BackgroundImage = global::MacOS.Properties.Resources.Screen;
            this.Screen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Location = new System.Drawing.Point(0, 24);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(783, 451);
            this.Screen.TabIndex = 2;
            // 
            // Taskbar
            // 
            this.Taskbar.BackgroundImage = global::MacOS.Properties.Resources.bottom;
            this.Taskbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Taskbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Taskbar.Location = new System.Drawing.Point(0, 475);
            this.Taskbar.Name = "Taskbar";
            this.Taskbar.Size = new System.Drawing.Size(783, 60);
            this.Taskbar.TabIndex = 1;
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 535);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.Taskbar);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Desktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel Taskbar;
        private System.Windows.Forms.Panel Screen;
    }
}

