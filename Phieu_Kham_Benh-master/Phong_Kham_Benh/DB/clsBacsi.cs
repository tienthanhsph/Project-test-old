
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DB
{
   public class clsBacsi
    {
        private string intPK_Bacsi;

        public string PK_Bacsi
        {
            get { return intPK_Bacsi; }
            set { intPK_Bacsi = value; }
        }
        private string strTenBS;


        public string TenBS
        {
            get { return strTenBS; }
            set { strTenBS = value; }
        }
        private string strTrinhdo;

        public string Trinhdo
        {
            get { return strTrinhdo; }
            set { strTrinhdo = value; }
        }
        private string strChuyenkhoa;

        public string Chuyenkhoa
        {
            get { return strChuyenkhoa; }
            set { strChuyenkhoa = value; }
        }
        private string dtNgaybatdau;

        public string Ngaybatdau
        {
            get { return dtNgaybatdau; }
            set { dtNgaybatdau = value; }
        }
        private string intNamkinhnghiem;

        public string Namkinhnghiem
        {
            get { return intNamkinhnghiem; }
            set { intNamkinhnghiem = value; }
        }
        public clsBacsi()
        { }
        public clsBacsi(string ten, string trinhdo)
        {

            this.TenBS = ten;
            this.Trinhdo = trinhdo;
        }
        public clsBacsi(string ten, string td, string ck, string bd, string kn)
        {
            this.TenBS = ten; this.Trinhdo = td; this.Chuyenkhoa = ck; this.Ngaybatdau = bd; this.Namkinhnghiem = kn;
        }

        string[] Paras = new string[] { "@PK_Bacsi", "@Tenbacsi", "@Trinhdo", "@Chuyenkhoa", "@Congtactungay", "@Namkinhnghiem" };
        string error = "";
        string rcd = "";
        //DataTable dt;

        private string Execute(ref string records, string StoreProcedureName)
        {
            try
            {
                clsDatabase cls = new clsDatabase();
                cls.OpenConnect();
                string[] Values = new string[] { PK_Bacsi, TenBS, Trinhdo, Chuyenkhoa, Ngaybatdau, Namkinhnghiem };
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
                string[] Values = new string[] { PK_Bacsi, TenBS, Trinhdo, Chuyenkhoa, Ngaybatdau, Namkinhnghiem };
                if (Paras.Length != Values.Length)
                    return "Tham bien va tham tri khong tuong thich";
                else
                    cls.getValue(ref tbl, "SPSelectBacsi", Paras, Values);

                cls.CloseConnect();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                MessageBox.Show("Co loi " + ex.Message);
            }
            return error;
        }


        public void Insert(string ten, string td, string ck, string ng, string nam)
        {
            this.PK_Bacsi = "";
            this.TenBS = ten; this.Trinhdo = td; this.Chuyenkhoa = ck; this.Ngaybatdau = ng; this.Namkinhnghiem = nam;
            this.Execute(ref rcd, "InsertBacsi");
        }

        public void Update(string khoa, string ten, string td, string ck, string ng, string nam)
        {
            this.PK_Bacsi = khoa;
            this.TenBS = ten; this.Trinhdo = td; this.Chuyenkhoa = ck; this.Ngaybatdau = ng; this.Namkinhnghiem = nam;
            this.Execute(ref rcd, "UpdateBacsi");
        }
        public void Delete(string khoa, string ten, string td, string ck, string ng, string nam)
        {
            this.PK_Bacsi = khoa;
            this.TenBS = ten; this.Trinhdo = td; this.Chuyenkhoa = ck; this.Ngaybatdau = ng; this.Namkinhnghiem = nam;
            this.Execute(ref rcd, "DeleteBacsi");
        }
    }
}
