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
    public class Benhnhanctrl
    {
        clsBenhnhan benhnhan = new clsBenhnhan();
        DataTable tbl = new DataTable();
        public void LoadDatagridview(DataGridView dtgrv, string ten, string cm, string ns, string gt, string dc, string sdt)
        {
            clsBenhnhan benhnhan1 = new clsBenhnhan();
            benhnhan1.PK_MaBN = "";
            benhnhan1.Hoten = ten; benhnhan1.CMND = cm; benhnhan1.Ngaysinh = ns; benhnhan1.Gioitinh = gt; benhnhan1.Diachi = dc; benhnhan1.Sodienthoai = sdt;
            benhnhan1.GetData(ref tbl);            
            dtgrv.DataSource = tbl;
        }

        public void ThemBenhNhan(DataGridView dtgrv, string ten, string cm, string ns, string gt, string dc, string sdt)
        {
            benhnhan.Insert(ten,cm,ns,gt,dc,sdt);
            LoadDatagridview(dtgrv, "", "", "", "", "","");
        }
        public void SuaBenhNhan(DataGridView dtgrv, string khoa, string ten, string cm, string ns, string gt, string dc, string sdt)
        {
            benhnhan.Update(khoa, ten, cm, ns, gt, dc, sdt);
            LoadDatagridview(dtgrv, "", "", "", "", "","");
        }
        public void XoaBenhNhan(DataGridView dtgrv, string khoa, string ten, string cm, string ns, string gt, string dc, string sdt)
        {
            benhnhan.Delete(khoa, ten, cm, ns, gt, dc, sdt);
            LoadDatagridview(dtgrv, "", "", "", "", "","");
        }
    }
}
