using SH.Crawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SH.SSM.Crawler
{
    public class CRPico : BaseSite
    {
        private string fixUrl;
        private string SiteItemGroup;
        public CRPico(string url, string iGroup)
        {
            this.SiteCode = EnumSiteCode.Pico.ToString();
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
            string baseUrl = string.Empty;
            int CurrentPage = 1;
            baseUrl = url + string.Format("?&pageIndex={0}", CurrentPage.ToString());
                
            HtmlAgilityPack.HtmlDocument document = LoadPage(baseUrl);
            var listNodes = document.DocumentNode.SelectNodes("//div[@class='row category-child']/div[@class='col-md-3 col-sm-4 col-xs-6 product']");
            string fisrtItemCode = string.Empty;
            bool breakLoop = false;
            while (listNodes != null && breakLoop == false)
            {
                RaiseLog("Bắt đầu quét trang: " + baseUrl);
                CurrentPage += 1;
                baseUrl = url + string.Format("?&pageIndex={0}", CurrentPage.ToString());


                var itemNodes = document.DocumentNode.SelectNodes("//div[@class='col-md-3 col-sm-4 col-xs-6 product']/div[@class='product-info']");
                foreach (var iNode in itemNodes)
                {
                    if (GlobalEnv.StopRuning)
                        break;

                    string ItemSiteName = iNode.SelectSingleNode("h6/a") != null ? iNode.SelectSingleNode("h6/a").InnerText.Trim() : string.Empty;
                    string ItemBrand = iNode.SelectSingleNode("div/img[@alt]").Attributes["alt"].Value != null ? iNode.SelectSingleNode("div/img[@alt]").Attributes["alt"].Value.Trim() : string.Empty;
                    string ItemSiteCode = ItemSiteName.ToLower().LastIndexOf(ItemBrand.ToLower()) > 0 ? ItemSiteName.Substring(ItemSiteName.ToLower().LastIndexOf(ItemBrand.ToLower()), ItemSiteName.Length - ItemSiteName.ToLower().LastIndexOf(ItemBrand.ToLower())).Trim() : ItemSiteName.Substring(ItemSiteName.LastIndexOf(" "),ItemSiteName.Length - ItemSiteName.LastIndexOf(" "));
                    string SitePrice = iNode.SelectSingleNode("div[@class='priceInfo']/span[@class='price']") != null ? iNode.SelectSingleNode("div[@class='priceInfo']/span[@class='price']").InnerText.Trim() : string.Empty;
                    SitePrice = SitePrice.Replace("₫", string.Empty);
                    SitePrice = SitePrice.Replace(".", string.Empty);                   
                    
                    if (string.IsNullOrEmpty(SitePrice))
                        continue;

                    if (!string.IsNullOrEmpty(ItemSiteCode) && ItemSiteCode == fisrtItemCode)
                    {
                        breakLoop = true;
                        break;
                    }

                    CrawInfoCls CrawInfo = new CrawInfoCls();
                    CrawInfo.SiteItemGroup = this.SiteItemGroup;
                    CrawInfo.ItemSiteCode = ItemSiteCode;
                    CrawInfo.SiteCode = this.SiteCode;
                    CrawInfo.ItemBrand = ItemBrand;
                    CrawInfo.SitePrice = Convert.ToDouble(SitePrice);
                    CrawInfo.ItemSiteName = ItemSiteName;
                    CrawInfo.UrlCheck = baseUrl;

                    //Gán mã số 1 để check
                    if (string.IsNullOrEmpty(fisrtItemCode))
                        fisrtItemCode = ItemSiteCode;

                    RaiseCrawInfo(CrawInfo);
                }

                //Xử lý chốt 
                document = LoadPage(baseUrl);
                listNodes = document.DocumentNode.SelectNodes("//div[@class='row category-child']/div[@class='col-md-3 col-sm-4 col-xs-6 product']");
            }
            GlobalEnv.Waiting = false;
        }
    }
}