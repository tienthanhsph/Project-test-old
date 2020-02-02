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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        private void btnOK_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap(this.txtUsername.Text.Trim(), this.txtPassword.Text.Trim());
        }
        private void KiemTraDangNhap(string Username, string Password)
        {
            if (Username == "" || Password == "")
            {
                MessageBox.Show("Điền thiếu thông tin");
                return;
            }
            string query = " select * from tblUsers where Username ='" + Username + "' and Password ='" + Password + "' ";
            if (cls.GetList(query, "Username").Length > 0)
            {
                clsStatic.Username = cls.GetList(query, "Username")[0];
                clsStatic.GiamSatNhapLieu_save("", "Đăng nhập", "DangNhap", "Đăng nhập thành công!");
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
                this.Show();
                

                //HoSo hoso = new HoSo();
                //this.Hide();
                //hoso.ShowDialog();
                //this.Show();
            }
            else
                MessageBox.Show("Đăng nhập không thành công!");
        }

       
    }
}
