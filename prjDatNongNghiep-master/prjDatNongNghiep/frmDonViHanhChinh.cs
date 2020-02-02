using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDatNongNghiep
{
    public partial class frmDonViHanhChinh : Form
    {
        public frmDonViHanhChinh()
        {
            InitializeComponent();
        }

        clsDatabase cls = new clsDatabase();
        DataSet ds = new DataSet();
        private void LoadDVHC()
        {
            try
            {
                ds.Tables.Clear();
                string qr = " select MaDonViHanhChinh,Ten from tblTuDienDonViHanhChinh where MaHuyen <> '0' and MaXa <> '0' order by Ten asc ";
                ds = cls.ExecuteQuery(qr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        comboBox1.Items.Add(ds.Tables[0].Rows[i]["Ten"].ToString().Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TimMaDonViHanhChinh(string Ten)
        {
            try
            {
                ds.Tables.Clear();
                string qr = " select MaDonViHanhChinh from tblTuDienDonViHanhChinh where Ten = N'" + Ten + "'";
                ds = cls.ExecuteQuery(qr);
                clsConfig.MaDonVihanhChinh = ds.Tables[0].Rows[0]["MaDonViHanhChinh"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadDVHC();
            
            if (clsConfig.ConnectString.Trim() == "")
            {
                MessageBox.Show("Bạn chưa thiết lập chuỗi kết nối CSDL!");
                
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() != "")
            {
                clsConfig.TenDVHC = comboBox1.Text.Trim();
                TimMaDonViHanhChinh(comboBox1.Text.Trim());
                clsConfig.Refresh();
                frmHOSO frm = new frmHOSO();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đơn vị hành chính!");
            }
        }
        
    }
}
