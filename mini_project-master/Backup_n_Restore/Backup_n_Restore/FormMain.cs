using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_n_Restore
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void ShowControl(Control UC)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(UC);
            UC.BringToFront();
            UC.Dock = DockStyle.Fill;
        }

        CtrlSearch Search = new CtrlSearch();
        CtrlContent Content = new CtrlContent();
        CtrlAccept Accept = new CtrlAccept();
        CtrlChange Change = new CtrlChange();
        CtrlHistory History = new CtrlHistory();
        frmGiaDinh GiaDinh = new frmGiaDinh();

        private void FormMain_Load(object sender, EventArgs e)
        {
                          
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ShowControl(Search);
            Search.Reload();
        }

        private void btnKeKhai_Click(object sender, EventArgs e)
        {
            ShowControl(Content);
            Search.Reload();
        }

        private void btnCapGCN_Click(object sender, EventArgs e)
        {
            ShowControl(Accept);
            Search.Reload();
        }

        private void btnBienDong_Click(object sender, EventArgs e)
        {
            ShowControl(Change);
            Search.Reload();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            ShowControl(History);
            Search.Reload();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            GiaDinh.ShowDialog();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            GiaDinh.ShowDialog();
        }
    }
}
