using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMCWeb.TuDien
{
    public partial class TuDienLoaiDeNghiDangKyCapGCN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {

            }
            else if (e.CommandName == "Edit")
            {


                DetailsView1.ChangeMode(DetailsViewMode.Edit);
            }
            else if (e.CommandName == "Select")
            {
                DetailsView1.ChangeMode(DetailsViewMode.Edit);

            }
            else if (e.CommandName == "New")
            {
                DetailsView1.ChangeMode(DetailsViewMode.Insert);

            }
            else
            {
                string cmdname = e.CommandName.ToString();
            }
        }

        protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            GridView1.DataBind();
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            GridView1.DataBind();
        }
    }
}