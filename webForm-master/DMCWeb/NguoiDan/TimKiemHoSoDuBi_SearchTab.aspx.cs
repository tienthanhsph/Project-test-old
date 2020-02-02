using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;
namespace DMCWeb.NguoiDan
{
    public partial class TimKiemHoSoDuBi_SearchTab : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["str"] != null)
                {
                    TimKiem(Request.QueryString["str"].ToString());
                }
            }
        }
        clsTimKiem tim = new clsTimKiem();
        protected void TimKiem(string str)
        {
            try
            {
                GridView1.DataSource = tim.TimKiemNhanhHS(str).ToArray();
                GridView1.DataBind();
                GridView2.DataSource = tim.TimKiemNhanhBD(str).ToArray();
                GridView2.DataBind();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
        }
    }
}