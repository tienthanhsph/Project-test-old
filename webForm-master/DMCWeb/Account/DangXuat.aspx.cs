using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMCWeb.Account
{
    public partial class DangXuat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Username"] = "";
            Session["Quyen"] = "";

            Response.Redirect("~/TrangChuKeKhai.aspx");
        }
    }
}