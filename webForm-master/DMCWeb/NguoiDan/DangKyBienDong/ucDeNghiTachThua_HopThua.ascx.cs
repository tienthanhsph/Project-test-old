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
    public partial class ucDeNghiTachThua_HopThua : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    if (Session["DangKyBienDong"] != null)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());

                    }
                }
                catch (Exception)
                {

                    return;
                }
            }
            ApDungTrangThai();
        }
        XuLyDangKyBienDong don = new XuLyDangKyBienDong();
       
        public void EnableInput(bool enable)
        {
            txtLyDoTachHopThua.Enabled = txtGiayToLienQuan.Enabled = enable;

            Tach_HopThua.EnableInput(enable);
            
        }
        public void ApDungTrangThai()
        {
            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ChiXem)
            {
                btnLuuThongTinKeKhai.Enabled = false;
                EnableInput(false);
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua || (ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {

                btnLuuThongTinKeKhai.Enabled = true;
                EnableInput(true);

            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.KhongNhap)
            {

            }

            Tach_HopThua.ApDungTrangThai();
        }
        public void LoadThongTin(string MaDangKyBienDong)
        {
            if (Session["LoaiHoSo"] == "DuBi") {
                tblDonXinDangKyBienDongDuBi DonHienTai = don.LayDonDuBi(MaDangKyBienDong);
                if (DonHienTai != null)
                {
               
                    txtLyDoTachHopThua.Text= DonHienTai.LyDoBienDong;
                    txtGiayToLienQuan.Text = DonHienTai.GiayToKemTheo;

                }
            }
            else if (Session["LoaiHoSo"] == "ChinhThuc")
            {
                tblDonXinDangKyBienDong DonHienTai = don.LayDon(MaDangKyBienDong);
                if (DonHienTai != null)
                {

                    txtLyDoTachHopThua.Text = DonHienTai.LyDoBienDong;
                    txtGiayToLienQuan.Text = DonHienTai.GiayToKemTheo;

                }
            }
            else
            {
                return;
            }
            Tach_HopThua.LoadThongTin(MaDangKyBienDong);
            
        }
        protected void btnLuuThongTinKeKhai_Click(object sender, EventArgs e)
        {
            if (Session["LoaiHoSo"] == "DuBi") {
                bool success = don.LuuThongTinDangKyBienDongDuBi(Session["DangKyBienDong"].ToString(), "", "", "", "", "", "", "", "", txtLyDoTachHopThua.Text, "", txtGiayToLienQuan.Text, "", "", "");
            }
            else if (Session["LoaiHoSo"] == "ChinhThuc")
            {
                bool success = don.LuuThongTinDangKyBienDong(Session["DangKyBienDong"].ToString(), "", "", "", "", "", "", "", "", txtLyDoTachHopThua.Text, "", txtGiayToLienQuan.Text, "", "", "");
            }
            else
            {
                return;
            }
            EnableInput(false);
        }

        protected void btnSuaThongTinKeKhai_Click(object sender, EventArgs e)
        {
            EnableInput(true);
        }
       
       
    }
}