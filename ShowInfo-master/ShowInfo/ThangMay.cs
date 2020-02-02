using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;


namespace ShowInfo
{
    class ThangMay
    {
        private Tang dangotang;

        internal Tang DangOTang
        {
            get { return dangotang; }
            set { dangotang = value; }
        }

        private Tang didentang;

        internal Tang DiDenTang
        {
            get { return didentang; }
            set { didentang = value; }
        }

        private Huong huongdc;
        public Huong HuongDC
        {
            get { return huongdc; }
            set { huongdc = value; }
        }

        private Point toado;
        public Point ToaDo
        {
            get { return toado; }
            set { toado = value; }
        }
        private Nguoi[] nguoibentrong;
        private Timer tmr;
        public ThangMay()
        {
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            DiChuyen();
        }
        void DiChuyen()
        {
            switch (huongdc)
            {
                case Huong.Trai:
                    toado.X -= 1;
                    break;
                case Huong.Phai:
                    toado.X += 1;
                    break;
                case Huong.Len:
                    toado.Y -= 1;
                    break;
                case Huong.Xuong:
                    toado.Y += 1;
                    break;
            }
        }
    }
}
