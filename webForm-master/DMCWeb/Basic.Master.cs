using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMCWeb
{
    public partial class Basic : System.Web.UI.MasterPage
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    if (Session["Username"].ToString().Trim() != "")
                    {
                        ChuaDangNhap.Visible = false;
                        DangDangNhap.Visible = true;
                        lblUsername.Text = Session["Username"].ToString();
                    }
                    else
                    {
                        lblUsername.Text = "";
                        DangDangNhap.Visible = false;
                        ChuaDangNhap.Visible = true;
                    }
                }
                else
                {

                    lblUsername.Text = "";
                    DangDangNhap.Visible = false;
                    ChuaDangNhap.Visible = true;
                }

                if (Session["Quyen"] != null)
                {

                }
            }
            
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            if(txtThongTinTimKiem.Text.Trim() != "" && txtThongTinTimKiem.Text.Trim() != "Nhập họ tên hoặc số CMND...")
            {
                Response.Redirect("~/NguoiDan/TimKiemHoSoDuBi_SearchTab.aspx?str="+txtThongTinTimKiem.Text.Trim());
            }
            else
            {
                txtThongTinTimKiem.Text = "Nhập họ tên hoặc số CMND...";
            }
        }
    }
}