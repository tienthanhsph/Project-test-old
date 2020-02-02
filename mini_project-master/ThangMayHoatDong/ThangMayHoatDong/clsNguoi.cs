using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThangMayHoatDong
{
    class clsNguoi
    {
        private string strName;

        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }
        private int intKg;

        public int Kg
        {
            get { return intKg; }
            set { intKg = value; }
        }
        private int intTang;

        public int Tang
        {
            get { return intTang; }
            set { intTang = value; }
        }
        private int intDichDen;

        public int DichDen
        {
            get { return intDichDen; }
            set { intDichDen = value; }
        }
        private bool blUuTien;

        public bool UuTien
        {
            get { return blUuTien; }
            set { blUuTien = value; }
        }
        private bool blTrongThangMay;

        public bool TrongThangMay
        {
            get { return blTrongThangMay; }
            set { blTrongThangMay = value; }
        }

        public clsThangMay ThangMay { get; set; }

        public clsNguoi()
        { 
        
        }
        public clsNguoi(int dichDen, int tang, int kg, bool trongThangMay, bool UuTien = false)
        { 
        
        }
    }
}
