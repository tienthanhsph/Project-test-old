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
    public partial class testDatetimePicker2SQL : Form
    {
        public testDatetimePicker2SQL()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        private void testDatetimePicker2SQL_Load(object sender, EventArgs e)
        {
            LoadDatagridview();
        }
        private void LoadDatagridview()
        {
            dataGridView1.DataSource = cls.ExecuteQuery("select * from testDatetimePicker2SQL order by ID desc").Tables[0];
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].Width = 50;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["SoNam"].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells["TuNgay"].Value.ToString().Trim() != "")
                    dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["TuNgay"].Value);
                else
                    dateTimePicker1.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TuNgay="";
            if (dateTimePicker1.Checked == true)
            {
                TuNgay = dateTimePicker1.Value.ToString();
            }

            if (cls.ExecuteSP("spTestDatetimePicker2SQL", new string[] { "@TuNgay", "@SoNam" }, new string[] { TuNgay, textBox1.Text.Trim() }) <= 0)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                LoadDatagridview();
            }
        }
    }
}
