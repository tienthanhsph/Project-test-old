using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaoCaoDong
{
    public partial class GanKieu : Form
    {
        public GanKieu()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        DataSet ds = new DataSet();
        string query = "";
        private void GanKieu_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadColumns();
            LoadKieuTimKiem();
        }
        private void LoadGrid()
        {
            query = "select A.TenCot,A.TenCotHienThi,B.TenKieu from tblColumns as A inner join tblGanKieu as B on A.MaKieuTimKiem = B.Kieu ";
            ds = cls._ExecuteQuery(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Width = 200 ;
            dataGridView1.Columns[1].Width = 220 ;
            dataGridView1.Columns[2].Width = 170 ;
        }
        private void LoadColumns()
        {
            query = "select TenCotHienThi from tblColumns";
            string[] items = cls._ExecuteReader(query, "TenCotHienThi");
            foreach (string item in items)
            {
                cmbColumns.Items.Add(item);
            }
        }
        private void LoadKieuTimKiem()
        {
            query = "select TenKieu from tblGanKieu";
            string[] items = cls._ExecuteReader(query, "TenKieu");
            foreach (string item in items)
            {
               cmbKieuTimKiem.Items.Add(item);
            } 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query = " update tblColumns set MaKieuTimKiem = ( select Kieu from tblGanKieu where TenKieu = N'"+cmbKieuTimKiem.Text.Trim()+"') where TenCotHienThi = N'"+cmbColumns.Text.Trim()+"' ";
            cls._ExecuteNonQuery(query);
            LoadGrid();
        }

        private void cmbColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select B.TenKieu from tblColumns as A inner join tblGanKieu as B on A.MaKieuTimKiem = B.Kieu  where A.TenCotHienThi = N'" + cmbColumns.Text.Trim() + "'";
            string[] items = cls._ExecuteReader(query, "TenKieu");
            cmbKieuTimKiem.Text = items[0];
        }
    }
}
