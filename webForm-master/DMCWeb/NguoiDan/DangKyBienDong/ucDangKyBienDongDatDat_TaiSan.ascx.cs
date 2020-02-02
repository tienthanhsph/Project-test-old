using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Models;
using DMCWeb.Logic;

namespace DMCWeb.NguoiDan.DangKyBienDong
{
    public partial class ucDangKyBienDongDatDat_TaiSan : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                try
                {
                    if(Session["DangKyBienDong"] != null)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        ApDungTrangThai();
                    }
                }
                catch (Exception)
                {

                    return;
                }
            }
        }
        public void EnableInput(bool enable)
        {
            txtSoPhatHanhGCN.Enabled = txtSoVaoSoCapGCN.Enabled = txtNgayCapGCN.Enabled = txtLyDoBienDong.Enabled = txtNoiDungTrenGCNTruocBD.Enabled = txtNoiDungSauBD.Enabled = txtLyDoBienDong.Enabled = txtTinhHinhThucHienNghiaVuTaiChinh.Enabled = txtGiayToLienQuan.Enabled = txtNoiDungBienDongVe.Enabled = enable;
        }
        public void ApDungTrangThai()
        {
           
            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ChiXem)
            {
                btnLuuThongTinKeKhai.Enabled = false;
                btnSuaThongTinKeKhai.Enabled = false;
                EnableInput(false);
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua || (ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {

                btnLuuThongTinKeKhai.Enabled = true;
                btnSuaThongTinKeKhai.Enabled = false;
                EnableInput(true);

            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.KhongNhap)
            {
                btnLuuThongTinKeKhai.Enabled = true;
                btnSuaThongTinKeKhai.Enabled = true;
                EnableInput(false);
            }
        
        }
        protected void btnLuuThongTinKeKhai_Click(object sender, EventArgs e)
        {
            if (Session["LoaiHoSo"] == "DuBi")
            {
                bool success = don.LuuThongTinDangKyBienDongDuBi(Session["DangKyBienDong"].ToString(), "", "", txtSoVaoSoCapGCN.Text, txtSoPhatHanhGCN.Text, txtNgayCapGCN.Text, txtNoiDungBienDongVe.Text, txtNoiDungTrenGCNTruocBD.Text, txtNoiDungSauBD.Text, txtLyDoBienDong.Text, txtTinhHinhThucHienNghiaVuTaiChinh.Text, txtGiayToLienQuan.Text, "", "", "");

            }else if (Session["LoaiHoSo"] == "ChinhThuc")
            {
                bool success = don.LuuThongTinDangKyBienDong(Session["DangKyBienDong"].ToString(), "", "", txtSoVaoSoCapGCN.Text, txtSoPhatHanhGCN.Text, txtNgayCapGCN.Text, txtNoiDungBienDongVe.Text, txtNoiDungTrenGCNTruocBD.Text, txtNoiDungSauBD.Text, txtLyDoBienDong.Text, txtTinhHinhThucHienNghiaVuTaiChinh.Text, txtGiayToLienQuan.Text, "", "", "");
			}
            else
            {
                return;
            }
            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }
        XuLyDangKyBienDong don = new XuLyDangKyBienDong();
        public void LoadThongTin(string MaDangKyBienDong)
        {
            if (Session["LoaiHoSo"] == "DuBi") {
                tblDonXinDangKyBienDongDuBi DonHienTai = don.LayDonDuBi(MaDangKyBienDong);
                if(DonHienTai != null)
                {
                    txtSoVaoSoCapGCN.Text = DonHienTai.SoVaoSoCapGCN;
                    txtSoPhatHanhGCN.Text = DonHienTai.SoPhatHanhGCN;
                    if (DonHienTai.NgayCapGCN != null)
                        txtNgayCapGCN.Text = DonHienTai.NgayCapGCN.ToString();
                    txtNoiDungBienDongVe.Text = DonHienTai.BienDongVe;
                    txtNoiDungTrenGCNTruocBD.Text = DonHienTai.NoiDungGhiTrenGCNTruocKhiBienDong;
                    txtNoiDungSauBD.Text = DonHienTai.NoiDungSauKhiBienDong;
                    txtLyDoBienDong.Text = DonHienTai.LyDoBienDong;
                    txtTinhHinhThucHienNghiaVuTaiChinh.Text = DonHienTai.TinhHinhThucHienNghiaVuTaiChinh;
                    txtGiayToLienQuan.Text = DonHienTai.GiayToKemTheo;

                }
            }
            else if (Session["LoaiHoSo"] == "ChinhThuc")
            {
                tblDonXinDangKyBienDong DonHienTai = don.LayDon(MaDangKyBienDong);
                if (DonHienTai != null)
                {
                    txtSoVaoSoCapGCN.Text = DonHienTai.SoVaoSoCapGCN;
                    txtSoPhatHanhGCN.Text = DonHienTai.SoPhatHanhGCN;
                    if (DonHienTai.NgayCapGCN != null)
                        txtNgayCapGCN.Text = DonHienTai.NgayCapGCN.ToString();
                    txtNoiDungBienDongVe.Text = DonHienTai.BienDongVe;
                    txtNoiDungTrenGCNTruocBD.Text = DonHienTai.NoiDungGhiTrenGCNTruocKhiBienDong;
                    txtNoiDungSauBD.Text = DonHienTai.NoiDungSauKhiBienDong;
                    txtLyDoBienDong.Text = DonHienTai.LyDoBienDong;
                    txtTinhHinhThucHienNghiaVuTaiChinh.Text = DonHienTai.TinhHinhThucHienNghiaVuTaiChinh;
                    txtGiayToLienQuan.Text = DonHienTai.GiayToKemTheo;

                }
            }
            else
            {
                return;
            }
        }

        protected void btnSuaThongTinKeKhai_Click(object sender, EventArgs e)
        {
            Session["ThaoTac"] = ThaoTac.DangSua;
            ApDungTrangThai();
        }
    }
}