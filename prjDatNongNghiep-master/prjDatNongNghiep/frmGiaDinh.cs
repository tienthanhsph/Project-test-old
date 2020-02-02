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
    public partial class frmGiaDinh : Form
    {
        public frmGiaDinh()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        #region "3 trang thai doi voi tab Giadinh"
        private void TrangThaiBanDau()
        {
            foreach (Control ctrl in groupBox4.Controls)
            {

                if (ctrl is TextBox)
                {
                	
                    ctrl.BackColor = Color.LemonChiffon;
                    ((TextBox)ctrl).ReadOnly = true;
                }
                else if (ctrl is RichTextBox)
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
            btnThemNK.Enabled = true;
            btnSuaNK.Enabled = true;
            btnXoaNK.Enabled = true;

            btnOKNK.Enabled = false;
            btnCancelNK.Enabled = false;
        }
        private void TrangThaiChucNang()
        {
            foreach (Control ctrl in groupBox4.Controls)
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
                else if (ctrl is NumericUpDown)
                {
                    ctrl.BackColor = Color.White;
                    ((NumericUpDown)ctrl).ReadOnly = false;
                }
            }
            btnThemNK.Enabled = false;
            btnSuaNK.Enabled = false;
            btnXoaNK.Enabled = false;

            btnOKNK.Enabled = true;
            btnCancelNK.Enabled = true;

            txtDaiDien.ReadOnly = true;
        }
        private void TrangThaiKetThuc()
        {
            foreach (Control ctrl in groupBox4.Controls)
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
            btnThemNK.Enabled = true;
            btnSuaNK.Enabled = true;
            btnXoaNK.Enabled = true;


            btnOKNK.Enabled = false;
            btnCancelNK.Enabled = false;

            HienThiNguoiDaiDien();
        }
#endregion

        #region "3 trang thai doi voi tab Nhan Khau"
        private void TrangThaiBanDau_nk()
        {
            foreach (Control ctrl in groupBox1.Controls)
            {

                if (ctrl is TextBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((TextBox)ctrl).ReadOnly = true;
                }
                else if (ctrl is RichTextBox)
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
            btnThemNK.Enabled = true;
            btnSuaNK.Enabled = true;
            btnXoaNK.Enabled = true;

            btnOKNK.Enabled = false;
            btnCancelNK.Enabled = false;
        }
        private void TrangThaiChucNang_nk()
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
            btnThemNK.Enabled = false;
            btnSuaNK.Enabled = false;
            btnXoaNK.Enabled = false;

            btnOKNK.Enabled = true;
            btnCancelNK.Enabled = true;
        }
        private void TrangThaiKetThuc_nk()
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
            btnThemNK.Enabled = true;
            btnSuaNK.Enabled = true;
            btnXoaNK.Enabled = true;


            btnOKNK.Enabled = false;
            btnCancelNK.Enabled = false;

            HienThiNguoiDaiDien();
        }
        #endregion


        #region "Chuc nang doi voi tab GiaDinh"
        int Work = 0;
        int Work_nk = 0;
        private void ChonHoGiaDinhChoHoSo(int MaHS, int MaGD)
        {
        	string query ="spThayDoiHoGiaDinh";
        	int kq = cls.ExecuteSP(query, new string[]{"@MaHoSoCapGCNDatNN","@MaSoGiaDinh"}, new string[]{MaHS.ToString(), MaGD.ToString()});
        	if(kq>0)
        		MessageBox.Show("Gán thành công hộ gia đình cho hồ sơ ");
        	else
        	{ 
        		MessageBox.Show("Không thành công!");
        	}
        }
        private void LoadCmbThon()
        {
            string query = " select Distinct Thon from tblHoGiaDinh where MaDonViHanhChinh =" + clsConfig.MaDonVihanhChinh.ToString();
            string[] DsThon = cls.GetList(query, "Thon");
            cmbThon.Items.Clear();
            if (DsThon.Length > 0)
            {
                for (int i = 0; i < DsThon.Length; i++)
                    cmbThon.Items.Add(DsThon[i]);
            }
        }
        private void frmGiaDinh_Load(object sender, EventArgs e)
        {
            LoadCmbThon();
        	txtTongDienTich.Visible=txtTongHopThue.Visible=label7.Visible=label8.Visible = false;
            btnThem.Visible = false;
            if(clsConfig.MaGiaDinh != 0)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                LoadThongTinGiaDinh(clsConfig.MaGiaDinh);
                FillData(clsConfig.MaGiaDinh);
            }
            else
            {
            	DialogResult result = MessageBox.Show("- YES nếu muốn tạo hộ gia đình mới \n- NO nếu muốn tra cứu trong những hộ gia đình có sẵn","Chưa có thông tin hộ gia đình",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            	if(result == DialogResult.Yes)
            	{
	            	ThemHoGiaDinh();
	                btnThem.Enabled = true;
	                btnSua.Enabled = true;
	                btnXoa.Enabled = true;
            	}
                else if(result == DialogResult.No)
                {
                	frmTimKiemHoGiaDinh frm = new frmTimKiemHoGiaDinh();
                	frm.ShowDialog();
                	if(frm.MaSoGiaDinh != 0)
                	{
                		btnThem.Enabled = false;
		                btnSua.Enabled = true;
		                btnXoa.Enabled = true;
		                clsConfig.MaGiaDinh = frm.MaSoGiaDinh;
		                ChonHoGiaDinhChoHoSo(clsConfig.MaHoSo, clsConfig.MaGiaDinh);
		                LoadThongTinGiaDinh(clsConfig.MaGiaDinh);
		                FillData(clsConfig.MaGiaDinh);
                		
                	}
                }
            }
               

            TrangThaiBanDau();
            TrangThaiBanDau_nk();
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            
            dtpNgayCapCMND.Format=DateTimePickerFormat.Custom;
            dtpNgayCapCMND.CustomFormat="dd/MM/yyyy";

            HienThiNguoiDaiDien();
        }
        
        private void FillData(int MaGD)
        {
            string query = " select * from tblNguoi where MaSoGiaDinh ='" + MaGD + "' ";
            clsDatabase cls = new clsDatabase();
            DataSet ds = cls.ExecuteQuery(query);
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
                if (dataGridView1.Columns[i].Name == "HoTen")
                {
                    dataGridView1.Columns[i].HeaderText = "Họ tên";
                    dataGridView1.Columns[i].Width = 150;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "DiaChi")
                {
                    dataGridView1.Columns[i].HeaderText = "Địa chỉ";
                    dataGridView1.Columns[i].Width = 300;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "CMND")
                {
                    dataGridView1.Columns[i].HeaderText = "CMND";
                    dataGridView1.Columns[i].Width = 100;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "CoKhau")
                {
                    dataGridView1.Columns[i].HeaderText = "Có khẩu";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "MaSo_in_tblChu")
                {
                    dataGridView1.Columns[i].HeaderText = "MaSo_in_tblChu";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = false;
                }
                if (dataGridView1.Columns[i].Name == "ID")
                {
                    dataGridView1.Columns[i].HeaderText = "ID";
                    dataGridView1.Columns[i].Width = 30;
                    dataGridView1.Columns[i].Visible = false;
                }
                //if (dataGridView1.Columns[i].Name == "MaHoSoCapGCNDatNN")
                //{
                //    dataGridView1.Columns[i].HeaderText = "Mã hồ sơ";
                //    dataGridView1.Columns[i].Width = 40;
                //    dataGridView1.Columns[i].Visible = true;
                //}
                if (dataGridView1.Columns[i].Name == "isNguoiDaiDien")
                {
                    dataGridView1.Columns[i].HeaderText = "Đại diện GĐ";
                    dataGridView1.Columns[i].Width = 60;
                    dataGridView1.Columns[i].Visible = true;
                }
                
            }
        }
        private void ThemHoGiaDinh()
        { 
         string[] Paras = new string[] { "@MaSoGiaDinh", "@DaiDien", "@ThanhVien","@SoNguoi", "@DiaChi", "@KhauChinhThuc", "@KhauXemXet", "@GhiChu" };
            string[] Values = new string[]{"","","","", "", "", "",""};
            string spName;
            
            spName = "spThemHoGiaDinh";
            int kq = cls.ExecuteSP(spName, Paras, Values);
            if (kq > 0)
            {
                //MessageBox.Show("Đã thêm " + kq.ToString() + " hộ gia đình");
                string query = " select Max(MaSoGiaDinh) from tblHoGiaDinh ";
                clsConfig.MaGiaDinh =Convert.ToInt32( cls.ExecuteQueryScalar(query));
                btnThem.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không thêm được hộ gia đình nào!");
            }
                        
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Work = 1;
            TrangThaiChucNang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Work =2;
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
            LoadThongTinGiaDinh(clsConfig.MaGiaDinh);
            
        }

        private void UpdateHoSoCapGCNDatNN()
        {
            try
            {
                string[] Paras = new string[] { "@MaHoSoCapGCNDatNN", "@flag" };
                string[] Values = new string[] { clsConfig.MaHoSo.ToString(), "1" };
                string spName = "SpUpdatetblHoSoCapGCNDatNN";
                cls.ExecuteSP(spName, Paras, Values);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] Paras = new string[] {"@MaHoSoCapGCNDatNN","@MaDonViHanhChinh","@MaSoGiaDinh", "@DaiDien", "@ThanhVien","@SoNguoi", "@DiaChi", "@KhauChinhThuc", "@KhauXemXet", "@GhiChu" ,"@Thon"};
            string[] Values = new string[]{clsConfig.MaHoSo.ToString(), clsConfig.MaDonVihanhChinh.ToString(), clsConfig.MaGiaDinh.ToString(), txtDaiDien.Text.Trim(),"", nbrSoNguoi.Value.ToString(), txtDiaChi.Text.Trim(), nbrKhauChinhThuc.Value.ToString(),
                                                                   nbrKhauXemXet.Value.ToString(), rtbGhiChu.Text.Trim(),cmbThon.Text.Trim()};
            string spName;
            switch (Work)
            {

                case 1:
                    {
                        spName = "spThemHoGiaDinh";
                        int kq = cls.ExecuteSP(spName, Paras, Values);
                        if (kq > 0)
                        {
                            //MessageBox.Show("Đã thêm " + kq.ToString() + " hộ gia đình");
                            string query = " select Max(MaSoGiaDinh) from tblHoGiaDinh ";
                            clsConfig.MaGiaDinh =Convert.ToInt32( cls.ExecuteQueryScalar(query));
                            btnThem.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Không thêm được hộ gia đình nào!");
                        }
                        break;
                    }
                case 2:
                    {
                        spName = "spUpdateHoGiaDinh";
                        int kq = cls.ExecuteSP(spName, Paras, Values);
                        if (kq > 0)
                        {
                            //MessageBox.Show("Update thành công thông tin " + kq.ToString() + " hộ gia đình");
                        }
                        else
                        {
                            MessageBox.Show("Không Update thành công");
                        }
                        break;
                    }
                case 3:
                    {
                        spName = "spXoaHoGiaDinh";
                        int kq = cls.ExecuteSP(spName, Paras, Values);
                        if (kq > 0)
                        {
                            //MessageBox.Show(" Xóa thành công " + kq.ToString() + " hộ gia đình");
                        }
                        else
                        {
                            MessageBox.Show("Không Xóa thành công");
                        }
                        break;
                    }

            }

            TrangThaiKetThuc();
            UpdateHoSoCapGCNDatNN();
            THTT();
            Work = 0;
            LoadThongTinGiaDinh(clsConfig.MaGiaDinh);
        }
        private void LoadThongTinGiaDinh(int MGD)
        {
            string query = "Select * from tblHoGiaDinh where MaSoGiaDinh =" + MGD.ToString();
            DataSet ds = cls.ExecuteQuery(query);
            txtDaiDien.Text = ds.Tables[0].Rows[0]["NguoiDaiDien"].ToString();
            nbrKhauChinhThuc.Value =Convert.ToInt32(ds.Tables[0].Rows[0]["KhauChinhThuc"].ToString());
            nbrKhauXemXet.Value=Convert.ToInt32(ds.Tables[0].Rows[0]["KhauXemXet"].ToString());
            nbrSoNguoi.Value=Convert.ToInt32(ds.Tables[0].Rows[0]["SoNguoi"].ToString());
            txtDiaChi.Text=ds.Tables[0].Rows[0]["DiaChi"].ToString();
            rtbGhiChu.Text=ds.Tables[0].Rows[0]["GhiChu"].ToString();
            cmbThon.Text = ds.Tables[0].Rows[0]["Thon"].ToString();
        }

        #endregion

        #region "Chuc nang doi voi tab Nhan Khau"
        private void btnThemNK_Click(object sender, EventArgs e)
        {
            Work_nk = 1;
            TrangThaiChucNang_nk();
            txtHoTen.Text ="";
            txtHoKhau.Text ="";
            txtCMND.Text ="";
            txtNoiCapCMND.Text ="";
            txtDiaChiNguoi.Text ="";
            
        }

        private void btnSuaNK_Click(object sender, EventArgs e)
        {
            if(IDNguoi!= 0)
            {
                Work_nk = 2;
                TrangThaiChucNang_nk();
            }
            
        }

        private void btnXoaNK_Click(object sender, EventArgs e)
        {
            if (IDNguoi != 0)
            {
                Work_nk = 3;
                TrangThaiChucNang_nk();
            }
           
        }

        private void btnCancelNK_Click(object sender, EventArgs e)
        {
            Work_nk = 0;
            TrangThaiBanDau_nk();
            IDNguoi = 0;
            //LoadThongTinVeNguoi(IDNguoi);
        }

        private void HienThiNguoiDaiDien()
        {
            try
            {
                string query = " select HoTen from tblNguoi where MaSoGiaDinh ='" + clsConfig.MaGiaDinh + "'  and IsNguoiDaiDien = 1 ";
                if (cls.ExecuteQueryScalar(query) != null)
                {
                    txtDaiDien.Text = cls.ExecuteQueryScalar(query);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnOKNK_Click(object sender, EventArgs e)
        {
            string _NgaySinh = "";
            if (dtpNgaySinh.Checked == true)
                _NgaySinh = dtpNgaySinh.Value.ToString();
            string _NgayCapCMND = "";
            if(dtpNgayCapCMND.Checked== true)
                _NgayCapCMND = dtpNgayCapCMND.Value.ToString();
            string[] Paras = new string[] { "@ID", "@MaSoGiaDinh", "@HoTen", "@CMND", "@NgaySinh", "@DiaChi","@IsNguoiDaiDien", "@CoKhau","@HoKhau","@NgayCapCMND","@NoiCapCMND" };
            string[] Values = new string[]{IDNguoi.ToString(),clsConfig.MaGiaDinh.ToString(), txtHoTen.Text.Trim(), txtCMND.Text.Trim(), _NgaySinh,
            	txtDiaChiNguoi.Text.Trim(), (chkDaiDien.Checked? true: false).ToString(),  (chkCoKhau.Checked? true: false).ToString(),txtHoKhau.Text.Trim(), _NgayCapCMND, txtNoiCapCMND.Text.Trim()};
            string spName;
            switch (Work_nk)
            {

                case 1:
                    {
                        spName = "spThemNguoi";
                        int kq = cls.ExecuteSP(spName, Paras, Values);
                        if (kq > 0)
                        {
                           // MessageBox.Show("Thêm thành công " + kq.ToString() + " thành viên vào gia đình");
                        }
                        else
                        {
                            MessageBox.Show("Không thêm được");
                        }
                        break;
                    }
                case 2:
                    {
                        spName = "spUpdateNguoi";
                        int kq = cls.ExecuteSP(spName, Paras, Values);
                        if (kq > 0)
                        {
                           // MessageBox.Show("Update thành công thông tin " + kq.ToString() + " thành viên");
                        }
                        else
                        {
                            MessageBox.Show("Không Update thành công");
                        }
                        break;
                    }
                case 3:
                    {
                        spName = "spXoaNguoi";
                        int kq = cls.ExecuteSP(spName, Paras, Values);
                        if (kq > 0)
                        {
                            MessageBox.Show(" Xóa thành công " + kq.ToString() + " người");
                        }
                        else
                        {
                            MessageBox.Show("Không Xóa thành công");
                        }
                        break;
                    }

            }

            TrangThaiKetThuc_nk();
            UpdatetblHoGiaDinh(clsConfig.MaGiaDinh);
            FillData(clsConfig.MaGiaDinh);
            IDNguoi = 0;
            Work_nk = 0;
        }
        private void UpdatetblHoGiaDinh(int MaGD)
        { 
            string[] Paras = new string[]{"@MaSoGiaDinh"};
            string[] Values = new string[]{MaGD.ToString()};
            cls.ExecuteSP("spUpdatetblHoGiaDinh",Paras,Values);
        }
        int IDNguoi = 0;
        //private void LoadThongTinVeNguoi(int ID)
        //{
        //    string query = " select top(1) HoTen, CMND, DiaChi,NgaySinh,IsNguoiDaiDien,CoKhau from tblNguoi where ID ='" + ID + "' ";
            
        //}

        
        #endregion

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TrangThaiBanDau_nk();
            int index = dataGridView1.CurrentRow.Index;
            IDNguoi = Convert.ToInt32(dataGridView1.Rows[index].Cells["ID"].Value.ToString());            
            txtHoTen.Text = dataGridView1.Rows[index].Cells["HoTen"].Value.ToString();
            txtCMND.Text = dataGridView1.Rows[index].Cells["CMND"].Value.ToString();
            if (dataGridView1.Rows[index].Cells["NgaySinh"].Value.ToString() != "")
            {
                dtpNgaySinh.Text = dataGridView1.Rows[index].Cells["NgaySinh"].Value.ToString();
                dtpNgaySinh.Checked = true;
            }
            else
                dtpNgaySinh.Checked = false;
            chkCoKhau.Checked = Convert.ToBoolean(dataGridView1.Rows[index].Cells["CoKhau"].Value);
            chkDaiDien.Checked = Convert.ToBoolean(dataGridView1.Rows[index].Cells["isNguoiDaiDien"].Value);
            if (dataGridView1.Rows[index].Cells["NgayCapCMND"].Value.ToString() != "")
            {
                dtpNgayCapCMND.Checked = true;
                dtpNgayCapCMND.Text = dataGridView1.Rows[index].Cells["NgayCapCMND"].Value.ToString();
            }
            else
                dtpNgayCapCMND.Checked = false;
            txtNoiCapCMND.Text=dataGridView1.Rows[index].Cells["NoiCapCMND"].Value.ToString();
            txtDiaChiNguoi.Text = dataGridView1.Rows[index].Cells["DiaChi"].Value.ToString();
            txtHoKhau.Text =dataGridView1.Rows[index].Cells["HoKhau"].Value.ToString();
            
        }

        public delegate void UpdateTongHopThongTinHandler(object sender, EventArgs e);
        public event UpdateTongHopThongTinHandler OnTHTT;
        private void THTT()
        {
            if (OnTHTT != null)
                OnTHTT(this, null);
        }
		void TxtCMNDTextChanged(object sender, EventArgs e)
		{
	
		}
		void GroupBox1Enter(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		
		void BtnTimKiemHoGiaDinhClick(object sender, EventArgs e)
		{
					frmTimKiemHoGiaDinh frm = new frmTimKiemHoGiaDinh();					
                	frm.ShowDialog();
                	if(frm.MaSoGiaDinh != 0)
                	{
                		btnThem.Enabled = false;
		                btnSua.Enabled = true;
		                btnXoa.Enabled = true;
		                clsConfig.MaGiaDinh = frm.MaSoGiaDinh;
		                ChonHoGiaDinhChoHoSo(clsConfig.MaHoSo, clsConfig.MaGiaDinh);
		                LoadThongTinGiaDinh(clsConfig.MaGiaDinh);
		                FillData(clsConfig.MaGiaDinh);
                		
                	}
		}
		void BtnSuaClick(object sender, EventArgs e)
		{
	
		}
		void TabPage2Click(object sender, EventArgs e)
		{
	
		}
    }
}
