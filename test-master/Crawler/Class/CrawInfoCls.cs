using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SH.SSM.Crawler
{
    public enum EnumSiteCode
    {
        Nguyenkim,
        Dienmayxanh,
        HC,
        Trananh,
        Mediamart,
        Pico,
        Phankhang
    }
    public class CrawInfoCls
    {
        private string _SiteCode;

        public string SiteCode
        {
            get { return _SiteCode; }
            set { _SiteCode = value; }
        }


        private string _ItemCode;

        public string ItemCode
        {
            get { return _ItemCode; }
            set { _ItemCode = value; }
        }

        private string _ItemSiteName;

        public string ItemSiteName
        {
            get { return _ItemSiteName; }
            set { _ItemSiteName = value; }
        }
        

        private string _ItemSiteCode;

        public string ItemSiteCode
        {
            get { return _ItemSiteCode; }
            set { _ItemSiteCode = value; }
        }

        private string _ItemBrand;

        public string ItemBrand
        {
            get { return _ItemBrand; }
            set { _ItemBrand = value; }
        }
        

        private string _Desciption;

        public string Description
        {
            get { return _Desciption; }
            set { _Desciption = value; }
        }

        private string _Promotion;

        public string Promotion
        {
            get { return _Promotion; }
            set { _Promotion = value; }
        }

        private double _SitePrice;

        public double SitePrice
        {
            get { return _SitePrice; }
            set { _SitePrice = value; }
        }

        private string _UrlCheck;

        public string UrlCheck
        {
            get { return _UrlCheck; }
            set { _UrlCheck = value; }
        }

        private string _SiteItemGroup;

        public string SiteItemGroup
        {
            get { return _SiteItemGroup; }
            set { _SiteItemGroup = value; }
        }
        
        
    }
}