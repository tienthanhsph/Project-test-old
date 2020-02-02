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
    public partial class HoSo : Form
    {
        public HoSo()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            clsStatic.LoadData(dataGridView1, i, new string[] { "MaHoSo", "DienTich", "ChuHoSo","TrangThai" }, new Control[] { this.txtMaHoSo, this.txtDienTich, this.txtChu,this.txtTrangThai });
            MaHoSo =Convert.ToInt32(this.dataGridView1.Rows[i].Cells["MaHoSo"].Value);
        }
        public void Reload()
        {
            string query = " select * from tblHoSo";
            clsStatic.LoadDataGridView(dataGridView1, query);

            txtChu.Text = "";
            txtDienTich.Text = "";
            txtMaHoSo.Text = "";

            ChucNang = 0;
            MaHoSo = 0;
            clsStatic.TrangThaiBanDau(groupBox1);

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnOK.Enabled = btnCancel.Enabled = false;

            StyleGridView();
            dataGridView1.ClearSelection();

        }
        private void StyleGridView()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].Name == "MaHoSo")
                {
                    dataGridView1.Columns[i].HeaderText = "Mã hồ sơ";
                    dataGridView1.Columns[i].Width = 80;
                }
                if (dataGridView1.Columns[i].Name == "DienTich")
                {
                    dataGridView1.Columns[i].HeaderText = "Diện tích";
                    dataGridView1.Columns[i].Width = 100;
                }
                if (dataGridView1.Columns[i].Name == "ChuHoSo")
                {
                    dataGridView1.Columns[i].HeaderText = "Chủ hồ sơ";
                    dataGridView1.Columns[i].Width = 250;
                }
                if (dataGridView1.Columns[i].Name == "TrangThai")
                {
                    dataGridView1.Columns[i].HeaderText = "Trạng thái";
                    dataGridView1.Columns[i].Width = 100;
                }
            }
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int _trangthai = 0;
                    try
                    {
                        _trangthai=Convert.ToInt32(dataGridView1.Rows[i].Cells["TrangThai"].Value);
                    }
                    catch (Exception ex) { }
                    if (_trangthai == 10)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            
        }
        int ChucNang = 0;
        public int MaHoSo = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            ChucNang = 1;
            clsStatic.TrangThaiChucNang(groupBox1);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnOK.Enabled = btnCancel.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MaHoSo == 0)
            {
                MessageBox.Show("Cần chọn hồ sơ");
                return;
            }
            ChucNang = 2;
            clsStatic.TrangThaiChucNang(groupBox1);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnOK.Enabled = btnCancel.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MaHoSo == 0)
            {
                MessageBox.Show("Cần chọn hồ sơ");
                return;
            }
            ChucNang = 3;
            clsStatic.TrangThaiChucNang(groupBox1);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnOK.Enabled = btnCancel.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Execute(ChucNang);
            clsStatic.TrangThaiKetThuc(groupBox1);              
            Reload();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clsStatic.TrangThaiKetThuc(groupBox1);              
            Reload();
        }

        private void Execute(int flag)
        {
            string[] Paras = new string[] { "@flag", "@MaHoSo", "@DienTich", "@Chu","@TrangThai" };
            string[] Values = new string[]{flag.ToString(), txtMaHoSo.Text.Trim(),
                                            txtDienTich.Text.Trim(),txtChu.Text.Trim(),txtTrangThai.Text.Trim()};
            int kq = 0;
            try{

                kq = cls.ExecuteSP("spHoSo", Paras, Values);
                if (kq > 0)
                {
                    //MessageBox.Show("OK!");
                }
                else {
                    MessageBox.Show("Error!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HoSo_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnBienDong_Click(object sender, EventArgs e)
        {
            if(MaHoSo == 0)
            {
            MessageBox.Show("Cần chọn hồ sơ!");
                return;
            }
            BienDong biendong = new BienDong();
            biendong.MaHoSo = this.MaHoSo;

            this.Hide();
            biendong.ShowDialog();
            this.MaHoSo = biendong.MaHoSo;
            this.Show();
            this.Reload();
        }

        private void btnLichSuBienDong_Click(object sender, EventArgs e)
        {
            LichSu lichsu = new LichSu();
            lichsu.MaHoSo = this.MaHoSo;
            
            this.Hide();
            lichsu.ShowDialog();

            this.Show();
        }

        ThongTinNhanh thongtin = new ThongTinNhanh();
        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int i = e.RowIndex;
            //if (i >= 0)
            //{
                
            //    thongtin.Location = this.PointToScreen(e.Location);
            //    thongtin.label2.Text = "  Mã hồ sơ: " + this.dataGridView1.Rows[i].Cells["MaHoSo"].Value.ToString() + "\n" +
            //                            "  Diện tích: " + this.dataGridView1.Rows[i].Cells["DienTich"].Value.ToString() + "\n" +
            //                            "  Chủ: " + this.dataGridView1.Rows[i].Cells["ChuHoSo"].Value.ToString() + "\n" +
            //                            "  Trạng thái: " + this.dataGridView1.Rows[i].Cells["TrangThai"].Value.ToString();
            //    thongtin.Show();
            //}


           
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //thongtin.Hide();
        }

    }
}
