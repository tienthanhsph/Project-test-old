/*
 * Created by SharpDevelop.
 * User: viet
 * Date: 8/17/2015
 * Time: 4:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace prjDatNongNghiep
{
	/// <summary>
	/// Description of frmTimKiemHoGiaDinh.
	/// </summary>
	public partial class frmTimKiemHoGiaDinh : Form
	{
		public frmTimKiemHoGiaDinh()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		DataSet ds = new DataSet();
		clsDatabase cls = new clsDatabase();
		
		public int MaHoSo =0;
		public int MaSoGiaDinh =0;
		void BtnTimClick(object sender, EventArgs e)
		{
			string query = "spTimKiemHoGiaDinh";
            string[] Paras = new string[] {"@HoTen","@CMND","@DiaChi"};
            string[] Values = new string[] {txtTenNguoi.Text.Trim(),txtCMND.Text.Trim(),
                                             txtDiaChi.Text.Trim()};
            clsDatabase cls = new clsDatabase();
            DataSet ds = cls.GetData(query, Paras, Values);
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
                if (dataGridView1.Columns[i].Name == "NguoiDaiDien")
                {
                    dataGridView1.Columns[i].HeaderText = "Đại diện gia đình";
                    dataGridView1.Columns[i].Width = 150;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "ThanhVien")
                {
                    dataGridView1.Columns[i].HeaderText = "Thành viên gia đình";
                    dataGridView1.Columns[i].Width = 300;
                    dataGridView1.Columns[i].Visible = true;
                }
               
                if (dataGridView1.Columns[i].Name == "DiaChi")
                {
                    dataGridView1.Columns[i].HeaderText = "Địa chỉ";
                    dataGridView1.Columns[i].Width = 80;
                    dataGridView1.Columns[i].Visible = true;
                }               
                if (dataGridView1.Columns[i].Name == "ID")
                {
                    dataGridView1.Columns[i].HeaderText = "ID";
                    dataGridView1.Columns[i].Width = 30;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "MaHoSoCapGCNDatNN")
                {
                    dataGridView1.Columns[i].HeaderText = "Mã hồ sơ";
                    dataGridView1.Columns[i].Width = 60;
                    dataGridView1.Columns[i].Visible = true;
                }
                if (dataGridView1.Columns[i].Name == "MaDonViHanhChinh")
                {
                    dataGridView1.Columns[i].HeaderText = "Mã xã";
                    dataGridView1.Columns[i].Width = 60;
                    dataGridView1.Columns[i].Visible = true;
                }               
               
            }
            Warning();
        }
		 void Warning()
		 {
		 	if(dataGridView1.Rows.Count>0)
		 	{
		 		for(int i=0;i<dataGridView1.Rows.Count;i++)
		 		{
		 			 dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
		 		}
		 		for(int i=0;i<dataGridView1.Rows.Count;i++)
		 		{
                    //if(dataGridView1.Rows[i].Cells["MaHoSoCapGCNDatNN"].Value.ToString() == "" || dataGridView1.Rows[i].Cells["MaHoSoCapGCNDatNN"].Value.ToString() == "0")
                    // dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
		 			if(dataGridView1.Rows[i].Cells["MaSoGiaDinh"].Value.ToString() == "" || dataGridView1.Rows[i].Cells["MaSoGiaDinh"].Value.ToString() == "0")
		 			 dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
		 		}
		 	}
		 }
		void DataGridView1CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
            {
                MaHoSo = 0;
                MaSoGiaDinh = 0;
            }
            else if (e.Button == MouseButtons.Right)
                {
                    int index = e.RowIndex;
                    if (index < 0)
                        return;
                    Warning();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                    	
                        if (i == index)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Maroon;
                        }
//                        else
//                        {
//                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
//                        }
                    }

                   // MaHoSo = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    if (dataGridView1.Rows[index].Cells["MaSoGiaDinh"].Value != null)
                    {
                        if (dataGridView1.Rows[index].Cells["MaSoGiaDinh"].Value.ToString() != "")
                        {
                            MaSoGiaDinh = Convert.ToInt32(dataGridView1.Rows[index].Cells["MaSoGiaDinh"].Value);
                        }
                    }
                    if (dataGridView1.Rows[index].Cells["MaHoSoCapGCNDatNN"].Value != null)
                    {
                        if (dataGridView1.Rows[index].Cells["MaHoSoCapGCNDatNN"].Value.ToString() != "")
                        {
                            MaHoSo = Convert.ToInt32(dataGridView1.Rows[index].Cells["MaHoSoCapGCNDatNN"].Value);
                        }
                    }  
                
                }
		}
		void BtnChonHoGiaDinhClick(object sender, EventArgs e)
		{
		if(MaSoGiaDinh == 0)
		{
			MessageBox.Show("Chưa chọn hộ gia đình.");
		}
		this.Close();
		}
		
		
	}
}
