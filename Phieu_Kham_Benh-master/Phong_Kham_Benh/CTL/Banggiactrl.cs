using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DB;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CTL
{
    public class Banggiactrl
    {
        DataTable tbl = new DataTable();
        clsBanggia bg = new clsBanggia();

        public void LoadDataGridView(DataGridView dtgrv, string ten, string gia, string them, string huy, string hd)
        {
            bg.PK_Maloaihinh = "";
            bg.Tenloaihinh = ten; bg.Gia = gia; bg.Ngaythem = them; bg.Ngayhuy = huy; bg.Danghoatdong = hd;
            bg.GetData(ref tbl);
            dtgrv.DataSource = tbl;
        }
        public void ThemBangGia(DataGridView dtgrv, string ten, string gia, string them)
        {
            bg.Insert(ten, gia, them);
            LoadDataGridView(dtgrv, "", "", "", "", "");
        }
        public void SuaBangGia(DataGridView dtgrv,string khoa, string ten, string gia, string them, string huy, string hd)
        {
            bg.Update(khoa, ten, gia, them, huy, hd);
            LoadDataGridView(dtgrv, "", "", "", "", "");
        }
        public void XoaBangGia(DataGridView dtgrv, string khoa, string ten, string gia)
        {
            bg.Delete(khoa, ten, gia);
            LoadDataGridView(dtgrv, "", "", "", "", "");
        }
    }
}
