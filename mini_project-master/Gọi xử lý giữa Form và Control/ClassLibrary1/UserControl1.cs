using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public delegate void SendData(string s);
    
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public delegate void exe(string s);
        public event exe OnExe;
        private void button1_Click(object sender, EventArgs e)
        {
            if(OnExe != null)
            {
                OnExe(textBox1.Text.Trim());
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text ="0";
        }
        //public event EventHandler handler;
        //private void button1_Click(object sender, EventArgs e)
        //{
           
        //   if(handler != null)
        //   {
        //       handler(this, e);
        //   }
        //}
    }
}
