using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SH.SSM.Crawler
{
    public interface ICrawler
    {
       void CrawlerSite();
    }
    public class BaseSite 
    {
        public delegate void WebpagRunHandler(string PageId, int CurrentPage);
        public event WebpagRunHandler WebpagRunEvent;

        public delegate void LogHandler(string logMessenger);
        public event LogHandler LogEvent;

        public delegate void CrawInfoHandler(CrawInfoCls CrawInfo);
        public event CrawInfoHandler CrawInfoEvent;

        public string SiteCode;
        public string SiteUrlCraw;
        public CrawInfoCls CrawInfo;

        public void RaiseUpdatePageRun(string PageId, int CurrentPage)
        {
            if (WebpagRunEvent != null)
                WebpagRunEvent(PageId, CurrentPage);
        }


        public void RaiseLog(string logMessenger)
        {
            if (LogEvent != null)
                LogEvent(logMessenger);
        }

       
        public void RaiseCrawInfo(CrawInfoCls CrawInfo)
        {
            if (CrawInfoEvent != null)
                CrawInfoEvent(CrawInfo);
        }

        public virtual void CrawlerSite()
        {
            
        }

        public HtmlDocument LoadPage(string url)
        {
            bool allowLoop = true;
            HtmlDocument oHtmlDocument = new HtmlDocument();
            while (allowLoop)
            {
                try
                {
                    HtmlWeb oHtmlWeb = new HtmlWeb() { AutoDetectEncoding = true, OverrideEncoding = Encoding.UTF8 };
                    allowLoop = false;
                    oHtmlDocument = oHtmlWeb.Load(url);
                }
                catch (Exception ex)
                {
                    allowLoop = ex.Message.Contains("The connection was closed");
                    RaiseLog(ex.Message);
                }
            }
            return oHtmlDocument;

        }
    }
}