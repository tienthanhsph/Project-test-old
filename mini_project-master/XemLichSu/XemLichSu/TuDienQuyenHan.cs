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
    public partial class TuDienQuyenHan : Form
    {
        public TuDienQuyenHan()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        DataSet ds = new DataSet();
        PhanQuyen phanquyen = new PhanQuyen();

        private void TuDienQuyenHan_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnOK.Enabled = btnCancel.Enabled = false;
            ChucNang = 0;
            MaQuyen = 0;
            clsStatic.TrangThaiBanDau(groupBox1);
            LoadDataGridview();
            LoadTreeView();
            LoadCmbMaQuyenCha();
            treeView1.Enabled = true;
        }
        private void LoadDataGridview()
        {
            string query = " select * from tblTuDienQuyenHan";
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
        private void LoadCmbMaQuyenCha()
        {
            string query = "  select distinct MaQuyen from tblTuDienQuyenHan  ";
            string[] items = cls.GetList(query,"MaQuyen");
            cmbMaQuyenCha.Items.Clear();
            foreach (string item in items)
                cmbMaQuyenCha.Items.Add(item);
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
               
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }    
           
        }



        private void LoadContent(int _MaQuyen)
        {
            string query = " select * from tblTuDienQuyenHan where MaQuyen =" + _MaQuyen.ToString();
            ds.Tables.Clear();
            ds = cls.ExecuteQuery(query);
            txtMaQuyen.Text = ds.Tables[0].Rows[0]["MaQuyen"].ToString();
            cmbMaQuyenCha.Text = ds.Tables[0].Rows[0]["MaQuyenCha"].ToString();
            txtYNghia.Text = ds.Tables[0].Rows[0]["YNghia"].ToString();
        }
        int ChucNang = 0;
        int MaQuyen = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (phanquyen.KiemTraQuyen(clsStatic.Username, 16) == false)
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
            if (MaQuyen == 0)
            {
                MessageBox.Show("Chưa chọn quyền!");
                return;
            }
            if (phanquyen.KiemTraQuyen(clsStatic.Username, 16) == false)
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
            if (MaQuyen == 0)
            {
                MessageBox.Show("Chưa chọn quyền!");
                return;
            }
            if (phanquyen.KiemTraQuyen(clsStatic.Username, 16) == false)
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
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnOK.Enabled = btnCancel.Enabled = false;
            ExecuteProcedure(ChucNang);

            clsStatic.TrangThaiKetThuc(groupBox1);
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
            string[] Paras = new string[] { "@flag", "@MaQuyen", "@MaQuyenCha", "@YNghia"};
            string[] Values = new string[]{flag.ToString(), txtMaQuyen.Text.Trim(), cmbMaQuyenCha.Text.Trim(), txtYNghia.Text.Trim()};
            int kq = 0;
            try
            {

                kq = cls.ExecuteSP("spTuDienQuyenHan", Paras, Values);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaQuyen = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MaQuyen"].Value);
            LoadContent(MaQuyen);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MaQuyen = Convert.ToInt32(e.Node.Name);
            LoadContent(MaQuyen);
        }
    }
}
