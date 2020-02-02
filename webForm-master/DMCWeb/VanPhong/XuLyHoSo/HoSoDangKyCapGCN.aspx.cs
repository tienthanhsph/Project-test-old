using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;
using DMCWeb.Models;


namespace DMCWeb.VanPhong.XuLyHoSo
{
    
    public partial class HoSoDangKyCapGCN : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                Session["MaHoSo"] = Request.QueryString["MaHoSo"];
                if (Session["MaHoSo"] != null && Session["MaHoSo"] != "")
                {
                    
                    string s = Session["MaHoSo"].ToString();
                    if (LayThongTinHoSo(Session["MaHoSo"].ToString()))
                        Session["ThaoTac"] = ThaoTac.ChiXem;
                    else
                        Session["ThaoTac"] = ThaoTac.KhongCo;
                    btnSuaDon.Enabled = true;
                }
                else
                {
                    Session["MaHoSo"] = 0;
                    Session["MaDVHC"] = 0;
                    Session["ThaoTac"] = ThaoTac.KhongCo;
                    Session["MaChuHoSo"] = 0;
                    Session["MaDoiTuong"] = 0;
                    btnSuaDon.Enabled = false;
                    drDonViHanhChinh.SelectedIndex = -1;
                }
               
                ApDungTrangThai();

               
                LoaddrLoaiDoiTuong();
                LoaddrDanhXung();
                if (Convert.ToInt32(Session["MaHoSo"]) != 0)
                {
                    LoadgrvChu();
                    LoadgrvThuaDat();
                    LoadgrvNhaO();
                    LoadThongTinGuiNhanHoSo();
                }
                
            }

        }
        public bool LayThongTinHoSo(string MaHoSo)
        {
            try
            {
                using (DMCWebEntities db = new DMCWebEntities())
                {
                    long _maHS = long.Parse(MaHoSo);
                    var kq = from h in db.tblHoSoes
                             join dt in db.tblChuHoSoes on h.MaHoSo equals dt.MaHoSo
                             where h.MaHoSo == _maHS
                             select new
                             {
                                 MaHS = h.MaHoSo,
                                 Dvhc = h.DonViHanhChinh,
                                 LoaiDT = h.LoaiDoiTuong 
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
        //protected void btnTaoDon_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (Convert.ToInt32(Session["MaHoSo"]) == 0)
        //        {
        //            Session["MaDVHC"] = drDonViHanhChinh.SelectedValue.ToString();
        //            Session["MaHoSo"] = don.TaoDonMoi(Session["MaDVHC"].ToString());
        //            Session["ThaoTac"] = ThaoTac.ThemMoi;                               
        //            ApDungTrangThai();
                   
        //        }
        //        else
        //        {
        //            // thông báo có đơn rồi.
        //            //ScriptManager.RegisterStartupScript(this, this.GetType(), "XacNhanTaoMoiDon", "confirm('Bạn đang có hồ sơ rồi, bạn có thể chọn sửa hồ sơ này. \n nếu bạn vẫn muốn tiếp tục thì mọi thông tin hồ sơ này sẽ bị xóa đi và bạn sẽ thao tác với hồ sơ mới. \n Bạn vẫn muốn xóa hồ sơ?')", true);
        //            Response.Write("<script>alert('Dang de lai...')</script>");



        //            Session["MaDVHC"] = drDonViHanhChinh.SelectedValue.ToString();
        //            Session["MaHoSo"] = don.TaoDonMoi(Session["MaDVHC"].ToString());
        //            Session["ThaoTac"] = ThaoTac.ThemMoi;                   
        //            ApDungTrangThai();
                    
                
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        string error = ex.Message;
        //    }
        //}
        protected void btnSuaDon_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["MaHoSo"]) != 0)
            {
                Wizard1.Enabled = true;
                Session["ThaoTac"] = ThaoTac.DangSua;
                ApDungTrangThai();
                LoadgrvChu();
                LoadgrvThuaDat();
            }
        }

        #region "NHẬP THÔNG TIN CHỦ"
        private void LoadgrvChu()
        {
            grvChu.DataSource = don.dsChu(Session["MaHoSo"].ToString());
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
            don.CapNhatLoaiDoiTuong(Session["MaDon"].ToString(), drLoaiDoiTuong.SelectedValue.ToString());
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
                bool kq = don.ThemChu(Session["MaHoSo"].ToString(), drDanhXung.Text, txtHoTen.Text, txtNamSinh.Text, txtDiaChi.Text, txtDinhDanh.Text, txtSoDinhDanh.Text, txtNoiCap.Text, txtNgayCap.Text, txtQuocTich.Text);
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua)
            {
                bool kq = don.SuaChu(lblMaChu.Text, drDanhXung.Text, txtHoTen.Text, txtNamSinh.Text, txtDiaChi.Text, txtDinhDanh.Text, txtSoDinhDanh.Text, txtNoiCap.Text, txtNgayCap.Text, txtQuocTich.Text);
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
                    var q = (from c in db.tblChus
                            where c.MaChu == maChu
                                 select c).Single();
                    tblChu chu = (tblChu)q;
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

            bool kq = don.XoaChu(_maChu);
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
                bool kq = don.ThemThuaDat(Session["MaHoSo"].ToString(), txtToBanDo.Text, txtSoThua.Text, txtDiaChiThuaDat.Text, txtDienTich.Text, txtDTSDChung.Text, txtDTSDRieng.Text, drLoaiNguonGoc.SelectedValue, txtMucDich.Text, drHanChe.SelectedValue, txtHanChe.Text, txtNgayBatDau.Text, txtThoiHan.Text);
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua)
            {
                bool kq = don.SuaThuaDat(lblMaThuaDat.Text, Session["MaHoSo"].ToString(), txtToBanDo.Text, txtSoThua.Text, txtDiaChiThuaDat.Text, txtDienTich.Text, txtDTSDChung.Text, txtDTSDRieng.Text, drLoaiNguonGoc.SelectedValue, txtMucDich.Text, drHanChe.SelectedValue, txtHanChe.Text, txtNgayBatDau.Text, txtThoiHan.Text);
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
            grvThuaDat.DataSource = don.dsThuaDat(Session["MaHoSo"].ToString());
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
                    var thuadatdangxet = (from td in db.tblThuaDats
                              where td.MaThuaDat == maThuaDat
                              select td).Single();
                    tblThuaDat thua = (tblThuaDat)thuadatdangxet;
                    lblMaThuaDat.Text = thua.MaThuaDat.ToString();
                    lblMaHoSo.Text = thua.MaHoSo.ToString();
                    txtToBanDo.Text = thua.ToBanDo;
                    txtSoThua.Text = thua.SoThua;
                    txtDiaChi.Text = thua.DiaChi;
                    txtDienTich.Text = thua.DienTich;
                    txtDTSDChung.Text = thua.SuDungChung;
                    txtDTSDRieng.Text = thua.SuDungRieng;
                    txtMucDich.Text = thua.MucDichSuDung;
                    txtThoiHan.Text = thua.ThoiHanSuDung;
                    txtNgayBatDau.Text = thua.NgayBatDauSuDung.ToString();
                    drHanChe.SelectedValue = thua.CoHanCheSuDung.ToString();
                    txtHanChe.Text = thua.NoiDungHanCheSuDung;
                    drLoaiNguonGoc.SelectedValue = thua.LoaiNguonGocSuDung;
                    
                }


            }
        }
        protected void grvThuaDat_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string _maChu = grvChu.DataKeys[e.RowIndex].Value.ToString();

            bool kq = don.XoaChu(_maChu);
            LoadgrvChu();
        }
        #endregion

        #region "NHẬP THÔNG TIN Nhà ở"
        private void LoadgrvNhaO()
        {
            grvNhaO.DataSource = don.dsNhaO(Session["MaHoSo"].ToString());
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
            if ((ThaoTac)Session["ThaoTac"] == ThaoTac.ThemMoi)
            {
                bool kq = don.ThemNhaO(Session["MaHoSo"].ToString(), drLoaiNhaO.Text, txtDienTichXayDung.Text, txtDienTichSan.Text, txtKetCau.Text, txtSoTang.Text, txtSoHuuChung.Text, txtSoHuuRieng.Text, drHanCheNha.Text, txtHanCheNha.Text);
            }
            else if ((ThaoTac)Session["ThaoTac"] == ThaoTac.DangSua)
            {
                bool kq = don.SuaNhaO(lblMaNhaO.Text, drLoaiNhaO.Text, txtDienTichXayDung.Text, txtDienTichSan.Text, txtKetCau.Text, txtSoTang.Text, txtSoHuuChung.Text, txtSoHuuRieng.Text, drHanCheNha.Text, txtHanCheNha.Text);
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
                    var q = (from n in db.tblThongTinNhaOs
                             where n.MaNhaO == maNhaO
                             select n).Single();
                    tblThongTinNhaO nha = (tblThongTinNhaO)q;
                    lblMaNhaO.Text = nha.MaNhaO.ToString();
                    drLoaiNhaO.SelectedValue = nha.LoaiNhaO;
                    txtDienTichXayDung.Text = nha.DienTichXayDung;
                    txtDienTichSan.Text = nha.DienTichSan;
                    txtSoHuuChung.Text = nha.SoHuuChung;
                    txtSoHuuRieng.Text = nha.SoHuuRieng;
                    txtKetCau.Text = nha.KetCau;
                    txtHanCheNha.Text = nha.ThoiHanSoHuu;
                    drHanCheNha.SelectedValue = nha.CoHanCheThoiHanSoHuu.ToString();
                    txtSoTang.Text = nha.SoTang;
                }


            }
        }
        protected void grvNhaO_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string _maNhaO = grvNhaO.DataKeys[e.RowIndex].Value.ToString();

            bool kq = don.XoaNhaO(_maNhaO);
            LoadgrvNhaO();
        }


        #endregion

        //protected void btnChapNhan_Click(object sender, EventArgs e)
        //{
        //    if (txtNguoiNhan.Text != "" && txtSoTiepNhan.Text != "" && txtNgayNhan.Text != "")
        //    {
        //        string MaHoSoKeKhaiDuBi = Session["MaHoSo"].ToString();
        //        Response.Redirect(@"~/VanPhong/ChapNhanHoSo.aspx?MaHoSoKeKhaiDuBi='" + MaHoSoKeKhaiDuBi + "'");
        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('Lỗi ! \n Thông tin tiếp nhận hồ sơ chưa đầy đủ, vì vậy hồ sơ chưa được gửi tới cơ quan chức năng')</script>");
        //    }


        //}


        #region "NHẬP THÔNG TIN GỬI, NHẬN HỒ SƠ"
        protected void LoadThongTinGuiNhanHoSo()
        {
            try
            {
                string s = Session["MaHoSo"].ToString();
                tblHoSoKeKhai HSKeKhaiHienTai = don.LayThongTinHoSoKeKhai(Session["MaHoSo"].ToString());
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
            bool success = don.LuuThongTinXetDuyetCapCSDuBi(Session["MaHoSo"].ToString(), txtTieuDeKinhGui.Text, txtNguoiVietDon.Text, drLoaiDeNghiCapGCN.SelectedValue, txtNghiaVuTaiChinh.Text, txtGiayToKemTheo.Text, txtDeNghiKhac.Text, txtEmailNguoiVietDon.Text, txtDienThoaiNguoiVietDon.Text, txtNguoiNhan.Text, txtNgayNhan.Text, txtSoTiepNhan.Text, txtQuyen.Text);
            Session["ThaoTac"] = ThaoTac.ChiXem;
            ApDungTrangThai();
        }

        protected void btnSuaThongTinHoSo_Click(object sender, EventArgs e)
        {
            Session["ThaoTac"] = ThaoTac.DangSua;
            ApDungTrangThai();
        }
        #endregion

        protected void btnXemHoSo_Click(object sender, EventArgs e)
        {

            Response.Redirect( string.Format( "~/VanPhong/XuLyHoSo/HoSo.aspx?MaHoSo={0}",Session["MaHoSo"].ToString()));
        }

       
    }
}