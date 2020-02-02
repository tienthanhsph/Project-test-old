using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMCWeb.Models;

namespace DMCWeb.Logic
{
    public class XNCoQuanDangKy
    {
        DMCWebEntities db = new DMCWebEntities();
        public tblXacNhanCoQuanDangKyDatDai result(string MaHoSo)
        {
            long _maHoSo = long.Parse(MaHoSo);
            try
            {
                return db.tblXacNhanCoQuanDangKyDatDais.Single(n => n.MaHoSo == _maHoSo);
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool KiemTraTonTai(string MaHoSo)
        {
            try
            {
                long _maHoSo = long.Parse(MaHoSo);
                tblXacNhanCoQuanDangKyDatDai kq = (from n in db.tblXacNhanCoQuanDangKyDatDais
                                                   where n.MaHoSo == _maHoSo
                                                   select n).SingleOrDefault();
                if (kq != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool ThemXacNhanCoQuanDangKy(string MaHoSo, string NgayKiemtra, string NguoiKiemTra, string ChucVuNguoiKiemTra, string NoiDungYKien, string GhiChu, string NgayKy, string GiamDoc)
        {
            try
            {
                tblXacNhanCoQuanDangKyDatDai kq = new tblXacNhanCoQuanDangKyDatDai();
                kq.MaHoSo = long.Parse(MaHoSo);
                kq.NgayKiemTra = Convert.ToDateTime(NgayKiemtra);
                kq.NguoiKiemTra = NguoiKiemTra;
                kq.ChucVuNguoiKiemTra = ChucVuNguoiKiemTra;
                kq.NoiDungYKien = NoiDungYKien;
                kq.GhiChu = GhiChu;
                if(NgayKy.Trim() != "")
                kq.NgayKy = Convert.ToDateTime(NgayKy);
                kq.GiamDoc = GiamDoc;

                db.tblXacNhanCoQuanDangKyDatDais.Add(kq);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SuaXacNhanCoQuanDangKy(string MaHoSo, string NgayKiemtra, string NguoiKiemTra, string ChucVuNguoiKiemTra, string NoiDungYKien, string GhiChu, string NgayKy, string GiamDoc)
        {
            try
            {
                long _maHoSo = long.Parse(MaHoSo);
                tblXacNhanCoQuanDangKyDatDai kq = db.tblXacNhanCoQuanDangKyDatDais.Single(n => n.MaHoSo == _maHoSo);
                
                kq.NgayKiemTra = Convert.ToDateTime(NgayKiemtra);
                kq.NguoiKiemTra = NguoiKiemTra;
                kq.ChucVuNguoiKiemTra = ChucVuNguoiKiemTra;
                kq.NoiDungYKien = NoiDungYKien;
                kq.GhiChu = GhiChu;
                if(NgayKy.Trim() != "")
                kq.NgayKy = Convert.ToDateTime(NgayKy);
                kq.GiamDoc = GiamDoc;

               
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool XoaXacNhanCoQuanDangKy(string MaHoSo)
        {
            try
            {
                long _maHoSo = long.Parse(MaHoSo);
                tblXacNhanCoQuanDangKyDatDai kq = db.tblXacNhanCoQuanDangKyDatDais.Single(n => n.MaHoSo == _maHoSo);

                db.tblXacNhanCoQuanDangKyDatDais.Remove(kq);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}