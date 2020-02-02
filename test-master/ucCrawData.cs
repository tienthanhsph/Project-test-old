using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SH.Crawler.Model;
using System.IO;

namespace SH.Crawler
{
    public partial class ucCrawData : UserControl//BaseUserControl
    {
        public ucCrawData()
        {
            InitializeComponent();
            this.Load += ucCrawData_Load;
            btnOK.Click += btnOK_Click;
            btnExport.Click += btnExport_Click;
            btnExport.Enabled = false;
        }

        void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "BaseData.xlsx");
                gridData.MainView.ExportToXlsx(filePath);
                FileInfo fi = new FileInfo(filePath);
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string SiteCode = cboWebpage.SelectedValue != null ? cboWebpage.SelectedValue.ToString() : string.Empty;
                dbModelDataContext db = new dbModelDataContext();
                var gData = (from d in db.CRItemPrices
                             where d.SiteCode == SiteCode || SiteCode == string.Empty
                             select d).ToList();
                btnExport.Enabled = gData.Count > 0;

                gridData.DataSource = gData;
                gridData.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ucCrawData_Load(object sender, EventArgs e)
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
    }
}
