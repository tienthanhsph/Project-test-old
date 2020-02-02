using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CTL;
using DB;

namespace GIAODIEN
{
    public partial class ThongTinBenhNhan : UserControl
    {
        public ThongTinBenhNhan()
        {
            InitializeComponent();
        }
        int state = 0;
        private void ThongTinBenhNhan_Load(object sender, EventArgs e)
        {
            Benhnhanctrl benhnhan = new Benhnhanctrl();
            benhnhan.LoadDatagridview(dataGridView1, "", "", "", "", "","");
            LoadDataGridViewFormat();
            TrangThaiBanDau();

        }
        private void TrangThaiBanDau()
        {
            state = 0;
            button2.Enabled = button3.Enabled = button4.Enabled = button1.Enabled = true;
            button6.Enabled = button5.Enabled = false;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text =comboBox1.Text= "";

        }
        private void TrangThaiChucNang()
        {
            button2.Enabled = button3.Enabled = button4.Enabled = button1.Enabled = false;
            button6.Enabled = button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            state = 0;
            TrangThaiBanDau();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            state = 1;
            TrangThaiChucNang();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            state = 2;
            TrangThaiChucNang();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            state = 3;
            TrangThaiChucNang();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string _gioitinh = "true";
            if (comboBox1.Text.Trim() == "Nam") _gioitinh = "true";
            else _gioitinh = "false";

            switch (state)
            {
                case 1:
                    {
                        Benhnhanctrl benhnhan = new Benhnhanctrl();
                        if (textBox1.Text.Trim() == "")
                            MessageBox.Show("Phải có tên bệnh nhân mới thực hiện thêm được!");
                        else
                        {
                            
                            benhnhan.ThemBenhNhan(dataGridView1, textBox1.Text.Trim(), textBox4.Text.Trim(), dateTimePicker2.Text.Trim(),_gioitinh, textBox2.Text.Trim(), textBox5.Text.Trim());
                        }
                        break;
                    }
                case 2:
                    {
                        Benhnhanctrl benhnhan = new Benhnhanctrl();
                        benhnhan.SuaBenhNhan(dataGridView1, this.dataGridView1.CurrentRow.Cells[0].Value.ToString(),textBox1.Text.Trim(),textBox4.Text.Trim(),dateTimePicker2.Text.Trim(),_gioitinh,textBox2.Text.Trim(),textBox5.Text.Trim());
                        break;
                    }
                case 3:
                    {
                        Benhnhanctrl benhnhan = new Benhnhanctrl();
                        benhnhan.XoaBenhNhan(dataGridView1, this.dataGridView1.CurrentRow.Cells[0].Value.ToString(), textBox1.Text.Trim(), textBox4.Text.Trim(), dateTimePicker2.Text.Trim(), _gioitinh, textBox2.Text.Trim(), textBox5.Text.Trim());
                        break;
                    }
            }
            TrangThaiBanDau();
        }

        private string Kieu_Gioi_Tinh(string input)
        {
            if (input == "Nam")
                return "1";
            else

            if (input == "Nữ")
                return "0";
            else
                return "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Benhnhanctrl benhnhan = new Benhnhanctrl();
            if(dateTimePicker2.Checked== true)
                benhnhan.LoadDatagridview(dataGridView1, textBox1.Text.Trim(), textBox4.Text.Trim(), dateTimePicker2.Text.Trim(),Kieu_Gioi_Tinh(comboBox1.Text), textBox2.Text.Trim(), textBox5.Text.Trim());
            else
                benhnhan.LoadDatagridview(dataGridView1, textBox1.Text.Trim(), textBox4.Text.Trim(), "", Kieu_Gioi_Tinh(comboBox1.Text), textBox2.Text.Trim(), textBox5.Text.Trim());

        }

        private void LoadDataGridViewFormat()
        {
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 400;
            dataGridView1.Columns[6].Width = 150;

            dataGridView1.Columns[0].HeaderText = "Key";
            dataGridView1.Columns[1].HeaderText = "Tên Bệnh Nhân";
            dataGridView1.Columns[2].HeaderText = "CMND";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Giới Tính";
            dataGridView1.Columns[5].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[6].HeaderText = "SĐT";

            dataGridView1.Columns[0].Visible = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "False") comboBox1.Text = "Nữ";
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "True") comboBox1.Text = "Nam";
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clsThongTinChung.MaBenhNhan = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        

    }
}
