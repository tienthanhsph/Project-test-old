/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 6/8/2015
 * Time: 2:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using System.Text;

using System.Threading.Tasks;

//using HtmlAgilityPack;

using Word = Microsoft.Office.Interop.Word;

using System.Runtime.InteropServices;
using System.IO;




namespace aaa
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			try{
			List<string> Input = new List<string>();
			List<string> Output = new List<string>();
			Input.Add("Name");
			Input.Add("CMND");
			Input.Add("DiaChi");
			Output= MyParser.ParseFieldsFromAWordFile(@"C:\Users\Admin\Desktop\aaa\aaa\bin\Debug\haha.docx",Input);
			string kq="";
			foreach(string item in Output)
			{
				kq += item +";";
			}
			MessageBox.Show(kq);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			try{
			OpenConnection();
            sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandType= CommandType.StoredProcedure;
            sqlcom.CommandText = "haha";
            
            sqlcom.Parameters.Add("@MaBD","242");
            reader=sqlcom.ExecuteReader();
            string kq="";
            string truong = textBox1.Text.Trim();
            while (reader.Read())
            {
            	kq += Convert.ToString( reader[truong]);
            }
            MessageBox.Show("ket qua: "+ kq);
            CloseConnection();
			}
			catch(Exception ex)
			{
				CloseConnection();
				MessageBox.Show(ex.Message);
			}
           
		}
		string connection ="  SERVER = 192.168.0.103; DATABASE = georgetown_ThanhTri; User ID = sa; Password = dmc3star";
		public SqlConnection sqlcon = new SqlConnection();
        public SqlCommand sqlcom;
        public  SqlDataReader reader;
        public SqlDataAdapter adt;
        public DataTable tbl = new DataTable();
        public DataSet ds = new DataSet();
        public void OpenConnection()
        {
            try
            {
                if (sqlcon.ConnectionString.Trim() == "")
                    sqlcon.ConnectionString = connection;
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CloseConnection()
        {
            if (sqlcon.State == ConnectionState.Open)
                sqlcon.Close();
        }
		void Button3Click(object sender, EventArgs e)
		{
			// Len Danh Sach Bookmark of file office			
			List<string> listBookmark = new List<string>();	
			List<string> listBookmark2 = new List<string>();
			List<string> listBookmark3 = new List<string>();
			
			listBookmark.Add("ToBanDo");
			listBookmark.Add("SoThua");
			listBookmark.Add("DienTich");
			listBookmark.Add("DiaChi");
			listBookmark.Add("ThoiDiemDangKy");
			//listBookmark.Add("SoHopDong");
			//listBookmark.Add("SoCongChung");
			//listBookmark.Add("CoQuanCongChung");
			listBookmark.Add("DienTichChung");
			listBookmark.Add("DienTichRieng");
			listBookmark.Add("MaSoGCN");
			//listBookmark.Add("ThongTinNhaODeNghiCapGCN");
			
			
			listBookmark2.Add("QuanHe");
			listBookmark2.Add("HoTen");
			listBookmark2.Add("SoDinhDanh");
			listBookmark2.Add("NgayCap");
			listBookmark2.Add("NoiCap");
			listBookmark2.Add("DiaChi");
			
			listBookmark3.Add("QuanHe2");
			listBookmark3.Add("HoTen2");
			listBookmark3.Add("SoDinhDanh2");
			listBookmark3.Add("NgayCap2");
			listBookmark3.Add("NoiCap2");
			listBookmark3.Add("DiaChi2");

			//---------------
			string fileName="";
			if(textBox1.Text.Trim() != "")
				fileName = textBox1.Text.Trim()+".docx";
			else
				fileName = DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss")+".docx";
			
		    string sourcefile = @"C:\Users\Administrator\Desktop\reading\aaa\aaa\bin\Debug\thongbao.docx";
		    string dstnfile =@"C:\Users\Administrator\Desktop\"+fileName;
			var WordApp = new Word.Application();
			Word.Document doc = null;
		    Word.Bookmarks bookmarks = null;
		    Word.Bookmark myBookmark = null;
		    Word.Range bookmarkRange = null;
		 
		    object missing = System.Reflection.Missing.Value;
		    try
		    { 

		    	
		    	string kq = "";
		    	File.Copy(sourcefile, dstnfile,true);		    	
		    	WordApp.Documents.Open(dstnfile);
		        doc = WordApp.ActiveDocument;
		        bookmarks = doc.Bookmarks;
		        
		        //truy van cac truong trong csdl
		        try
		        {
					OpenConnection();
		            sqlcom = sqlcon.CreateCommand();
		            sqlcom.CommandType= CommandType.StoredProcedure;
		            sqlcom.CommandText = "haha";
		            sqlcom.Parameters.Add("@MaBD",comboBox1.Text.Trim());
		            sqlcom.ExecuteNonQuery();
		            CloseConnection();
				}
				catch(Exception ex)
				{
					CloseConnection();
					MessageBox.Show(ex.Message);
				}
		        //-------------
		        
		        #region " Neu lam chi tiet truong hop co nhieu chu su dung va chu chuyen nhuong ; tuy nhien ta dang tien hanh voi 1 chu dau tien!"
//		        foreach(Word.Bookmark bm in bookmarks)
//		        {
//		        	string bmName = bm.Name;
//		        	listBookmark.Add(bmName);
//		        }
//		        
//		        
//		        foreach(string s in listBookmark)
//		        {
//		        	myBookmark = bookmarks[s];
//			        bookmarkRange = myBookmark.Range;
//			        bookmarkRange.Text=kq ;
//		        }
//		        
		       #endregion
		       		    	#region "cach xuong dong"
//		    	string kq = "-	Thửa đất số: {}, Tờ bản đồ số: {} " +Convert.ToChar(11)+
//		    		"-	Địa chỉ: {}"+ Convert.ToChar(11)+
//							"-	Diện tích: {}" +Convert.ToChar(11)+
//							"-	Hình thức sử dụng : riêng: {} m2; chung : {} m2"+
//							"-	Mục đích sử dụng: {}"+
//							"-	Nguồn gốc sử dụng : {}"+
//		    		"-	Nhà ở: {}";
		    	#endregion	
//		       foreach(Word.Bookmark bm in bookmarks)
//		        {
//		        	myBookmark = bookmarks[bm];
//			        bookmarkRange = myBookmark.Range;
//			        bookmarkRange.Text=ds.Tables[0].Rows[0][bm.Name].ToString();
//		        } 
//		        
		    	
		    	
		    	//query 1
		    	
		    	string query1= "select Top(1)* from tmpTam_by_Thanh";
		    	sqlcom.CommandType= CommandType.Text;
		    	OpenConnection();
		    	sqlcom.CommandText = query1;
		    	reader = sqlcom.ExecuteReader();
		    	
		    	while (reader.Read())
		    	{
			    	foreach(string s in listBookmark)
			        {			    		
			    		myBookmark = bookmarks[s];
				        bookmarkRange = myBookmark.Range;
				        bookmarkRange.Text=reader[s].ToString();
			    				        			       
			    	}
		    	}
		    	CloseConnection();
		    	
		    	//query 2
		    	string query2= "select * from tmpTam_by_Thanh2";
		    	OpenConnection();
		    	sqlcom.CommandText = query2;
		    	string TenDVHC = sqlcom.ExecuteScalar().ToString();
		    	CloseConnection();
		    	myBookmark = bookmarks["TenDonViHanhChinh"];
		        bookmarkRange = myBookmark.Range;
		        bookmarkRange.Text=TenDVHC;
		        myBookmark = bookmarks["TenDonViHanhChinh2"];
		        bookmarkRange = myBookmark.Range;
		        bookmarkRange.Text=TenDVHC;
		        
		        
		    	//query 3
		    	string bmChuChuyenNhuong="";
		    	int i=0;
		    	string query3= "select * from tmpTam_by_Thanh3";
		    	OpenConnection();
		    	sqlcom.CommandText = query3;
		    	reader = sqlcom.ExecuteReader();
		    	while (reader.Read())
		    	{
		    		if(i>0)
		    			bmChuChuyenNhuong +=", ";
		    		bmChuChuyenNhuong += reader["QuanHe"]+": "+reader["HoTen"];
		    		i++;
		    	}
		    	CloseConnection();
		    	myBookmark = bookmarks["ChuChuyenNhuong"];
		        bookmarkRange = myBookmark.Range;
		        bookmarkRange.Text= bmChuChuyenNhuong;
		        
		        myBookmark = bookmarks["ChuChuyenNhuong2"];
		        bookmarkRange = myBookmark.Range;
		        bookmarkRange.Text= bmChuChuyenNhuong;
		    	
		    	
		    	//query 4		    
		    	string bmNguoiNhanChuyenNhuong="";
		    	string bmTenNguoiNhanChuyenNhuong="";
		    	int j=0;
		    	string query4= "select * from tmpTam_by_Thanh4";
		    	OpenConnection();
		    	sqlcom.CommandText = query4;
		    	reader = sqlcom.ExecuteReader();
		    	while (reader.Read())
		    	{
		    		if(j>0)
		    			bmNguoiNhanChuyenNhuong +="; " +Convert.ToChar(11)+"";
		    		bmNguoiNhanChuyenNhuong += reader["QuanHe"]+": "+reader["HoTen"] +", CMND số: "+reader["SoDinhDanh"]+
		    				", cấp ngày: "+reader["NgayCap"]+" , nơi cấp: "+ reader["NoiCap"]+" ; địa chỉ thường trú: "+ reader["DiaChi"];
		    		bmTenNguoiNhanChuyenNhuong+= reader["QuanHe"]+": "+reader["HoTen"];
		    		j++;
		    	}
		    	CloseConnection();
		    	myBookmark = bookmarks["NguoiNhanChuyenNhuong"];
		        bookmarkRange = myBookmark.Range;
		        bookmarkRange.Text= bmNguoiNhanChuyenNhuong;
		    	
		        myBookmark = bookmarks["TenNguoiNhanChuyenNhuong"];
		        bookmarkRange = myBookmark.Range;
		        bookmarkRange.Text= bmTenNguoiNhanChuyenNhuong;
		        
		        myBookmark = bookmarks["TenNguoiNhanChuyenNhuong2"];
		        bookmarkRange = myBookmark.Range;
		        bookmarkRange.Text= bmTenNguoiNhanChuyenNhuong;
 				try
		        {
					OpenConnection();
		            sqlcom = sqlcon.CreateCommand();
		            sqlcom.CommandText = "drop table tmpTam_by_Thanh ";	
					sqlcom.CommandText += "drop table tmpTam_by_Thanh2 ";	
					sqlcom.CommandText += "drop table tmpTam_by_Thanh3 ";	
					sqlcom.CommandText += "drop table tmpTam_by_Thanh4 ";	
		            sqlcom.ExecuteNonQuery();
		            CloseConnection();
				}
				catch(Exception ex)
				{
					CloseConnection();
					MessageBox.Show(ex.Message);
				}
		        
		        doc.Close(ref missing,ref missing,ref missing);
		        System.Diagnostics.Process.Start(dstnfile);
		    }
		    catch(Exception ex)
		    {
		    	MessageBox.Show(ex.Message);
		    }
		    finally
		    {
		        if (bookmarkRange != null) Marshal.ReleaseComObject(bookmarkRange);
		        if (myBookmark != null) Marshal.ReleaseComObject(myBookmark);
		        if (bookmarks != null) Marshal.ReleaseComObject(bookmarks);
		        if (doc != null) Marshal.ReleaseComObject(doc);        
		        
		    }
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			comboBox1.Text="242";
			try{
			string query ="select MaDangKyBienDong from tblDangKyBienDong where LoaiBienDong ='CN' and DienTich <> 0";
			OpenConnection();
			 sqlcom = sqlcon.CreateCommand();
            
            sqlcom.CommandText = query;
            reader = sqlcom.ExecuteReader();
            while (reader.Read())
            {
            	comboBox1.Items.Add(reader["MaDangKyBienDong"].ToString());
            }
			CloseConnection();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}




//
//using System;
//
//using System.Collections.Generic;



	public static class MyParser
	
	{
	
		// Method trích thông tin từ file doc/docx
		
		//    filePath: đường dẫn file doc/docx
		
		//    fieldNames: danh sách chuỗi bookmark cần lấy có trong file word
		
		//    return Danh sách kết quả đã parse từ danh sách bookmark tương ứng
		
		public static List<String> ParseFieldsFromAWordFile(String filePath, List<String> fieldNames)
		
		{
		
			List<String> returnedStrings = new List<String>();
			
			var WordApp = new Word.Application();
			
			Word.Document doc = null;
			
			Word.Bookmarks bookmarks = null;
			
			Word.Bookmark myBookmark = null;
			
			Word.Range bookmarkRange = null;
			
			try
			
			{
			
				WordApp.Visible = false;
				
				WordApp.Documents.Open(filePath);
				
				doc = WordApp.ActiveDocument;
				
				bookmarks = doc.Bookmarks;
				
				foreach (String fieldName in fieldNames)
				
				{
				
					myBookmark = bookmarks[fieldName]; // Xác định bookmark
					
					bookmarkRange = myBookmark.Range;  // Xác định vùng bookmark
					
					returnedStrings.Add(bookmarkRange.Text.ToString()); // Lấy giá trị của bookmark
				
				}
				
				WordApp.Documents.Close();
			
			}
			
			finally
			
			{
			
				WordApp.Quit();
				
				if (bookmarkRange != null) Marshal.ReleaseComObject(bookmarkRange);
				
				if (myBookmark != null) Marshal.ReleaseComObject(myBookmark);
				
				if (bookmarks != null) Marshal.ReleaseComObject(bookmarks);
				
				if (doc != null) Marshal.ReleaseComObject(doc);
			
			}
			
			return returnedStrings;
		
		}
		
		
	}

}