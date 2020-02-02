using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjMenuHeThong
{
    public static class Global
    {
       // public static string _connectionString ="";
       
       // public static string _connectionString = " SERVER = TIENTHANH-PC\\SQLEXPRESS; DATABASE = georgetown_TayHo; User ID = sa; Password = Thanhid1";
        public static string _connectionString = " SERVER = 192.168.0.102; DATABASE = georgetown_ThanhTri; User ID = sa; Password = dmc3star";
       // public static string _connectionString = " SERVER = THI-PC\\SQL2005; DATABASE = georgetown_ThanhTri; User ID = sa; Password = dmc3star";

        public static List<string> listColumns = new List<string>();

        public static int _flag_style_of_panel1 = 0;

        public static List<string> _dieukien = new List<string>();
        public static List<string> _hienthi_dieukien = new List<string>();

        public static string _Notification = "";


        public static string _MaDonViHanhChinhHienThoi="";       

        public static string _MaTrangThaiHoSo = "";


    }
}
