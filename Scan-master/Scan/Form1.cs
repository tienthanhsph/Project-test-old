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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        DataSet ds = new DataSet();
        private void LoadDVHC()
        {
            try
            {
                ds.Tables.Clear();
                string qr = " select MaDonViHanhChinh,Ten from tblTuDienDonViHanhChinh where MaHuyen <> '0' and MaXa <> '0' order by Ten asc ";
                ds = cls.ExecuteQuery(qr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        comboBox1.Items.Add(ds.Tables[0].Rows[i]["Ten"].ToString().Trim());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TimMaDonViHanhChinh(string Ten)
        {
            try
            {
                ds.Tables.Clear();
                string qr = " select MaDonViHanhChinh from tblTuDienDonViHanhChinh where Ten = N'" + Ten + "'";
                ds = cls.ExecuteQuery(qr);
                clsGlobal.glbMaDonViHanhChinh = ds.Tables[0].Rows[0]["MaDonViHanhChinh"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            clsGlobal.glbRootFolder =  ReadTextFile("RootFileSCAN", "Rootfilescan2.txt");
            clsGlobal.glbConnectionString = ReadTextFile("Connect","ConnectString.txt");
            LoadDVHC();
            if (clsGlobal.glbRootFolder.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn thư mục Root để chứa ảnh!");
                string path = Application.StartupPath + "\\RootFileSCAN\\Rootfilescan2.txt";
                System.Diagnostics.Process.Start(path);
            }
            if (clsGlobal.glbConnectionString.Trim() == "")
            {
                MessageBox.Show("Bạn chưa thiết lập chuỗi kết nối CSDL!");
                string path = Application.StartupPath + "\\Connect\\ConnectString.txt";
                System.Diagnostics.Process.Start(path);
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() != "")
            {
                clsGlobal.glbTenDonViHanhChinh = comboBox1.Text.Trim();
                TimMaDonViHanhChinh(comboBox1.Text.Trim());
                frmTimKiem timkiem = new frmTimKiem();
                this.Hide();
                timkiem.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đơn vị hành chính!");
            }
        }
        public string ReadTextFile(string DirName, string FileName)
        {
            if (FileName.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn file!");
                return "";
            }
            string content = "";
            string path = Application.StartupPath;
            if (DirName.Trim() != "")
            {
                if (!Directory.Exists(path + "\\" + DirName))
                {
                    Directory.CreateDirectory(path + "\\" + DirName);
                }
                DirName = "\\" + DirName;
            }
            
            path += DirName+"\\"+FileName;
            if (!File.Exists(path))
            {
                try
                {
                    FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    MessageBox.Show(path + "\n Đã được tạo.");
                    file.Close();
                    System.Diagnostics.Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            try
            {
                content = File.ReadAllText(path).Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (content == "")
            {
                MessageBox.Show("File " + path + " chưa có nội dung!");
                return "";
            }
            else
            {
                return content;
            }
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
        	clsGlobal.glbTenDonViHanhChinh = comboBox1.Text.Trim();
            TimMaDonViHanhChinh(comboBox1.Text.Trim());
            RenameFile frm = new RenameFile();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        
    }
}
