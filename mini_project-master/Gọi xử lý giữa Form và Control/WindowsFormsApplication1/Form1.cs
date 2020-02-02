using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void KiemTraGiaTri()
        {
            if(glbClass.index >2)
            {
                label1.Text = "Giá trị của index đã > 2";
            }
            else
            {
                label1.Text=glbClass.index.ToString();
                glbClass.index+=1;
            }
        }
        public void TinhTong(string s)
        {
            try
            {
                glbClass.index += Convert.ToInt32(s);
                label1.Text = glbClass.index.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // this.userControl11.handler += Ex;
            this.userControl11.OnExe += TinhTong;
        }
        private void Ex(object sender, EventArgs e)
        {
            KiemTraGiaTri();
        }
        
    }
}
