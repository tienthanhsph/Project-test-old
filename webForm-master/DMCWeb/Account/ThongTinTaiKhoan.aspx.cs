using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMCWeb.Account
{
    public partial class ThongTinTaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                if (Session["Username"].ToString() != "")
                {
                    Label1.Text ="Thông tin tài khoản : "+ Session["Username"].ToString();
                }
            }
            
        }
    }
}