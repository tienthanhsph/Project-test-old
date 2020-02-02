using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextStep
{
    public partial class Main : Form
    {
        bool flag = true;
        public Main()
        {
            InitializeComponent();
        }
        private void Reload()
        {

            ctrl1.chckDone.Enabled = ctrl2.chckDone.Enabled = ctrl3.chckDone.Enabled = ctrl4.chckDone.Enabled = ctrl5.chckDone.Enabled = true;
            ctrl1.chckDone.Checked = ctrl2.chckDone.Checked = ctrl3.chckDone.Checked = ctrl4.chckDone.Checked = ctrl5.chckDone.Checked = false;
          
        }
        private void Main_Load(object sender, EventArgs e)
        {
            ctrl1.chckDone.CheckedChanged += XongChucNang;
            ctrl2.chckDone.CheckedChanged += XongChucNang;
            ctrl3.chckDone.CheckedChanged += XongChucNang;
            ctrl4.chckDone.CheckedChanged += XongChucNang;
            ctrl5.chckDone.CheckedChanged += XongChucNang;


            clsGlobal.MaHoSo = 0;
            clsGlobal.TrangThaiHienTai = 0;
            Reload();
            HienThiChucNangTheoTrangThaiHoSo();
        }
        Ctrl1 ctrl1 = new Ctrl1();
        Ctrl2 ctrl2 = new Ctrl2();
        Ctrl3 ctrl3 = new Ctrl3();
        Ctrl4 ctrl4 = new Ctrl4();
        Ctrl5 ctrl5 = new Ctrl5();

        

        private void ShowControl(Control control)
        {
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(control);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowControl(ctrl1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowControl(ctrl2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowControl(ctrl3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowControl(ctrl4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowControl(ctrl5);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmChonHoSo frm = new frmChonHoSo();
            frm.ShowDialog();
            if(frm.MaHoSo !=0)
            {
                clsGlobal.MaHoSo = frm.MaHoSo;
                clsGlobal.TrangThaiHienTai = frm.TrangThai;
            }
            Reload();
            HienThiChucNangTheoTrangThaiHoSo();
           
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            clsGlobal.MaHoSo = 11;
            clsGlobal.TrangThaiHienTai = 0;
            Reload();
            HienThiChucNangTheoTrangThaiHoSo();
        }

        #region " Chức năng "
        private void TaoHoSoMoi()
        {
        
        }
        private void HienThiChucNangTheoTrangThaiHoSo()
        {
            flag = false;
            lblHoSo.Text = "Hồ sơ: " + clsGlobal.MaHoSo.ToString();
            lblTrangThai.Text = "Trạng thái :" + clsGlobal.TrangThaiHienTai.ToString();

            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = false;
           
            if (clsGlobal.TrangThaiHienTai >=0)
            {
                button1.Enabled = true;
            }
            if(clsGlobal.TrangThaiHienTai > 0)
            {
                ctrl1.chckDone.Enabled = false;
                ctrl1.chckDone.Checked = true;

                button2.Enabled = true;               
            }
            if(clsGlobal.TrangThaiHienTai > 1)
            {
                ctrl2.chckDone.Enabled = false;
                ctrl2.chckDone.Checked = true;

                button3.Enabled = true;
            }
            if(clsGlobal.TrangThaiHienTai > 2)
            {
                ctrl3.chckDone.Enabled = false;
                ctrl3.chckDone.Checked = true;

                button4.Enabled = true;
            }
            if(clsGlobal.TrangThaiHienTai > 3)
            {
                ctrl4.chckDone.Enabled = false;
                ctrl4.chckDone.Checked = true;

                button5.Enabled = true;
            }
            if (clsGlobal.TrangThaiHienTai > 4)
            {
                ctrl5.chckDone.Enabled = false;
                ctrl5.chckDone.Checked = true;
               
            }

            flag = true;
            
        }
        private void XongChucNang(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
            {
                if(flag)
                    clsGlobal.TrangThaiHienTai++;
                // cap nhat trang thai vao csdl


                HienThiChucNangTheoTrangThaiHoSo();


                ((CheckBox)sender).Enabled = false;

                if (clsGlobal.TrangThaiHienTai == 1)
                    ShowControl(ctrl2);
                else if (clsGlobal.TrangThaiHienTai == 2)
                    ShowControl(ctrl3);
                else if (clsGlobal.TrangThaiHienTai == 3)
                    ShowControl(ctrl4);
                else if (clsGlobal.TrangThaiHienTai == 4)
                    ShowControl(ctrl5);
            }
           
            
        }
        #endregion
    }
}
