using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;
using DMCWeb.Models;

namespace DMCWeb.TienIch
{
    public partial class TimKiemNguoi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["DangKyBienDong"] = Request.QueryString["MaDangKyBienDong"].ToString();
        
            }
            

        }
        clsTimKiem cls = new clsTimKiem();
        protected void btnTim_Click(object sender, EventArgs e)
        {
            Tim();
        }
        protected void Tim()
        {
            try
            {
                if(txtToBanDo.Text.Trim()==  "" && txtSoThua.Text.Trim()=="" && drDonViHanhChinh.Visible == false)
                {
                    GridView1.DataSource = cls.TimKiemChu(txtHoTen.Text, txtCMND.Text, txtDiaChi.Text).ToArray();
                    GridView1.DataBind();
                }
                else
                {
                    GridView1.DataSource = cls.TimKiemChu(txtHoTen.Text, txtCMND.Text, txtDiaChi.Text, drDonViHanhChinh.SelectedValue, txtToBanDo.Text,txtSoThua.Text).ToArray();
                    GridView1.DataBind();
                }
                
            }
            catch (Exception)
            {

                return;
            }
            
        }
        protected void ChckDVHC_CheckedChanged(object sender, EventArgs e)
        {
            if (ChckDVHC.Checked == true)
            {
                drDonViHanhChinh.Visible = true;
            }
            else
            {
                drDonViHanhChinh.Visible = false;
            }
            Tim();
        }

        protected void drDonViHanhChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tim();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName =="Select")
            {
                long _maChu = long.Parse( e.CommandArgument.ToString());
               
                if(Convert.ToInt32(Session["DangKyBienDong"])>0)
                {
                  

                    XuLyDangKyBienDong don = new XuLyDangKyBienDong();
                    don.ThemChu(false, Session["DangKyBienDong"].ToString(), e.CommandArgument.ToString());
                    
                    Response.Redirect(string.Format("~/NguoiDan/DangKyBienDong/DonDangKyBienDong.aspx?MaDangKyBienDong={0}", Session["DangKyBienDong"].ToString()));
                }
            }
        }
    }
}