using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB
{
    public class clsBanggia
    {
        clsDatabase cls = new clsDatabase();
        private string intPK_Maloaihinh;

        public string PK_Maloaihinh
        {
            get { return intPK_Maloaihinh; }
            set { intPK_Maloaihinh = value; }
        }
        private string strTenloaihinh;

        public string Tenloaihinh
        {
            get { return strTenloaihinh; }
            set { strTenloaihinh = value; }
        }
        private string strGia;

        public string Gia
        {
            get { return strGia; }
            set { strGia = value; }
        }
        private string dtNgaythem;

        public string Ngaythem
        {
            get { return dtNgaythem; }
            set { dtNgaythem = value; }
        }
        private string dtNgayhuy;

        public string Ngayhuy
        {
            get { return dtNgayhuy; }
            set { dtNgayhuy = value; }
        }
        private string blDanghoatdong;

        public string Danghoatdong
        {
            get { return blDanghoatdong; }
            set { blDanghoatdong = value; }
        }
        public clsBanggia()
        { }
        public clsBanggia(string ten, string gia)
        {
            this.Tenloaihinh = ten;
            this.Gia = gia;
        }
        public clsBanggia(string ten, string gia, string them, string huy, string hd)
        {
            this.Tenloaihinh = ten;
            this.Gia = gia;
            this.Ngaythem = them;
            this.Ngayhuy = huy;
            this.Danghoatdong = hd;
        }

        string[] Paras = new string[] { "@PK_Maloaihinh", "@Tenloaihinh", "@Gia", "@Ngaythem", "@Ngayhuy", "@Danghoatdong" };
        string error = "";
        string rcd = "";

        private string Execute(ref string records, string StoreProcedureName)
        {
            try
            {
                clsDatabase cls = new clsDatabase();
                cls.OpenConnect();
                string[] Values = new string[] { PK_Maloaihinh,Tenloaihinh,Gia,Ngaythem,Ngayhuy,Danghoatdong};
                if (Paras.Length != Values.Length)
                    return "Tham bien va tham tri khong tuong thich";
                else
                    cls.ExecuteSP(StoreProcedureName, Paras, Values, ref records);

                cls.CloseConnect();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                MessageBox.Show("Có lỗi \n " + ex.Message);
            }
            return error;
        }


        public string GetData(ref DataTable tbl)
        {

            try
            {
                clsDatabase cls = new clsDatabase();
                cls.OpenConnect();
                string[] Values = new string[] { PK_Maloaihinh, Tenloaihinh, Gia, Ngaythem, Ngayhuy, Danghoatdong };
                if (Paras.Length != Values.Length)
                    return "Tham bien va tham tri khong tuong thich";
                else
                    cls.getValue(ref tbl, "SPSelectBangGia", Paras, Values);

                cls.CloseConnect();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                MessageBox.Show("Có lỗi\n" + ex.Message);
            }
            return error;
        }


        public void Insert(string ten, string gia, string them)
        {
            this.PK_Maloaihinh = "";
            this.Tenloaihinh = ten; this.Gia = gia; this.Ngaythem = them; this.Ngayhuy = ""; this.Danghoatdong = "1";
            this.Execute(ref rcd, "InsertBangGia");
        }

        public void Update(string khoa, string ten, string gia, string them, string huy, string hoatdong)
        {
            this.PK_Maloaihinh = khoa;
            this.Tenloaihinh = ten; this.Gia = gia; this.Ngaythem = them; this.Ngayhuy = huy; this.Danghoatdong = hoatdong;
            this.Execute(ref rcd, "UpdateBangGia");
        }
        public void Delete(string khoa, string ten, string gia)
        {
            this.PK_Maloaihinh = khoa;
            this.Tenloaihinh = ten; this.Gia = gia; this.Ngaythem = ""; this.Ngayhuy = ""; this.Danghoatdong = "";
            this.Execute(ref rcd, "DeleteBangGia");
        }
    }
}
