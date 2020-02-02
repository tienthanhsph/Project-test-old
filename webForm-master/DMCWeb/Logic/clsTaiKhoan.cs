using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMCWeb.Models;
namespace DMCWeb.Logic
{
    public class clsTaiKhoan
    {
        DMCWebEntities db = new DMCWebEntities();
        clsEncrypt mahoa = new clsEncrypt();
        public bool ThemTaiKhoan(string TenDangNhap, string MatKhau,  string HoTen, string MaQuyen, string NguoiQuanLy, string NgayTao, string ChucVu, string PhongBan,string DiaChi, string DienThoai)
        {
            try
            {
                tblUser newUser = new tblUser();
                newUser.TenDangNhap = TenDangNhap;
                newUser.MatKhau =mahoa.GetMD5( MatKhau);
                newUser.TenDayDu = HoTen;
                if (MaQuyen != "")
                    newUser.MaQuyen = int.Parse(MaQuyen);
                if (NguoiQuanLy != "")
                    newUser.NguoiQuanLy = int.Parse(NguoiQuanLy);
                if (NgayTao != "")
                    newUser.NgayTaoUser = Convert.ToDateTime(NgayTao);
                newUser.ChucVu = ChucVu;
                newUser.PhongBan = PhongBan;
                newUser.DiaChi = DiaChi;
                newUser.SoDienThoai = DienThoai;

                db.tblUsers.Add(newUser);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaTaiKhoan(string TenDangNhap, string HoTen, string MaQuyen, string NguoiQuanLy, string NgayTao, string ChucVu, string PhongBan, string DiaChi, string DienThoai)
        {
            try
            {
                tblUser user = db.tblUsers.SingleOrDefault(n => n.TenDangNhap == TenDangNhap);
                if( user != null)
                {
                    user.TenDayDu = HoTen;
                    if (MaQuyen != "")
                        user.MaQuyen = int.Parse(MaQuyen);
                    if (NguoiQuanLy != "")
                        user.NguoiQuanLy = int.Parse(NguoiQuanLy);
                    if (NgayTao != "")
                        user.NgayTaoUser = Convert.ToDateTime(NgayTao);
                    user.ChucVu = ChucVu;
                    user.PhongBan = PhongBan;
                    user.DiaChi = DiaChi;
                    user.SoDienThoai = DienThoai;


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


        public bool DoiMatKhau(string TenDangNhap,string MatKhauCu, string MatKhauMoi)
        {
            try
            {
                tblUser user = db.tblUsers.SingleOrDefault(n => n.TenDangNhap == TenDangNhap);
                if (user != null)
                {
                    if (user.MatKhau == mahoa.GetMD5( MatKhauCu))
                    {
                        user.MatKhau = mahoa.GetMD5( MatKhauMoi);
                        db.SaveChanges();
                        return true;
                    }
                    else return false;
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

        public tblUser XemTaiKhoan(string TenDangNhap)
        {
            try
            {
                tblUser user = db.tblUsers.SingleOrDefault(n => n.TenDangNhap == TenDangNhap);
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public tblUser DangNhap(string TenDangNhap, string MatKhau)
        {
            try
            {
                string MatKhauSoSanh = mahoa.GetMD5(MatKhau);
                tblUser user = db.tblUsers.SingleOrDefault(n => n.TenDangNhap == TenDangNhap && n.MatKhau == MatKhauSoSanh);
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}