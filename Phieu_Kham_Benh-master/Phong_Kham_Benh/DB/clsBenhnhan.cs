using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB
{
    public class clsBenhnhan
    {
        clsDatabase cls = new clsDatabase();
        private string intPK_MaBN;

        public string PK_MaBN
        {
            get { return intPK_MaBN; }
            set { intPK_MaBN = value; }
        }
        private string strHoten;

        public string Hoten
        {
            get { return strHoten; }
            set { strHoten = value; }
        }
        private string blGioitinh;

        public string Gioitinh
        {
            get { return blGioitinh; }
            set { blGioitinh = value; }
        }
        private string strDiachi;

        public string Diachi
        {
            get { return strDiachi; }
            set { strDiachi = value; }
        }
        private string strSodienthoai;

        public string Sodienthoai
        {
            get { return strSodienthoai; }
            set { strSodienthoai = value; }
        }
        private string strCMND;

        public string CMND
        {
            get { return strCMND; }
            set { strCMND = value; }
        }
        private string dtNgaysinh;

        public string Ngaysinh
        {
            get { return dtNgaysinh; }
            set { dtNgaysinh = value; }
        }
        public clsBenhnhan() { }
        public clsBenhnhan(string ten, string cm)
        {
            this.Hoten = ten;
            this.CMND = cm;
        }
        public clsBenhnhan(string ten, string gt, string dc, string sdt, string cm, string ns)
        {
            this.Hoten = ten; this.Gioitinh = gt; this.Diachi = dc; this.Sodienthoai = sdt; this.CMND = cm; this.Ngaysinh = ns;
        }






        string[] Paras = new string[] { "@PK_MaBN", "@Hoten", "@CMND", "@Ngaysinh", "@Gioitinh", "@Diachi", "@Sodienthoai" };
        string error = "";
        string rcd = "";
        //DataTable dt;

        private string Execute(ref string records, string StoreProcedureName)
        {
            try
            {
                clsDatabase cls = new clsDatabase();
                cls.OpenConnect();
                string[] Values = new string[] { PK_MaBN, Hoten, CMND, Ngaysinh, Gioitinh, Diachi, Sodienthoai };
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
                string[] Values = new string[] { PK_MaBN, Hoten, CMND, Ngaysinh, Gioitinh, Diachi, Sodienthoai };
                if (Paras.Length != Values.Length)
                    return "Tham bien va tham tri khong tuong thich";
                else
                    cls.getValue(ref tbl, "SPSelectBenhNhan", Paras, Values);

                cls.CloseConnect();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                MessageBox.Show("Co loi " + ex.Message);
            }
            return error;
        }


        public void Insert(string ten, string cm, string ns, string gt, string dc, string sdt)
        {
            this.PK_MaBN = "";
            this.Hoten = ten; this.CMND = cm; this.Ngaysinh = ns; this.Gioitinh = gt; this.Diachi = dc; this.Sodienthoai = sdt;
            this.Execute(ref rcd, "InsertBenhNhan");
        }

        public void Update(string khoa,string ten, string cm, string ns, string gt, string dc, string sdt)
        {
            this.PK_MaBN = khoa;
            this.Hoten = ten; this.CMND = cm; this.Ngaysinh = ns; this.Gioitinh = gt; this.Diachi = dc; this.Sodienthoai = sdt;
            this.Execute(ref rcd, "UpdateBenhNhan");
        }
        public void Delete(string khoa,string ten, string cm, string ns, string gt, string dc, string sdt)
        {
            this.PK_MaBN = khoa;
            this.Hoten = ten; this.CMND = cm; this.Ngaysinh = ns; this.Gioitinh = gt; this.Diachi = dc; this.Sodienthoai = sdt;
            this.Execute(ref rcd, "DeleteBenhNhan");
        }
    }
}
