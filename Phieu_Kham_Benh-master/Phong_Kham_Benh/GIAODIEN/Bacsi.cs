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
    public partial class Bacsi : UserControl
    {
        public Bacsi()
        {
            InitializeComponent();
        }
        //int Key = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // int i = this.dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        int state = 0;
        private void TrangThaiBanDau()
        {
            state = 0;            
            button1.Enabled = button2.Enabled = button3.Enabled = button6.Enabled = true;
            button4.Enabled = button5.Enabled = false;
            textBox1.Text = textBox2.Text = textBox3.Text = comboBox1.Text = "";
        }
        private void TrangThaiChucNang()
        {
            button1.Enabled = button2.Enabled = button3.Enabled = button6.Enabled = false;            
            button4.Enabled = button5.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrangThaiChucNang();
            state = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrangThaiChucNang();
            state = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrangThaiChucNang();
            state = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
        
            switch (state)
            {
                case 1:
                    {
                        Bacsictrl bs = new Bacsictrl();
                        if (textBox1.Text.Trim() == "")
                            MessageBox.Show("Phải có tên bác sĩ mới thực hiện thêm được!");
                        else
                            bs.ThemBacSi(dataGridView1, textBox1.Text.Trim(), textBox2.Text.Trim(), comboBox1.Text.Trim(), dateTimePicker1.Text.Trim(), textBox3.Text.Trim());
                        break;
                    }
                case 2:
                    {
                        Bacsictrl bs = new Bacsictrl();
                        bs.SuaBacSi(dataGridView1, this.dataGridView1.CurrentRow.Cells[0].Value.ToString(), textBox1.Text.Trim(),
                            textBox2.Text.Trim(), comboBox1.Text.Trim(), dateTimePicker1.Text.Trim(), textBox3.Text.Trim());
                        break; 
                    }
                case 3:
                    {
                        Bacsictrl bs = new Bacsictrl();
                        bs.XoaBacSi(dataGridView1, this.dataGridView1.CurrentRow.Cells[0].Value.ToString(), textBox1.Text.Trim(),
                            textBox2.Text.Trim(), comboBox1.Text.Trim(), dateTimePicker1.Text.Trim(), textBox3.Text.Trim());
                        break;
                    }
            }
            TrangThaiBanDau();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            state = 0;
            TrangThaiBanDau();
        }

        private void Bacsi_Load(object sender, EventArgs e)
        {
            Bacsictrl bs = new Bacsictrl();
            bs.LoadDatagridview(dataGridView1, "", "", "", "", "");
            LoadDataGridViewFormat();
            TrangThaiBanDau();

            clsDatabase cls = new clsDatabase();
            cls.loadcombobox(comboBox1, "SELECT * FROM tblLoaihinhdichvu", 2);
        }
        private void LoadDataGridViewFormat()
        {
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 110;

            dataGridView1.Columns[0].HeaderText = "Key";
            dataGridView1.Columns[1].HeaderText = "Tên bác sĩ";
            dataGridView1.Columns[2].HeaderText = "Trình độ";
            dataGridView1.Columns[3].HeaderText = "Chuyên khoa";
            dataGridView1.Columns[4].HeaderText = "Ngày vào BV";
            dataGridView1.Columns[5].HeaderText = "Kinh nghiệm";

            dataGridView1.Columns[0].Visible = false;
            
        }
       
        
        private void button6_Click(object sender, EventArgs e)
        {
            Bacsictrl bsctr = new Bacsictrl();
            bsctr.LoadDatagridview(dataGridView1, textBox1.Text.Trim(), textBox2.Text.Trim(), comboBox1.Text.Trim(), dateTimePicker1.Text.Trim(), textBox3.Text.Trim());
        }
    }
}
