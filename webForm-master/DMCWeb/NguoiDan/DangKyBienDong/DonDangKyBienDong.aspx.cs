using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;
using DMCWeb.Models;

namespace DMCWeb.NguoiDan.DangKyBienDong
{
    public partial class DonDangKyBienDong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                TrangThaiKhoiTao();

                object DangKyBienDong = Request.QueryString["DangKyBienDong"];               
                object LoaiHoSo = Request.QueryString["LoaiHoSo"];
                object QuyenChapNhan = Request.QueryString["QuyenChapNhan"];
                //object DoiTuong = Request.QueryString["DoiTuong"];
                
                if(DangKyBienDong!= null)
                {
                    if(Convert.ToInt32(DangKyBienDong)>0){
                        Session["DangKyBienDong"] = DangKyBienDong.ToString();
                       
                    }
                }

                if(LoaiHoSo!= null)
                {
                    if (LoaiHoSo.ToString().ToLower() == "chinhthuc")
                    {
                        Session["LoaiHoSo"] = "ChinhThuc";
                    }
                }
               
                if (QuyenChapNhan != null)
                {
                    if (QuyenChapNhan.ToString().ToLower() == "true")
                    {
                        Session["QuyenChapNhan"] = "true";
                        QuyenCanBo.Visible = true;
                    }
                    else
                    {
                        QuyenCanBo.Visible = false;
                    }
                }
                else
                {
                    QuyenCanBo.Visible = false;
                }

              
                if (Convert.ToInt32(Session["DangKyBienDong"]) > 0)
                {
                    bool success = LayThongTinVeDon(Session["DangKyBienDong"].ToString());
                    if (success)
                    {
                        chckDaChonLoaiBienDong.Checked = true;
                        chckDaChonLoaiBienDong.Visible = false;
                        drLoaiBienDong.Enabled = false;
                        Session["ThaoTac"] = ThaoTac.ChiXem;
                        ApDungTrangThai();

                        ucGuiNhanHoSo.LoadThongTin(Session["DangKyBienDong"].ToString());
                        ucGuiNhanHoSo.ApDungTrangThai();

                        ucNhapThongTinChu.LoadgrvChu();
                        ucNhapThongTinChu.ApDungTrangThai();

                        ucDangKyBienDongDatDat_TaiSan.LoadThongTin(Session["DangKyBienDong"].ToString());
                        ucDangKyBienDongDatDat_TaiSan.ApDungTrangThai();

                        ucDeNghiCapLai.LoadThongTin(Session["DangKyBienDong"].ToString());
                        ucDeNghiCapLai.ApDungTrangThai();

                        ucDeNghiTachThua_HopThua.LoadThongTin(Session["DangKyBienDong"].ToString());
                        ucDeNghiTachThua_HopThua.ApDungTrangThai();
                    }
                    //else
                    //{
                    //    TrangThaiKhoiTao();
                    //}
                }
                //else
                //{
                //    TrangThaiKhoiTao();
                //}


                
            }

            if (Session["LoaiHoSo"] == "ChinhThuc")
            {
                ChucNangXuLyHoSoCapTren.Visible = true;
                QuyenCanBo.Visible = false;
                btnGuiHoSoBienDong.Visible = false;
            }
            else
            {
                ChucNangXuLyHoSoCapTren.Visible = false;
                if ((ThaoTac)Session["ThaoTac"] != ThaoTac.KhongCo)
                    btnGuiHoSoBienDong.Visible = true;
                else
                    btnGuiHoSoBienDong.Visible = false;
            }
            LoadTheoLoaiBienDong();
        }
        public void TrangThaiKhoiTao()
        {
            Session["DangKyBienDong"] = "0";
            Session["LoaiBienDong"] = "0";
            Session["ThaoTac"] = ThaoTac.KhongCo;
            Session["LoaiHoSo"] = "DuBi";
            Session["MaDVHC"] = "0";
            Session["QuyenChapNhan"] = "false";


            //Session["DoiTuong"] = "Khach";
            if (Session["ThuaDatThaoTac"] == null)
                Session["ThuaDatThaoTac"] = "0"; // dùng để tránh lỗi ở Usercontrol thông tin thửa đất có thay đổi.
            if (Session["TaiSanThaoTac"] == null)
                Session["TaiSanThaoTac"] = "0";// dùng để tránh lỗi ở Usercontrol thông tin tài sản có thay đổi.


            chckDaChonLoaiBienDong.Checked = false;
            chckDaChonLoaiBienDong.Visible = true;
            
            drLoaiBienDong.Enabled = true;
            
            drDonViHanhChinh.Visible = true;
            ChckDVHC.Checked = true;

            ApDungTrangThai();
        }
        XuLyDangKyBienDong don = new XuLyDangKyBienDong();
        public bool LayThongTinVeDon(string MaDangKyBienDong)
        {
            try
            {
                using (DMCWebEntities db = new DMCWebEntities())
                {
                    long _maDangKyBienDong = long.Parse(MaDangKyBienDong);

                    if (Session["LoaiHoSo"] == "DuBi")
                    {
                        var kq = from h in db.tblDonXinDangKyBienDongDuBis
                                 where h.ID == _maDangKyBienDong
                                 select h;

                        Session["MaDVHC"] = kq.Single().DonViHanhChinh;
                        if (Session["MaDVHC"] != null && Session["MaDVHC"].ToString() != "")
                            drDonViHanhChinh.SelectedValue = Session["MaDVHC"].ToString();

                        Session["LoaiBienDong"] = kq.Single().LoaiBienDong;
                        string s = Session["LoaiBienDong"].ToString();
                        if (Convert.ToInt32(Session["LoaiBienDong"]) > 0)
                            drLoaiBienDong.SelectedValue = Session["LoaiBienDong"].ToString();
                        return true;
                    }
                    else if(Session["LoaiHoSo"] == "ChinhThuc")
                    {
                        var kq = from h in db.tblDonXinDangKyBienDongs
                                 where h.MaDangKyBienDong == _maDangKyBienDong
                                 select h;

                        Session["MaDVHC"] = kq.Single().DonViHanhChinh;
                        if (Session["MaDVHC"] != null && Session["MaDVHC"].ToString() != "")
                            drDonViHanhChinh.SelectedValue = Session["MaDVHC"].ToString();

                        Session["LoaiBienDong"] = kq.Single().LoaiBienDong;
                        string s = Session["LoaiBienDong"].ToString();
                        if (Convert.ToInt32(Session["LoaiBienDong"]) > 0)
                            drLoaiBienDong.SelectedValue = Session["LoaiBienDong"].ToString();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {

                string s = ex.Message;
                return false;
            }
        }
        private void ApDungTrangThai() // đang để lại!
        {
            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.KhongCo)
            {
                ThongTinBienDong.Visible = false;
                btnSuaDonDangKyBienDong.Visible = false;
                btnGuiHoSoBienDong.Visible = false;
                btnChapNhanHoSo.Visible = false;
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ChiXem)
            {
                ThongTinBienDong.Visible = true;
                btnTaoHoSoDangKyBienDong.Visible = true;
                btnSuaDonDangKyBienDong.Visible = true;
                btnGuiHoSoBienDong.Visible = true;
                btnChapNhanHoSo.Visible = true;

            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua || (ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {
                ThongTinBienDong.Visible = true;
                btnTaoHoSoDangKyBienDong.Visible = true;
                btnSuaDonDangKyBienDong.Visible = true;
                btnGuiHoSoBienDong.Visible = true;
                btnChapNhanHoSo.Visible = true;

               
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.KhongNhap)
            {
                ThongTinBienDong.Visible = true;
                btnTaoHoSoDangKyBienDong.Visible = true;
                btnSuaDonDangKyBienDong.Visible = true;
                btnGuiHoSoBienDong.Visible = true;
                btnChapNhanHoSo.Visible = true;
            }



           
            ucGuiNhanHoSo.ApDungTrangThai();
            ucNhapThongTinChu.ApDungTrangThai();
            ucDangKyBienDongDatDat_TaiSan.ApDungTrangThai();
            ucDeNghiCapLai.ApDungTrangThai();
            ucDeNghiTachThua_HopThua.ApDungTrangThai();
        }

        protected void btnTaoHoSoDangKyBienDong_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32( Session["DangKyBienDong"])>0) // tạm thông báo thôi đã, sau học javascript sẽ chỉnh sửa sau.
            {
                Response.Write("<script> alert('Hồ sơ hiện tại đã dừng nhập liệu để tạo hồ sơ mới!'); </script>");
            }
            TrangThaiKhoiTao();            
            Session["DangKyBienDong"] = don.TaoDonDangKyBienDongDuBi();
            Session["ThaoTac"] = ThaoTac.ThemMoi;
            ApDungTrangThai();

           
            ucGuiNhanHoSo.LoadThongTin(Session["DangKyBienDong"].ToString());           

            ucNhapThongTinChu.LoadgrvChu();           

            ucDangKyBienDongDatDat_TaiSan.LoadThongTin(Session["DangKyBienDong"].ToString());
            
            ucDeNghiCapLai.LoadThongTin(Session["DangKyBienDong"].ToString());            

            ucDeNghiTachThua_HopThua.LoadThongTin(Session["DangKyBienDong"].ToString());

           

            string Test_MaDangKyBienDong = Session["DangKyBienDong"].ToString();
        }
        

        protected void drLoaiBienDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["LoaiBienDong"] = drLoaiBienDong.SelectedValue;
            LoadTheoLoaiBienDong();
        }
        protected void LoadTheoLoaiBienDong()
        {
            if (Session["LoaiBienDong"].ToString()=="1")
            {
                Hide3UC();
                ucDangKyBienDongDatDat_TaiSan.Visible = true;
            }
            else if (Session["LoaiBienDong"].ToString() == "2")
            {
                Hide3UC();
                ucDeNghiCapLai.Visible = true;
            }
            else if (Session["LoaiBienDong"].ToString() == "3")
            {
                Hide3UC();
                ucDeNghiTachThua_HopThua.Visible = true;
            }
            else
            {
                Hide3UC();
            }
        }
        public void Hide3UC()
        {
            ucDangKyBienDongDatDat_TaiSan.Visible = ucDeNghiCapLai.Visible = ucDeNghiTachThua_HopThua.Visible = false;
        }

        protected void ChckDVHC_CheckedChanged(object sender, EventArgs e)
        {
            if (ChckDVHC.Checked == true)
            {
                drDonViHanhChinh.Visible = true;
            }
            else
            {
                drDonViHanhChinh.Visible = false;
            }
        }

        protected void chckDaChonLoaiBienDong_CheckedChanged(object sender, EventArgs e)
        {
            if (chckDaChonLoaiBienDong.Checked == true)
            {
                if (don.LuuThongTinDangKyBienDongDuBi(Session["DangKyBienDong"].ToString(),"","","","","","","","","","","", drLoaiBienDong.SelectedValue, "",""))
                {
                    Session["LoaiBienDong"] = drLoaiBienDong.SelectedValue.ToString();
                    drLoaiBienDong.Enabled = false;
                    chckDaChonLoaiBienDong.Visible = false;
                }
                
            }
        }

        protected void drDonViHanhChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool success = don.LuuThongTinDangKyBienDongDuBi(Session["DangKyBienDong"].ToString(), "", "", "","", "", "", "", "", "", "", "", "", "", drDonViHanhChinh.SelectedValue);
        }

        protected void btnSuaDonDangKyBienDong_Click(object sender, EventArgs e)
        {
            Session["ThaoTac"] = ThaoTac.DangSua;
            ApDungTrangThai();
        }

        protected void btnChapNhanHoSo_Click(object sender, EventArgs e)
        {
            if(don.ChapNhanBienDong(Session["DangKyBienDong"].ToString(), txtNgayNhan.Text, txtNguoiNhan.Text,txtSoTiepNhan.Text,txtQuyen.Text))
            {
                Response.Write("<script>alert('Thành công!')</script>");
                Response.Redirect("~/VanPhong/TiepNhanDon/BaoCaoHoSoBienDongMoi.aspx");
            }
            else
            {
                Response.Write("<script>alert('LỖI! ~_~ ')</script>");
            }
        }

        protected void btnXoaHoSo_Click(object sender, EventArgs e)
        {
            if(don.XoaDuLieuBienDongDuBi(Session["DangKyBienDong"].ToString()))
            {
                Response.Write("<script>alert('Xóa thành công!')</script>");
            }
            else
            {
                Response.Write("<script>alert('Xóa thất bại!')</script>");
            }
        }

        protected void btnGuiHoSoBienDong_Click(object sender, EventArgs e)
        {
           bool success =  don.GuiHoSo(Session["DangKyBienDong"].ToString());
            if(success)
            {
                Response.Write("<script> alert('Đã gửi đơn!')</script>");
            }
            else
            {
                Response.Write("<script> alert('Lỗi! không gửi thành công.')</script>");
            }
        }

        protected void btnXacNhanCapCoSo_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/VanPhong/XuLyBienDong/XacNhanCapCoSo_BienDong.aspx?DangKyBienDong={0}", Session["DangKyBienDong"].ToString()));
        }

        protected void btnCoQuanDangKyDatDai_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/VanPhong/XuLyBienDong/YKienCoQuanDangKyDatDai.aspx?DangKyBienDong={0}", Session["DangKyBienDong"].ToString()));
        }

        protected void btnCoQuanTaiNguyenMoiTruong_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/VanPhong/XuLyBienDong/YKienCoQuanTaiNguyenVaMoiTruong.aspx?DangKyBienDong={0}", Session["DangKyBienDong"].ToString()));
        }
    
              
    }
}