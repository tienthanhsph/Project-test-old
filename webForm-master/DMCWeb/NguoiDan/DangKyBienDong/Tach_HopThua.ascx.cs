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
    public partial class Tach_HopThua : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["ThuaDatThaoTac"] = "0";
            ApDungTrangThai();
        }
        XuLyDangKyBienDong don = new XuLyDangKyBienDong();
        public void EnableInput(bool enable)
        {
            EnableTachThua(enable);
            EnableHopThua(enable);
        }
        public void EnableTachThua(bool enable)
        {
            txtSoThuaTachRa.Enabled = txtToBanDo.Enabled = txtSoThua.Enabled = txtDiaChiThua.Enabled = txtSoPhatHanhGCN.Enabled = txtSoVaoSoCapGCN.Enabled = txtNgayCapGCN.Enabled = txtTT_DienTichThua1.Enabled = txtTT_DienTichThua2.Enabled = enable;
        }
        public void EnableHopThua(bool enable)
        {
            txtHT_DiaChiThua.Enabled = txtHT_SoPhatHanh.Enabled = txtHT_SoVaoSo.Enabled = txtHT_ThuaDatSo.Enabled = txtHT_ToBanDo.Enabled = enable;
        }
        public void ApDungTrangThai()
        {

            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ChiXem)
            {
                //EnableInput(false);
                
                btnLuuThongTinThuaCanTach.Enabled = false;
                btnSuaThongTinThuaCanTach.Enabled = false;
                btnThemThuaCanHop.Enabled = false;
                btnLuuThuaCanHop.Enabled = false;
                btnHuy.Enabled = false;
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua || (ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {
                //EnableInput(true);
               
                btnLuuThongTinThuaCanTach.Enabled = true;
                btnSuaThongTinThuaCanTach.Enabled = false;
                btnThemThuaCanHop.Enabled = false;
                btnLuuThuaCanHop.Enabled = true;
                btnHuy.Enabled = true;

            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.KhongNhap)
            {
                btnLuuThongTinThuaCanTach.Enabled = false;
                btnSuaThongTinThuaCanTach.Enabled = true;
                btnThemThuaCanHop.Enabled = true;
                btnLuuThuaCanHop.Enabled = false;
                btnHuy.Enabled = false;
            }
        }
        public void LoadThongTin(string MaDangKyBienDong)
        {
            if (Session["DangKyBienDong"] != null)
            {
                try
                {
                    if (Session["LoaiHoSo"] == "DuBi") {
                        grvThuaDatDeNghiHopThua.DataSource = don.dsThuaDatDeNghiHopThuaTheoDon(Session["DangKyBienDong"].ToString());
                        grvThuaDatDeNghiHopThua.DataBind();

                        tblThuaDatDeNghiTachThuaTrongBienDongTheoDon thua = don.LayThuaDeNghiTachTheoDon(Session["DangKyBienDong"].ToString());
                        if (thua != null)
                        {
                            txtSoThuaTachRa.Text = thua.SoThuaConDeNghiTach;
                            txtToBanDo.Text = thua.ToBanDo;
                            txtSoThua.Text = thua.SoThua;
                            txtDiaChiThua.Text = thua.DiaChi;
                            txtSoPhatHanhGCN.Text = thua.SoPhatHanhGCN;
                            txtSoVaoSoCapGCN.Text = thua.SoVaoSoCapGCN;
                            if (thua.NgayCapGCN != null)
                                txtNgayCapGCN.Text = thua.NgayCapGCN.ToString();
                            txtTT_DienTichThua1.Text = thua.DienTichCon1;
                            txtTT_DienTichThua2.Text = thua.DienTichCon2;
                        }
                    }
                    else if (Session["LoaiHoSo"] == "ChinhThuc")
                    {
                        grvThuaDatDeNghiHopThua.DataSource = don.dsThuaDatDeNghiHopThua(Session["DangKyBienDong"].ToString());
                        grvThuaDatDeNghiHopThua.DataBind();

                        tblThuaDatDeNghiTachThuaTrongBienDong thua = don.LayThuaDeNghiTach(Session["DangKyBienDong"].ToString());
                        if (thua != null)
                        {
                            txtSoThuaTachRa.Text = thua.SoThuaConDeNghiTach;
                            txtToBanDo.Text = thua.ToBanDo;
                            txtSoThua.Text = thua.SoThua;
                            txtDiaChiThua.Text = thua.DiaChi;
                            txtSoPhatHanhGCN.Text = thua.SoPhatHanhGCN;
                            txtSoVaoSoCapGCN.Text = thua.SoVaoSoCapGCN;
                            if (thua.NgayCapGCN != null)
                                txtNgayCapGCN.Text = thua.NgayCapGCN.ToString();
                            txtTT_DienTichThua1.Text = thua.DienTichCon1;
                            txtTT_DienTichThua2.Text = thua.DienTichCon2;
                        }
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
        protected void btnLuuThongTinThuaCanTach_Click(object sender, EventArgs e)
        {
            
            if(don.LayMaThuaDeNghiTach(Session["DangKyBienDong"].ToString()) =="0")
            {
                if (Session["LoaiHoSo"] == "DuBi")
                {
                    bool success = don.ThemThuaDatDeNghiTachThuaTrongBienDongTheoDon(Session["DangKyBienDong"].ToString(), txtSoThuaTachRa.Text, txtToBanDo.Text, txtSoThua.Text, txtDiaChiThua.Text, txtSoPhatHanhGCN.Text, txtSoVaoSoCapGCN.Text, txtNgayCapGCN.Text, txtTT_DienTichThua1.Text, txtTT_DienTichThua2.Text);
                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                    bool success = don.ThemThuaDatDeNghiTachThuaTrongBienDong(Session["DangKyBienDong"].ToString(), txtSoThuaTachRa.Text, txtToBanDo.Text, txtSoThua.Text, txtDiaChiThua.Text, txtSoPhatHanhGCN.Text, txtSoVaoSoCapGCN.Text, txtNgayCapGCN.Text, txtTT_DienTichThua1.Text, txtTT_DienTichThua2.Text);
                }
            }
            else
            {
                if (Session["LoaiHoSo"] == "DuBi")
                {
                    bool success = don.SuaThuaDatDeNghiTachThuaTrongBienDongTheoDon(don.LayMaThuaDeNghiTach(Session["DangKyBienDong"].ToString()), txtSoThuaTachRa.Text, txtToBanDo.Text, txtSoThua.Text, txtDiaChiThua.Text, txtSoPhatHanhGCN.Text, txtSoVaoSoCapGCN.Text, txtNgayCapGCN.Text, txtTT_DienTichThua1.Text, txtTT_DienTichThua2.Text);
                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                    bool success = don.SuaThuaDatDeNghiTachThuaTrongBienDong(don.LayMaThuaDeNghiTach(Session["DangKyBienDong"].ToString()), txtSoThuaTachRa.Text, txtToBanDo.Text, txtSoThua.Text, txtDiaChiThua.Text, txtSoPhatHanhGCN.Text, txtSoVaoSoCapGCN.Text, txtNgayCapGCN.Text, txtTT_DienTichThua1.Text, txtTT_DienTichThua2.Text);
                }
            }
            EnableTachThua(false);
            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (((ThaoTac)Session["ThaoTac"] != ThaoTac.ChiXem) && ((ThaoTac)Session["ThaoTac"] != ThaoTac.KhongCo))
            {
                string id = grvThuaDatDeNghiHopThua.DataKeys[e.RowIndex].Value.ToString();

                bool success = false;

                if (Session["LoaiHoSo"] == "DuBi")
                {
                    success = don.XoaThuaDatDeNghiHopThuaTheoDon(id);
                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                    success = don.XoaThuaDatDeNghiHopThua(id);
                }

                if (success)
                    LoadThongTin(Session["DangKyBienDong"].ToString());
            }
        }

       
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (((ThaoTac)Session["ThaoTac"] != ThaoTac.ChiXem) && ((ThaoTac)Session["ThaoTac"] != ThaoTac.KhongCo))
            {
                if (e.CommandName == "Select")
                {

                    Session["ThuaDatThaoTac"] = e.CommandArgument.ToString();
                    if (Session["LoaiHoSo"] == "DuBi")
                    {
                        tblThuaDatDeNghiHopThuaTrongBienDongTheoDon thuadangxet = don.LayThuaDatDeNghiHopThuaTheoDon(Session["ThuaDatThaoTac"].ToString());
                        string s = Session["ThuaDatThaoTac"].ToString();
                        if (thuadangxet != null)
                        {
                            txtHT_ThuaDatSo.Text = thuadangxet.SoThua;
                            txtHT_ToBanDo.Text = thuadangxet.ToBanDo;
                            txtHT_DiaChiThua.Text = thuadangxet.DiaChi;
                            txtHT_SoPhatHanh.Text = thuadangxet.SoPhatHanhGCN;
                            txtHT_SoVaoSo.Text = thuadangxet.SoVaoSoCapGCN;

                            Session["ThaoTac"] = ThaoTac.DangSua;
                            ApDungTrangThai();
                            EnableHopThua(true);
                        }
                    }
                    else if (Session["LoaiHoSo"] == "ChinhThuc")
                    {
                        tblThuaDatDeNghiHopThuaTrongBienDong thuadangxet = don.LayThuaDatDeNghiHopThua(Session["ThuaDatThaoTac"].ToString());
                        string s = Session["ThuaDatThaoTac"].ToString();
                        if (thuadangxet != null)
                        {
                            txtHT_ThuaDatSo.Text = thuadangxet.SoThua;
                            txtHT_ToBanDo.Text = thuadangxet.ToBanDo;
                            txtHT_DiaChiThua.Text = thuadangxet.DiaChi;
                            txtHT_SoPhatHanh.Text = thuadangxet.SoPhatHanhGCN;
                            txtHT_SoVaoSo.Text = thuadangxet.SoVaoSoCapGCN;

                            Session["ThaoTac"] = ThaoTac.DangSua;
                            ApDungTrangThai();
                            EnableHopThua(true);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        protected void btnSuaThongTinThuaCanTach_Click(object sender, EventArgs e)
        {
            EnableTachThua(true);
            Session["ThaoTac"] = ThaoTac.DangSua;
            ApDungTrangThai();
        }

        protected void ClearTextBox()
        {
            txtHT_ToBanDo.Text = txtHT_ThuaDatSo.Text = txtHT_DiaChiThua.Text = txtHT_SoPhatHanh.Text = txtHT_SoVaoSo.Text = "";
        }
        
        protected void btnThemThuaCanHop_Click(object sender, System.EventArgs e)
        {
             EnableHopThua(true);
             Session["ThaoTac"] = ThaoTac.DangSua;
             ApDungTrangThai();
            
        }

        protected void btnHuy_Click(object sender, System.EventArgs e)
        {
            EnableHopThua(false);
            ClearTextBox();
            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }

        protected void btnLuuThuaCanHop_Click(object sender, System.EventArgs e)
        {
            string s = Session["ThuaDatThaoTac"].ToString();
            if (Session["ThuaDatThaoTac"].ToString() == "0")
            {
                if (Session["LoaiHoSo"] == "DuBi") {
                    bool success = don.ThemThuaDatDeNghiHopThuaTheoDon(Session["DangKyBienDong"].ToString(), txtHT_ToBanDo.Text, txtHT_ThuaDatSo.Text, txtHT_DiaChiThua.Text, txtHT_SoPhatHanh.Text, txtHT_SoVaoSo.Text);
                    if (success)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        Session["ThuaDatThaoTac"] = 0;
                    }
                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                    bool success = don.ThemThuaDatDeNghiHopThua(Session["DangKyBienDong"].ToString(), txtHT_ToBanDo.Text, txtHT_ThuaDatSo.Text, txtHT_DiaChiThua.Text, txtHT_SoPhatHanh.Text, txtHT_SoVaoSo.Text);
                    if (success)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        Session["ThuaDatThaoTac"] = 0;
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
                    bool success = don.SuaThuaDatDeNghiHopThuaTheoDon(Session["ThuaDatThaoTac"].ToString(), txtHT_ToBanDo.Text, txtHT_ThuaDatSo.Text, txtHT_DiaChiThua.Text, txtHT_SoPhatHanh.Text, txtHT_SoVaoSo.Text);
                    if (success)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        Session["ThuaDatThaoTac"] = 0;
                    }
                }
                else if (Session["LoaiHoSo"] == "ChinhThuc")
                {
                    bool success = don.SuaThuaDatDeNghiHopThua(Session["ThuaDatThaoTac"].ToString(), txtHT_ToBanDo.Text, txtHT_ThuaDatSo.Text, txtHT_DiaChiThua.Text, txtHT_SoPhatHanh.Text, txtHT_SoVaoSo.Text);
                    if (success)
                    {
                        LoadThongTin(Session["DangKyBienDong"].ToString());
                        Session["ThuaDatThaoTac"] = 0;
                    }
                }
                else
                {
                    return;
                }

            }

            EnableHopThua(false);
            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }
       
    }
}