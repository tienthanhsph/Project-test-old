using SH.Crawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SH.SSM.Crawler
{
    public class CRMediamart : BaseSite
    {
        private string fixUrl;
        private string SiteItemGroup;
        public CRMediamart(string url, string iGroup)
        {
            this.SiteCode = EnumSiteCode.Mediamart.ToString();
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
            if (url.LastIndexOf("/") < url.Length - 2)
                baseUrl = url + string.Format("/?trang={0}", CurrentPage.ToString());
            else
                baseUrl = url + string.Format("?trang={0}", CurrentPage.ToString());

            HtmlAgilityPack.HtmlDocument document = LoadPage(baseUrl);
            var listNodes = document.DocumentNode.SelectNodes("//div[@class='pca-pl-l']");
            string fisrtItemCode = string.Empty;
            bool breakLoop = false;
            while (listNodes != null && breakLoop == false)
            {
                CurrentPage += 1;
                if (url.LastIndexOf('/') >= url.Length - 1)
                {
                    baseUrl = url + string.Format("?trang={0}", CurrentPage.ToString());
                }
                else
                {
                    baseUrl = url + string.Format("/?trang={0}", CurrentPage.ToString());
                }


                RaiseLog("Bắt đầu quét trang: " + baseUrl);

                var itemNodes = document.DocumentNode.SelectNodes("//div[@class='pca-pl-l']/ul[@class='pl-item-ul']/li");
                if (itemNodes == null) break;
                foreach (var iNode in itemNodes)
                {
                    if (GlobalEnv.StopRuning)
                        break;

                    string ItemSiteName = iNode.SelectSingleNode("div/p[@class='pl-item-name']") != null ? iNode.SelectSingleNode("div/p[@class='pl-item-name']").InnerText.Trim() : string.Empty;
                    string ItemBrand = iNode.SelectSingleNode("div/p[@class='pl-item-brand']").FirstChild != null ? iNode.SelectSingleNode("div/p[@class='pl-item-brand']").FirstChild.InnerText.Trim() : string.Empty;
                    string ItemSiteCode = ItemSiteName.Substring(ItemSiteName.ToLower().LastIndexOf(ItemBrand.ToLower()) + ItemBrand.Length, ItemSiteName.Length - ItemSiteName.ToLower().LastIndexOf(ItemBrand.ToLower()) - ItemBrand.Length).Trim();

                    string iProductPricehtml = iNode.SelectSingleNode("div/div[@class='pl-item-price']/div[@class='pl-item-pbuy']/div[@class='draw-price']/div[@class='draw-price-content']") != null ? iNode.SelectSingleNode("div/div[@class='pl-item-price']/div[@class='pl-item-pbuy']/div[@class='draw-price']/div[@class='draw-price-content']").InnerHtml : string.Empty;
                    string[] arrItemPrice = Regex.Split(iProductPricehtml, "</span>");
                    string[] realPrice = arrItemPrice.Where(a => a.Contains("drw-pri-thumb-view")).ToArray<string>();
                    string SitePrice = "";
                    string getPrice = "drw-pri-thumb-view-";
                    foreach (string iPrice in realPrice)
                    {
                        if (iPrice.IndexOf("drw-pri-thumb-stt-0") > 0)
                            SitePrice += !string.IsNullOrEmpty(iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1)) ? iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1) : string.Empty;

                        if (iPrice.IndexOf("drw-pri-thumb-stt-1") > 0)
                            SitePrice += !string.IsNullOrEmpty(iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1)) ? iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1) : string.Empty;


                        if (iPrice.IndexOf("drw-pri-thumb-stt-2") > 0)
                            SitePrice += !string.IsNullOrEmpty(iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1)) ? iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1) : string.Empty;


                        if (iPrice.IndexOf("drw-pri-thumb-stt-3") > 0)
                            SitePrice += !string.IsNullOrEmpty(iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1)) ? iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1) : string.Empty;


                        if (iPrice.IndexOf("drw-pri-thumb-stt-4") > 0)
                            SitePrice += !string.IsNullOrEmpty(iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1)) ? iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1) : string.Empty;


                        if (iPrice.IndexOf("drw-pri-thumb-stt-5") > 0)
                            SitePrice += !string.IsNullOrEmpty(iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1)) ? iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1) : string.Empty;


                        if (iPrice.IndexOf("drw-pri-thumb-stt-6") > 0)
                            SitePrice += !string.IsNullOrEmpty(iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1)) ? iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1) : string.Empty;


                        if (iPrice.IndexOf("drw-pri-thumb-stt-7") > 0)
                            SitePrice += !string.IsNullOrEmpty(iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1)) ? iPrice.Substring(iPrice.IndexOf(getPrice) + getPrice.Length, 1) : string.Empty;

                    }

                    if (string.IsNullOrEmpty(SitePrice))
                        continue;

                    if (!string.IsNullOrEmpty(ItemSiteCode) && ItemSiteCode == fisrtItemCode)
                    {
                        breakLoop = true;
                        break;
                    }

                    CrawInfoCls CrawInfo = new CrawInfoCls();
                    CrawInfo.ItemSiteCode = ItemSiteCode;
                    CrawInfo.SiteCode = this.SiteCode;
                    CrawInfo.ItemBrand = ItemBrand;
                    CrawInfo.SitePrice = Convert.ToDouble(SitePrice) * 1000;
                    CrawInfo.ItemSiteName = ItemSiteName;
                    CrawInfo.SiteItemGroup = this.SiteItemGroup;
                    CrawInfo.UrlCheck = baseUrl;

                    //Gán mã số 1 để check
                    if (string.IsNullOrEmpty(fisrtItemCode))
                        fisrtItemCode = ItemSiteCode;

                    RaiseCrawInfo(CrawInfo);


                }


                //Xử lý chốt 
                document = LoadPage(baseUrl);
                listNodes = document.DocumentNode.SelectNodes("//div[@class='pca-pl-l']");
            }
            GlobalEnv.Waiting = false;
        }
    }
}