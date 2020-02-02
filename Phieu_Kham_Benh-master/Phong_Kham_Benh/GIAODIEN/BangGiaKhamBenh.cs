using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CTL;
using DB;

namespace GIAODIEN
{
    public partial class BangGiaKhamBenh : UserControl
    {
        public BangGiaKhamBenh()
        {
            InitializeComponent();
        }
        
        private void BangGiaKhamBenh_Load(object sender, EventArgs e)
        {
            Banggiactrl bg = new Banggiactrl();
            bg.LoadDataGridView(dataGridView1, "", "", "", "", "");
            LoadDataGridViewFormat();
            TrangThaiBanDau();
            clsDatabase cls = new clsDatabase();
            cls.loadcombobox(comboBox1, "SELECT Distinct(Danghoatdong) FROM tblLoaihinhdichvu", 0);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TrangThaiBanDau()
        {
            state = 0;            
            button1.Enabled = button2.Enabled = button3.Enabled = button6.Enabled = true;
            button4.Enabled = button5.Enabled = false;
            textBox1.Text = textBox2.Text = comboBox1.Text = "";
            
        }
        private void TrangThaiChucNang()
        {            
            button1.Enabled = button2.Enabled = button3.Enabled = button6.Enabled = false;           
            button4.Enabled = button5.Enabled = true;
        }
        private void LoadDataGridViewFormat()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;

            dataGridView1.Columns[0].HeaderText = "pk";
            dataGridView1.Columns[1].HeaderText = "Key";
            dataGridView1.Columns[2].HeaderText = "Tên Dịch Vụ";
            dataGridView1.Columns[3].HeaderText = "Giá";
            dataGridView1.Columns[4].HeaderText = "Ngày thêm";
            dataGridView1.Columns[5].HeaderText = "Ngày hủy";
            dataGridView1.Columns[6].HeaderText = "Đang hoạt động";

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;

        }
        int state = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            state = 1;
            TrangThaiChucNang();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            state = 2;
            TrangThaiChucNang();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            state = 3;
            TrangThaiChucNang();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            state = 0;
            TrangThaiBanDau();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Banggiactrl bg = new Banggiactrl();
            string _danghd = "";
            if (comboBox1.Text.Trim() == "") _danghd = "";
            else if (comboBox1.Text.Trim() == "false") _danghd = "0"; 
                else _danghd = "1";
            string _ngaythem = "";
            string _ngayhuy = "";
            if (dateTimePicker1.Checked == true) _ngaythem = dateTimePicker1.Text.Trim();
            if (dateTimePicker2.Checked == true) _ngayhuy = dateTimePicker1.Text.Trim();            
            bg.LoadDataGridView(dataGridView1, textBox1.Text.Trim(), textBox2.Text.Trim(), _ngaythem,_ngayhuy,_danghd);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 1:
                    {
                        Banggiactrl bg = new Banggiactrl();
                        if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
                            MessageBox.Show("Phải có tên Dịch Vụ và Giá mới thực hiện thêm được!");
                        else
                            bg.ThemBangGia(dataGridView1, textBox1.Text.Trim(), textBox2.Text.Trim(),dateTimePicker1.Text.Trim());
                        break;
                    }
                case 2:
                    {
                        Banggiactrl bg = new Banggiactrl();
                        bg.SuaBangGia(dataGridView1, this.dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                            textBox1.Text.Trim(), textBox2.Text.Trim(), dateTimePicker1.Text.Trim(), dateTimePicker2.Text.Trim(), comboBox1.Text.ToString());
                        break;
                    }
                case 3:
                    {
                        Banggiactrl bg = new Banggiactrl();
                        bg.XoaBangGia(dataGridView1, this.dataGridView1.CurrentRow.Cells[0].Value.ToString(), textBox1.Text.Trim(), textBox2.Text.Trim());
                        break;
                    }
            }
            TrangThaiBanDau();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
