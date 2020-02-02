using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cExcel=  Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;

namespace Excel_Read
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string folder = "";
        string file = "";
        string path = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.Text = "Quản trị";
           // comboBox1.Text = "Marketing";
            //comboBox1.Text = "Thương mại";
            comboBox1.Text = "Tài chính - Ngân hàng";
            #region 
            //cExcel.Application xlApp;
            //cExcel.Workbook xlWorkBook;
            //cExcel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //xlApp = new cExcel.Application();
            //xlWorkBook = xlApp.Workbooks.Open(@"D:\3000 Tieu luan Kinh Te\Links\menu.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            //xlWorkSheet = (cExcel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //MessageBox.Show(xlWorkSheet.get_Range("A8", "A12").Value2.ToString());

            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();


            //cExcel.Application xlApp;
            //cExcel.Workbook xlWorkBook;
            //cExcel.Worksheet xlWorkSheet;
            //cExcel.Range range;

            //string str;
            //int rCnt = 0;
            //int cCnt = 0;

            //xlApp = new cExcel.Application();
            //xlWorkBook = xlApp.Workbooks.Open(@"D:\3000 Tieu luan Kinh Te\Links\menu.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            //xlWorkSheet = (cExcel.Worksheet)xlWorkBook.Worksheets.get_Item(5);

            //range = xlWorkSheet.UsedRange;
            ////string write = "";
            //for (rCnt = 1; rCnt <= range.Rows.Count; rCnt++)
            //{
            //    for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
            //    {
            //        string write = "";
            //        write += "(";
            //        str = (string)(range.Cells[rCnt, cCnt] as cExcel.Range).Value2;
            //        write += str + ")";

                    
            //        //MessageBox.Show(str);
            //    }
            //    //write += "\n";
            //}
            //richTextBox1.Text = write;
            //xlWorkBook.Close(true, null, null);
            //xlApp.Quit();

            //dataGridView1.DataSource = xlWorkSheet;





            //******************************
            #endregion
            LoadContent();
            
            
        }


        private void fmtGridView()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[1].Width=706;
         
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
                folder = comboBox1.Text;
                file = dataGridView1.Rows[i].Cells[0].Value.ToString();
                path = "D:\\3000 Tieu luan Kinh Te\\Data\\Bao_cao_TTTN\\" + folder + "\\" + file + ".doc";
                //MessageBox.Show(@"D:\New folder\New Microsoft Office Word Document.docx");
               // OpenMicrosoftWord(@"D:\Newfolder\NewMicrosoftOfficeWordDocument.docx");
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi "+ex);
            }

        }
        private void LoadContent()
        {
            try
            {
                //comboBox1.Text = "Quản trị";
                string sheet = comboBox1.Text.Trim();
                string query = @"select * from [" + sheet + "$]";
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet DtSet;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\\3000 Tieu luan Kinh Te\\Links\\menu.xls';Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter(query, MyConnection);
                //MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                dataGridView1.DataSource = DtSet.Tables[0];
                MyConnection.Close();
                fmtGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadContent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimKiem(textBox1.Text.Trim());
        }
        //static void OpenMicrosoftWord(string file)
        //{
        //    ProcessStartInfo startInfo = new ProcessStartInfo();
        //    startInfo.FileName = "WINWORD.EXE";
        //    startInfo.Arguments = file;
        //    Process.Start(startInfo);
        //}
        private void TimKiem(string str)
        {
            try
            {
                string sheet = comboBox1.Text.Trim();
                string query = @"select * from [" + sheet + "$] where  ["+ dataGridView1.Columns[1].Name.ToString() +"] like  '%"+str+"%'";
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet DtSet;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\\3000 Tieu luan Kinh Te\\Links\\menu.xls';Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter(query, MyConnection);
                //MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                dataGridView1.DataSource = DtSet.Tables[0];
                MyConnection.Close();
                fmtGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
       
    
    }

   
}


	

	 