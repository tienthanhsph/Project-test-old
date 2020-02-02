using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snack
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ThucAn thucan;
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            thucan = new ThucAn();
            thucan.TyLe = 50;
            thucan.X = (int)(this.panel1.Width / thucan.TyLe);
            thucan.Y = (int)(this.panel1.Height / thucan.TyLe);
            
            thucan.g = g;
            thucan.VeThucAn(false);
            g.Dispose();
        }
    }
}
