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
    public partial class BienDong : Form
    {
        public BienDong()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            clsStatic.LoadData(dataGridView1, i, new string[] { "MaHoSo", "MaBienDong", "LoaiBienDong","NgayBienDong","NoiDung" }, 
                                                new Control[] { this.txtMaHoSo,this.txtMaBienDong,this.cmbLoaiBienDong,this.dtpNgayBienDong,this.rtbNoiDung});
            MaBienDong = Convert.ToInt32(this.dataGridView1.Rows[i].Cells["MaBienDong"].Value);
        }
        public void Reload()
        {
            string query = " select * from tblBienDong where MaHoSo ="+MaHoSo.ToString();
            clsStatic.LoadDataGridView(dataGridView1, query);

            txtMaHoSo.Text = MaHoSo.ToString();
            txtMaBienDong.Text = "";
            dtpNgayBienDong.Enabled = false;
            cmbLoaiBienDong.Text = "";
            rtbNoiDung.Text = "";


            ChucNang = 0;
            MaBienDong = 0;
            clsStatic.TrangThaiBanDau(groupBox1);

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnOK.Enabled = btnCancel.Enabled = false;

            cmbLoaiBienDong.Items.Clear();
            cmbLoaiBienDong.Items.Add("Thêm thửa đất");
            cmbLoaiBienDong.Items.Add("Đổi thửa đất");
            cmbLoaiBienDong.Items.Add("Xóa thửa đất");
            cmbLoaiBienDong.Items.Add("Đổi tên người");

            dataGridView1.ClearSelection();
        }

        int ChucNang = 0;
        public int MaBienDong = 0;
        public int MaHoSo { get; set; }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ChucNang = 1;
            clsStatic.TrangThaiChucNang(groupBox1);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnOK.Enabled = btnCancel.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MaBienDong == 0)
            {
                MessageBox.Show("Cần chọn biến động");
                return;
            }
            ChucNang = 2;
            clsStatic.TrangThaiChucNang(groupBox1);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnOK.Enabled = btnCancel.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MaBienDong == 0)
            {
                MessageBox.Show("Cần chọn biến động");
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
            string[] Paras = new string[] { "@flag", "@MaHoSo", "@MaBienDong", "@NgayBienDong","@LoaiBienDong","@NoiDung" };
            string[] Values = new string[]{flag.ToString(), txtMaHoSo.Text.Trim(),  txtMaBienDong.Text.Trim(),
                                           dtpNgayBienDong.Value.ToString(), cmbLoaiBienDong.Text.Trim(),rtbNoiDung.Text.Trim() };
            int kq = 0;
            try
            {

                kq = cls.ExecuteSP("spBienDong", Paras, Values);
                if (kq > 0)
                {
                    //MessageBox.Show("OK!");
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void BienDong_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnTaoHoSoMoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaBienDong == 0)
                {
                    MessageBox.Show("Cần chọn biến động trước");
                    return;
                }

                string query = " select Max(MaBienDong) from tblBienDong where MaHoSo =" + MaHoSo.ToString();
                if (MaBienDong == Convert.ToInt32(cls.ExecuteQueryScalar(query)))
                {
                    query = " Select MaHoSoMoi from tblBienDong where MaHoSo =" + MaHoSo.ToString() + " and MaBienDong =" + MaBienDong.ToString();
                    if (cls.ExecuteQueryScalar(query) != "")
                    {
                        MessageBox.Show("Đã tạo hồ sơ mới rồi, Sai sót gì ở đây?!");
                        return;
                    }


                    if (MessageBox.Show("-) Khi tạo hồ sơ mới, tất cả thông tin từ hồ sơ hiện tại của bạn sẽ được copy sang hồ sơ mới và bạn sẽ chỉnh lý biến động trên hồ sơ mới. \n  " +
                                         "-) Hồ sơ hiện tại của bạn sẽ bị lưu thành hồ sơ cũ và không còn được sử dụng!", "Tạo hồ sơ mới?!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int exe = cls.ExecuteSP("spSaoChepHoSo", new string[] { "@MaHoSo", "@MaBienDong" }, new string[] { MaHoSo.ToString(), MaBienDong.ToString() });
                        if (exe == 0)
                        {
                            MessageBox.Show("Copy hồ sơ Error!");
                        }

                        this.MaHoSo = exe;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Phải là biến động sau cùng, bạn mới có thể tạo hồ sơ mới!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnLichSu_Click(object sender, EventArgs e)
        {
            LichSu lichsu = new LichSu();
            lichsu.MaHoSo = this.MaHoSo;
            lichsu.MaBienDong = this.MaBienDong;

            this.Hide();
            lichsu.ShowDialog();

            this.Show();
        }

       
    }
}
