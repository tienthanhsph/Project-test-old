using HtmlAgilityPack;
using Jurassic.Library;
using Newtonsoft.Json.Linq;
using SH.Crawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace SH.SSM.Crawler
{
    public class CRPhankhang : BaseSite
    {
        private string fixUrl;
        private string SiteItemGroup;
        public CRPhankhang(string url, string iGroup)
        {
            this.SiteCode = EnumSiteCode.Phankhang.ToString();
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
            string baseUrl = url;
            HtmlAgilityPack.HtmlDocument document = LoadPage(baseUrl);
            if (document.DocumentNode.SelectSingleNode("//html/body/div/div/script") == null)
                return;

            var htmlScript = document.DocumentNode.SelectSingleNode("//html/body/div/div/script").InnerText.Trim();
            string jsScrip = htmlScript.Substring(htmlScript.IndexOf("products"), htmlScript.LastIndexOf("]") + 1 - htmlScript.IndexOf("products"));
            string[] arrJson = jsScrip.Split('}');
            foreach (var iStr in arrJson)
            {
                if (GlobalEnv.StopRuning)
                    break;
                string iCheck = iStr.Substring(iStr.IndexOf('{') + 1, iStr.Length - iStr.IndexOf('{') - 1).Trim();
                JObject jObject = null;
                try
                {
                    jObject = JObject.Parse("{" + iCheck + "}");
                }
                catch
                {
                    continue;
                }

                string ItemSiteName = jObject["productname"].ToString();
                string SitePrice = jObject["price"].ToString();
                if (SitePrice.IndexOf("class=price>") > 0)
                {
                    SitePrice = SitePrice.Substring(SitePrice.IndexOf("class=price>") + "class=price>".Length, SitePrice.Length - SitePrice.IndexOf("class=price>") - "class=price>".Length);
                    SitePrice = SitePrice.Substring(0, SitePrice.IndexOf("</span>"));
                    SitePrice = SitePrice.Replace(",", string.Empty);
                    SitePrice = SitePrice.Replace(".", string.Empty);
                    SitePrice = SitePrice.Trim();
                }
                else
                {
                    SitePrice = "0";
                }


                string ItemBrand = jObject["brand"].ToString();
                string categorie = jObject["categorie"].ToString();
                string link = jObject["link"].ToString();
                string id = jObject["id"].ToString();
                string ItemSiteCode = "";

                if (link.ToLower().IndexOf(ItemBrand.ToLower()) > 0 && link.ToLower().IndexOf(id.ToLower()) > 0)
                {
                    ItemSiteCode = link.Substring(link.ToLower().IndexOf(ItemBrand.ToLower()) + ItemBrand.Length, link.ToLower().IndexOf(id.ToLower()) - link.ToLower().IndexOf(ItemBrand.ToLower()) - ItemBrand.Length).Replace("-", string.Empty);
                }


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