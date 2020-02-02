using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDatNongNghiep
{
    public partial class ctrlKeKhai : UserControl
    {
        public ctrlKeKhai()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        clsDatabase cls = new clsDatabase();
        private void ctrlKeKhai_Load(object sender, EventArgs e)
        {
            if (clsConfig.MaHoSo != 0)
            {
                FillData(clsConfig.MaHoSo);
            }
           
            LoadThongTinChu(clsConfig.MaGiaDinh);
            if (clsConfig.MaGiaDinh != 0)
                btnTaoHoGiaDinh.Enabled = false;
            else 
                btnTaoHoGiaDinh.Enabled = true;

            TrangThaiBanDau();
        }
        public void ReLoad()
        {
            if (clsConfig.MaHoSo != 0)
            {
                FillData(clsConfig.MaHoSo);
            }

            LoadThongTinChu(clsConfig.MaGiaDinh);
            if (clsConfig.MaGiaDinh != 0)
                btnTaoHoGiaDinh.Enabled = false;
            else
                btnTaoHoGiaDinh.Enabled = true;

            TrangThaiBanDau();
        }
        public void TaoHoSoMoi()
        {
            if (clsConfig.MaHoSo != 0)
            {
                FillData(clsConfig.MaHoSo);
            }
            else
            {
                string query = " INSERT INTO tblHoSoCapGCNDatNN (MaDonViHanhChinh,TrangThaiHoSo) " +
                                "  VALUES ('" + clsConfig.MaDonVihanhChinh + "' ,2) ";
                cls.ExecuteQueryInsertUpdateDelete(query);


                       query= " SELECT MAX(MaHoSoCapGCNDatNN) from tblHoSoCapGCNDatNN";
                clsConfig.MaHoSo = Convert.ToInt32(cls.ExecuteQueryScalar(query));
                FillData(clsConfig.MaHoSo);

            }
            
        }
       

        private void FillData(int MSHS)
        {
            ds.Tables.Clear();
            string query = " select * from tblThuaDatCapGCNDatNN where MaDonViHanhChinh ='" + clsConfig.MaDonVihanhChinh + "'  and MaHoSoCapGCNDatNN ='" + MSHS + "' ";
            ds = cls.ExecuteQuery(query);
            dataGridView1.DataSource = ds.Tables[0];
            DatagridviewStyle();
        }
        private void DatagridviewStyle()
        { 
            for(int i=0;i<dataGridView1.Columns.Count;i++)
            {
                if (dataGridView1.Columns[i].Name == "ID")
                {
                    dataGridView1.Columns[i].HeaderText = "ID";
                    dataGridView1.Columns[i].Width = 30;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "MaHoSoCapGCNDatNN")
                {
                    dataGridView1.Columns[i].HeaderText = "Mã hồ sơ";
                    dataGridView1.Columns[i].Width = 40;
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
        }
        int IDThuaDat = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TrangThaiBanDau()
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
                
                if(ctrl is TextBox )
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((TextBox)ctrl).ReadOnly = true;
                }
                else if(ctrl is RichTextBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((RichTextBox)ctrl).ReadOnly = true;
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((ComboBox)ctrl).AllowDrop = false;
                }
                else if (ctrl is NumericUpDown)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((NumericUpDown)ctrl).ReadOnly = true;
                }
                else if (ctrl is DateTimePicker)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((DateTimePicker)ctrl).Checked = false;
                }
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnThue.Enabled = false;

            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void TrangThaiChucNang()
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
                
                if (ctrl is TextBox)
                {
                    ctrl.BackColor = Color.White;
                    ((TextBox)ctrl).ReadOnly = false;
                    if (((TextBox)ctrl).Name == "txtChu")
                        ((TextBox)ctrl).ReadOnly = true;
                }
                else if (ctrl is RichTextBox)
                {
                    ctrl.BackColor = Color.White;
                    ((RichTextBox)ctrl).ReadOnly = false;
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.BackColor = Color.White;
                    ((ComboBox)ctrl).AllowDrop = true;
                }
            }
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnThue.Enabled = true;

            btnOK.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void TrangThaiKetThuc()
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
               
                if (ctrl is TextBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((TextBox)ctrl).ReadOnly = true;
                    ctrl.Text = "";
                }
                else if (ctrl is RichTextBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((RichTextBox)ctrl).ReadOnly = true;
                    ctrl.Text = "";
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((ComboBox)ctrl).AllowDrop = false;
                    ctrl.Text = "";
                }
                else if (ctrl is NumericUpDown)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((NumericUpDown)ctrl).ReadOnly = true;
                }
                else if (ctrl is DateTimePicker)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((DateTimePicker)ctrl).Checked = false;
                }
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnThue.Enabled = false;

            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }

        private int Work = 0;
        private void  LoadDefault()
        {
            txtMucDich.Text = "Sản xuất nông nghiệp";
            txtNguonGoc.Text = "Nhà nước giao";
            cmbLoaiDat.Text = "2 lúa";
            cmbLoaiThoiHan.Text = "Ổn định";
            txtThoiHan.Text = "20";
            txtThue.Text = "0";
            txtTienDaNop.Text = "0";
            txtDienTichChenhLech.Text = "0";
            txtGiaDauThau.Text = "0";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.Gold;
            Work = 1;
            LoadDefault();
            TrangThaiChucNang();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.BackColor = Color.Gold;
            Work = 2;
            TrangThaiChucNang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Work = 3;
            TrangThaiChucNang();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Work = 0;
            TrangThaiBanDau();
            
            btnThem.BackColor = btnSua.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] Paras = new string[]{"@ID","@MaHoSoCapGCNDatNN","@MaDonViHanhChinh","@ToBanDo","@SoThua","@XuDong","@DienTich","@DienTichTangGiam","@LoaiDat","@LoaiThoiHan","@ThoiHan","@Thue","@GhiChu","@NguonGoc","@MucDich"};
            string[] Values = new string[]{IDThuaDat.ToString() ,clsConfig.MaHoSo.ToString(),clsConfig.MaDonVihanhChinh, txtTo.Text.Trim(),txtThua.Text.Trim(),txtXuDong.Text.Trim(),txtDienTich.Text.Trim(), txtDienTich.Text.Trim(),txtDienTichChenhLech.Text.Trim(), cmbLoaiDat.Text.Trim(),
                                                                                                            cmbLoaiThoiHan.Text.Trim(),txtThoiHan.Text.Trim(),txtThue.Text.Trim(), txtNguonGoc.Text.Trim(),txtMucDich.Text.Trim()};
            string spName;
            switch(Work)
            {

                case 1:
                    {
                        spName = "spThemThuaDatNN";
                        int kq = cls.ExecuteSP(spName, Paras, Values);
                        if(kq>0)
                        {
                            MessageBox.Show("Thêm thành công " + kq.ToString() + " thửa đất vào hồ sơ ");
                        }
                        else
                        {
                            MessageBox.Show("Không thêm được thửa đất nào");
                        }    
                        break;
                    }
                case 2:
                    {
                        if(IDThuaDat == 0)
                        {
                            MessageBox.Show("Bạn cần chọn thửa đất để thao tác!");
                            return;
                        }
                        spName = "spUpdateThuaDatNN";
                        int kq = cls.ExecuteSP(spName, Paras, Values);
                        if (kq > 0)
                        {
                            MessageBox.Show("Update thành công " + kq.ToString() + " thửa đất trong hồ sơ");
                        }
                        else
                        {
                            MessageBox.Show("Không Update thành công");
                        }    
                        break;
                    }
                case 3:
                    {
                        if (IDThuaDat == 0)
                        {
                            MessageBox.Show("Bạn cần chọn thửa đất để thao tác!");
                            return;
                        }
                        spName = "spXoaThuaDatNN";
                        int kq = cls.ExecuteSP(spName, Paras, Values);
                        if (kq > 0)
                        {
                            MessageBox.Show(" Xóa thành công " + kq.ToString() + " thửa đất trong hồ sơ");
                        }
                        else
                        {
                            MessageBox.Show("Không Xóa thành công");
                        }    
                        break;
                    }
               
            }

            TrangThaiKetThuc();
            Work = 0;
            btnThem.BackColor = btnSua.BackColor = System.Drawing.SystemColors.Control ;
            ReLoad();
        }

        private void btnTaoHoGiaDinh_Click(object sender, EventArgs e)
        {
           
            frmGiaDinh frm = new frmGiaDinh();
            this.Hide();
            frm.ShowDialog();
            ((frmHOSO)this.ParentForm).Status(clsConfig.TrangThaiHoSo);// goị hàm satus từ form chứa nó.
            ((frmHOSO)this.ParentForm).KiemTraCheckDone(2);
            this.Show();
            LoadThongTinChu(clsConfig.MaGiaDinh);            
        }

        private void LoadThongTinChu(int MaGD)
        {
            if(MaGD !=0)
            {
                string query = "select NguoiDaiDien from tblHoGiaDinh where MaSoGiaDinh = '" + clsConfig.MaGiaDinh + "' ";
                if (cls.ExecuteQueryScalar(query) != "")
                {

                    txtChu.Text = cls.ExecuteQueryScalar(query);
                }
            }
            

        }

        

        private void cmbLoaiThoiHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiThoiHan.Text == "Thuê, đấu thầu")
            {
                label10.Enabled = true;
                label12.Enabled = true;
                btnThue.Enabled = true;
                txtThue.Enabled = true;
            }
            else
            {
                label10.Enabled = false;
                label12.Enabled = false;
                btnThue.Enabled = false;
                txtThue.Enabled = false;
            }
        }

        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            IDThuaDat = Convert.ToInt32(dataGridView1.Rows[index].Cells["ID"].Value);

            txtTo.Text = dataGridView1.Rows[index].Cells["ToBanDo"].Value.ToString();
            txtThua.Text = dataGridView1.Rows[index].Cells["SoThua"].Value.ToString();
            txtXuDong.Text = dataGridView1.Rows[index].Cells["XuDong"].Value.ToString();
            txtDienTich.Text = dataGridView1.Rows[index].Cells["DienTich"].Value.ToString();
            txtDienTichChenhLech.Text = dataGridView1.Rows[index].Cells["DienTichTangGiam"].Value.ToString();
            cmbLoaiDat.Text = dataGridView1.Rows[index].Cells["LoaiDat"].Value.ToString();
            cmbLoaiThoiHan.Text = dataGridView1.Rows[index].Cells["LoaiThoiHan"].Value.ToString();
            txtThoiHan.Text = dataGridView1.Rows[index].Cells["ThoiHan"].Value.ToString();
            rtbGhiChu.Text = dataGridView1.Rows[index].Cells["GhiChu"].Value.ToString();
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            if (IDThuaDat == 0)
            {
                MessageBox.Show("Bạn cần chọn thửa đất để thao tác!");
                return;
            }
            frmNopTien frm = new frmNopTien();
            frm.IDThuaDat = IDThuaDat;
            frm.ShowDialog();
            // reload o day.
        }

        
    }
}
