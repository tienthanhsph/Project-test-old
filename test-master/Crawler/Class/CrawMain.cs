using SH.Crawler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SH.SSM.Crawler
{
    public class CrawMain
    {
        public delegate void LogHandler(string logMessenger);
        public event LogHandler LogEvent;
        private string SiteCode, FixUrl;
        private BaseSite CrawSite;
        public CrawMain(string _SiteCode, string _fixUrl, string _ItemGroup)
        {
            SiteCode = _SiteCode;
            FixUrl = _fixUrl;

            if (SiteCode == EnumSiteCode.Dienmayxanh.ToString())
                CrawSite = new CRDienmayxanh(FixUrl, _ItemGroup); 

            if (SiteCode == EnumSiteCode.HC.ToString())
                CrawSite = new CRHC(FixUrl, _ItemGroup);

            if (SiteCode == EnumSiteCode.Mediamart.ToString())
                CrawSite = new CRMediamart(FixUrl, _ItemGroup); 

            if (SiteCode == EnumSiteCode.Pico.ToString())
                CrawSite = new CRPico(FixUrl, _ItemGroup);

            if (SiteCode == EnumSiteCode.Phankhang.ToString())
                CrawSite = new CRPhankhang(FixUrl, _ItemGroup);

            if (SiteCode == EnumSiteCode.Nguyenkim.ToString())
                CrawSite = new CRNguyenkim(FixUrl, _ItemGroup);


            CrawSite.LogEvent += cr_LogEvent;
            CrawSite.CrawInfoEvent += CrawSite_CrawInfoEvent;
        }

        void CrawSite_CrawInfoEvent(CrawInfoCls CrawInfo)
        {

            dbModelDataContext db = new dbModelDataContext();
            var iCheck = (from i in db.CRItemPrices
                          where i.SiteCode == CrawInfo.SiteCode && i.ItemSiteCode == CrawInfo.ItemSiteCode
                          select i).ToList();

            if (iCheck.Count > 0)
            {
                db.CRItemPrices.DeleteAllOnSubmit(iCheck);
                db.SubmitChanges();
            }

            CRItemPrice iNew = new CRItemPrice();
            iNew.SiteCode = CrawInfo.SiteCode;
            iNew.ItemSiteCode = CrawInfo.ItemSiteCode;
            iNew.ItemBrand = CrawInfo.ItemBrand;
            iNew.ItemSiteName = CrawInfo.ItemSiteName;
            iNew.SiteItemGroup = CrawInfo.SiteItemGroup;
            iNew.SitePrice = CrawInfo.SitePrice;
            iNew.UrlCheck = CrawInfo.UrlCheck;
            iNew.CreateDate = DateTime.Now;
            iNew.CreateBy = "SoftWare";
            db.CRItemPrices.InsertOnSubmit(iNew);
            db.SubmitChanges();


            cr_LogEvent(string.Format("Mã hàng: {0}, giá: {1}, Thương hiệu: {2}", CrawInfo.ItemSiteCode, CrawInfo.SitePrice, CrawInfo.ItemBrand));
        }

        public void Craw()
        {
            CrawSite.CrawlerSite();
        }

        void cr_LogEvent(string logMessenger)
        {
            if (LogEvent != null)
                LogEvent(logMessenger);
        }

    }
}