using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DB;

namespace CTL
{
    public class Bacsictrl
    {
        clsBacsi bs = new clsBacsi();
        DataTable tbl= new DataTable();
        public void LoadDatagridview(DataGridView dtgrv, string ten, string td, string ck, string bd, string kn)
        {
            clsBacsi clsbs = new clsBacsi(); clsbs.PK_Bacsi = "";
            clsbs.TenBS = ten; clsbs.Trinhdo = td; clsbs.Chuyenkhoa = ck; clsbs.Ngaybatdau = bd; clsbs.Namkinhnghiem = kn;

            clsbs.GetData(ref tbl);
            dtgrv.DataSource = tbl;
        }
        
        public void ThemBacSi(DataGridView dtgrv, string ten, string trinhdo, string chuyenkhoa, string ngaybd, string namkn)
        {
            bs.Insert(ten, trinhdo, chuyenkhoa, ngaybd, namkn);
            LoadDatagridview(dtgrv,"","","","","");
        }
        public void SuaBacSi(DataGridView dtgrv,string khoa, string ten, string trinhdo, string chuyenkhoa, string ngaybd, string namkn)
        {
            bs.Update(khoa, ten, trinhdo, chuyenkhoa, ngaybd, namkn);
            LoadDatagridview(dtgrv,"","","","","");
        }
        public void XoaBacSi(DataGridView dtgrv, string khoa, string ten, string trinhdo, string chuyenkhoa, string ngaybd, string namkn)
        {
            bs.Delete(khoa, ten, trinhdo, chuyenkhoa, ngaybd, namkn);
            LoadDatagridview(dtgrv, "", "", "", "", "");
        }
    }
}
