using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjDatNongNghiep
{
    public static class clsConfig
    {
        public static string ConnectString = "SERVER = TIENTHANH-PC\\SQLEXPRESS; DATABASE = Backup_n_Resotre; User ID = sa; Password = 1";
      
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
