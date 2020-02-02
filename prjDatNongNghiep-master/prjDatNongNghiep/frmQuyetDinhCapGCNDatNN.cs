/*
 * Created by SharpDevelop.
 * User: viet
 * Date: 8/25/2015
 * Time: 3:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace prjDatNongNghiep
{
	/// <summary>
	/// Description of frmQuyetDinhCapGCNDatNN.
	/// </summary>
	public partial class frmQuyetDinhCapGCNDatNN : Form
	{
		public frmQuyetDinhCapGCNDatNN()
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
       
        public int MaQuyetDinh = 0;
        public string NgayQuyetDinh = "";
        public string  CoQuanQuyetDinh = "";
        public string SoQuyetDinh ="";
        public string ngayquyetdinh = "";
        public string ngaygiaodat = "";
        public string ngaytrinh = "";
        public string ngaytrinhxa = "";
       
        
        public void ReLoad()
        {
            LoadNull();   
//            MaQuyetDinh =  LoadMaQuyetDinh(clsConfig.MaHoSo);
//            ThongTinQuyetDinh(MaQuyetDinh);
			fomatngay ();
            TrangThaiBanDau();
            LoadComboBox();
            loadgrv();
        }
        
        public void loadgrv()
        {
        	
        	DataSet dts = new DataSet();
        	       string[] Paras = new string[] { "@MaQuyetDinh","@SoQuyetDinh","@NgayQuyetDinh","@CoQuanQuyetDinh","@NoiDung","@NgayGiaoDat","@ToTrinh","@NgayTrinh","@CQQD","@ToTrinhXa","@NgayTrinhXa","@CQQDXa","@MaDonViHanhChinh", "@flag" };
                string[] Values = new string[] { MaQuyetDinh.ToString(),txtSoQuyetDinh .Text.Trim(),dtpNgayQuyetDinh.Value .ToString() , txtCoQuanQuyetDinh.Text.Trim(),
                	cboNoiDung.Text,dateNgayGiaoDat.Value  .ToString() ,txtToTrinh.Text.Trim(),dateNgayTrinh.Value  .ToString() ,
                	txtCQQD.Text.Trim(),txtToTrinhXa.Text.Trim(),DateToTrinhXa.Value   .ToString(),txtCQQDXa.Text ,clsConfig.MaDonVihanhChinh.ToString(),       	"4" };
                string spName = "SpQuyetDinhCapGCNDatNN";
            dts= cls.GetData(spName, Paras, Values);
            if(dts.Tables[0].Rows.Count>0)
            {
            	dgrQuyetDinh.DataSource = dts.Tables[0];
            	
            }
            MaQuyetDinh =0;
           
        }
       
        private void TrangThaiBanDau()
        {
            foreach (Control ctrl in panel1.Controls)
            {
                
                if(ctrl is TextBox )
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((TextBox)ctrl).Enabled=false;
                    
                }
                else if(ctrl is RichTextBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((RichTextBox)ctrl).Enabled=false;
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((ComboBox)ctrl).Enabled=false;
                }
                else if (ctrl is NumericUpDown)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((NumericUpDown)ctrl).Enabled=false;
                }
                else if (ctrl is DateTimePicker)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((DateTimePicker)ctrl).Enabled=false;
                }
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
            txtSoQuyetDinh.Enabled = true;
        }
        private void TrangThaiChucNang()
        {
            foreach (Control ctrl in panel1.Controls)
            {
                
                if (ctrl is TextBox)
                {
                    ctrl.BackColor = Color.White;
                    ((TextBox)ctrl).Enabled= true;
                    
                }
                else if (ctrl is RichTextBox)
                {
                    ctrl.BackColor = Color.White;
                    ((RichTextBox)ctrl).Enabled= true;
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.BackColor = Color.White;
                    ((ComboBox)ctrl).AllowDrop = true;
                    ((ComboBox)ctrl).Enabled= true;
                }
                else if(ctrl is DateTimePicker)
                {
                
                	ctrl.BackColor= Color.White;
                	((DateTimePicker)ctrl).Enabled= true;
                	((DateTimePicker)ctrl).Checked = true;
                }
            }
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
//            btnTim.Enabled = true;
            
            btnOK.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void TrangThaiKetThuc()
        {
            foreach (Control ctrl in panel1.Controls)
            {
               
                if (ctrl is TextBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((TextBox)ctrl).Enabled=false;
                    ctrl.Text = "";
                }
                else if (ctrl is RichTextBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((RichTextBox)ctrl).Enabled=false;
                    ctrl.Text = "";
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((ComboBox)ctrl).Enabled=false;
                    ctrl.Text = "";
                }
                else if (ctrl is NumericUpDown)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((NumericUpDown)ctrl).Enabled=false;
                }
                else if (ctrl is DateTimePicker)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((DateTimePicker)ctrl).Enabled=false;
                }
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            btnOK.Enabled = false;
            btnCancel.Enabled = false;
            txtSoQuyetDinh.Enabled = true;
          
        }

        private int Work = 0;
        
        private void LoadNull()
        {
        	txtCoQuanQuyetDinh.Text="";
        	txtSoQuyetDinh.Text="";
        	dtpNgayQuyetDinh.Checked=false;
        }
        
        private int LoadMaQuyetDinh(int _MaHoSo)
        {
        	int maqd=0;
        	DataSet dts = new DataSet();
        	string[] Paras = new string[] { "@MaHoSoCapGCNDatNN","@MaQuyetDinh", "@flag" };
        	string[] Values = new string[] { _MaHoSo.ToString(),MaQuyetDinh.ToString(),"2"};
            string spName = "SpQuyetDinhHoSoCapGCNDatNN";
            dts= cls.GetData(spName, Paras, Values);
            if(dts.Tables[0].Rows.Count>0)
            {
            	maqd =  Convert.ToInt32(dts.Tables[0].Rows[0]["MaQuyetDinh"].ToString());
            	
            }
            return maqd;
        }
        
//        private void ThongTinQuyetDinh(int _MaQuyetDinh)
//        {
//        	DataSet dts = new DataSet();
//        	 string[] Paras = new string[] { "@MaQuyetDinh","@SoQuyetDinh","@NgayQuyetDinh","@CoQuanQuyetDinh", "@flag" };
//            string[] Values = new string[] { _MaQuyetDinh.ToString(),txtSoQuyetDinh .Text.Trim(), dtpNgayQuyetDinh.Value.ToString(), txtCoQuanQuyetDinh.Text.Trim(),"6"};
//            string spName = "SpQuyetDinhCapGCNDatNN";
//            dts= cls.GetData(spName, Paras, Values);
//            if(dts.Tables[0].Rows.Count>0)
//            {
//            	dtpNgayQuyetDinh.Text =dts.Tables[0].Rows[0]["NgayQuyetDinh"].ToString();
//            	txtCoQuanQuyetDinh.Text= dts.Tables[0].Rows[0]["CoQuanQuyetDinh"].ToString();
//            	cmbSoQuyetDinh.Text=dts.Tables[0].Rows[0]["SoQuyetDinh"].ToString();
//            	cmbSoQuyetDinh.ValueMember = _MaQuyetDinh.ToString() ;
//            }
//        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.Gold;
            Work = 1;            
            TrangThaiChucNang();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MaQuyetDinh == 0)
                MessageBox.Show("Chưa chọn quyết định!");
            else
            {
                btnSua.BackColor = Color.Gold;
                Work = 2;
                TrangThaiChucNang();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MaQuyetDinh == 0)
                MessageBox.Show("Chưa chọn quyết định!");
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
            MaQuyetDinh = 0;
            
        }
        private int ExeQuyetDinhDatNN(int flag)
        {
        	int kq=0;
            try
            {
                string _NgayQuyetDinh = "";
                if (dtpNgayQuyetDinh.Checked == true)
                    _NgayQuyetDinh = dtpNgayQuyetDinh.Value.ToString();
                string _NgayGiaoDat = "";
                if (dateNgayGiaoDat.Checked == true)
                    _NgayGiaoDat = dateNgayGiaoDat.Value.ToString();
                string _NgayTrinh = "";
                    if(dateNgayTrinh.Checked== true)
                        _NgayTrinh= dateNgayTrinh.Value.ToString();
                string _NgayTrinhXa = "";
                if (DateToTrinhXa.Checked == true)
                    _NgayTrinhXa = DateToTrinhXa.Value.ToString();


                string[] Paras = new string[] { "@MaQuyetDinh","@SoQuyetDinh","@NgayQuyetDinh","@CoQuanQuyetDinh","@NoiDung","@NgayGiaoDat","@ToTrinh","@NgayTrinh","@CQQD","@ToTrinhXa","@NgayTrinhXa","@CQQDXa","@MaDonViHanhChinh", "@flag" };
                string[] Values = new string[] { MaQuyetDinh.ToString(),txtSoQuyetDinh .Text.Trim(),_NgayQuyetDinh , txtCoQuanQuyetDinh.Text.Trim(),
                	cboNoiDung.Text,_NgayGiaoDat ,txtToTrinh.Text.Trim(),_NgayTrinh,
                	txtCQQD.Text.Trim(),txtToTrinhXa.Text.Trim(),_NgayTrinhXa,txtCQQDXa.Text ,clsConfig.MaDonVihanhChinh.ToString(),       	flag.ToString() };
                string spName = "SpQuyetDinhCapGCNDatNN";
                kq= cls.ExecuteSP(spName, Paras, Values);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return kq;
        }
        
        private DataSet GetDataQuyetDinhDatNN(int flag)
        {
        	DataSet dts = new DataSet();
            try
            {
                string _NgayQuyetDinh = "";
                if (dtpNgayQuyetDinh.Checked == true)
                    _NgayQuyetDinh = dtpNgayQuyetDinh.Value.ToString();
                string _NgayGiaoDat = "";
                if (dateNgayGiaoDat.Checked == true)
                    _NgayGiaoDat = dateNgayGiaoDat.Value.ToString();
                string _NgayTrinh = "";
                if (dateNgayTrinh.Checked == true)
                    _NgayTrinh = dateNgayTrinh.Value.ToString();
                string _NgayTrinhXa = "";
                if (DateToTrinhXa.Checked == true)
                    _NgayTrinhXa = DateToTrinhXa.Value.ToString();

                string[] Paras = new string[] { "@MaQuyetDinh", "@SoQuyetDinh", "@NgayQuyetDinh", "@CoQuanQuyetDinh", "@NoiDung", "@NgayGiaoDat", "@ToTrinh", "@NgayTrinh", "@CQQD", "@ToTrinhXa", "@NgayTrinhXa", "@CQQDXa", "@MaDonViHanhChinh", "@flag" };
                string[] Values = new string[] { MaQuyetDinh.ToString(),txtSoQuyetDinh .Text.Trim(),_NgayQuyetDinh , txtCoQuanQuyetDinh.Text.Trim(),
                	cboNoiDung.Text,_NgayGiaoDat ,txtToTrinh.Text.Trim(),_NgayTrinh,
                	txtCQQD.Text.Trim(),txtToTrinhXa.Text.Trim(),_NgayTrinhXa,txtCQQDXa.Text ,clsConfig.MaDonVihanhChinh.ToString(),       	flag.ToString() };
                string spName = "SpQuyetDinhCapGCNDatNN";
                 dts= cls.GetData(spName, Paras, Values);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return dts;
        }
        
        private bool KiemTraTonTai()
        {
        
        	ds.Tables.Clear();
        	ds= GetDataQuyetDinhDatNN(5);
        	try {
        	if(ds.Tables[0].Rows.Count>0)
        		return true;
        	else 
        		return false;
        	}
        	catch{
        		return false;
        	}
        }
        
        public void checkdate()
        {
        	if (dtpNgayQuyetDinh.Checked == false)
        	{
        		ngayquyetdinh   = "";
        	}
        	else
        	{
        		ngayquyetdinh = dtpNgayQuyetDinh.Text;
        	}
        	if ( dateNgayTrinh  .Checked == false)
        	{
        		ngaytrinh    = "";
        	}
        	else
        	{
        		ngaytrinh = dateNgayTrinh.Text ;
        	}
        	if (dateNgayGiaoDat  .Checked == false)
        	{
        		ngaygiaodat    = "";
        	}
        	else
        	{
        		ngaygiaodat = dateNgayGiaoDat.Text;
        	}
        	
        	if (DateToTrinhXa.Checked == false)
        	{
        		ngaytrinhxa   = "";
        	}
        	else
        	{
        		ngaytrinhxa = DateToTrinhXa.Text ;
        	}
        	
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
        	checkdate ();
            switch(Work)
            {

                case 1:
                    {
            			if(KiemTraTonTai() == true)
            			{
            				MessageBox.Show("Đã tồn tại Quyết định!");
            				break;
            			}
            			else{
            					int kq = ExeQuyetDinhDatNN(1);
		                        if(kq>0)
		                        {
		                        	loadgrv();
		                           // MessageBox.Show("Thêm thành công " + kq.ToString());
		                        }
		                        else
		                        {
		                            MessageBox.Show("Không thêm được quyết định");
		                        } 
		            		}
            			   
                        break;
                    }
                case 2:
                    {
                        if(MaQuyetDinh == 0)
                        {
                            MessageBox.Show("Bạn cần chọn quyết định để thao tác!");
                            return;
                        }
//                        if(KiemTraTonTai() == true)
//            			{
//            				MessageBox.Show("Đã tồn tại Quyết định!");
//            				break;
//            			}
            			else{
	                        int kq= ExeQuyetDinhDatNN(2);
	                        if (kq > 0)
	                        {
	                        	loadgrv();
	                            //MessageBox.Show("Cập nhật thành công " + kq.ToString());
	                        }
	                        else
	                        {
	                            MessageBox.Show("Không Update thành công");
	                        }  
                        }
                        break;
                    }
                case 3:
                    {
                      if(MaQuyetDinh == 0)
                        {
                            MessageBox.Show("Bạn cần chọn quyết định để thao tác!");
                            return;
                        }
                     
            			else{
	                        int kq= ExeQuyetDinhDatNN(3);
	                        if (kq > 0)
	                        {
	                            MessageBox.Show("Xóa thành công " );
	                            loadgrv();
	                        }
	                        else
	                        {
	                            MessageBox.Show("Không xóa thành công");
	                        }  
                        }
                        break;
                    }
               
            }

            TrangThaiKetThuc();
            ReLoad();
            Work = 0;            
          
        }
		void BtnTraCuuCoQuanClick(object sender, EventArgs e)
		{
	
		}
		void BtnChonQuyetDinhClick(object sender, EventArgs e)
		{
			if(clsConfig.MaHoSo == 0 || MaQuyetDinh ==0 || txtSoQuyetDinh .Text.Trim() =="")
			{
				MessageBox.Show("Lỗi!");
				return;
				
			}
			else{
				int kq = cls.ExecuteSP("spCapNhatQuyetDinhDatNN", new string[]{"@MaHoSoCapGCNDatNN","@MaQuyetDinh"},new string[]{clsConfig.MaHoSo.ToString(), MaQuyetDinh.ToString()});
				if(kq >0)
					MessageBox.Show("Thành công!");
				else
					MessageBox.Show("Lỗi!");
			}
			
		}
		void BtnOKClick(object sender, EventArgs e)
		{
	
		}
		public void fomatngay()
		{
			dtpNgayQuyetDinh.Format =   DateTimePickerFormat.Custom;
			dtpNgayQuyetDinh.CustomFormat = "dd/MM/yyyy";
			
			dateNgayGiaoDat.Format = DateTimePickerFormat.Custom;
			dateNgayGiaoDat.CustomFormat  = "dd/MM/yyyy";
			
			dateNgayTrinh.Format =DateTimePickerFormat.Custom;
			dateNgayTrinh.CustomFormat ="dd/MM/yyyy";
			
			DateToTrinhXa.Format = DateTimePickerFormat.Custom;
			DateToTrinhXa.CustomFormat  = "dd/MM/yyyy";
		}
		private void LoadComboBox()
		{
			cboNoiDung.Items.Clear();
			cboNoiDung.Items.Add("");
			cboNoiDung.Items.Add("Về việc giao đất,cấp giấy chứng nhận");
			cboNoiDung.Items.Add("Về việc giao đất");
			cboNoiDung.Items.Add("Về việc cấp giấy chứng nhận");
//			ds.Tables.Clear();
//			//cmbSoQuyetDinh.Items.Clear();
//			ds= GetDataQuyetDinhDatNN(4);
//			cmbSoQuyetDinh.DataSource = ds.Tables[0];
//			cmbSoQuyetDinh.DisplayMember = ds.Tables[0].Columns["SoQuyetDinh"].ToString();
//			cmbSoQuyetDinh.ValueMember = ds.Tables[0].Columns["MaQuyetDinh"].ToString();
		}
	
//		void CmbSoQuyetDinhSelectedIndexChanged(object sender, EventArgs e)
//		{
//			MaQuyetDinh= Convert.ToInt32( cmbSoQuyetDinh.SelectedValue.ToString()) ;
//			ThongTinQuyetDinh(MaQuyetDinh);
////			dts= cls.GetData(
//		}
	
	
		void DgrQuyetDinhMouseClick(object sender, MouseEventArgs e)
		{
			if (dgrQuyetDinh.Rows.Count > 0)
			{
				int i = dgrQuyetDinh.CurrentRow.Index ;
				MaQuyetDinh = Convert.ToInt32 ( dgrQuyetDinh.Rows[i].Cells ["MaQuyetDinh"].Value .ToString());
				txtSoQuyetDinh.Text = dgrQuyetDinh.Rows[i].Cells ["SoQuyetDinh"].Value.ToString();
				try{
					dtpNgayQuyetDinh.Value =Convert.ToDateTime ( dgrQuyetDinh.Rows[i].Cells ["NgayQuyetDinh"].Value .ToString());
				NgayQuyetDinh =  dgrQuyetDinh.Rows[i].Cells ["NgayQuyetDinh"].Value.ToString();
				}
				catch 
				{
					dtpNgayQuyetDinh.Value = DateTime.Today;
					dtpNgayQuyetDinh.Checked = false;
					NgayQuyetDinh =  "" ;
				}
				txtCoQuanQuyetDinh.Text  = dgrQuyetDinh.Rows[i].Cells ["CoQuanQuyetDinh"].Value.ToString();
				cboNoiDung.Text  = dgrQuyetDinh.Rows[i].Cells ["NoiDung"].Value.ToString();
				try{
				dateNgayGiaoDat .Value  = Convert.ToDateTime( dgrQuyetDinh.Rows[i].Cells ["NgayGiaoDat"].Value.ToString());
				}
				catch
				{
					dateNgayGiaoDat.Value = DateTime.Today;
					dateNgayGiaoDat.Checked = false;
				}
				txtToTrinh.Text = dgrQuyetDinh.Rows[i].Cells ["ToTrinh"].Value.ToString();
				try
				{
				dateNgayTrinh.Value  =Convert.ToDateTime( dgrQuyetDinh.Rows[i].Cells ["NgayTrinh"].Value.ToString());
				}
				catch
				{
					dateNgayTrinh.Value = DateTime.Today;
					dateNgayTrinh.Checked = false;
				}
				txtCQQD.Text = dgrQuyetDinh.Rows[i].Cells ["CQQD"].Value.ToString();
				txtToTrinhXa.Text = dgrQuyetDinh.Rows[i].Cells ["ToTrinhXa"].Value.ToString();
				try
				{
				 DateToTrinhXa.Value   =Convert.ToDateTime( dgrQuyetDinh.Rows[i].Cells ["NgayTrinhXa"].Value.ToString());
				}
				catch
				{
					DateToTrinhXa.Value = DateTime.Today;
					dateNgayTrinh.Checked = false;
				}
				txtCQQDXa.Text = dgrQuyetDinh.Rows[i].Cells ["CQQDXa"].Value.ToString();
				SoQuyetDinh  = dgrQuyetDinh.Rows[i].Cells ["SoQuyetDinh"].Value.ToString();
				
				CoQuanQuyetDinh = dgrQuyetDinh.Rows[i].Cells ["CoQuanQuyetDinh"].Value.ToString();
			}
		}
		void BtnTimClick(object sender, EventArgs e)
		{			ds.Tables .Clear();
			ds = GetDataQuyetDinhDatNN(7);
			try
			{
				if (ds.Tables[0].Rows.Count > 0)
				{
					dgrQuyetDinh.DataSource = ds.Tables[0];
				}
				else
				{
					dgrQuyetDinh.DataSource = null;
				}
			}
			catch
			{
				dgrQuyetDinh.DataSource = null;
			}
			
		}
		void BtlLoadClick(object sender, EventArgs e)
		{
			txtSoQuyetDinh.Text = "";
			loadgrv();
		}
	}
}
