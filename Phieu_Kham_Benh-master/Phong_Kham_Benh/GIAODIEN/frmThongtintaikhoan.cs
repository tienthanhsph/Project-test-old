using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DB;

namespace GIAODIEN
{
    public partial class frmThongtintaikhoan : Form
    {
        public frmThongtintaikhoan()
        {
            InitializeComponent();
        }

        private void frmThongtintaikhoan_Load(object sender, EventArgs e)
        {
            string _tenquyen = "";
            if(clsThongTinChung._Quyen =="1")_tenquyen ="Admin";
            else if(clsThongTinChung._Quyen =="2")_tenquyen ="Nhân viên";
            else if(clsThongTinChung._Quyen =="3")_tenquyen ="Khách xem";
            label1.Text = "User Account:  " + clsThongTinChung._UserAccount + "\n\n\t Quyền: " + _tenquyen;
        }
    }
}
