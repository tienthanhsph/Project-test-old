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
    public partial class ChonCotBD : Form
    {
        public ChonCotBD()
        {
            InitializeComponent();
        }
        public DataSet ds1 = new DataSet();
        public DataSet ds2 = new DataSet();
        DataTable tbl1 = new DataTable();
        DataTable tbl2 = new DataTable();
        DataTable tbl3 = new DataTable();
        int k = 1;
        clsDatabase cls = new clsDatabase();

        public void CreateDataset()
        {
            ds1.Tables.Clear();
            ds2.Tables.Clear();

            tbl1.Reset();
            tbl1.Columns.Add("Chọn", typeof(bool));
            tbl1.Columns.Add("Tiêu đề", typeof(string));
            tbl1.Columns.Add("Tên trường", typeof(string));
            ds1.Tables.Add(tbl1);

            tbl3.Reset();
            tbl3.Columns.Add("Chọn", typeof(bool));
            tbl3.Columns.Add("Tiêu đề", typeof(string));
            tbl3.Columns.Add("Tên trường", typeof(string));
            ds1.Tables.Add(tbl3);

            tbl2.Reset();
            tbl2.Columns.Add("Thứ tự", typeof(int));
            tbl2.Columns.Add("Tiêu đề", typeof(string));
            tbl2.Columns.Add("Tên trường", typeof(string));
            ds2.Tables.Add(tbl2);

        }
        private void FormatGridView1()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string _query = " select  B.Color " +
                                " from tblColumnsBienDong as A inner join tblQuanLyBangBienDong as B on A.TenBang = B.num " +
                                " where A.TenCot = '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "' ";
                DataSet ds = cls._Execute(_query);
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromName(ds.Tables[0].Rows[0][0].ToString());
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[2].Visible = false;
            }
        }
        private void FormatGridView2()
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                string _query = " select  B.Color " +
                                " from tblColumnsBienDong as A inner join tblQuanLyBangBienDong as B on A.TenBang = B.num " +
                                " where A.TenCot = '" + dataGridView2.Rows[i].Cells[2].Value.ToString() + "' ";
                DataSet ds = cls._Execute(_query);
                dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.FromName(ds.Tables[0].Rows[0][0].ToString());
                dataGridView2.Columns[0].Width = 50;
                dataGridView2.Columns[1].Width = 200;
                dataGridView2.Columns[2].Width = 150;
                dataGridView2.Columns[2].Visible = false;
            }
        }

        private void ChonCot_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView2.DataSource = ds2.Tables[0];
            FormatGridView1();
            FormatGridView2();
            LoadComboBox1();
        }
        private void LoadComboBox1()
        {
            string _query = " select * from tblQuanLyBangBienDong ";
            string[] _result = cls._ExecuteReader(_query, "title");
            foreach (string item in _result)
            {
                comboBox1.Items.Add(item);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
                dataGridView2.DataSource = ds2.Tables[0];
                k = 1;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ((bool)dataGridView1.Rows[i].Cells[0].Value)
                    {
                        if (Global.listColumns.Contains(dataGridView1.Rows[i].Cells[2].Value.ToString()) == false)
                        {

                            ds2.Tables[0].Rows.Add(k, dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString());
                            //Global.listColumns.Add(dataGridView1.Rows[i].Cells[2].Value.ToString()); 
                            k += 1;

                        }
                    }
                }
                FormatGridView2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                int _row = dataGridView2.CurrentCell.RowIndex;
                string _cot = dataGridView2.Rows[_row].Cells[2].Value.ToString().Trim();
                Global.listColumns.Remove(_cot);
                FormatGridView2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ds2.Tables[0].Rows.Clear();
            Global.listColumns.Clear();
            dataGridView2.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                dataGridView1.DataSource = ds1.Tables[0];
            }
            else
            {
                ds1.Tables[1].Rows.Clear();
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    if (ds1.Tables[0].Rows[i][1].ToString().ToLower().Contains(textBox1.Text.Trim().ToLower()) || ds1.Tables[0].Rows[i][2].ToString().ToLower().Contains(textBox1.Text.Trim().ToLower()))
                    {
                        ds1.Tables[1].Rows.Add(false, ds1.Tables[0].Rows[i][1].ToString(), ds1.Tables[0].Rows[i][2].ToString());
                    }
                }
                dataGridView1.DataSource = ds1.Tables[1];
            }
            FormatGridView1();
        }
        private int DemSoDongCuaBang(string TenBang)
        {
            string _query1 = " select count(*) from tblColumnsBienDong where TrangThai = '1' and Tenbang = '" + TenBang + "'";
            int _result = Convert.ToInt32(cls._ExecuteScalar(_query1));
            return _result;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text.Trim())
            {
               
                case "Bảng đăng ký biến động":
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
                        break;
                    }
                case "Bảng loại biến động":
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[DemSoDongCuaBang("tblDangKyBienDong")].Cells[0];
                        break;
                    }
                case "Bảng loại hình biến động":
                    {
                        int _index = DemSoDongCuaBang("tblDangKyBienDong") + DemSoDongCuaBang("tblTuDienLoaiHinhBienDong");
                        dataGridView1.CurrentCell = dataGridView1.Rows[_index].Cells[0];
                        break;
                    }
                case "Bảng tổng hợp số liệu Người chuyển nhượng":
                    {
                        int _index = DemSoDongCuaBang("tblDangKyBienDong") + DemSoDongCuaBang("tblTuDienLoaiHinhBienDong") + DemSoDongCuaBang("tblTuDienLoaiBienDong");
                        dataGridView1.CurrentCell = dataGridView1.Rows[_index].Cells[0];
                        break;
                    }
                case "Bảng tổng hợp số liệu Người nhận chuyển nhượng":
                    {
                        int _index = DemSoDongCuaBang("tblDangKyBienDong") + DemSoDongCuaBang("tblTuDienLoaiHinhBienDong") + DemSoDongCuaBang("tblTuDienLoaiBienDong") + DemSoDongCuaBang("tblTongHopSoLieuNguoi");
                        dataGridView1.CurrentCell = dataGridView1.Rows[_index].Cells[0];
                        break;
                    }
                case "Bảng Thửa đất cấp Giấy chứng nhận":
                    {
                        int _index = DemSoDongCuaBang("tblDangKyBienDong") + DemSoDongCuaBang("tblTuDienLoaiHinhBienDong") + DemSoDongCuaBang("tblTuDienLoaiBienDong") + DemSoDongCuaBang("tblTongHopSoLieuNguoi") + DemSoDongCuaBang("tblTongHopSoLieuNguoiDoiVoiBienDong");
                        dataGridView1.CurrentCell = dataGridView1.Rows[_index].Cells[0];
                        break;
                    }
                case "Bảng Hồ sơ cấp Giấy chứng nhận":
                    {
                        int _index = DemSoDongCuaBang("tblDangKyBienDong") + DemSoDongCuaBang("tblTuDienLoaiHinhBienDong") + DemSoDongCuaBang("tblTuDienLoaiBienDong") + DemSoDongCuaBang("tblTongHopSoLieuNguoi") + DemSoDongCuaBang("tblTongHopSoLieuNguoiDoiVoiBienDong") + DemSoDongCuaBang("tblHoSoCapGCN");
                        dataGridView1.CurrentCell = dataGridView1.Rows[_index].Cells[0];
                        break;
                    }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Global.listColumns.Clear();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                Global.listColumns.Add(dataGridView2.Rows[i].Cells[2].Value.ToString());

            }

            this.Close();
        }

        private void btnEditColumns_Click(object sender, EventArgs e)
        {
            EditColumns frm = new EditColumns();
            frm.ShowDialog();
        }
        int Value1 = 0;
        int Value2 = 0;
        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentCell.ColumnIndex == 0)
                {
                    Value1 = Convert.ToInt32(dataGridView2.CurrentCell.Value);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentCell.ColumnIndex == 0)
                {
                    Value2 = Convert.ToInt32(dataGridView2.CurrentCell.Value);
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (i != dataGridView2.CurrentCell.RowIndex)
                        {
                            if (Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value) == Value2)
                            {
                                dataGridView2.Rows[i].Cells[0].Value = Value1;

                            }

                        }

                    }
                }
                dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Ascending);
                // dataGridView2.Refresh();
            }
            catch (Exception ex)
            { MessageBox.Show("Cần nhấn Enter sau khi thay đổi nội dung xong! \n" + ex.Message); }

        }

    }
}
