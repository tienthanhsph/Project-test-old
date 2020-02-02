using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;

namespace Snack
{
    class Snack
    {
        private int xDau;
        private int yDau;
        private Queue<Point> xuongsong = new Queue<Point>();
        private int tyle;
        public Graphics g;
        public DiChuyen dichuyen =  DiChuyen.Phai;
        public string mauVien="Red";
        public string mauNen = "Lime";
        public string mauPanel;
        public string mauDau="Red";

        public int XDau 
        { 
            get { return xDau;}
            set { xDau = value; }
        }
        public int YDau
        {
            get { return yDau; }
            set { yDau = value; }
        }
        public Queue<Point> XuongSong
        {
            get { return xuongsong; }
            set { xuongsong = value; }
        }
        public int TyLe
        {
            get { return tyle; }
            set { tyle = value; }
        }
        public Snack()
        {
            xDau = 2;
            yDau = 2;
            xuongsong.Enqueue(new Point(xDau-1,yDau));              
            tyle = 50;
            //thoigian.Elapsed += thoigian_Elapsed;
        }

        //void thoigian_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    try
        //    {
                
        //        Move(dichuyen,false);

        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //}
        public Snack(int xdau, int ydau, int tyle, Queue<Point> xuongsong)
        {
            this.xDau = xdau;
            this.yDau = ydau;
            this.tyle = tyle;
            this.xuongsong = xuongsong;
            
           // thoigian.Elapsed += thoigian_Elapsed;
        }

        public void VeRan(bool xoa)
        { 
        //ve dau
            VeHinh vedau = new VeHinh(this.g, this.xDau, this.yDau, this.tyle, this.mauDau, this.mauDau, this.mauPanel, xoa);
        //ve than
            foreach (Point dotsong in xuongsong)
            {
                VeHinh vedotsong = new VeHinh(this.g, dotsong.X, dotsong.Y, this.tyle,this.mauVien,this.mauNen,this.mauPanel, xoa);
            }
        }
        public void Move(DiChuyen dc, bool LonLen)
        {
            VeRan(true);
            switch (dc)
            { 
                case DiChuyen.Len:
                {
                    //xuongsong.Dequeue();
                    xuongsong.Enqueue(new Point(xDau, yDau));
                    yDau -= 1;
                    break;
                }
                case DiChuyen.Xuong:
                {
                    //xuongsong.Dequeue();
                    xuongsong.Enqueue(new Point(xDau,yDau));
                    yDau += 1;
                    break;
                }
                case DiChuyen.Trai:
                {
                    //xuongsong.Dequeue();
                    xuongsong.Enqueue(new Point(xDau, yDau));
                    xDau -= 1;
                    break;
                }
                case DiChuyen.Phai:
                {
                    //xuongsong.Dequeue();
                    xuongsong.Enqueue(new Point(xDau, yDau));
                    xDau += 1;
                    break;
                }
            }
            if (LonLen == false)
            {
                xuongsong.Dequeue();
            }
            VeRan(false);
        }

        //public Timer thoigian = new Timer();
        public void LonLen()
        {
            Point Duoi = this.xuongsong.Last<Point>();

        }
    }
}
