using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjDatNongNghiep
{
    public partial class frmXacNhanQuyenQuanLy : Form
    {
        public frmXacNhanQuyenQuanLy()
        {
            InitializeComponent();
        }
        public int Quyen { get; set; }
        

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPassword.Text.Trim() == "1")
                {
                    Quyen = 1;
                    this.Close();
                }

                else
                    if (txtPassword.Text.Trim() == "10")
                    {
                        Quyen = 10;
                        this.Close();
                    }
            }
        }
    }
}
