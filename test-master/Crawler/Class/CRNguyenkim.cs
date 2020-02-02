using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SH.SSM.Crawler
{
    public class CRNguyenkim : BaseSite
    {
        private string fixUrl;
        private string SiteItemGroup;
        public CRNguyenkim(string url, string iGroup)
        {
            this.SiteCode = EnumSiteCode.Nguyenkim.ToString();
            SiteItemGroup = iGroup;

            if (!string.IsNullOrEmpty(url))
                fixUrl = url;
        }

        public override void CrawlerSite()
        {       
            LoadCrawSite(fixUrl);
        }

        public void LoadCrawSite(string url)
        {
            HtmlAgilityPack.HtmlDocument document = LoadPage(url);
            var listNodes = document.DocumentNode.SelectNodes("//div[@class='grid-list']/div[@class='ty-column4']");
            foreach (var ulItem in listNodes)
            {
                //string[] ItemName = ulItem.SelectSingleNode(ulItem.XPath + "//div[@class='properties-update']").InnerText.Split("\r\n");
            }
        }

    }


}