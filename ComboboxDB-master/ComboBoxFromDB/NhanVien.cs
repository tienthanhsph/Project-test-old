using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComboBoxFromDB
{
    public class NhanVien
    {      
        // Property
        private string maNhanVien;
        private string tenNhanVien;
        private string thongTinChiTiet;

        // Constructor
        public NhanVien(string maNhanVien, string tenNhanVien, string thongTinChiTiet)
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.thongTinChiTiet = thongTinChiTiet;
        }

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
       

        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }
        

        public string ThongTinChiTiet
        {
            get { return thongTinChiTiet; }
            set { thongTinChiTiet = value; }
        }
    }
}
