using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ShowInfo
{
    public enum Huong { Len, Xuong, Trai, Phai, Khong}
    class Nguoi
    {
        public Nguoi()
        {
            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            DiChuyen();
        }
        private Point toado;
        public Point ToaDo{
            get { return toado; }
            set { toado = value; }
        }
        private Image anh;
        public Image Anh
        {
            get { return anh; }
            set { anh = value; }
        }
        private Huong huongdc;
        public Huong HuongDC
        {
            get { return huongdc; }
            set { huongdc = value; }
        }
        void DiChuyen()
        {
            switch (huongdc){
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
                    toado.Y+= 1;
                    break;
            }
        }
        private Timer tmr;
        private int tanghientai;

        public int TangHienTai
        {
            get { return tanghientai; }
            set { tanghientai = value; }
        }

        private int tangcanden;

        public int TangCanDen
        {
            get { return tangcanden; }
            set { tangcanden = value; }
        }
        private ThangMay thang;

        internal ThangMay Thang
        {
            get { return thang; }
            set { thang = value; }
        }
        public void Go()
        {
            tmr.Start();
        }
        public void Stand()
        {
            tmr.Stop();
        }
        //public Timer Tmr
        //{
        //    get { return tmr; }
        //    set
        //    {
        //        tmr = value;
        //    }
        //}
    }
}
