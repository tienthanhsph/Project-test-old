using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XemLichSu
{
    public partial class LichSu : Form
    {
        public LichSu()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        clsDatabase cls = new clsDatabase();
        private int CapBac = 0;
        public int MaHoSo { get; set; }
        public int MaBienDong { get; set; }

        private void LichSu_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        int Location_Y_Panel = 10;
        string[] Contents = new string[5];

        
        private void ReLoad()
        {
            TimDanhSachHoSoBienDong();
            for (int i = 0; i < DanhSachMaHoSo.Count; i++)
            {
                
                TreeNode nodeHS = new TreeNode("Hồ sơ: "+DanhSachMaHoSo[i]);
                treeView1.Nodes.Add(nodeHS);
                if (GetMaBienDong(Convert.ToInt32(DanhSachMaHoSo[i])).Length > 0)
                {
                    for (int j = 0; j < GetMaBienDong(Convert.ToInt32(DanhSachMaHoSo[i])).Length; j++)
                    {
                        
                        ds.Tables.Clear();
                        ds = cls.ExecuteQuery(" select * from tblBienDong where MaHoSo =" + DanhSachMaHoSo[i] + " and MaBienDong =" + GetMaBienDong(Convert.ToInt32(DanhSachMaHoSo[i]))[j]);
                         Contents[0]=ds.Tables[0].Rows[0]["MaHoSo"].ToString();
                         Contents[1]=ds.Tables[0].Rows[0]["MaBienDong"].ToString();
                         Contents[2]=Convert.ToDateTime( ds.Tables[0].Rows[0]["NgayBienDong"]).ToString("dd/MM/yyyy");
                         Contents[3]=ds.Tables[0].Rows[0]["LoaiBienDong"].ToString();
                         Contents[4]= ds.Tables[0].Rows[0]["NoiDung"].ToString();

                         if (GetMaBienDong(Convert.ToInt32(DanhSachMaHoSo[i]))[j] == MaBienDong.ToString()) 
                         {
                             Location_Y_Panel += CreatePanel(i, Location_Y_Panel, true, Contents, Contents[1]);
                             
                         }
                           
                         else
                             Location_Y_Panel += CreatePanel(i, Location_Y_Panel, false, Contents, Contents[1]);




                         TreeNode nodeBD = new TreeNode("Biến động: " + Contents[1] + "     (" + Contents[2]+")");
                         nodeBD.Name = Contents[1];
                         nodeHS.Nodes.Add(nodeBD);
                        treeView1.AfterSelect+= treeView1_AfterSelect;
                    }
                }
                
            }
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {  
            if(panel1.Controls.Count>0)   
            foreach(Control grb in this.panel1.Controls)
            {
                
                if (grb.Name == e.Node.Name)
                {
                    grb.BackColor = Color.Red;
                }
                else
                {
                    grb.BackColor = Color.LightBlue;
                }
            }
        }
        private string[] GetMaBienDong(int _MaHoSo)
        {
            string query = " select MaBienDong from tblBienDong where MaHoSo = " + _MaHoSo.ToString();
            return cls.GetList(query, "MaBienDong");
        }
        List<string> DanhSachMaHoSo = new List<string>();
        List<string> DanhSachMaHoSoTruoc = new List<string>();
        List<string> DanhSachMaHoSoSau = new List<string>();
        private void TimDanhSachHoSoBienDong()
        {
            DanhSachMaHoSo.Clear();
            DanhSachMaHoSoTruoc.Clear();
            DanhSachMaHoSoSau.Clear();

            // tìm danh sách hồ sơ trước
            int mahs = MaHoSo;

            while (TimDanhSachHoSoBienDongTruoc(mahs) != 0)
            { 
                int k= TimDanhSachHoSoBienDongTruoc(mahs);
                DanhSachMaHoSoTruoc.Add(k.ToString());
                mahs = k;
            }

            // tìm danh sách hồ sơ sau
            mahs = MaHoSo;

            while (TimDanhSachHoSoBienDongSau(mahs) != 0)
            {
                int k = TimDanhSachHoSoBienDongSau(mahs);
                DanhSachMaHoSoSau.Add(k.ToString());
                mahs = k;
            }


            // bắt đầu thêm vào danh sách chính
            if(DanhSachMaHoSoTruoc.Count>0)
            {
                for (int i =DanhSachMaHoSoTruoc.Count -1; i >=0 ; i--)
                {
                    DanhSachMaHoSo.Add(DanhSachMaHoSoTruoc[i]);
                }
            }
            DanhSachMaHoSo.Add(MaHoSo.ToString());
            if(DanhSachMaHoSoSau.Count>0)
            {
                for (int i = 0; i < DanhSachMaHoSoSau.Count; i++)
                {
                    DanhSachMaHoSo.Add(DanhSachMaHoSoSau[i]);
                }
            }
             
        }
        private int TimDanhSachHoSoBienDongTruoc(int _MaHoSo)
        {
            int kq = 0;
            string query = " select MaHoSo from tblBienDong Where MaHoSoMoi =" + _MaHoSo.ToString();
            try
            {
                    kq=Convert.ToInt32(cls.ExecuteQueryScalar(query));
            }
            catch(Exception ex)
            {
            
            }
            return kq;
        }
        private int TimDanhSachHoSoBienDongSau(int _MaHoSo)
        {
            int kq = 0;
            string query = " select MaHoSoMoi from tblBienDong Where MaHoSoMoi is not null and MaHoSo =" + _MaHoSo.ToString();
            try
            {
                kq = Convert.ToInt32(cls.ExecuteQueryScalar(query));
            }
            catch (Exception ex)
            {

            }
            return kq;
        }



        private int CreatePanel(int CapBac,int Location_Y, bool current, string[] contents, string _Name)
        {
            int _height = 0;
            Panel Pnl = new Panel();
            Pnl.Text = "";
            Pnl.Name = _Name;
            //Pnl.AutoSize = true;
            Pnl.Location = new Point(CapBac * 50+10, Location_Y);
            Pnl.Width = 550;
            if (current == true)
            {
                Pnl.BackColor = Color.Lavender;
            }
            else
            {
                Pnl.BackColor = Color.LightBlue;
            
            }
            int Y=3;
            CreateLabel(Pnl,0,Y,"Mã hồ sơ",contents[0],true);
            CreateLabel(Pnl,180, Y, "Mã biến động", contents[1],true);
            Y += CreateLabel(Pnl, 340, Y, "Ngày biến động", contents[2],false);
            Y += 5 + CreateLabel(Pnl, 0, Y, "Loại biến động", contents[3], false);
            Y += CreateLabel(Pnl, 0, Y, "Nội dung biến động", contents[4], false);
             
            Pnl.Height = Y+5;
            this.panel1.Controls.Add(Pnl);
            _height = Y + 10;             
            return _height;
        }
        private int  CreateLabel(Panel Pnl,int Location_X,int Location_Y, string Caption, string content,bool Bold)
        {
            int _height = 0;
            Label lbl = new Label();
            lbl.Text = Caption + ": " + content;
            if(Bold)
                lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl.AutoSize = true;
            lbl.MaximumSize = new System.Drawing.Size(500, 0);             
            lbl.Location = new Point(20+ Location_X, Location_Y);
            //lbl.BackColor = SystemColors.Info;
            Pnl.Controls.Add(lbl);
            _height = lbl.Height;
            return _height+3;
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }
            
    }
}
