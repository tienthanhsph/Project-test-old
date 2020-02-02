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
    public partial class CbBoxItems : Form
    {
        public CbBoxItems()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        string query = "";
        DataSet ds1 = new DataSet();

        private void CbBoxItems_Load(object sender, EventArgs e)
        {   
            try
            {
                LoadDataGridView("");

                LoadComboBox();
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadDataGridView(string dk)
        {
            ds1.Tables.Clear();
            query = " select * from tblColumnsComboBox where 1=1 " + dk;
            ds1 = cls._ExecuteQuery(query);
            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView1.Refresh();
        }
        void LoadComboBox()
        {
            comboBox1.Items.Clear();
            query = " select distinct Col from tblColumnsComboBox group by Col ";
            string[] _resl = cls._ExecuteReader(query, "Col");
            foreach (string resl in _resl)
            {
                
                comboBox1.Items.Add(resl);
            }
        }
        void FormatDataGridView()
        {
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = comboBox1.Text;
            query = " select * from tblColumnsComboBox where Col = '" + result + "'";
            string[] _result1 = cls._ExecuteReader(query, "Items");
            string _result2 = "";
            foreach (string str in _result1)
            {
                _result2 += str + "\n";

            }
            richTextBox1.Text = _result2;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = " delete from tblColumnsComboBox where Col = '" + comboBox1.Text.Trim() + "'";
            cls._ExecuteNonQuery(query);
            string[] items = richTextBox1.Text.Trim().Split('\n');
            query = "";
            foreach (string item in items)
            {
                query += " insert into  tblColumnsComboBox(Col,Items) values (N'" + comboBox1.Text.Trim() + "',N'" + item + "') ";

            }
            cls._ExecuteNonQuery(query);
            LoadDataGridView(" ");

            LoadComboBox();
            FormatDataGridView();
        }

        private void bntKhoiTao_Click(object sender, EventArgs e)
        {
            try
            {
                string query0 = " delete from tblColumnsComboBox ";
                cls._ExecuteNonQuery(query0);

                string query1 ="	 create table #tmpColumnsComboBox (Col nvarchar(50)) " +
                               "     insert into #tmpColumnsComboBox (Col) " +
                               "             select TenCot from tblColumns where MaKieuTimKiem = '3' " +
                               " select Col from #tmpColumnsComboBox";
                string[] Columns = cls._ExecuteReader(query1, "Col");
                foreach (string Column in Columns)
                {
                    if (Column.Trim() != "")
                    {
                        string query2 = " insert into tblColumnsComboBox(Col,Items) select distinct '" + Column + "', " + Column + " from  tblTongHopThongTin";
                        cls._ExecuteNonQuery(query2);
                    }
                   
                }

                string query3 ="	create table #tmpColumnsComboBox (Col nvarchar(50)) " +
                               "    insert into #tmpColumnsComboBox (Col) " +
                               "            select TenCot from tblColumnsBienDong  " +
                               "               where MaKieuTimKiem = '3' and TenCot not in (select TenCot from tblColumns where MaKieuTimKiem = '3') " +
                               " select Col from #tmpColumnsComboBox";
                string[] Columns2 = cls._ExecuteReader(query3, "Col");
                for(int i=0;i<Columns2.Length;i++)
                {
                    if (Columns.Contains(Columns2[i]))
                    {
                        Columns2[i] = "";
                    }
                    if (Columns2[i].Trim() != "")
                    {
                        string query4 = " insert into tblColumnsComboBox(Col,Items) select distinct '" + Columns2[i] + "', " + Columns2[i] + " from  tblTongHopThongTinBienDong";
                        cls._ExecuteNonQuery(query4);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
