using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WORK_WITH_PGN_FILES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CHỌN FILE,  Update vào csdl rồi hiển thị ra.
            //Stream myStream = null;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Users\tienthanh.sph\Documents\Visual Studio 2013\Projects\WORK_WITH_PGN_FILES\";
            //openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.Filter = "(*.pgn)|*.pgn";
            openFileDialog1.Multiselect = false;
            //openFileDialog1.RestoreDirectory = true ;
            timer1.Enabled = true;
            timer1.Start();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    StreamReader streamreader = new StreamReader(openFileDialog1.OpenFile());
                    
                    while (!streamreader.EndOfStream)
                        richTextBox1.Text = streamreader.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            XoaSachBang();

            SaveFormToDatabase("tblPGN");
            timer1.Stop();
            timer1.Enabled = false;
            label3.Text = "";
        }




        /// <summary>
        /// CAC HAM XU LY THANH PHAN
        /// </summary>
        /// <param name="TextFileName"></param>
        /// 

        //private void ReadTextToString(string TextFileName)
        //{
        //    string path = @"C:\Users\tienthanh.sph\Documents\Visual Studio 2013\Projects\WORK_WITH_PGN_FILES\" + TextFileName + ".txt";
        //    string[] Files = File.ReadAllLines(path);
        //}
        private string[] ExecuteStringArray(string[] Input)
        {


            string[] Output = new string[Input.Length + 1];
            int stt = 0;
            int _demsodongnoidung = 0;
            int countOuput = -1;
            try
            {

                foreach (string file in Input)
                {

                    if (file.Trim() != "")
                    {

                        if (file.Trim()[0] == '[')
                        {
                            countOuput++;
                            _demsodongnoidung = 0;
                            Output[countOuput] = file;

                        }
                        else
                        {
                            _demsodongnoidung++;
                            if (_demsodongnoidung == 1)
                            {
                                countOuput++;
                                Output[countOuput] = Input[stt] + " ";
                            }
                            else
                                Output[countOuput] += Input[stt] + " ";

                        }
                    }
                    stt++;
                }
                List<string> list = new List<string>(Output);
                list.RemoveRange(countOuput + 1, stt - countOuput);
                Output = list.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(stt + ex.Message);
            }
            return Output;

        }
        string[] Values = new string[11];
        private void SaveStringToDatabase(string[] StringName, string TableName)
        {
            try
            {
                string[] Paras = new string[11] { "@Events", "@Site", "@Date", "@Rounds", "@White", "@Black", "@Result", "@WhiteElo", "@BlackElo", "@ECO", "@Plays" };
                int _Count = 0;
                foreach (string file in StringName)
                {
                    _Count++;
                    string strResult = "";
                    if ((_Count % 11) == 0)
                    {
                        Values[0] = StringName[_Count - 11];
                        Values[1] = StringName[_Count - 10];
                        Values[2] = StringName[_Count - 9];
                        Values[3] = StringName[_Count - 8];
                        Values[4] = StringName[_Count - 7];
                        Values[5] = StringName[_Count - 6];
                        Values[6] = StringName[_Count - 5];
                        Values[7] = StringName[_Count - 4];
                        Values[8] = StringName[_Count - 3];
                        Values[9] = StringName[_Count - 2];
                        Values[10] = StringName[_Count - 1];
                        clsDatabase cls = new clsDatabase();
                        cls.OpenConnect();
                        cls.ExecuteSP("InsertTotblPGN", Paras, Values, ref strResult);
                        //MessageBox.Show(strResult);
                        cls.CloseConnect();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadStringToForm(string[] Str)
        {
            try
            {
                foreach (string file in Str)
                {
                    richTextBox1.Text += file + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadFromDatabaseToForm(string TableName)
        {
            try
            {
                clsDatabase cls = new clsDatabase();
                string[] TextArr = cls.ReadFromTable(TableName);
                int i = 0;
                foreach (string textline in TextArr)
                {
                    i++;
                    if ((i % 11) == 0)
                        richTextBox1.Text += textline + "\n\n";
                    else
                        richTextBox1.Text += textline + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void SaveFormToDatabase(string Tablename)
        {
            try
            {
                if (richTextBox1.Text.Trim() == "")
                {
                    MessageBox.Show("rickTextBox CHUA CO NOI DUNG!");
                    return;
                }
                string sql = " SELECT * FROM information_schema.tables where table_name ='" + Tablename + "'";
                clsDatabase cls = new clsDatabase();
                int kq = cls.Execute_Scalar(sql);
                if (kq == 0)
                {
                    string createTable = "USE [WORK_WITH_PGN_FILE]" +
                                        "GO" +
                        /****** Object:  Table [dbo].[tblPGN]    Script Date: 10/02/2014 11:18:14 ******/
                                        "SET ANSI_NULLS ON" +
                                        "GO" +
                                        "vSET QUOTED_IDENTIFIER ON" +
                                        "GO" +
                                        "CREATE TABLE [dbo].[" + Tablename + "](" +
                                            "[ID] [bigint] IDENTITY(1,1) NOT NULL," +
                                            "[Events] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                                           " [Site] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                                            "[Date] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                                            "[Rounds] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                                            "[White] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                                            "[Black] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                                           " [Result] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                                            "[WhiteElo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                                            "[BlackElo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                                            "[ECO] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                                           " [Plays] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                                         "CONSTRAINT [PK_tblPGN] PRIMARY KEY CLUSTERED " +
                                        "(" +
                                           " [ID] ASC" +
                                        ")WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]" +
                                        ") ON [PRIMARY]";
                    cls.Execute_NonQuery(createTable);
                }
                string[] ReadFromRickTextBox = richTextBox1.Text.Trim().Split('\n');

                string[] Output = ExecuteStringArray(ReadFromRickTextBox);
                SaveStringToDatabase(Output, Tablename);
                MessageBox.Show("Thanh Cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveFormToText(string TextFileName)
        {
            try
            {
                string path = @"C:\Users\tienthanh.sph\Documents\Visual Studio 2013\Projects\WORK_WITH_PGN_FILES\" + TextFileName + ".txt";
                //if (!File.Exists(path))
                //{
                //    FileStream fs = File.Create(path);
                //    fs.Close();

                //}

                // string[] lines = richTextBox1.Text.Trim().Split('\n');

                //CÁCH LÀM NÀY CHƯA HOÀN HẢO, CHỈ GHI ĐC RA FILE .TXT, .PGN, .DOC CON NHUNG FILE NHU EXEL, DOCX,... THI DEU KHONG DUOC
                // SE TIM CACH XU LI SAU, TAM THỜI CHƯƠNG TRÌNH CHỈ DỪNG LẠI TẠI ĐÂY THÔI.

                path = @"C:\Users\tienthanh.sph\Documents\Visual Studio 2013\Projects\WORK_WITH_PGN_FILES\" + TextFileName + ".pgn";
                File.WriteAllText(path, richTextBox1.Text.Trim());
                
                MessageBox.Show("Đã ghi file xong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadFromDataTableToForm(DataTable tbl)
        {
           
            try
            {
                foreach (DataRow row in tbl.Rows)
                {
                    richTextBox1.Text += row[1] + "\n";
                    richTextBox1.Text += row[2] + "\n";
                    richTextBox1.Text += row[3] + "\n";
                    richTextBox1.Text += row[4] + "\n";
                    richTextBox1.Text += row[5] + "\n";
                    richTextBox1.Text += row[6] + "\n";
                    richTextBox1.Text += row[7] + "\n";
                    richTextBox1.Text += row[8] + "\n";
                    richTextBox1.Text += row[9] + "\n";
                    richTextBox1.Text += row[10] + "\n";
                    richTextBox1.Text += row[11] + "\n";
                    richTextBox1.Text += "\n\n";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DataTable tbl = new DataTable();
        string[] Paras = new string[] { "@TenKienTuong" };
        string error = "";


        private void ChonVan(int Maso)
        {
            try
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Chua chon Ten Nguoi");
                    return;
                }
                
                switch (Maso)
                {
                        //XỬ LÝ THEO CÁCH CŨ LÀ GETDATA RA TBL RỒI ĐỌC TỪ TBL RA RICKTEXTBOX1 RẤT CHẬM, MẤT RẤT NHIỀU THỜI GIAN.
                        // SAU KHI THAY THẾ BẰNG SỬ DỤNG EXECUTEREADER THÌ TỐC ĐỘ NHANH HƠN RẤT NHIỀU, ĐÁNG ĐỂ XEM XÉT LẠI!!!!!!!!
                    case 1:
                        {
                            //clsDatabase cls = new clsDatabase();
                            //cls.getValue(ref tbl, "SPChonVanHoa", Paras, Values);
                            richTextBox1.Text = "";
                            clsDatabase cls = new clsDatabase();
                            richTextBox1.Text= cls.Execute_Reader("SPChonVanHoa",textBox1.Text.Trim());
                            //GetData(ref tbl, "SPChonVanHoa");
                            //ReadFromDataTableToForm(tbl);
                            break;
                        }
                    case 2:
                        {
                            //clsDatabase cls = new clsDatabase();
                            //cls.getValue(ref tbl, "SPChonVanThang", Paras, Values);
                            richTextBox1.Text = "";
                            clsDatabase cls = new clsDatabase();
                            richTextBox1.Text= cls.Execute_Reader("SPChonVanThang",textBox1.Text.Trim());
                            //label3.Text = "ĐANG XỬ LÝ...";
                            //GetData(ref tbl, "SPChonVanThang");
                            //ReadFromDataTableToForm(tbl);
                            
                            break;
                        }
                    case 3:
                        {
                            //clsDatabase cls = new clsDatabase();
                            //cls.getValue(ref tbl, "SPChonVanThua", Paras, Values);
                            richTextBox1.Text = "";
                            clsDatabase cls = new clsDatabase();
                            richTextBox1.Text= cls.Execute_Reader("SPChonVanThua",textBox1.Text.Trim());
                            
                            //GetData(ref tbl, "SPChonVanThua");
                            //ReadFromDataTableToForm(tbl);
                            break;
                        }

                    //default:

                    //        MessageBox.Show("CO LOI XAY RA TRONG QUA TRINH LUA CHON");

                }
                
                MessageBox.Show("Xong!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetData(ref DataTable dt, string StoreProcedureName)
        {
            try
            {         
                string[] Values = new string[] { textBox1.Text.Trim() };
                clsDatabase cls = new clsDatabase();
                cls.OpenConnect();
                if (Paras.Length != Values.Length)
                    return "Tham bien va tham tri khong tuong thich";
                else
                    cls.getValue(ref dt, StoreProcedureName, Paras, Values);

                cls.CloseConnect();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                MessageBox.Show("Co loi " + ex.Message);
            }
            return error;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + " -Drawn";
            ChonVan(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + " -Win";
            ChonVan(2);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + " -Lost";
            ChonVan(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "")
            {
                SaveFormToText(textBox2.Text.Trim());
            }
            else
                MessageBox.Show("Ban Can Nhap Ten File Truoc!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XoaSachBang();
            MessageBox.Show("Đã Xóa sạch trong csdl!");
        }
        private void XoaSachBang()
        {
            string delete = "Delete from tblPGN";
            clsDatabase cls = new clsDatabase();
            cls.Execute_NonQuery(delete);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }
        //int _timer=0;
        //int _thoigiantunggiaidoan = 0;
        //int _gd1 = 0;
        //int _gd2 = 0;
        //int _gd3 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //_timer++;
            //if (_timer % 4 == 0)
            //    label3.Text = "ĐANG XỬ LÝ";
            //if (_timer % 4 == 1)
            //    label3.Text = "ĐANG XỬ LÝ .";
            //if (_timer % 4 == 2)
            //    label3.Text = "ĐANG XỬ LÝ ..";
            //if (_timer % 4 == 3)
            //    label3.Text = "ĐANG XỬ LÝ ...";
            //if (_thoigiantunggiaidoan == 1)
            //{
            //    _gd1++;
            //}
            //if (_thoigiantunggiaidoan == 2)
            //{
            //    _gd2++;
            //}
            //if (_thoigiantunggiaidoan == 3)
            //{
            //    _gd3++;
            //}

        }
    }
}
