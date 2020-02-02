using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snack
{
    class ThucAn
    {
        public int X;
        public int Y;
        public int TyLe;
        public Graphics g;
        public ThucAn()
        {
           // Random rdm = new Random();
           // int x = rdm.Next(X);
           // int y = rdm.Next(Y);
           //VeHinh veThucAn = new VeHinh(g, x, y, TyLe, "Red", "Red", "White", false);
        }
        public void VeThucAn(bool xoa)
        {
            //Random rdm = new Random();
            //int x = rdm.Next(X);
            //int y = rdm.Next(Y);
            VeHinh veThucAn = new VeHinh(g, X, Y, TyLe, xoa);
        }
    }
}
