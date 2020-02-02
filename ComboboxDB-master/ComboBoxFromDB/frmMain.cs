using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxFromDB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            // thiết lập thông tin hiển thị và thông tin giá trị của combobox
            cbbNhanVien.DisplayMember = "TenNhanVien";
            cbbNhanVien.ValueMember = "MaNhanVien";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // nạp danh sách nhân viên lên combobox
            NhanVienDB nhanVienDB = new NhanVienDB();
            cbbNhanVien.DataSource = nhanVienDB.LayDanhSachNhanVien();            
        }

        private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhanVienDB nhanVienDB = new NhanVienDB();

            // lấy mã nhân viên được chọn
            string maNhanVienDuocChon = (string) cbbNhanVien.SelectedValue;

            // lấy nhân viên từ mã
            NhanVien nhanVienDuocChon = nhanVienDB.LayNhanVienTheoMa(maNhanVienDuocChon);

            // hiển thị lên thông tin nhân viên
            lbThongTinNhanVien.Text = nhanVienDuocChon.ThongTinChiTiet;

        }
    }
}
