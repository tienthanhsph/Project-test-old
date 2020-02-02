using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMCWeb.Models;

namespace DMCWeb.Logic
{
    public class clsTimKiem
    {
        
        DMCWebEntities db = new DMCWebEntities();
        public IEnumerable<object> TimKiemHoSo(string DVHC,string Ten,string CMND, string DiaChi, string ToBanDo, string SoThua)
        {
            try
            {
                var data = from hs in db.tblHoSoes
                           join chs in db.tblChuHoSoes on hs.MaHoSo equals chs.MaHoSo
                           join c in db.tblChus on chs.MaChu equals c.MaChu
                           join td in db.tblThuaDats on hs.MaHoSo equals td.MaHoSo
                           where c.HoTen.Contains(Ten) && c.SoDinhDanh.Contains(CMND)&& td.DiaChi.Contains(DiaChi)&& td.ToBanDo.Contains(ToBanDo)&& td.SoThua.Contains(SoThua) && hs.DonViHanhChinh.Contains(DVHC)
                           select new
                           {
                               MaHS = hs.MaHoSo,
                               TenChu = c.HoTen,
                               ToBD = td.ToBanDo,
                               ST = td.SoThua,
                               DC = td.DiaChi,
                               DT=td.DienTich
                           };
                int i = data.ToList().Count;
                return data;
                              
            }
            catch (Exception ex)
            {
                return null;
            }


        }

        public IEnumerable<object> TimKiemNhanhHS(string str)
        {
            try
            {
                var data = from hs in db.tblHoSoKeKhaiDuBis
                           join chs in db.tblChuHoSoDuBis on hs.MaHoSoKeKhai equals chs.MaHoSoKeKhai
                           join c in db.tblChuDuBis on chs.MaChu equals c.MaChu
                           join td in db.tblThuaDatDuBis on hs.MaHoSoKeKhai equals td.MaHoSoKeKhai
                           where hs.DaGuiDi == true && (c.HoTen.Contains(str) || c.SoDinhDanh == str)
                           select new
                           {
                               MaHS = hs.MaHoSoKeKhai,
                               TenChu = c.HoTen,
                               ToBD = td.ToBanDo,
                               ST = td.SoThua,
                               DC = td.DiaChi,
                               DT = td.DienTich
                           };
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<object> TimKiemNhanhBD(string str)
        {
            try
            {
                var data = from n in db.tblDonXinDangKyBienDongDuBis
                           where n.DaGuiDon== true && n.NguoiVietDon.Contains(str)
                           
                           select new
                           {
                               MaDangKyBienDong = n.ID,
                               NguoiVietDon = n.NguoiVietDon,
                               LoaiBienDong = n.LoaiBienDong,
                               SoPhatHanhGCN = n.SoPhatHanhGCN,
                               SoVaoSoCapGCN = n.SoVaoSoCapGCN,
                               NgayCapGCN = n.NgayCapGCN,
                           };
                int count = data.ToArray().Length;
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<object> TimKiemHoSoKeKhaiDuBi(string DVHC, string Ten, string CMND, string DiaChi, string ToBanDo, string SoThua)
        {
            try
            {

                var data = from hs in db.tblHoSoKeKhaiDuBis
                           join chs in db.tblChuHoSoDuBis on hs.MaHoSoKeKhai equals chs.MaHoSoKeKhai
                           join c in db.tblChuDuBis on chs.MaChu equals c.MaChu
                           join td in db.tblThuaDatDuBis on hs.MaHoSoKeKhai equals td.MaHoSoKeKhai
                           where hs.DaGuiDi == true && c.HoTen.Contains(Ten) && c.SoDinhDanh.Contains(CMND) && td.DiaChi.Contains(DiaChi) && td.ToBanDo.Contains(ToBanDo) && td.SoThua.Contains(SoThua) && hs.DonViHanhChinh.Contains(DVHC)
                           select new
                           {
                               MaHS = hs.MaHoSoKeKhai,
                               TenChu = c.HoTen,
                               ToBD = td.ToBanDo,
                               ST = td.SoThua,
                               DC = td.DiaChi,
                               DT = td.DienTich
                           };
                return data;

            }
            catch (Exception ex)
            {
                return null;
            }


        }


        public IEnumerable<object> TimKiemHoSoDangKyBienDong(string DVHC, string Ten, string LoaiBienDong, string SoPhatHanhGCN, string SoVaoSoCapGCN, string NgayCapGCN) {
            try
            {
                var data = from n in db.tblDonXinDangKyBienDongs
                           where
                               (n.DonViHanhChinh.Contains(DVHC) || DVHC == "") &&
                           n.NguoiVietDon.Contains(Ten)
                           && (n.LoaiBienDong.Contains(LoaiBienDong) || LoaiBienDong == "")
                           && (n.SoPhatHanhGCN.Contains(SoPhatHanhGCN) || SoPhatHanhGCN == "")
                           && (n.SoVaoSoCapGCN.Contains(SoVaoSoCapGCN) || SoVaoSoCapGCN == "")
                               //&& (n.NgayCapGCN.ToString().Contains(NgayCapGCN)|| NgayCapGCN == "") // Linq không cho xử lý .ToString; nên trường datetime .NgayCapGCN này cần để lại xử lý sau!.
                           
                           select new
                           {
                               MaDangKyBienDong = n.MaDangKyBienDong,
                               NguoiVietDon = n.NguoiVietDon,
                               LoaiBienDong = n.LoaiBienDong,
                               SoPhatHanhGCN = n.SoPhatHanhGCN,
                               SoVaoSoCapGCN = n.SoVaoSoCapGCN,
                               NgayCapGCN = n.NgayCapGCN,
                           };
                int count = data.ToArray().Length;
                return data;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public IEnumerable<object> TimKiemDonDangKyBienDongDuBi(string DVHC, string Ten, string LoaiBienDong,string SoPhatHanhGCN, string SoVaoSoCapGCN, string NgayCapGCN) {
            try
            {
                //ta thấy rằng hạn chể ở LINQ là ta chưa biết cách xử lý trường hợp: nếu trường nào đó ="" thì không đặt trong điều kiện???????
                var data = from n in db.tblDonXinDangKyBienDongDuBis
                           where
                               //n.DonViHanhChinh.Contains(DVHC) && 
                           n.NguoiVietDon.Contains(Ten)
                           //&& n.LoaiBienDong.Contains(LoaiBienDong)
                           //&& n.SoPhatHanhGCN.Contains(SoPhatHanhGCN) && n.SoVaoSoCapGCN.Contains(SoVaoSoCapGCN) && n.NgayCapGCN.ToString().Contains(NgayCapGCN)
                           select new
                           {
                               MaDangKyBienDong = n.ID,
                               NguoiVietDon = n.NguoiVietDon,
                               LoaiBienDong = n.LoaiBienDong,
                               SoPhatHanhGCN = n.SoPhatHanhGCN,
                               SoVaoSoCapGCN = n.SoVaoSoCapGCN,
                               NgayCapGCN = n.NgayCapGCN,
                           };
                int count = data.ToArray().Length;
                return data;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public IEnumerable<object> TimKiemDonDangKyBienDongDuBiDaGui(string DVHC, string Ten, string LoaiBienDong, string SoPhatHanhGCN, string SoVaoSoCapGCN, string NgayCapGCN)
        {
            try
            {
                
                var data = from n in db.tblDonXinDangKyBienDongDuBis
                           where
                               (n.DonViHanhChinh.Contains(DVHC)|| DVHC == "" )&& 
                           n.NguoiVietDon.Contains(Ten) 
                           && (n.LoaiBienDong.Contains(LoaiBienDong) || LoaiBienDong=="")
                           && (n.SoPhatHanhGCN.Contains(SoPhatHanhGCN) || SoPhatHanhGCN =="")
                           && (n.SoVaoSoCapGCN.Contains(SoVaoSoCapGCN) || SoVaoSoCapGCN =="")
                           //&& (n.NgayCapGCN.ToString().Contains(NgayCapGCN)|| NgayCapGCN == "") // Linq không cho xử lý .ToString; nên trường datetime .NgayCapGCN này cần để lại xử lý sau!.
                           && n.DaGuiDon== true 
                           select new
                           {
                               MaDangKyBienDong = n.ID,
                               NguoiVietDon = n.NguoiVietDon,
                               LoaiBienDong = n.LoaiBienDong,
                               SoPhatHanhGCN = n.SoPhatHanhGCN,
                               SoVaoSoCapGCN = n.SoVaoSoCapGCN,
                               NgayCapGCN = n.NgayCapGCN,
                           };

               

                int count = data.ToArray().Length;
                return data;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return null;
            }
        }

        public IEnumerable<object> TimKiemChu(string Ten, string CMND, string DiaChi)
        {
            try
            {
                var dsChu = from n in db.tblChus
                            where n.HoTen.Contains(Ten) && n.SoDinhDanh.Contains(CMND) && n.DiaChi.Contains(DiaChi)
                            select n;
                return dsChu;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public IEnumerable<object> TimKiemChu(string Ten, string CMND, string DiaChi, string DVHC, string ToBanDo, string SoThua)
        {
            try
            {
                var dsChu = from n in db.tblChus
                            join chs in db.tblChuHoSoes on n.MaChu equals chs.MaChu
                            join hs in db.tblHoSoes on chs.MaHoSo equals hs.MaHoSo
                            join td in db.tblThuaDats on hs.MaHoSo equals td.MaHoSo
                            where n.HoTen.Contains(Ten) && n.SoDinhDanh.Contains(CMND) && n.DiaChi.Contains(DiaChi) && hs.DonViHanhChinh == DVHC && td.ToBanDo==ToBanDo && td.SoThua==SoThua
                            select n;
                return dsChu;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}