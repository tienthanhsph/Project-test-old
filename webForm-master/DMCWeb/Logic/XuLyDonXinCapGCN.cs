using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMCWeb.Models;


namespace DMCWeb.Logic
{
    public enum ThaoTac { KhongCo, ThemMoi, DangSua, KhongNhap, ChiXem }
    public class XuLyDonXinCapGCN
    {
       
/// <summary>
/// LÀM VIỆC VỚI HỒ SƠ DỰ BỊ: NGƯỜI DÂN NHẬP THÔNG TIN VÀ GỬI LÊN CHO CƠ QUAN CHỨC NĂNG
/// </summary>
/// <param name="MaDVHC"></param>
/// <returns></returns>
        
        DMCWebEntities db = new DMCWebEntities();
        public int TaoDonMoi(string MaDVHC)
        {
            int i = 0;
            try
            {
               
                tblHoSoKeKhaiDuBi hsNew = new tblHoSoKeKhaiDuBi();
                hsNew.DonViHanhChinh= MaDVHC;
                
                db.tblHoSoKeKhaiDuBis.Add(hsNew);
                db.SaveChanges();
                i = Convert.ToInt32( hsNew.MaHoSoKeKhai);
            }
            catch (Exception ex)
            {

            }
            return i;
           
        }
       
        
        public List<tblChuDuBi> dsChuDuBi(string MaHoSo)
        {

            if (MaHoSo == "0" || MaHoSo == "")
                return null;
            int _hs = Convert.ToInt32(MaHoSo);
            var kq = from ch in db.tblChuHoSoDuBis where ch.MaHoSoKeKhai == _hs select  ch.MaChu ;
            var ds = from c in db.tblChuDuBis
                     where kq.Contains(c.MaChu)
                     select c;

            return ds.ToList<tblChuDuBi>();

        }
        public bool ThemChuDuBi(string MaHoSo, string DanhXung, string HoTen, string NamSinh, string DiaChi, string DinhDanh, string SoDinhDanh, string NoiCap, string NgayCap, string QuocTich)
        {
            try
            {

                tblChuDuBi chumoi = new tblChuDuBi();
                
                chumoi.DanhXung = DanhXung;
                chumoi.HoTen = HoTen;
                chumoi.NamSinh = NamSinh;
                chumoi.DiaChi = DiaChi;
                chumoi.DinhDanh = DinhDanh;
                chumoi.SoDinhDanh = SoDinhDanh;
                chumoi.NoiCap = NoiCap;
                chumoi.NgayCap =Convert.ToDateTime( NgayCap);
                chumoi.QuocTich = QuocTich;

                db.tblChuDuBis.Add(chumoi);
                db.SaveChanges();

                tblChuHoSoDuBi chuhoso = new tblChuHoSoDuBi();
                chuhoso.MaChu = chumoi.MaChu;
                chuhoso.MaHoSoKeKhai = Convert.ToInt32(MaHoSo);
                db.tblChuHoSoDuBis.Add(chuhoso);
                db.SaveChanges();


                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool SuaChuDuBi(string MaChu, string DanhXung, string HoTen, string NamSinh, string DiaChi, string DinhDanh, string SoDinhDanh, string NoiCap, string NgayCap, string QuocTich)
        {
            try
            {
           
                long _maChu = long.Parse(MaChu);
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
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool XoaChuDuBi(string MaChu)
        {
            try
            {
                long _maChu = long.Parse(MaChu);
                tblChuDuBi chucanxoa = db.tblChuDuBis.Single(c => c.MaChu == _maChu);
                db.tblChuDuBis.Remove(chucanxoa);

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool CapNhatLoaiDoiTuong(string MaHoSo, string MaLoaiDoiTuong)
        {
            try
            {
               
                long _maHoSo = long.Parse(MaHoSo);
                tblHoSoKeKhaiDuBi HoSoHienTai = db.tblHoSoKeKhaiDuBis.Single(h => h.MaHoSoKeKhai == _maHoSo);
                HoSoHienTai.MaLoaiDoiTuong = MaLoaiDoiTuong;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }





        public List<tblThuaDatDuBi> dsThuaDatDuBi(string MaHoSo)
        {

            if (MaHoSo == "0" || MaHoSo == "")
                return null;
            
            
            try
            {
                int _hs = Convert.ToInt32(MaHoSo);
                var ds = from td in db.tblThuaDatDuBis
                         where td.MaHoSoKeKhai == _hs
                         select td;
                return ds.ToList<tblThuaDatDuBi>();
            }
            catch (Exception)
            {
                return null;
            }
            

        }
        public bool ThemThuaDatDuBi(string MaHoSo, string ToBanDo, string SoThua, string DiaChi, string DienTich, string SuDungChung, string SuDungRieng, string NguonGoc, string MucDich, string CoHanChe, string HanChe, string SuDungTuNgay, string ThoiHan)
        {
            try
            {
                bool _coHanChe = false;
                if (CoHanChe.Trim().ToLower() == "true")
                    _coHanChe = true;
                else
                    _coHanChe = false;

                tblThuaDatDuBi thuadatmoi = new tblThuaDatDuBi();
                thuadatmoi.MaHoSoKeKhai = Convert.ToInt32(MaHoSo);
                thuadatmoi.ToBanDo = ToBanDo;
                thuadatmoi.SoThua = SoThua;
                thuadatmoi.DiaChi = DiaChi;
                thuadatmoi.DienTich = DienTich;
                thuadatmoi.SuDungChung = SuDungChung;
                thuadatmoi.SuDungRieng = SuDungRieng;
                thuadatmoi.LoaiNguonGocSuDung = NguonGoc;
                thuadatmoi.MucDichSuDung = MucDich;
                thuadatmoi.CoHanCheSuDung = _coHanChe;
                thuadatmoi.NoiDungHanCheSuDung = HanChe;
                thuadatmoi.NgayBatDauSuDung =Convert.ToDateTime( SuDungTuNgay);
                thuadatmoi.ThoiHanSuDung = ThoiHan;

                db.tblThuaDatDuBis.Add(thuadatmoi);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool SuaThuaDatDuBi(string MaThuaDat, string MaHoSo, string ToBanDo, string SoThua, string DiaChi, string DienTich, string SuDungChung, string SuDungRieng, string NguonGoc, string MucDich, string CoHanChe, string HanChe, string SuDungTuNgay, string ThoiHan)
        {
            try
            {
                bool _coHanChe = false;
                if (CoHanChe.Trim().ToLower() == "true")
                    _coHanChe = true;
                else
                    _coHanChe = false;



                long _maThuaDat = long.Parse(MaThuaDat);
                tblThuaDatDuBi thuadatcansua = db.tblThuaDatDuBis.Single(td => td.MaThuaDat == _maThuaDat);

                thuadatcansua.MaHoSoKeKhai = Convert.ToInt32(MaHoSo);
                thuadatcansua.ToBanDo = ToBanDo;
                thuadatcansua.SoThua = SoThua;
                thuadatcansua.DiaChi = DiaChi;
                thuadatcansua.DienTich = DienTich;
                thuadatcansua.SuDungChung = SuDungChung;
                thuadatcansua.SuDungRieng = SuDungRieng;
                thuadatcansua.LoaiNguonGocSuDung = NguonGoc;
                thuadatcansua.MucDichSuDung = MucDich;
                thuadatcansua.CoHanCheSuDung = _coHanChe;
                thuadatcansua.NoiDungHanCheSuDung = HanChe;
                thuadatcansua.NgayBatDauSuDung = Convert.ToDateTime(SuDungTuNgay);
                thuadatcansua.ThoiHanSuDung = ThoiHan;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool XoaThuaDatDuBi(string MaThuaDat)
        {
            try
            {
                long _maThuaDat = long.Parse(MaThuaDat);
                tblThuaDatDuBi thuadatcanxoa = db.tblThuaDatDuBis.Single(td => td.MaThuaDat == _maThuaDat);
                db.tblThuaDatDuBis.Remove(thuadatcanxoa);

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }



        public List<tblThongTinNhaODuBi> dsNhaODuBi(string MaHoSo)
        {

            if (MaHoSo == "0" || MaHoSo == "")
                return null;
            int _hs = Convert.ToInt32(MaHoSo);
            var kq = from n in db.tblThongTinNhaODuBis
                     where n.MaHoSoKeKhai == _hs
                     select n;
            return kq.ToList<tblThongTinNhaODuBi>();

        }
        public bool ThemNhaODuBi(string MaHoSo, string LoaiNhaO, string DienTichXayDung, string DienTichSan, string KetCau, string SoTang, string SoHuuChung, string SoHuuRieng, string CoHanChe, string HanChe)
        {
            try
            {
                bool _cohanche =false;
                if (CoHanChe.ToLower() == "true")
                    _cohanche = true;
                else
                    _cohanche = false;

                tblThongTinNhaODuBi nhaNew = new tblThongTinNhaODuBi();
                nhaNew.MaHoSoKeKhai = Convert.ToInt32(MaHoSo);
                nhaNew.LoaiNhaO = LoaiNhaO;
                nhaNew.DienTichXayDung = DienTichXayDung;
                nhaNew.DienTichSan = DienTichSan;
                nhaNew.KetCau = KetCau;
                nhaNew.SoTang = SoTang;
                nhaNew.SoHuuChung = SoHuuChung;
                nhaNew.SoHuuRieng = SoHuuRieng;
                nhaNew.CoHanCheThoiHanSoHuu = _cohanche;
                nhaNew.ThoiHanSoHuu = HanChe;

                db.tblThongTinNhaODuBis.Add(nhaNew);
                db.SaveChanges();


                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool SuaNhaODuBi(string MaNhaO, string LoaiNhaO, string DienTichXayDung, string DienTichSan, string KetCau, string SoTang, string SoHuuChung, string SoHuuRieng, string CoHanChe, string HanChe)
        {
            try
            {
                bool _cohanche = false;
                if (CoHanChe.ToLower() == "true")
                    _cohanche = true;
                else
                    _cohanche = false;


                long _maNhaO = long.Parse(MaNhaO);
                tblThongTinNhaODuBi nhaSua = db.tblThongTinNhaODuBis.Single(n => n.MaNhaO == _maNhaO);

                nhaSua.LoaiNhaO = LoaiNhaO;
                nhaSua.DienTichXayDung = DienTichXayDung;
                nhaSua.DienTichSan = DienTichSan;
                nhaSua.KetCau = KetCau;
                nhaSua.SoTang = SoTang;
                nhaSua.SoHuuChung = SoHuuChung;
                nhaSua.SoHuuRieng = SoHuuRieng;
                nhaSua.CoHanCheThoiHanSoHuu = _cohanche;
                nhaSua.ThoiHanSoHuu = HanChe;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool XoaNhaODuBi(string MaNhaO)
        {
            try
            {
                long _maNhaO = long.Parse(MaNhaO);
                tblThongTinNhaODuBi nhaXoa = db.tblThongTinNhaODuBis.Single(n => n.MaNhaO == _maNhaO);
                db.tblThongTinNhaODuBis.Remove(nhaXoa);

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        /// <summary>
        /// Hiển thi thông tin về đơn.
        /// </summary>
        /// <param name="MaHoSo"></param>
        public tblHoSoKeKhaiDuBi LayThongTinXetDuyetCapCSDuBi(string MaHoSo)
        {
            try
            {
                long _maHS = long.Parse(MaHoSo);
                tblHoSoKeKhaiDuBi HS = db.tblHoSoKeKhaiDuBis.Single(h => h.MaHoSoKeKhai == _maHS);
                return HS;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool LuuThongTinXetDuyetCapCSDuBi(string MaHoSo, string TieuDe, string NguoiGui, string LoaiDeNghi, string NghiaVuTC , string GiayToKemTheo, string DeNghiKhac, string Email, string DienThoai, string NguoiNhan, string NgayNhan, string SotiepNhan, string Quyen)
        {
            try
            {
                long _maHS = long.Parse(MaHoSo);
                tblHoSoKeKhaiDuBi HS = db.tblHoSoKeKhaiDuBis.Single(h => h.MaHoSoKeKhai == _maHS);

                HS.KinhGuiCoQuanChucNang = TieuDe;
                HS.NguoiVietDon = NguoiGui;
                HS.MaLoaiDeNghi = LoaiDeNghi;
                HS.NghiaVuTaiChinh = NghiaVuTC;
                HS.GiayToKemTheo = GiayToKemTheo;
                HS.DeNghiKhac = DeNghiKhac;
                HS.DiaChiMail = Email;
                HS.SoDienThoaiLienHe = DienThoai;
                HS.NguoiNhanHoSo = NguoiNhan;
                if(NgayNhan.Trim() !="")
                    HS.NgayNhanHoSo =Convert.ToDateTime( NgayNhan);
                HS.SoTiepNhan = SotiepNhan;
                HS.Quyen = Quyen;

                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                string s = ex.Message;
                return false;
            }
        }

        public bool GuiHoSoDi(string MaHoSo)
        {
            try
            {
                long _maHS = long.Parse(MaHoSo);
                tblHoSoKeKhaiDuBi HS = db.tblHoSoKeKhaiDuBis.Single(h => h.MaHoSoKeKhai == _maHS);
                HS.DaGuiDi = true;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                string s = ex.Message;
                return false;
            }
        }
        



        //************************ QUAN TRỌNG!
        // ĐÂY LÀ PHẦN CHẤP NHẬN HỒ SƠ, CẬP NHẬT VÀ TÁC DỘNG ĐẾN NHIỀU BẢNG
        // NÊN CẦN DÀNH THỜI GIAN XEM XÉT KỸ LẠI PHẦN NÀY!
        public bool KiemTraDuDieuKienChapNhan(string MaHoSoKeKhai)
        {
            try
            {
                long _maHS = long.Parse(MaHoSoKeKhai);
                tblHoSoKeKhaiDuBi HS = db.tblHoSoKeKhaiDuBis.Single(h => h.MaHoSoKeKhai == _maHS);
                if (HS.SoTiepNhan.Trim() == "" && HS.Quyen.Trim() == "")
                    return false;
                else
                    return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool ChapNhanHoSo(string MaHoSoKeKhai)
        {
           
            try
            {
                long _maHS = long.Parse(MaHoSoKeKhai);
                tblHoSoKeKhaiDuBi HS = db.tblHoSoKeKhaiDuBis.Single(h => h.MaHoSoKeKhai == _maHS);

                //-- tao ho so moi
                tblHoSo HoSoMoi = new tblHoSo();
                db.tblHoSoes.Add(HoSoMoi);

                //-- them vao bang ho so

                tblHoSoKeKhai HSKK = new tblHoSoKeKhai();
                HSKK.KinhGuiCoQuanChucNang = HS.KinhGuiCoQuanChucNang;
                HSKK.NgayNhanHoSo = HS.NgayNhanHoSo;
                HSKK.NguoiNhanHoSo = HS.NguoiNhanHoSo;
                HSKK.SoTiepNhan = HS.SoTiepNhan;
                HSKK.Quyen = HS.Quyen;
                HSKK.NguoiVietDon = HS.NguoiVietDon;
                HSKK.DonViHanhChinh = HS.DonViHanhChinh;
                HSKK.GiayToKemTheo = HS.GiayToKemTheo;
                HSKK.NghiaVuTaiChinh = HS.NghiaVuTaiChinh;
                HSKK.DeNghiKhac = HS.DeNghiKhac;
                HSKK.SoDienThoaiLienHe = HS.SoDienThoaiLienHe;
                HSKK.DiaChiMail = HS.DiaChiMail;
                HSKK.MaLoaiDeNghi = HS.MaLoaiDeNghi;

                HSKK.MaHoSo =_maHS;
                db.tblHoSoKeKhais.Add(HSKK);

                //-- insert vao bang hosokekhaiduocchapnhan

                tblHoSoKeKhaiDuocChapNhan HSKKDCN = new tblHoSoKeKhaiDuocChapNhan();
                HSKKDCN.MaHoSoKeKhai = HSKK.MaHoSoKeKhai;
                HSKKDCN.MaHoSoKeKhaiDuBi = HS.MaHoSoKeKhai;
                HSKKDCN.NgayThucHien = DateTime.Today;

                db.tblHoSoKeKhaiDuocChapNhans.Add(HSKKDCN);

                //-- insert vao bang hoso

                HoSoMoi.LoaiDoiTuong = HS.MaLoaiDoiTuong;
                HoSoMoi.DonViHanhChinh = HS.DonViHanhChinh;
                HoSoMoi.TrangThaiHoSoCapGCN = "1";
                //HoSoMoi.TongSoThua se cap nhat o phan thua dat...

                //-- insert vao bang thuadat
                List<tblThuaDatDuBi> dsThuaDat = (from td in db.tblThuaDatDuBis
                                                  where td.MaHoSoKeKhai == HS.MaHoSoKeKhai
                                                  select td).ToList<tblThuaDatDuBi>();

                if (dsThuaDat.Count > 0)
                {
                    HoSoMoi.TongSoThua = dsThuaDat.Count;
                    for (int i = 0; i < dsThuaDat.Count; i++)
                    {
                        tblThuaDat ThuaDaMoi = new tblThuaDat();

                        ThuaDaMoi.MaHoSo = dsThuaDat[i].MaHoSoKeKhai;
                        ThuaDaMoi.ToBanDo = dsThuaDat[i].ToBanDo;
                        ThuaDaMoi.SoThua = dsThuaDat[i].SoThua;
                        ThuaDaMoi.DiaChi = dsThuaDat[i].DiaChi;
                        ThuaDaMoi.DienTich = dsThuaDat[i].DienTich;
                        ThuaDaMoi.SuDungChung = dsThuaDat[i].SuDungChung;
                        ThuaDaMoi.SuDungRieng = dsThuaDat[i].SuDungRieng;
                        ThuaDaMoi.MucDichSuDung = dsThuaDat[i].MucDichSuDung;
                        ThuaDaMoi.ThoiHanSuDung = dsThuaDat[i].ThoiHanSuDung;
                        ThuaDaMoi.NgayBatDauSuDung = dsThuaDat[i].NgayBatDauSuDung;
                        ThuaDaMoi.LoaiNguonGocSuDung = dsThuaDat[i].LoaiNguonGocSuDung;
                        ThuaDaMoi.CoHanCheSuDung = dsThuaDat[i].CoHanCheSuDung.ToString();
                        ThuaDaMoi.NoiDungHanCheSuDung = dsThuaDat[i].NoiDungHanCheSuDung;

                        db.tblThuaDats.Add(ThuaDaMoi);

                    }
                }
                //-- insert vao bang nhao
                List<tblThongTinNhaODuBi> dsNhaO = (from n in db.tblThongTinNhaODuBis
                                                    where n.MaHoSoKeKhai == _maHS
                                                    select n).ToList<tblThongTinNhaODuBi>();
                if (dsNhaO.Count > 0)
                {
                    for (int i = 0; i < dsNhaO.Count; i++)
                    {
                        tblThongTinNhaO NhaMoi = new tblThongTinNhaO();
                        NhaMoi.MaHoSo = dsNhaO[i].MaHoSoKeKhai;
                        NhaMoi.LoaiNhaO = dsNhaO[i].LoaiNhaO;
                        NhaMoi.DienTichXayDung = dsNhaO[i].DienTichXayDung;
                        NhaMoi.DienTichSan = dsNhaO[i].DienTichSan;
                        NhaMoi.SoHuuChung = dsNhaO[i].SoHuuChung;
                        NhaMoi.SoHuuRieng = dsNhaO[i].SoHuuRieng;
                        NhaMoi.KetCau = dsNhaO[i].KetCau;
                        NhaMoi.SoTang = dsNhaO[i].SoTang;
                        NhaMoi.CoHanCheThoiHanSoHuu = dsNhaO[i].CoHanCheThoiHanSoHuu;
                        NhaMoi.ThoiHanSoHuu = dsNhaO[i].ThoiHanSoHuu;

                        db.tblThongTinNhaOs.Add(NhaMoi);

                    }
                }
                //-- insert vao bang chuhoso va bang chu
                List<tblChuHoSoDuBi> dsChuHS = (from chs in db.tblChuHoSoDuBis
                                                where chs.MaHoSoKeKhai == _maHS
                                                select chs).ToList<tblChuHoSoDuBi>();
                
                if (dsChuHS.Count > 0)
                {
                    for (int i = 0; i < dsChuHS.Count; i++)
                    {
                        tblChuHoSo ChuHS = new tblChuHoSo();
                        ChuHS.MaChu = dsChuHS[i].MaChu;
                        ChuHS.MaHoSo = _maHS;

                        db.tblChuHoSoes.Add(ChuHS);

                        long ma =(long)dsChuHS[i].MaChu;
                        tblChuDuBi chudubi = db.tblChuDuBis.Single(c => c.MaChu == ma);
                        tblChu Chu = new tblChu();
                        Chu.DanhXung = chudubi.DanhXung;
                        Chu.HoTen = chudubi.HoTen;
                        Chu.NamSinh = chudubi.NamSinh;
                        Chu.DiaChi = chudubi.DiaChi;
                        Chu.DinhDanh = chudubi.DinhDanh;
                        Chu.SoDinhDanh = chudubi.SoDinhDanh;
                        Chu.NoiCap = chudubi.NoiCap;
                        Chu.NgayCap = chudubi.NgayCap;
                        Chu.QuocTich = chudubi.QuocTich;

                        db.tblChus.Add(Chu);
                    }
                }


                //LƯU LẠI LẦN 1
                db.SaveChanges();



                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
            
           
        }

        public bool XoaHoSoDuBi(string MaHoSoKeKhai)
        {
            try
            {
                long _maHoSo = long.Parse(MaHoSoKeKhai);
               
                //-- xoa trong bang chuhoso va chu du bi
                List<tblChuHoSoDuBi> dsChuHS_xoa = (from chs in db.tblChuHoSoDuBis
                                                    where chs.MaHoSoKeKhai == _maHoSo
                                                    select chs).ToList();
                if(dsChuHS_xoa.Count>0)
                {
                    for(int i=0;i<dsChuHS_xoa.Count;i++)
                    {
                        long ma = (long)dsChuHS_xoa[i].MaChu;
                        tblChuDuBi Chu_xoa = db.tblChuDuBis.Single(n => n.MaChu == ma);
                        db.tblChuDuBis.Remove(Chu_xoa);
                        db.tblChuHoSoDuBis.Remove(dsChuHS_xoa[i]);                                             
                    }
                }
                //-- xoa trong bang nha o du bi
                var NhaO_xoa = from n in db.tblThongTinNhaODuBis
                               where n.MaHoSoKeKhai == _maHoSo
                               select n;
                db.tblThongTinNhaODuBis.RemoveRange(NhaO_xoa);

                //-- xoa trong bang thuadat du bi
                var ThuaDat_xoa = from td in db.tblThuaDatDuBis
                                  where td.MaHoSoKeKhai == _maHoSo
                                  select td;
                db.tblThuaDatDuBis.RemoveRange(ThuaDat_xoa);
                // -- xoa trong bang ho so ke khai du bi
                var HoSoKeKhai_xoa =( from h in db.tblHoSoKeKhaiDuBis
                                     where h.MaHoSoKeKhai==_maHoSo
                                     select h).SingleOrDefault();
                db.tblHoSoKeKhaiDuBis.Remove(HoSoKeKhai_xoa);

                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        //**************
























/// <summary>
/// LÀM VIỆC VỚI HỒ SƠ CHÍNH THỨC
/// </summary>
/// <param name="MaDVHC"></param>
/// <returns></returns>
        public int TaoHoSoMoi(string MaDVHC)
        {
            int i = 0;
            try
            {
                tblHoSo hsNew = new tblHoSo();
                hsNew.DonViHanhChinh = MaDVHC;

                db.tblHoSoes.Add(hsNew);
                db.SaveChanges();
                i = Convert.ToInt32(hsNew.MaHoSo);
            }
            catch (Exception ex)
            {

            }
            return i;

        }
        
        public List<tblChu> dsChu(string MaHoSo)
        {         
            if (MaHoSo == "0" || MaHoSo == "")
                return null;
            try
            {
                int _hs = Convert.ToInt32(MaHoSo);
                var kq = from ch in db.tblChuHoSoes where ch.MaHoSo == _hs select ch.MaChu;
                var ds = from c in db.tblChus
                         where kq.Contains(c.MaChu)
                         select c;
                return ds.ToList<tblChu>();
            }
            catch (Exception)
            {

                return null;
            }
            

        }
        public bool ThemChu(string MaHoSo ,string DanhXung, string HoTen, string NamSinh, string DiaChi, string DinhDanh, string SoDinhDanh, string NoiCap, string NgayCap, string QuocTich)
        {
            try
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


                tblChuHoSo chuhoso = new tblChuHoSo();
                chuhoso.MaChu = chumoi.MaChu;
                chuhoso.MaHoSo = Convert.ToInt32(MaHoSo);
                db.tblChuHoSoes.Add(chuhoso);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool SuaChu(string MaChu, string DanhXung, string HoTen, string NamSinh, string DiaChi, string DinhDanh, string SoDinhDanh, string NoiCap, string NgayCap, string QuocTich)
        {
            try
            {
                
                long _maChu = long.Parse(MaChu);
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
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool XoaChu(string MaChu)
        {
            try
            {
                long _maChu = long.Parse(MaChu);
                tblChu chucanxoa = db.tblChus.Single(c => c.MaChu == _maChu);
                db.tblChus.Remove(chucanxoa);

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        

        public List<tblThuaDat> dsThuaDat(string MaHoSo)
        {

            if (MaHoSo == "0" || MaHoSo == "")
                return null;


            try
            {
                int _hs = Convert.ToInt32(MaHoSo);
                var ds = from td in db.tblThuaDats
                         where td.MaHoSo == _hs
                         select td;
                return ds.ToList<tblThuaDat>();
            }
            catch (Exception)
            {
                return null;
            }


        }
        public bool ThemThuaDat(string MaHoSo, string ToBanDo, string SoThua, string DiaChi, string DienTich, string SuDungChung, string SuDungRieng, string NguonGoc, string MucDich, string CoHanChe, string HanChe, string SuDungTuNgay, string ThoiHan)
        {
            try
            {
                //bool _coHanChe = false;
                //if (CoHanChe.ToLower() == "true")
                //    _coHanChe = true;
                //else
                //    _coHanChe = false;

                tblThuaDat thuadatmoi = new tblThuaDat();
                thuadatmoi.MaHoSo = Convert.ToInt32(MaHoSo);
                thuadatmoi.ToBanDo = ToBanDo;
                thuadatmoi.SoThua = SoThua;
                thuadatmoi.DiaChi = DiaChi;
                thuadatmoi.DienTich = DienTich;
                thuadatmoi.SuDungChung = SuDungChung;
                thuadatmoi.SuDungRieng = SuDungRieng;
                thuadatmoi.LoaiNguonGocSuDung = NguonGoc;
                thuadatmoi.MucDichSuDung = MucDich;
                thuadatmoi.CoHanCheSuDung = CoHanChe;
                thuadatmoi.NoiDungHanCheSuDung = HanChe;
                thuadatmoi.NgayBatDauSuDung = Convert.ToDateTime(SuDungTuNgay);
                thuadatmoi.ThoiHanSuDung = ThoiHan;

                db.tblThuaDats.Add(thuadatmoi);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool SuaThuaDat(string MaThuaDat, string MaHoSo, string ToBanDo, string SoThua, string DiaChi, string DienTich, string SuDungChung, string SuDungRieng, string NguonGoc, string MucDich, string CoHanChe, string HanChe, string SuDungTuNgay, string ThoiHan)
        {
            try
            {

                long _maThuaDat = long.Parse(MaThuaDat);
                tblThuaDat thuadatcansua = db.tblThuaDats.Single(td => td.MaThuaDat == _maThuaDat);

                //bool _coHanChe = false;
                //if (CoHanChe.ToLower() == "true")
                //    _coHanChe = true;
                //else
                //    _coHanChe = false;

                thuadatcansua.MaHoSo = Convert.ToInt32(MaHoSo);
                thuadatcansua.ToBanDo = ToBanDo;
                thuadatcansua.SoThua = SoThua;
                thuadatcansua.DiaChi = DiaChi;
                thuadatcansua.DienTich = DienTich;
                thuadatcansua.SuDungChung = SuDungChung;
                thuadatcansua.SuDungRieng = SuDungRieng;
                thuadatcansua.LoaiNguonGocSuDung = NguonGoc;
                thuadatcansua.MucDichSuDung = MucDich;
                thuadatcansua.CoHanCheSuDung = CoHanChe;
                thuadatcansua.NoiDungHanCheSuDung = HanChe;
                thuadatcansua.NgayBatDauSuDung = Convert.ToDateTime(SuDungTuNgay);
                thuadatcansua.ThoiHanSuDung = ThoiHan;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool XoaThuaDat(string MaThuaDat)
        {
            try
            {
                long _maThuaDat = long.Parse(MaThuaDat);
                tblThuaDat thuadatcanxoa = db.tblThuaDats.Single(td => td.MaThuaDat == _maThuaDat);
                db.tblThuaDats.Remove(thuadatcanxoa);

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public List<tblThongTinNhaO> dsNhaO(string MaHoSo)
        {

            if (MaHoSo == "0" || MaHoSo == "")
                return null;
            int _hs = Convert.ToInt32(MaHoSo);
            var kq = from n in db.tblThongTinNhaOs
                     where n.MaHoSo == _hs
                     select n;
            return kq.ToList<tblThongTinNhaO>();

        }
       
        public bool ThemNhaO(string MaHoSo, string LoaiNhaO, string DienTichXayDung, string DienTichSan, string KetCau, string SoTang, string SoHuuChung, string SoHuuRieng, string CoHanChe, string HanChe)
        {
            try
            {
                bool _cohanche = false;
                if (CoHanChe.ToLower() == "true")
                    _cohanche = true;
                else
                    _cohanche = false;

                tblThongTinNhaO nhaNew = new tblThongTinNhaO();
                nhaNew.MaHoSo = Convert.ToInt32(MaHoSo);
                nhaNew.LoaiNhaO = LoaiNhaO;
                nhaNew.DienTichXayDung = DienTichXayDung;
                nhaNew.DienTichSan = DienTichSan;
                nhaNew.KetCau = KetCau;
                nhaNew.SoTang = SoTang;
                nhaNew.SoHuuChung = SoHuuChung;
                nhaNew.SoHuuRieng = SoHuuRieng;
                nhaNew.CoHanCheThoiHanSoHuu = _cohanche;
                nhaNew.ThoiHanSoHuu = HanChe;

                db.tblThongTinNhaOs.Add(nhaNew);
                db.SaveChanges();


                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool SuaNhaO(string MaNhaO, string LoaiNhaO, string DienTichXayDung, string DienTichSan, string KetCau, string SoTang, string SoHuuChung, string SoHuuRieng, string CoHanChe, string HanChe)
        {
            try
            {
                bool _cohanche = false;
                if (CoHanChe.ToLower() == "true")
                    _cohanche = true;
                else
                    _cohanche = false;


                long _maNhaO = long.Parse(MaNhaO);
                tblThongTinNhaO nhaSua = db.tblThongTinNhaOs.Single(n => n.MaNhaO == _maNhaO);

                nhaSua.LoaiNhaO = LoaiNhaO;
                nhaSua.DienTichXayDung = DienTichXayDung;
                nhaSua.DienTichSan = DienTichSan;
                nhaSua.KetCau = KetCau;
                nhaSua.SoTang = SoTang;
                nhaSua.SoHuuChung = SoHuuChung;
                nhaSua.SoHuuRieng = SoHuuRieng;
                nhaSua.CoHanCheThoiHanSoHuu = _cohanche;
                nhaSua.ThoiHanSoHuu = HanChe;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool XoaNhaO(string MaNhaO)
        {
            try
            {
                long _maNhaO = long.Parse(MaNhaO);
                tblThongTinNhaO nhaXoa = db.tblThongTinNhaOs.Single(n => n.MaNhaO == _maNhaO);
                db.tblThongTinNhaOs.Remove(nhaXoa);

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public tblHoSoKeKhai LayThongTinHoSoKeKhai(string MaHoSo)
        {
            try
            {
                long _maHS = long.Parse(MaHoSo);
                tblHoSoKeKhai HS = db.tblHoSoKeKhais.Single(h => h.MaHoSo == _maHS);
                return HS;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public tblXacNhanCapCoSo LayThongTinXacNhanCapCoSo(string MaHoSo)
        {
            try
            {
                long _maHS = long.Parse(MaHoSo);
                tblXacNhanCapCoSo xacnhan = db.tblXacNhanCapCoSoes.SingleOrDefault(n => n.MaHoSo == _maHS);
                return xacnhan;
            }
            catch (Exception)
            {
                
                return null;
            }
        }
        public tblXacNhanCoQuanDangKyDatDai LayThongTinXacNhanCoQuanDangKy(string MaHoSo)
        {
            try
            {
                long _maHS = long.Parse(MaHoSo);
                tblXacNhanCoQuanDangKyDatDai xacnhan = db.tblXacNhanCoQuanDangKyDatDais.SingleOrDefault(n => n.MaHoSo == _maHS);
                return xacnhan;
            }
            catch (Exception)
            {

                return null;
            }
        }
       
    }
}

