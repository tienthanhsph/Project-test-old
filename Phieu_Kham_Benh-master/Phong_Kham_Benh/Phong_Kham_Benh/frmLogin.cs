using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DB;

namespace Phong_Kham_Benh
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private string strTaikhoan;

        public string Taikhoan
        {
            get { return strTaikhoan; }
            set { strTaikhoan = value; }
        }
        private string strMatkhau;

        public string Matkhau
        {
            get { return strMatkhau; }
            set { strMatkhau = value; }
        }
        private string strQuyen;

        public string Quyen
        {
            get { return strQuyen; }
            set { strQuyen = value; }
        }

        string User="";
        string Pass = "";
       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                User = textBox1.Text.Trim();
                Pass = textBox2.Text.Trim();

                string str = "SELECT Quyen from tblDangnhap where Taikhoan = '" + User + "' and Matkhau = '" + Pass + "'";
                clsDatabase cls = new clsDatabase();
                string kq = cls.Execute_Reader(str);
                if (kq == "")
                    MessageBox.Show("Tên đăng nhập hoặc tài khoản không đúng!");
                else
                {

                    Main mainform = new Main();
                    mainform.Show();
                    
                    clsThongTinChung._UserAccount = User;
                    clsThongTinChung._Quyen = kq;
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại!\n"+ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDangKy dangky = new frmDangKy();
            this.Hide();
            dangky.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
