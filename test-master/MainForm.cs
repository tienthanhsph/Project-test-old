using SH.Crawler.Model;
using SH.SSM.Crawler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SH.Crawler
{
    public partial class MainForm : Form
    {     
        public MainForm()
        {
            InitializeComponent();
            tsMenuItemCraw.Click += tsMenuItemCraw_Click;
            tsMenuItemBaseData.Click += tsMenuItemBaseData_Click;
        }

        void tsMenuItemBaseData_Click(object sender, EventArgs e)
        {
            ucCrawData uc = new ucCrawData();
            LoadUserControl(uc);
        }

        void tsMenuItemCraw_Click(object sender, EventArgs e)
        {
            using (frmCrawler frm = new frmCrawler())
            {
                frm.ShowDialog(this);
            }
        }

        public void LoadUserControl(UserControl uc)
        {
            MainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(uc);
        }
            
    }
}
