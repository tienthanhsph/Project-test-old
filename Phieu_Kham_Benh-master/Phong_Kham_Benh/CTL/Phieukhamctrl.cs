using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DB;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CTL
{
    public class Phieukhamctrl
    {
        clsPhieukham pk = new clsPhieukham();
        DataTable tbl = new DataTable();
        public void LoadDatagridview(DataGridView dtgrv, string FK_MaBN, string FK_MaBacsi, string Dontiep, string Dientim, string Noi, string Noinhi, string Noi4, string Ngoai, string San, string Xquang, string Sieuam, string Sinhhoa, string Huyethoc, string Taimuihong, string Ranghammat, string Ngaykham, string Tongtien)
        {
            clsPhieukham pk1 = new clsPhieukham();
            pk1.PK_MaPhieu = "";
            pk1.FK_MaBN = FK_MaBN; pk1.FK_MaBacsi = FK_MaBacsi; pk1.Dontiep = Dontiep; pk1.Dientim = Dientim; pk1.Noi = Noi; pk1.Noinhi = Noinhi; pk1.Noi4 = Noi4; pk1.Ngoai = Ngoai; pk1.San = San; pk1.Xquang = Xquang; pk1.Sieuam = Sieuam; pk1.Sinhhoa = Sinhhoa; pk1.Huyethoc = Huyethoc; pk1.Taimuihong = Taimuihong; pk1.Ranghammat = Ranghammat; pk1.Ngaykham = Ngaykham; pk1.Tongtien = Tongtien;

            pk1.GetData(ref tbl);
            dtgrv.DataSource = tbl;
        }

        public void LoadDatagridview_TimKiem(DataGridView dtgrv,string PK_MaPhieu, string TenBenhNhan, string TenBacSi, string Dontiep, string Dientim, string Noi, string Noinhi, string Noi4, string Ngoai, string San, string Xquang, string Sieuam, string Sinhhoa, string Huyethoc, string Taimuihong, string Ranghammat, string Ngaykham, string Tongtien)
        {
            clsPhieukham pk1 = new clsPhieukham();
            pk1.PK_MaPhieu = PK_MaPhieu;
            pk1.TenBN = TenBenhNhan; pk1.TenBS = TenBacSi; pk1.Dontiep = Dontiep; pk1.Dientim = Dientim; pk1.Noi = Noi; pk1.Noinhi = Noinhi; pk1.Noi4 = Noi4; pk1.Ngoai = Ngoai; pk1.San = San; pk1.Xquang = Xquang; pk1.Sieuam = Sieuam; pk1.Sinhhoa = Sinhhoa; pk1.Huyethoc = Huyethoc; pk1.Taimuihong = Taimuihong; pk1.Ranghammat = Ranghammat; pk1.Ngaykham = Ngaykham; pk1.Tongtien = Tongtien;

            pk1.GetData_TimKiem(ref tbl);
            dtgrv.DataSource = tbl;
        }

        public void ThemPhieuKham(DataGridView dtgrv, string FK_MaBN, string FK_MaBacsi, string Dontiep, string Dientim, string Noi, string Noinhi, string Noi4, string Ngoai, string San, string Xquang, string Sieuam, string Sinhhoa, string Huyethoc, string Taimuihong, string Ranghammat, string Ngaykham, string Tongtien)
        {
            pk.Insert(FK_MaBN, FK_MaBacsi, Dontiep, Dientim, Noi, Noinhi, Noi4, Ngoai, San, Xquang, Sieuam, Sinhhoa, Huyethoc, Taimuihong, Ranghammat, Ngaykham, Tongtien);
            LoadDatagridview(dtgrv, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
        }
        public void SuaPhieuKham(DataGridView dtgrv, string khoa, string FK_MaBN, string FK_MaBacsi, string Dontiep, string Dientim, string Noi, string Noinhi, string Noi4, string Ngoai, string San, string Xquang, string Sieuam, string Sinhhoa, string Huyethoc, string Taimuihong, string Ranghammat, string Ngaykham, string Tongtien)
        {
            pk.Update(khoa, FK_MaBN, FK_MaBacsi, Dontiep, Dientim, Noi, Noinhi, Noi4, Ngoai, San, Xquang, Sieuam, Sinhhoa, Huyethoc, Taimuihong, Ranghammat, Ngaykham, Tongtien);
            LoadDatagridview(dtgrv, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
        }
        public void XoaPhieuKham(DataGridView dtgrv, string khoa, string FK_MaBN, string FK_MaBacsi, string Dontiep, string Dientim, string Noi, string Noinhi, string Noi4, string Ngoai, string San, string Xquang, string Sieuam, string Sinhhoa, string Huyethoc, string Taimuihong, string Ranghammat, string Ngaykham, string Tongtien)
        {
            pk.Delete(khoa, FK_MaBN, FK_MaBacsi, Dontiep, Dientim, Noi, Noinhi, Noi4, Ngoai, San, Xquang, Sieuam, Sinhhoa, Huyethoc, Taimuihong, Ranghammat, Ngaykham, Tongtien);
            LoadDatagridview(dtgrv, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
        }
    }
}
