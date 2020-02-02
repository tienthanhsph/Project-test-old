using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMCWeb
{
    public partial class Excute : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    if (Session["Username"].ToString().Trim() != "")
                    {
                        DangDangNhap.Visible = true;
                        lblUsername.Text = Session["Username"].ToString();
                    }
                    else
                    {
                        lblUsername.Text = "";
                        DangDangNhap.Visible = false;
                    }
                }
                else
                {

                    lblUsername.Text = "";
                    DangDangNhap.Visible = false;
                }

                if (Session["Quyen"] != null)
                {

                }
            }
        }
    }
}