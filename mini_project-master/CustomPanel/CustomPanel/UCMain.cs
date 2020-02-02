using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPanel
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            label1.Text = " Sẽ hướng đến làm thêm một form cấu hình .\n Có thể tùy chọn kích thước các panel trong form và lưu lại cấu hình cho chương trình.";
        }

        
    }
}
