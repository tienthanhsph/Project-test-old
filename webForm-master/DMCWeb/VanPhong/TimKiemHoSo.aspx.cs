using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;

namespace DMCWeb
{
    public partial class TimKiem : System.Web.UI.Page
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
                if (drDonViHanhChinh.Visible)
                {
                    GridView1.DataSource = tim.TimKiemHoSo(drDonViHanhChinh.SelectedValue.ToString(), txtTen.Text, txtCMND.Text, txtDiaChi.Text, txtToBanDo.Text, txtSoThua.Text).ToArray();
                }
                else
                {
                    GridView1.DataSource = tim.TimKiemHoSo("", txtTen.Text, txtCMND.Text, txtDiaChi.Text, txtToBanDo.Text, txtSoThua.Text).ToArray();
                }


                GridView1.DataBind();
               

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
                    GridView1.DataSource = tim.TimKiemHoSo(drDonViHanhChinh.SelectedValue.ToString(), "", "", "", "", "").ToArray();
                }
                else
                {
                    GridView1.DataSource = tim.TimKiemHoSo("", "", "", "", "", "").ToArray();
                }
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
            Tim();
        }

        protected void drDonViHanhChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tim();
        }
    }
}