using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDatNongNghiep
{
    public partial class ctrlXetQSDD : UserControl
    {
        public ctrlXetQSDD()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        DataSet ds = new DataSet();
        int flag = 0;
        
        private void ctrlXetQSDD_Load(object sender, EventArgs e)
        {
        	dtpNgayKyDC.Format= DateTimePickerFormat.Custom;
        	dtpNgayKyDC.CustomFormat = "dd/MM/yyyy";
        	
        	dtpNgayKyUBND.Format= DateTimePickerFormat.Custom;
        	dtpNgayKyUBND.CustomFormat = "dd/MM/yyyy";
        		
        }
        public  void ReLoad()
        {
            
            TrangThaiBanDauDC();
            TrangThaiBanDauUBND();

            if (KiemTraTonTai() == true)
            {
                LoadDataDC();
                LoadDataUBND();
            }

            Find("Cán bộ cơ quan địa chính", "", "", "Ten", cmbThuTruongDC);
            Find("Tiêu đề ký", "", "", "Ten", cmbTieuDeUBND);
            Find("Cán bộ UBND", "", "", "Ten", cmbCanBoUBND);
        }
        private void AutoUBND()
        {
        	rtbYKienUBND.Text = "UBND " + clsConfig.TenDVHC + " nhất trí giao đất cho hộ Ông (Bà) : " + ((frmHOSO)(this.ParentForm)).TenChuGiaDinh + " với diện tích là " + ((frmHOSO)(this.ParentForm)).TongDienTich + " (m2) đất nông nghiệp, với thời hạn sử dụng là 20 năm ";
        }
        private void AutoDC()
        {

        }




        private void Find(string DanhMuc, string Ten, string ChucVu, string Output, ComboBox cmb)
        {
            try
            {
                string query = " select " + Output + " from tblDSCanBoCapDatNN where 1=1 ";
                if (DanhMuc != "")
                    query += " and DanhMuc Like N'%" + DanhMuc+ "%' ";
                if (ChucVu != "")
                    query += " and ChucVu like N'%" + ChucVu + "%' ";
                if (Ten != "")
                    query += " and Ten like N'%" + Ten +"%' ";
               
                ds.Tables.Clear();
                ds = cls.ExecuteQuery(query);
                cmb.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmb.Items.Add(ds.Tables[0].Rows[i][Output].ToString());
                }
            }
            catch (Exception ex)
            {

            }
        }


        #region "..."
        private void btnTuDien1_Click(object sender, EventArgs e)
        {
            frmCanBo canbo = new frmCanBo();
            canbo.cmbDanhMuc.Text = "Tiêu đề ký";
            canbo.ShowDialog();
            cmbTieuDeUBND.Text = canbo.TenNguoi;
        }

        private void btnTuDien2_Click(object sender, EventArgs e)
        {
            frmCanBo canbo = new frmCanBo();
            canbo.cmbDanhMuc.Text = "Cán bộ UBND";
            canbo.ShowDialog();
            cmbCanBoUBND.Text = canbo.TenNguoi;
        }

        private void btnTuDien3_Click(object sender, EventArgs e)
        {
            frmCanBo canbo = new frmCanBo();
            canbo.cmbDanhMuc.Text = "Cán bộ cơ quan địa chính";
            canbo.ShowDialog();
            cmbThuTruongDC.Text= canbo.TenNguoi;
        }
        #endregion

        #region "DuLieu"
        private void LoadDataUBND()
        {
            try{
                string query = " select * from tblXetQuyenSuDungDatNN Where MaDonViHanhChinh ='" + clsConfig.MaDonVihanhChinh + "' and MaHoSoCapGCNDatNN ='" + clsConfig.MaHoSo + "' ";
            ds.Tables.Clear();
            ds = cls.ExecuteQuery(query);
            if(ds.Tables[0].Rows.Count >0)
            {
                rtbYKienUBND.Text = ds.Tables[0].Rows[0]["UBNDNoiDung"].ToString();
                if (ds.Tables[0].Rows[0]["UBNDNgayKy"].ToString() != "")
                {
                    dtpNgayKyUBND.Value = (DateTime)ds.Tables[0].Rows[0]["UBNDNgayKy"];
                    dtpNgayKyUBND.Checked = true;
                }
                else
                    dtpNgayKyUBND.Checked = false;
                cmbCanBoUBND.Text = ds.Tables[0].Rows[0]["UBNDNguoiKy"].ToString();
                cmbTieuDeUBND.Text = ds.Tables[0].Rows[0]["UBNDTieuDeKy"].ToString();
            }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }      
       
        private void LoadDataDC()
        {
            try
            {
                string query = " select * from tblXetQuyenSuDungDatNN Where MaDonViHanhChinh ='" + clsConfig.MaDonVihanhChinh + "' and MaHoSoCapGCNDatNN ='" + clsConfig.MaHoSo + "' ";
                ds.Tables.Clear();
                ds = cls.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    rtbYKienDC.Text = ds.Tables[0].Rows[0]["CQDCNoiDung"].ToString();
                    if (ds.Tables[0].Rows[0]["CQDCNgayKy"].ToString() != "")
                    {
                        dtpNgayKyDC.Value = (DateTime)ds.Tables[0].Rows[0]["CQDCNgayKy"];
                        dtpNgayKyDC.Checked = true;
                    }
                    else
                        dtpNgayKyDC.Checked = false;
                    cmbThuTruongDC.Text = ds.Tables[0].Rows[0]["CQDCNguoiKy"].ToString();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        #endregion

        #region "3 trang thai"
        private void TrangThaiBanDauUBND()
        {
            foreach (Control ctrl in UBND.Controls)
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
               
                else if (ctrl is DateTimePicker)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((DateTimePicker)ctrl).Checked = false;
                }
            }
            btnThemUBND.Enabled = true;
            btnSuaUBND.Enabled = true;
            btnLuuUBND.Enabled = false;
            
        }
        private void TrangThaiChucNangUBND()
        {
            foreach (Control ctrl in UBND.Controls)
            {

                if (ctrl is TextBox)
                {
                    ctrl.BackColor = Color.White;
                    ((TextBox)ctrl).ReadOnly = false;
                    
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
                else if(ctrl is DateTimePicker)
                {
                    ctrl.BackColor = Color.White;
                    ((DateTimePicker)ctrl).Checked = true;
                }
            }
            btnThemUBND.Enabled = false;
            btnSuaUBND.Enabled = false;
            btnLuuUBND.Enabled = true;
           
        }
        private void TrangThaiKetThucUBND()
        {
            foreach (Control ctrl in UBND.Controls)
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
               
                else if (ctrl is DateTimePicker)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((DateTimePicker)ctrl).Checked = false;
                }
            }
            btnThemUBND.Enabled = true;
            btnSuaUBND.Enabled = true;
            btnLuuUBND.Enabled = false;

        
        }


        private void TrangThaiBanDauDC()
        {
            foreach (Control ctrl in DC.Controls)
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
                
                else if (ctrl is DateTimePicker)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((DateTimePicker)ctrl).Checked = false;
                }
            }
            btnThemDC.Enabled = true;
            btnSuaDC.Enabled = true;
            btnLuuDC.Enabled = false;
        }
        private void TrangThaiChucNangDC()
        {
            foreach (Control ctrl in DC.Controls)
            {

                if (ctrl is TextBox)
                {
                    ctrl.BackColor = Color.White;
                    ((TextBox)ctrl).ReadOnly = false;

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
                else if (ctrl is DateTimePicker)
                {
                    ctrl.BackColor = Color.White;
                    ((DateTimePicker)ctrl).Checked = true;
                }
            }
            btnThemDC.Enabled = false;
            btnSuaDC.Enabled = false;
            btnLuuDC.Enabled = true;
        }
        private void TrangThaiKetThucDC()
        {
            foreach (Control ctrl in DC.Controls)
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

                else if (ctrl is DateTimePicker)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((DateTimePicker)ctrl).Checked = false;
                }
            }
            btnThemDC.Enabled = true;
            btnSuaDC.Enabled = true;
            btnLuuDC.Enabled = false;
        }
        #endregion


        #region "button Click"
        private bool KiemTraTonTai()
        {
            try
            {
                int kq = 0;
                string query = " select count(*) from tblXetQuyenSuDungDatNN Where MaDonViHanhChinh ='" + clsConfig.MaDonVihanhChinh + "' and MaHoSoCapGCNDatNN ='" + clsConfig.MaHoSo + "' ";
                if(cls.ExecuteQueryScalar(query) != null && cls.ExecuteQueryScalar(query).Trim() != "")
                {
                    kq =Convert.ToInt32(cls.ExecuteQueryScalar(query));
                }

                if (kq > 0)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }

        private void btnThemUBND_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai() == false)
            {
	            Exe(0);
	            AutoUBND();
            }
	            flag = 1;
	            TrangThaiChucNangUBND();
            
                
        }

        private void btnSuaUBND_Click(object sender, EventArgs e)
        {
        	if (KiemTraTonTai() == true)
            {
	            flag = 1;
	            TrangThaiChucNangUBND();
        	}
        }
        
        private void Exe(int _flag)
        {
            if (clsConfig.MaHoSo != 0)
            {
                string _UBNDNgayKy = "";
                if (dtpNgayKyUBND.Checked == true)
                    _UBNDNgayKy = dtpNgayKyUBND.Value.ToString();
                string _CQDCNgayKy = "";
                if (dtpNgayKyDC.Checked == true)
                    _CQDCNgayKy = dtpNgayKyDC.Value.ToString();
                string[] Paras = new string[] { "@flag", "@MaHoSoCapGCNDatNN", "@MaDonViHanhChinh", "@UBNDNgayKy", "@UBNDTieuDeKy", "@UBNDNguoiKy", "@UBNDNoiDung", "@CQDCNgayKy", "@CQDCNguoiKy", "@CQDCNoiDung" };
                string[] Values = new string[]{_flag.ToString(), clsConfig.MaHoSo.ToString(),clsConfig.MaDonVihanhChinh, _UBNDNgayKy, cmbTieuDeUBND.Text.Trim(), cmbCanBoUBND.Text.Trim(), rtbYKienUBND.Text.Trim(),
                                            _CQDCNgayKy, cmbThuTruongDC.Text.Trim(), rtbYKienDC.Text.Trim()};
                int kq = cls.ExecuteSP("spXetQuyenSDDatNN", Paras, Values);
                if (kq > 0)
                {
                    //MessageBox.Show(kq.ToString() + " OK!");
                }
                else
                {
                    MessageBox.Show("Không có gì thay đổi!");
                }
            }
            
        }
        private void btnLuuUBND_Click(object sender, EventArgs e)
        {
            Exe(flag);
            TrangThaiKetThucUBND();
        }

        private void btnThemDC_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai() == false)
            {
	             Exe(0);
//	            flag = 2;
            }
            flag = 2;
	            TrangThaiChucNangDC();
            
               
        }

        private void btnSuaDC_Click(object sender, EventArgs e)
        {
        	if (KiemTraTonTai() == true)
            {
	            flag = 2;
	            TrangThaiChucNangDC();
        	}
        }

        private void btnLuuDC_Click(object sender, EventArgs e)
        {
//        	flag = 2;
            Exe(flag);
            TrangThaiKetThucDC();
            
        }
        #endregion
    }
}
