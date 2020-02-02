using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Scan
{
    public partial class frmTimKiem : Form
    {
        clsDatabase cls = new clsDatabase();
        DataSet Result = new DataSet();
       
        private string folderRoot = "";
        private string folderName = "";
        private string path = "";


        string ToBanDo = "";
        string SoThua = "";
        string DiaChi = "";
        string MaDVHC = "";
        string MaHoSoCapGCN = "";
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            this.Text = clsGlobal.glbTenDonViHanhChinh;
            MaDVHC = "";
            chkChonBanDo.Checked = true;
            
            LoadQuyetDinh();
//            Form1 frm = new Form1();
//            clsGlobal.glbSoQuyetDinh = frm.ReadTextFile("QuyetDinh","SoQuyetDinh.txt");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {            
            TimThua();
        }
        private void TimThua()
        {
        	MaHoSoCapGCN="";
            Result.Tables.Clear();
            MaDVHC = clsGlobal.glbMaDonViHanhChinh;
            ToBanDo = textBox1.Text.Trim();
            SoThua = textBox2.Text.Trim();
            DiaChi = textBox3.Text.Trim();
            Result = SelectThuaDat();
            dataGridView1.DataSource = Result.Tables[0];
            FormatGridview();            
        }
        string strIsBanDo = "1";
        int TongSoBanGhi;
        private DataSet SelectThuaDat()
        {
            TongSoBanGhi = 0;
            string[] Paras = new string[] { "@MaDonViHanhChinh", "@ToBanDo", "@SoThua", "@DiaChiThua", "@IsCoBanDo", "@Start", "@End", "@TongSoBanGhi"};
            string[] Values = new string[] { MaDVHC, ToBanDo, SoThua, DiaChi, strIsBanDo, "0", "100", TongSoBanGhi.ToString()};
            DataSet _result = cls.GetData("spSelectThongTinThuaDat100", Paras, Values);
            return _result;
        }

        private void chkChonBanDo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonBanDo.Checked)
            {
                strIsBanDo = "1";
            }
            else
            {
                strIsBanDo = "0";
            }
        }
        private void FormatGridview()
        {
            if (dataGridView1.Columns["DiaChi"] != null)
            {
                dataGridView1.Columns["DiaChi"].Width = 350;
                dataGridView1.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dataGridView1.Columns["DiaChi"].Visible = false;
            }
            if (dataGridView1.Columns["MaHoSoCapGCN"] != null)
            {
                dataGridView1.Columns["MaHoSoCapGCN"].Width = 70;
                dataGridView1.Columns["MaHoSoCapGCN"].HeaderText = "Mã hồ sơ";
                dataGridView1.Columns["MaHoSoCapGCN"].Visible = true;
            }
            if (dataGridView1.Columns["ToBanDo"] != null)
            {
                dataGridView1.Columns["ToBanDo"].Width = 90;
                dataGridView1.Columns["ToBanDo"].HeaderText = "Tờ bản đồ";
                dataGridView1.Columns["ToBanDo"].Visible = true;
            }
            if (dataGridView1.Columns["SoThua"] != null)
            {
                dataGridView1.Columns["SoThua"].Width = 80;
                dataGridView1.Columns["SoThua"].HeaderText = "Số thửa";
                dataGridView1.Columns["SoThua"].Visible = true;
            }
            if (dataGridView1.Columns["DienTich"] != null)
            {
                dataGridView1.Columns["DienTich"].Width = 90;
                dataGridView1.Columns["DienTich"].HeaderText = "Diện tích";
                dataGridView1.Columns["DienTich"].Visible = true;
            }
            if (dataGridView1.Columns["MaSoThuaDat"] != null)
            {
                dataGridView1.Columns["MaSoThuaDat"].Visible = false;
            }
            if (dataGridView1.Columns["Status"] != null)
            {
                dataGridView1.Columns["Status"].Visible = false;
            }
            if (dataGridView1.Columns["SoToTrinh"] != null)
            {
                dataGridView1.Columns["SoToTrinh"].Visible = false;
            }
            if (dataGridView1.Columns["NgayLapToTrinh"] != null)
            {
                dataGridView1.Columns["NgayLapToTrinh"].Visible = false;
            }
            if (dataGridView1.Columns["NgayQuyetDinhCapGCN"] != null)
            {
                dataGridView1.Columns["NgayQuyetDinhCapGCN"].Visible = false;
            }
            if (dataGridView1.Columns["MaDonViHanhChinh"] != null)
            {
                dataGridView1.Columns["MaDonViHanhChinh"].Visible = false;
            }
            if (dataGridView1.Columns["HoTenTimKiem"] != null)
            {
                dataGridView1.Columns["HoTenTimKiem"].Width = 400;
                dataGridView1.Columns["HoTenTimKiem"].HeaderText = "Chủ";
                dataGridView1.Columns["HoTenTimKiem"].Visible = true;
            }
            if (dataGridView1.Columns["HoTenChuChuyenNhuongTimKiem"] != null)
            {
                dataGridView1.Columns["HoTenChuChuyenNhuongTimKiem"].Width = 350;
                dataGridView1.Columns["HoTenChuChuyenNhuongTimKiem"].HeaderText = "Người nhận CN";
                dataGridView1.Columns["HoTenChuChuyenNhuongTimKiem"].Visible = false;
            }
            if (dataGridView1.Columns["MaLoaiBienDong"] != null)
            {
                dataGridView1.Columns["MaLoaiBienDong"].Visible = false;
            }
            if (dataGridView1.Columns["CanhBaoTranhChapKhieuKien"] != null)
            {
                dataGridView1.Columns["CanhBaoTranhChapKhieuKien"].Visible = false;
            }
            if (dataGridView1.Columns["STT"] != null)
            {
                dataGridView1.Columns["STT"].Visible = false;
            }
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //int RowNumber = e.RowIndex;
            //dataGridView1.BackgroundColor = Color.WhiteSmoke;
            //dataGridView1.Rows[RowNumber].DefaultCellStyle.BackColor = Color.Maroon;
            //ToBanDo = dataGridView1.Rows[RowNumber].Cells["ToBanDo"].Value.ToString().Trim();
            //SoThua = dataGridView1.Rows[RowNumber].Cells["SoThua"].Value.ToString().Trim();
            //MaHoSoCapGCN = dataGridView1.Rows[RowNumber].Cells["MaHoSoCapGCN"].Value.ToString().Trim();
        }
        private void Scan(string _Xa, string _MaHS, string _ToBD, string _Thua)
        {
            path = "";
            try
            {
                if (_Xa.Trim() == "" || _MaHS.Trim() == "")
                {
                    MessageBox.Show("Lỗi xảy ra! \n Có thể do chưa chọn hồ sơ?!");
                    return;
                }
                else
                {
                    folderName = _Xa.Trim() + "\\" + _MaHS.Trim() + "_" + _ToBD.Trim() + "_" + _Thua.Trim();
                    path = folderRoot + "\\" + folderName;
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    else
                    {
                        MessageBox.Show("Thư mục đã tồn tại!");
                    }
                    System.Diagnostics.Process.Start(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void MoveFile(string folderSource, string folderDestination)
        {
            int countFileVisible = 0;
            if (folderSource.Trim() == "" || folderDestination.Trim() == "")
            {
                MessageBox.Show("Lỗi xảy ra! \n Không có thư mục gốc hoặc đích!");
                return;
            }
            else
            {
                DirectoryInfo dirSrc = new DirectoryInfo(folderSource);
                FileInfo[] files = dirSrc.GetFiles();
                if (files == null || files.Length < 1)
                {
                    MessageBox.Show("Thư mục: " + folderSource + " Không có file nào!");
                    return;
                }
                else
                {
                    foreach (FileInfo file in files)
                    {
                        if ((file.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                        {
                            countFileVisible++;
                            try
                            {
                                file.MoveTo(folderDestination + "\\" + file.Name);

                            }

                            catch (UnauthorizedAccessException)
                            {

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    if (countFileVisible == 0)
                        MessageBox.Show("Thu mục: " + folderSource + " Không có file nào!");
                    //System.Diagnostics.Process.Start(folderDestination);   
                }
            }
        }

        private void btnXemThuMucAnh_Click(object sender, EventArgs e)
        {
            folderRoot = clsGlobal.glbRootFolder;
            Scan(MaDVHC, MaHoSoCapGCN, ToBanDo, SoThua);
        }

        private void btnMoveFile_Click(object sender, EventArgs e)
        {
            folderRoot = clsGlobal.glbRootFolder;
            Scan(MaDVHC, MaHoSoCapGCN, ToBanDo, SoThua);
            string pathsource = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            MoveFile(pathsource, path);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int RowNumber = e.RowIndex;
                if (RowNumber < 0)
                    return;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i == RowNumber)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Maroon;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
                    
                ToBanDo = dataGridView1.Rows[RowNumber].Cells["ToBanDo"].Value.ToString().Trim();
                SoThua = dataGridView1.Rows[RowNumber].Cells["SoThua"].Value.ToString().Trim();
                MaHoSoCapGCN = dataGridView1.Rows[RowNumber].Cells["MaHoSoCapGCN"].Value.ToString().Trim();
            }
        }
		
		void CmbQuyetDinhSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		private void LoadQuyetDinh()
		{
			folderRoot = clsGlobal.glbRootFolder;
			MaDVHC=clsGlobal.glbMaDonViHanhChinh;
            if (!Directory.Exists(folderRoot + "\\" + MaDVHC))
                Directory.CreateDirectory(folderRoot + "\\" + MaDVHC);
			DirectoryInfo dir = new DirectoryInfo(folderRoot+"\\"+MaDVHC);			
			DirectoryInfo[] subDirs= dir.GetDirectories();
			foreach(DirectoryInfo subDir in subDirs)
			{
				if ((subDir.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
				{
					if(subDir.Name.Contains("QĐ"))								
					{
						cmbQuyetDinh.Items.Add(subDir.Name.Trim());
					}
				}
				
			}
		}
		void BtnTimQuyetDinhClick(object sender, EventArgs e)
		{
			if(cmbQuyetDinh.Text.Trim() == "")
				return ;
			else
			{
				string dirQD = folderRoot +"\\"+MaDVHC +"\\"+cmbQuyetDinh.Text.Trim();
				if(!Directory.Exists(dirQD))
					Directory.CreateDirectory(dirQD);
				System.Diagnostics.Process.Start(dirQD);
			}
		}
		void BtnErrorClick(object sender, EventArgs e)
		{
			string dirError = folderRoot +"\\"+MaDVHC +"\\Hồ sơ không xác định";
			if(!Directory.Exists(dirError))
				Directory.CreateDirectory(dirError);
			System.Diagnostics.Process.Start(dirError);
		}
    }
}
