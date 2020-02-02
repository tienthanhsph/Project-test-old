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
    public partial class XacNhanCapCoSo : System.Web.UI.Page
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
                        loadData(Session["HoSoHienTai"].ToString());
                    }
                    else
                        Response.Write("<script>alert('Có lỗi xảy ra! \n hay quay lại bước trước để kiểm tra');</script>");
                }
                else
                    Response.Write("<script>alert('Có lỗi xảy ra! \n hay quay lại bước trước để kiểm tra');</script>");
            }
        }
        XNCapCoSo n = new XNCapCoSo();
        protected void loadData(string MaHoSo)
        {
            try
            {
                tblXacNhanCapCoSo x = n.result(MaHoSo);
                lblMaHoSoCS.Text = x.MaHoSo.ToString();
                txtNoiDungKeKhaiSoVoiHienTai.Text = x.NoiDungKeKhaiSoVoiHienTrang;
                txtNguonGocSuDungDat.Text = x.NguonGocSuDungDat;
                txtThoiDiemSuDungDatVaoMucDichDangKy.Text = x.ThoiDiemSuDungDatVaoMucDichDangKy.ToString();
                txtThoiDiemTaoLapTaiSanGanLienVoiDat.Text = x.ThoiDiemTaoLapTaiSanGanLienVoiDat.ToString();
                txtSuPhuHopVoiQuyHoachSuDungDatVaQuyHoachXayDung.Text = x.SuPhuHopVoiQuyHoachSuDungDatVaQuyHoachXayDung;
                txtTinhTrangTranhChapDatDaiVaTaiSan.Text = x.TinhTrangTranhChapDatDaiVaTaiSan;
                txtNoiDungKhac.Text = x.NoiDungKhac;

                txtDiaChinh_NgayXacNhan.Text = x.DiaChinh_NgayXacNhan.ToString();
                txtDiaChinh_TieuDeKy.Text = x.DiaChinh_TieuDeKy;
                txtDiaChinh_NguoiKy.Text = x.DiaChinh_CanBo;

                txtUBND_NgayXacNhan.Text = x.UBND_NgayKy.ToString();
                txtUBND_TieuDeKy.Text = x.UBND_TieuDeKy;
                txtUBND_NguoiKy.Text = x.UBND_NguoiKy;
            }
            catch (Exception)
            {
                
                return;
            }
            


        }
        protected void btnLuuXacNhanCS_Click(object sender, EventArgs e)
        {
            if(!n.KiemTraCoXacNhanChua(Session["HoSoHienTai"].ToString())){
               bool kq=  n.TaoXacNhanCapCoSo(Session["HoSoHienTai"].ToString(), txtNoiDungKeKhaiSoVoiHienTai.Text, txtNguonGocSuDungDat.Text, txtThoiDiemSuDungDatVaoMucDichDangKy.Text, txtThoiDiemTaoLapTaiSanGanLienVoiDat.Text, txtTinhTrangTranhChapDatDaiVaTaiSan.Text, txtSuPhuHopVoiQuyHoachSuDungDatVaQuyHoachXayDung.Text, txtNoiDungKhac.Text, txtDiaChinh_NgayXacNhan.Text, txtUBND_NgayXacNhan.Text, txtDiaChinh_TieuDeKy.Text, txtUBND_TieuDeKy.Text, txtDiaChinh_NguoiKy.Text, txtUBND_NguoiKy.Text);
            }
            else
            {
                bool kq = n.SuaXacNhanCapCoSo(Session["HoSoHienTai"].ToString(), txtNoiDungKeKhaiSoVoiHienTai.Text, txtNguonGocSuDungDat.Text, txtThoiDiemSuDungDatVaoMucDichDangKy.Text, txtThoiDiemTaoLapTaiSanGanLienVoiDat.Text, txtTinhTrangTranhChapDatDaiVaTaiSan.Text, txtSuPhuHopVoiQuyHoachSuDungDatVaQuyHoachXayDung.Text, txtNoiDungKhac.Text, txtDiaChinh_NgayXacNhan.Text, txtUBND_NgayXacNhan.Text, txtDiaChinh_TieuDeKy.Text, txtUBND_TieuDeKy.Text, txtDiaChinh_NguoiKy.Text, txtUBND_NguoiKy.Text);
            }
        }

        protected void btnHuyXacNhanCS_Click(object sender, EventArgs e)
        {

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format( "~/VanPhong/XuLyHoSo/XacNhanCuaCoQuanDangKyDatDai.aspx?MaHoSo={0}",Session["HoSoHienTai"].ToString()));
        }

        protected void btnXemHoSo_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/VanPhong/XuLyHoSo/HoSo.aspx?MaHoSo={0}", Session["HoSoHienTai"].ToString()));
        }

     
    }
}