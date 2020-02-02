using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ExePgnFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        private void LoadCmdNguoiChoi()
        {
            cls.Execute_Procedure_NonPara("LoadNguoiChoi");
            string query = " select distinct Name from tblNguoiChoi ";
            DataSet ds = cls.GetData(query);
            cmbNguoiChoi.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count;i++)
            {
                cmbNguoiChoi.Items.Add(ds.Tables[0].Rows[i]["Name"].ToString());
            }
        }

        private void SaveToDatabase(string _fileName)
        {
            bool DangTrongVan = false;            
            string line = "";
            string VanDau="";
            List<string> content = new List<string>();
            StreamReader reader = new StreamReader(_fileName);
            while (!reader.EndOfStream)
            {
                line =reader.ReadLine();
                line = line.Replace('\'',' ');
                if (line.Trim() != "" && line.Trim()[0] == '[')
                {
                    if (DangTrongVan == false)// bat dau van moi
                    {
                        if (VanDau.Trim() != "")
                            content.Add(VanDau);
                        if (content != null && content.Count>10)
                            UpDateTungVanVaoDatabase(content);
                        content.Clear();
                        content.Add(line.Trim());
                        DangTrongVan = true;
                        VanDau = "Content: ";
                    }
                    else
                    {
                        content.Add(line.Trim());
                    }

                }
                else
                {
                    DangTrongVan = false;
                    if (line.Trim() !="")
                        VanDau += line.Trim() + " ";
                }
            }
        }

        string Event = "";
        string Site = "";
        string Date = "";
        string Round = "";
        string White = "";
        string Black = "";
        string Result = "";
        string WhiteElo = "";
        string BlackElo = "";
        string ECO = "";
        string Content = "";
        private void UpDateTungVanVaoDatabase(List<string> NoiDungVanCo)
        {
            try
            {
                Event = "";
                Site = "";
                Date = "";
                Round = "";
                White = "";
                Black = "";
                Result = "";
                WhiteElo = "";
                BlackElo = "";
                ECO = "";
                Content = "";
                foreach (string str in NoiDungVanCo)
                {
                    if (str.Contains("[Event "))
                    {
                        Event = str.Substring(str.IndexOf('"') + 1, str.LastIndexOf('"') - 1 - str.IndexOf('"')).Trim();

                    }
                    if (str.Contains("[Site "))
                    {
                        Site = str.Substring(str.IndexOf('"') + 1, str.LastIndexOf('"') - 1 - str.IndexOf('"')).Trim();
                    }
                    if (str.Contains("[Date "))
                    {
                        Date = str.Substring(str.IndexOf('"') + 1, str.LastIndexOf('"') - 1 - str.IndexOf('"')).Trim();
                    }
                    if (str.Contains("[Round "))
                    {
                        Round = str.Substring(str.IndexOf('"') + 1, str.LastIndexOf('"') - 1 - str.IndexOf('"')).Trim();
                    }
                    if (str.Contains("[White "))
                    {
                        White = str.Substring(str.IndexOf('"') + 1, str.LastIndexOf('"') - 1 - str.IndexOf('"')).Trim();
                        if (White.Trim() != "" && White.Contains(','))
                            White = White.Substring(0, White.IndexOf(','));
                    }
                    if (str.Contains("[Black "))
                    {
                        Black = str.Substring(str.IndexOf('"') + 1, str.LastIndexOf('"') - 1 - str.IndexOf('"')).Trim();
                        if (Black.Trim() != "" && Black.Contains(','))
                            Black = Black.Substring(0, Black.IndexOf(','));
                    }
                    if (str.Contains("[Result "))
                    {
                        Result = str.Substring(str.IndexOf('"') + 1, str.LastIndexOf('"') - 1 - str.IndexOf('"')).Trim();
                    }
                    if (str.Contains("[WhiteElo "))
                    {
                        WhiteElo = str.Substring(str.IndexOf('"') + 1, str.LastIndexOf('"') - 1 - str.IndexOf('"')).Trim();
                    }
                    if (str.Contains("[BlackElo "))
                    {
                        BlackElo = str.Substring(str.IndexOf('"') + 1, str.LastIndexOf('"') - 1 - str.IndexOf('"')).Trim();
                    }
                    if (str.Contains("[ECO "))
                    {
                        ECO = str.Substring(str.IndexOf('"') + 1, str.LastIndexOf('"') - 1 - str.IndexOf('"')).Trim();
                    }
                    if (str.Contains("Content: "))
                    {
                        Content = str.Replace("Content: ", " ").Trim();
                    }
                }

                string query = " INSERT INTO tblPGN " +
                              " (Events, Site, Date, Rounds, White, Black, Result, WhiteElo, BlackElo, ECO, Content) " +
                              " VALUES " +
                              " (N'" + Event + "',N'" + Site + "',N'" + Date + "',N'" + Round + "',N'" + White + "',N'" + Black + "',N'" + Result + "',N'" + WhiteElo + "',N'" + BlackElo + "',N'" + ECO + "',N'" + Content + "')";
                cls.Execute_NonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("aaa" + ex.Message);
            }
             
        }
        private void GetFromDatabase(string query)
        {
            DataSet ds = cls.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        
        private void LocDuLieuTrungNhau()
        {
            cls.Execute_Procedure_NonPara("LocDuLieuTrungNhau");            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCmdNguoiChoi();

            string query = " select Events, Site, Date, Rounds, White, Black, Result, WhiteElo, BlackElo, ECO, Content  from tblPGN ";
            LoadDataGridView(query);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            openfile.Filter = "(*.pgn)|*.pgn";
            openfile.Multiselect = true;
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (string file in openfile.FileNames)
                    {                        
                        SaveToDatabase(file);
                    }
                    //MessageBox.Show("Luu thanh cong du lieu vao Database!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            LocDuLieuTrungNhau();

            string query = " select Events, Site, Date, Rounds, White, Black, Result, WhiteElo, BlackElo, ECO, Content  from tblPGN ";
            LoadDataGridView(query);
            LoadCmdNguoiChoi();
        }

        private void LoadDataGridView(string query)
        {
            DataSet ds = cls.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];

            styleDataGridView();
            label3.Text = "Số kết quả: " + dataGridView1.Rows.Count.ToString();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            cls.Execute_Procedure_NonPara("KhoiTao");

            string query = " select Events, Site, Date, Rounds, White, Black, Result, WhiteElo, BlackElo, ECO, Content  from tblPGN ";
            LoadDataGridView(query);
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            string fileName = DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss") + ".pgn";
            string path =Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                FileStream file =  File.Open(path + "\\" + fileName,FileMode.Append);
                StreamWriter write = new StreamWriter(file);
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)                
                {                   
                    write.WriteLine("[Event \""+dataGridView1.Rows[i].Cells[0].Value.ToString().Trim()+"\"]");
                    write.WriteLine("[Site \""+dataGridView1.Rows[i].Cells[1].Value.ToString().Trim()+"\"]");
                    write.WriteLine("[Date \""+dataGridView1.Rows[i].Cells[2].Value.ToString().Trim()+"\"]");
                    write.WriteLine("[Round \""+dataGridView1.Rows[i].Cells[3].Value.ToString().Trim()+"\"]");
                    write.WriteLine("[White \"["+(i+1).ToString()+"] "+dataGridView1.Rows[i].Cells[4].Value.ToString().Trim()+"\"]");
                    write.WriteLine("[Black \""+dataGridView1.Rows[i].Cells[5].Value.ToString().Trim()+"\"]");
                    write.WriteLine("[Result \""+dataGridView1.Rows[i].Cells[6].Value.ToString().Trim()+"\"]");
                    write.WriteLine("[WhiteElo \""+dataGridView1.Rows[i].Cells[7].Value.ToString().Trim()+"\"]");
                    write.WriteLine("[BlackElo \""+dataGridView1.Rows[i].Cells[8].Value.ToString().Trim()+"\"]");
                    write.WriteLine("[ECO \""+dataGridView1.Rows[i].Cells[9].Value.ToString().Trim()+"\"]");
                    write.Write("\n");
                    write.WriteLine(dataGridView1.Rows[i].Cells[10].Value.ToString().Trim());
                    write.Write("\n");

               
                 
                    
                }
                    write.Close();
                file.Close();
                MessageBox.Show("Xong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                string query = " select  Events, Site, Date, Rounds, White, Black, Result, WhiteElo, BlackElo, ECO, Content  from tblPGN where 1=1 ";
                if (ELO.Value != 0 || ELO.Value != null)
                {
                    query += " and (WhiteElo >= '" + ELO.Value.ToString() + "' or BlackElo >= '" + ELO.Value.ToString() + "') ";
                }
                if (chkLoaiBoTranHoa.Checked == true)
                { query += " and Result <> '1/2-1/2' "; }
                if (cmbNguoiChoi.Text.Trim() == "")
                {
                    LoadDataGridView(query);

                }
                else
                {
                    string dieukien = "";
                    if (chkWin.Checked == true)
                    {
                        dieukien += " and ((Result = '1-0' and White ='" + cmbNguoiChoi.Text.Trim() + "') or (Result = '0-1' and Black ='" + cmbNguoiChoi.Text.Trim() + "') )";
                    }
                    else
                    {
                        dieukien += " and (White ='" + cmbNguoiChoi.Text.Trim() + "' or  Black ='" + cmbNguoiChoi.Text.Trim() + "')";
                    }

                    if (rBTrang.Checked == true)
                    {
                        dieukien += " and White ='" + cmbNguoiChoi.Text.Trim()+"'";
                    }
                    else
                        if (rBDen.Checked == true)
                        {
                            dieukien += " and Black ='" + cmbNguoiChoi.Text.Trim() + "'";
                        }
                        
                    query += dieukien;
                    LoadDataGridView(query);
                }

                //MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void styleDataGridView()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].Name == "Events")
                {
                    dataGridView1.Columns[i].HeaderText = "Sự kiện";
                    dataGridView1.Columns[i].Width = 150;
                    dataGridView1.Columns[i].Visible = false;
                }
                if (dataGridView1.Columns[i].Name == "Site")
                {
                    dataGridView1.Columns[i].HeaderText = "Địa điểm";
                    dataGridView1.Columns[i].Width = 110;
                    dataGridView1.Columns[i].Visible = false;
                }
                if (dataGridView1.Columns[i].Name == "Date")
                {
                    dataGridView1.Columns[i].HeaderText = "Ngày";
                    dataGridView1.Columns[i].Width = 70;
                    dataGridView1.Columns[i].Visible = false;
                }
                if (dataGridView1.Columns[i].Name == "Rounds")
                {
                    dataGridView1.Columns[i].HeaderText = "Vòng đấu";
                    dataGridView1.Columns[i].Width = 50;
                    dataGridView1.Columns[i].Visible = false;
                }
                if (dataGridView1.Columns[i].Name == "White")
                {
                    dataGridView1.Columns[i].HeaderText = "quân Trắng";
                    dataGridView1.Columns[i].Width = 90;
                }
                if (dataGridView1.Columns[i].Name == "Black")
                {
                    dataGridView1.Columns[i].HeaderText = "quân Đen";
                    dataGridView1.Columns[i].Width = 90;
                }
                if (dataGridView1.Columns[i].Name == "Result")
                {
                    dataGridView1.Columns[i].HeaderText = "Kết quả";
                    dataGridView1.Columns[i].Width = 80;
                }
                if (dataGridView1.Columns[i].Name == "WhiteElo")
                {
                   
                    dataGridView1.Columns[i].Width = 70;
                }
                if (dataGridView1.Columns[i].Name == "BlackElo")
                {
                   
                    dataGridView1.Columns[i].Width = 70;
                }
                if (dataGridView1.Columns[i].Name == "ECO")
                {
                    
                    dataGridView1.Columns[i].Width = 45;
                }
                if (dataGridView1.Columns[i].Name == "Content")
                {
                    dataGridView1.Columns[i].HeaderText = "Các bước di chuyển";
                    dataGridView1.Columns[i].Width = 400;
                }
            }
        }


        int _index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != null)
                {
                    _index = dataGridView1.CurrentRow.Index;
                }
                
                XemVanDau vandau = new XemVanDau();
                vandau._white= dataGridView1.Rows[_index].Cells["White"].Value.ToString();
                vandau._black = dataGridView1.Rows[_index].Cells["Black"].Value.ToString();
                vandau._content = dataGridView1.Rows[_index].Cells["Content"].Value.ToString();
                this.Hide();

                vandau.ShowDialog();

                this.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
