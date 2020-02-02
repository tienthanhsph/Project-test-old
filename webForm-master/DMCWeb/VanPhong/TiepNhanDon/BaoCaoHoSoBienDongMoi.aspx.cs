using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;

namespace DMCWeb.VanPhong.TiepNhanDon
{
    public partial class BaoCaoHoSoBienDongMoi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ChckDVHC.Checked = false;
                drDonViHanhChinh.Visible = false;
                
            }
        }
        clsTimKiem tim = new clsTimKiem();

        
        protected void btnTimKiemBienDong_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
        protected void TimKiem()
        {
            try
            {
                string _maDVHC = "";
                if (drDonViHanhChinh.Visible == true)
                    _maDVHC = drDonViHanhChinh.SelectedValue.ToString();
                else
                    _maDVHC = "";
                string _maLoaiBienDong = "";
                if (drLoaiBienDong.SelectedValue != "0")
                    _maLoaiBienDong = drLoaiBienDong.SelectedValue;
                GridView2.DataSource = tim.TimKiemDonDangKyBienDongDuBiDaGui(_maDVHC, txtNguoiVietDon.Text, _maLoaiBienDong, txtSoPhatHanhGCN.Text, txtSoVaoSoCapGCN.Text, txtNgayCapGCN.Text).ToArray();
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
            TimKiem();
        }

        protected void drDonViHanhChinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}