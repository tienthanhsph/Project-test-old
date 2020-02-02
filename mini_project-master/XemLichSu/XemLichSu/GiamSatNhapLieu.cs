using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XemLichSu
{
    public partial class GiamSatNhapLieu : Form
    {
        public GiamSatNhapLieu()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        private void GiamSatNhapLieu_Load(object sender, EventArgs e)
        {
            LoadDatagridview();
        }
        private string DieuKienLoc = "";
        string DKThoiDiem = "";
        string DKUsername = "";
        string DKMaHoSo = "";
        string DKThaoTac = "";
        string DKDanhMuc = "";
        string DKNoiDung = "";
        
        private void StyleDatagridview()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].Name == "ThoiDiem")
                {
                    dataGridView1.Columns[i].HeaderText = "Thời điểm";
                    dataGridView1.Columns[i].Width = 110;
                }
                else if (dataGridView1.Columns[i].Name == "Username")
                {
                    dataGridView1.Columns[i].HeaderText = "Username";
                    dataGridView1.Columns[i].Width = 110;
                }
                else if (dataGridView1.Columns[i].Name == "MaHoSo")
                {
                    dataGridView1.Columns[i].HeaderText = "Hồ sơ";
                    dataGridView1.Columns[i].Width = 110;
                }
                else if (dataGridView1.Columns[i].Name == "ThaoTac")
                {
                    dataGridView1.Columns[i].HeaderText = "Thao tác";
                    dataGridView1.Columns[i].Width = 110;
                }
                else if (dataGridView1.Columns[i].Name == "DanhMuc")
                {
                    dataGridView1.Columns[i].HeaderText = "Danh mục";
                    dataGridView1.Columns[i].Width = 110;
                }
                else if (dataGridView1.Columns[i].Name == "NoiDung")
                {
                    dataGridView1.Columns[i].HeaderText = "Nội dung";
                    dataGridView1.Columns[i].Width = 210;
                }
            }
        }
        private void LoadDatagridview()
        {
            DieuKienLoc = DKUsername + DKThoiDiem + DKMaHoSo + DKThaoTac + DKDanhMuc + DKNoiDung;
            string query = "SELECT " +
                             "[ThoiDiem] " +
                             ",[Username] " +
                             ",[MaHoSo] " +
                             ",[ThaoTac] " +
                             ",[DanhMuc] " +
                             ",[NoiDung] " +
                             "FROM [dbo].[tblGiamSatNhapLieu] where 1=1 "+DieuKienLoc;
            dataGridView1.DataSource = cls.ExecuteQuery(query).Tables[0];
            StyleDatagridview();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
                DKUsername = "";
            else
                DKUsername = " and Username LIKE N'%" + txtUsername.Text.Trim() + "%' ";

            LoadDatagridview();
        }

        private void txtMaHoSo_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHoSo.Text.Trim() == "")
                DKMaHoSo = "";
            else
                DKMaHoSo = " and MaHoSo  LIKE N'%" + txtMaHoSo.Text.Trim() + "%' ";

            LoadDatagridview();
        }

        private void txtThaoTac_TextChanged(object sender, EventArgs e)
        {
            if (txtThaoTac.Text.Trim() == "")
                DKThaoTac = "";
            else
                DKThaoTac = " and ThaoTac  LIKE N'%" + txtThaoTac.Text.Trim() + "%' ";

            LoadDatagridview();
        }

        private void txtDanhMuc_TextChanged(object sender, EventArgs e)
        {
            if (txtDanhMuc.Text.Trim() == "")
                DKDanhMuc = "";
            else
                DKDanhMuc = " and DanhMuc  LIKE N'%" + txtDanhMuc.Text.Trim() + "%' ";

            LoadDatagridview();
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            if (txtNoiDung.Text.Trim() == "")
                DKNoiDung = "";
            else
                DKNoiDung = " and NoiDung  LIKE N'%" + txtNoiDung.Text.Trim() + "%' ";

            LoadDatagridview();
        }
    }
}
