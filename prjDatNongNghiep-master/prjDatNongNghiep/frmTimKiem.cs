using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDatNongNghiep
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        int MaHoSo = 0;
        int MaSoGiaDinh = 0;
        private void btnHoSo_Click(object sender, EventArgs e)
        {
            clsConfig.Refresh();
            clsConfig.MaHoSo = this.MaHoSo;
            clsConfig.MaGiaDinh = this.MaSoGiaDinh;
            frmHOSO frm = new frmHOSO();
            frm.MaHoSoDatNN = clsConfig.MaHoSo;
            frm.MaSoGiaDinh = clsConfig.MaGiaDinh;
            this.Close();
            //this.Hide();
            //frm.Show();
        }

        int KieuTimKiem = 0;
        private void btnTim1_Click(object sender, EventArgs e)
        {
            KieuTimKiem = 0;
            TimKiem();
        }

        private void btnTim2_Click(object sender, EventArgs e)
        {
            KieuTimKiem = 1;
            TimKiem();
        }
       
        private void TimKiem()
        {
            string query = "spTimKiemHoSoDatNN";
            string[] Paras = new string[] { "@flag","@MaDonViHanhChinh","@HoTen","@CMND","@DiaChi","@ToBanDo","@SoThua","@HoSoCoHieuLuc"};
            string[] Values = new string[] { KieuTimKiem.ToString(), clsConfig.MaDonVihanhChinh, txtTenNguoi.Text.Trim(),txtCMND.Text.Trim(),
                                             txtDiaChi.Text.Trim(), txtTBD.Text.Trim(),txtThua.Text.Trim(),ChkHoSoConHieuLuc.Checked.ToString()};
            clsDatabase cls = new clsDatabase();
            DataSet ds = cls.GetData(query, Paras, Values);
            dataGridView1.DataSource = ds.Tables[0];
            DatagridviewStyle();
        }
        private void DatagridviewStyle()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {

                if (dataGridView1.Columns[i].Name == "MaSoGiaDinh")
                {
                    dataGridView1.Columns[i].HeaderText = "Mã Gia đình";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "NguoiDaiDien")
                {
                    dataGridView1.Columns[i].HeaderText = "Đại diện gia đình";
                    dataGridView1.Columns[i].Width = 150;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "ThanhVien")
                {
                    dataGridView1.Columns[i].HeaderText = "Thành viên gia đình";
                    dataGridView1.Columns[i].Width = 300;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "DienTichDeNghiCapGCN")
                {
                    dataGridView1.Columns[i].HeaderText = "Diện tích cấp GCN";
                    dataGridView1.Columns[i].Width = 100;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "DiaChi")
                {
                    dataGridView1.Columns[i].HeaderText = "Địa chỉ";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                }
                /////////
                if (dataGridView1.Columns[i].Name == "ID")
                {
                    dataGridView1.Columns[i].HeaderText = "ID";
                    dataGridView1.Columns[i].Width = 30;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "MaHoSoCapGCNDatNN")
                {
                    dataGridView1.Columns[i].HeaderText = "Mã hồ sơ";
                    dataGridView1.Columns[i].Width = 60;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "MaDonViHanhChinh")
                {
                    dataGridView1.Columns[i].HeaderText = "Mã xã";
                    dataGridView1.Columns[i].Width = 60;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "ToBanDo")
                {
                    dataGridView1.Columns[i].HeaderText = "Tờ bản đồ";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "SoThua")
                {
                    dataGridView1.Columns[i].HeaderText = "Số thửa";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "DienTich")
                {
                    dataGridView1.Columns[i].HeaderText = "Diện tích";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                    
                }
                if (dataGridView1.Columns[i].Name == "DienTichTangGiam")
                {
                    dataGridView1.Columns[i].HeaderText = "DT tăng/giảm";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "LoaiDat")
                {
                    dataGridView1.Columns[i].HeaderText = "Loại đất";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "MucDich")
                {
                    dataGridView1.Columns[i].HeaderText = "Mục đích";
                    dataGridView1.Columns[i].Width = 100;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "LoaiThoiHan")
                {
                    dataGridView1.Columns[i].HeaderText = "Loại thời hạn";
                    dataGridView1.Columns[i].Width = 100;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "ThoiHan")
                {
                    dataGridView1.Columns[i].HeaderText = "Thời hạn";
                    dataGridView1.Columns[i].Width = 60;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "NguonGoc")
                {
                    dataGridView1.Columns[i].HeaderText = "Nguồn gốc";
                    dataGridView1.Columns[i].Width = 150;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "DauThau")
                {
                    dataGridView1.Columns[i].HeaderText = "Đấu thầu";
                    dataGridView1.Columns[i].Width = 20;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "GhiChu")
                {
                    dataGridView1.Columns[i].HeaderText = "Ghi chú";
                    dataGridView1.Columns[i].Width = 200;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "XuDong")
                {
                    dataGridView1.Columns[i].HeaderText = "Xứ đồng";
                    dataGridView1.Columns[i].Width = 40;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "Thue")
                {
                    dataGridView1.Columns[i].HeaderText = "Thuế";
                    dataGridView1.Columns[i].Width = 100;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "GiaDauThau")
                {
                    dataGridView1.Columns[i].HeaderText = "Giá đấu thầu";
                    dataGridView1.Columns[i].Width = 100;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "TienDaNop")
                {
                    dataGridView1.Columns[i].HeaderText = "Tiền đã nộp";
                    dataGridView1.Columns[i].Width = 100;
                    dataGridView1.Columns[i].Visible = true;
                }
            }
            Warning();
        }
        void Warning()
		 {
		 	if(dataGridView1.Rows.Count>0)
		 	{
		 		for(int i=0;i<dataGridView1.Rows.Count;i++)
		 		{
		 			 dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
		 		}
		 		for(int i=0;i<dataGridView1.Rows.Count;i++)
		 		{
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells["TrangThaiHoSo"].Value) == 7)
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                    else if(Convert.ToInt32( dataGridView1.Rows[i].Cells["TrangThaiHoSo"].Value) >= 8)
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    else if(dataGridView1.Rows[i].Cells["MaHoSoCapGCNDatNN"].Value.ToString() == "" || dataGridView1.Rows[i].Cells["MaHoSoCapGCNDatNN"].Value.ToString() == "0")
		 			    dataGridView1.Rows[i].DefaultCellStyle.BackColor =  SystemColors.Info;
                    else if(dataGridView1.Rows[i].Cells["MaSoGiaDinh"].Value.ToString() == "" || dataGridView1.Rows[i].Cells["MaSoGiaDinh"].Value.ToString() == "0")
		 			    dataGridView1.Rows[i].DefaultCellStyle.BackColor = SystemColors.Info;
		 		}
		 	}
		 }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MaHoSo = 0;
                MaSoGiaDinh = 0;
            }
            else if (e.Button == MouseButtons.Right)
                {
                    int index = e.RowIndex;
                    if (index < 0)
                        return;
                    Warning();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (i == index)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Maroon;
                        }
//                        else
//                        {
//                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
//                        }
                    }

                    MaHoSo = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    if (dataGridView1.Rows[index].Cells[1].Value != null)
                    {
                        if (dataGridView1.Rows[index].Cells[1].Value.ToString() != "")
                        {
                            MaSoGiaDinh = Convert.ToInt32(dataGridView1.Rows[index].Cells[1].Value);
                        }
                    }
                       
                
                }
        }

        
    }
}
