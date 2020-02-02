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
    public partial class ctrlXetGiaoDatNN : UserControl
    {
        public ctrlXetGiaoDatNN()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        DataSet ds = new DataSet();
        int flag = 0;
        private void ctrlXetGiaoDatNN_Load(object sender, EventArgs e)
        {
            
            
        	dtpNgayKyHDGD.Format= DateTimePickerFormat.Custom;
        	dtpNgayKyHDGD.CustomFormat = "dd/MM/yyyy";
        	
        	dtpNgayKyUBND.Format= DateTimePickerFormat.Custom;
        	dtpNgayKyUBND.CustomFormat = "dd/MM/yyyy";
        }


        public void ReLoad()
        {          

            TrangThaiBanDauHDGD();
            TrangThaiBanDauUBND();

            if (KiemTraTonTai() == true)
            {
                LoadDataHDGD();
                LoadDataUBND();
            }

            Find("Cán bộ Hội đồng giao đất nông nghiệp", "", "", "Ten", cmbThuKyHDGD);
            Find("Tiêu đề ký", "", "", "Ten", cmbTieuDeUBND);
            Find("Cán bộ UBND","","","Ten", cmbCanBoUBND );
            
        }
        private void btnTuDien1_Click(object sender, EventArgs e)
        {
            frmCanBo canbo = new frmCanBo();
            canbo.cmbDanhMuc.Text = "Cán bộ Hội đồng giao đất nông nghiệp";
            canbo.ShowDialog();
            cmbThuKyHDGD.Text=canbo.TenNguoi;
        }

        private void btnTuDien2_Click(object sender, EventArgs e)
        {
            frmCanBo canbo = new frmCanBo();
            canbo.cmbDanhMuc.Text = "Tiêu đề ký";
            canbo.ShowDialog();
            cmbTieuDeUBND.Text = canbo.TenNguoi;
            
        }

        private void btnTuDien3_Click(object sender, EventArgs e)
        {
            frmCanBo canbo = new frmCanBo();
            canbo.cmbDanhMuc.Text = "Cán bộ UBND";
            canbo.ShowDialog();
            cmbCanBoUBND.Text = canbo.TenNguoi;
        }



        private void Find(string DanhMuc, string Ten, string ChucVu, string Output, ComboBox cmb)
        {
            try
            {
                string query = " select " + Output + " from tblDSCanBoCapDatNN where 1=1 ";
                if (DanhMuc != "")
                    query += " and DanhMuc Like N'%" + DanhMuc + "%' ";
                if (ChucVu != "")
                    query += " and ChucVu like N'%" + ChucVu + "%' ";
                if (Ten != "")
                    query += " and Ten like N'%" + Ten + "%' ";
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
        private void AutoUBND()
        {
        	rtbYKienUBND.Text = "UBND " + clsConfig.TenDVHC + " nhất trí giao đất cho hộ Ông (Bà) : " + ((frmHOSO)(this.ParentForm)).TenChuGiaDinh + " với diện tích là " + ((frmHOSO)(this.ParentForm)).TongDienTich + " (m2) đất nông nghiệp, với thời hạn sử dụng là 20 năm ";
        }
        private void AutoHDGD()
        {
        	string OnDinh = "- Giao đất ổn định 20 năm (từ ngày    đến ngày   ) gồm các thửa: ";
        	string ChoThue ="- Cho thuê (đấu thầu) để sản xuất nông nghiệp     năm    (từ ngày     đến ngày   )gồm các thửa:  ";
        	rtbYKienHDGD.Text= OnDinh+"\n"+ ChoThue;
        	
        }


        #region "DuLieu"
        private void LoadDataUBND()
        {
            try
            {
                string query = " select * from tblXetGiaoDatNN Where MaDonViHanhChinh ='" + clsConfig.MaDonVihanhChinh + "' and MaHoSoCapGCNDatNN ='" + clsConfig.MaHoSo + "' ";
                ds.Tables.Clear();
                ds = cls.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count > 0)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadDataHDGD()
        {
            try
            {
                string query = " select * from tblXetGiaoDatNN Where MaDonViHanhChinh ='" + clsConfig.MaDonVihanhChinh + "' and MaHoSoCapGCNDatNN ='" + clsConfig.MaHoSo + "' ";
                ds.Tables.Clear();
                ds = cls.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    rtbYKienHDGD.Text = ds.Tables[0].Rows[0]["HDGDNoiDung"].ToString();
                    if (ds.Tables[0].Rows[0]["HDGDNgayKy"].ToString() != "")
                    {
                        dtpNgayKyHDGD.Value = (DateTime)ds.Tables[0].Rows[0]["HDGDNgayKy"];
                        dtpNgayKyHDGD.Checked = true;
                    }
                    else
                        dtpNgayKyHDGD.Checked = false;
                    cmbThuKyHDGD.Text = ds.Tables[0].Rows[0]["HDGDNguoiKy"].ToString();

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
                else if (ctrl is DateTimePicker)
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


        private void TrangThaiBanDauHDGD()
        {
            foreach (Control ctrl in HDGD.Controls)
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
            btnThemHDGD.Enabled = true;
            btnSuaHDGD.Enabled = true;
            btnLuuHDGD.Enabled = false;
        }
        private void TrangThaiChucNangHDGD()
        {
            foreach (Control ctrl in HDGD.Controls)
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
            btnThemHDGD.Enabled = false;
            btnSuaHDGD.Enabled = false;
            btnLuuHDGD.Enabled = true;
        }
        private void TrangThaiKetThucHDGD()
        {
            foreach (Control ctrl in HDGD.Controls)
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
            btnThemHDGD.Enabled = true;
            btnSuaHDGD.Enabled = true;
            btnLuuHDGD.Enabled = false;
        }
        #endregion


        #region "button Click"
        private bool KiemTraTonTai()
        {
            try
            {
                int kq = 0;
                string query = " select count(*) from tblXetGiaoDatNN Where MaDonViHanhChinh ='" + clsConfig.MaDonVihanhChinh + "' and MaHoSoCapGCNDatNN ='" + clsConfig.MaHoSo + "' ";
                if (cls.ExecuteQueryScalar(query) != null && cls.ExecuteQueryScalar(query).Trim() != "")
                {
                    kq = Convert.ToInt32(cls.ExecuteQueryScalar(query));
                }

                if (kq > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }


        private void Exe(int _flag)
        {
            if (clsConfig.MaHoSo != 0)
            {
                string _UBNDNgayKy = "";
                if (dtpNgayKyUBND.Checked == true)
                    _UBNDNgayKy = dtpNgayKyUBND.Value.ToString();
                string _HDGDNgayKy = "";
                if (dtpNgayKyHDGD.Checked == true)
                    _HDGDNgayKy = dtpNgayKyHDGD.Value.ToString();
                string[] Paras = new string[] { "@flag", "@MaHoSoCapGCNDatNN", "@MaDonViHanhChinh", "@UBNDNgayKy", "@UBNDTieuDeKy", "@UBNDNguoiKy", "@UBNDNoiDung", "@HDGDNgayKy", "@HDGDNguoiKy", "@HDGDNoiDung" };
                string[] Values = new string[]{_flag.ToString(), clsConfig.MaHoSo.ToString(),clsConfig.MaDonVihanhChinh, _UBNDNgayKy, cmbTieuDeUBND.Text.Trim(), cmbCanBoUBND.Text.Trim(), rtbYKienUBND.Text.Trim(),
                                            _HDGDNgayKy, cmbThuKyHDGD.Text.Trim(), rtbYKienHDGD.Text.Trim()};
                int kq = cls.ExecuteSP("spXetGiaoDatNN", Paras, Values);
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

        private void btnThemHDGD_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai() == false)
            {
            Exe(0);
            AutoHDGD();
            }
            flag = 1;
            TrangThaiChucNangHDGD();
            
                
        }

        private void btnSuaHDGD_Click(object sender, EventArgs e)
        {
        	if (KiemTraTonTai() == true)
            {
            flag = 1;
            TrangThaiChucNangHDGD();
        	}
        }

        private void btnLuuHDGD_Click(object sender, EventArgs e)
        {
            Exe(flag);
            TrangThaiKetThucHDGD();
        }

        private void btnThemUBND_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTai() == false)
            {
	             Exe(0);
	            AutoUBND();
            }
	            flag = 2;
	            TrangThaiChucNangUBND();
            
               

        }

        private void btnSuaUBND_Click(object sender, EventArgs e)
        {
        	if (KiemTraTonTai() == true)
            {
            flag = 2;
            TrangThaiChucNangUBND();
        	}
        }

        private void btnLuuUBND_Click(object sender, EventArgs e)
        {
            Exe(flag);
            TrangThaiKetThucUBND();
        }

        #endregion

    }
}
