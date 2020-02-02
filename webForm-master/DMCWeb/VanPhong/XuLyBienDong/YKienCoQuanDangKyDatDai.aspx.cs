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
    public partial class YKienCoQuanDangKyDatDai : System.Web.UI.Page
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
                tblYKienCoQuanDangKyDatDaiVeBienDong ykien = n.result(Session["DangKyBienDong"].ToString());
                if (ykien != null)
                {
                    txtNoiDungYKien.Text = ykien.NoiDungYKien;
                    txtNguoiKiemTra.Text = ykien.NguoiKiemTra;
                    if(ykien.NgayKiemTra != null)
                    txtNguoiKiemTra_NgayKy.Text = ykien.NgayKiemTra.ToString();
                    txtGiamDoc.Text = ykien.GiamDoc;
                    if(ykien.NgayKy!= null)
                    txtGiamDoc_NgayKy.Text = ykien.NgayKy.ToString();
                    txtGhiChu.Text = ykien.GhiChu;
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
                bool kq = n.ThemXacNhanCoQuanDangKy(Session["DangKyBienDong"].ToString(), txtNguoiKiemTra_NgayKy.Text, txtNguoiKiemTra.Text,"", txtNoiDungYKien.Text, txtGhiChu.Text, txtGiamDoc_NgayKy.Text, txtGiamDoc.Text);
                if (kq)
                    Response.Redirect("<script> alert('Thành công!');</cript>");
                else
                    Response.Redirect("<script> alert('Lỗi!');</cript>");
            }
            else
            {
                bool kq = n.SuaXacNhanCoQuanDangKy(Session["DangKyBienDong"].ToString(), txtNguoiKiemTra_NgayKy.Text, txtNguoiKiemTra.Text, "", txtNoiDungYKien.Text, txtGhiChu.Text, txtGiamDoc_NgayKy.Text, txtGiamDoc.Text);
                if (kq)
                    Response.Redirect("<script> alert('Thành công!');</cript>");
                else
                    Response.Redirect("<script> alert('Lỗi!');</cript>");
            }
        }
    }
}