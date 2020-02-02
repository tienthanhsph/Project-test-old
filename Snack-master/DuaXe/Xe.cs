using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace DuaXe
{
    class Xe
    {           
        public int LoaiXe;
        public int W;
        public int H;
        public Point ViTri;
        public Graphics g;
        public int TocDo=10;
        public Xe()
        {

        }
        public Xe(int LoaiXe)   // danh cho nhung xe lam vat can tren duong
        {                      
            this.LoaiXe = LoaiXe;
            this.W = 60;
            this.H = 120;
            Random rd = new Random();
            this.ViTri.X = rd.Next(0,3)*this.W;
            this.ViTri.Y = 0;
            
        }
        public Xe(int LoaiXe, Point ViTri, int W, int H)      // dung de ve xe cua minh
        {
            this.LoaiXe = LoaiXe;
            this.ViTri = ViTri;
            this.W = W;
            this.H = H;
           
        }
        public void VeXe(bool ve)
        {
            try
            {
                Ve vexe = new Ve();
                vexe.draw(this.g, this.ViTri, this.W, this.H, this.LoaiXe, ve);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("VeXe: \n"+ex.Message);
            }
            
        }
        public void ChuyenDong()
        {
            VeXe(false);
            this.ViTri.Y += this.TocDo;
            VeXe(true);
        }

    }
}
