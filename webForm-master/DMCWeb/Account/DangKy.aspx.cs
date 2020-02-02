using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;

namespace DMCWeb.Account
{
    public partial class DangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        clsTaiKhoan taikhoan = new clsTaiKhoan();
        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(taikhoan.ThemTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text, txtHoTen.Text,drMaQuyen.SelectedValue.ToString(), txtNguoiQuanLy.Text, txtNgayTao.Text,txtChucVu.Text,txtPhongBan.Text,txtDiaChi.Text,txtSoDienThoai.Text))
            {
                Response.Write("<script> alert('Đã tạo tài khoản mới.'); </script>");
               
                
                txtTaiKhoan.Text="";
                txtMatKhau.Text="";
                txtMatKhau2.Text = "";
                txtHoTen.Text="";
                drMaQuyen.SelectedIndex = -1;
                txtNguoiQuanLy.Text="";
                txtNgayTao.Text="";
                txtChucVu.Text="";
                txtPhongBan.Text="";
                txtDiaChi.Text="";
                txtSoDienThoai.Text = "";
            }
            else
            {
                Response.Write("<script> alert('Lỗi!'); </script>");
            }
        }
    }
}