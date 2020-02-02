using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DB;
using CTL;

namespace GIAODIEN
{
    public partial class PhieuKham : UserControl
    {
        public PhieuKham()
        {
            InitializeComponent();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ThongTinBenhNhan bn = new ThongTinBenhNhan();
            frmUC frm = new frmUC();
            frm.Show();
            //frm.ShowDialog();
            frm.LoadPanel(bn);

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PhieuKham_Load(object sender, EventArgs e)
        {
            button7.Hide();
            TrangThaiBanDau();
            Phieukhamctrl pk = new Phieukhamctrl();
            pk.LoadDatagridview(dataGridView1, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            LoadDataGridViewFormat();
            LoadThongTinBenhNhan();
            LoadBacSi();
        }
        private void LoadDataGridViewFormat()
        {
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 55;
            dataGridView1.Columns[3].Width = 55;
            dataGridView1.Columns[4].Width = 55;
            dataGridView1.Columns[5].Width = 55;
            dataGridView1.Columns[6].Width = 55;
            dataGridView1.Columns[7].Width = 55;
            dataGridView1.Columns[8].Width = 55;
            dataGridView1.Columns[9].Width = 55;
            dataGridView1.Columns[10].Width = 55;
            dataGridView1.Columns[11].Width = 55;
            dataGridView1.Columns[12].Width = 55;
            dataGridView1.Columns[13].Width = 55;
            dataGridView1.Columns[14].Width = 55;
            dataGridView1.Columns[15].Width = 55;
            dataGridView1.Columns[16].Width = 85;
            dataGridView1.Columns[17].Width = 90;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "BS";
            dataGridView1.Columns[3].HeaderText = "Đón tiếp";
            dataGridView1.Columns[4].HeaderText = "Điện tim";
            dataGridView1.Columns[5].HeaderText = "Nội";
            dataGridView1.Columns[6].HeaderText = "Nội nhi";
            dataGridView1.Columns[7].HeaderText = "Nội 4";
            dataGridView1.Columns[8].HeaderText = "Ngoại";
            dataGridView1.Columns[9].HeaderText = "Sản";
            dataGridView1.Columns[10].HeaderText = "Xquang";
            dataGridView1.Columns[11].HeaderText = "Siêu âm";
            dataGridView1.Columns[12].HeaderText = "Sinh hóa";
            dataGridView1.Columns[13].HeaderText = "HH";
            dataGridView1.Columns[14].HeaderText = "TMH";
            dataGridView1.Columns[15].HeaderText = "RHM";
            dataGridView1.Columns[16].HeaderText = "Ngày";
            dataGridView1.Columns[17].HeaderText = "Tổng tiền";

            

            //dataGridView1.Columns[0].Visible = false;
        
        }
        private void LoadThongTinBenhNhan()
        {
            if (clsThongTinChung.MaBenhNhan != "")
            {                
                string str = "SELECT Top(1) Hoten from tblBenhNhan where PK_MaBN = " + clsThongTinChung.MaBenhNhan;
                clsDatabase cls = new clsDatabase();
                textBox1.Text = cls.Execute_Reader(str);

            }
        }
        private void LoadBacSi()
        {
            clsDatabase cls = new clsDatabase();
            cls.loadcombobox(comboBox1, "SELECT * FROM tblBacsi", 1);
        }

        private void TrangThaiBanDau()
        {
            state = 0;            
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = true;
            button5.Enabled = button6.Enabled = false;
            textBox1.Text = textBox2.Text = textBox3.Text= "";
        }
        private void TrangThaiChucNang()
        {            
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = false;            
            button6.Enabled = button5.Enabled = true;
        }
        private int state = 0;
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
        private string XemMaBacSi(string tenbacsi)
        {
            string str = "SELECT Top(1) PK_Bacsi from tblBacsi where Tenbacsi = N'" + tenbacsi+"'";
            clsDatabase cls = new clsDatabase();
            string kq = cls.Execute_Reader(str);
            return kq;
        }
        private string XemTenBacSi(int MaBS)
        {
            string str = "SELECT Top(1) Tenbacsi from tblBacsi where PK_Bacsi = " + MaBS ;
            clsDatabase cls = new clsDatabase();
            string kq = cls.Execute_Reader(str);
            return kq;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string MaBS = "";
            if(comboBox1.Text.Trim()!="")
                MaBS= XemMaBacSi(comboBox1.Text.Trim());
            switch (state)
            {
                
                case 1:
                    {
                        Phieukhamctrl pk = new Phieukhamctrl();
                        if (textBox1.Text.Trim() == "")
                            MessageBox.Show("Phải có tên bệnh nhân mới thực hiện thêm được!");
                        else
                            pk.ThemPhieuKham(dataGridView1,clsThongTinChung.MaBenhNhan,MaBS,checkBox1.Checked.ToString(),checkBox2.Checked.ToString(),checkBox3.Checked.ToString(),checkBox4.Checked.ToString(),checkBox5.Checked.ToString(),checkBox6.Checked.ToString(),checkBox7.Checked.ToString(),checkBox8.Checked.ToString(),checkBox9.Checked.ToString(),checkBox10.Checked.ToString(),checkBox11.Checked.ToString(),checkBox12.Checked.ToString(),checkBox13.Checked.ToString(),DateTime.Now.ToString(),"");

                        break;
                    }
                case 2:
                    {
                        Phieukhamctrl pk = new Phieukhamctrl();
                        pk.SuaPhieuKham(dataGridView1, this.dataGridView1.CurrentRow.Cells[0].Value.ToString(), clsThongTinChung.MaBenhNhan, MaBS, checkBox1.Checked.ToString(), checkBox2.Checked.ToString(), checkBox3.Checked.ToString(), checkBox4.Checked.ToString(), checkBox5.Checked.ToString(), checkBox6.Checked.ToString(), checkBox7.Checked.ToString(), checkBox8.Checked.ToString(), checkBox9.Checked.ToString(), checkBox10.Checked.ToString(), checkBox11.Checked.ToString(), checkBox12.Checked.ToString(), checkBox13.Checked.ToString(), DateTime.Now.ToString(), "");
                        break;
                    }
                case 3:
                    {
                        Phieukhamctrl pk = new Phieukhamctrl();
                        pk.XoaPhieuKham(dataGridView1, this.dataGridView1.CurrentRow.Cells[0].Value.ToString(), clsThongTinChung.MaBenhNhan, MaBS, checkBox1.Checked.ToString(), checkBox2.Checked.ToString(), checkBox3.Checked.ToString(), checkBox4.Checked.ToString(), checkBox5.Checked.ToString(), checkBox6.Checked.ToString(), checkBox7.Checked.ToString(), checkBox8.Checked.ToString(), checkBox9.Checked.ToString(), checkBox10.Checked.ToString(), checkBox11.Checked.ToString(), checkBox12.Checked.ToString(), checkBox13.Checked.ToString(), DateTime.Now.ToString(), "");
                        break;
                    }
            }
            TrangThaiBanDau();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            state = 0;
            TrangThaiBanDau();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clsThongTinChung.MaBenhNhan = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = XemTenBacSi(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
            textBox2.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            checkBox1.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            checkBox2.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            checkBox3.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            checkBox4.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            checkBox5.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            checkBox6.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            checkBox7.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            checkBox8.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[10].Value.ToString());
            checkBox9.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[11].Value.ToString());
            checkBox10.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[12].Value.ToString());
            checkBox11.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[13].Value.ToString());
            checkBox12.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[14].Value.ToString());
            checkBox13.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[15].Value.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try {
                if (textBox3.Text.Trim() != "")
                {
                    VIEW_REPORT rpt = new VIEW_REPORT();
                    rpt._maphieu = Convert.ToInt32(textBox3.Text.Trim());
                    rpt.LoadPhieuKham();
                    rpt.Show();
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phieukhamctrl pk = new Phieukhamctrl();
            pk.LoadDatagridview_TimKiem(dataGridView1, textBox3.Text.Trim(), textBox1.Text.Trim(), comboBox1.Text.Trim(), checkBox1.Checked.ToString(), checkBox2.Checked.ToString(), checkBox3.Checked.ToString(), checkBox4.Checked.ToString(), checkBox5.Checked.ToString(), checkBox6.Checked.ToString(), checkBox7.Checked.ToString(), checkBox8.Checked.ToString(), checkBox9.Checked.ToString(), checkBox10.Checked.ToString(), checkBox11.Checked.ToString(), checkBox12.Checked.ToString(), checkBox13.Checked.ToString(), "", "");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
