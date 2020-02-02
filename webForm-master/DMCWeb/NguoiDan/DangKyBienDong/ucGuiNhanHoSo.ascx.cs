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
    public partial class ucGuiNhanHoSo : System.Web.UI.UserControl
    {
        public void Page_Load(object sender, EventArgs e)
        {
           // string Test_MaDangKyBienDong = Session["DangKyBienDong"].ToString();
        }
        public void EnableInput(bool enable)
        {
            txtTieuDeDon.Enabled = txtNguoiViet.Enabled = txtNgayViet.Enabled = txtNguoiNhan.Enabled = txtNgayNhan.Enabled = txtSoTiepNhan.Enabled = txtQuyen.Enabled = enable;
        }
        public void ApDungTrangThai()
        {
            if(Session["ThaoTac"]!= null)
            {
                if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ChiXem)
                {
                    btnLuu.Visible = false;
                }
                else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua || (ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
                {

                    btnLuu.Visible = true;

                }
                else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.KhongNhap)
                {

                    btnLuu.Enabled = false;
                }
            }
        }
        public void CanhBao()
        {
            lblTieuDeDon.Text = "Lỗi! không có mã đăng ký biến động được gửi tới";
            //Session["DangKyBienDong"] = "0";
            btnLuu.Visible = false;
            ThongTinGuiHoSo.Visible = false;
            ThongTinNhanHoSo.Visible = false;
            
        }
        XuLyDangKyBienDong don = new XuLyDangKyBienDong();
        public void LoadThongTin(string MaDangKyBienDong)
        {
            if (Convert.ToInt32(MaDangKyBienDong) < 1)
            {
                CanhBao();
                return;
            }


            if (Session["LoaiHoSo"] == "DuBi")
            {
                
                tblDonXinDangKyBienDongDuBi XemDon = don.XemDonDangKyBienDongDuBi(Session["DangKyBienDong"].ToString());
                if (XemDon != null)
                {
                    ThongTinNhanHoSo.Visible = false;
                    txtTieuDeDon.Text = XemDon.TieuDeDon;
                    txtNguoiViet.Text = XemDon.NguoiVietDon;
                    if(XemDon.NgayVietDon != null)
                    txtNgayViet.Text = ((DateTime)XemDon.NgayVietDon).ToString("dd/MM/yyyy");

                }
               
            }
            else
            {
                ThongTinNhanHoSo.Visible = true;
                tblDonXinDangKyBienDong XemDon = don.XemDonDangKyBienDong(Session["DangKyBienDong"].ToString());
                if (XemDon != null)
                {
                    txtTieuDeDon.Text = XemDon.KinhGuiCoQuanChucNang;
                    txtNguoiViet.Text = XemDon.NguoiVietDon;
                    if (XemDon.NgayVietDon != null)
                    txtNgayViet.Text = ((DateTime)XemDon.NgayVietDon).ToString("dd/MM/yyyy");

                    txtNguoiNhan.Text = XemDon.NguoiNhanHoSo;
                    if (XemDon.NgayNhanHoSo != null)
                    txtNgayNhan.Text = ((DateTime)XemDon.NgayNhanHoSo).ToString("dd/MM/yyyy"); ;
                    txtSoTiepNhan.Text = XemDon.SoTiepNhan;
                    txtQuyen.Text = XemDon.Quyen;
                }
            }
            string Test_MaDangKyBienDong = Session["DangKyBienDong"].ToString();
        }

        public void btnLuu_Click(object sender, EventArgs e)
        {
            string Test_MaDangKyBienDong = Session["DangKyBienDong"].ToString();
            bool loaiHS=false;
            if(Session["LoaiHoSo"] == "DuBi")
                loaiHS=false;
            else
                loaiHS= true;
            bool success = don.LuuThongTinGuiNhanHoSo(Session["DangKyBienDong"].ToString(), loaiHS, txtTieuDeDon.Text, txtNguoiViet.Text, txtNgayViet.Text, txtNguoiNhan.Text, txtNgayNhan.Text, txtSoTiepNhan.Text, txtQuyen.Text);

            EnableInput(false);
           
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            EnableInput(true);
        }

       
        
    }
}