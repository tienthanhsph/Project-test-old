using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;

namespace DMCWeb
{
    public partial class TimKiemHoSoDuBi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ChckDVHC.Checked = false;
                drDonViHanhChinh.Visible = false;
                TimKiemDangKyCapGCN.Visible = true;
                TimKiemDangKyBienDong.Visible = false;
                rdLoaiDonTimKiem.SelectedValue = "1";
            }
        }
        clsTimKiem tim = new clsTimKiem();
        protected void btnTim_Click(object sender, EventArgs e)
        {
            try 
	        {
                string _maDVHC="";
                if(drDonViHanhChinh.Visible == true)
                    _maDVHC=drDonViHanhChinh.SelectedValue.ToString();
                else 
                    _maDVHC="";
                GridView1.DataSource = tim.TimKiemHoSoKeKhaiDuBi(_maDVHC, txtTen.Text, txtCMND.Text, txtDiaChi.Text, txtToBanDo.Text, txtSoThua.Text).ToArray();
                GridView1.DataBind();
	        }
	        catch (Exception ex)
	        {

                string s = ex.Message;
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
        }

     
        protected void rdLoaiDonTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdLoaiDonTimKiem.SelectedValue == "1")
            {
                TimKiemDangKyCapGCN.Visible = true;
                TimKiemDangKyBienDong.Visible = false;
            }
            else if (rdLoaiDonTimKiem.SelectedValue == "2")
            {
                TimKiemDangKyCapGCN.Visible = false;
                TimKiemDangKyBienDong.Visible = true;
            }
        }

        protected void btnTimKiemBienDong_Click(object sender, EventArgs e)
        {
            try
            {
                string _maDVHC = "";
                if (drDonViHanhChinh.Visible == true)
                    _maDVHC = drDonViHanhChinh.SelectedValue.ToString();
                else
                    _maDVHC = "";
               string _maLoaiBienDong="";
                if (drLoaiBienDong.SelectedValue != "0")
                      _maLoaiBienDong = drLoaiBienDong.SelectedValue;
                GridView2.DataSource = tim.TimKiemDonDangKyBienDongDuBi(_maDVHC, txtNguoiVietDon.Text, _maLoaiBienDong, txtSoPhatHanhGCN.Text, txtSoVaoSoCapGCN.Text, txtNgayCapGCN.Text).ToArray();
                GridView2.DataBind();
            }
            catch (Exception ex)
            {

                string s = ex.Message;
            }
        }
    }
}