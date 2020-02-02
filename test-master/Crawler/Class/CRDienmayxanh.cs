using HtmlAgilityPack;
using SH.Crawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SH.SSM.Crawler
{
    public class CRDienmayxanh : BaseSite
    {
        private string fixUrl;
        private string SiteItemGroup;
        public CRDienmayxanh(string url, string iGroup)
        {
            this.SiteCode = EnumSiteCode.Dienmayxanh.ToString();
            SiteItemGroup = iGroup;

            if (!string.IsNullOrEmpty(url))
                fixUrl = url;
        }

        public override void CrawlerSite()
        {
            LoadCrawSite(this.fixUrl);
        }

        public void LoadCrawSite(string url)
        {
            int CurrentItem = 0;
            string baseUrl = string.Empty;
            int CurrentPage = 1;
            baseUrl = url + string.Format("?page={0}", CurrentPage.ToString());

            HtmlAgilityPack.HtmlDocument document = LoadPage(baseUrl);

            var listNodes = document.DocumentNode.SelectNodes("//ul[@class='cate ']/li");
            if (listNodes == null) return;
            foreach (var ulItem in listNodes)
            {
                if (GlobalEnv.StopRuning)
                    break;

                string ItemSiteName = ulItem.SelectSingleNode(ulItem.XPath + "//h3") != null ? ulItem.SelectSingleNode(ulItem.XPath + "//h3").InnerText : string.Empty;
                string SitePrice = ulItem.SelectSingleNode(ulItem.XPath + "/strong") != null ? ulItem.SelectSingleNode(ulItem.XPath + "/strong").InnerText : string.Empty;
                string linkItemCode = ulItem.SelectSingleNode(ulItem.XPath + "/div/a") != null ? ulItem.SelectSingleNode(ulItem.XPath + "/div/a").Attributes["href"].Value : string.Empty;
                string ItemSiteCode = linkItemCode.Substring(linkItemCode.LastIndexOf('/') + 1, linkItemCode.Length - linkItemCode.LastIndexOf('/') - 1);
                string ItemBrand = ItemSiteCode.Substring(0, ItemSiteCode.IndexOf('-'));

                SitePrice = SitePrice.Replace("₫", string.Empty);
                SitePrice = SitePrice.Replace(".", string.Empty);  

                CrawInfoCls CrawInfo = new CrawInfoCls();
                CrawInfo.SiteItemGroup = this.SiteItemGroup;
                CrawInfo.ItemSiteCode = ItemSiteCode;
                CrawInfo.SiteCode = this.SiteCode;
                CrawInfo.ItemBrand = ItemBrand;
                CrawInfo.SitePrice = Convert.ToDouble(SitePrice);
                CrawInfo.ItemSiteName = ItemSiteName;
                CrawInfo.UrlCheck = baseUrl;

                RaiseCrawInfo(CrawInfo);
            }

            GlobalEnv.Waiting = false;
            
        }
    }
}