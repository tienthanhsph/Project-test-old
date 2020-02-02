using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Models;
using DMCWeb.Logic;

namespace DMCWeb.VanPhong.XuLyHoSo
{
    public partial class XacNhanCuaCoQuanDangKyDatDai : System.Web.UI.Page
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
        XNCoQuanDangKy n = new XNCoQuanDangKy();
        protected void loadData(string MaHoSo)
        {
            try
            {
                tblXacNhanCoQuanDangKyDatDai xn = n.result(MaHoSo);

                lblMaHoSo.Text = xn.MaHoSo.ToString();
                txtNgayKiemTra.Text = xn.NgayKiemTra.ToString();
                txtNguoiKiemTra.Text = xn.NguoiKiemTra;
                txtChucVuNguoiKiemTra.Text = xn.ChucVuNguoiKiemTra;

                txtNoiDungYKien.Text = xn.NoiDungYKien;
                txtGhiChu.Text = xn.GhiChu;
                txtNgayKy.Text = xn.NgayKy.ToString();
                txtGiamDoc.Text = xn.GiamDoc;
            }
            catch (Exception)
            {

                return;
            }



        }
        protected void btnLuuCoQuanDangKyDatDai_Click(object sender, EventArgs e)
        {
            if (!n.KiemTraTonTai(Session["HoSoHienTai"].ToString()))
            {
               bool kq= n.ThemXacNhanCoQuanDangKy(Session["HoSoHienTai"].ToString(), txtNgayKiemTra.Text, txtNguoiKiemTra.Text, txtChucVuNguoiKiemTra.Text,txtNoiDungYKien.Text,txtGhiChu.Text,txtNgayKy.Text,txtGiamDoc.Text);
            }
            else{
                bool kq= n.SuaXacNhanCoQuanDangKy(Session["HoSoHienTai"].ToString(), txtNgayKiemTra.Text, txtNguoiKiemTra.Text, txtChucVuNguoiKiemTra.Text, txtNoiDungYKien.Text, txtGhiChu.Text, txtNgayKy.Text, txtGiamDoc.Text);
            }
        }

        protected void btnSuaCoQuanDangKyDatDai_Click(object sender, EventArgs e)
        {

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/VanPhong/HoanThanh.aspx");
        }

        protected void btnXemHoSo_Click(object sender, EventArgs e)
        {
            string s = Session["HoSoHienTai"].ToString();
            Response.Redirect(string.Format( "~/VanPhong/XuLyHoSo/HoSo.aspx?MaHoSo={0}",Session["HoSoHienTai"].ToString()));
        }
    }
}