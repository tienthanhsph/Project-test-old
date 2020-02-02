using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ExePgnFile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        #region "Test Graphics"
        Graphics g;
        string pathICON =@"C:\Users\Administrator\OneDrive\WORKING___\ExePgnFile\icon";
        private void Paint()
        {
            Image img = Image.FromFile(pathICON+"\\Table\\Orange.png");
            Rectangle rec = new Rectangle(0,0,400,400);
            g= this.CreateGraphics();
            g.DrawImage(img, rec);
            g.DrawRectangle(new Pen(new SolidBrush(Color.Orange),3), rec);
        }
        private void PainKnight()
        {
            int x = 50 * 4+6;
            int y = 50 * 5 + 6;
            Rectangle recChess = new Rectangle(x, y, 36, 36);
            Image knight = Image.FromFile(pathICON + "\\Knight\\Red.png");
            g.DrawImage(knight, recChess);
            
        }

        private void PainKnight2()
        {
            int x = 50 * 5 + 6;
            int y = 50 * 7 + 6;
            Rectangle recChess = new Rectangle(x, y, 36, 36);
            Image knight = Image.FromFile(pathICON + "\\Knight\\Red.png");
            g.DrawImage(knight, recChess);

        }
        private void DrawChessByImageControl()
        {
            int x = 50 * 4 + 6;
            int y = 50 * 5 + 6;
            PictureBox pic = new PictureBox();
            pic.Location = new Point(x,y);
            pic.Size = new Size(36, 36);
            Image knight = Image.FromFile(pathICON + "\\Knight\\Red.png");
            pic.BackgroundImage = knight;
            pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Paint();
            //PainKnight();
           // DrawChessByImageControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Paint();
            PainKnight2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Paint();
            PainKnight();
        }
#endregion

        #region "Test Class"
        private void Test()
        {
            A cls = new A();
            richTextBox1.Text += cls.Method() +"\n";
            richTextBox1.Text += "\n";

            A cls2 = new B();
            richTextBox1.Text += cls2.Method() + "\n";
           // richTextBox1.Text += ((B)cls2).MethodB() + "\n";
            richTextBox1.Text += "\n";

            A cls3 = new C();
            richTextBox1.Text += cls3.Method() + "\n";
            //richTextBox1.Text += ((C)cls3).MethodC() + "\n";
            richTextBox1.Text += "\n";

            A cls4 = new D();
            richTextBox1.Text += cls4.Method() + "\n";
            //richTextBox1.Text += ((D)cls4).MethodD() + "\n";
            richTextBox1.Text += "\n";

            C cls5 = new D();
            richTextBox1.Text += cls5.Method() + "\n";
           // richTextBox1.Text += ((D)cls5).MethodD() + "\n";
            richTextBox1.Text += "\n";
        }
        public class A
        {
            public int a { get; set; }
            public virtual string Method()
            {
               
                return "Phuong thuc lop A";
            }
        }
        public class B : A
        {
            public int b { get; set; }           
            public override string Method()
            {
                return "B Override A";
            }
            public string MethodB()
            {
                return "Phuong thuc lop B";
            }
        }




        public class C : A
        {
            public int c { get; set; }
            //public override string Method()
            //{
            //    return "C Override A";
            //}
            public string MethodC()
            {
                return "Phuong thuc lop C";
            }
        }
        public class D : C
        {
            public int d { get; set; }
            public override string Method()
            {
                return "D Override ...";
            }
            public string MethodD()
            {
                return "Phuong thuc lop D";
            }
        }

        #endregion
        private int KichThuocBanCo = 400;
        private int KichThuocQuanCo = 36;
        BanCo banco = new BanCo();
        private void button1_Click_1(object sender, EventArgs e)
        {
            test();
            LoadCmb();
        }
        private void LoadCmb()
        {
            foreach (QuanCo qc in DanhSachQuanCo)
            {
                comboBox1.Items.Add(qc.Name);
            }
        }
        List<QuanCo> DanhSachQuanCo = new List<QuanCo>();
        private void test()
        {
            DanhSachQuanCo.Clear();
            //List<QuanCo> DanhSachQuanCo = new List<QuanCo>();
            //List<QuanCo> DanhSachQuanCo = new List<QuanCo>();
            // 2 tươngs
            King king1 = new King();
            king1.Name = "King1";
            king1.banco = banco;
            king1._color = "Red";
            king1._flag = 1;
            king1._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            king1._vitri = new ViTri(4, 0);
            king1.TimCacNuocDi();

            King king2 = new King();
            king2.Name = "King2";
            king2.banco = banco;
            king2._color = "Black";
            king2._flag = 2;
            king2._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            king2._vitri = new ViTri(4, 7);
            king2.TimCacNuocDi();

            // 2 hậu
            Queen Queen1 = new Queen();
            Queen1.Name = "Queen1";
            Queen1.banco = banco;
            Queen1._color = "Red";
            Queen1._flag = 1;
            Queen1._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Queen1._vitri = new ViTri(3, 0);
            Queen1.TimCacNuocDi();

            Queen Queen2 = new Queen();
            Queen2.Name = "Queen2";
            Queen2.banco = banco;
            Queen2._color = "Black";
            Queen2._flag = 2;
            Queen2._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Queen2._vitri = new ViTri(3, 7);
            Queen2.TimCacNuocDi();
            //4 xe
            Rook Rook11 = new Rook();
            Rook11.Name = "Rook11";
            Rook11.banco = banco;
            Rook11._color = "Red";
            Rook11._flag = 1;
            Rook11._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Rook11._vitri = new ViTri(0, 0);
            Rook11.TimCacNuocDi();

            Rook Rook12 = new Rook();
            Rook12.Name = "Rook12";
            Rook12.banco = banco;
            Rook12._color = "Red";
            Rook12._flag = 1;
            Rook12._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Rook12._vitri = new ViTri(7, 0);
            Rook12.TimCacNuocDi();


            Rook Rook21 = new Rook();
            Rook21.Name = "Rook21";
            Rook21.banco = banco;
            Rook21._color = "Black";
            Rook21._flag = 2;
            Rook21._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Rook21._vitri = new ViTri(0, 7);
            Rook21.TimCacNuocDi();

            Rook Rook22 = new Rook();
            Rook22.Name = "Rook22";
            Rook22.banco = banco;
            Rook22._color = "Black";
            Rook22._flag = 2;
            Rook22._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Rook22._vitri = new ViTri(7, 7);
            Rook22.TimCacNuocDi();
            //4 tịnh
            Bishop Bishop11 = new Bishop();
            Bishop11.Name = "Bishop11";
            Bishop11.banco = banco;
            Bishop11._color = "Red";
            Bishop11._flag = 1;
            Bishop11._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Bishop11._vitri = new ViTri(2, 0);
            Bishop11.TimCacNuocDi();

            Bishop Bishop12 = new Bishop();
            Bishop12.Name = "Bishop12";
            Bishop12.banco = banco;
            Bishop12._color = "Red";
            Bishop12._flag = 1;
            Bishop12._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Bishop12._vitri = new ViTri(5, 0);
            Bishop12.TimCacNuocDi();


            Bishop Bishop21 = new Bishop();
            Bishop21.Name = "Bishop21";
            Bishop21.banco = banco;
            Bishop21._color = "Black";
            Bishop21._flag = 2;
            Bishop21._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Bishop21._vitri = new ViTri(2, 7);
            Bishop21.TimCacNuocDi();

            Bishop Bishop22 = new Bishop();
            Bishop22.Name = "Bishop22";
            Bishop22.banco = banco;
            Bishop22._color = "Black";
            Bishop22._flag = 2;
            Bishop22._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Bishop22._vitri = new ViTri(5, 7);
            Bishop22.TimCacNuocDi();
            //4 mã
            Knight Knight11 = new Knight();
            Knight11.Name = "Knight11";
            Knight11.banco = banco;
            Knight11._color = "Red";
            Knight11._flag = 1;
            Knight11._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Knight11._vitri = new ViTri(1, 0);
            Knight11.TimCacNuocDi();

            Knight Knight12 = new Knight();
            Knight12.Name = "Knight12";
            Knight12.banco = banco;
            Knight12._color = "Red";
            Knight12._flag = 1;
            Knight12._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Knight12._vitri = new ViTri(6, 0);
            Knight12.TimCacNuocDi();


            Knight Knight21 = new Knight();
            Knight21.Name = "Knight21";
            Knight21.banco = banco;
            Knight21._color = "Black";
            Knight21._flag = 2;
            Knight21._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Knight21._vitri = new ViTri(1, 7);
            Knight21.TimCacNuocDi();

            Knight Knight22 = new Knight();
            Knight22.Name = "Knight22";
            Knight22.banco = banco;
            Knight22._color = "Black";
            Knight22._flag = 2;
            Knight22._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
            Knight22._vitri = new ViTri(6, 7);
            Knight22.TimCacNuocDi();
            //16 tốt
            Pawn[] _pawn1 = new Pawn[8];
            for (int i = 0; i < _pawn1.Length; i++)
            {
                _pawn1[i] = new Pawn();
                _pawn1[i].Name = "_pawn1" + i.ToString();
                _pawn1[i].banco = banco;
                _pawn1[i]._color = "Red";
                _pawn1[i]._flag = 1;
                _pawn1[i]._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
                _pawn1[i]._vitri = new ViTri(i, 2);
                _pawn1[i].TimCacNuocDi();
                DanhSachQuanCo.Add(_pawn1[i]);
            }
            Pawn[] _pawn2 = new Pawn[8];
            for (int i = 0; i < _pawn2.Length; i++)
            {
                _pawn2[i] = new Pawn();
                _pawn2[i].Name = "_pawn2" + i.ToString();
                _pawn2[i].banco = banco;
                _pawn2[i]._color = "Red";
                _pawn2[i]._flag = 1;
                _pawn2[i]._size = new Size(KichThuocQuanCo, KichThuocQuanCo);
                _pawn2[i]._vitri = new ViTri(i, 2);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach (QuanCo qc in DanhSachQuanCo)
            {
                if (qc.Name == comboBox1.Text)
                {
                    foreach (ViTri vt in qc.CacNuocDi)
                    {
                        richTextBox1.Text += vt.x.ToString() + "," + vt.y.ToString() + "\n";
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<int> lst = new List<int>();
            lst.Add(2);
            lst.Add(1);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            lst.Add(6);
            lst.Add(7);
            lst.Add(8);
            lst.Add(9);
            int[] list2 = new int[lst.Count];
            lst.CopyTo(list2);
            richTextBox1.Text = "";
            for(int j=0;j<list2.Length;j++)
            {
                if (list2[j] > 4 && list2[j] < 9)
                {
                    lst.Remove(list2[j]);
                }
            }
            richTextBox1.Text += "LST\n";
                foreach (int i in lst)
                {
                    richTextBox1.Text += i.ToString() + "\n";
                }
                richTextBox1.Text += "LIST2\n";
                foreach (int i in list2)
                {
                    richTextBox1.Text += i.ToString() + "\n";
                }

        }
    }


   
}
