using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Combobox
{
    /// <summary>
    /// Lớp NhanVien
    /// </summary>
    class NhanVien
    {
        // Mã nhân viên
        private int maNhanVien;

        // Tên nhân viên
        private string tenNhanVien;

        // Thông tin nhân viên
        private string thongTinNhanVien;

        public NhanVien() { }

        public NhanVien(int maNhanVien, string tenNhanVien, string thongTinNhanVien)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.thongTinNhanVien = thongTinNhanVien;
        }
            

        public int MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
        
        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }        

        public string ThongTinNhanVien
        {
            get { return thongTinNhanVien; }
            set { thongTinNhanVien = value; }
        }
    }
}
