using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMCWeb.Logic;

namespace DMCWeb.VanPhong
{
    public partial class ChapNhanHoSo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // xử lý chấp nhận hồ sơ ở đây
                string s = Request.QueryString["MaHoSoKeKhaiDuBi"].ToString() ;
                XuLyDonXinCapGCN don = new XuLyDonXinCapGCN();

                if (!don.KiemTraDuDieuKienChapNhan(s))
                {
                    Response.Write("<script>alert('Hồ sơ chưa đủ điều kiện!')</script>");
                    return;
                }
                    

                if(don.ChapNhanHoSo(s))
                {
                    if (don.XoaHoSoDuBi(s))
                    {
                        Response.Write("<script>alert('Thành công!')</script>");
                        Response.Redirect("~/VanPhong/TiepNhanDon/BaoCaoHoSoDangKyMoi.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('LỖI! ~_~ ')</script>");
                    }
                }
                
                
            }
        }
        
    }
}