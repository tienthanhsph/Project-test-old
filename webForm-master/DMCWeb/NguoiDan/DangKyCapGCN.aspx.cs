using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;
using DMCWeb.Models;

namespace DMCWeb.NguoiDan
{
    public enum ThaoTac {KhongCo,ThemMoi,DangSua,KhongNhap,ChiXem}
    public partial class DangKyCapGCN : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Session["MaDon"] = 20;
                //Session["MaDVHC"] = 1;
                //Session["ThaoTac"] = ThaoTac.ThemMoi;
                //Session["MaChu"] = 5;
               
                if (Request.QueryString["QuyenChapNhan"] != null)
                {
                    if (Request.QueryString["QuyenChapNhan"].ToString().ToLower() == "true")
                        btnChapNhan.Visible = true;

                }
                else
                {
                    btnChapNhan.Visible = false; 
                }
                Session["DoiTuong"] = "Khach";
                if(Request.QueryString["DoiTuong"] != null)
                {
                    Session["DoiTuong"] = Request.QueryString["DoiTuong"].ToString();
                }

                Session["MaDon"] = Request.QueryString["MaHoSo"];
                if (Session["MaDon"] != null)
                {
                    string ss = Session["MaDon"].ToString();
                    if (LayThongTinVeDon(Session["MaDon"].ToString()))
                    {
                        Session["ThaoTac"] = ThaoTac.ChiXem;
                    }
                    else
                        Session["ThaoTac"] = ThaoTac.KhongCo;
    
                    btnSuaDon.Enabled = true;
                }
                else
                {
                    Session["MaDon"] = 0;
                    Session["MaDVHC"] = 0;
                    Session["ThaoTac"] = ThaoTac.KhongCo;
                    Session["MaChuHoSo"] = 0;
                    
                    btnSuaDon.Enabled = false;
                    drDonViHanhChinh.SelectedIndex = -1;
                }

                //Session["MaDon"] = 7;
                //Session["MaDVHC"] = 1;
                //Session["ThaoTac"] = ThaoTac.DangSua;


                ApDungTrangThai();

                ////Kiểm tra giá trị session
                string s1 = Session["MaDon"].ToString();
                string s2 = Session["MaDVHC"].ToString();
                string s3 = Session["ThaoTac"].ToString();

                
                

                LoaddrLoaiDoiTuong();
                LoaddrDanhXung();
                if (Convert.ToInt32(Session["MaDon"]) != 0)
                {
                    LoadgrvChu();
                    LoadgrvThuaDat();
                    LoadgrvNhaO();
                    LoadThongTinGuiNhanHoSo();
                }
                
            }

        }
        public bool LayThongTinVeDon(string MaHoSo)
        {
            try
            {
                using (DMCWebEntities db = new DMCWebEntities())
                {
                    long _maHS = long.Parse(MaHoSo);
                    var kq = from h in db.tblHoSoKeKhaiDuBis
                             join dt in db.tblChuHoSoDuBis on h.MaHoSoKeKhai equals dt.MaHoSoKeKhai
                             where h.MaHoSoKeKhai == _maHS
                             select new
                             {
                                 MaHS = h.MaHoSoKeKhai,
                                 Dvhc = h.DonViHanhChinh,
                                 LoaiDT = h.MaLoaiDoiTuong                                
                             };
                    Session["MaDVHC"] = kq.Single().Dvhc;
                    string strLoaiDoiTuong = kq.Single().LoaiDT;
                    if (strLoaiDoiTuong == null || strLoaiDoiTuong == "")
                        drLoaiDoiTuong.SelectedIndex = -1;
                    else
                        drLoaiDoiTuong.SelectedValue = strLoaiDoiTuong;
                    drDonViHanhChinh.SelectedValue = Session["MaDVHC"].ToString();
                    return true;
                }
            }
            catch (Exception ex)
            {

                string s = ex.Message;
                return false;
            }
        }
        private void ApDungTrangThai()
        {
            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.KhongCo)
            {
                Wizard1.Visible = false;
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ChiXem)
            {
                Wizard1.Visible = true;
                btnThemChu.Enabled = btnThemThuaDat.Enabled = false;
                btnLuuChu.Enabled = btnLuuThuaDat.Enabled = false;
                btnHuyThuaDat.Enabled = btnHuyChu.Enabled = false;
                NhapThongTinChu_Visible(false);
                NhapThongTinThuaDat_Visible(false);
                NhapThongTinNhaO_Visible(false);

                TrangThaiChucNangCuaThongTinHoSo(false, false);

                drLoaiDoiTuong.Enabled = false;
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua || (ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {
                Wizard1.Visible = true;
                btnThemChu.Enabled = btnThemThuaDat.Enabled = true;
                btnLuuChu.Enabled = btnLuuThuaDat.Enabled = true;
                btnHuyThuaDat.Enabled = btnHuyChu.Enabled = true;
                NhapThongTinChu_Visible(true);
                NhapThongTinThuaDat_Visible(true);
                NhapThongTinNhaO_Visible(true);

                if (Session["DoiTuong"] != null)
                {
                    if (Session["DoiTuong"].ToString() == "Khach")
                    {
                        TrangThaiChucNangCuaThongTinHoSo(true, false);
                    }
                    else
                    {
                        TrangThaiChucNangCuaThongTinHoSo(true, true);
                    }
                }
                else
                {
                    TrangThaiChucNangCuaThongTinHoSo(false, false);
                }


                drLoaiDoiTuong.Enabled = true;
                
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.KhongNhap)
            {
                Wizard1.Visible = true;
                btnThemChu.Enabled = btnThemThuaDat.Enabled = true;
                btnLuuChu.Enabled = btnLuuThuaDat.Enabled = true;
                btnHuyThuaDat.Enabled = btnHuyChu.Enabled = true;
                NhapThongTinChu_Visible(false);
                NhapThongTinThuaDat_Visible(false);
                NhapThongTinNhaO_Visible(false);

                TrangThaiChucNangCuaThongTinHoSo(false, false);

                drLoaiDoiTuong.Enabled = false;
            }
        }       
      
        XuLyDonXinCapGCN don = new XuLyDonXinCapGCN();
        protected void btnTaoDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Session["MaDon"]) == 0)
                {
                    Session["MaDVHC"] = drDonViHanhChinh.SelectedValue.ToString();
                    Session["MaDon"] = don.TaoDonMoi(Session["MaDVHC"].ToString());
                    Session["ThaoTac"] = ThaoTac.ThemMoi;                               
                    ApDungTrangThai();
                }
                else
                {
                    // thông báo có đơn rồi.
                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "XacNhanTaoMoiDon", "confirm('Bạn đang có hồ sơ rồi, bạn có thể chọn sửa hồ sơ này. \n nếu bạn vẫn muốn tiếp tục thì mọi thông tin hồ sơ này sẽ bị xóa đi và bạn sẽ thao tác với hồ sơ mới. \n Bạn vẫn muốn xóa hồ sơ?')", true);
                    Response.Write("<script>alert('Dang de lai...')</script>");



                    Session["MaDVHC"] = drDonViHanhChinh.SelectedValue.ToString();
                    Session["MaDon"] = don.TaoDonMoi(Session["MaDVHC"].ToString());
                    Session["ThaoTac"] = ThaoTac.ThemMoi;                   
                    ApDungTrangThai();
                }

                drLoaiDoiTuong.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                string error = ex.Message;
            }
        }
        protected void btnSuaDon_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Session["MaDon"]) != 0)
            {
                Wizard1.Enabled = true;
                Session["ThaoTac"]= ThaoTac.DangSua;
                ApDungTrangThai();
                LoadgrvChu();
                LoadgrvThuaDat();
            }
        }

        #region "NHẬP THÔNG TIN CHỦ"
        private void LoadgrvChu()
        {
            grvChu.DataSource = don.dsChuDuBi(Session["MaDon"].ToString());
            grvChu.DataBind();
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
           bool success= don.CapNhatLoaiDoiTuong(Session["MaDon"].ToString(), drLoaiDoiTuong.SelectedValue.ToString());
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
           
            ClearTextBoxChu();
           
            Session["ThaoTac"] = ThaoTac.ThemMoi;
            ApDungTrangThai();
        }
        private void ClearTextBoxChu()
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
            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {
                bool kq = don.ThemChuDuBi(Session["MaDon"].ToString(), drDanhXung.Text, txtHoTen.Text, txtNamSinh.Text, txtDiaChi.Text, txtDinhDanh.Text, txtSoDinhDanh.Text, txtNoiCap.Text, txtNgayCap.Text, txtQuocTich.Text);
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua)
            {
                bool kq = don.SuaChuDuBi(lblMaChu.Text.Replace("Mã chủ: ", " ").Trim(), drDanhXung.Text, txtHoTen.Text, txtNamSinh.Text, txtDiaChi.Text, txtDinhDanh.Text, txtSoDinhDanh.Text, txtNoiCap.Text, txtNgayCap.Text, txtQuocTich.Text);
            }
            LoadgrvChu();
            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }
        protected void btnHuyChu_Click(object sender, EventArgs e)
        {
            ClearTextBoxChu();
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
               
                using(DMCWebEntities db = new DMCWebEntities())
                {
                    long maChu = long.Parse(_maChu);
                    var q = (from c in db.tblChuDuBis
                            where c.MaChu == maChu
                                 select c).Single();
                    tblChuDuBi chu = (tblChuDuBi)q;
                    lblMaChu.Text ="Mã chủ: "+ _maChu.ToString();                   
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
        protected void grvChu_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string _maChu = grvChu.DataKeys[e.RowIndex].Value.ToString();

            bool kq = don.XoaChuDuBi(_maChu);
            LoadgrvChu();
        }


        #endregion

        #region "NHẬP THÔNG TIN ĐẤT"
        protected void btnThemThuaDat_Click(object sender, EventArgs e)
        {
            ClearTextBoxThuaDat();            
            Session["ThaoTac"] = ThaoTac.ThemMoi;
            ApDungTrangThai();
        }
        private void ClearTextBoxThuaDat()
        {
           
            lblMaHoSo.Text = "";
            lblMaThuaDat.Text = "";
            drHanChe.SelectedIndex = 0;
            drLoaiNguonGoc.SelectedIndex = -1;
            txtToBanDo.Text = "";
            txtSoThua.Text = "";
            txtDiaChiThuaDat.Text = "";
            txtDienTich.Text = "";
            txtDTSDChung.Text = "";
            txtDTSDRieng.Text = "";
            txtHanChe.Text = "";
            txtMucDich.Text = "";
            txtThoiHan.Text = "";
            txtNgayBatDau.Text = "";

        }
        private void NhapThongTinThuaDat_Visible(bool visible)
        {
            NhapThongTinThuaDat.Visible = visible;
        }
        protected void btnLuuThuaDat_Click(object sender, EventArgs e)
        {
            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {
                bool kq = don.ThemThuaDatDuBi(Session["MaDon"].ToString(), txtToBanDo.Text, txtSoThua.Text, txtDiaChiThuaDat.Text, txtDienTich.Text, txtDTSDChung.Text, txtDTSDRieng.Text, drLoaiNguonGoc.SelectedValue, txtMucDich.Text, drHanChe.SelectedValue, txtHanChe.Text, txtNgayBatDau.Text, txtThoiHan.Text);
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua)
            {
                bool kq = don.SuaThuaDatDuBi(lblMaThuaDat.Text, Session["MaDon"].ToString(), txtToBanDo.Text, txtSoThua.Text, txtDiaChiThuaDat.Text, txtDienTich.Text, txtDTSDChung.Text, txtDTSDRieng.Text, drLoaiNguonGoc.SelectedValue, txtMucDich.Text, drHanChe.SelectedValue, txtHanChe.Text, txtNgayBatDau.Text, txtThoiHan.Text);
            }
            LoadgrvThuaDat();
            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }
        protected void btnHuyThuaDat_Click(object sender, EventArgs e)
        {
            ClearTextBoxThuaDat();
            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }
        protected void LoadgrvThuaDat(){
            grvThuaDat.DataSource = don.dsThuaDatDuBi(Session["MaDon"].ToString());
           grvThuaDat.DataBind();
       }
        protected void grvThuaDat_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                NhapThongTinThuaDat_Visible(true);
                string _maThuaDat = e.CommandArgument.ToString();
                Session["ThaoTac"] = ThaoTac.DangSua;
                Session["MaThuaDat"] = _maThuaDat;

                using (DMCWebEntities db = new DMCWebEntities())
                {
                    long maThuaDat = long.Parse(_maThuaDat);
                    var thuadatdangxet = (from td in db.tblThuaDatDuBis
                              where td.MaThuaDat == maThuaDat
                              select td).Single();
                    tblThuaDatDuBi thua = (tblThuaDatDuBi)thuadatdangxet;
                    lblMaThuaDat.Text = thua.MaThuaDat.ToString();
                    lblMaHoSo.Text = thua.MaHoSoKeKhai.ToString();
                    txtToBanDo.Text = thua.ToBanDo;
                    txtSoThua.Text = thua.SoThua;
                    txtDiaChi.Text = thua.DiaChi;
                    txtDienTich.Text = thua.DienTich;
                    txtDTSDChung.Text = thua.SuDungChung;
                    txtDTSDRieng.Text = thua.SuDungRieng;
                    txtMucDich.Text = thua.MucDichSuDung;
                    txtThoiHan.Text = thua.ThoiHanSuDung;
                    txtNgayBatDau.Text = thua.NgayBatDauSuDung.ToString();
                    
                    drHanChe.SelectedValue = thua.CoHanCheSuDung.ToString().ToLower();
                    txtHanChe.Text = thua.NoiDungHanCheSuDung;
                    drLoaiNguonGoc.SelectedValue = thua.LoaiNguonGocSuDung;
                    
                }


            }
        }
        protected void grvThuaDat_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string _maChu = grvChu.DataKeys[e.RowIndex].Value.ToString();

            bool kq = don.XoaChuDuBi(_maChu);
            LoadgrvChu();
        }
        #endregion
               
        #region "NHẬP THÔNG TIN Nhà ở"
        private void LoadgrvNhaO()
        {
            grvNhaO.DataSource = don.dsNhaODuBi(Session["MaDon"].ToString());
            grvNhaO.DataBind();
        }
        
        protected void btnThemNhaO_Click(object sender, EventArgs e)
        {
            ClearTextBoxNhaO();
            Session["ThaoTac"] = ThaoTac.ThemMoi;
            ApDungTrangThai();
        }
        private void ClearTextBoxNhaO()
        {
            lblMaNhaO.Text = "";
            drLoaiNhaO.SelectedIndex = -1;
            txtDienTichXayDung.Text = "";
            txtDienTichSan.Text = "";
            txtSoHuuChung.Text = "";
            txtSoHuuRieng.Text = "";
            txtKetCau.Text = "";
            txtHanCheNha.Text = "";
            drHanCheNha.SelectedIndex = 0;
            txtSoTang.Text = "";
              
        }
        private void NhapThongTinNhaO_Visible(bool enable)
        {
            NhapThongTinNhaO.Visible = enable;
        }

        protected void btnLuuNhaO_Click(object sender, EventArgs e)
        {
            string s = Session["ThaoTac"].ToString();
            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {
                bool kq = don.ThemNhaODuBi(Session["MaDon"].ToString(), drLoaiNhaO.Text, txtDienTichXayDung.Text, txtDienTichSan.Text, txtKetCau.Text, txtSoTang.Text, txtSoHuuChung.Text, txtSoHuuRieng.Text, drHanCheNha.SelectedValue, txtHanCheNha.Text);
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua)
            {
                bool kq = don.SuaNhaODuBi(lblMaNhaO.Text, drLoaiNhaO.Text, txtDienTichXayDung.Text, txtDienTichSan.Text, txtKetCau.Text, txtSoTang.Text, txtSoHuuChung.Text, txtSoHuuRieng.Text, drHanCheNha.SelectedValue, txtHanCheNha.Text);
            }
            LoadgrvNhaO();
            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }
        protected void btnHuyNhaO_Click(object sender, EventArgs e)
        {
            ClearTextBoxNhaO();
            Session["ThaoTac"] = ThaoTac.KhongNhap;
            ApDungTrangThai();
        }
        protected void grvNhaO_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                NhapThongTinNhaO_Visible(true);
                string _maNhaO = e.CommandArgument.ToString();
                Session["ThaoTac"] = ThaoTac.DangSua;
                Session["MaNhaO"] = _maNhaO;

                using (DMCWebEntities db = new DMCWebEntities())
                {
                    long maNhaO = long.Parse(_maNhaO);
                    var q = (from n in db.tblThongTinNhaODuBis
                             where n.MaNhaO == maNhaO
                             select n).Single();
                    tblThongTinNhaODuBi nha = (tblThongTinNhaODuBi)q;
                    lblMaNhaO.Text =nha.MaNhaO.ToString();
                    drLoaiNhaO.SelectedValue = nha.LoaiNhaO;
                    txtDienTichXayDung.Text =nha.DienTichXayDung;
                    txtDienTichSan.Text =nha.DienTichSan;
                    txtSoHuuChung.Text =nha.SoHuuChung;
                    txtSoHuuRieng.Text =nha.SoHuuRieng;
                    txtKetCau.Text = nha.KetCau;
                    txtHanCheNha.Text =nha.ThoiHanSoHuu;
                    drHanCheNha.SelectedValue=nha.CoHanCheThoiHanSoHuu.ToString();
                    txtSoTang.Text =nha.SoTang;
                }


            }
        }
        protected void grvNhaO_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string _maNhaO = grvNhaO.DataKeys[e.RowIndex].Value.ToString();

            bool kq = don.XoaNhaODuBi(_maNhaO);
            LoadgrvNhaO();
        }


        #endregion

        protected void btnChapNhan_Click(object sender, EventArgs e)
        {
            if(txtNguoiNhan.Text !="" && txtSoTiepNhan.Text != "" && txtNgayNhan.Text !="")
            {
                string MaHoSoKeKhaiDuBi = Session["MaDon"].ToString();
                Response.Redirect(@"~/VanPhong/TiepNhanDon/ChapNhanHoSo.aspx?MaHoSoKeKhaiDuBi=" + MaHoSoKeKhaiDuBi);
            }
            else
            {
                Response.Write("<script>alert('Lỗi ! Thông tin tiếp nhận hồ sơ chưa đầy đủ')</script>");
            }

           
        }


        #region "NHẬP THÔNG TIN GỬI, NHẬN HỒ SƠ"
        protected void LoadThongTinGuiNhanHoSo()
        {
            try
            {
                tblHoSoKeKhaiDuBi HSKeKhaiHienTai = don.LayThongTinXetDuyetCapCSDuBi(Session["MaDon"].ToString());
                txtTieuDeKinhGui.Text = HSKeKhaiHienTai.KinhGuiCoQuanChucNang;
                txtNguoiVietDon.Text = HSKeKhaiHienTai.NguoiVietDon;
                drLoaiDeNghiCapGCN.SelectedValue = HSKeKhaiHienTai.MaLoaiDeNghi;
                txtNghiaVuTaiChinh.Text = HSKeKhaiHienTai.NghiaVuTaiChinh;
                txtGiayToKemTheo.Text = HSKeKhaiHienTai.GiayToKemTheo;
                txtDeNghiKhac.Text = HSKeKhaiHienTai.DeNghiKhac;
                txtEmailNguoiVietDon.Text = HSKeKhaiHienTai.DiaChiMail;
                txtDienThoaiNguoiVietDon.Text = HSKeKhaiHienTai.SoDienThoaiLienHe;


                txtNguoiNhan.Text = HSKeKhaiHienTai.NguoiNhanHoSo;
                txtNgayNhan.Text = HSKeKhaiHienTai.NgayNhanHoSo.ToString();
                txtSoTiepNhan.Text = HSKeKhaiHienTai.SoTiepNhan;
                txtQuyen.Text = HSKeKhaiHienTai.Quyen;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
           
        }
        protected void TrangThaiChucNangCuaThongTinHoSo(bool nguoigui, bool nguoinhan)
        {
            //NhapThongTinGuiHoSo.EnableTheming = nguoigui;
            txtTieuDeKinhGui.Enabled = nguoigui;
            txtNguoiVietDon.Enabled = nguoigui;
            drLoaiDeNghiCapGCN.Enabled = nguoigui;
            txtNghiaVuTaiChinh.Enabled = nguoigui;
            txtGiayToKemTheo.Enabled = nguoigui;
            txtDeNghiKhac.Enabled = nguoigui;
            txtEmailNguoiVietDon.Enabled = nguoigui;
            txtDienThoaiNguoiVietDon.Enabled = nguoigui;

            //NhapThongTinNhanHoSo.EnableTheming = nguoinhan;
            txtNguoiNhan.Enabled = nguoinhan;
            txtNgayNhan.Enabled = nguoinhan;
            txtSoTiepNhan.Enabled = nguoinhan;
            txtQuyen.Enabled = nguoinhan;
        }
        protected void btnLuuThongTinHoSo_Click(object sender, EventArgs e)
        {
            bool success =  don.LuuThongTinXetDuyetCapCSDuBi(Session["MaDon"].ToString(), txtTieuDeKinhGui.Text, txtNguoiVietDon.Text, drLoaiDeNghiCapGCN.SelectedValue, txtNghiaVuTaiChinh.Text, txtGiayToKemTheo.Text, txtDeNghiKhac.Text, txtEmailNguoiVietDon.Text, txtDienThoaiNguoiVietDon.Text, txtNguoiNhan.Text, txtNgayNhan.Text, txtSoTiepNhan.Text, txtQuyen.Text);
            Session["ThaoTac"] = ThaoTac.ChiXem;
            ApDungTrangThai();
        }

        protected void btnSuaThongTinHoSo_Click(object sender, EventArgs e)
        {
            Session["ThaoTac"] = ThaoTac.DangSua;
            ApDungTrangThai();
        }
        #endregion

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            bool SendSuccess = don.GuiHoSoDi(Session["MaDon"].ToString());
            if (SendSuccess)
                Response.Write("<script>alert('Bạn đã gửi thành công hồ sơ')</script>");
            else
                Response.Write("<script>alert('Có lỗi! Hồ sơ chưa được gửi đi!')</script>");
        }

       


    }
}