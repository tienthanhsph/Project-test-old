using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB
{
   public class clsPhieukham
    {
        clsDatabase cls = new clsDatabase();
        private string intPK_MaPhieu;

        public string PK_MaPhieu
        {
            get { return intPK_MaPhieu; }
            set { intPK_MaPhieu = value; }
        }
        private string intFK_MaBN;

        public string FK_MaBN
        {
            get { return intFK_MaBN; }
            set { intFK_MaBN = value; }
        }
        private string strFK_MaBacsi;

        public string FK_MaBacsi
        {
            get { return strFK_MaBacsi; }
            set { strFK_MaBacsi = value; }
        }
        private string strDontiep;


        public string Dontiep
        {
            get { return strDontiep; }
            set { strDontiep = value; }
        }
        private string strDientim;

        public string Dientim
        {
            get { return strDientim; }
            set { strDientim = value; }
        }
        private string strNoi;

        public string Noi
        {
            get { return strNoi; }
            set { strNoi = value; }
        }
        private string strNoinhi;

        public string Noinhi
        {
            get { return strNoinhi; }
            set { strNoinhi = value; }
        }
        private string strNoi4;

        public string Noi4
        {
            get { return strNoi4; }
            set { strNoi4 = value; }
        }
        private string strNgoai;

        public string Ngoai
        {
            get { return strNgoai; }
            set { strNgoai = value; }
        }
        private string strSan;

        public string San
        {
            get { return strSan; }
            set { strSan = value; }
        }
        private string strXquang;

        public string Xquang
        {
            get { return strXquang; }
            set { strXquang = value; }
        }
        private string strSieuam;

        public string Sieuam
        {
            get { return strSieuam; }
            set { strSieuam = value; }
        }
        private string strSinhhoa;

        public string Sinhhoa
        {
            get { return strSinhhoa; }
            set { strSinhhoa = value; }
        }
        private string strHuyethoc;

        public string Huyethoc
        {
            get { return strHuyethoc; }
            set { strHuyethoc = value; }
        }
        private string strTaimuihong;

        public string Taimuihong
        {
            get { return strTaimuihong; }
            set { strTaimuihong = value; }
        }
        private string strRanghammat;

        public string Ranghammat
        {
            get { return strRanghammat; }
            set { strRanghammat = value; }
        }
        private string dtNgaykham;

        public string Ngaykham
        {
            get { return dtNgaykham; }
            set { dtNgaykham = value; }
        }
        private string strTongtien;

        public string Tongtien
        {
            get { return strTongtien; }
            set { strTongtien = value; }
        }




        string[] Paras = new string[] { "@PK_MaPhieu", "@FK_MaBN", "@FK_MaBacsi", "@Dontiep", "@Dientim", "@Noi", "@Noinhi", "@Noi4", "@Ngoai", "@San", "@Xquang", "@Sieuam", "@Sinhhoa", "@Huyethoc", "@Taimuihong", "@Ranghammat", "@Ngaykham", "@Tongtien" };
        string error = "";
        string rcd = "";
        //DataTable dt;

        private string Execute(ref string records, string StoreProcedureName)
        {
            try
            {
                clsDatabase cls = new clsDatabase();
                cls.OpenConnect();
                string[] Values = new string[] { PK_MaPhieu, FK_MaBN, FK_MaBacsi, Dontiep, Dientim, Noi, Noinhi, Noi4, Ngoai, San, Xquang, Sieuam, Sinhhoa, Huyethoc, Taimuihong, Ranghammat, Ngaykham, Tongtien };
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


        public string GetData(ref DataTable tbl)
        {

            try
            {
                clsDatabase cls = new clsDatabase();
                cls.OpenConnect();
                string[] Values = new string[] { PK_MaPhieu, FK_MaBN, FK_MaBacsi, Dontiep, Dientim, Noi, Noinhi, Noi4, Ngoai, San, Xquang, Sieuam, Sinhhoa, Huyethoc, Taimuihong, Ranghammat, Ngaykham, Tongtien };
                if (Paras.Length != Values.Length)
                    return "Tham bien va tham tri khong tuong thich";
                else
                    cls.getValue(ref tbl, "SPSelectPhieuKham", Paras, Values);

                cls.CloseConnect();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                MessageBox.Show("Co loi " + ex.Message);
            }
            return error;
        }

        public string TenBN;
        public string TenBS;
        string[] Paras_TimKiem = new string[] { "@PK_MaPhieu", "@TenBN", "@TenBS", "@Dontiep", "@Dientim", "@Noi", "@Noinhi", "@Noi4", "@Ngoai", "@San", "@Xquang", "@Sieuam", "@Sinhhoa", "@Huyethoc", "@Taimuihong", "@Ranghammat", "@Ngaykham", "@Tongtien" };
        public string GetData_TimKiem(ref DataTable tbl)
        {

            try
            {
                clsDatabase cls = new clsDatabase();
                cls.OpenConnect();
                string[] Values = new string[] { PK_MaPhieu, TenBN, TenBS, Dontiep, Dientim, Noi, Noinhi, Noi4, Ngoai, San, Xquang, Sieuam, Sinhhoa, Huyethoc, Taimuihong, Ranghammat, Ngaykham, Tongtien };
                if (Paras_TimKiem.Length != Values.Length)
                    return "Tham bien va tham tri khong tuong thich";
                else
                    cls.getValue(ref tbl, "SPSelectPhieuKham_TimKiem", Paras_TimKiem, Values);

                cls.CloseConnect();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                MessageBox.Show("Co loi " + ex.Message);
            }
            return error;
        }

        public void Insert(string FK_MaBN, string FK_MaBacsi, string Dontiep, string Dientim, string Noi, string Noinhi, string Noi4, string Ngoai, string San, string Xquang, string Sieuam, string Sinhhoa, string Huyethoc, string Taimuihong, string Ranghammat, string Ngaykham, string Tongtien)
        {
            this.PK_MaPhieu = "";
            this.FK_MaBN = FK_MaBN; this.FK_MaBacsi = FK_MaBacsi; this.Dontiep = Dontiep; this.Dientim = Dientim; this.Noi = Noi; this.Noinhi = Noinhi; this.Noi4 = Noi4; this.Ngoai = Ngoai; this.San = San; this.Xquang = Xquang; this.Sieuam = Sieuam; this.Sinhhoa = Sinhhoa; this.Huyethoc = Huyethoc; 
            this.Taimuihong = Taimuihong; this.Ranghammat = Ranghammat; this.Ngaykham = Ngaykham; this.Tongtien = Tongtien;
            this.Execute(ref rcd, "InsertPhieuKham");
        }

        public void Update(string khoa,string FK_MaBN, string FK_MaBacsi, string Dontiep, string Dientim, string Noi, string Noinhi, string Noi4, string Ngoai, string San, string Xquang, string Sieuam, string Sinhhoa, string Huyethoc, string Taimuihong, string Ranghammat, string Ngaykham, string Tongtien)
        {
            this.PK_MaPhieu = khoa;
            this.FK_MaBN = FK_MaBN; this.FK_MaBacsi = FK_MaBacsi; this.Dontiep = Dontiep; this.Dientim = Dientim; this.Noi = Noi; this.Noinhi = Noinhi; this.Noi4 = Noi4; this.Ngoai = Ngoai; this.San = San; this.Xquang = Xquang; this.Sieuam = Sieuam; this.Sinhhoa = Sinhhoa; this.Huyethoc = Huyethoc;
            this.Taimuihong = Taimuihong; this.Ranghammat = Ranghammat; this.Ngaykham = Ngaykham; this.Tongtien = Tongtien;
            this.Execute(ref rcd, "UpdatePhieuKham");
        }
        public void Delete(string khoa,string FK_MaBN, string FK_MaBacsi, string Dontiep, string Dientim, string Noi, string Noinhi, string Noi4, string Ngoai, string San, string Xquang, string Sieuam, string Sinhhoa, string Huyethoc, string Taimuihong, string Ranghammat, string Ngaykham, string Tongtien)
        {
            this.PK_MaPhieu = khoa;
            this.FK_MaBN = FK_MaBN; this.FK_MaBacsi = FK_MaBacsi; this.Dontiep = Dontiep; this.Dientim = Dientim; this.Noi = Noi; this.Noinhi = Noinhi; this.Noi4 = Noi4; this.Ngoai = Ngoai; this.San = San; this.Xquang = Xquang; this.Sieuam = Sieuam; this.Sinhhoa = Sinhhoa; this.Huyethoc = Huyethoc;
            this.Taimuihong = Taimuihong; this.Ranghammat = Ranghammat; this.Ngaykham = Ngaykham; this.Tongtien = Tongtien;
            this.Execute(ref rcd, "DeletePhieuKham");
        }
        
    }
}
