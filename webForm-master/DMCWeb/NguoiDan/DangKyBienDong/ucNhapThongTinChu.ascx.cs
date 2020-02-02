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
    public partial class ucNhapThongTinChu : System.Web.UI.UserControl
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["ThaoTac"] = ThaoTac.ChiXem;
                ApDungTrangThai();
                LoaddrLoaiDoiTuong();
                LoaddrDanhXung();
            }
        }

        XuLyDangKyBienDong don = new XuLyDangKyBienDong();
        public void CanhBao()
        {
            lblTieuDeDon.Text = "Lỗi! không có mã đăng ký biến động được gửi tới";
            
        }
        public void ApDungTrangThai()
        {
            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ChiXem)
            {
                btnThemChu.Enabled = false;
                btnLuuChu.Enabled = false;
                NhapThongTinChu_Visible(false);
                drLoaiDoiTuong.Enabled = false;
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua || (ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {
                
                btnThemChu.Enabled = true;
                btnLuuChu.Enabled  = true;
                NhapThongTinChu_Visible(true);                
                drLoaiDoiTuong.Enabled = true;

            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.KhongNhap)
            {

                btnThemChu.Enabled = true;
                btnLuuChu.Enabled = true;
                NhapThongTinChu_Visible(false);
                drLoaiDoiTuong.Enabled = false;
            }
        }


        #region "NHẬP THÔNG TIN CHỦ"
        public void LoadgrvChu()
        {

            try
            {
                if (Convert.ToInt32(Session["DangKyBienDong"]) > 0)
                {
                    if (Session["LoaiHoSo"] == "DuBi")
                    {
                        grvChu.DataSource = don.dsChuDuBi(Session["DangKyBienDong"].ToString());
                        grvChu.DataBind();
                    }
                    else if (Session["LoaiHoSo"] == "ChinhThuc")
                    {
                        grvChu.DataSource = don.dsChu(Session["DangKyBienDong"].ToString());
                        grvChu.DataBind();
                    }
                }
                else
                {
                    CanhBao();
                }
            }
            catch(Exception ex)
            {
                CanhBao();
            }

        }

        private void LoaddrLoaiDoiTuong()
        {
            List<string> ds = new List<string>();
            ds.Add("Cá nhân");
            ds.Add("Hộ gia đình");
            ds.Add("Tổ chức");
            ds.Add("Người có Quốc tịch khác");
            ds.Add("Đồng sở hữu");


            drLoaiDoiTuong.DataSource = ds;
            drLoaiDoiTuong.DataBind();
        }
        protected void drLoaiDoiTuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool success = don.CapNhatLoaiDoiTuong(Session["DangKyBienDong"].ToString(), drLoaiDoiTuong.SelectedValue.ToString());
        }
        private void LoaddrDanhXung()
        {
            List<string> ds = new List<string>();
            ds.Add("Ông");
            ds.Add("Bà");
            ds.Add("Hộ ông");
            ds.Add("Hộ bà");
            ds.Add("Công ty");
            drDanhXung.DataSource = ds;
            drDanhXung.DataBind();

        }
        protected void btnThemChu_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            Session["ThaoTac"] = ThaoTac.ThemMoi;
            ApDungTrangThai();
        }
        private void ClearTextBox()
        {
            drDanhXung.SelectedIndex = -1;
            txtHoTen.Text = "";
            txtNamSinh.Text = "";
            txtDiaChi.Text = "";
            txtSoDinhDanh.Text = "";
            txtNoiCap.Text = "";
            txtNgayCap.Text = "";
            lblMaChu.Text = "";
        }
        private void NhapThongTinChu_Visible(bool enable)
        {
            NhapThongTinChu.Visible = enable;
        }

        protected void btnLuuChu_Click(object sender, EventArgs e)
        {
            bool HoSoChinhThuc = false;
            if (Session["LoaiHoSo"] == "DuBi")
                HoSoChinhThuc = false;
            else if (Session["LoaiHoSo"] == "ChinhThuc")
                HoSoChinhThuc = true;



            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {               
                bool kq = don.ThemChu(HoSoChinhThuc, Session["DangKyBienDong"].ToString(), drDanhXung.Text, txtHoTen.Text, txtNamSinh.Text, txtDiaChi.Text, txtDinhDanh.Text, txtSoDinhDanh.Text, txtNoiCap.Text, txtNgayCap.Text, txtQuocTich.Text);
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua)
            {                
                bool kq = don.SuaChu(HoSoChinhThuc, lblMaChu.Text.Replace("Mã chủ: ", " ").Trim(), drDanhXung.Text, txtHoTen.Text, txtNamSinh.Text, txtDiaChi.Text, txtDinhDanh.Text, txtSoDinhDanh.Text, txtNoiCap.Text, txtNgayCap.Text, txtQuocTich.Text);
            }

            LoadgrvChu();

            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
            
        }
        
        protected void btnSuaChu_Click(object sender, EventArgs e)
        {
            Session["ThaoTac"] = ThaoTac.DangSua;
            ApDungTrangThai();
        }
        
        protected void btnHuy_Click(object sender, EventArgs e)
        {
            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }
        protected void grvChu_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                NhapThongTinChu_Visible(true);
                string _maChu = e.CommandArgument.ToString();
                Session["ThaoTac"] = ThaoTac.DangSua;
                Session["MaChu"] = _maChu;

                using (DMCWebEntities db = new DMCWebEntities())
                {
                    long maChu = long.Parse(_maChu);
                    if (Session["LoaiHoSo"] == "DuBi")
                    {
                        tblChuDuBi chu = db.tblChuDuBis.SingleOrDefault(n => n.MaChu == maChu);
                        
                        lblMaChu.Text = _maChu.ToString();
                        txtHoTen.Text = chu.HoTen;
                        drDanhXung.Text = chu.DanhXung;
                        txtNamSinh.Text = chu.NamSinh;
                        txtDiaChi.Text = chu.DiaChi;
                        txtSoDinhDanh.Text = chu.SoDinhDanh;
                        txtNoiCap.Text = chu.NoiCap;
                        txtNgayCap.Text = chu.NgayCap.ToString();
                        txtDinhDanh.Text = chu.DinhDanh;
                    }
                    else if (Session["LoaiHoSo"] == "ChinhThuc")
                    {
                        tblChu chu = db.tblChus.SingleOrDefault(n => n.MaChu == maChu);

                        lblMaChu.Text = "Mã chủ: " + _maChu.ToString();
                        txtHoTen.Text = chu.HoTen;
                        drDanhXung.Text = chu.DanhXung;
                        txtNamSinh.Text = chu.NamSinh;
                        txtDiaChi.Text = chu.DiaChi;
                        txtSoDinhDanh.Text = chu.SoDinhDanh;
                        txtNoiCap.Text = chu.NoiCap;
                        txtNgayCap.Text = chu.NgayCap.ToString();
                        txtDinhDanh.Text = chu.DinhDanh;
                    }
                }


            }
        }
        protected void grvChu_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string _maChu = grvChu.DataKeys[e.RowIndex].Value.ToString();
            bool HoSoChinhThuc=false;
            if (Session["LoaiHoSo"] == "DuBi")
                HoSoChinhThuc = false;
            else if (Session["LoaiHoSo"] == "ChinhThuc")
                HoSoChinhThuc = true;


            bool kq = don.XoaChu(HoSoChinhThuc, _maChu);
            LoadgrvChu();
        }


        #endregion

        protected void btnTimChu_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/TienIch/TimKiemNguoi.aspx?MaDangKyBienDong={0}", Session["DangKyBienDong"].ToString()));
        }

       
    }
}