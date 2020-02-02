using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            flag = 1;
            clsStatic.TrangThaiChucNang(panel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag != 0)
            {
                clsStatic.Flag = this.flag;
                clsStatic.TrangThaiKetThuc(panel1);
                this.flag = 0;
            }
            else {
                MessageBox.Show("khong co hanh dong nao duoc thuc hien!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsStatic.TrangThaiBanDau(panel1);
            
            panel2.Controls.Add(b);
            b.Location = new Point(0, 0);
        }


        bee b = new bee();

        int d,k,h = 0;
        int i = 0;

        int x, y, x0, y0, x1, y1 = 0;

        private Point GetPoint()
        {
            if (i <= h)
            {
                i += 2;
                x = x0 + (int)(i * k / h);
                y = y0 + (int)(i * d / h);

                return new Point(x, y);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Win!");
                return new Point(0,0);
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            b.Location = GetPoint();
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            


            timer1.Stop();
            x0 = b.Location.X;
            y0 = b.Location.Y;

            x1 = e.X;
            y1 = e.Y;

            k = (x1 - x0);
            d = (y1 - y0);
            if (k > 0)
                b.BackgroundImage = Properties.Resources.bee_right;
            else
                b.BackgroundImage = Properties.Resources.bee_left;

            h = (int)(Math.Sqrt(Math.Pow(k, 2) + Math.Pow(d, 2)));
            i = 0;

            
            timer1.Start();
            
        }
    }
}
