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
    public partial class XacNhanCapCoSo_BienDong : System.Web.UI.Page
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
                tblXacNhanCapCoSoVeBienDong xacnhan = n.LayXacNhanCapCoSo(Session["DangKyBienDong"].ToString());
                if (xacnhan != null)
                {
                    txtNoiDungXacNhan.Text = xacnhan.NoiDungXacNhan;
                    txtNoiDungKhac.Text = xacnhan.NoiDungKhac;
                    if(xacnhan.DiaChinh_NgayXacNhan != null)
                    txtDiaChinh_NgayKy.Text = xacnhan.DiaChinh_NgayXacNhan.ToString();
                    txtDiaChinh_NguoiKy.Text = xacnhan.DiaChinh_CanBo;
                    txtDiaChinh_TieuDeKy.Text = xacnhan.DiaChinh_TieuDeKy;
                    if(xacnhan.UBND_NgayKy != null)
                    txtUBND_NgayKy.Text = xacnhan.UBND_NgayKy.ToString();
                    txtUBND_NguoiKy.Text = xacnhan.UBND_NguoiKy;
                    txtUBND_TieuDeKy.Text = xacnhan.UBND_TieuDeKy;
                }

            }
            catch (Exception)
            {

                return;
            }



        }
        protected void btnLuuXacNhanCS_Click(object sender, EventArgs e)
        {
            if (!n.KiemTraCoXacNhanChua(Session["DangKyBienDong"].ToString()))
            {
                bool kq = n.TaoXacNhanCapCoSo(Session["DangKyBienDong"].ToString(),txtNoiDungXacNhan.Text,txtNoiDungKhac.Text, txtDiaChinh_NgayKy.Text, txtUBND_NgayKy.Text,txtDiaChinh_TieuDeKy.Text, txtUBND_TieuDeKy.Text, txtDiaChinh_NguoiKy.Text, txtUBND_NguoiKy.Text);
                if (kq)
                    Response.Redirect("<script> alert('Thành công!');</cript>");
                else
                    Response.Redirect("<script> alert('Lỗi!');</cript>");
            }
            else
            {
                bool kq = n.SuaXacNhanCapCoSo(Session["DangKyBienDong"].ToString(), txtNoiDungXacNhan.Text, txtNoiDungKhac.Text, txtDiaChinh_NgayKy.Text, txtUBND_NgayKy.Text, txtDiaChinh_TieuDeKy.Text, txtUBND_TieuDeKy.Text, txtDiaChinh_NguoiKy.Text, txtUBND_NguoiKy.Text);
                if (kq)
                    Response.Redirect("<script> alert('Thành công!');</cript>");
                else
                    Response.Redirect("<script> alert('Lỗi!');</cript>");
            }
        }

       
       
        protected void btnXemHoSo_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/NguoiDan/DangKyBienDong/DonDangKyBienDong.aspx?DangKyBienDong={0}&LoaiHoSo=ChinhThuc", Session["DangKyBienDong"]));


        }
    }
}