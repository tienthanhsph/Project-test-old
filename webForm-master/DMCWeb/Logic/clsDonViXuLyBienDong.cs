using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMCWeb.Models;
namespace DMCWeb.Logic
{
    public class clsDonViXuLyBienDong
    {
        DMCWebEntities db = new DMCWebEntities();

        #region "cấp cơ sở"
        public tblXacNhanCapCoSoVeBienDong LayXacNhanCapCoSo(string MaDangKyBienDong)
        {
            
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblXacNhanCapCoSoVeBienDong xacnhan = db.tblXacNhanCapCoSoVeBienDongs.SingleOrDefault(n => n.MaDangKyBienDong == _maBD);
                return xacnhan;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool KiemTraCoXacNhanChua(string MaDangKyBienDong)
        {
            try
            {
                long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                var rs = db.tblXacNhanCapCoSoVeBienDongs.Select(n => n.MaDangKyBienDong == _MaDangKyBienDong);
                if (rs.Count() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool TaoXacNhanCapCoSo(string MaDangKyBienDong, string NoiDungXacNhan, string NoiDungKhac, string DiaChinh_NgayXacNhan, string UBND_NgayXacNhan, string DiaChinh_TieuDeKy, string UBND_TieuDeKy, string DiaChinh_NguoiKy, string UBND_NguoiKy)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblXacNhanCapCoSoVeBienDong xacnhan = new tblXacNhanCapCoSoVeBienDong();
                xacnhan.MaDangKyBienDong = _maBD;
                xacnhan.NoiDungXacNhan = NoiDungXacNhan;
                xacnhan.NoiDungKhac = NoiDungKhac;
                xacnhan.DiaChinh_NgayXacNhan = Convert.ToDateTime(DiaChinh_NgayXacNhan);
                xacnhan.UBND_NgayKy = Convert.ToDateTime(UBND_NgayXacNhan);
                xacnhan.DiaChinh_TieuDeKy = DiaChinh_TieuDeKy;
                xacnhan.UBND_TieuDeKy = UBND_TieuDeKy;
                xacnhan.DiaChinh_CanBo = DiaChinh_NguoiKy;
                xacnhan.UBND_NguoiKy = UBND_NguoiKy;

                db.tblXacNhanCapCoSoVeBienDongs.Add(xacnhan);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool SuaXacNhanCapCoSo(string MaDangKyBienDong, string NoiDungXacNhan, string NoiDungKhac, string DiaChinh_NgayXacNhan, string UBND_NgayXacNhan, string DiaChinh_TieuDeKy, string UBND_TieuDeKy, string DiaChinh_NguoiKy, string UBND_NguoiKy)
        {
            try
            {
                long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                tblXacNhanCapCoSoVeBienDong xacnhan = db.tblXacNhanCapCoSoVeBienDongs.SingleOrDefault(x => x.MaDangKyBienDong == _MaDangKyBienDong);

                xacnhan.NoiDungXacNhan = NoiDungXacNhan;
                xacnhan.NoiDungKhac = NoiDungKhac;
                xacnhan.DiaChinh_NgayXacNhan = Convert.ToDateTime(DiaChinh_NgayXacNhan);
                xacnhan.UBND_NgayKy = Convert.ToDateTime(UBND_NgayXacNhan);
                xacnhan.DiaChinh_TieuDeKy = DiaChinh_TieuDeKy;
                xacnhan.UBND_TieuDeKy = UBND_TieuDeKy;
                xacnhan.DiaChinh_CanBo = DiaChinh_NguoiKy;
                xacnhan.UBND_NguoiKy = UBND_NguoiKy;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool XoaXacNhanCapCoSo(string MaDangKyBienDong)
        {
            try
            {
                long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                var xacnhandel = from n in db.tblXacNhanCapCoSoVeBienDongs
                                 where n.MaDangKyBienDong == _MaDangKyBienDong
                                 select n;
                db.tblXacNhanCapCoSoVeBienDongs.RemoveRange(xacnhandel);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        #endregion

        #region "cơ quan đăng ký đất đai"
        public tblYKienCoQuanDangKyDatDaiVeBienDong result(string MaDangKyBienDong)
        {
            long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
            try
            {
                return db.tblYKienCoQuanDangKyDatDaiVeBienDongs.SingleOrDefault(n => n.MaDangKyBienDong == _MaDangKyBienDong);
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool KiemTraTonTai(string MaDangKyBienDong)
        {
            try
            {
                long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                tblYKienCoQuanDangKyDatDaiVeBienDong kq = (from n in db.tblYKienCoQuanDangKyDatDaiVeBienDongs
                                                   where n.MaDangKyBienDong == _MaDangKyBienDong
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
        public bool ThemXacNhanCoQuanDangKy(string MaDangKyBienDong, string NgayKiemtra, string NguoiKiemTra, string ChucVuNguoiKiemTra, string NoiDungYKien, string GhiChu, string NgayKy, string GiamDoc)
        {
            try
            {

                tblYKienCoQuanDangKyDatDaiVeBienDong kq = new tblYKienCoQuanDangKyDatDaiVeBienDong();
                kq.MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                kq.NgayKiemTra = Convert.ToDateTime(NgayKiemtra);
                kq.NguoiKiemTra = NguoiKiemTra;
                kq.ChucVuNguoiKiemTra = ChucVuNguoiKiemTra;
                kq.NoiDungYKien = NoiDungYKien;
                kq.GhiChu = GhiChu;
                if (NgayKy.Trim() != "")
                    kq.NgayKy = Convert.ToDateTime(NgayKy);
                kq.GiamDoc = GiamDoc;

                db.tblYKienCoQuanDangKyDatDaiVeBienDongs.Add(kq);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SuaXacNhanCoQuanDangKy(string MaDangKyBienDong, string NgayKiemtra, string NguoiKiemTra, string ChucVuNguoiKiemTra, string NoiDungYKien, string GhiChu, string NgayKy, string GiamDoc)
        {
            try
            {
                long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                tblYKienCoQuanDangKyDatDaiVeBienDong kq = db.tblYKienCoQuanDangKyDatDaiVeBienDongs.SingleOrDefault(n => n.MaDangKyBienDong == _MaDangKyBienDong);

                kq.NgayKiemTra = Convert.ToDateTime(NgayKiemtra);
                kq.NguoiKiemTra = NguoiKiemTra;
                kq.ChucVuNguoiKiemTra = ChucVuNguoiKiemTra;
                kq.NoiDungYKien = NoiDungYKien;
                kq.GhiChu = GhiChu;
                if (NgayKy.Trim() != "")
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
        public bool XoaXacNhanCoQuanDangKy(string MaDangKyBienDong)
        {
            try
            {
                long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                tblYKienCoQuanDangKyDatDaiVeBienDong kq = db.tblYKienCoQuanDangKyDatDaiVeBienDongs.SingleOrDefault(n => n.MaDangKyBienDong == _MaDangKyBienDong);

                db.tblYKienCoQuanDangKyDatDaiVeBienDongs.Remove(kq);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion

        #region "cơ quan tài nguyên và môi trường"
        public tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDong resultTNMT(string MaDangKyBienDong)
        {
            long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
            try
            {
                return db.tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDongs.SingleOrDefault(n => n.MaDangKyBienDong == _MaDangKyBienDong);
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool KiemTraTonTaiTNMT(string MaDangKyBienDong)
        {
            try
            {
                long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDong kq = (from n in db.tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDongs
                                                           where n.MaDangKyBienDong == _MaDangKyBienDong
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
        public bool ThemXacNhanCoQuanTNMT(string MaDangKyBienDong, string NgayKiemtra, string NguoiKiemTra, /*string ChucVuNguoiKiemTra,*/ string NoiDungYKien, string GhiChu, string NgayKy, string ThuTruong)
        {
            try
            {
                tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDong kq = new tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDong();
                kq.MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                kq.NgayKiemTra = Convert.ToDateTime(NgayKiemtra);
                kq.NguoiKiemTra = NguoiKiemTra;
                //kq.ChucVuNguoiKiemTra = ChucVuNguoiKiemTra;
                kq.NoiDungYKien = NoiDungYKien;
                kq.GhiChu = GhiChu;
                if (NgayKy.Trim() != "")
                    kq.NgayKy = Convert.ToDateTime(NgayKy);
                kq.ThuTruongCoQuanKy = ThuTruong;

                db.tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDongs.Add(kq);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SuaXacNhanCoQuanTNMT(string MaDangKyBienDong, string NgayKiemtra, string NguoiKiemTra,/* string ChucVuNguoiKiemTra, */string NoiDungYKien, string GhiChu, string NgayKy, string ThuTruong)
        {
            try
            {
                long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDong kq = db.tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDongs.SingleOrDefault(n => n.MaDangKyBienDong == _MaDangKyBienDong);

                kq.NgayKiemTra = Convert.ToDateTime(NgayKiemtra);
                kq.NguoiKiemTra = NguoiKiemTra;
                //kq.ChucVuNguoiKiemTra = ChucVuNguoiKiemTra;
                kq.NoiDungYKien = NoiDungYKien;
                kq.GhiChu = GhiChu;
                if (NgayKy.Trim() != "")
                    kq.NgayKy = Convert.ToDateTime(NgayKy);
                kq.ThuTruongCoQuanKy = ThuTruong;


                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool XoaXacNhanCoQuanTNMT(string MaDangKyBienDong)
        {
            try
            {
                long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDong kq = db.tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDongs.SingleOrDefault(n => n.MaDangKyBienDong == _MaDangKyBienDong);

                db.tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDongs.Remove(kq);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion
    }

}