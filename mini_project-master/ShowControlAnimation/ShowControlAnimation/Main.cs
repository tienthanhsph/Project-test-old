using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowControlAnimation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        UC1 uc1 = new UC1();
        UC2 uc2 = new UC2();
        UC3 uc3 = new UC3();
        UC4 uc4 = new UC4();
        UC5 uc5 = new UC5();

        int i = 0;
        int k = 80;
        int status = 0;
        bool _flag_check = true;
        int Animation = 0;
        
        private void ShowControl(Control ctrl)
        {
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(ctrl);
        }
        private void ResizeControl(Control ctrl, Size size)
        {
            ctrl.Size = size;
        }
        private void ReLocateControl(Control ctrl, Point point)
        {
            ctrl.Location = point;
        }
        private void ResizeAndLocateControl(Control ctrl, Size size, Point point)
        {
            ctrl.Size = size;
            ctrl.Location = point;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            ShowControl(uc1);
            ResizeControl(uc1, PnlMain.Size);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowControl(uc2);
            ResizeControl(uc2, PnlMain.Size);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowControl(uc3);
            ResizeControl(uc3, PnlMain.Size);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowControl(uc4);
            ResizeControl(uc4, PnlMain.Size);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowControl(uc5);
            ResizeControl(uc5, PnlMain.Size);
        }

        private void CheckboxChecked(object sender, EventArgs e)
        {
            if (_flag_check == false)
                return;
            if (((CheckBox)sender).Checked == true)
            {
                status++;
                if (status == 0)
                {
                    ShowControl(uc1);
                   
                }
                else if (status == 1)
                {
                    ShowControl(uc2);
                   
                }
                else if (status == 2)
                {
                    ShowControl(uc3);
                   
                }
                else if (status == 3)
                {
                    ShowControl(uc4);
                   
                }
                else if (status == 4)
                {
                    ShowControl(uc5);
                   
                }
                else if (status == 5)
                {
                    MessageBox.Show("All Done!");
                }

                if (Animation == 0)
                    tmrShowPanel.Start();
                else if (Animation == 1)
                    tmrReLocatePanel.Start();
                else if (Animation == 2)
                    tmrResizeAndLocatePanel.Start();
                ActiveControl();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            uc1.ChckDone.CheckedChanged += CheckboxChecked;
            uc2.ChckDone.CheckedChanged += CheckboxChecked;
            uc3.ChckDone.CheckedChanged += CheckboxChecked;
            uc4.ChckDone.CheckedChanged += CheckboxChecked;
            uc5.ChckDone.CheckedChanged += CheckboxChecked;

            Reload();
            
        }

        private void Reload()
        {
            _flag_check = false;
            uc1.ChckDone.Enabled = uc2.ChckDone.Enabled = uc3.ChckDone.Enabled = uc4.ChckDone.Enabled = uc5.ChckDone.Enabled = true;
            uc1.ChckDone.Checked = uc2.ChckDone.Checked = uc3.ChckDone.Checked = uc4.ChckDone.Checked = uc5.ChckDone.Checked = false;
            _flag_check = true;

            ActiveControl();
            ShowControl(uc1);
            uc1.Size = PnlMain.Size;
        }
        Open open = new Open();
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.ShowDialog();
            this.status = open.Status;
            this.Animation = open.Animation;
            Reload();
        }
        private void ActiveControl()
        {
            _flag_check = false;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = false;
            if (status >= 0)
            {
                button1.Enabled = true;
            }
            if (status > 0)
            {
                button2.Enabled = true;
                uc1.ChckDone.Checked = true;
            }
            if (status > 1)
            {
                button3.Enabled = true;
                uc2.ChckDone.Checked = true;
            }
            if (status > 2)
            {
                button4.Enabled = true;
                uc3.ChckDone.Checked = true;
            }
            if (status > 3)
            {
                button5.Enabled = true;
                uc4.ChckDone.Checked = true;
            }
            if (status > 4)
            {                
                uc5.ChckDone.Checked = true;
            }
            _flag_check = true;
        }

        private void tmrShowPanel_Tick(object sender, EventArgs e)
        {
            Control ctrl = this.PnlMain.Controls[0];
            Size newSize;
            if (i < 20)
            {
                if (i * k > PnlMain.Width || i * k > PnlMain.Height)
                {
                    newSize = PnlMain.Size;
                    ResizeControl(ctrl, newSize);
                    tmrShowPanel.Stop();
                    i = 0;
                }
                else
                {
                    newSize = new Size(i * k, i * k);
                    ResizeControl(ctrl, newSize);
                    i++;
                }
            }
            else
            {
                tmrShowPanel.Stop();
                i = 0;
            }
        }

        private void tmrReLocatePanel_Tick(object sender, EventArgs e)
        {
            Control ctrl = this.PnlMain.Controls[0];
            ctrl.Size = PnlMain.Size;
            Point newPoint;
            if (i <= 90)
            {
               
                double x= 500*( Math.Cos(i*Math.PI/180));
                double y= 500*(1-( Math.Sin(i*Math.PI/180)));
                newPoint = new Point((int)x, (int)y);
                ReLocateControl(ctrl, newPoint);
                i+=10;
            }
            else
            {
                tmrReLocatePanel.Stop();
                i = 0;
            }

        }

        private void tmrResizeAndLocatePanel_Tick(object sender, EventArgs e)
        {
            Control ctrl = this.PnlMain.Controls[0];            
            Point newPoint;
            Size newSize;
            int _k = 3;
            if (i <= 90)
            {

                double x = 500 * (Math.Cos(i * Math.PI / 180));
                double y = 500 * (1 - (Math.Sin(i * Math.PI / 180)));
                newPoint = new Point((int)x, (int)y);

                if (i * _k > PnlMain.Width || i * _k > PnlMain.Height)
                {
                    newSize = PnlMain.Size;
                }
                else
                {
                    newSize = new Size(i * _k, i * _k);
                    
                }

                ResizeAndLocateControl(ctrl, newSize, newPoint);
                i += 5;
            }
            else
            {
                ctrl.Size = PnlMain.Size;
                tmrResizeAndLocatePanel.Stop();
                i = 0;
            }
        }

        
    }
}
