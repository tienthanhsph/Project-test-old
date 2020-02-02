using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExePgnFile
{
    public partial class XemVanDau : Form
    {
        public XemVanDau()
        {
            InitializeComponent();
        }
        public string _white = "";
        public string _black = "";
        public string _content = "";

        private int KichThuocBanCo = 400;
        private int KichThuocQuanCo = 36;
        Image img;

        #region "note"
        /*
         Ví dụ một ván đấu:
         * 
         * 
         1.e4 c5 2.c3 Nf6 3.e5 Nd5 4.d4 Nc6 5.Nf3 cxd4 6.cxd4 e6 7.a3 d6 8.Bd3 Qa5+
        9.Bd2 Qb6 10.Nc3 Nxc3 11.Bxc3 dxe5 12.dxe5 Be7 13.O-O Bd7 14.Nd2 Qc7 15.Qg4 O-O-O
        16.Rfc1 Kb8 17.Qc4 Rc8 18.b4 f6 19.Nf3 Qb6 20.Qe4 f5 21.Qe1 a6 22.Rab1 g5
        23.Nd2 Nd4 24.Qe3 Rxc3 25.Rxc3 f4 26.Qe1 g4 27.Ne4 Bc6 28.Nc5 Ka7 29.a4 Bf3
        30.a5 Qd8 31.Bc4 Bxc5 32.bxc5 Qh4 33.gxf3 gxf3 34.Kh1 Rg8 35.Qe4 Rg7 36.Qxd4 Qg5
        37.c6+ Kb8 38.c7+ Rxc7 39.Rg1 Qh5 40.Rg8+ Rc8 41.Qd6+ Ka7  1-0
         
         */

        /*
         kế hoạch là dựng ma trận 8X8
         * mỗi ô phải có trạng thái đánh dấu là 0,1,2 để mô phỏng trạng thái trống, quân ta , quân địch
         mô phỏng những nước đi được phép của từng quân, mỗi quân là một class
         
         * nước đi được phép khi thỏa mãn điều kiện và không có quân nào cản giữa (dựa vào nước đi của từng quân để kiểm tra xem ô có bị cản hay không).
         * nước được ăn khi không phải quân của mình, và không bị chiếu tướng
         * từng đối tượng có lưu và cập nhật những vị trí khả dụng khi click vào đối tượng đó.
         * 
         * 
         * quân cờ là lớp trừu tượng
         * từng loại cờ là lớp kế thừa.
         * 
         * 
         * có sự kiện di chuyển, sự kiện ăn quân, 
         */
        #endregion


        
        #region "Ve Ban Co"
        Graphics g;
        //string pathICON = @"C:\Users\Administrator\OneDrive\WORKING___\ExePgnFile\icon";
        string pathICON = @"C:\Users\HUONG LAN\OneDrive\WORKING___\ExePgnFile\icon";
        private void VeBanCo()
        {
            img = Image.FromFile(pathICON + "\\Table\\Orange.png");
            Rectangle rec = new Rectangle(0, 0, KichThuocBanCo,KichThuocBanCo);
            g = this.panel2.CreateGraphics();
            g.DrawImage(img, rec);
            g.DrawRectangle(new Pen(new SolidBrush(Color.Orange), 3), rec);
        }
        BanCo banco = new BanCo();
        List<QuanCo> DanhSachQuanCo = new List<QuanCo>();
        private void KhoiTaoCacQuanCo()
        {
            DanhSachQuanCo.Clear();
            //List<QuanCo> DanhSachQuanCo = new List<QuanCo>();
            //List<QuanCo> DanhSachQuanCo = new List<QuanCo>();
            // 2 tươngs
            King king1 = new King();
            king1.Name = "King1";
            king1.banco = banco;
            king1._color = "Red";
            king1._Image = "\\King\\" + king1._color + ".png";   
            king1._flag = 1;
            king1._size = new Size(KichThuocQuanCo,KichThuocQuanCo);
            king1._vitri = new ViTri(4, 0);
            king1.TimCacNuocDi();

            King king2 = new King();
            king2.Name = "King2";
            king2.banco = banco;
            king2._color = "Black";
            king2._Image = "\\King\\" + king2._color + ".png";
            king2._flag = 2;
            king2._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            king2._vitri = new ViTri(4, 7);
            king2.TimCacNuocDi();
            
            // 2 hậu
            Queen Queen1 = new Queen();
            Queen1.Name = "Queen1";
            Queen1.banco = banco;
            Queen1._color = "Red";
            Queen1._Image = "\\Queen\\" + Queen1._color + ".png";
            Queen1._flag = 1;
            Queen1._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Queen1._vitri = new ViTri(3, 0);
            Queen1.TimCacNuocDi();

            Queen Queen2 = new Queen();
            Queen2.Name = "Queen2";
            Queen2.banco = banco;
            Queen2._color = "Black";
            Queen2._Image = "\\Queen\\" + Queen2._color + ".png";
            Queen2._flag = 2;
            Queen2._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Queen2._vitri = new ViTri(3, 7);
            Queen2.TimCacNuocDi();
            //4 xe
            Rook Rook11 = new Rook();
            Rook11.Name = "Rook11";
            Rook11.banco = banco;
            Rook11._color = "Red";
            Rook11._Image = "\\Rook\\" + Rook11._color + ".png";
            Rook11._flag = 1;
            Rook11._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Rook11._vitri = new ViTri(0, 0);
            Rook11.TimCacNuocDi();

            Rook Rook12 = new Rook();
            Rook12.Name = "Rook12";
            Rook12.banco = banco;
            Rook12._color = "Red";
            Rook12._Image = "\\Rook\\" + Rook12._color + ".png";
            Rook12._flag = 1;
            Rook12._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Rook12._vitri = new ViTri(7,0);
            Rook12.TimCacNuocDi();


            Rook Rook21 = new Rook();
            Rook21.Name = "Rook21";
            Rook21.banco = banco;
            Rook21._color = "Black";
            Rook21._Image = "\\Rook\\" + Rook21._color + ".png";
            Rook21._flag = 2;
            Rook21._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Rook21._vitri = new ViTri(0, 7);
            Rook21.TimCacNuocDi();

            Rook Rook22 = new Rook();
            Rook22.Name = "Rook22";
            Rook22.banco = banco;
            Rook22._color = "Black";
            Rook22._Image = "\\Rook\\" + Rook22._color + ".png";
            Rook22._flag = 2;
            Rook22._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Rook22._vitri = new ViTri(7, 7);
            Rook22.TimCacNuocDi();
            //4 tịnh
            Bishop Bishop11 = new Bishop();
            Bishop11.Name = "Bishop11";
            Bishop11.banco = banco;
            Bishop11._color = "Red";
            Bishop11._Image = "\\Bishop\\" + Bishop11._color + ".png";
            Bishop11._flag = 1;
            Bishop11._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Bishop11._vitri = new ViTri(2, 0);
            Bishop11.TimCacNuocDi();

            Bishop Bishop12 = new Bishop();
            Bishop12.Name = "Bishop12";
            Bishop12.banco = banco;
            Bishop12._color = "Red";
            Bishop12._Image = "\\Bishop\\" + Bishop12._color + ".png";
            Bishop12._flag = 1;
            Bishop12._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Bishop12._vitri = new ViTri(5, 0);
            Bishop12.TimCacNuocDi();


            Bishop Bishop21 = new Bishop();
            Bishop21.Name = "Bishop21";
            Bishop21.banco = banco;
            Bishop21._color = "Black";
            Bishop21._Image = "\\Bishop\\" + Bishop21._color + ".png";
            Bishop21._flag = 2;
            Bishop21._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Bishop21._vitri = new ViTri(2, 7);
            Bishop21.TimCacNuocDi();

            Bishop Bishop22 = new Bishop();
            Bishop22.Name = "Bishop22";
            Bishop22.banco = banco;
            Bishop22._color = "Black";
            Bishop22._Image = "\\Bishop\\" + Bishop22._color + ".png";
            Bishop22._flag = 2;
            Bishop22._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Bishop22._vitri = new ViTri(5, 7);
            Bishop22.TimCacNuocDi();
            //4 mã
            Knight Knight11 = new Knight();
            Knight11.Name = "Knight11";
            Knight11.banco = banco;
            Knight11._color = "Red";
            Knight11._Image = "\\Knight\\" + Knight11._color + ".png";
            Knight11._flag = 1;
            Knight11._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Knight11._vitri = new ViTri(1, 0);
            Knight11.TimCacNuocDi();

            Knight Knight12 = new Knight();
            Knight12.Name = "Knight12";
            Knight12.banco = banco;
            Knight12._color = "Red";
            Knight12._Image = "\\Knight\\" + Knight12._color + ".png";
            Knight12._flag = 1;
            Knight12._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Knight12._vitri = new ViTri(6, 0);
            Knight12.TimCacNuocDi();


            Knight Knight21 = new Knight();
            Knight21.Name = "Knight21";
            Knight21.banco = banco;
            Knight21._color = "Black";
            Knight21._Image = "\\Knight\\" + Knight21._color + ".png";
            Knight21._flag = 2;
            Knight21._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Knight21._vitri = new ViTri(1, 7);
            Knight21.TimCacNuocDi();

            Knight Knight22 = new Knight();
            Knight22.Name = "Knight22";
            Knight22.banco = banco;
            Knight22._color = "Black";
            Knight22._Image = "\\Knight\\" + Knight22._color + ".png";
            Knight22._flag = 2;
            Knight22._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Knight22._vitri = new ViTri(6, 7);
            Knight22.TimCacNuocDi();
            //16 tốt
            Pawn[] _pawn1 = new Pawn[8];
            for (int i = 0; i < _pawn1.Length;i++ )
            {
                _pawn1[i] = new Pawn();
                _pawn1[i].Name = "_pawn1" + i.ToString();
                _pawn1[i].banco = banco;
                _pawn1[i]._color = "Red";
                _pawn1[i]._Image = "\\Pawn\\" + _pawn1[i]._color + ".png";
                _pawn1[i]._flag = 1;
                _pawn1[i]._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
                _pawn1[i]._vitri = new ViTri(i, 1);
                _pawn1[i].TimCacNuocDi();
                DanhSachQuanCo.Add(_pawn1[i]);
            }
            Pawn[] _pawn2 = new Pawn[8];
            for (int i = 0; i < _pawn2.Length; i++)
            {
                _pawn2[i] = new Pawn();
                _pawn2[i].Name = "_pawn2" + i.ToString();
                _pawn2[i].banco = banco;
                _pawn2[i]._color = "Black";
                _pawn2[i]._Image = "\\Pawn\\" + _pawn2[i]._color + ".png";
                _pawn2[i]._flag = 1;
                _pawn2[i]._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
                _pawn2[i]._vitri = new ViTri(i, 6);
                _pawn2[i].TimCacNuocDi();
                DanhSachQuanCo.Add(_pawn2[i]);
            }
            DanhSachQuanCo.Add(king1);
            DanhSachQuanCo.Add(king2);
            DanhSachQuanCo.Add(Queen1);
            DanhSachQuanCo.Add(Queen2);
            DanhSachQuanCo.Add(Rook11);
            DanhSachQuanCo.Add(Rook12);
            DanhSachQuanCo.Add(Rook21);
            DanhSachQuanCo.Add(Rook22);
            DanhSachQuanCo.Add(Bishop11);
            DanhSachQuanCo.Add(Bishop12);
            DanhSachQuanCo.Add(Bishop21);
            DanhSachQuanCo.Add(Bishop22);
            DanhSachQuanCo.Add(Knight11);
            DanhSachQuanCo.Add(Knight12);
            DanhSachQuanCo.Add(Knight21);
            DanhSachQuanCo.Add(Knight22);
           
           

        }

        private void VeQuanCo()
        {
            foreach (QuanCo quanco in DanhSachQuanCo)
            {
                if (quanco._live == true)
                {
                    img = Image.FromFile(pathICON + quanco._Image);
                    Rectangle rec = new Rectangle((quanco._vitri.x) * (KichThuocBanCo / 8) + (KichThuocBanCo / 8 - KichThuocQuanCo) / 2, (quanco._vitri.y) * (KichThuocBanCo / 8) + (KichThuocBanCo / 8 - KichThuocQuanCo) / 2, KichThuocQuanCo, KichThuocQuanCo);
                    g.DrawImage(img, rec);
                }
            }
        }

        //private void GhiTrangThaiQuanCoRafile()
        //{
        //    foreach (QuanCo quan in DanhSachQuanCo)
        //    { 
        //    richTextBox1 .Text += 
        //    }
        //}
        #endregion


        #region "Su Kien Khi Choi"
        private void _AnQuan()
        {

        }
        private void _NhapThanh()
        {

        }
        private void _ChieuTuong()
        {

        }
        private void _Thang()
        {

        }
        private void _KetThuc()
        {

        }
        #endregion

        #region "Doc Tu File PGN"
        private List<string> NuocDi = new List<string>();
        private void LayNuocDi(string Content)
        { 
        
        }
        int Pause = 0;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            VeBanCo();
            VeQuanCo();
        }

        private void XemVanDau_Load(object sender, EventArgs e)
        {
            label1.Text = "Ván đấu giữa " + _white + " và " + _black;
            KhoiTaoCacQuanCo();
        }
        // cần có cách lưu lại vị trí tất cả quân cờ trong mỗi nước đi.
        // đọc ghi ra file riêng trong mỗi nước đi.
        #endregion

    }
}
