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
    public partial class HoSo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["HoSoHienTai"] = Request.QueryString["MaHoSo"];
               
                if (Session["HoSoHienTai"] != null)
                {
                    if (Convert.ToInt32(Session["HoSoHienTai"]) > 0)
                    {
                        LoadThongTin(Session["HoSoHienTai"].ToString());
                        lblMaHoSo.Text = "HỒ SƠ: " + Session["HoSoHienTai"].ToString();
                    }
                    else
                    {
                        Session["HoSoHienTai"] = "";
                        lblMaHoSo.Text = "Rất tiếc! Không hiển thị hồ sơ nào.";
                    }
                }
                else
                {
                    Session["HoSoHienTai"] = "";
                    lblMaHoSo.Text = "Rất tiếc! Không hiển thị hồ sơ nào.";
                }
            }
        }
        protected void LoadThongTin(string MaHoSo)
        {
            try
            {
                long _maHoSo = long.Parse(MaHoSo);
                
                XuLyDonXinCapGCN don = new XuLyDonXinCapGCN();

                tblHoSoKeKhai kk = don.LayThongTinHoSoKeKhai(MaHoSo);
                if (kk != null)
                {
                    lblTieuDeDon.Text = kk.KinhGuiCoQuanChucNang;
                    lblNguoiVietDon.Text = kk.NguoiVietDon;
                    lblEmail.Text = kk.DiaChiMail;
                    lblDienThoai.Text = kk.SoDienThoaiLienHe;
                    lblDeNghi.Text = kk.MaLoaiDeNghi;
                    lblDeNghiKhac.Text = kk.DeNghiKhac;
                    lblNgayNhanHoSo.Text = ((DateTime)kk.NgayNhanHoSo).ToString("dd/MM/yyyy");
                    lblNguoiNhanHoSo.Text = kk.NguoiNhanHoSo;
                    lblSoVaoSo.Text = kk.SoTiepNhan;
                    lblQuyen.Text = kk.Quyen;
                    lblNghiaVuTaiChinh.Text = kk.NghiaVuTaiChinh;
                    lblGiayToKemTheo.Text = kk.GiayToKemTheo;
                }
                
                grvChu.DataSource = don.dsChu(MaHoSo);
                grvChu.DataBind();

                grvThuaDat.DataSource = don.dsThuaDat(MaHoSo);
                grvThuaDat.DataBind();

                grvNhaO.DataSource = don.dsNhaO(MaHoSo);
                grvNhaO.DataBind();


                // thong tin rung cay lau nam...

                // thong tin rung san xuat...

                // thong tin xet duyet cap co so
                tblXacNhanCapCoSo xd1 = don.LayThongTinXacNhanCapCoSo(MaHoSo);
                if (xd1 != null)
                {
                    lblNoiDungKeKhaiSoVoiHienTai.Text = xd1.NoiDungKeKhaiSoVoiHienTrang;
                    lblNguonGoc.Text = xd1.NguonGocSuDungDat;
                    lblThoiDiemSuDungDat.Text = ((DateTime)xd1.ThoiDiemSuDungDatVaoMucDichDangKy).ToString("dd/MM/yyyy");
                    lblThoiDiemTaoTaiSan.Text = ((DateTime)xd1.ThoiDiemTaoLapTaiSanGanLienVoiDat).ToString("dd/MM/yyyy");
                    lblTinhTrangTranhChap.Text = xd1.TinhTrangTranhChapDatDaiVaTaiSan;
                    lblPhuHopQuyHoach.Text = xd1.SuPhuHopVoiQuyHoachSuDungDatVaQuyHoachXayDung;
                    lblNoiDungKhac.Text = xd1.NoiDungKhac;
                    lblDiaChinhNgay.Text = ((DateTime)xd1.DiaChinh_NgayXacNhan).ToString("dd/MM/yyyy");
                    lblDiaChinhNguoi.Text = xd1.DiaChinh_CanBo;
                    lblDiaChinhTieuDe.Text = xd1.DiaChinh_TieuDeKy;
                    lblUBNDNgay.Text = ((DateTime)xd1.UBND_NgayKy).ToString("dd/MM/yyyy");
                    lblUBNDNguoi.Text = xd1.UBND_NguoiKy;
                    lblUBNDTieuDe.Text = xd1.UBND_TieuDeKy;
                }

                // thong tin xac nhan co quan dang ky
                tblXacNhanCoQuanDangKyDatDai xd2 = don.LayThongTinXacNhanCoQuanDangKy(MaHoSo);
                if(xd2!= null)
                {
                    lblNgayKiemTra.Text = ((DateTime)xd2.NgayKiemTra).ToString("dd/MM/yyyy");
                    lblNguoiKiemTra.Text = xd2.NguoiKiemTra;
                    lblChucVuNguoiKiemTra.Text = xd2.ChucVuNguoiKiemTra;
                    lblNoiDungYKien.Text = xd2.NoiDungYKien;
                    lblGhiChuYKien.Text = xd2.GhiChu;
                    lblNgayKyVPDK.Text = ((DateTime)xd2.NgayKy).ToString("dd/MM/yyyy");
                    lblGiamDocVPDK.Text = xd2.GiamDoc;
                }

            }
            catch (Exception)
            {
                return;
            }
           

        }

        protected void btnSuaHoSo_Click(object sender, EventArgs e)
        {
            string s = string.Format("~/VanPhong/XuLyHoSo/HoSoDangKyCapGCN.aspx?MaHoSo={0}", Session["HoSoHienTai"]);
            Response.Redirect(string.Format("~/VanPhong/XuLyHoSo/HoSoDangKyCapGCN.aspx?MaHoSo={0}", Session["HoSoHienTai"]));
            // sẽ sửa tran HoSoDangKyCapGCN sau!
        }

        protected void btnXetDuyetCapCoSo_Click(object sender, EventArgs e)
        {

            Response.Redirect(string.Format("~/VanPhong/XuLyHoSo/XacNhanCapCoSo.aspx?MaHoSo={0}", Session["HoSoHienTai"].ToString()));
        }

        protected void btnXacNhanCoQuanDangKyDatDai_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/VanPhong/XuLyHoSo/XacNhanCuaCoQuanDangKyDatDai.aspx?MaHoSo={0}", Session["HoSoHienTai"].ToString()));
        }

    }
}