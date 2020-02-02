using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDatNongNghiep
{
    public partial class frmQuanLyHoSo : Form
    {
        public frmQuanLyHoSo()
        {
            InitializeComponent();
        }

        string DVHC = "";
        string NgayCapGCN = "";
        string LoaiThoiHan = "";
        string TrangThaiHS = "";
        string qrDVHC = "";
        string qrNgayCapGCN = "";
        string qrLoaiThoiHan = "";
        string qrTrangThaiHS = "";
        

        string query = "";
        private void FillData()
        {


        }

        private void frmQuanLyHoSo_Load(object sender, EventArgs e)
        {
            reLoad();
        }
        private void reLoad()
        {
            chkNgayCap.Checked = false;
            grpNgayCap.Enabled = false;
            LoadDVHC();
            LoadTrangThaiHS();
            LoadLoaiThoiHan();

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
                        cmbDVHC.Items.Add(ds.Tables[0].Rows[i]["Ten"].ToString().Trim());
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
                DVHC = ds.Tables[0].Rows[0]["MaDonViHanhChinh"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadLoaiThoiHan()
        {
            try
            {
                ds.Tables.Clear();
                string qr = " select distinct LoaiThoiHan from tblThuaDatCapGCNDatNN ";
                ds = cls.ExecuteQuery(qr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        cmbDVHC.Items.Add(ds.Tables[0].Rows[i]["LoaiThoiHan"].ToString().Trim());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTrangThaiHS()
        {
            cmbTrangThaiHS.Items.Clear();
            cmbTrangThaiHS.Items.Add("");
            cmbTrangThaiHS.Items.Add("Hồ sơ kê khai");
            cmbTrangThaiHS.Items.Add("Hồ sơ xét duyệt");
            cmbTrangThaiHS.Items.Add("Hồ sơ thẩm định");
            cmbTrangThaiHS.Items.Add("Hồ sơ đã cấp GCN");
            cmbTrangThaiHS.Items.Add("Trường hợp khác");
            
        }
        private void chkNgayCap_CheckedChanged(object sender, EventArgs e)
        {
            if(chkNgayCap.Checked == true)
            {
                //dateTimePicker1.Enabled = dateTimePicker2.Enabled = label5.Enabled = false;
                grpNgayCap.Enabled = true;
            }
            else
            {

                //dateTimePicker1.Enabled = dateTimePicker2.Enabled = label5.Enabled = true;
                grpNgayCap.Enabled = false;
            }
        }

        private void cmbDVHC_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimMaDonViHanhChinh(cmbDVHC.Text.Trim());
            qrDVHC = " and HS.MaDonViHanhChinh = '" + DVHC + "' ";

            FillData();
        }
        private void UpdateQuery()
        { 
        query= " select * "+
                " from tblHoSoCapGCNDatNN as hs   "+
                " full outer join tblHoGiaDinh as gd on gd.MaHoSoCapGCNDatNN = hs.MaHoSoCapGCNDatNN "+
                " where 1=1 "+
                " and hs.MaHoSoCapGCNDatNN in(select MaHoSoCapGCNDatNN from tblThuaDatCapGCNDatNN where 1=1 @) "+
                " and ";
        }
    }
}
