using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Snack
{
   
    public partial class frm : Form
    {
         
        public frm()
        {
            InitializeComponent();
        }
        Snack snack;
        ThucAn thucan;
       
        Graphics g;
        
        private void btnRun_Click(object sender, EventArgs e)
        {
            
            thoigian.Start();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            thoigian.Elapsed += thoigian_Elapsed;
            g = this.panel1.CreateGraphics();   
        }
        private void KhoiTao()
        {                
            snack= new Snack();
            snack.TyLe = 20;
            snack.g = g;
            snack.mauPanel = this.panel1.BackColor.Name.ToString();
            
            snack.VeRan(false);    
            TaoThucAn();
        }
        private void TaoThucAn()
        {             
            thucan = new ThucAn();              
            thucan.TyLe = snack.TyLe;
            Random rnd = new Random();
            int x =rnd.Next( (int)(this.panel1.Width / thucan.TyLe));
            int y = rnd.Next((int)(this.panel1.Height / thucan.TyLe));
            thucan.X = x;
            thucan.Y = y;   
            thucan.g = g;
            thucan.VeThucAn(false);
        }
        private void btnBegin_Click(object sender, EventArgs e)
        {
            LamSach();
            KhoiTao();
        }
        private void LamSach()
        {
            snack = null;
            thucan = null;
            g.Clear(Color.FromName(this.panel1.BackColor.Name.ToString()));
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            thoigian.Stop();
        }
        #region "VoDung"
        //private void frm_KeyDown(object sender, KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Up:
        //            {
        //                snack.dichuyen = DiChuyen.Len;
        //                break;
        //            }
        //        case Keys.Down:
        //            {
        //                snack.dichuyen = DiChuyen.Xuong;
        //                break;
        //            }
        //        case Keys.Left:
        //            {
        //                snack.dichuyen = DiChuyen.Trai;
        //                break;
        //            }
        //        case Keys.Right:
        //            {
        //                snack.dichuyen = DiChuyen.Phai;
        //                break;
        //            }

        //    }
        //}
        #endregion
        Keys UsingKey;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            switch (keyData)
            {
                case Keys.Right:
                    {
                        if (UsingKey != Keys.Left)
                        {
                            snack.dichuyen = DiChuyen.Phai;                                                          
                            UsingKey = Keys.Right;
                        }
                        bHandled = true;  
                        break;
                    }
                    
                case Keys.Left:
                    {
                        if (UsingKey != Keys.Right)
                        {
                            snack.dichuyen = DiChuyen.Trai;                             
                            UsingKey = Keys.Left;
                        }
                        bHandled = true;
                        break;
                    }
                    
                case Keys.Up:
                    {
                        if (UsingKey != Keys.Down)
                        {
                            snack.dichuyen = DiChuyen.Len;
                            UsingKey = Keys.Up;
                        }
                        bHandled = true;
                        break;
                    }
                    
                case Keys.Down:
                    {
                        if (UsingKey != Keys.Up)
                        {
                            snack.dichuyen = DiChuyen.Xuong;
                            UsingKey = Keys.Down;
                        }
                        bHandled = true;
                        break;
                    }
                   
            }
            return bHandled;
        }
        System.Timers.Timer thoigian = new System.Timers.Timer();
        void thoigian_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (snack.XDau == thucan.X && snack.YDau == thucan.Y)
                {
                    snack.Move(snack.dichuyen, true);
                    TaoThucAn();
                }
                else
                {
                    snack.Move(snack.dichuyen, false);
                }
                if (KiemTra() == false)
                    end();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void end()
        {
            thoigian.Stop();
            MessageBox.Show("Con rắn đâm phải tường!");
        }
        private bool KiemTra()
        {
            if ((snack.XDau+1) * snack.TyLe > this.panel1.Width || (snack.YDau+1) * snack.TyLe > this.panel1.Height || snack.XDau * snack.TyLe<0 || snack.YDau * snack.TyLe<0)
            {
                return false;
            }
            return true;
        }
        
    }
}
