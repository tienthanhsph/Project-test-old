/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 6/10/2015
 * Time: 9:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace aaa
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        string connection = "  SERVER = 192.168.0.103; DATABASE = georgetown_ThanhTri; User ID = sa; Password = dmc3star";
        public SqlConnection sqlcon = new SqlConnection();
        public SqlCommand sqlcom;
        public SqlDataReader reader;
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
        void Button1Click(object sender, EventArgs e)
        {
            //    string fileName="";
            //if(textBox1.Text.Trim() != "")
            //    fileName = textBox1.Text.Trim()+".docx";
            //else
            //    fileName = DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss")+".docx";
            //object missing = System.Reflection.Missing.Value;
            //string sourcefile = @"C:\Users\Administrator\Desktop\reading\aaa\aaa\bin\Debug\thongbao.docx";
            //string dstnfile =@"C:\Users\Administrator\Desktop\"+fileName;
            //var WordApp = new Word.Application();
            //Word.Document doc = null;
            //File.Copy(sourcefile, dstnfile,true);		    	
            //WordApp.Documents.Open(dstnfile);
            //doc = WordApp.ActiveDocument;



            //doc.Close(ref missing, ref missing, ref missing);
            //System.Diagnostics.Process.Start(dstnfile);





            //-----------------------
            // Len Danh Sach Bookmark of file office			
            List<string> ListFind2Replace = new List<string>();
            List<string> ListFind2Replace2 = new List<string>();
            List<string> ListFind2Replace3 = new List<string>();

            ListFind2Replace.Add("ToBanDo");
            ListFind2Replace.Add("SoThua");
            ListFind2Replace.Add("DienTich");
            ListFind2Replace.Add("DiaChi");
            ListFind2Replace.Add("ThoiDiemDangKy");
            ListFind2Replace.Add("SoHopDong");
            ListFind2Replace.Add("SoCongChung");
            ListFind2Replace.Add("CoQuanCongChung");
            ListFind2Replace.Add("DienTichChung");
            ListFind2Replace.Add("DienTichRieng");
            ListFind2Replace.Add("MaSoGCN");
            ListFind2Replace.Add("ThongTinNhaODeNghiCapGCN");


            ListFind2Replace2.Add("QuanHe");
            ListFind2Replace2.Add("HoTen");
            ListFind2Replace2.Add("SoDinhDanh");
            ListFind2Replace2.Add("NgayCap");
            ListFind2Replace2.Add("NoiCap");
            ListFind2Replace2.Add("DiaChi");

            ListFind2Replace3.Add("QuanHe2");
            ListFind2Replace3.Add("HoTen2");
            ListFind2Replace3.Add("SoDinhDanh2");
            ListFind2Replace3.Add("NgayCap2");
            ListFind2Replace3.Add("NoiCap2");
            ListFind2Replace3.Add("DiaChi2");

            //---------------
            string fileName = "";
            if (textBox1.Text.Trim() != "")
                fileName = textBox1.Text.Trim() + ".docx";
            else
                fileName = DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss") + ".docx";

            string sourcefile = @"C:\Users\Administrator\Desktop\reading\aaa\aaa\bin\Debug\thongbao.docx";
            string dstnfile = @"C:\Users\Administrator\Desktop\" + fileName;
            var WordApp = new Word.Application();
            Word.Document doc = null;
            
            object missing = System.Reflection.Missing.Value;
            try
            {


                string kq = "";
                File.Copy(sourcefile, dstnfile, true);
                WordApp.Documents.Open(dstnfile);
                doc = WordApp.ActiveDocument;
                
                try
                {
                    OpenConnection();
                    sqlcom = sqlcon.CreateCommand();
                    sqlcom.CommandType = CommandType.StoredProcedure;
                    sqlcom.CommandText = "haha";
                    sqlcom.Parameters.Add("@MaBD", "242");
                    sqlcom.ExecuteNonQuery();
                    CloseConnection();
                }
                catch (Exception ex)
                {
                    CloseConnection();
                    MessageBox.Show(ex.Message);
                }
                

                //query 1

                string query1 = "select Top(1)* from tmpTam_by_Thanh";
                sqlcom.CommandType = CommandType.Text;
                OpenConnection();
                sqlcom.CommandText = query1;
                reader = sqlcom.ExecuteReader();

                while (reader.Read())
                {
                    foreach (string s in ListFind2Replace)
                    {
                        FindAndReplace(WordApp, s, reader[s]);
                    }

                }
                CloseConnection();

                //query 2
                string query2 = "select * from tmpTam_by_Thanh2";
                OpenConnection();
                sqlcom.CommandText = query2;
                string TenDVHC = sqlcom.ExecuteScalar().ToString();
                FindAndReplace(WordApp, "TenDVHC", TenDVHC);
                CloseConnection();
                
                //query 3
                string F2RChuChuyenNhuong = "";
                int i = 0;
                string query3 = "select * from tmpTam_by_Thanh3";
                OpenConnection();
                sqlcom.CommandText = query3;
                reader = sqlcom.ExecuteReader();
                while (reader.Read())
                {
                    if (i > 0)
                        F2RChuChuyenNhuong += ", ";
                    F2RChuChuyenNhuong += reader["QuanHe"] + ": " + reader["HoTen"];
                    i++;
                }
                FindAndReplace(WordApp, "ChuChuyenNhuong", F2RChuChuyenNhuong);
                CloseConnection();
                
                //query 4		    
                string F2RNguoiNhanChuyenNhuong = "";
                string F2RTenNguoiNhanChuyenNhuong = "";
                int j = 0;
                string query4 = "select * from tmpTam_by_Thanh4";
                OpenConnection();
                sqlcom.CommandText = query4;
                reader = sqlcom.ExecuteReader();
                while (reader.Read())
                {
                    if (j > 0)
                    {
                        F2RNguoiNhanChuyenNhuong += "; " + Convert.ToChar(11) + "";
                        F2RTenNguoiNhanChuyenNhuong += ", ";
                    }
                       
                    F2RNguoiNhanChuyenNhuong += reader["QuanHe"] + ": " + reader["HoTen"] + ", CMND số: " + reader["SoDinhDanh"] +
                            ", cấp ngày: " + reader["NgayCap"] + " , nơi cấp: " + reader["NoiCap"] + " ; địa chỉ thường trú: " + reader["DiaChi"];
                    F2RTenNguoiNhanChuyenNhuong += reader["QuanHe"] + ": " + reader["HoTen"];
                    j++;
                }
                FindAndReplace(WordApp, "NguoiNhanChuyenNhuong", F2RNguoiNhanChuyenNhuong);
                FindAndReplace(WordApp, "TenNguoiNhanChuyenNhuong", F2RTenNguoiNhanChuyenNhuong);
                CloseConnection();
                
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
                catch (Exception ex)
                {
                    CloseConnection();
                    MessageBox.Show(ex.Message);
                }

                //doc.Close(ref missing, ref missing, ref missing);
                //System.Diagnostics.Process.Start(dstnfile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                doc.Close(ref missing, ref missing, ref missing);
                System.Diagnostics.Process.Start(dstnfile);
                if (doc != null) Marshal.ReleaseComObject(doc);
            }

            #region "old"
            //			Word.Document doc = null;
            //		    Word.Bookmarks bookmarks = null;
            //		    Word.Bookmark myBookmark = null;
            //		    Word.Range bookmarkRange = null;
            //		 
            //		    object missing = System.Reflection.Missing.Value;
            //		    try
            //		    { 
            //
            //		    	
            //		    	string kq = "";
            //		    	File.Copy(sourcefile, dstnfile,true);		    	
            //		    	WordApp.Documents.Open(dstnfile);
            //		        doc = WordApp.ActiveDocument;
            //		        bookmarks = doc.Bookmarks;
            //		        
            //		       
            //		        doc.Close(ref missing,ref missing,ref missing);
            //		        System.Diagnostics.Process.Start(dstnfile);
            //		    }
            //		    catch(Exception ex)
            //		    {
            //		    	MessageBox.Show(ex.Message);
            //		    }
            //		    finally
            //		    {
            //		        if (bookmarkRange != null) Marshal.ReleaseComObject(bookmarkRange);
            //		        if (myBookmark != null) Marshal.ReleaseComObject(myBookmark);
            //		        if (bookmarks != null) Marshal.ReleaseComObject(bookmarks);
            //		        if (doc != null) Marshal.ReleaseComObject(doc);        
            //		        
            //		    }
            #endregion
        }
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application doc, object findText, object replaceWithText)
        {
            if (findText != null && replaceWithText != null)
            {
                //options
                if (replaceWithText.ToString().Trim() == "")
                    replaceWithText = ".........";
                object matchCase = false;
                object matchWholeWord = true;
                object matchWildCards = false;
                object matchSoundsLike = false;
                object matchAllWordForms = false;
                object forward = true;
                object format = false;
                object matchKashida = false;
                object matchDiacritics = false;
                object matchAlefHamza = false;
                object matchControl = false;
                object read_only = false;
                object visible = true;
                object replace = 2;
                object wrap = 1;
                //execute find and replace
                doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                    ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                    ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
            }
            
        }
    }
}
