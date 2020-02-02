using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowControlAnimation
{
    public partial class Open : Form
    {
        public Open()
        {
            InitializeComponent();
        }
        public int Status { get; set; }
        public int Animation { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Status = Convert.ToInt32(comboBox1.Text);
                if (comboBox2.Text == "Thay đổi Kích thước Control")
                    Animation = 0;
                else if (comboBox2.Text == "Thay đổi Vị trí Control")
                    Animation = 1;
                else if (comboBox2.Text == "Thay đổi Kích thước và Vị trí Control")
                    Animation = 2;
                this.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
