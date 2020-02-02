using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DB;

namespace GIAODIEN
{
    public partial class DoanhThu : UserControl
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            FormatDataGrid();
        }
        private void LoadDataGrid()
        {
            clsDatabase cls = new clsDatabase();            
            clsDatabase cls2 = new clsDatabase();            
            LoadDataGridViewThang(dataGridView1, "SPThongKeDoanhThuTheoNgay");
            LoadDataGridView(dataGridView2, "SPThongKeDoanhThuTheoThang");
            cls2.loaddatagridview(dataGridView3, "SPThongKeDoanhThuTheoNam");
        }
        private void FormatDataGrid()
        {
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 137;
            dataGridView1.Columns[0].HeaderText = "Ngày";
            dataGridView1.Columns[1].HeaderText = "Tổng doanh thu";

            dataGridView2.Columns[0].Width = 60;
            dataGridView2.Columns[1].Width = 137;
            dataGridView2.Columns[0].HeaderText = "Tháng";
            dataGridView2.Columns[1].HeaderText = "Tổng doanh thu";

            dataGridView3.Columns[0].Width = 60;
            dataGridView3.Columns[1].Width = 137;
            dataGridView3.Columns[0].HeaderText = "Năm";
            dataGridView3.Columns[1].HeaderText = "Tổng doanh thu";

        }
        //int ngay =0;
        int thang = 0;
        int nam = 0;

        string[] Paras = new string[] {"@Nam" };
        string[] ParasThang = new string[] { "@Thang","@Nam" };
        string error = "";
        //string rcd = "";
        public string GetData(ref DataTable tbl,string SPname)
        {

            try
            {
                clsDatabase cls = new clsDatabase();
                cls.OpenConnect();
                string[] Values = new string[] {Convert.ToString(nam)};
                if (Paras.Length != Values.Length)
                    return "Tham bien va tham tri khong tuong thich";
                else
                    cls.getValue(ref tbl,SPname , Paras, Values);

                cls.CloseConnect();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                MessageBox.Show("Co loi " + ex.Message);
            }
            return error;
        }

        public string GetDataThang(ref DataTable tbl, string SPname)
        {

            try
            {
                clsDatabase cls = new clsDatabase();
                cls.OpenConnect();
                string[] Values = new string[] { Convert.ToString(thang),Convert.ToString(nam) };
                if (ParasThang.Length != Values.Length)
                    return "Tham bien va tham tri khong tuong thich";
                else
                    cls.getValue(ref tbl, SPname, ParasThang, Values);

                cls.CloseConnect();
            }
            catch (Exception ex)
            {
                error = ex.ToString();
                MessageBox.Show("Co loi " + ex.Message);
            }
            return error;
        }
        private void LoadDataGridViewThang(DataGridView dtgrv, string SPname)
        {
            DataTable tbl = new DataTable();
            GetDataThang(ref tbl, SPname);
            dtgrv.DataSource = tbl;

        }
        private void LoadDataGridView(DataGridView dtgrv, string SPname)
        {
            DataTable tbl = new DataTable();
            GetData(ref tbl, SPname);
            dtgrv.DataSource = tbl;

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nam = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            LoadDataGridView(dataGridView2, "SPThongKeDoanhThuTheoThang");
            label2.Text = "Năm : " + nam;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thang = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString().Trim());
            LoadDataGridViewThang(dataGridView1, "SPThongKeDoanhThuTheoNgay");
            label1.Text = "Tháng : " + thang;
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VIEW_REPORT rpt = new VIEW_REPORT();
            
            rpt._nam = nam;
            rpt.LoadDoanhThuTheoNam();
            rpt.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VIEW_REPORT rpt = new VIEW_REPORT();
            rpt._thang = thang;
            rpt._nam = nam;
            rpt.LoadDoanhThuTheoThang();
            rpt.Show();
        }
        
    }
}
