using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIAODIEN
{
    public partial class frmUC : Form
    {
        public frmUC()
        {
            InitializeComponent();
        }

        private void frmUC_Load(object sender, EventArgs e)
        {

        }
        public void LoadPanel(UserControl uc)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
