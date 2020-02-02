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
    public partial class frmQuanLyHoSo : Form
    {
        public frmQuanLyHoSo()
        {
            InitializeComponent();
        }

       
        string query = "";
        private void FillData()
        {
            string[] Paras = new string[] { "@MaDonViHanhChinh", "@Thon", "@LoaiThoiHan", "@TrangThaiHoSo", "@BaoXoa"     ,"@TenNguoi","@DiaChi","@ToBanDo","@SoThua","@flag" };
            string[] Values = new string[] { MaDVHC, Thon, LoaiThoiHan, TrangThai, isBaoXoa,           TenNguoi,DiaChi,ToBanDo,SoThua ,_flag.ToString()};
            dataGridView1.DataSource = cls.GetData("spQuanLyHoSo", Paras, Values).Tables[0];
            StyleDatagridview();
            CountHoSo();

        }
        private void StyleDatagridview()
        {
          
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["BaoXoa"].Value.ToString().ToLower() == "true")
                     dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                else if(Convert.ToInt32( dataGridView1.Rows[i].Cells["TrangThaiHoSo"].Value)> 7)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            }
            

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Columns[i].Name == "MaHoSoCapGCNDatNN")
                    {
                        dataGridView1.Columns[i].HeaderText = "Mã hồ sơ";
                        dataGridView1.Columns[i].Width = 70;
                    }
                    if (dataGridView1.Columns[i].Name == "MaDonViHanhChinh")
                    {
                        dataGridView1.Columns[i].HeaderText = "Mã xã";
                        dataGridView1.Columns[i].Width = 80;
                    }
                    if (dataGridView1.Columns[i].Name == "DienTich")
                    {
                        dataGridView1.Columns[i].HeaderText = "Diện tích";
                        dataGridView1.Columns[i].Width = 90;
                    }
                    if (dataGridView1.Columns[i].Name == "TrangThaiHoSo")
                    {
                        dataGridView1.Columns[i].HeaderText = "Trạng thái";
                        dataGridView1.Columns[i].Width = 70;
                    }
                    if (dataGridView1.Columns[i].Name == "BaoXoa")
                    {
                        dataGridView1.Columns[i].HeaderText = "Báo xóa";
                        dataGridView1.Columns[i].Width = 70;
                    }
                    if (dataGridView1.Columns[i].Name == "NgayCapGCN")
                    {
                        dataGridView1.Columns[i].HeaderText = "Ngày cấp GCN";
                        dataGridView1.Columns[i].Width = 90;
                    }
                    if (dataGridView1.Columns[i].Name == "NgayNhapLieu")
                    {
                        dataGridView1.Columns[i].HeaderText = "Ngày nhập";
                        dataGridView1.Columns[i].Width = 90;
                    }
                    if (dataGridView1.Columns[i].Name == "NguoiDaiDien")
                    {
                        dataGridView1.Columns[i].HeaderText = "Người đại diện";
                        dataGridView1.Columns[i].Width = 200;
                    }
                    if (dataGridView1.Columns[i].Name == "ThanhVien")
                    {
                        dataGridView1.Columns[i].HeaderText = "Thành viên";
                        dataGridView1.Columns[i].Width = 200;
                    }
                    if (dataGridView1.Columns[i].Name == "SoNguoi")
                    {
                        dataGridView1.Columns[i].HeaderText = "Số người";
                        dataGridView1.Columns[i].Width = 70;
                    }
                    if (dataGridView1.Columns[i].Name == "DiaChi")
                    {
                        dataGridView1.Columns[i].HeaderText = "Địa chỉ";
                        dataGridView1.Columns[i].Width = 150;
                    }
                    if (dataGridView1.Columns[i].Name == "KhauChinhThuc")
                    {
                        dataGridView1.Columns[i].HeaderText = "Số khẩu";
                        dataGridView1.Columns[i].Width = 70;
                    }
                    if (dataGridView1.Columns[i].Name == "KhauXemXet")
                    {
                        dataGridView1.Columns[i].HeaderText = "Khẩu xem xét";
                        dataGridView1.Columns[i].Width = 70;
                    }
                    if (dataGridView1.Columns[i].Name == "Thon")
                    {
                        dataGridView1.Columns[i].HeaderText = "Thôn";
                        dataGridView1.Columns[i].Width = 170;
                    }
                    if (dataGridView1.Columns[i].Name == "ToBanDo")
                    {
                        dataGridView1.Columns[i].HeaderText = "Tờ bản đồ";
                        dataGridView1.Columns[i].Width = 70;
                    }
                    if (dataGridView1.Columns[i].Name == "SoThua")
                    {
                        dataGridView1.Columns[i].HeaderText = "Số thửa";
                        dataGridView1.Columns[i].Width = 70;
                    }
                }
        }
        private void frmQuanLyHoSo_Load(object sender, EventArgs e)
        {
            frmXacNhanQuyenQuanLy quyen = new frmXacNhanQuyenQuanLy();
            this.Hide();
            quyen.ShowDialog();
            if (quyen.Quyen == 1)
            {
                //MessageBox.Show("-Bạn có quyền tra cứu thông tin.\n-Không có quyền xóa hồ sơ.");
                btnXoaHoSo.Visible = false;
            }
            else
                if (quyen.Quyen == 10)
                {
                    //MessageBox.Show("-Bạn có quyền tra cứu thông tin và có quyền xóa hồ sơ.");
                    btnXoaHoSo.Visible = true;
                }
                else
                {
                    foreach (Control ctrl in this.Controls)
                        if(ctrl.Name != "Refresh")
                            ctrl.Visible = false;
                }
            this.Show();
            reLoad();
        }
        private void reLoad()
        {            
            LoadDVHC();
            LoadTrangThaiHS();
            LoadLoaiThoiHan();
            //FillData();
        }
        clsDatabase cls = new clsDatabase();
        DataSet ds = new DataSet();

        string MaHoSo = "";
        string MaDVHC ="";
        string Thon = "";
        string LoaiThoiHan = "";
        string TrangThai = "";
        string isBaoXoa = "";

        string TenNguoi = "";
        string DiaChi = "";
        string ToBanDo = "";
        string SoThua = "";

        int _flag = 0;

        private void LoadDVHC()
        {
            try
            {
                cmbDVHC.Items.Add("A");
                ds.Tables.Clear();
                string qr = " select MaDonViHanhChinh,Ten from tblTuDienDonViHanhChinh where MaHuyen <> '0' and MaXa <> '0' order by Ten asc ";
                ds = cls.ExecuteQuery(qr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    /* Lưu ý, 
                     * luôn luôn để 2 trường xác định 
                     * cmbDVHC.ValueMember = "MaDonViHanhChinh";
                     * cmbDVHC.DisplayMember = "Ten"; 
                     
                     * hoặc
                     * cmbDVHC.DisplayMember = "Value";
                     * cmbDVHC.ValueMember = "Key";
                     * 
                     * lên trước khi đặt nguồn dữ liệu,
                     * 
                     * như vậy thì sự kiện cmbDVHC_SelectedIndexChanged không tự động nhảy vào khi bắt đầu load và sinh ra lỗi
                     * 
                     */
                    #region "cách này không thể add trường tùy ý thêm vào combobox"
                    //cmbDVHC.ValueMember = "MaDonViHanhChinh";
                    //cmbDVHC.DisplayMember = "Ten"; 
                    //dataGridView1.DataSource = ds.Tables[0];
                    //cmbDVHC.DataSource = ds.Tables[0];
                    #endregion

                    #region "cách này chủ động hơn!"
                    Dictionary<string, string> dsDVHC = new Dictionary<string, string>();
                    dsDVHC.Add("", "");
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dsDVHC.Add(ds.Tables[0].Rows[i]["MaDonViHanhChinh"].ToString(), ds.Tables[0].Rows[i]["Ten"].ToString());
                    }
                    cmbDVHC.DisplayMember = "Value";
                    cmbDVHC.ValueMember = "Key";
                    cmbDVHC.DataSource = new BindingSource(dsDVHC, null);
                    #endregion


                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
        private void LoadLoaiThoiHan()
        {
            //try
            //{
            //    ds.Tables.Clear();
            //    string qr = " select distinct LoaiThoiHan from tblThuaDatCapGCNDatNN ";
            //    ds = cls.ExecuteQuery(qr);
            //    if (ds.Tables[0].Rows.Count > 0)
            //    {
            //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //        {
            //            cmbDVHC.Items.Add(ds.Tables[0].Rows[i]["LoaiThoiHan"].ToString().Trim());

            //        }
            //    }
            //   
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void LoadTrangThaiHS()
        {
            try
            {
                ds.Tables.Clear();
                string qr = " select MaTrangThai,TenTrangThai from tblTrangThaiHoSoDatNN ";
                ds = cls.ExecuteQuery(qr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                   
                    Dictionary<string, string> dsDVHC = new Dictionary<string, string>();
                    dsDVHC.Add("", "");
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dsDVHC.Add(ds.Tables[0].Rows[i]["MaTrangThai"].ToString(), ds.Tables[0].Rows[i]["TenTrangThai"].ToString());
                    }
                    cmbTrangThaiHS.DisplayMember = "Value";
                    cmbTrangThaiHS.ValueMember = "Key";
                    cmbTrangThaiHS.DataSource = new BindingSource(dsDVHC, null);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void LoadThon()
        {
            if (MaDVHC != "0")
                query = " select distinct Thon from tblHoGiaDinh where MaDonViHanhChinh = '" + MaDVHC+"' ";            
            else 
                query = " select distinct Thon from tblHoGiaDinh ";

            try {
                cmbThon.Items.Clear();
                cmbThon.Items.Add("");
                ds = cls.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count;i++ )
                    {
                        cmbThon.Items.Add(ds.Tables[0].Rows[i]["Thon"].ToString());
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
       
        private void btnXoaHoSo_Click(object sender, EventArgs e)
        {
            if (MaHoSo.Trim() == "")
            {
                MessageBox.Show("chưa chọn hồ sơ!");
                return;
            }
            //string qr = " select NguoiDaiDien from tblHoGiaDinh where MaHoGiaDinh = (select MaHoGiaDinh from tblHoSoCapGCNDatNN where MaHoSoCapGCNDatNN =" + MaHoSo + ")";
            //if (MessageBox.Show("Bạn có chắc muốn xóa hồ sơ của gia đình Ông(Bà) "+cls.ExecuteQueryScalar(qr) +" không?","Xóa.",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            
            if (MessageBox.Show("Bạn có chắc muốn xóa hồ sơ" + MaHoSo + " không?", "Xóa.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string qr = "delete from tblHoSoCapGCNDatNN where  MaHoSoCapGCNDatNN =" + MaHoSo + "";
                int kq =Convert.ToInt32( cls.ExecuteQueryInsertUpdateDelete(qr));
                if (kq > 0)
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Error!");

                FillData();
            }
        }




        private void cmbDVHC_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaDVHC = cmbDVHC.SelectedValue.ToString();            
            LoadThon();
            FillData();
        }
       
        private void cmbThon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thon = cmbThon.SelectedValue.ToString();
            FillData();
        }

        private void cmbLoaiThoiHan_SelectedIndexChanged(object sender, EventArgs e)
        {
           // LoaiThoiHan = cmbLoaiThoiHan.SelectedValue.ToString();
            //FillData();
        }

        private void cmbTrangThaiHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrangThai = cmbTrangThaiHS.SelectedValue.ToString();
            FillData();
        }

        private void chkHoSoBaoXoa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHoSoBaoXoa.Checked == true)
                isBaoXoa = "1";
            else
                isBaoXoa = "0";
            FillData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["BaoXoa"].Value.ToString());
            MaHoSo = dataGridView1.Rows[e.RowIndex].Cells["MaHoSoCapGCNDatNN"].Value.ToString();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            frmXacNhanQuyenQuanLy quyen = new frmXacNhanQuyenQuanLy();
            this.Hide();
            quyen.ShowDialog();
            if (quyen.Quyen == 1)
            {
                //MessageBox.Show("-Bạn có quyền tra cứu thông tin.\n-Không có quyền xóa hồ sơ.");
                btnXoaHoSo.Visible = false;
            }
            else
                if (quyen.Quyen == 10)
                {
                    //MessageBox.Show("-Bạn có quyền tra cứu thông tin và có quyền xóa hồ sơ.");
                    btnXoaHoSo.Visible = true;
                }
                else
                {
                    foreach (Control ctrl in this.Controls)
                        if (ctrl.Name != "Refresh")
                            ctrl.Visible = false;
                }
            this.Show();
        }

        private void txtTenNguoi_TextChanged(object sender, EventArgs e)
        {
            TenNguoi = txtTenNguoi.Text.Trim();
            FillData();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            DiaChi = txtDiaChi.Text.Trim();
            FillData();
        }

        private void txtTBD_TextChanged(object sender, EventArgs e)
        {
            if (txtTBD.Text.Trim() != "" || txtThua.Text.Trim() != "")
            {
                _flag = 1;
                ToBanDo = txtTBD.Text.Trim();
                FillData();

            }
            else
            {
                _flag = 0;
                FillData();
            }
        }

        private void txtThua_TextChanged(object sender, EventArgs e)
        {
            if (txtTBD.Text.Trim() != "" || txtThua.Text.Trim() != "")
            {
                _flag = 1;
                SoThua = txtThua.Text.Trim();
                FillData();

            }
            else
            {
                _flag = 0;
                FillData();
            }
        }
        private void CountHoSo()
        {
            lblKQ.Text = "Tổng số: " + dataGridView1.Rows.Count + " hồ sơ. ";
            if (_flag == 1)
                lblKQ.Text = "Không đếm được số lượng hồ sơ nếu có tờ bản đồ hoặc số thửa";
        }

    }
}
