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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
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
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string _quyen = "";
            if (comboBox1.Text.Trim() == "Admin") _quyen = "1";
            else if (comboBox1.Text.Trim() == "Nhân viên chuyên môn") _quyen = "2";
            else if (comboBox1.Text.Trim() == "Khách xem") _quyen = "3";


            if (textBox1.Text.Trim().Contains(" ") == true)
                MessageBox.Show("Tên đăng nhập không được chứa ký tự trống!");
            else if (textBox2.Text.Trim() != textBox3.Text.Trim())
                MessageBox.Show("Mật khẩu không khớp nhau!");
            else
            {
                try
                {
                    Insert(textBox1.Text.Trim(), textBox2.Text.Trim(), _quyen);
                    MessageBox.Show("Đăng ký thành công!");
                    this.Hide();
                    frmLogin login = new frmLogin();
                    login.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public void Insert(string ten, string mk, string q)
        {

            this.Taikhoan = ten; this.Matkhau = mk; this.Quyen = q;
            this.Execute(ref rcd, "InsertUser");
        }
        string[] Paras = new string[] { "@Taikhoan", "@Matkhau", "@Quyen" };
        string error = "";
        string rcd = "";
        private string Execute(ref string records, string StoreProcedureName)
        {
            try
            {
                clsDatabase cls = new clsDatabase();
                cls.OpenConnect();
                string[] Values = new string[] { Taikhoan,Matkhau,Quyen};
                if (Paras.Length != Values.Length)
                    return "Tham bien va tham tri khong tuong thich";
                else
                    cls.ExecuteSP(StoreProcedureName, Paras, Values, ref records);

                cls.CloseConnect();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                MessageBox.Show("Co loi " + ex.Message);
            }
            return error;
        }
    }
}
