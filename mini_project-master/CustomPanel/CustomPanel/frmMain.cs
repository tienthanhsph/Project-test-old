using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPanel
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();             
        }
        UCBottom1 bottom1 = new UCBottom1();
        UCBottom2 bottom2 = new UCBottom2();
        UCBottom3 bottom3 = new UCBottom3();
        UCLeft left = new UCLeft();
        UCRight right = new UCRight();
        UCMain main = new UCMain();

        public static int frmMainWidth;
        public static int frmMainHeight;
        public  void SetSize(int percentBottom1, int percentLeft, int percentBottom2, int percentRight, int percentBottom3)
        {
            int width = 0;
            int height = 0;

            height = (int)(frmMainHeight * percentBottom1 / 100);
            Bottom1.Size = new Size(Bottom1.Width, height);

            width = 0;
            height = 0;

            width = (int)(frmMainWidth * percentLeft / 100);
            Left.Size = new Size(width, Left.Height);

            width = 0;
            height = 0;

            height = (int)(frmMainHeight * percentBottom2 / 100);
            Bottom2.Size = new Size(Bottom2.Width, height);

            width = 0;
            height = 0;

            width = (int)(frmMainWidth * percentRight / 100);
            Right.Size = new Size(width, Right.Height);

            width = 0;
            height = 0;

            height = (int)(frmMainHeight * percentBottom3 / 100);
            Bottom3.Size = new Size(Bottom3.Width, height);

        }
        public  void Script(string scriptName)
        {
            switch (scriptName.Trim())
            {
                case "ThongTinThem":
                    SetSize(5, 25, 0, 30, 0);
                    break;
                case "Status":
                    SetSize(5, 25, 3, 0, 0);
                    break;
                case "ThongTinThem+Status":
                    SetSize(5, 25, 7, 30, 0);
                    break;
                case "ThongTinThem+Status+":
                    SetSize(5, 25, 0, 30, 10);
                    break;
                default: 
                    SetSize(5,25,0,0,0);
                    break;

            }
        }
        private void AddUC(UserControl uc, Panel pnl)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void loadUC() {
            AddUC(bottom1, Bottom1);
            AddUC(bottom2, Bottom2);
            AddUC(bottom3, Bottom3);
            AddUC(left,Left);
            AddUC(right,Right);
            AddUC(main, Main);

            main.comboBox1.SelectedIndexChanged += Chage_Script;
        }
        private void Chage_Script(object sender, EventArgs e)
        {
            Script(main.comboBox1.Text.Trim());
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMainWidth = this.Width;
            frmMainHeight = this.Height;
            loadUC();
            Script("0");
        }
    }
}
