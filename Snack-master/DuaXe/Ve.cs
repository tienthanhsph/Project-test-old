using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuaXe
{
    class Ve
    {
        public Ve() { }
        public void draw(Graphics g, Point point, int W, int H,int loaixe, bool ve) 
        {
            try
            {
                Rectangle rec = new Rectangle(point.X, point.Y, W, H);
                Image anhXe;
                if (ve == true)
                {
                    if (loaixe == 1)
                    {
                        anhXe = Image.FromFile("Car1.png");
                        g.DrawImage(anhXe, rec);
                    }
                    else 
                    {
                        anhXe = Image.FromFile("Car2.png");
                        g.DrawImage(anhXe, rec);
                    }
                }
                else
                {
                    SolidBrush brush = new SolidBrush(Color.White);
                    g.FillRectangle(brush, rec);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Draw: \n" + ex.Message);
            }
            
        }
    }
}
