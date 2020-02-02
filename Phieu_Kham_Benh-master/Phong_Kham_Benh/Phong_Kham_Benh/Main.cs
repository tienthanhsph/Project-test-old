using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GIAODIEN;
using DB;

namespace Phong_Kham_Benh
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
       




        private void Main_Load(object sender, EventArgs e)
        {
            clrMainPl();
            ThongTinBenhNhan bn = new ThongTinBenhNhan();
            loadMainPl(bn);
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongtintaikhoan thongtin = new frmThongtintaikhoan();
            thongtin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clsThongTinChung._Quyen == "1" || clsThongTinChung._Quyen == "2")
            {
                if (clsThongTinChung.MaBenhNhan == "")
                    MessageBox.Show("Bạn cần chọn bệnh nhân để lập Phiếu khám!");
                else {
                    PhieuKham pk = new PhieuKham();
                    loadMainPl(pk);
                }
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập vào mục này!");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clsThongTinChung._Quyen == "1" || clsThongTinChung._Quyen == "2")
            {
                ThongTinBenhNhan bn = new ThongTinBenhNhan();
                loadMainPl(bn);
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập vào mục này!");
            
        }
        private void clrMainPl()
        {
            splitContainer1.Panel2.Controls.Clear();
        
        }
        public void loadMainPl(UserControl Ctrl)
        {
            clrMainPl();
            splitContainer1.Panel2.Controls.Add(Ctrl);
            Ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BangGiaKhamBenh bg = new BangGiaKhamBenh();
            loadMainPl(bg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clsThongTinChung._Quyen == "1")
            {
                DoanhThu dt = new DoanhThu();
                loadMainPl(dt);
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập vào mục này!");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (clsThongTinChung._Quyen == "1" || clsThongTinChung._Quyen == "2")
            {
                Bacsi bs = new Bacsi();
                loadMainPl(bs);
            }
            else
                MessageBox.Show("Bạn không có quyền truy cập vào mục này!");

        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
        private void DangXuat()
        {
            clsThongTinChung._Quyen = "";
            clsThongTinChung._UserAccount = "";
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangXuat();
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
