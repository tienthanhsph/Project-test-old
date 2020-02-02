using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Combobox
{
    public partial class frmDemoComboxBox : Form
    {
        // Danh sách nhân viên
        private List<NhanVien> danhSachNhanVien;

        public frmDemoComboxBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Nạp danh sách nhân viên khi Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDemoComboxBox_Load(object sender, EventArgs e)
        {
            // tạo thông tin các nhân viên
            NhanVien nv1 = new NhanVien(0, "Trần Đức Văn", "Lập trình viên");
            NhanVien nv2 = new NhanVien(1, "Nguyễn Văn Lập", "Marketing");
            NhanVien nv3 = new NhanVien(2, "Trần Đình Chính", "Giám đốc");

            // đưa nhân viên vào danh sách nhân viên
            danhSachNhanVien = new List<NhanVien>();
            danhSachNhanVien.Add(nv1);
            danhSachNhanVien.Add(nv2);
            danhSachNhanVien.Add(nv3);

            comboBoxNhanVien.DataSource = danhSachNhanVien;

            //Nội dung sẽ hiển thị lên combobox
            comboBoxNhanVien.DisplayMember = "TenNhanVien";

            //Giá trị nhận được ứng với từng nội dung được chọn trên combobox
            comboBoxNhanVien.ValueMember = "MaNhanVien";

            comboBoxNhanVien.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxNhanVien.AutoCompleteSource = AutoCompleteSource.ListItems;
            
        }

        /// <summary>
        /// Hàm xử lý sự kiện thay đổi lựa chọn trên combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lấy ra nhân viên được chọn
            NhanVien nvDuocChon = (NhanVien) comboBoxNhanVien.SelectedItem;

            // hiển thị thông tin nhân viên             
            lbThongTinNV.Text = nvDuocChon.ThongTinNhanVien;            
        }
    }
}
