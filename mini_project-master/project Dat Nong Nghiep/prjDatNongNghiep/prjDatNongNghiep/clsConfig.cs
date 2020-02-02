using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDatNongNghiep
{
    public static class clsConfig
    {
        public static string ConnectString ="SERVER = DMC-PC; DATABASE = georgetown_ThanhTri; User ID = sa; Password = dmc3star";
       // public static string ConnectString = "SERVER = TIENTHANH-PC\\SQLEXPRESS; DATABASE = georgetown_TayHo; User ID = sa; Password = Thanhid1";
        public static string MaDonVihanhChinh;
        public static string TenDVHC;
        public static int MaHoSo;
        public static int MaGiaDinh;
        public static int TrangThaiHoSo;
        public static bool DangThaoTac;
        public static void Refresh()
        {
            MaHoSo = 0;
            MaGiaDinh = 0;
            TrangThaiHoSo = 0;
            DangThaoTac = false;
        }

        
    }
}
