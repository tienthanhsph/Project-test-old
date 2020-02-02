using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuaXe
{
    public partial class frmDuaXe : Form
    {
        public frmDuaXe()
        {
            InitializeComponent();
        }
        int SinhXe = 0;
        Xe xecuatui;
        Xe xemoi;
        int diemso = 0;
        List<Xe> doixe = new List<Xe>();
        int tocdo = 3;
        Graphics g;
        Graphics g2;
        System.Timers.Timer timer = new System.Timers.Timer();

        private void frmDuaXe_Load(object sender, EventArgs e)
        {
           timer.Elapsed += timer_Elapsed;
            g2 = this.panel1.CreateGraphics();
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            SinhXe++;
            if (SinhXe == ((xecuatui.H / tocdo) * 2))
            {
                xemoi = new Xe(2);
                xemoi.g = g2;
                xemoi.VeXe(true);
                doixe.Add(xemoi);
                SinhXe = 0;
            }
            for (int i = 0; i < doixe.Count; i++)
            {

                doixe[i].ChuyenDong();
                if (doixe[i].ViTri.Y > this.panel1.Height)
                {
                    doixe[i].VeXe(false);
                    doixe.RemoveAt(i);
                    diemso++;
                    //TinhDiem();

                }
                KiemTraVaCham(doixe[i]);
            }
            
        }
        private void TinhDiem()
        {
            label1.Text = "Điểm số : " + diemso.ToString();
            textBox1.Text = diemso.ToString();
        }
        private void KiemTraVaCham(Xe xe)
        {
            if (xe.ViTri.X > (xecuatui.ViTri.X - xecuatui.W) && xe.ViTri.X < (xecuatui.ViTri.X + xecuatui.W) && xe.ViTri.Y > (xecuatui.ViTri.Y - xecuatui.H) && xe.ViTri.Y < (xecuatui.ViTri.Y + xecuatui.H))
            {
                timer.Stop();
                MessageBox.Show("Tai nạn rồi!");
            }
        }
        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            g = this.panel1.CreateGraphics();

            #region "VeXeCuaTui"
            xecuatui = new Xe();
            xecuatui.LoaiXe = 1;
            xecuatui.W = 60;
            xecuatui.H = 120;
            Point vitrixecuatui = new Point(this.panel1.Width - xecuatui.W, this.panel1.Height - xecuatui.H);
            xecuatui.ViTri = vitrixecuatui;
            xecuatui.g = g;
            xecuatui.VeXe(true);
            #endregion 
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            tocdo = 10;
            timer.Interval = 50;
            timer.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            switch (keyData)
            {
                case Keys.Left:
                    {
                        if (xecuatui.ViTri.X > 0)
                        {
                            xecuatui.VeXe(false);
                            xecuatui.ViTri.X -= xecuatui.W;
                            xecuatui.VeXe(true);
                        }
                        bHandled = true;
                        break;
                    }
                case Keys.Right:
                    {
                        if (xecuatui.ViTri.X < this.panel1.Width - xecuatui.W)
                        {
                            xecuatui.VeXe(false);
                            xecuatui.ViTri.X += xecuatui.W;
                            xecuatui.VeXe(true);
                        }
                        bHandled = true;
                        break;
                    }
                case Keys.Up:
                    {
                        if (xecuatui.ViTri.Y > 0)
                        {
                            xecuatui.VeXe(false);
                            xecuatui.ViTri.Y -= tocdo;
                            xecuatui.VeXe(true);
                        }
                        bHandled = true;
                        break;
                    }
                case Keys.Down:
                    {
                        if (xecuatui.ViTri.Y < this.panel1.Height - xecuatui.H)
                        {
                            xecuatui.VeXe(false);
                            xecuatui.ViTri.Y += tocdo;
                            xecuatui.VeXe(true);
                        }
                        bHandled = true;
                        break;
                    }
            }
            return bHandled;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            SinhXe++;
            if (SinhXe == ((xecuatui.H /tocdo) * 2))
            {
                xemoi = new Xe(2);
                xemoi.g = g2;
                xemoi.VeXe(true);
                xemoi.TocDo = tocdo;
                doixe.Add(xemoi);
                SinhXe = 0;
            }
            if (doixe.Count > 0)
            {
                for (int i =0;i< doixe.Count;i++)
                {
                   
                    doixe[i].ChuyenDong();
                    if (doixe[i].ViTri.Y  > this.panel1.Height)
                    {
                        doixe[i].VeXe(false);
                        doixe.RemoveAt(i);                        
                        diemso++;
                        TinhDiem();

                    }
                    KiemTraVaCham(doixe[i]);
                }
                
            }
            
        }
        Xe xemoi1;
        private void btnMotXe_Click(object sender, EventArgs e)
        {
            tocdo = 1;
            timer2.Interval = 30;
            xemoi1 = new Xe(2);
            xemoi1.g = g2;
            xemoi1.VeXe(true);
            xemoi1.TocDo = tocdo;
            timer2.Start();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            xemoi1.ChuyenDong();
        }
        
    }
}
