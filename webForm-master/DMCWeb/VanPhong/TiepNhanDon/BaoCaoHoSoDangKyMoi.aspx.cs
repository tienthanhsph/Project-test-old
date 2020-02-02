using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;

namespace DMCWeb
{
    public partial class BaoCao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ChckDVHC.Checked = false;
                drDonViHanhChinh.Visible = false;
                TimTatCa();
            }
            
        }
        clsTimKiem tim = new clsTimKiem();
        protected void btnTim_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
        protected void TimKiem()
        {
            try
            {
                if (drDonViHanhChinh.Visible)
                {
                    GridView1.DataSource = tim.TimKiemHoSoKeKhaiDuBi(drDonViHanhChinh.SelectedValue.ToString(), txtTen.Text, txtCMND.Text, txtDiaChi.Text, txtToBanDo.Text, txtSoThua.Text).ToArray();
                }
                else
                {
                    GridView1.DataSource = tim.TimKiemHoSoKeKhaiDuBi("", txtTen.Text, txtCMND.Text, txtDiaChi.Text, txtToBanDo.Text, txtSoThua.Text).ToArray();
                }


                GridView1.DataBind();
                ThongBao();

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
                if (drDonViHanhChinh.Visible== true)
                {
                    GridView1.DataSource = tim.TimKiemHoSoKeKhaiDuBi(drDonViHanhChinh.SelectedValue.ToString(), "", "", "", "", "").ToArray();
                }
                else
                {
                    GridView1.DataSource = tim.TimKiemHoSoKeKhaiDuBi("", "", "", "", "", "").ToArray();
                }
                GridView1.DataBind();
                ThongBao();
            }
            catch (Exception ex)
            {

                string s = ex.Message;
            }
        }
        protected void ThongBao()
        {
            lblThongBao.Text = "Có  " + GridView1.Rows.Count.ToString()+" hồ sơ đang chờ duyệt .";
        }

        protected void tblTimTatCa_Click(object sender, EventArgs e)
        {           
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtSoThua.Text = "";
            txtTen.Text = "";
            txtToBanDo.Text = "";


            TimTatCa();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                string MaHoSoKeKhaiDuBi = e.CommandArgument.ToString();
                Response.Redirect(@"~/VanPhong/TiepNhanDon/ChapNhanHoSo.aspx?MaHoSoKeKhaiDuBi=" + MaHoSoKeKhaiDuBi+"");
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
            TimKiem();
        }

        protected void drDonViHanhChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

       
    }
}