using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;
using DMCWeb.Models;

namespace DMCWeb.VanPhong.XuLyBienDong
{
    public partial class YKienCoQuanTaiNguyenVaMoiTruong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["DangKyBienDong"] = Request.QueryString["DangKyBienDong"];
                if (Session["DangKyBienDong"] != null)
                {
                    if (Convert.ToInt32(Session["DangKyBienDong"]) > 0)
                    {
                        loadData(Session["DangKyBienDong"].ToString());
                    }
                    else
                        Response.Write("<script>alert('Có lỗi xảy ra! \n hay quay lại bước trước để kiểm tra');</script>");
                }
                else
                    Response.Write("<script>alert('Có lỗi xảy ra! \n hay quay lại bước trước để kiểm tra');</script>");
            }
        }


        clsDonViXuLyBienDong n = new clsDonViXuLyBienDong();
        protected void loadData(string DangKyBienDong)
        {
            try
            {
                tblYKienCoQuanTaiNguyenVaMoiTruongVeBienDong ykien = n.resultTNMT(Session["DangKyBienDong"].ToString());
                if (ykien != null)
                {
                    txtNoiDungYKien.Text = ykien.NoiDungYKien;
                    txtNguoiKiemTra.Text = ykien.NguoiKiemTra;
                    if (ykien.NgayKiemTra != null)
                        txtNguoiKiemTra_NgayKy.Text = ykien.NgayKiemTra.ToString();
                    txtThuTruong.Text = ykien.ThuTruongCoQuanKy;
                    if (ykien.NgayKy != null)
                        txtThuTruong_NgayKy.Text=  ykien.NgayKy.ToString();
                    
                    
                }

            }
            catch (Exception)
            {

                return;
            }

        }

        protected void btnXemHoSo_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/NguoiDan/DangKyBienDong/DonDangKyBienDong.aspx?DangKyBienDong={0}&LoaiHoSo=ChinhThuc", Session["DangKyBienDong"].ToString()));
        }

        protected void btnLuuYKien_Click(object sender, EventArgs e)
        {
            if (!n.KiemTraTonTai(Session["DangKyBienDong"].ToString()))
            {
                bool kq = n.ThemXacNhanCoQuanTNMT(Session["DangKyBienDong"].ToString(), txtNguoiKiemTra_NgayKy.Text, txtNguoiKiemTra.Text, txtNoiDungYKien.Text,"",txtThuTruong_NgayKy.Text,txtThuTruong.Text);
                if (kq)
                    Response.Redirect("<script> alert('Thành công!');</cript>");
                else
                    Response.Redirect("<script> alert('Lỗi!');</cript>");
            }
            else
            {
                bool kq = n.SuaXacNhanCoQuanTNMT(Session["DangKyBienDong"].ToString(), txtNguoiKiemTra_NgayKy.Text, txtNguoiKiemTra.Text, txtNoiDungYKien.Text, "", txtThuTruong_NgayKy.Text, txtThuTruong.Text);
                if (kq)
                    Response.Redirect("<script> alert('Thành công!');</cript>");
                else
                    Response.Redirect("<script> alert('Lỗi!');</cript>");
            }
        }
    }
}