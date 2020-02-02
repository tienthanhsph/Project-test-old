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
    public partial class frmCanBo : Form
    {
        public frmCanBo()
        {
            InitializeComponent();
        }

        private void frmCanBo_Load(object sender, EventArgs e)
        {
            LoadCmbDanhMuc();
            TrangThaiBanDau();
            RefreshData();
        }
        private void LoadCmbDanhMuc()
        {
            try
            {
                string query = "select count(*) from tblDSCanBoCapDatNN ";
                if (Convert.ToInt32(cls.ExecuteQueryScalar(query)) == 0)
                {
                    query = " insert into tblDSCanBoCapDatNN (DanhMuc) values (N'Cán bộ UBND')";
                    cls.ExecuteQueryInsertUpdateDelete(query);
                    query = " insert into tblDSCanBoCapDatNN (DanhMuc) values (N'Cán bộ cơ quan địa chính')";
                    cls.ExecuteQueryInsertUpdateDelete(query);
                    query = " insert into tblDSCanBoCapDatNN (DanhMuc) values (N'Cán bộ Hội đồng giao đất nông nghiệp')";
                    cls.ExecuteQueryInsertUpdateDelete(query);
                    query = " insert into tblDSCanBoCapDatNN (DanhMuc) values (N'Tiêu đề ký')";
                    cls.ExecuteQueryInsertUpdateDelete(query);
                }
                query = " select distinct DanhMuc from tblDSCanBoCapDatNN ";
                ds.Tables.Clear();
                ds = cls.ExecuteQuery(query);
                cmbDanhMuc.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cmbDanhMuc.Items.Add(ds.Tables[0].Rows[i]["DanhMuc"].ToString());
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
              
            
        }
        private void ctrlThue_Load(object sender, EventArgs e)
        {
            ReLoad();
        }

        DataSet ds = new DataSet();
        clsDatabase cls = new clsDatabase();

        public string MaHS{get;set;}
        public string TenNguoi = "";
        public string tbl="";
        private void LoadNull()
        {
            txtTen.Text = "";
            txtChucVu.Text = "";            
        }

//        private void LoadTT()
//        {
//        	
//        	if(tbl == "tblXetGiaoDatNN")
//        	{
//	        	string query =" select * from  tblXetGiaoDatNN  where MaHoSoCapGCNDatNN = '"+clsConfig.MaHoSo+"' ";
//	        	ds.Tables.Clear();
//	        	ds= cls.ExecuteQuery(query);
//	        	txtTen.Text = ds.Tables[0].Rows[0]["Ten"].ToString();
//	            txtChucVu.Text =  ds.Tables[0].Rows[0]["ChucVu"].ToString();
//        	}
//        	if(tbl == "tblXetQuyenSuDungDatNN")
//        	
//        }
        public void ReLoad()
        {
            try
            {
                LoadNull();
                TrangThaiBanDau();
                string query = "select * from tblDSCanBoCapDatNN ";
                FillData(query);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
              
            
            
                
        }

        private void FillData(string query)
        {
            try
            {
                ds.Tables.Clear();
                ds = cls.ExecuteQuery(query);
                if (ds != null && ds.Tables != null)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    DatagridviewStyle();
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
       
        private void DatagridviewStyle()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].Name == "Ten")
                {
                    dataGridView1.Columns[i].HeaderText = "Tên";
                    dataGridView1.Columns[i].Width = 200;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "ChucVu")
                {
                    dataGridView1.Columns[i].HeaderText = "Chức vụ";
                    dataGridView1.Columns[i].Width = 100;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "DanhMuc")
                {
                    dataGridView1.Columns[i].HeaderText = "Bộ phận";
                    dataGridView1.Columns[i].Width = 90;
                    dataGridView1.Columns[i].Visible = true;
                }
                
            }
        }
        int ID = 0;
        private void TrangThaiBanDau()
        {
            foreach (Control ctrl in panel5.Controls)
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
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void TrangThaiChucNang()
        {
            foreach (Control ctrl in panel5.Controls)
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
                    ctrl.BackColor = Color.LemonChiffon;
                    ((DateTimePicker)ctrl).Checked = true;
                }
            }
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnOK.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void TrangThaiKetThuc()
        {
            foreach (Control ctrl in panel5.Controls)
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

            btnOK.Enabled = false;
            btnCancel.Enabled = false;
            ID = 0;
        }

        private int Work = 0;

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.Gold;
            Work = 1;
            TrangThaiChucNang();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ID == 0)
                MessageBox.Show("Chưa chọn dòng!");
            else
            {
                btnSua.BackColor = Color.Gold;
                Work = 2;
                TrangThaiChucNang();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ID == 0)
                MessageBox.Show("Chưa chọn dòng");
            else
            {
                Work = 3;
                TrangThaiChucNang();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Work = 0;
            TrangThaiBanDau();
            ID = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Paras = new string[] { "@flag", "@ID", "@Ten", "@ChucVu", "@DanhMuc" };
                string[] Values = new string[] { Work.ToString(), ID.ToString(), txtTen.Text.Trim(), txtChucVu.Text.Trim(), cmbDanhMuc.Text.Trim() };
                string spName;
                switch (Work)
                {

                    case 1:
                        {
                            spName = "spDSCanBoCapDatNN";
                            int kq = cls.ExecuteSP(spName, Paras, Values);
                            if (kq > 0)
                            {
                                MessageBox.Show("Thêm thành công " + kq.ToString() + "  ");
                            }
                            else
                            {
                                MessageBox.Show("Không thêm được Khoản nào");
                            }
                            break;
                        }
                    case 2:
                        {
                            spName = "spDSCanBoCapDatNN";
                            int kq = cls.ExecuteSP(spName, Paras, Values);
                            if (kq > 0)
                            {
                                MessageBox.Show("Update thành công " + kq.ToString() + " ");
                            }
                            else
                            {
                                MessageBox.Show("Không Update thành công");
                            }
                            break;
                        }
                    case 3:
                        {
                            spName = "spDSCanBoCapDatNN";
                            int kq = cls.ExecuteSP(spName, Paras, Values);
                            if (kq > 0)
                            {
                                MessageBox.Show(" Xóa thành công " + kq.ToString() + " ");
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
                THTT();
                ReLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                ID = Convert.ToInt32(dataGridView1.Rows[index].Cells["ID"].Value);
                txtTen.Text = dataGridView1.Rows[index].Cells["Ten"].Value.ToString();
                txtChucVu.Text = dataGridView1.Rows[index].Cells["ChucVu"].Value.ToString();
                cmbDanhMuc.Text = dataGridView1.Rows[index].Cells["DanhMuc"].Value.ToString();
            }
            catch (Exception ex)
            {
             // MessageBox.Show(ex.Message);
            }
            
           
        }

        public delegate void UpdateTongHopThongTinHandler(object sender, EventArgs e);
        public event UpdateTongHopThongTinHandler OnTHTT;
        private void THTT()
        {
            if (OnTHTT != null)
                OnTHTT(this, null);
        }
        
        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void txtChucVu_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            try
            {
                string query = " select * from tblDSCanBoCapDatNN where 1=1 ";
                if (cmbDanhMuc.Text.Trim() != "")
                    query += " and DanhMuc Like N'%" + cmbDanhMuc.Text.Trim() + "%' ";
                if (txtChucVu.Text.Trim() != "")
                    query += " and ChucVu like N'%" + txtChucVu.Text.Trim() + "%' ";
                if (txtTen.Text.Trim() != "")
                    query += " and Ten like N'%" + txtTen.Text.Trim() + "%' ";
                FillData(query);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
              
            
        }
        private void cmbDanhMuc_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                string nguoi = dataGridView1.Rows[i].Cells["Ten"].Value.ToString() + " : " + dataGridView1.Rows[i].Cells["ChucVu"].Value.ToString() + ";";
                richTextBox1.Text += nguoi + "\n";
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            
        }

        
        private void btnChonNguoi_Click(object sender, EventArgs e)
        {
            TenNguoi = txtTen.Text.Trim();            
            this.Close();
        }

        private void btnHoiDong_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (cmbDanhMuc.Text == "Cán bộ cơ quan địa chính")
                {

                    query = " Update  tblXetQuyenSuDungDatNN set CQDC ='" + richTextBox1.Text.Trim() + "' where MaHoSoCapGCNDatNN = " + clsConfig.MaHoSo.ToString();
                }
                else if (cmbDanhMuc.Text == "Cán bộ Hội đồng giao đất nông nghiệp")
                {
                    query = "Update  tblXetGiaoDatNN set HDGD ='" + richTextBox1.Text.Trim() + "'  where MaHoSoCapGCNDatNN = " + clsConfig.MaHoSo.ToString();
                }
                if (query != "")
                {
                    cls.ExecuteQueryInsertUpdateDelete(query);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
              
           
        }
    }
}
