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
    public partial class PhanQuyen : Form
    {
        public PhanQuyen()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        
        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            lblWarningPassword.Visible = lblWarningUsername.Visible = false;
            
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnOK.Enabled = btnCancel.Enabled = false;
            ChucNang = 0;
            MaQuyen = 0;
            MaUser = 0;
            clsStatic.TrangThaiBanDau(groupBox1);
            LoadDataGridview();
            LoadTreeView();               
            treeView1.Enabled = true;
        }
        private void LoadDataGridview()
        {
            string query = " select * from tblUsers";
            dataGridView1.DataSource = cls.ExecuteQuery(query).Tables[0];

        }
        private void LoadTreeView()
        {
            treeView1.Nodes.Clear();
            TreeNode nodeAdmin = new TreeNode("(1) Admin");
            nodeAdmin.Name = "1";
            AddChildNode(nodeAdmin);
            treeView1.Nodes.Add(nodeAdmin);
            treeView1.ExpandAll();
        }
        private void AddChildNode(TreeNode _Node)
        {
            DataTable _table = new DataTable();
            int _maquyen = Convert.ToInt32(_Node.Name);
            string query = "  select MaQuyen,YNghia from tblTuDienQuyenHan where MaQuyenCha =" + _maquyen.ToString();

            try
            {
                _table = cls.ExecuteQuery(query).Tables[0];
                int NumberNode = _table.Rows.Count;
                if (NumberNode > 0)
                    for (int i = 0; i < NumberNode; i++)
                    {
                        TreeNode Child = new TreeNode("(" + _table.Rows[i]["MaQuyen"].ToString() + ") " + _table.Rows[i]["YNghia"].ToString());
                        Child.Name = _table.Rows[i]["MaQuyen"].ToString();


                        _Node.Nodes.Add(Child);
                        AddChildNode(Child);

                    }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
        int MaUser = 0;
        int ChucNang = 0;
        int MaQuyen = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraQuyen(clsStatic.Username, 11) == false)
            {
                MessageBox.Show("Tài khoản không có quyền thực hiện thao tác này.");
                return;
            }
            ChucNang = 1;
            clsStatic.TrangThaiChucNang(groupBox1);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnOK.Enabled = btnCancel.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MaUser == 0)
            {
                MessageBox.Show("Chưa chọn User!");
                return;
            }
            if (KiemTraQuyen(clsStatic.Username, 10) == false)
            {
                MessageBox.Show("Tài khoản không có quyền thực hiện thao tác này.");
                return;
            }
            ChucNang = 2;
            clsStatic.TrangThaiChucNang(groupBox1);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnOK.Enabled = btnCancel.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MaUser == 0)
            {
                MessageBox.Show("Chưa chọn User!");
                return;
            }
            if (KiemTraQuyen(clsStatic.Username, 10) == false)
            {
                MessageBox.Show("Tài khoản không có quyền thực hiện thao tác này.");
                return;
            }
            ChucNang = 3;
            clsStatic.TrangThaiChucNang(groupBox1);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnOK.Enabled = btnCancel.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ThoaMan == false)
                return;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnOK.Enabled = btnCancel.Enabled = false;
            ExecuteProcedure(ChucNang);

            clsStatic.TrangThaiKetThuc(groupBox1);

            SelectNodeChecked();

            // cập nhật vào giám sát nhập liệu
            string _thaotac = "";
            if (ChucNang == 1)
                _thaotac = "Thêm ";
            else if (ChucNang == 2)
                _thaotac = "Sửa ";
            else if (ChucNang == 3)
                _thaotac = "Xóa ";
            
            string _noidungthaotac ="";
            if (ChucNang == 1)
                _noidungthaotac = _thaotac + " User ";
            else
                _noidungthaotac = _thaotac + " Mã User " + MaUser.ToString();
            clsStatic.GiamSatNhapLieu_save("", _thaotac, "Phân quyền", _noidungthaotac);
            //

            ReLoad();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnOK.Enabled = btnCancel.Enabled = false;
            clsStatic.TrangThaiKetThuc(groupBox1);
            ReLoad();
        }
        private void ExecuteProcedure(int flag)
        {
            string[] Paras = new string[] { "@flag", "@ID", "@Username", "@Password","@Showname" };
            string[] Values = new string[] { flag.ToString(), MaUser.ToString(),txtUsername.Text.Trim(), txtPassword.Text.Trim(), txtShowname.Text.Trim() };
            int kq = 0;
            try
            {

                kq = cls.ExecuteSP("spUsers", Paras, Values);
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

        private void Execute_spQuyenHan(int flag,string _Username, string _QuyenHan)
        {
            string[] Paras = new string[] { "@flag", "@Username", "@MaQuyen"};
            string[] Values = new string[] { flag.ToString(), _Username, _QuyenHan };
            int kq = 0;
            try
            {

                kq = cls.ExecuteSP("spQuyenHan", Paras, Values);
                if (kq > 0)
                {
                    //MessageBox.Show("OK!");
                }
                else
                {
                   // MessageBox.Show("Error!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        bool ThoaMan = true;
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblWarningUsername.Visible = true;
                if (txtUsername.Text.IndexOf(' ') > -1)
                {
                    this.lblWarningUsername.ForeColor = System.Drawing.Color.Red;
                    this.lblWarningUsername.Text = "không cho phép ký tự trắng";
                    ThoaMan = false;
                }
                else
                {
                    if (ChucNang == 1)
                    {
                        string query = " select Username from tblUsers where Username ='" + txtUsername.Text + "' ";
                        if (cls.GetList(query, "Username") != null && cls.GetList(query, "Username").Length > 0)
                        {
                            this.lblWarningUsername.ForeColor = System.Drawing.Color.Red;
                            this.lblWarningUsername.Text = "Username đã tồn tại!";
                            ThoaMan = false;
                            return;

                        }
                       

                    }
                    this.lblWarningUsername.ForeColor = System.Drawing.Color.Green;
                    this.lblWarningUsername.Text = "ok!";
                    ThoaMan = true;
                }
                   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            lblWarningPassword.Visible = true;
            if (txtPassword2.Text == txtPassword.Text)
            {
                lblWarningPassword.ForeColor = System.Drawing.Color.Green;
                lblWarningPassword.Text = "ok!";
                ThoaMan = true;
            }
            else {
                lblWarningPassword.ForeColor = System.Drawing.Color.Red;
                lblWarningPassword.Text = "(*)";
                ThoaMan = false;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                CheckChild(e.Node, e.Node.Checked);
                CheckParent(e.Node, e.Node.Checked);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CheckChild(TreeNode _Node, bool _Checked)
        {
            try
            {
                if (_Checked == false)
                    return;
                if (_Node.Nodes.Count > 0)
                {
                    for (int i = 0; i < _Node.Nodes.Count; i++)
                    {
                        CheckChild(_Node.Nodes[i], _Checked);
                        _Node.Nodes[i].Checked = _Checked;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void CheckParent(TreeNode _Node, bool _Checked)
        {
            try
            {
                if (_Checked == true)
                    return;
                TreeNode _Parent = _Node.Parent;
                if (_Parent != null)
                {
                    _Parent.Checked = false;
                    CheckParent(_Parent, _Checked);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        List<string> Luachon = new List<string>();
        private void SelectNodeChecked()
        {
            
            if (MaUser == 0)
                return;
            Luachon.Clear();
            AddToLuaChon(treeView1.Nodes[0]);
            Execute_spQuyenHan(0, txtUsername.Text, "");
            if (Luachon.Count > 0)
            {
                for (int i = 0; i < Luachon.Count; i++)
                {
                    Execute_spQuyenHan(1, txtUsername.Text, Luachon[i]);
                }
            }

        }
        private void AddToLuaChon(TreeNode _Node)
        {
            
            #region "Phương án 1"
            //if (_Node.Checked == true)
            //{
            //    Luachon.Add(_Node.Name);
            //}
            //if (_Node.Nodes.Count > 0)
            //{
            //    for (int i = 0; i < _Node.Nodes.Count; i++)
            //    {
            //        AddToLuaChon(_Node.Nodes[i]);
            //    }
            //}
            #endregion

            #region "Phương án 2"
            if (_Node.Checked == true)
            {   
                if(_Node.Parent == null)
                    Luachon.Add(_Node.Name);
                else if (_Node.Parent.Checked == false)
                    Luachon.Add(_Node.Name);
                   
            }
            else
            {
                if (_Node.Nodes.Count > 0)
                {
                    for (int i = 0; i < _Node.Nodes.Count; i++)
                    {
                        AddToLuaChon(_Node.Nodes[i]);
                    }
                }
            }
            
            #endregion

        }
        private void LoadPhanQuyenChoUser()
        {
           
            LoadTreeView();
            string _Username = "";
            if (txtUsername.Text != "")
            {
                _Username = txtUsername.Text.Trim();
            }

            string query = " select * from tblQuyenHan where Username ='" + _Username + "' ";
            string[] TongHopQuyen = cls.GetList(query, "MaQuyen");
            setChecked2TreeNode(treeView1.Nodes[0], TongHopQuyen);
            
        }
        private void setChecked2TreeNode(TreeNode _Node, string[] _MaQuyen)
        {
            for (int i = 0; i < _MaQuyen.Length; i++)
            {
                if (_Node.Name == _MaQuyen[i])
                    _Node.Checked = true;
            }
            if (_Node.Nodes.Count > 0)
            {
                for (int i = 0; i < _Node.Nodes.Count; i++)
                {
                    setChecked2TreeNode(_Node.Nodes[i], _MaQuyen);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                MaUser = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txtShowname.Text = dataGridView1.Rows[e.RowIndex].Cells["Showname"].Value.ToString();
                txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txtPassword2.Text = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                LoadPhanQuyenChoUser();
            }
           
        }

        public bool KiemTraQuyen(string _Username, int _MaQuyen)
        {
            string query = " select MaQuyen from tblQuyenHan where Username ='" + _Username + "' ";
            string[] DsMaQuyen = cls.GetList(query, "MaQuyen");
            if (DsMaQuyen.Length > 0)
            {
                for (int i = 0; i < DsMaQuyen.Length; i++)
                {
                    if( KiemTraMaQuyen(Convert.ToInt32( DsMaQuyen[i]), _MaQuyen) == true)
                        return true;
                }
                
            }
            return false;
        }
        private bool KiemTraMaQuyen(int _MaQuyenHienTai, int _MaQuyen)
        {
            if (_MaQuyenHienTai == _MaQuyen)
                return true;
            string query = " select MaQuyen from tblTuDienQuyenHan where MaQuyenCha ='" + _MaQuyenHienTai + "' ";
            string[] DsMaQuyen = cls.GetList(query, "MaQuyen");
            if (DsMaQuyen.Length > 0)
            {
                for (int i = 0; i < DsMaQuyen.Length; i++)
                {
                    if (Convert.ToInt32(DsMaQuyen[i]) == _MaQuyen)
                        return true;
                    else
                    {
                        if (KiemTraMaQuyen(Convert.ToInt32(DsMaQuyen[i]), _MaQuyen) == true)
                            return true;
                    }
                }

            }
            return false;
        }
    }
}
