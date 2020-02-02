using SH.Crawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SH.SSM.Crawler
{
    public class CRHC : BaseSite
    {
        private string fixUrl;
        private string SiteItemGroup;
        public CRHC(string url, string iGroup)
        {
            this.SiteCode = EnumSiteCode.HC.ToString();
            SiteItemGroup = iGroup;

            if (!string.IsNullOrEmpty(url))
                fixUrl = url;
        }

        public override void CrawlerSite()
        {
            //fixUrl = "http://hc.com.vn/gia-dung/cac-loai-quat/quat-dieu-hoa";
            LoadCrawSite(fixUrl);
        }

        public void LoadCrawSite(string url)
        {
            string baseUrl = string.Empty;
            int CurrentPage = 1;

            baseUrl = url + string.Format("?p={0}", CurrentPage.ToString());

            HtmlAgilityPack.HtmlDocument document = LoadPage(baseUrl);
            var listNodes = document.DocumentNode.SelectNodes("//div[@class='category-products']/ol[@class='products-list']");
            if (document.DocumentNode.SelectNodes("//div[@class='category-products']/div[@class='toolbar']/div[@class='pager']/div[@class='pages']/ol/li") == null)
                return;

            var listPages = document.DocumentNode.SelectNodes("//div[@class='category-products']/div[@class='toolbar']/div[@class='pager']/div[@class='pages']/ol/li").Count;
            int MaxPage = 0;
            for (int iIndex = 0; iIndex < listPages; iIndex++)
            {
                if (document.DocumentNode.SelectNodes("//div[@class='category-products']/div[@class='toolbar']/div[@class='pager']/div[@class='pages']/ol/li")[iIndex] != null)
                {
                    int checkPage = 0;
                    int.TryParse(document.DocumentNode.SelectNodes("//div[@class='category-products']/div[@class='toolbar']/div[@class='pager']/div[@class='pages']/ol/li")[iIndex].InnerText, out checkPage);
                    if (checkPage > MaxPage)
                        MaxPage = checkPage;
                }
            }


            string fisrtItemCode = string.Empty;
            bool breakLoop = false;
            while (CurrentPage < MaxPage + 2)
            {
                RaiseLog("Bắt đầu quét trang: " + baseUrl);
                CurrentPage += 1;
                baseUrl = url + string.Format("?p={0}", CurrentPage.ToString());


                var itemNodes = document.DocumentNode.SelectNodes("//div[@class='category-products']/ol[@class='products-list']/li[@class='item']");
                if (itemNodes != null)
                {
                    foreach (var iNode in itemNodes)
                    {
                        if (GlobalEnv.StopRuning)
                            break;

                        string ItemSiteName = iNode.SelectSingleNode("div[@class='product-shop']/div/div/h2[@class='product-name']") != null ? iNode.SelectSingleNode("div[@class='product-shop']/div/div/h2[@class='product-name']").InnerText.Trim() : string.Empty;
                        string ItemBrand = ItemSiteName.Split(' ').Count<string>() > 1 ? ItemSiteName.Split(' ')[ItemSiteName.Split(' ').Count<string>() - 2] : string.Empty;
                        string ItemSiteCode = ItemSiteName.ToLower().LastIndexOf(ItemBrand.ToLower()) > 0 ? ItemSiteName.Substring(ItemSiteName.ToLower().LastIndexOf(ItemBrand.ToLower()), ItemSiteName.Length - ItemSiteName.ToLower().LastIndexOf(ItemBrand.ToLower())).Trim() : ItemSiteName.Substring(ItemSiteName.LastIndexOf(" "), ItemSiteName.Length - ItemSiteName.LastIndexOf(" "));
                        string SitePrice = iNode.SelectSingleNode("div[@class='product-shop']/div/div/div[@class='price-box']/p[@class='special-price']/span[@class='price']") != null ? iNode.SelectSingleNode("div[@class='product-shop']/div/div/div[@class='price-box']/p[@class='special-price']/span[@class='price']").InnerText.Trim() : string.Empty;
                        if (string.IsNullOrEmpty(SitePrice))
                            SitePrice = iNode.SelectSingleNode("div[@class='product-shop']/div/div/div[@class='price-box']/span[@class='regular-price']/span[@class='price']") != null ? iNode.SelectSingleNode("div[@class='product-shop']/div/div/div[@class='price-box']/span[@class='regular-price']/span[@class='price']").InnerText.Trim() : string.Empty;


                        SitePrice = SitePrice.Replace("₫", string.Empty);
                        SitePrice = SitePrice.Replace(".", string.Empty);
                        SitePrice = SitePrice.Trim();

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
                }

                //Xử lý chốt 
                document = LoadPage(baseUrl);
                listNodes = document.DocumentNode.SelectNodes("//div[@class='category-products']/ol[@class='products-list']");
                if (listNodes == null) continue;

                for (int iIndex = 0; iIndex < listPages; iIndex++)
                {
                    if (document.DocumentNode.SelectNodes("//div[@class='category-products']/div[@class='toolbar']/div[@class='pager']/div[@class='pages']/ol/li") == null)
                        break;

                    if (document.DocumentNode.SelectNodes("//div[@class='category-products']/div[@class='toolbar']/div[@class='pager']/div[@class='pages']/ol/li")[iIndex] != null)
                    {
                        int checkPage = 0;
                        int.TryParse(document.DocumentNode.SelectNodes("//div[@class='category-products']/div[@class='toolbar']/div[@class='pager']/div[@class='pages']/ol/li")[iIndex].InnerText, out checkPage);
                        if (checkPage > MaxPage)
                            MaxPage = checkPage;
                    }
                }
            }

            GlobalEnv.Waiting = false;
        }

    }
}