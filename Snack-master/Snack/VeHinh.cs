using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snack
{
    class VeHinh
    {
        public VeHinh(Graphics g, int x, int y, int tyle, string mauVien, string mauNen, string mauPanel, bool xoa = false)
        {

            
            Pen pen = new Pen(Color.FromName(mauVien));
            SolidBrush brush = new SolidBrush(Color.FromName(mauNen));

            Pen penXoa = new Pen(Color.FromName(mauPanel));
            SolidBrush brushXoa = new SolidBrush(Color.FromName(mauPanel));

            Rectangle rec = new Rectangle(x * tyle, y * tyle, tyle, tyle);
            
            if (xoa == false)
            {
                g.DrawRectangle(pen, rec);
                g.FillRectangle(brush, rec);
            }
            else
            {
                g.DrawRectangle(penXoa, rec);
                g.FillRectangle(brushXoa, rec);
            }

        }
        public VeHinh(Graphics g,int x, int y, int tyle, bool xoa)
        {
            try
            {
                string mauVien = "Red";
                string mauNen = "Lime";
                string mauPanel = "White";
                Color _vien = Color.FromName(mauVien);
                Pen pen = new Pen(_vien);
                SolidBrush brush = new SolidBrush(Color.FromName(mauNen));

                Pen penXoa = new Pen(Color.FromName(mauPanel));
                SolidBrush brushXoa = new SolidBrush(Color.FromName(mauPanel));

                Rectangle rec = new Rectangle(x * tyle, y * tyle, tyle, tyle);

                if (xoa == false)
                {
                    g.DrawRectangle(pen, rec);
                    g.FillRectangle(brush, rec);
                }
                else
                {
                    g.DrawRectangle(penXoa, rec);
                    g.FillRectangle(brushXoa, rec);
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
