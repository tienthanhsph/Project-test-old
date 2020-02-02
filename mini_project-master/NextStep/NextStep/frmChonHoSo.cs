using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextStep
{
    public partial class frmChonHoSo : Form
    {
        public frmChonHoSo()
        {
            InitializeComponent();
        }
        public int MaHoSo { get; set; }
        public int TrangThai { get; set; }
        private void frmChonHoSo_Load(object sender, EventArgs e)
        {
            txtMaHoSo.Text = "10";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                MaHoSo = Convert.ToInt32(txtMaHoSo.Text.Trim());
                TrangThai = Convert.ToInt32(txtTrangThai.Text.Trim());
                this.Close();
            }
            catch(Exception)
            {}
            
        }
    }
}
