using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjDatNongNghiep
{
    public partial class ctrlThue : UserControl
    {
        public ctrlThue()
        {
            InitializeComponent();
        }

        private void ctrlThue_Load(object sender, EventArgs e)
        {
            ReLoad();
        } 
       
        DataSet ds = new DataSet();
        clsDatabase cls = new clsDatabase();
        private void LoadNull()
        {
            txtNguoiNop.Text = "";
            txtNamthue.Text = "";
            txtTienThue.Text = "";
            rtbGhiChu.Text = "";
            dtpNgayNop.Value= DateTime.Now;
        }

        string MucThue = "";
        string TienConPhaiNop = "";
        private void ThongTinBanDau()
        {
           
            string query = " select Thue from tblHoSoCapGCNDatNN where MaHoSoCapGCNDatNN ='" + clsConfig.MaHoSo + "' ";
            MucThue = cls.ExecuteQueryScalar(query);

            // tính tiền còn phải nộp ở đây
        }
        public void ReLoad()
        {
        	lblTienPhaiNop.Visible=false;
            if (clsConfig.MaHoSo == 0)
            {
                //MessageBox.Show("Không có mã hồ sơ!");
                return;
            }
            ThongTinBanDau();
            lblMucThue.Text = "Thuế hằng năm: "+ MucThue +" (VNĐ)";
            lblTienPhaiNop.Text = "Số tiền còn phải nộp: "+TienConPhaiNop+" (VNĐ)";
            LoadNull();            
            TrangThaiBanDau();
            FillData(clsConfig.MaHoSo);
        }
        
       
        private void FillData(int MSHS)
        {
            try
            {
                ds.Tables.Clear();
                string query = " select * from tblNopThueDatNN where MaDonViHanhChinh ='" + clsConfig.MaDonVihanhChinh + "'  and MaHoSoCapGCNDatNN ='" + MSHS + "' ";
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
                if (dataGridView1.Columns[i].Name == "ID")
                {
                    dataGridView1.Columns[i].HeaderText = "ID";
                    dataGridView1.Columns[i].Width = 40;
                    dataGridView1.Columns[i].Visible = false;
                }
                if (dataGridView1.Columns[i].Name == "DuocMien")
                {
                    dataGridView1.Columns[i].HeaderText = "Được miễn";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "MaHoSoCapGCNDatNN")
                {
                    dataGridView1.Columns[i].HeaderText = "Mã hồ sơ";
                    dataGridView1.Columns[i].Width = 50;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "MaDonViHanhChinh")
                {
                    dataGridView1.Columns[i].HeaderText = "Mã xã";
                    dataGridView1.Columns[i].Width = 60;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "TienNopThue")
                {
                    dataGridView1.Columns[i].HeaderText = "Tiền nộp thuế";
                    dataGridView1.Columns[i].Width = 90;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "NguoiNopThue")
                {
                    dataGridView1.Columns[i].HeaderText = "Người nộp";
                    dataGridView1.Columns[i].Width = 200;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "NgayNopThue")
                {
                    dataGridView1.Columns[i].HeaderText = "Ngày nộp";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "Nam")
                {
                    dataGridView1.Columns[i].HeaderText = "Năm";
                    dataGridView1.Columns[i].Width = 90;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "GhiChu")
                {
                    dataGridView1.Columns[i].HeaderText = "Ghi chú";
                    dataGridView1.Columns[i].Width = 200;
                    dataGridView1.Columns[i].Visible = true;
                }
               
            }
        }
        int ID = 0;        
        private void TrangThaiBanDau()
        {
            foreach (Control ctrl in this.Controls)
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
            foreach (Control ctrl in this.Controls)
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
            foreach (Control ctrl in this.Controls)
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
            ID  = 0;            
        }
       
        private void btnOK_Click(object sender, EventArgs e)
        {
            string _NgayNopThue = "";
            if (dtpNgayNop.Checked == true)
                _NgayNopThue = dtpNgayNop.Value.ToString();
            string[] Paras = new string[] { "@flag","@ID", "@MaHoSoCapGCNDatNN", "@MaDonViHanhChinh", "@TienNopThue", "@Nam", "@NguoiNopThue", "@NgayNopThue", "@GhiChu","@DuocMien"};
            string[] Values = new string[] { Work.ToString(), ID.ToString(), clsConfig.MaHoSo.ToString(), clsConfig.MaDonVihanhChinh, txtTienThue.Text.Trim(), txtNamthue.Text.Trim(), txtNguoiNop.Text.Trim(), _NgayNopThue, rtbGhiChu.Text.Trim(), txtDuocMien.Text.Trim() };
            string spName;
            switch (Work)
            {

                case 1:
                    {
                        spName = "spThueDatNN";
                        int kq = cls.ExecuteSP(spName, Paras, Values);
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm thành công " + kq.ToString() + " thửa đất vào hồ sơ ");
                        }
                        else
                        {
                            MessageBox.Show("Không thêm được Khoản nào");
                        }
                        break;
                    }
                case 2:
                    {
                        spName = "spThueDatNN";
                        int kq = cls.ExecuteSP(spName, Paras, Values);
                        if (kq > 0)
                        {
                            MessageBox.Show("Update thành công " + kq.ToString() + " khoản");
                        }
                        else
                        {
                            MessageBox.Show("Không Update thành công");
                        }
                        break;
                    }
                case 3:
                    {
                        spName = "spThueDatNN";
                        int kq = cls.ExecuteSP(spName, Paras, Values);
                        if (kq > 0)
                        {
                            MessageBox.Show(" Xóa thành công " + kq.ToString() + " khoản");
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
         
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            ID = Convert.ToInt32(dataGridView1.Rows[index].Cells["ID"].Value);            
            txtNguoiNop.Text = dataGridView1.Rows[index].Cells["NguoiNopThue"].Value.ToString();
            txtNamthue.Text = dataGridView1.Rows[index].Cells["Nam"].Value.ToString();
            txtTienThue.Text = dataGridView1.Rows[index].Cells["TienNopThue"].Value.ToString();
            if (dataGridView1.Rows[index].Cells["NgayNopThue"].Value.ToString().Trim() != "")
            {
                dtpNgayNop.Text = dataGridView1.Rows[index].Cells["NgayNopThue"].Value.ToString();
                dtpNgayNop.Checked = true;
            }
            else
                dtpNgayNop.Checked = false;
            rtbGhiChu.Text = dataGridView1.Rows[index].Cells["GhiChu"].Value.ToString();
            txtDuocMien.Text = dataGridView1.Rows[index].Cells["DuocMien"].Value.ToString();
        }

        public delegate void UpdateTongHopThongTinHandler(object sender, EventArgs e);
        public event UpdateTongHopThongTinHandler OnTHTT;
        private void THTT()
        {
            if (OnTHTT != null)
                OnTHTT(this, null);
        }
		
    }
}
