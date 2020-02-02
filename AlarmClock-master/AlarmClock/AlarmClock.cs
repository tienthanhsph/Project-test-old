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
    public partial class AlarmClock : Form
    {
        public static int gio = 23;//biến tĩnh để chứa giờ, mặc định là 24h
        public static int phut = 59;//biến tĩnh để chứa phút, mặc định là 59m
        
        int giayconlai;//tính giây còn lại
        string nhacchuong = "";//đường dẫn của nhạc chuông
        public AlarmClock()
        {
            InitializeComponent();
        }

        private void AlarmClock_Load(object sender, EventArgs e)
        {
            timerThoigian.Enabled = true;//bật timerThoigian để hiển thị giờ
            hiệnToolStripMenuItem.Enabled = false;//ẩn Items "hiện" dưới khay hệ thống
            //Thêm Items vào ComboBox
            comboBoxChucnang.SelectedText = "Lựa chọn chức năng";
            comboBoxChucnang.Items.Add("Báo thức");
            comboBoxChucnang.Items.Add("Tắt máy");
        }

        private void timerThoigian_Tick(object sender, EventArgs e)
        {
            //hiển thị thời gian hiện tại lên Label thời gian
            lblThoigian.Text = DateTime.Now.ToLongTimeString();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (dialog == DialogResult.OK)
            {
                Close();   
            }
        }

        private void notifyIconClock_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();//hiển thị form
            WindowState = FormWindowState.Normal;
        }

        private void hiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hiệnToolStripMenuItem.Enabled = false;//ẩn items "hiện"
            ẩnToolStripMenuItem.Enabled = true;//hiện items "ẩn"
            Show();//hiển thị form
            WindowState = FormWindowState.Normal;
        }

        private void ẩnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ẩnToolStripMenuItem.Enabled = false;//ẩn items "ẩn"
            hiệnToolStripMenuItem.Enabled = true;//hiện items "hiện"
            Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void AlarmClock_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                ẩnToolStripMenuItem.Enabled = false;
                hiệnToolStripMenuItem.Enabled = true;
                notifyIconClock.BalloonTipText = "Đồng hồ ẩn";//Text hiển thị nhắc nhở
                notifyIconClock.ShowBalloonTip(1000);//thời gian hiển thị
            }
            if (WindowState == FormWindowState.Normal)
            {
                Show();
                hiệnToolStripMenuItem.Enabled = false;
                ẩnToolStripMenuItem.Enabled = true;
                notifyIconClock.BalloonTipText = "Hiển thị đồng hồ";
                notifyIconClock.ShowBalloonTip(1000);
            }
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            ẩnToolStripMenuItem.Enabled = false;
            Hide();
            WindowState = FormWindowState.Minimized;
            hiệnToolStripMenuItem.Enabled = true;
            notifyIconClock.BalloonTipText = "Đồng hồ ẩn";
            notifyIconClock.ShowBalloonTip(1000);
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            string thongtin = @"Tác giả : Phan Tiến Quang
            Email : ptquang160492@gmail.com
            SDT   : 0166 2573 900";
            MessageBox.Show(thongtin, "Thông tin",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            int giay = DateTime.Now.Second;//lấy giây hiện tại của hệ thống
            //tính giây còn lại
            giayconlai = (gio - DateTime.Now.Hour) * 3600
                + (phut - DateTime.Now.Minute) * 60 - giay;
            if (comboBoxChucnang.SelectedItem.ToString() == "Báo thức")//nếu chọn chức năng báo thức
            {
                if (nhacchuong == "")//nếu chưa chọn nhạc chuông
                {
                    MessageBox.Show("Chọn nhạc chuông");
                }
                if (nhacchuong != "")//đã chọn nhạc chuông
                {
                    comboBoxChucnang.Enabled = false;//ẩn ComboBox chọn chức năng
                    timerHengio.Enabled = true;//bật timer Hẹn giờ để kiểm tra đến giờ
                    btnXacnhan.Enabled = false;//ẩn Button xác nhận
                }
            }
            if (comboBoxChucnang.SelectedItem.ToString() == "Tắt máy")//chọn chức năng hẹn giờ
            {
                comboBoxChucnang.Enabled = false;
                timerHengio.Enabled = true;
                btnXacnhan.Enabled = false;
            }
        }

        private void comboBoxChucnang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChucnang.SelectedItem.ToString() == "Báo thức")
            {
                //mở form thời gian để nhập giờ
                ThoiGian thoigian = new ThoiGian();
                thoigian.ShowDialog();
                btnNhacchuong.Enabled = true;//hiện button chọn nhạc
            }
            if (comboBoxChucnang.SelectedItem.ToString() == "Tắt máy")
            {
                ThoiGian thoigian = new ThoiGian();
                thoigian.ShowDialog();
            }
            btnXacnhan.Enabled = true;//hiện button xác nhận
            btnHuy.Enabled = true;//ẩn button hủy quá trình hẹn giờ
        }

        private void btnNhacchuong_Click(object sender, EventArgs e)
        {
            openFileDialogClock.Filter = "Medias Files(*.mp3)|*.mp3";
            openFileDialogClock.Title = "Chọn nhạc chuông";
            if (openFileDialogClock.ShowDialog() == DialogResult.OK)
            {
                nhacchuong = openFileDialogClock.FileName;
            }
        }

        private void timerHengio_Tick(object sender, EventArgs e)
        {
            giayconlai--;//giây còn lại giảm 1
            if (giayconlai >= 0)//nếu chưa đến giờ thì thông báo số giây còn lại
            {
                comboBoxChucnang.Text = comboBoxChucnang.SelectedItem.ToString() + " " + 
                    giayconlai + " giây";
            }
            else//nếu đã đến giờ hẹn (giây còn lại < 0)
            {
                if (giayconlai < -1)//nếu giây còn lại < -1 thì tắt timer hẹn giờ này
                {
                    timerHengio.Enabled = false;//tắt timer hẹn giờ
                }
                else//nếu giây = -1
                {
                    if (comboBoxChucnang.SelectedItem.ToString() == "Báo thức")
                    {
                       // MessageBox.Show("Báo thức nè");
                        axWindowsMediaPlayer1.URL = nhacchuong;//Bật nhạc chuông
                    }
                    if (comboBoxChucnang.SelectedItem.ToString() == "Tắt máy")
                    {
                        //MessageBox.Show("Tắt máy nè");
                        //câu lệnh này dùng để tắt máy trong 1 khoảng thời gian 500 giây
                        //System.Diagnostics.Process.Start("shutdown", "-s -t 300");
                       System.Diagnostics.Process.Start("shutdown", "-s -t 0");//tắt máy
                        //MessageBox.Show("Tắt mày nè");
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Hủy quá trình hẹn giờ đồng thời khôi phục lại trạng thái ban đầu
            if (comboBoxChucnang.SelectedItem.ToString() == "Báo thức")
            {
                //dừng phát nhạc chuông
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            if (comboBoxChucnang.SelectedItem.ToString() == "Tắt máy")
            {
                //hủy tắt máy
                System.Diagnostics.Process.Start("shutdown", "-a");
            }
            comboBoxChucnang.Enabled = true;
            comboBoxChucnang.ResetText();
            comboBoxChucnang.SelectedText = "Chọn chức năng";
            btnHuy.Enabled = false;
            btnNhacchuong.Enabled = false;
            btnXacnhan.Enabled = false;
            timerHengio.Enabled = false;
        }
    }
}
