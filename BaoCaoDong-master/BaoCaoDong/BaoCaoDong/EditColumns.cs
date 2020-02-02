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
    public partial class EditColumns : Form
    {
        public EditColumns()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        string query = "";
        DataSet ds = new DataSet();

        private void LoadGridView(string _query)
        {                
            ds.Tables.Clear();
            ds = cls._Execute(_query);           
            dataGridView1.DataSource = ds.Tables[0];
            FormatGridView();

        }
        private void FormatGridView()
        {
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 195;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Width = 40;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên bảng";
            dataGridView1.Columns[2].HeaderText = "Tên cột";
            dataGridView1.Columns[3].HeaderText = "Tên cột hiển thị";
            dataGridView1.Columns[4].HeaderText = "Độ rộng cột";
            dataGridView1.Columns[5].HeaderText = "Mã kiểu tìm kiếm";
            dataGridView1.Columns[6].HeaderText = "Ẩn/ Hiện";

            dataGridView1.Columns[0].ReadOnly=true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
        }
        private void EditColumns_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "tblColumns";
            query = " select ID,TenBang,TenCot,TenCotHienThi,DoRong,MaKieuTimKiem,TrangThai from  " + comboBox1.Text.Trim();
            LoadGridView(query);


            comboBox1.Items.Add("tblColumns");
            comboBox1.Items.Add("tblColumnsBienDong");
            comboBox1.Items.Add("");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   string _query="";
            query = "";
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                _query = " update " + comboBox1.Text.Trim() + " set TenCotHienThi =N'" + dataGridView1.Rows[i].Cells[3].Value.ToString().Trim() + "', DoRong ='" + dataGridView1.Rows[i].Cells[4].Value.ToString().Trim() + "', MaKieuTimKiem ='" + dataGridView1.Rows[i].Cells[5].Value.ToString().Trim() + "',TrangThai ='" + dataGridView1.Rows[i].Cells[6].Value.ToString().Trim() + "'  where ID =" + Convert.ToInt32( dataGridView1.Rows[i].Cells[0].Value);
                query += _query + "\n";
            }
            cls._ExecuteNonQuery(query);
            query = " select ID,TenBang,TenCot,TenCotHienThi,DoRong,MaKieuTimKiem,TrangThai from  " + comboBox1.Text.Trim();
            LoadGridView(query);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() != "")
            {
                query = " select ID,TenBang,TenCot,TenCotHienThi,DoRong,MaKieuTimKiem,TrangThai from  " + comboBox1.Text.Trim();
                LoadGridView(query);
            }
            
        }
    }
}
