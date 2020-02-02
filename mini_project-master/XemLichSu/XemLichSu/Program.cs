using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XemLichSu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HoSo());
            //Application.Run(new LichSu());
            //Application.Run(new Form1());
            //Application.Run(new TuDienQuyenHan());
            
            //Application.Run(new PhanQuyen());
           // Application.Run(new testDatetimePicker2SQL());
            //Application.Run(new Form1());
            Application.Run(new DangNhap());
        }
    }
}
