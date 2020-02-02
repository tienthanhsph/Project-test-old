using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using prjTuDienThamSoMacDinh;

namespace prjDatNongNghiep
{
    public partial class ctrlCapGCNDatNN : UserControl
    {
        public ctrlCapGCNDatNN()
        {
            InitializeComponent();
        }

        private void chkDone_CheckedChanged(object sender, EventArgs e)
        {

        }
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		
		
		DataSet ds = new DataSet();
        clsDatabase cls = new clsDatabase();
       
        int MaQuyetDinh=0;
        int ID =0;
        
        public void ReLoad()
        {
            LoadNull();   
//            MaQuyetDinh =  LoadMaQuyetDinh(clsConfig.MaHoSo);
//            ThongTinQuyetDinh(MaQuyetDinh);
            TrangThaiBanDau();
            loadngay();
//            LoadComboBox();
            loadgrv();
        }
        
        public void loadngay()
       
        {
        	dtpNgayQuyetDinh.Format =   DateTimePickerFormat.Custom;
			dtpNgayQuyetDinh.CustomFormat = "dd/MM/yyyy";
        }
        public void loadgrv()
        {
        	
        	DataSet dts = new DataSet();
        	  string[] Paras = new string[] { "@ID","@MaHoSoCapGCNDatNN","@MaQuyetDinh","@flag" };
                 string[] Values = new string[] { ID.ToString(),clsConfig.MaHoSo.ToString(),MaQuyetDinh.ToString(),"4" };
                string spName = "SpQuyetDinhHoSoCapGCNDatNN";
            dts= cls.GetData(spName, Paras, Values);
            if(dts.Tables[0].Rows.Count>0)
            {
           	dgrQuyetDinh.DataSource = dts.Tables[0];
           	
           }
            else
            {
            		dgrQuyetDinh.DataSource = null ;
            }
           ID =0;
           
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
          
        }

        private int Work = 0;
        
        private void LoadNull()
        {
        	txtCoQuanQuyetDinh.Text="";
        	txtSoQuyetDinh.Text="";
        	dtpNgayQuyetDinh.Checked=false;
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
            if (ID  == 0)
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
            if (ID == 0)
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
                 string[] Paras = new string[] { "@ID","@MaHoSoCapGCNDatNN","@MaQuyetDinh","@flag" };
                 string[] Values = new string[] { ID.ToString(),clsConfig.MaHoSo.ToString(),MaQuyetDinh.ToString(),flag.ToString() };
                string spName = "SpQuyetDinhHoSoCapGCNDatNN";
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
                 string[] Paras = new string[] { "@ID","@MaHoSoCapGCNDatNN","@MaQuyetDinh","@flag" };
                 string[] Values = new string[] { ID.ToString(),clsConfig.MaHoSo.ToString(),MaQuyetDinh.ToString(),flag.ToString() };
                string spName = "SpQuyetDinhHoSoCapGCNDatNN";
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
        private void btnOK_Click(object sender, EventArgs e)
        {
             
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
                        if(ID == 0)
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
                      if(ID == 0)
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
		
		void DgrQuyetDinhMouseClick(object sender, MouseEventArgs e)
		{
			if (dgrQuyetDinh.Rows.Count > 0)
			{
				int i = dgrQuyetDinh.CurrentRow.Index ;
				ID  = Convert.ToInt32 ( dgrQuyetDinh.Rows[i].Cells ["ID"].Value .ToString());
				MaQuyetDinh = Convert.ToInt32 ( dgrQuyetDinh.Rows[i].Cells ["MaQuyetDinh"].Value .ToString());
				txtSoQuyetDinh.Text = dgrQuyetDinh.Rows[i].Cells ["SoQuyetDinh"].Value .ToString();
				try{
				dtpNgayQuyetDinh.Value = Convert.ToDateTime(dgrQuyetDinh.Rows[i].Cells ["SoQuyetDinh"].Value .ToString());
				}
				catch
				{
					dtpNgayQuyetDinh.Value = DateTime.Today;
					dtpNgayQuyetDinh.Checked = false;
				}
				txtCoQuanQuyetDinh.Text = dgrQuyetDinh.Rows[i].Cells ["CoQuanQuyetDinh"].Value .ToString();
			}
		}
		void TabPage1Click(object sender, EventArgs e)
		{
	
		}
		void BtnTraCuuQuyetDinhClick(object sender, EventArgs e)
		{
			frmQuyetDinhCapGCNDatNN frm = new frmQuyetDinhCapGCNDatNN();
			frm.ReLoad();
			frm.ShowDialog();
			MaQuyetDinh = frm.MaQuyetDinh ;
			txtSoQuyetDinh.Text = frm.SoQuyetDinh ;
			txtCoQuanQuyetDinh.Text = frm.CoQuanQuyetDinh ;
			string d = frm.NgayQuyetDinh;
			if (d != "")
			{
				dtpNgayQuyetDinh.Value = Convert.ToDateTime(d.ToString());
			}
			
		}
		
		
 #region "TAB 2"
		 void LoadThongTinTab2(int _MaHS)
		 {
		 	if(_MaHS!= 0)
		 	{
		 		string query = "select * from tblHoSoCapGCNDatNN where MaHoSoCapGCNDatNN ="+_MaHS.ToString()+ " and MaDonViHanhChinh ='"+ clsConfig.MaDonVihanhChinh+"' ";
		 		DataSet dts = new DataSet();
		 		try {
		 			dts = cls.ExecuteQuery(query);
		 			if(dts.Tables[0].Rows.Count >0)
		 			{
		 				try
		 				{
		 				dtpNgayVaoSo.Value = Convert.ToDateTime(dts.Tables[0].Rows[0]["NgayVaoSoCapGCN"]);
		 				}
		 				catch
		 				{
		 					dtpNgayVaoSo.Value = DateTime.Today;
		 				
		 				}
		 				try
		 				{
		 				dtpNgayKyGCN.Value = Convert.ToDateTime(dts.Tables[0].Rows[0]["NgayKyGCN"]);
		 				}
		 				catch
		 				{
		 					dtpNgayKyGCN.Value = DateTime.Today;
		 				}
		 				txtNguoiKyGCN.Text = dts.Tables[0].Rows[0]["NguoiKyGCN"].ToString();
		 				txtTieuDeKyGCN.Text=dts.Tables[0].Rows[0]["TieuDeKyGCN"].ToString();
		 				txtSoPhatHanh.Text=dts.Tables[0].Rows[0]["SoPhatHanh"].ToString();
		 				txtTieuDeKyGCN.Text=dts.Tables[0].Rows[0]["NguoiKyGCN"].ToString();
		 				txtSoVaoSo.Text=dts.Tables[0].Rows[0]["SoVaoSoCapGCN"].ToString();
		 			}
		 		} catch (Exception ex) {
		 			
		 			//MessageBox.Show(ex.Message);
		 		}
		 		
		 		
		 	}
		 	
		 	dtpNgayKyGCN.Format= DateTimePickerFormat.Custom;
		 	dtpNgayKyGCN.CustomFormat="dd/MM/yyyy";
		 	
		 	dtpNgayVaoSo.Format=DateTimePickerFormat.Custom;
		 	dtpNgayVaoSo.CustomFormat="dd/MM/yyyy";
		 }
		 void  TrangThaiBanDau_Tab2()
		 {
		 foreach (Control ctrl in panel2.Controls)
            {
                
                if(ctrl is TextBox )
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((TextBox)ctrl).Enabled=false;
                }
                
                else if (ctrl is ComboBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((ComboBox)ctrl).Enabled=false;
                }
               
                else if (ctrl is DateTimePicker)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((DateTimePicker)ctrl).Enabled=false;
                }
            }
           
            btnSua2.Enabled = true;
            btnXoa2.Enabled = true;

            btnOK2.Enabled = false;
            btnCancel2.Enabled = false;
		 }
		 void TrangThaiChucNang_Tab2(){
		 foreach (Control ctrl in panel2.Controls)
            {
                
                if (ctrl is TextBox)
                {
                    ctrl.BackColor = Color.White;
                    ((TextBox)ctrl).Enabled= true;
                    
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
           
            btnSua2.Enabled = false;
            btnXoa2.Enabled = false;

            btnOK2.Enabled = true;
            btnCancel2.Enabled = true;
		 }
		 void TrangThaiKetThuc_Tab2(){
		  foreach (Control ctrl in panel2.Controls)
            {
               
                if (ctrl is TextBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((TextBox)ctrl).Enabled=false;
                    ctrl.Text = "";
                }
               
                else if (ctrl is ComboBox)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((ComboBox)ctrl).Enabled=false;
                    ctrl.Text = "";
                }
                
                else if (ctrl is DateTimePicker)
                {
                    ctrl.BackColor = Color.LemonChiffon;
                    ((DateTimePicker)ctrl).Enabled=false;
                }
            }
          
            btnSua2.Enabled = true;
            btnXoa2.Enabled = true;

            btnOK2.Enabled = false;
            btnCancel2.Enabled = false;
		 }
		 int flag_tab2=0;
		void BtnSua2Click(object sender, EventArgs e)
		{
			flag_tab2 =2;
			TrangThaiChucNang_Tab2();
		}
		void BtnXoa2Click(object sender, EventArgs e)
		{
			flag_tab2=3;
			TrangThaiChucNang_Tab2();
			
		}
		void BtnOK2Click(object sender, EventArgs e)
		{
	 		 switch(flag_tab2)
            {
                case 2:
                    {
                        
	                        int kq= ExeThongTinCapGCN(2);
	                        if (kq > 0)
	                        {
	                        	
	                            //MessageBox.Show("Cập nhật thành công " + kq.ToString());
	                        }
	                        else
	                        {
	                            MessageBox.Show("Không Update thành công");
	                        }  
                        }
                        break;
                   
                case 3:
                    {
                     
	                        int kq= ExeThongTinCapGCN(3);
	                        if (kq > 0)
	                        {
	                            MessageBox.Show("Xóa thành công " );
	                            
	                        }
	                        else
	                        {
	                            MessageBox.Show("Không xóa thành công");
	                        }  
                       
                        break;
                    }
               
            }

	 		 TrangThaiKetThuc_Tab2();
	 		 LoadThongTinTab2(clsConfig.MaHoSo);
	 		 flag_tab2=0;
        
		}
		void BtnCancel2Click(object sender, EventArgs e)
		{
			TrangThaiKetThuc_Tab2();
			flag_tab2=0;
		}
		void TabPage2Click(object sender, EventArgs e)
		{
	
		}
		
		private string d = "";
		private string dvaoso ="";
		public void ngay()
		{
			if (dtpNgayKyGCN.Checked == true)
			{
				d = dtpNgayKyGCN.Value.ToString();
			}
			else
			{
				d = null;
			}
			if (dtpNgayVaoSo .Checked == true)
			{
				dvaoso = dtpNgayVaoSo.Value.ToString();
			}
			else
			{
				dvaoso = "";
			}
		
		}
		 private int ExeThongTinCapGCN(int flag)
        {
        	int kq=0;
            try
            {
            	ngay();
//           

                 string[] Paras = new string[] { "@MaHoSoCapGCNDatNN","@NgayVaoSoCapGCN","@NgayKyGCN","@NguoiKyGCN","@TieuDeKyGCN","@SoPhatHanh","@SoVaoSoCapGCN","@flag" };
                 string[] Values = new string[] { clsConfig.MaHoSo.ToString(),dvaoso.ToString(),d.ToString(),txtNguoiKyGCN.Text,txtTieuDeKyGCN.Text,txtSoPhatHanh.Text,txtSoVaoSo.Text ,flag.ToString() };
              	    string spName = "spUpDateGCNDatNN";
                	kq= cls.ExecuteSP(spName, Paras, Values);


          
//            	if(flag ==2)
//            	{
//            		
//            		string query = " update tblHoSoCapGCNDatNN  "+
//            			" set NgayVaoSoCapGCN ='"+ Convert.ToDateTime(dvaoso.ToString()) + "' "+
//            			" , NgayKyGCN = '"+ Convert.ToDateTime(d.ToString()) +"' "+
//            			" , NguoiKyGCN =N'"+txtNguoiKyGCN.Text+"' "+
//            			" , TieuDeKyGCN =N'"+txtTieuDeKyGCN.Text+"' "+
//            			" , SoPhatHanh =N'"+txtSoPhatHanh.Text+"' "+
//            			" , SoVaoSoCapGCN =N'"+txtSoVaoSo.Text+"' "+
//            			" where MaHoSoCapGCNDatNN ='" + clsConfig.MaHoSo.ToString() + "'";
//            		
//            		
//            		kq =Convert.ToInt32( cls.ExecuteQueryInsertUpdateDelete(query));
//            	}
//            	else if(flag==3)
//            	{
//            		string query = " update tblHoSoCapGCNDatNN  "+
//            			" set NgayVaoSoCapGCN =N'' "+
//            			" , NgayKyGCN = N'' "+
//            			" , NguoiKyGCN =N'' "+
//            			" , TieuDeKyGCN =N'' "+
//            			" , SoPhatHanh =N'' "+
//            			" , SoVaoSoCapGCN =N'' "+
//            			" where MaHoSoCapGCNDatNN ="+clsConfig.MaHoSo;;
//            		
//            		kq =Convert.ToInt32( cls.ExecuteQueryInsertUpdateDelete(query));
//            	}
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return kq;
        }
		 
		 
		
		void TabControl1SelectedIndexChanged(object sender, EventArgs e)
		{
			if(tabControl1.SelectedTab.Name =="tabPage2")
			{
			LoadThongTinTab2(clsConfig.MaHoSo);
			TrangThaiBanDau_Tab2();
			}
		
		}
 #endregion	
       
       
    }
}
