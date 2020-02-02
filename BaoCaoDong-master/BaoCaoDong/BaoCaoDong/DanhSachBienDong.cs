using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BaoCaoDong
{
    public partial class DanhSachBienDong : Form
    {
        public DanhSachBienDong()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }
        
        private void btnNguoi_Click(object sender, EventArgs e)
        {
            
            //Nguoi frm = new Nguoi();
            //frm.Show();
            //this.Hide();
        }
        clsDatabase cls = new clsDatabase();
        string query = "";
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();

        #region "Basic"
        private void DanhSachBienDong_Load(object sender, EventArgs e)
        {
            Refresh();
            btnNguoi.Hide();
        }
        private string Check100()
        {
            if (checkBox1.Checked)
                return " TOP(100) ";
            else
                return " ";
        }
        private void LoadGrid()
        {            
            try
            {
                ds1.Tables.Clear();
                ds2.Tables.Clear();
                query = " select " + Check100() + LayTenCot() + " from tblTongHopThongTinBienDong " + ShowDieuKien();
                ds1 = cls._ExecuteQuery(query);
                ds2 = ds1.Copy();
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = ds2.Tables[0];
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadGrid(string _query)
        {
           
            try
            {
                ds2.Tables.Clear();
                ds2 = cls._ExecuteQuery(_query);
                dataGridView1.DataSource = ds2.Tables[0];
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadCmbDVHC()
        {
           
            cmbDVHC.Items.Clear();
            string _query = " select * from tblTuDienDonViHanhChinh WHERE  CONVERT(INT, MaDonViHanhChinh) >= 100000";
            string[] items = cls._ExecuteReader(_query, "Ten");
            foreach (string item in items)
            {
                cmbDVHC.Items.Add(item);
            }
        }
       
        private string ShowDieuKien()
        {
            string _result = " where 1=1 ";
            if (Global._dieukien.Count > 0)
            {
                for (int i = 0; i < Global._dieukien.Count; i++)
                {
                    _result += " and " + Global._dieukien[i];
                }
            }
            return _result;
        }

        private string LayTenCot()
        {
            string _query = " select * from tblColumnsBienDong where TrangThai = '1' ";
            string[] _result = cls._ExecuteReader(_query, "TenCot");
            string result = _result[0];
            for (int i = 1; i < _result.Length - 1; i++)
            {
                if (_result[i].IndexOf("Ngay") == 0 || _result[i].IndexOf("ThoiDiem") == 0)
                {
                    _result[i] = "Convert(varchar," + _result[i] + " ,103) AS " + _result[i];
                }
                result += ", " + _result[i];
            }
            return result;
        }
        private string LayTenCot(List<string> list)
        {
            if (list.Count == 0)
            {
                return LayTenCot();
            }
            else
            {
                string result = list[0];
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i].ToString().IndexOf("Ngay") == 0 || list[i].ToString().IndexOf("ThoiDiem") == 0)
                    {
                        list[i] = "Convert(varchar," + list[i].ToString() + " ,103) AS " + list[i].ToString();
                    }
                    result += ", " + list[i];
                }
                return result;
            }    
        }
        private void FormatDataGridView()
        {
           
            try
            {
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataSet ds;
                string _query = " select A.TenBang,A.TenCot,A.TenCotHienThi,A.DoRong,B.Color,C.TenKieu " +
                                   " from tblColumnsBienDong as A inner join tblQuanLyBangBienDong as B on A.TenBang = B.num " +
                                   " inner join tblGanKieu as C on C.Kieu = A.MaKieuTimKiem ";
                ds = cls._Execute(_query);
                List<string> listCol = new List<string>();
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    listCol.Add(dataGridView1.Columns[i].Name);
                }
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    //int j = -1;
                    for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                    {
                        if (dataGridView1.Columns[i].Name == ds.Tables[0].Rows[j][1].ToString())
                        {
                            dataGridView1.Columns[i].HeaderText = ds.Tables[0].Rows[j][2].ToString();
                            dataGridView1.Columns[i].DefaultCellStyle.BackColor = Color.FromName(ds.Tables[0].Rows[j][4].ToString());
                            dataGridView1.Columns[i].Width = Convert.ToInt32(ds.Tables[0].Rows[j][3]);
                        }
                    }

                }
                lblCount.Text = "Số kết quả: " + dataGridView1.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            QuanLyThongSo quanly = new QuanLyThongSo();
            quanly.ShowDialog();
        }

        private void btnColumns_Click(object sender, EventArgs e)
        {
            
            try
            {//co the toi uu hon o day, khong dung den ds1 nưa.

                dataGridView1.DataSource = ds1.Tables[0];
                FormatDataGridView();
                ChonCotBD frm = new ChonCotBD();
                frm.CreateDataset();
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    frm.ds1.Tables[0].Rows.Add(false, dataGridView1.Columns[i].HeaderText, dataGridView1.Columns[i].Name);
                }

                //lay nhung cot san co cho datagridview 2
                if (Global.listColumns.Count > 0)
                {
                    frm.ds2.Tables[0].Rows.Clear();
                    for (int i = 0; i < Global.listColumns.Count; i++)
                    {

                        frm.ds2.Tables[0].Rows.Add(i + 1, dataGridView1.Columns[Global.listColumns[i]].HeaderText, dataGridView1.Columns[Global.listColumns[i]].Name);
                    }
                }
                frm.ShowDialog();
                query = " select " + Check100() + LayTenCot(Global.listColumns) + " from tblTongHopThongTinBienDong " + ShowDieuKien();
                LoadGrid(query);
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("btnColumns_Click \n" + ex.Message);
            }
        }

        private void btnSaveScript_Click(object sender, EventArgs e)
        {
            try
            {
                string Columns = "";
                string DK = "";
                string HTDK = "";
                if (Global.listColumns.Count > 0)
                {
                    Columns = Global.listColumns[0];
                    for (int i = 1; i < Global.listColumns.Count; i++)
                    {
                        Columns += ";" + Global.listColumns[i];
                    }
                }
                if (Global._dieukien.Count > 0)
                {
                    DK = Global._dieukien[0];
                    for (int i = 1; i < Global._dieukien.Count; i++)
                    {
                        DK += ";" + Global._dieukien[i];
                    }

                }
                if (Global._hienthi_dieukien.Count > 0)
                {
                    HTDK = Global._hienthi_dieukien[0];
                    for (int i = 1; i < Global._hienthi_dieukien.Count; i++)
                    {
                        HTDK += ";" + Global._hienthi_dieukien[i];
                    }

                }
                Script script = new Script();
                script._Columns = Columns;
                script._DK = DK;
                script._HTDK = HTDK;
                script.ShowDialog();
                query = " select " + Check100() + LayTenCot(Global.listColumns) + " from tblTongHopThongTinBienDong " + ShowDieuKien();
                LoadGrid(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion



        #region "tao cac doi tuong datetimepicker, textbox,combobox,label"


        System.Drawing.Point vtrichinh = new System.Drawing.Point(300, 20);

        System.Drawing.Point vtrinhan1 = new System.Drawing.Point(160, 22);
        System.Drawing.Point vtrinhan2 = new System.Drawing.Point(325, 22);
        System.Drawing.Point vtrinhan3 = new System.Drawing.Point(475, 22);

        System.Drawing.Point vtridate1 = new System.Drawing.Point(350, 20);
        System.Drawing.Point vtridate2 = new System.Drawing.Point(500, 20);

        System.Drawing.Point vtricombo1 = new System.Drawing.Point(300, 20);
        System.Drawing.Point vtricombo2 = new System.Drawing.Point(425, 20);

        System.Drawing.Point vtritbx1 = new System.Drawing.Point(350, 20);
        System.Drawing.Point vtritbx2 = new System.Drawing.Point(500, 20);


        System.Drawing.Size sizechinh = new System.Drawing.Size(300, 20);
        System.Drawing.Size sizecombo_min = new System.Drawing.Size(50, 20);
        System.Drawing.Size sizetbx_min = new System.Drawing.Size(100, 20);
        System.Drawing.Size sizedate = new System.Drawing.Size(100, 20);
        System.Drawing.Size sizenhan = new System.Drawing.Size(130, 20);
        System.Drawing.Size sizenhan_min = new System.Drawing.Size(30, 20);



        private void createDTP(string name, int vt, bool checkbox, bool _checked)
        {
            DateTimePicker dtp = new DateTimePicker();
            dtp.Name = name;
            dtp.Size = sizedate;
            if (vt == 1)
                dtp.Location = vtridate1;
            if (vt == 2)
                dtp.Location = vtridate2;

            dtp.ShowCheckBox = checkbox;
            dtp.Checked = _checked;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";
            this.panel2.Controls.Add(dtp);
        }
        private void createTBX(string name, int vt, int size)
        {
            TextBox tbx = new TextBox();
            tbx.Name = name;
            if (vt == 1)
                tbx.Location = vtritbx1;
            else if (vt == 2)
                tbx.Location = vtritbx2;
            if (size == 1)
                tbx.Size = sizechinh;
            else if (size == 2)
                tbx.Size = sizetbx_min;
            this.panel2.Controls.Add(tbx);
        }
        private void createCBX(string name, int vt, int size, string[] items)
        {
            ComboBox cbx = new ComboBox();
            cbx.Name = name;
            if (vt == 1)
                cbx.Location = vtricombo1;
            else if (vt == 2)
                cbx.Location = vtricombo2;
            if (size == 1)
                cbx.Size = sizechinh;
            else if (size == 2)
                cbx.Size = sizecombo_min;
            foreach (string item in items)
            {
                cbx.Items.Add(item);
            }
            this.panel2.Controls.Add(cbx);

        }


        private void createLBL(string name, string text, int size, int vt, bool B)
        {
            Label lbl = new Label();
            lbl.Name = name;
            if (vt == 1)
            {
                lbl.Location = vtrinhan1;
                lbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            else if (vt == 2)
                lbl.Location = vtrinhan2;
            else if (vt == 3)
                lbl.Location = vtrinhan3;
            else if (vt == 10)
                lbl.Location = new System.Drawing.Point(30, 60);

            if (size == 1)
                lbl.Size = sizenhan;
            else if (size == 2)
                lbl.Size = sizenhan_min;
            else if (size == 10)
                lbl.Size = new System.Drawing.Size(800, 25);
            lbl.Text = text;
            this.panel2.Controls.Add(lbl);
        }

        private void createBTN(string name, string text, int style)
        {
            Button btn = new Button();
            btn.Name = Name;
            btn.Text = text;


            if (style == 1)
            {
                btn.Location = new System.Drawing.Point(700, 20);
                btn.Size = new System.Drawing.Size(100, 22);
                btn.Click += new EventHandler(btnSaveFilterClick);
                btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else if (style == 2)
            {
                btn.Location = new System.Drawing.Point(610, 22);
                btn.Size = new System.Drawing.Size(50, 20);
                btn.Click += new EventHandler(btnEditComboBoxItemsClick);

            }
            


            this.panel2.Controls.Add(btn);

        }

        private void createCHKBX(string name, string text, int style, bool _checked)
        {
            CheckBox chk= new CheckBox();
            chk.Name = name;
            chk.Text = text;
            if (style == 1)
            {
                chk.Location = new System.Drawing.Point(400,41);                             
                chk.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            if (style == 2)
            {
                chk.Location = new System.Drawing.Point(550, 41);
                chk.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            chk.Checked = _checked;
            this.panel2.Controls.Add(chk);
        }
        string TenCotHienThoi = "";
        private void btnEditComboBoxItemsClick(object sender, EventArgs e)
        {
            CbBoxItems edit = new CbBoxItems();
            edit.comboBox1.Text = TenCotHienThoi;
            edit.ShowDialog();

        }
        private void btnSaveFilterClick(object sender, EventArgs e)
        {
            string col = "", txt = "";
           
            string dieukienloc = "";
            string _hienthi_dieukienloc = "";
            try
            {
            switch (Global._flag_style_of_panel1)
            {

                case (0):
                    {
                        MessageBox.Show("Không có thứ gì được lưu vào!");
                        break;
                    }

                case (1):
                    {
                         string kk = "";
                        bool _CXac = false;
                        bool _Khac = false;
                        foreach (Control ctrl in panel2.Controls)
                        {
                            if (ctrl is CheckBox)
                            {

                                if (ctrl.Name == "ChkChinhXac")
                                {
                                    CheckBox ck = (CheckBox)ctrl;
                                    if (ck.CheckState == CheckState.Checked)
                                        _CXac = true;
                                    else
                                        _CXac = false;
                                }
                                else if (ctrl.Name == "ChkKhac")
                                {
                                    CheckBox ck = (CheckBox)ctrl;
                                    if (ck.CheckState == CheckState.Checked)
                                        _Khac = true;
                                    else
                                        _Khac = false;
                                }
                            }                         
                        }
                        if (_CXac == _Khac && _CXac == true)
                            throw new Exception();
                        foreach (Control ctrl in panel2.Controls)
                        {
                            if (ctrl is TextBox)
                            {
                                if (ctrl.Text.Trim() == "" && _CXac == false)
                                    throw new NoNullAllowedException();
                                
                                if (_CXac == false)
                                {
                                    if (_Khac == true)
                                    {
                                        dieukienloc = ctrl.Name + " not like N'%" + ctrl.Text.Trim() + "%'";
                                        kk = " Khác : [" + ctrl.Text.Trim() + "] ";
                                    }
                                    else
                                    {
                                        dieukienloc = ctrl.Name + " like N'%" + ctrl.Text.Trim() + "%'";
                                        kk = " Có chứa : [" + ctrl.Text.Trim() + "] ";
                                    }

                                }
                                else if (_CXac == true)
                                {
                                    dieukienloc = ctrl.Name + " = N'" + ctrl.Text.Trim() + "'";
                                    kk = " = N'" + ctrl.Text.Trim() + "'";
                                }
                                
                            }
                            else if (ctrl is Label)
                            {
                                col = ctrl.Name;
                                txt = ctrl.Text;
                            }

                        }
                        _hienthi_dieukienloc = txt + kk;
                        Global._dieukien.Add(dieukienloc);
                        Global._hienthi_dieukien.Add(_hienthi_dieukienloc);
                        break;
                    }

                case (2):
                    {
                        int vt = 0;
                        int vp = 0;
                        
                        foreach (Control ctrl in panel2.Controls)
                        {
                            if (ctrl is TextBox)
                            {
                                if (ctrl.Text.Trim() == "")
                                    throw new NoNullAllowedException();

                                if (ctrl.Name == "VT")
                                    vt = Convert.ToInt32(ctrl.Text.Trim());
                                if (ctrl.Name == "VP")
                                    vp = Convert.ToInt32(ctrl.Text.Trim());

                            }
                            else if (ctrl is Label)
                            {
                                if (ctrl.Name != "_tu" && ctrl.Name != "_den")
                                {
                                    col = ctrl.Name;
                                    txt = ctrl.Text;
                                }
                            }

                        }
                        dieukienloc = col + " >= " + vt + " and " + col + " <= " + vp;
                        _hienthi_dieukienloc = txt + " >= " + vt + " và " + col + " <= " + vp;
                        Global._dieukien.Add(dieukienloc);
                        Global._hienthi_dieukien.Add(_hienthi_dieukienloc);
                        break;
                    }

                case (3):
                    {
                        string vt = "", vp = "";
                        foreach (Control ctrl in panel2.Controls)
                        {

                            if (ctrl is DateTimePicker)
                            {

                                DateTimePicker dtp = (DateTimePicker)ctrl;
                                if (dtp.Checked == false)
                                    throw new NoNullAllowedException();
                                if (ctrl.Name == "DatetimePicker1")
                                {
                                    
                                    vt = dtp.Value.ToString("MM/dd/yyyy");
                                }
                                if (ctrl.Name == "DatetimePicker2")
                                {
                                   

                                    vp = dtp.Value.ToString("MM/dd/yyyy");
                                }
                            }
                            else if (ctrl is Label)
                            {
                                if (ctrl.Name != "_tu" && ctrl.Name != "_den")
                                {
                                    col = ctrl.Name;
                                    txt = ctrl.Text;
                                }
                            }

                        }
                        dieukienloc = col + " >= '" + vt + "' and " + col + " <= '" + vp + "' ";
                        _hienthi_dieukienloc = txt + " >= " + vt + " và " + txt + " <= " + vp;
                        Global._dieukien.Add(dieukienloc);
                        Global._hienthi_dieukien.Add(_hienthi_dieukienloc);
                        break;
                    }
                case (4):
                    {
                        string kk = "";
                        foreach (Control ctrl in panel2.Controls)
                        {
                            if (ctrl is ComboBox)
                            {
                                kk = ctrl.Text.Trim();
                                if (kk.Trim() == "")
                                    throw new NoNullAllowedException();
                            }
                            else if (ctrl is Label)
                            {
                                if (ctrl.Name != "_tu" && ctrl.Name != "_den")
                                {
                                    col = ctrl.Name;
                                    txt = ctrl.Text;
                                }
                            }
                        }
                        if (kk.Trim() != "")
                        {
                            dieukienloc = col + " = N'" + kk + "' ";
                            _hienthi_dieukienloc = txt + " = '" + kk + "' ";
                        }

                        Global._dieukien.Add(dieukienloc);
                        Global._hienthi_dieukien.Add(_hienthi_dieukienloc);
                        break;

                    }
            }

            Global._flag_style_of_panel1 = 0;
            _hienthidieukientonghop();
            }
            catch(NoNullAllowedException ex)
            {
                _hienthidieukientonghop();
                MessageBox.Show(" BẠN ĐÃ KHÔNG ĐIỀN VÀO MỤC NÀO ĐÓ?! \n" + ex.Message);
            }
        }
        #endregion


        #region " Header Column Click"
        private void ResetPanel2()
        {
            panel2.Controls.Clear();
            createBTN("btnSaveFilter", "lưu điều kiện.", 1);
            _hienthidieukientonghop();
            createLBL("Notification", Global._Notification, 10, 10, true);

        }
        private void _hienthidieukientonghop()
        {
            Global._Notification = "";
            for (int i = 0; i < Global._hienthi_dieukien.Count; i++)
            {
                Global._Notification += " [" + Global._hienthi_dieukien[i] + "] ";

            }
            // định dạng những cột đã đặt điều kiện thì tiêu đề chuyển thành màu đỏ
            dataGridView1.EnableHeadersVisualStyles = false;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderCell.Style.ForeColor = Color.Black;

            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                foreach (string item in Global._dieukien)
                {
                    int _do = 0;
                    foreach (string subitem in item.Split(' '))
                    {
                        if (subitem == dataGridView1.Columns[i].Name)
                        {
                            _do++;

                        }
                    }
                    if (_do > 0)
                    {
                        dataGridView1.Columns[i].HeaderCell.Style.ForeColor = Color.Red;
                    }
                }
            }
        }


        private List<string> _listTextbox = new List<string>();
        private List<string> _list2Textbox = new List<string>();
        private List<string> _listComboBox = new List<string>();
        private List<string> _listDatetimePicker = new List<string>();

        private void AddStyleDataGridView1ColumnHeader()
        {
            query = " select * from tblColumnsBienDong ";      //MaKieuTimKiem
            cls.OpenConnection();
            cls.sqlcom = cls.sqlcon.CreateCommand();
            cls.sqlcom.CommandText = query;
            cls.reader = cls.sqlcom.ExecuteReader();

            while (cls.reader.Read())
            {
                switch (cls.reader["MaKieuTimKiem"].ToString())
                {
                    case "1":
                        {
                            _listTextbox.Add(cls.reader["TenCot"].ToString());
                            break;
                        }
                    case "2":
                        {
                            _list2Textbox.Add(cls.reader["TenCot"].ToString());
                            break;
                        }
                    case "3":
                        {
                            _listComboBox.Add(cls.reader["TenCot"].ToString());
                            break;
                        }
                    case "4":
                        {
                            _listDatetimePicker.Add(cls.reader["TenCot"].ToString());
                            break;
                        }

                }

            }
            cls.CloseConnection();
        }
        private string[] LoadComboBox(string columnName)
        {
            string qr = " select Items from tblColumnsComboBox where Col = N'" + columnName + "' ";
            string[] vls = cls._ExecuteReader(qr, "Items");
            return vls;
        }
        private int Flag_ColumnsHeader_Clicked = 0;
        private int CurrentColumnsHeader_Clicked = -1;
        void DataGridView1ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Flag_ColumnsHeader_Clicked = 1;
            CurrentColumnsHeader_Clicked = -1;

            string ColHeadertex = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            ResetPanel2();
            int _flagDo = 0;
            for (int i = 0; i < Global._dieukien.Count; i++)
            {
                int _do = 0; // để tránh trường hợp lặp lại 2 lần sẽ sinh ra lỗi.
                foreach (string subitem in Global._dieukien[i].Split(' '))
                {

                    if (subitem == colName.Trim())
                    {
                        _do++;

                    }

                }
                if (_do > 0)
                {
                    if (MessageBox.Show("	Đã đặt điều kiện: \n [" + Global._hienthi_dieukien[i] + "]\n\n\t THAY ĐỔI?",
                                       "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Global._dieukien.Remove(Global._dieukien[i]);
                        Global._hienthi_dieukien.Remove(Global._hienthi_dieukien[i]);
                        _flagDo = 0;
                    }
                    else
                    {
                        _flagDo = 1;
                    }
                }

            }
            if (_flagDo == 0)
            {
                if (_listTextbox.Contains(colName))
                {
                    createLBL(colName, ColHeadertex, 1, 1, true);
                    createTBX(colName, 1, 1);
                    createCHKBX("ChkChinhXac", "Tìm chính xác!", 1, false);
                    createCHKBX("ChkKhac", "Khác...!", 2, false); 
                    Global._flag_style_of_panel1 = 1;
                    CurrentColumnsHeader_Clicked = dataGridView1.CurrentCell.ColumnIndex;
                }
                else if (_list2Textbox.Contains(colName))
                {
                    string[] Items = new string[5];
                    createLBL(colName, ColHeadertex, 1, 1, true);
                    createTBX("VT", 1, 2);
                    createTBX("VP", 2, 2);
                    createLBL("_tu", "Từ", 2, 2, false);
                    createLBL("_den", "Đến", 2, 3, false);
                    Global._flag_style_of_panel1 = 2;
                }
                else if (_listDatetimePicker.Contains(colName))
                {
                    createLBL(colName, ColHeadertex, 1, 1, true);
                    createDTP("DatetimePicker1", 1, true, true);
                    createDTP("DatetimePicker2", 2, true, true);
                    createLBL("_tu", "Từ", 2, 2, false);
                    createLBL("_den", "Đến", 2, 3, false);
                    Global._flag_style_of_panel1 = 3;
                }

                else if (_listComboBox.Contains(colName))
                {
                    TenCotHienThoi = colName;
                    string[] items = LoadComboBox(colName);
                    createLBL(colName, ColHeadertex, 1, 1, true);
                    createCBX(colName, 1, 1, items);
                    createBTN("bntEditComboBoxItems", "Sửa...", 2);
                    Global._flag_style_of_panel1 = 4;
                    CurrentColumnsHeader_Clicked = dataGridView1.CurrentCell.ColumnIndex;
                }
                else
                {
                    Global._flag_style_of_panel1 = 0;
                    createLBL(colName, "Trường này không có sự lựa chọn!", 1, 1, true);
                }
            }

        }


        #endregion

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {

                query = " select " + Check100() + LayTenCot(Global.listColumns) + " from tblTongHopThongTinBienDong " + ShowDieuKien();
                LoadGrid(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
               Refresh();

        }
        private void Refresh()
        {
            Global._dieukien.Clear();
            Global._hienthi_dieukien.Clear();
            Global._Notification = "";
            Global.listColumns.Clear();
            Global._MaDonViHanhChinhHienThoi = "";
            Global._MaTrangThaiHoSo = "";
            LoadGrid();
            AddStyleDataGridView1ColumnHeader();
            LoadCmbDVHC();
            
        }
        #region "Xuat Excel"
        private string ColumnNameExcel(int i, int _row)
        {
            string[] _arr = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string _return = "";
            int _chia = 0;
            int _du = 0;
            if (i < _arr.Length)
            {
                _return = _arr[i] + _row.ToString();
            }
            else
            {
                _chia = i / (_arr.Length);
                _du = i % (_arr.Length);
                _return = _arr[_chia] + _arr[_du] + _row.ToString();
            }
            return _return;
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            string title = "\\Báo cáo ngày " + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".xls";

            string DefaultPath = System.Windows.Forms.Application.StartupPath + "\\ThongKeBienDong";
            if (!System.IO.Directory.Exists(DefaultPath))
                System.IO.Directory.CreateDirectory(DefaultPath);


            for (j = 0; j < dataGridView1.ColumnCount; j++)
            {
                string _header = dataGridView1.Columns[j].HeaderText.Trim();
                xlWorkSheet.Cells[4, j + 1] = _header;

                int ColumnWidth = dataGridView1.Columns[j].Width;
                Microsoft.Office.Interop.Excel.Range _range = xlWorkSheet.get_Range(ColumnNameExcel(j, 4), ColumnNameExcel(j, 4));
                _range.ColumnWidth = ColumnWidth / 6;// không biết đơn vị là gì nhưng thấy chia cho 6 thì kích thước tạm hợp lý
                _range.Font.Bold = true;
            }
            //------------------------------------
            Microsoft.Office.Interop.Excel.Range _range1;
            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    xlWorkSheet.Cells[i + 5, j + 1] = cell.Value;

                    string _cell = ColumnNameExcel(j, i + 5);
                    _range1 = xlWorkSheet.get_Range(_cell, _cell);
                    _range1.WrapText = true;
                    _range1.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    _range1.Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                }
            }
            string filename = DefaultPath + title;
            filename.Replace("\\", "\\\\");
            xlWorkBook.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            System.Diagnostics.Process.Start(filename);
            // MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion


        private void cmbDVHC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _count = Global._dieukien.Count;
            if (_count > 0)
            {
                for (int i = 0; i < Global._dieukien.Count; i++)
                {
                    if (Global._dieukien[i].Contains("MaDonViHanhChinh"))
                    {
                        Global._dieukien.Remove(Global._dieukien[i]);
                        Global._hienthi_dieukien.Remove(Global._hienthi_dieukien[i]);
                    }

                }

            }

            if (cmbDVHC.Text.Trim() != "")
            {
                string _query = " select MaDonViHanhChinh from tblTuDienDonViHanhChinh where Ten = N'" + cmbDVHC.Text.Trim() + "'";
                string[] kq = cls._ExecuteReader(_query, "MaDonViHanhChinh");
                Global._MaDonViHanhChinhHienThoi = kq[0].ToString();
                Global._dieukien.Add(" MaDonViHanhChinh = '" + Global._MaDonViHanhChinhHienThoi + "' ");
                Global._hienthi_dieukien.Add(" Đơn vị hành chính = " + cmbDVHC.Text.Trim());
            }
            else
            {
                Global._MaDonViHanhChinhHienThoi = "";

            }

            query = " select " + Check100() + LayTenCot(Global.listColumns) + " from tblTongHopThongTinBienDong " + ShowDieuKien();
            LoadGrid(query);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Flag_ColumnsHeader_Clicked != 0)
                {
                    if (CurrentColumnsHeader_Clicked == e.ColumnIndex)
                    {
                        int _row = e.RowIndex;
                        foreach (Control ctrl in panel2.Controls)
                        {
                            if (ctrl is TextBox || ctrl is ComboBox)
                            {
                                ctrl.Text = dataGridView1.Rows[_row].Cells[CurrentColumnsHeader_Clicked].Value.ToString().Trim();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("dataGridView1_CellClick \n" + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                query = " select " + Check100() + LayTenCot(Global.listColumns) + " from tblTongHopThongTinBienDong " + ShowDieuKien();
                LoadGrid(query);
            }
            catch (Exception ex)
            { }
        }

    }
}
