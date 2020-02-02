using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMCWeb.Models;

namespace DMCWeb.Logic
{
    public class XuLyDangKyBienDong
    {
        DMCWebEntities db = new DMCWebEntities();

        public string TaoDonDangKyBienDongDuBi()
        {
            tblDonXinDangKyBienDongDuBi donmoi = new tblDonXinDangKyBienDongDuBi();
            donmoi.NgayTaoDon = DateTime.Today;

            db.tblDonXinDangKyBienDongDuBis.Add(donmoi);
            db.SaveChanges();

            return donmoi.ID.ToString();
        }
        public tblDonXinDangKyBienDongDuBi LayDonDuBi(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblDonXinDangKyBienDongDuBi result = db.tblDonXinDangKyBienDongDuBis.SingleOrDefault(n => n.ID == _maBD);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public tblDonXinDangKyBienDong LayDon(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblDonXinDangKyBienDong result = db.tblDonXinDangKyBienDongs.SingleOrDefault(n => n.MaDangKyBienDong == _maBD);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool LuuThongTinDangKyBienDongDuBi(string MaDangKyBienDong, string TieuDeDon, string NgayVietDon, string SoVaoSoCapGCN, string SoPhatHanhGCN, string NgayCapGCN, string BienDongVe, string NoiDungGhiTrenGCNTruocKhiBienDong, string NoiDungSauBienDong, string LyDoBienDong, string TinhHinhThucHienNghiaVuTaiChinh, string GiayToKemTheo, string LoaiBienDong, string LoaiDoiTuongApDung, string DonViHanhChinh)
        { 
            try 
	        {	        
		        long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                tblDonXinDangKyBienDongDuBi don = db.tblDonXinDangKyBienDongDuBis.SingleOrDefault(n=> n.ID== _MaDangKyBienDong);

                if(TieuDeDon != "")
                    don.TieuDeDon = TieuDeDon;
                if(NgayVietDon != "")
                    don.NgayVietDon=Convert.ToDateTime( NgayVietDon);
                if(SoVaoSoCapGCN != "")
                    don.SoVaoSoCapGCN=SoVaoSoCapGCN;
                if (SoPhatHanhGCN != "")
                    don.SoPhatHanhGCN = SoPhatHanhGCN;
                if (NgayCapGCN != "")
                    don.NgayCapGCN = Convert.ToDateTime(NgayCapGCN);
                if (BienDongVe != "")
                    don.BienDongVe = BienDongVe;
                if (NoiDungGhiTrenGCNTruocKhiBienDong != "")
                    don.NoiDungGhiTrenGCNTruocKhiBienDong = NoiDungGhiTrenGCNTruocKhiBienDong;
                if (NoiDungSauBienDong != "")
                    don.NoiDungSauKhiBienDong = NoiDungSauBienDong;
                if (LyDoBienDong != "")
                    don.LyDoBienDong = LyDoBienDong;
                if (TinhHinhThucHienNghiaVuTaiChinh != "")
                    don.TinhHinhThucHienNghiaVuTaiChinh = TinhHinhThucHienNghiaVuTaiChinh;
                if (GiayToKemTheo != "")
                    don.GiayToKemTheo = GiayToKemTheo;
                if (LoaiBienDong != "")
                    don.LoaiBienDong = LoaiBienDong;
                if (LoaiDoiTuongApDung != "")
                    don.LoaiDoiTuongApDung = LoaiDoiTuongApDung;
                if (DonViHanhChinh != "")
                    don.DonViHanhChinh = DonViHanhChinh;

                db.SaveChanges();

                return true;
                
	        }
	        catch (Exception)
	        {
		
		       return false;
	        }
       

        }

        public bool LuuThongTinDangKyBienDong(string MaDangKyBienDong, string TieuDeDon, string NgayVietDon, string SoVaoSoCapGCN, string SoPhatHanhGCN, string NgayCapGCN, string BienDongVe, string NoiDungGhiTrenGCNTruocKhiBienDong, string NoiDungSauBienDong, string LyDoBienDong, string TinhHinhThucHienNghiaVuTaiChinh, string GiayToKemTheo, string LoaiBienDong, string LoaiDoiTuongApDung, string DonViHanhChinh)
        {
            try
            {
                long _MaDangKyBienDong = long.Parse(MaDangKyBienDong);
                tblDonXinDangKyBienDong don = db.tblDonXinDangKyBienDongs.SingleOrDefault(n => n.MaDangKyBienDong == _MaDangKyBienDong);

                if (TieuDeDon != "")
                    don.KinhGuiCoQuanChucNang = TieuDeDon;
                if (NgayVietDon != "")
                    don.NgayVietDon = Convert.ToDateTime(NgayVietDon);
                if (SoVaoSoCapGCN != "")
                    don.SoVaoSoCapGCN = SoVaoSoCapGCN;
                if (SoPhatHanhGCN != "")
                    don.SoPhatHanhGCN = SoPhatHanhGCN;
                if (NgayCapGCN != "")
                    don.NgayCapGCN = Convert.ToDateTime(NgayCapGCN);
                if (BienDongVe != "")
                    don.BienDongVe = BienDongVe;
                if (NoiDungGhiTrenGCNTruocKhiBienDong != "")
                    don.NoiDungGhiTrenGCNTruocKhiBienDong = NoiDungGhiTrenGCNTruocKhiBienDong;
                if (NoiDungSauBienDong != "")
                    don.NoiDungSauKhiBienDong = NoiDungSauBienDong;
                if (LyDoBienDong != "")
                    don.LyDoBienDong = LyDoBienDong;
                if (TinhHinhThucHienNghiaVuTaiChinh != "")
                    don.TinhHinhThucHienNghiaVuTaiChinh = TinhHinhThucHienNghiaVuTaiChinh;
                if (GiayToKemTheo != "")
                    don.GiayToKemTheo = GiayToKemTheo;
                if (LoaiBienDong != "")
                    don.LoaiBienDong = LoaiBienDong;
                if (LoaiDoiTuongApDung != "")
                    don.LoaiDoiTuongApDung = LoaiDoiTuongApDung;
                if (DonViHanhChinh != "")
                    don.DonViHanhChinh = DonViHanhChinh;

                db.SaveChanges();

                return true;

            }
            catch (Exception)
            {

                return false;
            }


        }
        public bool LuuThongTinGuiNhanHoSo(string MaDangKyBienDong, bool HoSoChinhThuc, string KinhGui, string NguoiVietDon, string NgayVietDon, string NguoiNhanDon, string NgayNhanDon, string SoTiepNhan, string Quyen)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                if (HoSoChinhThuc)
                {
                    tblDonXinDangKyBienDong don = db.tblDonXinDangKyBienDongs.Single(n => n.MaDangKyBienDong == _maBD);
                    don.KinhGuiCoQuanChucNang = KinhGui;
                    don.NguoiVietDon = NguoiVietDon;
                    don.NgayVietDon = Convert.ToDateTime( NgayVietDon);
                    don.NguoiNhanHoSo = NguoiNhanDon;
                    don.NgayNhanHoSo = Convert.ToDateTime(NgayNhanDon);
                    don.SoTiepNhan = SoTiepNhan;
                    don.Quyen = Quyen;
                    db.SaveChanges();
                }
                else
                {
                    tblDonXinDangKyBienDongDuBi don = db.tblDonXinDangKyBienDongDuBis.Single(n => n.ID == _maBD);
                    don.TieuDeDon = KinhGui;
                    don.NguoiVietDon = NguoiVietDon;
                    don.NgayVietDon = Convert.ToDateTime(NgayVietDon);

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public tblDonXinDangKyBienDongDuBi XemDonDangKyBienDongDuBi(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblDonXinDangKyBienDongDuBi don = db.tblDonXinDangKyBienDongDuBis.SingleOrDefault(n => n.ID == _maBD);
                return don;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public tblDonXinDangKyBienDong XemDonDangKyBienDong(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblDonXinDangKyBienDong don = db.tblDonXinDangKyBienDongs.SingleOrDefault(n => n.MaDangKyBienDong == _maBD);
                return don;
            }
            catch (Exception)
            {

                return null;
            }
        }
#region "xóa biến động và những dữ liệu liên quan đến nó"
        public bool XoaDuLieuBienDongDuBi(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblDonXinDangKyBienDongDuBi don = db.tblDonXinDangKyBienDongDuBis.SingleOrDefault(n => n.ID == _maBD);
                if(don != null)
                {
                    db.tblDonXinDangKyBienDongDuBis.Remove(don);
                }
                IEnumerable<tblThuaDatThayDoiTrongBienDongDuBi> dstdtd = (from n in db.tblThuaDatThayDoiTrongBienDongDuBis
                                                                            where n.MaDangKyBienDong == _maBD
                                                                            select n).ToList();
                if(dstdtd!= null)
                {
                    if(dstdtd.Count() >0)
                    db.tblThuaDatThayDoiTrongBienDongDuBis.RemoveRange(dstdtd);
                }
                IEnumerable<tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBi> dsts = (from n in db.tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBis
                                                                                    where n.MaDangKyBienDong == _maBD
                                                                                    select n).ToList();
                if (dsts != null)
                {
                    if (dsts.Count() > 0) {
                        db.tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBis.RemoveRange(dsts);
                    }
                }
                tblThuaDatDeNghiTachThuaTrongBienDongTheoDon tdtt = db.tblThuaDatDeNghiTachThuaTrongBienDongTheoDons.SingleOrDefault(n => n.MaDangKyBienDong == _maBD);
                if (tdtt != null)
                {
                    db.tblThuaDatDeNghiTachThuaTrongBienDongTheoDons.Remove(tdtt);
                }
                IEnumerable<tblThuaDatDeNghiHopThuaTrongBienDongTheoDon> dstdht = (from n in db.tblThuaDatDeNghiHopThuaTrongBienDongTheoDons
                                                                                      where n.MaDangKyBienDong == _maBD
                                                                                      select n).ToList();
                if(dstdht!= null)
                {
                    if(dstdht.Count()>0)
                    {
                        db.tblThuaDatDeNghiHopThuaTrongBienDongTheoDons.RemoveRange(dstdht);
                       
                    }
                }

                List<tblChuDangKyBienDongDuBi> dschs= ( from chs in db.tblChuDangKyBienDongDuBis
                                                                   where chs.MaDangKyBienDong == _maBD
                                                                   select chs).ToList();
                if (dschs != null)
                {
                    if (dschs.Count() > 0)
                    {
                        for (int i = 0; i < dschs.Count(); i++)
                        {
                            long _maChu =(long)dschs[i].MaChu;
                            tblChuDuBi chdb = db.tblChuDuBis.SingleOrDefault(n => n.MaChu == _maChu);
                            if(chdb != null)
                            {
                                db.tblChuDuBis.Remove(chdb);
                               
                            }

                            db.tblChuDangKyBienDongDuBis.Remove(dschs[i]);
                            
                        }
                    }
                }


                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
#endregion        
        #region "Chu"
        public bool ThemChu(bool HoSoChinhThuc, string MaHoSo, string Machu)
        {
            try
            {
                long _maDangKyBienDong = long.Parse(MaHoSo);
                long _maChu = long.Parse(Machu);
                if (HoSoChinhThuc)
                {
                    tblChu chu = db.tblChus.SingleOrDefault(n => n.MaChu == _maChu);
                    if(chu != null)
                    {
                        tblChuDangKyBienDong chuhoso = new tblChuDangKyBienDong();
                        chuhoso.MaChu = _maChu;
                        chuhoso.MaDangKyBienDong = _maDangKyBienDong;
                        db.tblChuDangKyBienDongs.Add(chuhoso);
                        db.SaveChanges();
                    }
                }
                else
                {
                    tblChuDuBi chu = db.tblChuDuBis.SingleOrDefault(n => n.MaChu == _maChu);
                    if (chu != null)
                    {
                        tblChuDangKyBienDongDuBi chuhoso = new tblChuDangKyBienDongDuBi();
                        chuhoso.MaChu = _maChu;
                        chuhoso.MaDangKyBienDong = _maDangKyBienDong;
                        db.tblChuDangKyBienDongDuBis.Add(chuhoso);
                        db.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool ThemChu(bool HoSoChinhThuc, string MaHoSo, string DanhXung, string HoTen, string NamSinh, string DiaChi, string DinhDanh, string SoDinhDanh, string NoiCap, string NgayCap, string QuocTich)
        {
            try
            {
                if (HoSoChinhThuc)
                {
                    tblChu chumoi = new tblChu();

                    chumoi.DanhXung = DanhXung;
                    chumoi.HoTen = HoTen;
                    chumoi.NamSinh = NamSinh;
                    chumoi.DiaChi = DiaChi;
                    chumoi.DinhDanh = DinhDanh;
                    chumoi.SoDinhDanh = SoDinhDanh;
                    chumoi.NoiCap = NoiCap;
                    chumoi.NgayCap = Convert.ToDateTime(NgayCap);
                    chumoi.QuocTich = QuocTich;

                    db.tblChus.Add(chumoi);
                    db.SaveChanges();

                    tblChuDangKyBienDong chuhoso = new tblChuDangKyBienDong();
                    chuhoso.MaChu = chumoi.MaChu;
                    chuhoso.MaDangKyBienDong = Convert.ToInt32(MaHoSo);
                    db.tblChuDangKyBienDongs.Add(chuhoso);
                    db.SaveChanges();
                }
                else
                {
                    tblChuDuBi chumoi = new tblChuDuBi();
                    chumoi.DanhXung = DanhXung;
                    chumoi.HoTen = HoTen;
                    chumoi.NamSinh = NamSinh;
                    chumoi.DiaChi = DiaChi;
                    chumoi.DinhDanh = DinhDanh;
                    chumoi.SoDinhDanh = SoDinhDanh;
                    chumoi.NoiCap = NoiCap;
                    if(NgayCap!="")
                    chumoi.NgayCap = Convert.ToDateTime(NgayCap);
                    chumoi.QuocTich = QuocTich;
                    db.tblChuDuBis.Add(chumoi);
                    db.SaveChanges();

                    tblChuDangKyBienDongDuBi chuhoso = new tblChuDangKyBienDongDuBi();
                    chuhoso.MaChu = chumoi.MaChu;
                    chuhoso.MaDangKyBienDong = Convert.ToInt32(MaHoSo);
                    db.tblChuDangKyBienDongDuBis.Add(chuhoso);
                    db.SaveChanges();

                }
                

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool SuaChu(bool HoSoChinhThuc,string MaChu, string DanhXung, string HoTen, string NamSinh, string DiaChi, string DinhDanh, string SoDinhDanh, string NoiCap, string NgayCap, string QuocTich)
        {
            try
            {
                long _maChu = long.Parse(MaChu);
                if (HoSoChinhThuc)
                {
                    tblChu chucansua = db.tblChus.Single(c => c.MaChu == _maChu);
                    chucansua.DanhXung = DanhXung;
                    chucansua.HoTen = HoTen;
                    chucansua.NamSinh = NamSinh;
                    chucansua.DiaChi = DiaChi;
                    chucansua.DinhDanh = DinhDanh;
                    chucansua.SoDinhDanh = SoDinhDanh;
                    chucansua.NoiCap = NoiCap;
                    chucansua.NgayCap = Convert.ToDateTime(NgayCap);
                    chucansua.QuocTich = QuocTich;

                    db.SaveChanges();
                }
                else
                {                    
                    tblChuDuBi chucansua = db.tblChuDuBis.Single(c => c.MaChu == _maChu);
                    chucansua.DanhXung = DanhXung;
                    chucansua.HoTen = HoTen;
                    chucansua.NamSinh = NamSinh;
                    chucansua.DiaChi = DiaChi;
                    chucansua.DinhDanh = DinhDanh;
                    chucansua.SoDinhDanh = SoDinhDanh;
                    chucansua.NoiCap = NoiCap;
                    chucansua.NgayCap = Convert.ToDateTime(NgayCap);
                    chucansua.QuocTich = QuocTich;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool XoaChu(bool HoSoChinhThuc,string MaChu)
        {
            try
            {
                long _maChu = long.Parse(MaChu);
                if (HoSoChinhThuc)
                {
                    tblChu chucanxoa = db.tblChus.Single(c => c.MaChu == _maChu);
                    db.tblChus.Remove(chucanxoa);

                    db.SaveChanges();

                }
                else
                {
                    tblChuDuBi chucanxoa = db.tblChuDuBis.Single(c => c.MaChu == _maChu);
                    db.tblChuDuBis.Remove(chucanxoa);

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool CapNhatLoaiDoiTuong(string MaDon, string MaLoaiDoiTuong)
        {
            try
            {

                long _maDon = long.Parse(MaDon);
                tblDonXinDangKyBienDongDuBi DonDK = db.tblDonXinDangKyBienDongDuBis.Single(h => h.ID == _maDon);
                DonDK.LoaiDoiTuongApDung = MaLoaiDoiTuong;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public List<tblChu> dsChu(string MaDangKyBienDong)
        {

            if (MaDangKyBienDong == "0" || MaDangKyBienDong == "")
                return null;
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                var ds = from c in db.tblChus join
                             n in db.tblChuDangKyBienDongs on c.MaChu equals n.MaChu
                         where n.MaDangKyBienDong == _maBD
                         select c;
                return ds.ToList<tblChu>();
            }
            catch (Exception)
            {
                return null;
            }

        }
        public List<tblChuDuBi> dsChuDuBi(string MaDangKyBienDong)
        {

            if (MaDangKyBienDong == "0" || MaDangKyBienDong == "")
                return null;
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                var ds = from n in db.tblChuDuBis 
                         join chs in db.tblChuDangKyBienDongDuBis on n.MaChu equals chs.MaChu
                          
                         where chs.MaDangKyBienDong == _maBD
                         select n;
                
                return ds.ToList<tblChuDuBi>();
            }
            catch (Exception)
            {
                return null;
            }

        }
#endregion

        #region" thực hiện với bảng  ThongTinThuaDatCoThayDoi"
        public List<tblThuaDatThayDoiTrongBienDongDuBi> dsThuaDatThayDoiDuBi(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                var dsThua = from t in db.tblThuaDatThayDoiTrongBienDongDuBis
                             where t.MaDangKyBienDong == _maBD
                             select t;
                return dsThua.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<tblThuaDatThayDoiTrongBienDong> dsThuaDatThayDoi(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                var dsThua = from t in db.tblThuaDatThayDoiTrongBienDongs
                             where t.MaDangKyBienDong == _maBD
                             select t;
                return dsThua.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool ThemThuaDatThayDoiTrongBienDongDuBi(string MaDangKyBienDong, string ToBanDo, string SoThua, string DienTich, string NoiDungKhac, string ToBanDo2, string SoThua2, string DienTich2, string NoiDungThayDoiKhac2)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblThuaDatThayDoiTrongBienDongDuBi thuamoi = new tblThuaDatThayDoiTrongBienDongDuBi();
                thuamoi.MaDangKyBienDong = _maBD;
                thuamoi.ToBanDo = ToBanDo;
                thuamoi.SoThua = SoThua;
                thuamoi.DienTich = DienTich;
                thuamoi.NoiDungThayDoiKhac = NoiDungKhac;

                thuamoi.ToBanDoMoi = ToBanDo2;
                thuamoi.SoThuaMoi = SoThua2;
                thuamoi.DienTichMoi = DienTich2;
                thuamoi.NoiDungThayDoiKhacMoi = NoiDungThayDoiKhac2;

                db.tblThuaDatThayDoiTrongBienDongDuBis.Add(thuamoi);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
         public bool ThemThuaDatThayDoiTrongBienDong(string MaDangKyBienDong, string ToBanDo, string SoThua, string DienTich, string NoiDungKhac, string ToBanDo2, string SoThua2, string DienTich2, string NoiDungThayDoiKhac2)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblThuaDatThayDoiTrongBienDong thuamoi = new tblThuaDatThayDoiTrongBienDong();
                thuamoi.MaDangKyBienDong = _maBD;
                thuamoi.ToBanDo = ToBanDo;
                thuamoi.SoThua = SoThua;
                thuamoi.DienTich = DienTich;
                thuamoi.NoiDungThayDoiKhac = NoiDungKhac;

                thuamoi.ToBanDoMoi = ToBanDo2;
                thuamoi.SoThuaMoi = SoThua2;
                thuamoi.DienTichMoi = DienTich2;
                thuamoi.NoiDungThayDoiKhacMoi = NoiDungThayDoiKhac2;

                db.tblThuaDatThayDoiTrongBienDongs.Add(thuamoi);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
         public bool ThemThuaDatThayDoiTrongBienDongDuBi(string MaDangKyBienDong, string MaSoThuaDat, string NoiDungKhac)
        {
            try
            {
                long _maTD = long.Parse(MaSoThuaDat);
                tblThuaDat ThuaGoc = db.tblThuaDats.SingleOrDefault(n => n.MaThuaDat == _maTD);
                if (ThuaGoc != null)
                {
                    long _maBD = long.Parse(MaDangKyBienDong);
                    tblThuaDatThayDoiTrongBienDongDuBi thuamoi = new tblThuaDatThayDoiTrongBienDongDuBi();
                    thuamoi.MaDangKyBienDong = _maBD;
                    thuamoi.ToBanDo = ThuaGoc.ToBanDo;
                    thuamoi.SoThua = ThuaGoc.SoThua;
                    thuamoi.DienTich = ThuaGoc.DienTich;
                    thuamoi.NoiDungThayDoiKhac = NoiDungKhac;

                    db.tblThuaDatThayDoiTrongBienDongDuBis.Add(thuamoi);
                    db.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool ThemThuaDatThayDoiTrongBienDong(string MaDangKyBienDong, string MaSoThuaDat, string NoiDungKhac)
        {
            try
            {
                long _maTD = long.Parse(MaSoThuaDat);
                tblThuaDat ThuaGoc = db.tblThuaDats.SingleOrDefault(n => n.MaThuaDat == _maTD);
                if (ThuaGoc != null)
                {
                    long _maBD = long.Parse(MaDangKyBienDong);
                    tblThuaDatThayDoiTrongBienDong thuamoi = new tblThuaDatThayDoiTrongBienDong();
                    thuamoi.MaDangKyBienDong = _maBD;
                    thuamoi.ToBanDo = ThuaGoc.ToBanDo;
                    thuamoi.SoThua = ThuaGoc.SoThua;
                    thuamoi.DienTich = ThuaGoc.DienTich;
                    thuamoi.NoiDungThayDoiKhac = NoiDungKhac;

                    db.tblThuaDatThayDoiTrongBienDongs.Add(thuamoi);
                    db.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public tblThuaDatThayDoiTrongBienDongDuBi ThuaDuBiDangXet(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatThayDoiTrongBienDongDuBi result = db.tblThuaDatThayDoiTrongBienDongDuBis.SingleOrDefault(n => n.ID == _id);
                return result;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public tblThuaDatThayDoiTrongBienDong ThuaDangXet(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatThayDoiTrongBienDong result = db.tblThuaDatThayDoiTrongBienDongs.SingleOrDefault(n => n.ID == _id);
                return result;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool SuaThuaDatThayDoiDuBiTrongBienDong(string ID, string ToBanDo,string SoThua, string DienTich, string NoiDungKhac, string ToBanDo2, string SoThua2, string DienTich2, string NoiDungKhac2)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatThayDoiTrongBienDongDuBi thuathaydoi = db.tblThuaDatThayDoiTrongBienDongDuBis.SingleOrDefault(n => n.ID == _id);
                if (thuathaydoi != null)
                {
                    thuathaydoi.ToBanDo = ToBanDo;
                    thuathaydoi.SoThua = SoThua;
                    thuathaydoi.DienTich = DienTich;
                    thuathaydoi.NoiDungThayDoiKhac = NoiDungKhac;

                    thuathaydoi.ToBanDoMoi = ToBanDo2;
                    thuathaydoi.SoThuaMoi = SoThua2;
                    thuathaydoi.DienTichMoi = DienTich2;
                    thuathaydoi.NoiDungThayDoiKhacMoi = NoiDungKhac2;

                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SuaThuaDatThayDoiTrongBienDong(string ID, string ToBanDo,string SoThua, string DienTich, string NoiDungKhac, string ToBanDo2, string SoThua2, string DienTich2, string NoiDungKhac2)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatThayDoiTrongBienDong thuathaydoi = db.tblThuaDatThayDoiTrongBienDongs.SingleOrDefault(n => n.ID == _id);
                if (thuathaydoi != null)
                {
                    thuathaydoi.ToBanDo = ToBanDo;
                    thuathaydoi.SoThua = SoThua;
                    thuathaydoi.DienTich = DienTich;
                    thuathaydoi.NoiDungThayDoiKhac = NoiDungKhac;

                    thuathaydoi.ToBanDoMoi = ToBanDo2;
                    thuathaydoi.SoThuaMoi = SoThua2;
                    thuathaydoi.DienTichMoi = DienTich2;
                    thuathaydoi.NoiDungThayDoiKhacMoi = NoiDungKhac2;

                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool XoaThuaDatThayDoiDuBiTrongBienDong(string ID)
        {
            try 
	        {	        
		        long _id = long.Parse(ID);
                tblThuaDatThayDoiTrongBienDongDuBi thuaxoa = db.tblThuaDatThayDoiTrongBienDongDuBis.SingleOrDefault(n => n.ID == _id);
                if(thuaxoa != null)
                {
                    db.tblThuaDatThayDoiTrongBienDongDuBis.Remove(thuaxoa);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
	        }
	        catch (Exception)
	        {
		
		        return false;
	        }
            
        }
        public bool XoaThuaDatThayDoiTrongBienDong(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatThayDoiTrongBienDong thuaxoa = db.tblThuaDatThayDoiTrongBienDongs.SingleOrDefault(n => n.ID == _id);
                if (thuaxoa != null)
                {
                    db.tblThuaDatThayDoiTrongBienDongs.Remove(thuaxoa);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

        }
#endregion
#region"Thực hiện với bảng tài sản thay đổi"

        public List<tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBi> dsTaiSanDuBiThayDoi(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                var dsTaiSan = from t in db.tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBis
                             where t.MaDangKyBienDong == _maBD
                             select t;
                return dsTaiSan.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<tblThongTinTaiSanGanLienVoiDatTrongBienDong> dsTaiSanThayDoi(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                var dsTaiSan = from t in db.tblThongTinTaiSanGanLienVoiDatTrongBienDongs
                               where t.MaDangKyBienDong == _maBD
                               select t;
                return dsTaiSan.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool ThemTaiSanThayDoiDuBiTrongBienDong(string MaDangKyBienDong, string LoaiTaiSan, string DienTichXayDung, string NoiDungThayDoi, string LoaiTaiSanMoi, string DienTichXayDungMoi, string NoiDungThayDoiMoi)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBi ts = new tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBi();
                ts.MaDangKyBienDong = _maBD;
                ts.LoaiTaiSan = LoaiTaiSan;
                ts.DienTichXayDung = DienTichXayDung;
                ts.NoiDungThayDoi = NoiDungThayDoi;
                ts.LoaiTaiSanMoi = LoaiTaiSanMoi;
                ts.DienTichXayDungMoi = DienTichXayDungMoi;
                ts.NoiDungThayDoiMoi = NoiDungThayDoiMoi;

                db.tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBis.Add(ts);

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool ThemTaiSanThayDoiTrongBienDong(string MaDangKyBienDong, string LoaiTaiSan, string DienTichXayDung, string NoiDungThayDoi, string LoaiTaiSanMoi, string DienTichXayDungMoi, string NoiDungThayDoiMoi)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblThongTinTaiSanGanLienVoiDatTrongBienDong ts = new tblThongTinTaiSanGanLienVoiDatTrongBienDong();
                ts.MaDangKyBienDong = _maBD;
                ts.LoaiTaiSan = LoaiTaiSan;
                ts.DienTichXayDung = DienTichXayDung;
                ts.NoiDungThayDoi = NoiDungThayDoi;
                ts.LoaiTaiSanMoi = LoaiTaiSanMoi;
                ts.DienTichXayDungMoi = DienTichXayDungMoi;
                ts.NoiDungThayDoiMoi = NoiDungThayDoiMoi;

                db.tblThongTinTaiSanGanLienVoiDatTrongBienDongs.Add(ts);

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBi TaiSanDuBiDangXet(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBi result = db.tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBis.SingleOrDefault(n => n.ID == _id);
                return result;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public tblThongTinTaiSanGanLienVoiDatTrongBienDong TaiSanDangXet(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThongTinTaiSanGanLienVoiDatTrongBienDong result = db.tblThongTinTaiSanGanLienVoiDatTrongBienDongs.SingleOrDefault(n => n.ID == _id);
                return result;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool SuaTaiSanThayDoiDuBiTrongBienDong(string ID, string LoaiTaiSan, string DienTichXayDung, string NoiDungThayDoi, string LoaiTaiSanMoi, string DienTichXayDungMoi, string NoiDungThayDoiMoi)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBi ts = db.tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBis.SingleOrDefault(n => n.ID == _id);
                
                ts.LoaiTaiSan = LoaiTaiSan;
                ts.DienTichXayDung = DienTichXayDung;
                ts.NoiDungThayDoi = NoiDungThayDoi;
                ts.LoaiTaiSanMoi = LoaiTaiSanMoi;
                ts.DienTichXayDungMoi = DienTichXayDungMoi;
                ts.NoiDungThayDoiMoi = NoiDungThayDoiMoi;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SuaTaiSanThayDoiTrongBienDong(string ID, string LoaiTaiSan, string DienTichXayDung, string NoiDungThayDoi, string LoaiTaiSanMoi, string DienTichXayDungMoi, string NoiDungThayDoiMoi)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThongTinTaiSanGanLienVoiDatTrongBienDong ts = db.tblThongTinTaiSanGanLienVoiDatTrongBienDongs.SingleOrDefault(n => n.ID == _id);

                ts.LoaiTaiSan = LoaiTaiSan;
                ts.DienTichXayDung = DienTichXayDung;
                ts.NoiDungThayDoi = NoiDungThayDoi;
                ts.LoaiTaiSanMoi = LoaiTaiSanMoi;
                ts.DienTichXayDungMoi = DienTichXayDungMoi;
                ts.NoiDungThayDoiMoi = NoiDungThayDoiMoi;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool XoaTaiSanThayDoiDuBiTrongBienDong(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBi ts = db.tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBis.SingleOrDefault(n => n.ID == _id);
                if (ts != null)
                {
                    db.tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBis.Remove(ts);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool XoaTaiSanThayDoiTrongBienDong(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThongTinTaiSanGanLienVoiDatTrongBienDong ts = db.tblThongTinTaiSanGanLienVoiDatTrongBienDongs.SingleOrDefault(n => n.ID == _id);
                if (ts != null)
                {
                    db.tblThongTinTaiSanGanLienVoiDatTrongBienDongs.Remove(ts);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

        }
#endregion

        #region" Thuực hiện với thửa đất đề nghị tách thửa"

        public tblThuaDatDeNghiTachThuaTrongBienDongTheoDon LayThuaDeNghiTachTheoDon(string MaDangKyBienDong)
        {
            try
            {
                long _maBD= long.Parse(MaDangKyBienDong);
                tblThuaDatDeNghiTachThuaTrongBienDongTheoDon result = db.tblThuaDatDeNghiTachThuaTrongBienDongTheoDons.SingleOrDefault(n => n.MaDangKyBienDong == _maBD);
                return result;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return null;
            }
        }
        public tblThuaDatDeNghiTachThuaTrongBienDong LayThuaDeNghiTach(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblThuaDatDeNghiTachThuaTrongBienDong result = db.tblThuaDatDeNghiTachThuaTrongBienDongs.SingleOrDefault(n => n.MaDangKyBienDong == _maBD);
                return result;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return null;
            }
        }
        public string LayMaThuaDeNghiTachTheoDon(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblThuaDatDeNghiTachThuaTrongBienDongTheoDon result = db.tblThuaDatDeNghiTachThuaTrongBienDongTheoDons.SingleOrDefault(n => n.MaDangKyBienDong == _maBD);
                if (result != null)
                    return result.ID.ToString();
                else
                    return "0";
            }
            catch (Exception)
            {

                return "0";
            }
        }
        public string LayMaThuaDeNghiTach(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblThuaDatDeNghiTachThuaTrongBienDong result = db.tblThuaDatDeNghiTachThuaTrongBienDongs.SingleOrDefault(n => n.MaDangKyBienDong == _maBD);
                if (result != null)
                    return result.ID.ToString();
                else
                    return "0";
            }
            catch (Exception)
            {

                return "0";
            }
        }
        public bool ThemThuaDatDeNghiTachThuaTrongBienDongTheoDon (string MaDangKyBienDong, string SoThuaConDeNghiTach, string ToBanDo, string SoThua, string DiaChi, string SoPhatHanh, string SoVaoSo, string NgayCapGCN, string DienTichCon1, string DienTichCon2)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblThuaDatDeNghiTachThuaTrongBienDongTheoDon thua = new tblThuaDatDeNghiTachThuaTrongBienDongTheoDon();
                thua.MaDangKyBienDong = _maBD;
                thua.SoThuaConDeNghiTach = SoThuaConDeNghiTach;
                thua.ToBanDo = ToBanDo;
                thua.SoThua = SoThua;
                thua.DiaChi = DiaChi;
                thua.SoPhatHanhGCN = SoPhatHanh;
                thua.SoVaoSoCapGCN = SoVaoSo;
                if(NgayCapGCN!= "")
                thua.NgayCapGCN =Convert.ToDateTime( NgayCapGCN);
                thua.DienTichCon1 = DienTichCon1;
                thua.DienTichCon2 = DienTichCon2;
                db.tblThuaDatDeNghiTachThuaTrongBienDongTheoDons.Add(thua);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return false;
            }
        }
        public bool ThemThuaDatDeNghiTachThuaTrongBienDong(string MaDangKyBienDong, string SoThuaConDeNghiTach, string ToBanDo, string SoThua, string DiaChi, string SoPhatHanh, string SoVaoSo, string NgayCapGCN, string DienTichCon1, string DienTichCon2)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblThuaDatDeNghiTachThuaTrongBienDong thua = new tblThuaDatDeNghiTachThuaTrongBienDong();
                thua.MaDangKyBienDong = _maBD;
                thua.SoThuaConDeNghiTach = SoThuaConDeNghiTach;
                thua.ToBanDo = ToBanDo;
                thua.SoThua = SoThua;
                thua.DiaChi = DiaChi;
                thua.SoPhatHanhGCN = SoPhatHanh;
                thua.SoVaoSoCapGCN = SoVaoSo;
                if (NgayCapGCN != "")
                    thua.NgayCapGCN = Convert.ToDateTime(NgayCapGCN);
                thua.DienTichCon1 = DienTichCon1;
                thua.DienTichCon2 = DienTichCon2;
                db.tblThuaDatDeNghiTachThuaTrongBienDongs.Add(thua);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return false;
            }
        }
        public bool SuaThuaDatDeNghiTachThuaTrongBienDongTheoDon(string ID, string SoThuaConDeNghiTach, string ToBanDo, string SoThua, string DiaChi, string SoPhatHanh, string SoVaoSo, string NgayCapGCN, string DienTichCon1, string DienTichCon2)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatDeNghiTachThuaTrongBienDongTheoDon thua = db.tblThuaDatDeNghiTachThuaTrongBienDongTheoDons.SingleOrDefault(n => n.ID == _id);
                if (thua != null)
                {
                    thua.SoThuaConDeNghiTach = SoThuaConDeNghiTach;
                    thua.ToBanDo = ToBanDo;
                    thua.SoThua = SoThua;
                    thua.DiaChi = DiaChi;
                    thua.SoPhatHanhGCN = SoPhatHanh;
                    thua.SoVaoSoCapGCN = SoVaoSo;
                    if (NgayCapGCN != "")
                        thua.NgayCapGCN = Convert.ToDateTime(NgayCapGCN);
                    thua.DienTichCon1 = DienTichCon1;
                    thua.DienTichCon2 = DienTichCon2;
                    
                    db.SaveChanges();

                    return true;
                }
                else
                    return false;
                
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SuaThuaDatDeNghiTachThuaTrongBienDong(string ID, string SoThuaConDeNghiTach, string ToBanDo, string SoThua, string DiaChi, string SoPhatHanh, string SoVaoSo, string NgayCapGCN, string DienTichCon1, string DienTichCon2)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatDeNghiTachThuaTrongBienDong thua = db.tblThuaDatDeNghiTachThuaTrongBienDongs.SingleOrDefault(n => n.ID == _id);
                if (thua != null)
                {
                    thua.SoThuaConDeNghiTach = SoThuaConDeNghiTach;
                    thua.ToBanDo = ToBanDo;
                    thua.SoThua = SoThua;
                    thua.DiaChi = DiaChi;
                    thua.SoPhatHanhGCN = SoPhatHanh;
                    thua.SoVaoSoCapGCN = SoVaoSo;
                    if (NgayCapGCN != "")
                        thua.NgayCapGCN = Convert.ToDateTime(NgayCapGCN);
                    thua.DienTichCon1 = DienTichCon1;
                    thua.DienTichCon2 = DienTichCon2;

                    db.SaveChanges();

                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool XoaThuaDatDeNghiTachThuaTrongBienDongTheoDon(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatDeNghiTachThuaTrongBienDongTheoDon thua = db.tblThuaDatDeNghiTachThuaTrongBienDongTheoDons.SingleOrDefault(n => n.ID == _id);
                if (thua != null)
                {
                    db.tblThuaDatDeNghiTachThuaTrongBienDongTheoDons.Remove(thua);

                    db.SaveChanges();

                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool XoaThuaDatDeNghiTachThuaTrongBienDong(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatDeNghiTachThuaTrongBienDong thua = db.tblThuaDatDeNghiTachThuaTrongBienDongs.SingleOrDefault(n => n.ID == _id);
                if (thua != null)
                {
                    db.tblThuaDatDeNghiTachThuaTrongBienDongs.Remove(thua);

                    db.SaveChanges();

                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {

                return false;
            }
        }
#endregion
        #region "  thực hiện với thửa đất đề nghị hợp thửa."
        public List<tblThuaDatDeNghiHopThuaTrongBienDongTheoDon> dsThuaDatDeNghiHopThuaTheoDon(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                var ds = from n in db.tblThuaDatDeNghiHopThuaTrongBienDongTheoDons
                         where n.MaDangKyBienDong == _maBD
                         select n;
                return ds.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<tblThuaDatDeNghiHopThuaTrongBienDong> dsThuaDatDeNghiHopThua(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                var ds = from n in db.tblThuaDatDeNghiHopThuaTrongBienDongs
                         where n.MaDangKyBienDong == _maBD
                         select n;
                return ds.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool ThemThuaDatDeNghiHopThuaTheoDon(string MaDangKyBienDong, string ToBanDo, string SoThua, string DiaChi, string SoPhatHanh, string SoVaoSo/*, string NgayCapGCN*/)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblThuaDatDeNghiHopThuaTrongBienDongTheoDon thua = new tblThuaDatDeNghiHopThuaTrongBienDongTheoDon();
                thua.MaDangKyBienDong = _maBD;
                thua.ToBanDo = ToBanDo;
                thua.SoThua = SoThua;
                thua.DiaChi = DiaChi;
                thua.SoPhatHanhGCN = SoPhatHanh;
                thua.SoVaoSoCapGCN = SoVaoSo;
                //if(NgayCapGCN!="")
                //thua.NgayCapGCN = Convert.ToDateTime(NgayCapGCN);

                db.tblThuaDatDeNghiHopThuaTrongBienDongTheoDons.Add(thua);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool ThemThuaDatDeNghiHopThua(string MaDangKyBienDong, string ToBanDo, string SoThua, string DiaChi, string SoPhatHanh, string SoVaoSo/*, string NgayCapGCN*/)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblThuaDatDeNghiHopThuaTrongBienDong thua = new tblThuaDatDeNghiHopThuaTrongBienDong();
                thua.MaDangKyBienDong = _maBD;
                thua.ToBanDo = ToBanDo;
                thua.SoThua = SoThua;
                thua.DiaChi = DiaChi;
                thua.SoPhatHanhGCN = SoPhatHanh;
                thua.SoVaoSoCapGCN = SoVaoSo;
                //if(NgayCapGCN!="")
                //thua.NgayCapGCN = Convert.ToDateTime(NgayCapGCN);

                db.tblThuaDatDeNghiHopThuaTrongBienDongs.Add(thua);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SuaThuaDatDeNghiHopThuaTheoDon(string ID, string ToBanDo, string SoThua, string DiaChi, string SoPhatHanh, string SoVaoSo/*, string NgayCapGCN*/)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatDeNghiHopThuaTrongBienDongTheoDon thua = db.tblThuaDatDeNghiHopThuaTrongBienDongTheoDons.SingleOrDefault(n => n.ID == _id);
                thua.ToBanDo = ToBanDo;
                thua.SoThua = SoThua;
                thua.DiaChi = DiaChi;
                thua.SoPhatHanhGCN = SoPhatHanh;
                thua.SoVaoSoCapGCN = SoVaoSo;
                //if (NgayCapGCN != "")
                //    thua.NgayCapGCN = Convert.ToDateTime(NgayCapGCN);

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool SuaThuaDatDeNghiHopThua(string ID, string ToBanDo, string SoThua, string DiaChi, string SoPhatHanh, string SoVaoSo/*, string NgayCapGCN*/)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatDeNghiHopThuaTrongBienDong thua = db.tblThuaDatDeNghiHopThuaTrongBienDongs.SingleOrDefault(n => n.ID == _id);
                thua.ToBanDo = ToBanDo;
                thua.SoThua = SoThua;
                thua.DiaChi = DiaChi;
                thua.SoPhatHanhGCN = SoPhatHanh;
                thua.SoVaoSoCapGCN = SoVaoSo;
                //if (NgayCapGCN != "")
                //    thua.NgayCapGCN = Convert.ToDateTime(NgayCapGCN);

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool XoaThuaDatDeNghiHopThuaTheoDon(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatDeNghiHopThuaTrongBienDongTheoDon thua = db.tblThuaDatDeNghiHopThuaTrongBienDongTheoDons.SingleOrDefault(n => n.ID == _id);
                db.tblThuaDatDeNghiHopThuaTrongBienDongTheoDons.Remove(thua);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool XoaThuaDatDeNghiHopThua(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatDeNghiHopThuaTrongBienDong thua = db.tblThuaDatDeNghiHopThuaTrongBienDongs.SingleOrDefault(n => n.ID == _id);
                db.tblThuaDatDeNghiHopThuaTrongBienDongs.Remove(thua);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public tblThuaDatDeNghiHopThuaTrongBienDongTheoDon LayThuaDatDeNghiHopThuaTheoDon(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatDeNghiHopThuaTrongBienDongTheoDon thua = db.tblThuaDatDeNghiHopThuaTrongBienDongTheoDons.SingleOrDefault(n => n.ID == _id);
                return thua;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public tblThuaDatDeNghiHopThuaTrongBienDong LayThuaDatDeNghiHopThua(string ID)
        {
            try
            {
                long _id = long.Parse(ID);
                tblThuaDatDeNghiHopThuaTrongBienDong thua = db.tblThuaDatDeNghiHopThuaTrongBienDongs.SingleOrDefault(n => n.ID == _id);
                return thua;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool GuiHoSo(string MaDangKyBienDong)
        {
            try
            {
                long _maBD = long.Parse(MaDangKyBienDong);
                tblDonXinDangKyBienDongDuBi don = db.tblDonXinDangKyBienDongDuBis.SingleOrDefault(n => n.ID == _maBD);
                if (don != null)
                {
                    don.DaGuiDon = true;
                    db.SaveChanges();
                    return true;
                }
                else 
                    return false;

            }
            catch (Exception)
            {
                
                return false;
            }
        }

#endregion






        /// <summary>
        ///     QUAN TRỌNG!
        ///     ĐÂY LÀ PHẦN CHẤP NHẬN BIẾN ĐỘNG, TẤT CẢ DỮ LIỆU CỦA MỘT BIẾN ĐỘNG TRONG CÁC BẢNG DỰ BỊ SẼ ĐƯỢC ĐƯA LÊN BẢNG CHÍNH THỨC!
        /// </summary>
        /// <param name="HoSoChinhThuc"></param>
        /// <param name="MaHoSo"></param>
        /// <param name="Machu"></param>
        /// <returns></returns>
        /// 
        public bool ChapNhanBienDong(string MaDangKyBienDong, string NgayNhanHoSo, string NguoiNhanHoSo, string SoTiepNhan, string Quyen)
        {
            try
            {
                DateTime _ngayNhanHoSo;
                if (NgayNhanHoSo != "")
                    _ngayNhanHoSo = Convert.ToDateTime(NgayNhanHoSo);
                else
                    _ngayNhanHoSo = DateTime.Now;


                long _maBD = long.Parse(MaDangKyBienDong);
                // lấy ra hồ sơ đăng ký biến động dự bị trên.
                tblDonXinDangKyBienDongDuBi DonDuBi = db.tblDonXinDangKyBienDongDuBis.SingleOrDefault(n => n.ID == _maBD);
                if (DonDuBi == null)
                {
                    // thong bao loi...
                    return false;
                }
                // kiểm tra thông tin tiếp nhận hồ sơ xem có chưa.
                if (NguoiNhanHoSo == "" || SoTiepNhan == "")
                {
                    // thong bao loi...
                    return false;
                }
                // kiểm tra loại đăng ký biến động.
                string LoaiBD = DonDuBi.LoaiBienDong;
                if (LoaiBD == null)
                {
                    // thong bao loi...
                    return false;
                }
                // TẠO HỒ SƠ BIẾN ĐỘNG CHÍNH THỨC.
                tblDonXinDangKyBienDong DonChinhThuc = new tblDonXinDangKyBienDong();
                DonChinhThuc.KinhGuiCoQuanChucNang=DonDuBi.TieuDeDon;
                DonChinhThuc.NguoiVietDon=DonDuBi.NguoiVietDon;
                DonChinhThuc.NgayVietDon=DonDuBi.NgayVietDon;
                DonChinhThuc.SoVaoSoCapGCN=DonDuBi.SoVaoSoCapGCN;
                DonChinhThuc.SoPhatHanhGCN=DonDuBi.SoPhatHanhGCN;
                DonChinhThuc.NgayCapGCN=DonDuBi.NgayCapGCN;
                DonChinhThuc.BienDongVe=DonDuBi.BienDongVe;
                DonChinhThuc.NoiDungGhiTrenGCNTruocKhiBienDong=DonDuBi.NoiDungGhiTrenGCNTruocKhiBienDong;
                DonChinhThuc.NoiDungSauKhiBienDong=DonDuBi.NoiDungSauKhiBienDong;
                DonChinhThuc.LyDoBienDong=DonDuBi.LyDoBienDong;
                DonChinhThuc.TinhHinhThucHienNghiaVuTaiChinh=DonDuBi.TinhHinhThucHienNghiaVuTaiChinh;
                DonChinhThuc.GiayToKemTheo=DonDuBi.GiayToKemTheo;
                DonChinhThuc.LoaiBienDong=DonDuBi.LoaiBienDong;
                DonChinhThuc.LoaiDoiTuongApDung = DonDuBi.LoaiDoiTuongApDung;

                DonChinhThuc.NgayNhanHoSo = _ngayNhanHoSo;
                DonChinhThuc.NguoiNhanHoSo = NguoiNhanHoSo;
                DonChinhThuc.SoTiepNhan = SoTiepNhan;
                DonChinhThuc.Quyen = Quyen;

                db.tblDonXinDangKyBienDongs.Add(DonChinhThuc);
                db.SaveChanges();
                string s = DonChinhThuc.MaDangKyBienDong.ToString();
                // nếu là đăng ký biến động loại 1
                if (LoaiBD == "1")
                {
                    // đã có hết ở hồ sơ kê khai dự bị nên tạm thời chưa phải làm gì.
                }
                // nếu là đăng ký cấp lại, cấp đổi
                else if (LoaiBD == "2")
                {
                    List<tblThuaDatThayDoiTrongBienDongDuBi> dstdtd = (from n in db.tblThuaDatThayDoiTrongBienDongDuBis
                                                                              where n.MaDangKyBienDong == _maBD
                                                                              select n).ToList();
                    if (dstdtd != null)
                    {
                        if (dstdtd.Count() > 0)
                        {
                            for (int i = 0; i < dstdtd.Count(); i++)
                            {
                                tblThuaDatThayDoiTrongBienDongDuBi tddb= (tblThuaDatThayDoiTrongBienDongDuBi)dstdtd[i];
                                tblThuaDatThayDoiTrongBienDong td = new tblThuaDatThayDoiTrongBienDong();
                                td.MaDangKyBienDong= DonChinhThuc.MaDangKyBienDong;
                                td.ToBanDo=tddb.ToBanDo;
                                td.SoThua=tddb.SoThua;
                                td.DienTich=tddb.DienTich;
                                td.NoiDungThayDoiKhac=tddb.NoiDungThayDoiKhac;
                                td.ToBanDoMoi=tddb.ToBanDoMoi;
                                td.SoThuaMoi=tddb.SoThuaMoi;
                                td.DienTichMoi=tddb.DienTichMoi;
                                td.NoiDungThayDoiKhacMoi = tddb.NoiDungThayDoiKhacMoi;

                                db.tblThuaDatThayDoiTrongBienDongs.Add(td);
                                db.SaveChanges();

                            }
                        }
                    }



                    List<tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBi> dsts = (from n in db.tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBis
                                                                                         where n.MaDangKyBienDong == _maBD
                                                                                         select n).ToList();
                    if (dsts != null)
                    {
                        if (dsts.Count() > 0)
                        {
                            for (int i = 0; i < dsts.Count(); i++)
                            {
                                tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBi tsdb = (tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBi)dsts[i];
                                tblThongTinTaiSanGanLienVoiDatTrongBienDong ts = new tblThongTinTaiSanGanLienVoiDatTrongBienDong();
                                ts.MaDangKyBienDong = DonChinhThuc.MaDangKyBienDong;
                                ts.LoaiTaiSan=tsdb.LoaiTaiSan;
                                ts.DienTichXayDung=tsdb.DienTichXayDung;
                                ts.NoiDungThayDoi=tsdb.NoiDungThayDoi;
                                ts.LoaiTaiSanMoi = tsdb.LoaiTaiSanMoi;
                                ts.DienTichXayDungMoi = tsdb.DienTichXayDungMoi;
                                ts.NoiDungThayDoiMoi = tsdb.NoiDungThayDoiMoi;

                                db.tblThongTinTaiSanGanLienVoiDatTrongBienDongs.Add(ts);
                                db.SaveChanges();
                            }
                        }
                    }
                }
                // nếu là đăng ký tách, hợp thửa.
                else if (LoaiBD == "3")
                {
                    tblThuaDatDeNghiTachThuaTrongBienDongTheoDon tdtt = db.tblThuaDatDeNghiTachThuaTrongBienDongTheoDons.SingleOrDefault(n => n.MaDangKyBienDong == _maBD);
                    if (tdtt != null)
                    {
                        tblThuaDatDeNghiTachThuaTrongBienDong td = new tblThuaDatDeNghiTachThuaTrongBienDong();
                        td.MaDangKyBienDong= DonChinhThuc.MaDangKyBienDong;
                        td.MaThuaDat = tdtt.MaThuaDat;
                        td.ToBanDo = tdtt.ToBanDo;
                        td.SoThua = tdtt.SoThua;
                        td.DiaChi = tdtt.DiaChi;
                        td.SoPhatHanhGCN = tdtt.SoPhatHanhGCN;
                        td.SoVaoSoCapGCN = tdtt.SoVaoSoCapGCN;
                        td.NgayCapGCN = tdtt.NgayCapGCN;
                        td.SoThuaConDeNghiTach = tdtt.SoThuaConDeNghiTach;                        
                        td.DienTichCon1 = tdtt.DienTichCon1;
                        td.DienTichCon2 = tdtt.DienTichCon2;

                        db.tblThuaDatDeNghiTachThuaTrongBienDongs.Add(td);
                        db.SaveChanges();
                    }


                    List<tblThuaDatDeNghiHopThuaTrongBienDongTheoDon> dstdht = (from n in db.tblThuaDatDeNghiHopThuaTrongBienDongTheoDons
                                                                                       where n.MaDangKyBienDong == _maBD
                                                                                       select n).ToList();
                    if (dstdht != null)
                    {
                        if (dstdht.Count() > 0)
                        {
                            for (int i = 0; i < dstdht.Count(); i++)
                            {
                                tblThuaDatDeNghiHopThuaTrongBienDongTheoDon htdb = dstdht[i];
                                tblThuaDatDeNghiHopThuaTrongBienDong ht = new tblThuaDatDeNghiHopThuaTrongBienDong();

                                ht.MaDangKyBienDong = DonChinhThuc.MaDangKyBienDong;
                                ht.MaThuaDat=htdb.MaThuaDat;
                                ht.ToBanDo=htdb.ToBanDo;
                                ht.SoThua=htdb.SoThua;
                                ht.DiaChi=htdb.DiaChi;
                                ht.SoPhatHanhGCN=htdb.SoPhatHanhGCN;
                                ht.SoVaoSoCapGCN=htdb.SoVaoSoCapGCN;
                                ht.NgayCapGCN = htdb.NgayCapGCN;

                                db.tblThuaDatDeNghiHopThuaTrongBienDongs.Add(ht);
                                db.SaveChanges();
                            }

                        }
                    }
                }
                // lưu Chủ nữa.
                List<tblChuDangKyBienDongDuBi> dschudb = (from chs in db.tblChuDangKyBienDongDuBis
                                                         where chs.MaDangKyBienDong == _maBD
                                                         select chs).ToList();

                if(dschudb != null)
                {
                    if (dschudb.Count() > 0)
                    {
                        for(int i=0;i<dschudb.Count(); i++)
                        {
                            tblChuDangKyBienDong chs = new tblChuDangKyBienDong();
                            chs.MaDangKyBienDong = DonChinhThuc.MaDangKyBienDong;
                            //chs.MaChu =// cập nhật ở dưới.

                           
                            // tblChu
                            long _maChu =(long)dschudb[i].MaChu;
                            var ch = db.tblChuDuBis.SingleOrDefault(n => n.MaChu == _maChu);
                            if(ch != null)
                            {
                                tblChu chuMoi = new tblChu();
                                 // chuMoi.MaChu = ch.MaChu;
                                  chuMoi.DanhXung = ch.DanhXung;
                                  chuMoi.HoTen = ch.HoTen;
                                  chuMoi.NamSinh = ch.NamSinh;
                                  chuMoi.DiaChi = ch.DiaChi;
                                  chuMoi.DinhDanh = ch.DinhDanh;
                                  chuMoi.SoDinhDanh = ch.SoDinhDanh;
                                  chuMoi.NoiCap = ch.NoiCap;
                                  chuMoi.NgayCap = ch.NgayCap;
                                  chuMoi.QuocTich = ch.QuocTich;
                                  db.tblChus.Add(chuMoi);
                                  db.SaveChanges();


                                // quan trọng: bởi vì đến đây mã chủ mới được tạo ra và ta mới có thể gán được.
                                  chs.MaChu = chuMoi.MaChu;                                 
                                  
                            }
                            //VẬY TRONG TRƯỜNG HỢP TA KHÔNG TẠO RA CHỦ MỚI MÀ LẤY NÓ TRONG DATABASE CHỦ CÓ SẴN THÌ SẼ CẦN SỬA THÊM...
                            //TA SẼ THỬ NGHIỆM DƯỚI ĐÂY, TUY NHIÊN CHƯA CHẮC CHẮN ĐÚNG!?
                            else
                            {
                                var TimChuDaCoSan = db.tblChus.FirstOrDefault(n => n.MaChu == _maChu);
                                if (TimChuDaCoSan != null)
                                {
                                    chs.MaChu = TimChuDaCoSan.MaChu; //hoặc có thể viết là = _maChu;
                                }
                            }

                            
                            db.tblChuDangKyBienDongs.Add(chs);
                            db.SaveChanges();
                            
                        }
                    }
                }

                XoaDuLieuBienDongDuBi(MaDangKyBienDong);
                return true;

            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return false;
            }
        }
    }
}