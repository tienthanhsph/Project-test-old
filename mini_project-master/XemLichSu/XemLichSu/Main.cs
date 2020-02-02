using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XemLichSu
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        bool _end = true;
        PhanQuyen phanquyen = new PhanQuyen();


        private void hồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoSo hoso = new HoSo();
            this.Hide();
            hoso.ShowDialog();
            this.Show();
        }
       
        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (phanquyen.KiemTraQuyen(clsStatic.Username, 12))
            {
                this.Hide();
                phanquyen.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Bạn không có quyền làm điều này!");
            }
        }

        private void giámSátNhậpLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (phanquyen.KiemTraQuyen(clsStatic.Username, 13))
            {                
                GiamSatNhapLieu giamsat = new GiamSatNhapLieu();
                this.Hide();
                giamsat.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Bạn không có quyền làm điều này!");
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _end = false;
            this.Close();
                 
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_end)
                Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _end = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void từĐiểnQuyềnHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (phanquyen.KiemTraQuyen(clsStatic.Username, 17))
            {
                TuDienQuyenHan tudienquyen = new TuDienQuyenHan();
                this.Hide();
                tudienquyen.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Bạn không có quyền làm điều này!");
            }
        }
    }
}
