using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BaoCaoDong
{
    public partial class QuanLyThongSo : Form
    {
        public QuanLyThongSo()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        private void btnGanKieu_Click(object sender, EventArgs e)
        {
            GanKieu frm = new GanKieu();
            frm.ShowDialog();
        }

        private void btnCbBox_Click(object sender, EventArgs e)
        {
            CbBoxItems frm = new CbBoxItems();
            frm.ShowDialog();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            EditColumns frm = new EditColumns();
            frm.ShowDialog();
        }
        private void ReadFromText()
        {
            string path = Application.StartupPath;
            path = path.Replace("\\", "\\\\");
            string file = path + "\\NgayCapNhatDuLieuBaoCao.txt";
            string result = "";
            if (!System.IO.File.Exists(file))
            {
                System.IO.File.Create(file);
                MessageBox.Show("Chưa có file NgayCapNhatDuLieuBaoCao.txt!\n Chúng tôi vừa tạo mới file này.");
            }
            string[] text = System.IO.File.ReadAllLines(file);
            if (text.Length == 0)
                result = " Chưa có dữ liệu !";
            else
                result = text[text.Length - 1].Trim();
            lblRefresh.Text = "Dữ liệu được cập nhật lúc: " + result + "\n";
        }
        private void WriteToText()
        {
            string path = Application.StartupPath;
            path = path.Replace("\\", "\\\\");
            string file = path + "\\NgayCapNhatDuLieuBaoCao.txt";

            if (!System.IO.File.Exists(file))
            {
                System.IO.File.Create(file);
                MessageBox.Show("Chưa có file NgayCapNhatDuLieuBaoCao.txt!\n Chúng tôi vừa tạo mới file này.");
            }
            string _date = System.DateTime.Now.ToString();
            System.IO.File.WriteAllText(file, _date);
        }

        
        private void QuanLyThongSo_Load(object sender, EventArgs e)
        {

            ReadFromText();
        }
        string query = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Làm mới lại thông tin \n Bạn sẽ phải đợi một vài phút!", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    query = "_SETUP_MAIN";
                    cls._ChayThuTuc(query);
                    query = "SETUP_BIENDONG";
                    cls._ChayThuTuc(query);
                    query = "TabletblTongHopThongTin";
                    cls._ChayThuTuc(query);
                    query = "TabletblTongHopThongTinBienDong";
                    cls._ChayThuTuc(query);
                    MessageBox.Show("Bạn đã làm mới thành công!");
                    WriteToText();
                    ReadFromText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
