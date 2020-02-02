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
    public partial class CtrlDangKyBienDong : UserControl
    {
        public CtrlDangKyBienDong()
        {
            InitializeComponent();
        }
        public void KiemTraMaHoSo()
        { 
        // neu khong co ma ho so thi hien thong bao
        }
        DataSet ds = new DataSet();
        clsDatabase cls = new clsDatabase();
        int Flag = 0;
        int MaDKBD = 0;
        int MaQuyetDinh = 0;

        

        public  void TrangThaiBanDau()
        {
            try
            {
                LoadNull();

                grpQuyetDinh.Enabled = false;
                dataGridView1.Enabled = true;
                btnTaoHoSoMoi.Enabled = true;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                btnOK.Enabled = false;
                btnCancel.Enabled = false;

                if (panel1.Controls.Count > 0)
                {
                    foreach (Control con in panel1.Controls)
                    {
                        if (con is TextBox)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((TextBox)con).Enabled = false;
                        }
                        else if (con is RichTextBox)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((RichTextBox)con).Enabled = false;
                        }
                        else if (con is NumericUpDown)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((NumericUpDown)con).Enabled = false;
                        }
                        else if (con is DateTimePicker)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((DateTimePicker)con).Enabled = false;
                        }
                        else if (con is CheckBox)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((CheckBox)con).Enabled = false;
                        }
                        else if (con is RadioButton)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((RadioButton)con).Enabled = false;
                        }
                        else if (con is ComboBox)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((ComboBox)con).Enabled = false;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public  void TrangThaiChucNang()
        {
            try
            {
                grpQuyetDinh.Enabled = true;
                dataGridView1.Enabled = false;
                btnTaoHoSoMoi.Enabled = false;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                btnOK.Enabled = true;
                btnCancel.Enabled = true;

                if (panel1.Controls.Count > 0)
                {
                    foreach (Control con in panel1.Controls)
                    {
                        if (con is TextBox)
                        {
                            con.BackColor = Color.White;
                            ((TextBox)con).Enabled = true;
                        }
                        else if (con is RichTextBox)
                        {
                            con.BackColor = Color.White;
                            ((RichTextBox)con).Enabled = true;
                        }
                        else if (con is NumericUpDown)
                        {
                            con.BackColor = Color.White;
                            ((NumericUpDown)con).Enabled = true;
                        }
                        else if (con is DateTimePicker)
                        {
                            con.BackColor = Color.White;
                            ((DateTimePicker)con).Enabled = true;
                        }
                        else if (con is CheckBox)
                        {
                            con.BackColor = Color.White;
                            ((CheckBox)con).Enabled = true;
                        }
                        else if (con is RadioButton)
                        {
                            con.BackColor = Color.White;
                            ((RadioButton)con).Enabled = true;
                        }
                        else if (con is ComboBox)
                        {
                            con.BackColor = Color.White;
                            ((ComboBox)con).Enabled = true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public  void TrangThaiKetThuc()
        {
            try
            {                
                grpQuyetDinh.Enabled = false;
                dataGridView1.Enabled = true;
                btnTaoHoSoMoi.Enabled = true;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                btnOK.Enabled = false;
                btnCancel.Enabled = false;

                if (panel1.Controls.Count > 0)
                {
                    foreach (Control con in panel1.Controls)
                    {
                        if (con is TextBox)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((TextBox)con).Enabled = false;
                        }
                        else if (con is RichTextBox)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((RichTextBox)con).Enabled = false;
                        }
                        else if (con is NumericUpDown)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((NumericUpDown)con).Enabled = false;
                        }
                        else if (con is DateTimePicker)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((DateTimePicker)con).Enabled = false;
                        }
                        else if (con is CheckBox)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((CheckBox)con).Enabled = false;
                        }
                        else if (con is RadioButton)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((RadioButton)con).Enabled = false;
                        }
                        else if (con is ComboBox)
                        {
                            con.BackColor = Color.LemonChiffon;
                            ((ComboBox)con).Enabled = false;
                        }
                    }
                }

                MessageBox.Show(Flag.ToString() + " Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void ReLoad() {
           
            TrangThaiBanDau();
            Flag = 0;
            MaDKBD = 0;
            MaQuyetDinh = 0;
            FillDataGridView();
            FillCmbLoaiBienDong();


            dtpNgayDangKy.Format = DateTimePickerFormat.Custom;
            dtpNgayDangKy.CustomFormat = "dd/MM/yyyy";
            dtpNgayQuyetDinh.Format = DateTimePickerFormat.Custom;
            dtpNgayQuyetDinh.CustomFormat = "dd/MM/yyyy";

            StyleDataGridView();
            LoadNull();
        }

        //private void ShowThongTinBienDong(int MaBienDong) {
        //    ExecuteProcedure(5, true);

        //}
        private void FillDataGridView() {

            ExecuteProcedure(4, true);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void FillCmbLoaiBienDong() { }
        
        private void StyleDataGridView() {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {

                if (dataGridView1.Columns[i].Name == "MaDangKyBienDong")
                {
                    dataGridView1.Columns[i].HeaderText = "Mã biến động";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "NguoiDangKy")
                {
                    dataGridView1.Columns[i].HeaderText = "Người đăng ký";
                    dataGridView1.Columns[i].Width = 150;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "NgayDangKy")
                {
                    dataGridView1.Columns[i].HeaderText = "Ngày đăng ký";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "MaHoSo")
                {
                    dataGridView1.Columns[i].HeaderText = "Hồ sơ đăng ký";
                    dataGridView1.Columns[i].Width = 100;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "MaHoSoMoi")
                {
                    dataGridView1.Columns[i].HeaderText = "Hồ sơ mới";
                    dataGridView1.Columns[i].Width = 100;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "LoaiBienDong")
                {
                    dataGridView1.Columns[i].HeaderText = "Loại biến động";
                    dataGridView1.Columns[i].Width = 150;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "NoiDungBienDong")
                {
                    dataGridView1.Columns[i].HeaderText = "Nội dung biến động";
                    dataGridView1.Columns[i].Width = 300;
                    dataGridView1.Columns[i].Visible = true;
                }
               
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadNull();
            Flag = 1;
            TrangThaiChucNang();

            ExecuteProcedure_BDDatNN(0, true);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MaDKBD != 0)
            {
                Flag = 2;
                TrangThaiChucNang();
            }
            else
            {
                MessageBox.Show("Chưa chọn biến động");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MaDKBD != 0)
            {
                Flag = 3;
                TrangThaiChucNang();
            }
            else
            {
                MessageBox.Show("Chưa chọn biến động");
            }
        }

        private void ExecuteProcedure(int _flag, bool _getData)
        {
            try
            {
                string _NgayDangKy = "";
                if (dtpNgayDangKy.Checked == true)
                {
                    _NgayDangKy = dtpNgayDangKy.Value.ToString();
                }


                string[] Paras = new string[] { "@flag", "@MaDangKyBienDong", "@NgayDangKy", "@MaHoSo", "@MaHoSoMoi", "@NguoiDangKy", "@LoaiBienDong", "@NoiDungBienDong" };
                string[] Values = new string[] { _flag.ToString(), MaDKBD.ToString(),_NgayDangKy, clsConfig.MaHoSo.ToString(), "", txtNguoiDangKy.Text.Trim(), cmbLoaiBienDong.Text.Trim(), rtbNoiDungBienDong.Text.Trim() };
                string spName;

                spName = "spDangKyBienDongDatNN";
                if (_getData == false)
                {
                    int kq = cls.ExecuteSP(spName, Paras, Values);
                    if (kq > 0)
                    {
                        // MessageBox.Show("Thêm thành công " + kq.ToString() + " thành viên vào gia đình");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thực thi spDangKyBienDongDatNN");
                    }
                }
                else
                {
                    ds.Tables.Clear();
                    ds = cls.GetData(spName, Paras, Values);
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                    }
                    else
                    {
                        //MessageBox.Show("Không có kết quả spDangKyBienDongDatNN");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ExecuteProcedure lỗi \n"+ex.Message);
            }
            
        }
            
        private void btnOK_Click(object sender, EventArgs e)
        {
            ExecuteProcedure(Flag,false);         
            TrangThaiKetThuc();
            if (Flag == 1)
            { 
                MaDKBD =Convert.ToInt32(cls.ExecuteQueryScalar("Select Max(MaDangKyBienDong) from tblDangKyBienDongDatNN "));
            }
            UpdateQuyetDinh();
            ReLoad();
        }        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReLoad();
        }

        

        private void btnTaoHoSoMoi_Click(object sender, EventArgs e)
        {
            /*
             kiểm tra xem có mã hồ sơ mới chưa
             * nếu đã có thì thông báo ,(trường hợp này có thể sai vì đúng ra hồ sơ hiện tại đã phải bị ẩn rồi!)
             * 
             * nếu chưa có thì cập nhật trạng thái hồ sơ hiện tại lên đã lưu thành hồ sơ cũ
             * lấy mã hồ sơ hiện tại
             * tạo hồ sơ mới, sao chép thông tin hồ sơ cũ vào nó.
             * cập nhật vào bảng biến động mã hồ sơ mới.
             */
            if (MaDKBD == 0)
            {
                MessageBox.Show("Cần chọn biến động cuối cùng.");
                return;
            }
            int MaHoSoMoi = 0;
            string query = " select MaHoSoMoi from tblDangKyBienDongDatNN Where MaHoSo = " + clsConfig.MaHoSo.ToString() ;
            //string query = " select MaHoSoMoi from tblDangKyBienDongDatNN Where MaHoSo = " + clsConfig.MaHoSo.ToString() + " and MaDangKyBienDong =" + MaDKBD.ToString() + " ";
            try {
                MaHoSoMoi = Convert.ToInt32(cls.ExecuteQueryScalar(query));                
            }
            catch (Exception ex)
            {
               
            }

            if (MaHoSoMoi != 0)
            {
                MessageBox.Show("Đã có mã hồ sơ mới rồi!");
            }
            else
            {
                if (MessageBox.Show(" Hồ sơ hiện tại sẽ lưu lại và không còn hiệu lực nữa! \n Thay vào đó, một hồ sơ mới sẽ được tạo ra và copy y nguyên dữ liệu từ hồ sơ cũ vào, những gì thuộc về biến động, bạn sẽ chỉnh sửa trong đó","Tạo hồ sơ mới", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                   try {
                        int MaHoSoHienTai = clsConfig.MaHoSo;
                        string SpName = "SaoChepHoSoDatNN";
                        MaHoSoMoi = Convert.ToInt32(cls.GetData(SpName, new string[] { "@MaHoSo", "@MaDangKyBienDong" }, new string[] { MaHoSoHienTai.ToString(), MaDKBD.ToString() }).Tables[0].Rows[0]["MaHoSoMoiCanTim"]);
                        //clsConfig.MaHoSo = MaHoSoMoi;
                        if (MaHoSoMoi != 0)
                        {
                            frmTimKiem frm = new frmTimKiem();                         
                            ((frmHOSO)this.ParentForm).Hide();
                            frm.ShowDialog();
                            ((frmHOSO)this.ParentForm).LoadForm();
                            ((frmHOSO)this.ParentForm).Show(); 
                        }
                        else {
                            MessageBox.Show("Quá trình không thành công!");
                        }
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show("Lỗi btnTaoHoSoMoi_Click");
                   }

                }
            }
        }

        private void btnLichSuBienDong_Click(object sender, EventArgs e)
        {
            frmXemLichSuBienDong lichsu = new frmXemLichSuBienDong();
            lichsu.MaHoSo = clsConfig.MaHoSo;
            lichsu.MaBienDong = this.MaDKBD;

            this.Hide();
            lichsu.ShowDialog();

            this.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
            int i = e.RowIndex;
            if (i >= 0)
            {
                MaDKBD = Convert.ToInt32(dataGridView1.Rows[i].Cells["MaDangKyBienDong"].Value);
                txtNguoiDangKy.Text = dataGridView1.Rows[i].Cells["NguoiDangKy"].Value.ToString();
                cmbLoaiBienDong.Text = dataGridView1.Rows[i].Cells["LoaiBienDong"].Value.ToString();
                if (dataGridView1.Rows[i].Cells["NgayDangKy"].Value.ToString().Trim() != "")
                {
                    dtpNgayDangKy.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells["NgayDangKy"].Value);
                    dtpNgayDangKy.Checked = true;
                }
                else
                    dtpNgayDangKy.Checked = false;
                rtbNoiDungBienDong.Text = dataGridView1.Rows[i].Cells["NoiDungBienDong"].Value.ToString();
                LoadThongTinQuyetDinh(MaDKBD);
            }
           
            }
            catch (Exception ex)
            {
                
            }
        }

       

        #region "Quyết định"
        
        //List<string> DanhSachQuyetDinhChoMotBienDong = new List<string>();
        DataSet dsQD = new DataSet();
        private void btnThemQD_Click(object sender, EventArgs e)
        {
            frmQuyetDinhCapGCNDatNN frm = new frmQuyetDinhCapGCNDatNN();
            frm.ReLoad();
            frm.ShowDialog();
            MaQuyetDinh = frm.MaQuyetDinh;
            txtSoQuyetDinh.Text = frm.SoQuyetDinh;
            txtCoQuanQuyetDinh.Text = frm.CoQuanQuyetDinh;
            string d = frm.NgayQuyetDinh;
            if (d != "")
            {
                dtpNgayQuyetDinh.Value = Convert.ToDateTime(d.ToString());
            }
            ExecuteProcedure_BDDatNN(1, true);


            MaQuyetDinh = 0;
        }

        private void btnXoaQD_Click(object sender, EventArgs e)
        {
            if (MaQuyetDinh == 0)
            {
                MessageBox.Show("Chọn một dòng để thao tác");
                return;
            }
            ExecuteProcedure_BDDatNN(2, true);
            MaQuyetDinh = 0;
            
        }
       
        private void UpdateQuyetDinh()
        {
            ExecuteProcedure_BDDatNN(10, false);
        }
        private void ExecuteProcedure_BDDatNN(int _flag, bool _getData)
        {
            try{
                
                string[] Paras = new string[] { "@flag", "@MaDangKyBienDong", "@MaQuyetDinh"};
                string[] Values = new string[] { _flag.ToString(), MaDKBD.ToString(),MaQuyetDinh.ToString()};
                string spName;

                spName = "spQuyetDinhBienDongDatNN";
                if (_getData == false)
                {
                    int kq = cls.ExecuteSP(spName, Paras, Values);
                    if (kq > 0)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thực thi spQuyetDinhBienDongDatNN");
                    }
                }
                else
                    {
                        dsQD.Tables.Clear();
                        dsQD = cls.GetData(spName, Paras, Values);
                        if (dsQD.Tables[0].Rows.Count > 0)
                        {
                            dtgrvQuyetDinh.DataSource = dsQD.Tables[0];
                        }
                        else
                        {
                            dtgrvQuyetDinh.DataSource = dsQD.Tables[0];
                            //MessageBox.Show("Không có kết quả spQuyetDinhBienDongDatNN");
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ExecuteProcedure lỗi \n"+ex.Message);
            }
        }
        private void dtgrvQuyetDinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaQuyetDinh= Convert.ToInt32(dtgrvQuyetDinh.CurrentRow.Cells["MaQuyetDinh"].Value);
            txtSoQuyetDinh.Text = dtgrvQuyetDinh.CurrentRow.Cells["SoQuyetDinh"].Value.ToString();
            txtCoQuanQuyetDinh.Text = dtgrvQuyetDinh.CurrentRow.Cells["CoQuanQuyetDinh"].Value.ToString();
            if (dtgrvQuyetDinh.CurrentRow.Cells["NgayQuyetDinh"].Value.ToString().Trim() != "")
            {
                dtpNgayQuyetDinh.Value = Convert.ToDateTime(dtgrvQuyetDinh.CurrentRow.Cells["NgayQuyetDinh"].Value);
                dtpNgayQuyetDinh.Checked = true;
            }
            else
                dtpNgayQuyetDinh.Checked = false;
        }
        private void LoadThongTinQuyetDinh(int MaBienDong)
        {
            ExecuteProcedure_BDDatNN(0, true);
            for (int i = 0; i < dtgrvQuyetDinh.Columns.Count; i++)
            {
                if (dtgrvQuyetDinh.Columns[i].Name == "MaQuyetDinh")
                {
                    dtgrvQuyetDinh.Columns[i].HeaderText = "Mã quyết định";
                    dtgrvQuyetDinh.Columns[i].Width = 80;
                }
                else if (dtgrvQuyetDinh.Columns[i].Name == "MaDangKyBienDong")
                {
                    dtgrvQuyetDinh.Columns[i].HeaderText = "Mã biến động";
                    dtgrvQuyetDinh.Columns[i].Width = 100;
                }
                else if (dtgrvQuyetDinh.Columns[i].Name == "CoQuanQuyetDinh")
                {
                    dtgrvQuyetDinh.Columns[i].HeaderText = "Cơ quan quyết định";
                    dtgrvQuyetDinh.Columns[i].Width = 200;
                }
                else if (dtgrvQuyetDinh.Columns[i].Name == "NgayQuyetDinh")
                {
                    dtgrvQuyetDinh.Columns[i].HeaderText = "Ngày quyết định";
                    dtgrvQuyetDinh.Columns[i].Width = 100;
                }
                else if (dtgrvQuyetDinh.Columns[i].Name == "NoiDung")
                {
                    dtgrvQuyetDinh.Columns[i].HeaderText = "Nội dung";
                    dtgrvQuyetDinh.Columns[i].Width = 200;
                }
                else if (dtgrvQuyetDinh.Columns[i].Name == "SoQuyetDinh")
                {
                    dtgrvQuyetDinh.Columns[i].HeaderText = "Số quyết định";
                    dtgrvQuyetDinh.Columns[i].Width = 80;
                }
                
            }
        }
        #endregion

        private void CtrlDangKyBienDong_Load(object sender, EventArgs e)
        {
            ReLoad();
        }


        private void LoadNull()
        {
            txtNguoiDangKy.Text = "";
            cmbLoaiBienDong.Text = "";
            rtbNoiDungBienDong.Text = "";
            dtpNgayDangKy.Enabled = false;

            dtpNgayQuyetDinh.Enabled = false;
            txtSoQuyetDinh.Text = "";
            txtCoQuanQuyetDinh.Text = "";
            MaDKBD = 0;
            ExecuteProcedure_BDDatNN(0, true);
        }
        


    }
}
