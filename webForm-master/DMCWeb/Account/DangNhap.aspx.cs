using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;
using DMCWeb.Models;
namespace DMCWeb.Account
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        clsTaiKhoan taikhoan = new clsTaiKhoan();
        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                tblUser curUser = taikhoan.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
                if(curUser != null)
                {
                    Session["Username"] = curUser.TenDangNhap;
                    Session["Quyen"] = curUser.MaQuyen;

                    
                    Response.Write("<script> alert('Đăng nhập thành công.'); </script>");
                    Response.Redirect("~/TrangChuKeKhai.aspx");
                }
                else
                {
                    Response.Write("<script> alert('Lỗi!'); </script>");
                }
            }
            catch (Exception)
            {
                
                 Response.Write("<script> alert('Lỗi!'); </script>");
            }
        }
    }
}