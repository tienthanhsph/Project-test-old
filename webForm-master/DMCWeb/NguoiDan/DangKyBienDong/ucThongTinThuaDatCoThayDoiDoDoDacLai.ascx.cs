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
    public partial class ucThongTinThuaDatCoThayDoiDoDoDacLai : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ApDungTrangThai();
        }
        XuLyDangKyBienDong don = new XuLyDangKyBienDong();
        public void EnableInput(bool enable)
        {
            txtToBanDo1.Enabled =txtThuaDat1.Enabled = txtDienTich1.Enabled =txtNoiDungKhac1.Enabled=txtToBanDo2.Enabled =txtThuaDat2.Enabled = txtDienTich2.Enabled =txtNoiDungKhac2.Enabled= enable;
        }
        public void ApDungTrangThai() {

            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ChiXem)
            {               
                EnableInput(false);
                btnThemThuaDat.Enabled = false;
                btnLuuThongTin.Enabled = false;
                btnHuy.Enabled = false;
                CapNhatThongTinThuaDatThayDoiDoBienDong.Visible = false;

            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua || (ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {                
                EnableInput(true);
                btnThemThuaDat.Enabled = false;
                btnLuuThongTin.Enabled = true;
                btnHuy.Enabled = true;
                CapNhatThongTinThuaDatThayDoiDoBienDong.Visible = true;
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.KhongNhap)
            {
                EnableInput(false);
                btnThemThuaDat.Enabled = true;
                btnLuuThongTin.Enabled = false;
                btnHuy.Enabled = false;
                CapNhatThongTinThuaDatThayDoiDoBienDong.Visible = false;
            }
        }
        public void LoadThongTin(string MaDangKyBienDong)
        {
            if (Session["DangKyBienDong"] != null)
            {
                try
                {
                    if (Session["LoaiHoSo"] == "DuBi") {
                        GridView1.DataSource = don.dsThuaDatThayDoiDuBi(Session["DangKyBienDong"].ToString());
                        GridView1.DataBind();
                    }
                    else if (Session["LoaiHoSo"] == "ChinhThuc")
                    {
                        GridView1.DataSource = don.dsThuaDatThayDoi(Session["DangKyBienDong"].ToString());
                        GridView1.DataBind();
                    }
                    else
                    {
                        return;
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
            if(((ThaoTac)Session["ThaoTac"]== ThaoTac.DangSua) || ((ThaoTac)Session["ThaoTac"]== ThaoTac.ThemMoi)){
               string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
                if (Session["LoaiHoSo"] == "DuBi") {
                    bool success = don.XoaThuaDatThayDoiDuBiTrongBienDong(id);
                    if(success)
                        LoadThongTin(Session["DangKyBienDong"].ToString());

                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                    bool success = don.XoaThuaDatThayDoiTrongBienDong(id);
                    if (success)
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                }
                else
                {
                    return;
                }
            }
        }

        protected void btnThemThuaDat_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            Session["ThaoTac"] = ThaoTac.DangSua;
            ApDungTrangThai();
        }

        protected void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            if(Session["ThuaDatThaoTac"].ToString() == "0")
            {
                if (Session["LoaiHoSo"] == "DuBi") {
                    bool success = don.ThemThuaDatThayDoiTrongBienDongDuBi(Session["DangKyBienDong"].ToString(), txtToBanDo1.Text, txtThuaDat1.Text, txtDienTich1.Text, txtNoiDungKhac1.Text, txtToBanDo2.Text, txtThuaDat2.Text, txtDienTich2.Text, txtNoiDungKhac2.Text);
                    if (success)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        Session["ThuaDatThaoTac"]= "0";
                    }
                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                    bool success = don.ThemThuaDatThayDoiTrongBienDong(Session["DangKyBienDong"].ToString(), txtToBanDo1.Text, txtThuaDat1.Text, txtDienTich1.Text, txtNoiDungKhac1.Text, txtToBanDo2.Text, txtThuaDat2.Text, txtDienTich2.Text, txtNoiDungKhac2.Text);
                    if (success)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        Session["ThuaDatThaoTac"] = "0";
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
                    bool success = don.SuaThuaDatThayDoiDuBiTrongBienDong(Session["ThuaDatThaoTac"].ToString(), txtToBanDo1.Text, txtThuaDat1.Text, txtDienTich1.Text, txtNoiDungKhac1.Text, txtToBanDo2.Text, txtThuaDat2.Text, txtDienTich2.Text, txtNoiDungKhac2.Text);
                    if(success)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        Session["ThuaDatThaoTac"] = "0";
                    }
                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                    bool success = don.SuaThuaDatThayDoiTrongBienDong(Session["ThuaDatThaoTac"].ToString(), txtToBanDo1.Text, txtThuaDat1.Text, txtDienTich1.Text, txtNoiDungKhac1.Text, txtToBanDo2.Text, txtThuaDat2.Text, txtDienTich2.Text, txtNoiDungKhac2.Text);
                    if (success)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        Session["ThuaDatThaoTac"] = "0";
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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                
                Session["ThuaDatThaoTac"] = e.CommandArgument.ToString();
                if (Session["LoaiHoSo"] == "DuBi") {
                    tblThuaDatThayDoiTrongBienDongDuBi thuadangxet = don.ThuaDuBiDangXet(Session["ThuaDatThaoTac"].ToString());
                    txtThuaDat1.Text = thuadangxet.ToBanDo;
                    txtToBanDo1.Text = thuadangxet.SoThua;
                    txtDienTich1.Text = thuadangxet.DienTich;
                    txtNoiDungKhac1.Text = thuadangxet.NoiDungThayDoiKhac;

                    txtThuaDat2.Text = thuadangxet.SoThuaMoi;
                    txtToBanDo2.Text = thuadangxet.ToBanDoMoi;
                    txtDienTich2.Text = thuadangxet.DienTichMoi;
                    txtNoiDungKhac2.Text = thuadangxet.NoiDungThayDoiKhacMoi;
                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                    tblThuaDatThayDoiTrongBienDong thuadangxet = don.ThuaDangXet(Session["ThuaDatThaoTac"].ToString());
                    txtThuaDat1.Text = thuadangxet.ToBanDo;
                    txtToBanDo1.Text = thuadangxet.SoThua;
                    txtDienTich1.Text = thuadangxet.DienTich;
                    txtNoiDungKhac1.Text = thuadangxet.NoiDungThayDoiKhac;

                    txtThuaDat2.Text = thuadangxet.SoThuaMoi;
                    txtToBanDo2.Text = thuadangxet.ToBanDoMoi;
                    txtDienTich2.Text = thuadangxet.DienTichMoi;
                    txtNoiDungKhac2.Text = thuadangxet.NoiDungThayDoiKhacMoi;
                }
                else
                {
                    return;
                }
            }
        }

        protected void ClearTextBox()
        {
            txtThuaDat1.Text ="";
            txtToBanDo1.Text = "";
            txtDienTich1.Text = "";
            txtNoiDungKhac1.Text = "";

            txtThuaDat2.Text = "";
            txtToBanDo2.Text = "";
            txtDienTich2.Text = "";
            txtNoiDungKhac2.Text = "";
        }
        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }
    }
}