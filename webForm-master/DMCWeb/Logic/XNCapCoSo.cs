using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMCWeb.Models;

namespace DMCWeb.Logic
{
    public class XNCapCoSo
    {
        DMCWebEntities db = new DMCWebEntities();
        public tblXacNhanCapCoSo result(string MaHoSo)
        {
            try
            {
                long _maHoSo = long.Parse(MaHoSo);
                return db.tblXacNhanCapCoSoes.Single(n=>n.MaHoSo == _maHoSo);
                                      
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool KiemTraCoXacNhanChua(string MaHoSo)
        {
            try
            {
                long _maHoSo = long.Parse(MaHoSo);
                var rs = db.tblXacNhanCapCoSoes.Select(n => n.MaHoSo == _maHoSo);
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
        public bool TaoXacNhanCapCoSo(string MaHoSo, string NoiDungKeKhaiSoVoiHienTai, string NguonGocSuDungDat, string ThoiDiemSuDungDatVaoMucDichDangKy, string ThoiDiemTaoLapTaiSanGanLienVoiDat, string TinhTrangTranhChapDatDaiVaTaiSan, string SuPhuHopVoiQuyHoachSuDungDatVaQuyHoachXayDung, string NoiDungKhac, string DiaChinh_NgayXacNhan, string UBND_NgayXacNhan, string DiaChinh_TieuDeKy, string UBND_TieuDeKy, string DiaChinh_NguoiKy, string UBND_NguoiKy)
        {
            try
            {
                tblXacNhanCapCoSo xacnhan = new tblXacNhanCapCoSo();
                xacnhan.MaHoSo = long.Parse(MaHoSo);
                xacnhan.NoiDungKeKhaiSoVoiHienTrang = NoiDungKeKhaiSoVoiHienTai;
                xacnhan.NguonGocSuDungDat = NguonGocSuDungDat;
                xacnhan.ThoiDiemSuDungDatVaoMucDichDangKy =Convert.ToDateTime( ThoiDiemSuDungDatVaoMucDichDangKy);
                xacnhan.ThoiDiemTaoLapTaiSanGanLienVoiDat =Convert.ToDateTime( ThoiDiemTaoLapTaiSanGanLienVoiDat);
                xacnhan.TinhTrangTranhChapDatDaiVaTaiSan = TinhTrangTranhChapDatDaiVaTaiSan;
                xacnhan.SuPhuHopVoiQuyHoachSuDungDatVaQuyHoachXayDung = SuPhuHopVoiQuyHoachSuDungDatVaQuyHoachXayDung;
                xacnhan.NoiDungKhac = NoiDungKhac;
                xacnhan.DiaChinh_NgayXacNhan =Convert.ToDateTime( DiaChinh_NgayXacNhan);
                xacnhan.UBND_NgayKy =Convert.ToDateTime( UBND_NgayXacNhan);
                xacnhan.DiaChinh_TieuDeKy = DiaChinh_TieuDeKy;
                xacnhan.UBND_TieuDeKy = UBND_TieuDeKy;
                xacnhan.DiaChinh_CanBo = DiaChinh_NguoiKy;
                xacnhan.UBND_NguoiKy = UBND_NguoiKy;

                db.tblXacNhanCapCoSoes.Add(xacnhan);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false; 
            }

        }

        public bool SuaXacNhanCapCoSo(string MaHoSo, string NoiDungKeKhaiSoVoiHienTai, string NguonGocSuDungDat, string ThoiDiemSuDungDatVaoMucDichDangKy, string ThoiDiemTaoLapTaiSanGanLienVoiDat, string TinhTrangTranhChapDatDaiVaTaiSan, string SuPhuHopVoiQuyHoachSuDungDatVaQuyHoachXayDung, string NoiDungKhac, string DiaChinh_NgayXacNhan, string UBND_NgayXacNhan, string DiaChinh_TieuDeKy, string UBND_TieuDeKy, string DiaChinh_NguoiKy, string UBND_NguoiKy)
        {
            try
            {
                long _maHoSo = long.Parse(MaHoSo);
                tblXacNhanCapCoSo xacnhan = db.tblXacNhanCapCoSoes.Single(x=>x.MaHoSo ==_maHoSo);
                
                xacnhan.NoiDungKeKhaiSoVoiHienTrang = NoiDungKeKhaiSoVoiHienTai;
                xacnhan.NguonGocSuDungDat = NguonGocSuDungDat;
                xacnhan.ThoiDiemSuDungDatVaoMucDichDangKy = Convert.ToDateTime(ThoiDiemSuDungDatVaoMucDichDangKy);
                xacnhan.ThoiDiemTaoLapTaiSanGanLienVoiDat = Convert.ToDateTime(ThoiDiemTaoLapTaiSanGanLienVoiDat);
                xacnhan.TinhTrangTranhChapDatDaiVaTaiSan = TinhTrangTranhChapDatDaiVaTaiSan;
                xacnhan.SuPhuHopVoiQuyHoachSuDungDatVaQuyHoachXayDung = SuPhuHopVoiQuyHoachSuDungDatVaQuyHoachXayDung;
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
        public bool XoaXacNhanCapCoSo(string MaHoSo)
        {
            try
            {
                long _maHoSo = long.Parse(MaHoSo);
                var xacnhandel = from n in db.tblXacNhanCapCoSoes
                                 where n.MaHoSo == _maHoSo
                                 select n;
                db.tblXacNhanCapCoSoes.RemoveRange(xacnhandel);
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