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
    public partial class Script : Form
    {
        public Script()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        public string _Name = "";
        public string _Columns = "";
        public string _DK = "";
        public string _HTDK = "";
        int _isUpdate = 0;
        int _currentID = 0;
        DataSet ds = new DataSet();
        private void LoadGridView()
        {
            string query = " select * from tblScript ";
            ds=  cls._ExecuteQuery(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Width = 30 ;
            dataGridView1.Columns[1].Width = 150 ;
            dataGridView1.Columns[2].Width = 200 ;
            dataGridView1.Columns[3].Width = 200 ;
            dataGridView1.Columns[4].Width = 200;
        }
        private void Script_Load(object sender, EventArgs e)
        {
            _isUpdate = 0;
            tbxName.Text = _Name;
            rtbColumns.Text = _Columns;
            rtbDK.Text = _DK;
            rtbDKHT.Text = _HTDK;
            LoadGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _rtbDieuKien = rtbDK.Text.Trim().Replace("'", "''");
            string _rtbDKHT = rtbDKHT.Text.Trim().Replace("'", "''");
            if (_isUpdate == 0)    // add
            {
                string query = " insert into tblScript(TenKichBan,TenCacCot,NoiDung, NoiDungHT) values (N'" + tbxName.Text.Trim() + "', N'" + rtbColumns.Text.Trim() + "',N'" + _rtbDieuKien + "',N'" + _rtbDKHT + "') ";
                cls._ExecuteNonQuery(query);
            }
            else                  //update
            {
                string query = " update tblScript set TenKichBan =N'" + tbxName.Text.Trim() + "', TenCacCot =N'" + rtbColumns.Text.Trim() + "',NoiDung = N'" + _rtbDieuKien + "',N'" + _rtbDKHT + "' where ID = " + _currentID;
                cls._ExecuteNonQuery(query);
            }
            LoadGridView();
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _isUpdate = 1;
            int _row = dataGridView1.CurrentCell.RowIndex;
            tbxName.Text = dataGridView1.Rows[_row].Cells[1].Value.ToString();
            rtbColumns.Text = dataGridView1.Rows[_row].Cells[2].Value.ToString();
            rtbDK.Text = dataGridView1.Rows[_row].Cells[3].Value.ToString();
            rtbDKHT.Text = dataGridView1.Rows[_row].Cells[4].Value.ToString();
            _currentID = Convert.ToInt32(dataGridView1.Rows[_row].Cells[0].Value);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int _row = dataGridView1.CurrentCell.RowIndex;
            int _columns = dataGridView1.CurrentCell.ColumnIndex;
            Global.listColumns.Clear();
            Global._dieukien.Clear();
            Global._hienthi_dieukien.Clear();
            string[] _listCol = dataGridView1.Rows[_row].Cells[2].Value.ToString().Trim().Split(';');
            string[] _listDieukien = dataGridView1.Rows[_row].Cells[3].Value.ToString().Trim().Split(';');
            string[] _listDieukienHT = dataGridView1.Rows[_row].Cells[4].Value.ToString().Trim().Split(';');
            
            foreach (string s in _listCol)
            {
                if(s.Trim() != "")
                Global.listColumns.Add(s);
            }
            foreach (string s in _listDieukien)
            {
                if (s.Trim() != "")
                {
                    Global._dieukien.Add(s);
                   
                }
               
            }
            foreach (string s in _listDieukienHT)
            {
                if (s.Trim() != "")
                {
                    Global._hienthi_dieukien.Add(s);

                }

            }
            this.Close();
        }
    }
}
