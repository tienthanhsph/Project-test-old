using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDatNongNghiep
{
    public partial class frmHOSO : Form
    {
        public frmHOSO()
        {
            InitializeComponent();
        }

        DataSet ds= new DataSet();
        clsDatabase cls = new clsDatabase();
        public int MaHoSoDatNN { get; set; }
        public int MaSoGiaDinh { get; set; }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem();
            this.Hide();
            frm.ShowDialog();
            LoadForm();
            this.Show();            
        }

        private void HideAllControl_in_Panel2()
        {
            foreach (UserControl uc in panel2.Controls)
            {
                uc.Hide();
            }
        }

        private void btnKeKhai_Click(object sender, EventArgs e)
        {
            HideAllControl_in_Panel2();
            KiemTraCheckDone(2);
            ctrlKeKhai1.Show();
            ctrlKeKhai1.ReLoad();
            ButtonColor("btnKeKhai");
        }

        private void frmHOSO_Load(object sender, EventArgs e)
        {
            LoadForm();
            this.Text = "Hồ sơ đất nông nghiệp   [ "+ clsConfig.TenDVHC.ToUpper()+"]";
        }

        public void LoadForm()
        {
            try
            {
                ctrlXetQSDD1.Dock = System.Windows.Forms.DockStyle.Fill;
                ctrlKeKhai1.Dock = System.Windows.Forms.DockStyle.Fill;
                ctrlXetGiaoDatNN1.Dock = System.Windows.Forms.DockStyle.Fill;
                ctrlCapGCNDatNN1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.MaHoSoDatNN = clsConfig.MaHoSo;
                this.MaSoGiaDinh = clsConfig.MaGiaDinh;
                if (this.MaHoSoDatNN == 0)
                {
                    if (this.MaSoGiaDinh == 0)
                    {
                        Status(1);
                    }
                    else
                    {
                        Status(2);
                        this.lblStatus.Text = "Chưa có Hồ sơ!";
                    }
                }
                else
                {
                    if (this.MaSoGiaDinh == 0)
                    {
                        Status(2);
                        this.lblStatus.Text = "Chưa có thông tin hộ gia đình!";
                    }
                    else
                    {
                        LayTrangThaiHoSo();
                        Status(clsConfig.TrangThaiHoSo);
                    }
                }

                HienThiThongTinGiaDinh_HoSo(clsConfig.MaHoSo);
                HideAllControl_in_Panel2();
                ctrlKeKhai1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LayTrangThaiHoSo()
        {
            try
            {
                if (clsConfig.MaHoSo != 0)
                {
                    string query = " select TrangThaiHoSo from tblHoSoCapGCNDatNN where MaHoSoCapGCNDatNN ='" + clsConfig.MaHoSo + "' ";
                    if (cls.ExecuteQueryScalar(query) != null && cls.ExecuteQueryScalar(query).ToString() != "")
                        clsConfig.TrangThaiHoSo = Convert.ToInt32(cls.ExecuteQueryScalar(query));
                }
                else
                    clsConfig.TrangThaiHoSo = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        public void Status(int trangthai)        
        {
            try
            {
                this.lblStatus.ForeColor = System.Drawing.Color.White;

                if (trangthai == 1)// không có thông tin về gia đình và hồ sơ
                {
                    this.lblStatus.BackColor = System.Drawing.Color.Red;
                    btnKeKhai.Enabled = false;
                    btnXetQSDD.Enabled = false;
                    btnXetGiaoDatNN.Enabled = false;
                    btnCapGCNDatNN.Enabled = false;
                    this.lblStatus.Text = "Chưa có thông tin.";
                }
                else if (trangthai == 2)
                {
                    this.lblStatus.BackColor = System.Drawing.Color.Orange;// thiếu thông tin gia đình hoặc hồ sơ
                    btnKeKhai.Enabled = true;
                    btnXetQSDD.Enabled = false;
                    btnXetGiaoDatNN.Enabled = false;
                    btnCapGCNDatNN.Enabled = false;
                    if (clsConfig.MaHoSo == 0)
                        this.lblStatus.Text = "Chưa có hồ sơ";
                    else if (clsConfig.MaGiaDinh == 0)
                        this.lblStatus.Text = "Chưa có thông tin hộ gia đình!";
                    else
                        this.lblStatus.Text = "Thông tin hồ sơ";
                }
                else if (trangthai == 3)// Kê khai xong!
                {
                    this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                    this.lblStatus.Text = "Xong bước điền thông tin hồ sơ";
                    btnKeKhai.Enabled = true;
                    btnXetQSDD.Enabled = true;
                    btnXetGiaoDatNN.Enabled = false;
                    btnCapGCNDatNN.Enabled = false;
                }
                else if (trangthai == 4)//Xét duyệt xong
                {
                    this.lblStatus.BackColor = System.Drawing.Color.MediumBlue;
                    this.lblStatus.Text = "Xong bước xét duyệt quyền sử dụng đất";
                    btnKeKhai.Enabled = true;
                    btnXetQSDD.Enabled = true;
                    btnXetGiaoDatNN.Enabled = true;
                    btnCapGCNDatNN.Enabled = false;
                }
                else if (trangthai == 5)// ThẨm định xong
                {
                    this.lblStatus.BackColor = System.Drawing.Color.DeepPink;
                    this.lblStatus.Text = "Xong bước xét duyệt giao đất nông nghiệp";
                    btnKeKhai.Enabled = true;
                    btnXetQSDD.Enabled = true;
                    btnXetGiaoDatNN.Enabled = true;
                    btnCapGCNDatNN.Enabled = true;
                }
                else if (trangthai == 6)//đã cấp Giấy chứng nhận.
                {
                    this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
                    this.lblStatus.ForeColor = System.Drawing.Color.Black;
                    this.lblStatus.Text = "Đã cấp Giấy chứng nhận!";
                    this.lblStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                    btnKeKhai.Enabled = true;
                    btnXetQSDD.Enabled = true;
                    btnXetGiaoDatNN.Enabled = true;
                    btnCapGCNDatNN.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
        
        private void HienThiThongTinGiaDinh_HoSo(int MSHS)
        {
            try
            {
                if (MSHS == 0)
                    return;
                ds.Tables.Clear();
                ds = cls.GetData("spHienThiThongTinHSDatNN", new string[] { "@MaHoSoCapGCNDatNN" }, new string[] { MSHS.ToString() });
                if (ds == null)
                    return;
                lblChuHS.Text = "Chủ :" + ds.Tables[0].Rows[0]["NguoiDaiDien"].ToString();
                lblDiaChi.Text = "Địa chỉ: " + ds.Tables[0].Rows[0]["DiaChi"].ToString();
                lblSoKhau.Text = "Số người: " + ds.Tables[0].Rows[0]["SoNguoi"].ToString();
                lblDienTich.Text = "Diện tích: " + ds.Tables[0].Rows[0]["DienTichDeNghiCapGCN"].ToString();
                lblThue.Text = "Tổng tiền thuế: " + ds.Tables[0].Rows[0]["TongHopThue"].ToString();
                string xong = ds.Tables[0].Rows[0]["DaXongThue"].ToString().ToLower();
                if (ds.Tables[0].Rows[0]["DaXongThue"].ToString().ToLower() == "true")
                    lblNopThue.Text = "Đã nộp xong thuế";
                else
                    lblNopThue.Text = "Chưa nộp xong thuế!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }


        private void ButtonColor(string name)
        {
           foreach(Button btn in panel3.Controls)
           {
               if(btn.Name != "btnXoa")
               {
                   if (btn.Name == name)
                       btn.BackColor = Color.Lavender;
                   else
                       btn.BackColor = SystemColors.Control;
               }
           }

        }
        
        private void btnXetQSDD_Click(object sender, EventArgs e)
        {
            HideAllControl_in_Panel2();
            ctrlXetQSDD1.Show();
            KiemTraCheckDone(3);
            Status(clsConfig.TrangThaiHoSo);
            ButtonColor("btnXetQSDD");
            ctrlXetQSDD1.ReLoad();
        }

        private void btnXetGiaoDatNN_Click(object sender, EventArgs e)
        {
            HideAllControl_in_Panel2();
            ctrlXetGiaoDatNN1.Show();
            KiemTraCheckDone(4);
            Status(clsConfig.TrangThaiHoSo);
            ButtonColor("btnXetGiaoDatNN");
            ctrlXetGiaoDatNN1.ReLoad();
        }
        private void btnCapGCNDatNN_Click(object sender, EventArgs e)
        {
            HideAllControl_in_Panel2();
            ctrlCapGCNDatNN1.Show();
            KiemTraCheckDone(5);
            Status(clsConfig.TrangThaiHoSo);
            ButtonColor("btnCapGCNDatNN");
        }

       
       
        private void btnHoGiaDinh_Click(object sender, EventArgs e)
        {
            if(clsConfig.MaHoSo == 0)
            {
                MessageBox.Show("Cần tạo hồ sơ trước!");
            }
            else
            {
                frmGiaDinh frm = new frmGiaDinh();
                this.Hide();
                frm.ShowDialog();
              //  ShowInfo();
                Status(clsConfig.TrangThaiHoSo);
                KiemTraCheckDone(2);
                this.Show();

            }
            
        }

        private void chkDone_CheckedChanged(object sender, EventArgs e)
        {
            if(clsConfig.TrangThaiHoSo <2)
            {
            }
            else if(chkDone.Checked == true)
            {
                clsConfig.TrangThaiHoSo++;
                Status(clsConfig.TrangThaiHoSo);
                string query = " update tblHoSoCapGCNDatNN set TrangThaiHoSo =" + clsConfig.TrangThaiHoSo + " where MaHoSoCapGCNDatNN ='" + clsConfig.MaHoSo + "' ";
                cls.ExecuteQueryInsertUpdateDelete(query);
            }
            
        }
        public void KiemTraCheckDone(int buoc)
        {
            if(buoc == 2 &&(clsConfig.MaHoSo ==0 || clsConfig.MaGiaDinh==0))
            {
                chkDone.Enabled = false;
            }
            else
            {
                if (buoc < clsConfig.TrangThaiHoSo)
                {
                    //chkDone.Checked = true;
                    chkDone.Enabled = false;
                }
                else
                    if (buoc == clsConfig.TrangThaiHoSo)
                    {
                        chkDone.Checked = false;
                        chkDone.Enabled = true;
                    }
                    else if (buoc > clsConfig.TrangThaiHoSo)
                    {
                        chkDone.Checked = false;
                        chkDone.Enabled = true;
                    }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("BẠN có chắc muốn xóa hồ sơ này?", "XÓA hồ sơ!", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if (clsConfig.MaHoSo != 0)
                {
                    string query = " update tblHoSoCapGCNDatNN set BaoXoa = 1 where MaHoSoCapGCNDatNN ='" + clsConfig.MaHoSo + "' ";
                    cls.ExecuteQuery(query);
                }

                HideAllControl_in_Panel2();
                clsConfig.Refresh();
                LayTrangThaiHoSo();
                Status(1);
            }
            
        }

       
        //private void ShowInfo()
        //{
        //    rtbInfo.Text += "\n\n Mã gia đình: " + clsConfig.MaGiaDinh.ToString() + "\n Mã hồ sơ: " + clsConfig.MaHoSo.ToString()+"\n Trạng thái HS: "+clsConfig.TrangThaiHoSo.ToString();
        //}

        private void tạoHồSơMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (clsConfig.MaHoSo != 0)
                {
                    var result = MessageBox.Show("Dừng thao tác trên hồ sơ hiện tại, tạo hồ sơ mới!", "Tạo mới hồ sơ?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        clsConfig.Refresh();
                        HideAllControl_in_Panel2();
                        ctrlKeKhai1.TaoHoSoMoi();
                        clsConfig.TrangThaiHoSo = 2;
                        ctrlKeKhai1.Show();
                        Status(2);
                       // ShowInfo();
                        KiemTraCheckDone(1);
                        ButtonColor("btnKeKhai");
                        btnKeKhai.Focus();
                    }
                }
                else
                {
                    clsConfig.Refresh();
                    HideAllControl_in_Panel2();
                    ctrlKeKhai1.TaoHoSoMoi();
                    clsConfig.TrangThaiHoSo = 2;
                    ctrlKeKhai1.Show();
                    Status(2);
                   // ShowInfo();
                    KiemTraCheckDone(1);
                    ButtonColor("btnKeKhai");
                    btnKeKhai.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýHồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHoSo frm = new frmQuanLyHoSo();
            frm.Show();
        }
    }
}
