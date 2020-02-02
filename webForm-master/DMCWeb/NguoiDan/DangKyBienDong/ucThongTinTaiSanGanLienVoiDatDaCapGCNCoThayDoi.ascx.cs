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
    public partial class ucThongTinTaiSanGanLienVoiDatDaCapGCNCoThayDoi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ApDungTrangThai();
        }
        XuLyDangKyBienDong don = new XuLyDangKyBienDong();
        public void EnableInput(bool enable)
        {
            txtLoaiTaiSan1.Enabled = txtLoaiTaiSan2.Enabled = txtDienTich1.Enabled = txtDienTich2.Enabled = txtNoiDungKhac1.Enabled = txtNoiDungKhac2.Enabled = enable;
        }
        public void ApDungTrangThai() {
            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ChiXem)
            {
                EnableInput(false);
                btnThemTaiSan.Enabled = false;
                btnLuuThongTin.Enabled = false;
                btnHuy.Enabled = false;
                CapNhatThongTinTaiSanThayDoiDoBienDong.Visible = false;
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua || (ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {
                EnableInput(true);
                btnThemTaiSan.Enabled = false;
                btnLuuThongTin.Enabled = true;
                btnHuy.Enabled = true;
                CapNhatThongTinTaiSanThayDoiDoBienDong.Visible = true;
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.KhongNhap)
            {
                btnThemTaiSan.Enabled = true;
                btnLuuThongTin.Enabled = false;
                btnHuy.Enabled = false;
                CapNhatThongTinTaiSanThayDoiDoBienDong.Visible = false;
            }
        }
        public void LoadThongTin(string MaDangKyBienDong)
        {
            if (Session["DangKyBienDong"] != null)
            {
                try
                {
                    if (Session["LoaiHoSo"] == "DuBi") {
                        GridView1.DataSource = don.dsTaiSanDuBiThayDoi(Session["DangKyBienDong"].ToString());
                        GridView1.DataBind();
                    }
                    else if (Session["LoaiHoSo"] == "ChinhThuc")
                    {
                        GridView1.DataSource = don.dsTaiSanThayDoi(Session["DangKyBienDong"].ToString());
                        GridView1.DataBind();
                    }
                }
                catch (Exception)
                {

                    return;
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua) || ((ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi))
            {
                string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
                if (Session["LoaiHoSo"] == "DuBi") {                    
                    bool success = don.XoaTaiSanThayDoiDuBiTrongBienDong(id);
                    if (success)
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                    bool success = don.XoaTaiSanThayDoiTrongBienDong(id);
                    if (success)
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                }
                else
                {
                    return;
                }
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {

                Session["TaiSanThaoTac"] = e.CommandArgument.ToString();
                if (Session["LoaiHoSo"] == "DuBi") {
                    tblThongTinTaiSanGanLienVoiDatTrongBienDongDuBi taisandangxet = don.TaiSanDuBiDangXet(Session["TaiSanThaoTac"].ToString());

                    txtLoaiTaiSan1.Text = taisandangxet.LoaiTaiSan;
                    txtDienTich1.Text = taisandangxet.DienTichXayDung;
                    txtNoiDungKhac1.Text = taisandangxet.NoiDungThayDoi;

                    txtLoaiTaiSan2.Text = taisandangxet.LoaiTaiSanMoi;
                    txtDienTich2.Text = taisandangxet.DienTichXayDungMoi;
                    txtNoiDungKhac2.Text = taisandangxet.NoiDungThayDoiMoi;

                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                        tblThongTinTaiSanGanLienVoiDatTrongBienDong taisandangxet = don.TaiSanDangXet(Session["TaiSanThaoTac"].ToString());

                    txtLoaiTaiSan1.Text = taisandangxet.LoaiTaiSan;
                    txtDienTich1.Text = taisandangxet.DienTichXayDung;
                    txtNoiDungKhac1.Text = taisandangxet.NoiDungThayDoi;

                    txtLoaiTaiSan2.Text = taisandangxet.LoaiTaiSanMoi;
                    txtDienTich2.Text = taisandangxet.DienTichXayDungMoi;
                    txtNoiDungKhac2.Text = taisandangxet.NoiDungThayDoiMoi;
                }
                else
                {
                    return;
                }
            }
        }

        protected void btnThemTaiSan_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            Session["ThaoTac"] = ThaoTac.DangSua;
            ApDungTrangThai();
        }

        protected void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            if(Session["TaiSanThaoTac"].ToString() == "0")
            {
                if (Session["LoaiHoSo"] == "DuBi") {
                    bool success = don.ThemTaiSanThayDoiDuBiTrongBienDong(Session["DangKyBienDong"].ToString(), txtLoaiTaiSan1.Text, txtDienTich1.Text, txtNoiDungKhac1.Text, txtLoaiTaiSan2.Text, txtDienTich2.Text, txtNoiDungKhac2.Text);
                    if (success)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        Session["TaiSanThaoTac"]= "0";
                    }
                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                    bool success = don.ThemTaiSanThayDoiTrongBienDong(Session["DangKyBienDong"].ToString(), txtLoaiTaiSan1.Text, txtDienTich1.Text, txtNoiDungKhac1.Text, txtLoaiTaiSan2.Text, txtDienTich2.Text, txtNoiDungKhac2.Text);
                    if (success)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        Session["TaiSanThaoTac"] = "0";
                    }
                }
                else
                {
                    return;
                }
                    
            }
            else
            {
                if (Session["LoaiHoSo"] == "DuBi") {
                    bool success = don.SuaTaiSanThayDoiDuBiTrongBienDong(Session["TaiSanThaoTac"].ToString(), txtLoaiTaiSan1.Text, txtDienTich1.Text, txtNoiDungKhac1.Text, txtLoaiTaiSan2.Text, txtDienTich2.Text, txtNoiDungKhac2.Text);
                    if (success)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        Session["TaiSanThaoTac"] = "0";
                    }
                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                    bool success = don.SuaTaiSanThayDoiTrongBienDong(Session["TaiSanThaoTac"].ToString(), txtLoaiTaiSan1.Text, txtDienTich1.Text, txtNoiDungKhac1.Text, txtLoaiTaiSan2.Text, txtDienTich2.Text, txtNoiDungKhac2.Text);
                    if (success)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        Session["TaiSanThaoTac"] = "0";
                    }
                }
                else
                {
                    return;
                }
            }

            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }

        protected void ClearTextBox()
        {
            txtLoaiTaiSan1.Text = txtDienTich1.Text = txtNoiDungKhac1.Text = txtLoaiTaiSan2.Text = txtDienTich2.Text = txtNoiDungKhac2.Text = "";
        }
        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }
    }
}