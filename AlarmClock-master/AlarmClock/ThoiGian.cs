using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class ThoiGian : Form
    {
        public ThoiGian()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int gio = (int)numericUpDownGio.Value;//lấy giá trị của numericUpDownGio
            int phut = (int)numericUpDownPhut.Value;//lấy giá trị của numericUpDownPhut
            if (((gio - DateTime.Now.Hour) * 3600 + (phut - DateTime.Now.Minute) * 60) < 0)
            {
                MessageBox.Show("Thời gian đã qua");
            }
            else
            {
                Close();
                AlarmClock.gio = gio;
                AlarmClock.phut = phut;
            }
        }
    }
}
