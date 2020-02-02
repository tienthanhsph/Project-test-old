using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;

namespace DMCWeb.VanPhong
{
    public partial class TimKiemHoSoBienDong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ChckDVHC.Checked = false;
                drDonViHanhChinh.Visible = false;
                TimTatCa();
            }
        }
        clsTimKiem tim = new clsTimKiem();
        protected void btnTim_Click(object sender, EventArgs e)
        {
            Tim();

        }


        protected void Tim()
        {
            try
            {
                string _loaiBD = "";
                if (drLoaiBienDong.SelectedValue != "0")
                    _loaiBD = drLoaiBienDong.SelectedValue;
                if (drDonViHanhChinh.Visible)
                {
                    GridView2.DataSource = tim.TimKiemHoSoDangKyBienDong(drDonViHanhChinh.SelectedValue.ToString(), txtNguoiVietDon.Text, _loaiBD, txtSoPhatHanhGCN.Text, txtSoVaoSoCapGCN.Text, txtNgayCapGCN.Text).ToArray();
                }
                else
                {
                    GridView2.DataSource = tim.TimKiemHoSoDangKyBienDong("", txtNguoiVietDon.Text, _loaiBD, txtSoPhatHanhGCN.Text, txtSoVaoSoCapGCN.Text, txtNgayCapGCN.Text).ToArray();
                }


                GridView2.DataBind();


            }
            catch (Exception ex)
            {

                string s = ex.Message;
            }

        }

        protected void TimTatCa()
        {
            try
            {

                if (drDonViHanhChinh.Visible == true)
                {
                    GridView2.DataSource = tim.TimKiemHoSoDangKyBienDong(drDonViHanhChinh.SelectedValue.ToString(), "", "", "", "", "").ToArray();
                }
                else
                {
                    GridView2.DataSource = tim.TimKiemHoSoDangKyBienDong("", "", "", "", "", "").ToArray();
                }
                GridView2.DataBind();

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
            Tim();
        }

        protected void drDonViHanhChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tim();
        }
    }
}