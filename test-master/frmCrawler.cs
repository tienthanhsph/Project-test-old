using SH.Crawler.Model;
using SH.SSM.Crawler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SH.Crawler
{
    public partial class frmCrawler : Form
    {
        public static ListBoxLog listBoxSite;
        public static ListBoxLog listBoxPage;
        private BackgroundWorker bw;
        private string CurrentSiteCode;

        public frmCrawler()
        {
            InitializeComponent();
            listBoxSite = new ListBoxLog(listBoxLogPage);
            listBoxPage = new ListBoxLog(lbLog);
            this.Load += frmCrawler_Load;

            bw = new BackgroundWorker();
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += bw_DoWork;
            bw.ProgressChanged += bw_ProgressChanged;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            GlobalEnv.Waiting = true;
            GlobalEnv.StopRuning = false;
            btnOK.Click += btnOK_Click;
            btnStop.Click += btnStop_Click;
        }

        void frmCrawler_Load(object sender, EventArgs e)
        {
            dbModelDataContext db = new dbModelDataContext();
            var dtSites = (from s in db.CRSites
                           where s.Active == true
                           select s).ToList();

            cboWebpage.Enabled = true;
            cboWebpage.DataSource = dtSites;
            cboWebpage.DisplayMember = "SiteUrl";
            cboWebpage.ValueMember = "SiteCode";
            cboWebpage.Show();
        }


        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            dbModelDataContext db = new dbModelDataContext();
            var listSites = db.Proc_CRLoadUrlCraw(CurrentSiteCode).ToList();
            foreach (var ilink in listSites)
            {
                if (GlobalEnv.StopRuning)
                    break;

                listBoxSite.Log(Level.Info, string.Format("Load trang: {0}", ilink.PageUrl));
                CrawMain crMain = new CrawMain(ilink.SiteCode, ilink.PageUrl, ilink.SiteItemGroup);
                crMain.LogEvent += crMain_LogEvent;
                crMain.Craw();

            }
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listBoxSite.Log(Level.Error, "Hoàn thành!");
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!bw.IsBusy)
            {

                GlobalEnv.StopRuning = false;
                CurrentSiteCode = cboWebpage.SelectedValue != null ? cboWebpage.SelectedValue.ToString() : String.Empty;
                bw.RunWorkerAsync();
            }
            else
            {
                listBoxPage.Log(Level.Error, "Hệ thống đang bận xử lý thao tác trước, thực hiện tác vụ lại sau giây lát...!");
            }


        }

        void crMain_LogEvent(string logMessenger)
        {
            listBoxPage.Log(logMessenger);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            GlobalEnv.StopRuning = true;
        }




    }
}
