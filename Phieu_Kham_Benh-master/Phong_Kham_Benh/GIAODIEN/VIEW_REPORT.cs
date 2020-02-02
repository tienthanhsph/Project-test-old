using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using DB;

namespace GIAODIEN
{
    public partial class VIEW_REPORT : Form
    {
        public VIEW_REPORT()
        {
            InitializeComponent();
        }
        public int _thang = 0;
        public int _nam = 0;
        public int _maphieu = 0;
        private void VIEW_REPORT_Load(object sender, EventArgs e)
        {
            
        }
        public void LoadDoanhThuTheoThang()
        {
            try
            {
                
                RptDoanhThuTheoNgay _doanhthungay = new RptDoanhThuTheoNgay();
                
                string path = Application.StartupPath + "\\RptDoanhThuTheoNgay.rpt";
                _doanhthungay.FileName = path;
                _doanhthungay.SetDatabaseLogon("sa", "dmc3star", "TIENTHANH-PC", "phong_kham_benh");
                _doanhthungay.SetParameterValue("@Nam", _nam);
                _doanhthungay.SetParameterValue("@Thang", _thang);            
                
                crystalReportViewer1.ReportSource = _doanhthungay;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadDoanhThuTheoNam()
        {
            try
            {
                RptDoanhThuTheoThang _doanhthuthang = new RptDoanhThuTheoThang();
                //ParameterValues a = new ParameterValues();
                //ParameterDiscreteValue b = new ParameterDiscreteValue();
                //b.Value = _nam;
                //a.Add(b);
                //_doanhthuthang.DataDefinition.ParameterFields["@Nam"].ApplyCurrentValues(a);

                string path = Application.StartupPath + "\\RptDoanhThuTheoThang.rpt";
                _doanhthuthang.FileName = path;

                _doanhthuthang.SetDatabaseLogon("sa", "dmc3star", "TIENTHANH-PC", "phong_kham_benh");
                _doanhthuthang.SetParameterValue("@Nam", _nam);
                crystalReportViewer1.ReportSource = _doanhthuthang;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadPhieuKham()
        {
            try
            {
                RptPhieuKham _phieukham = new RptPhieuKham();
                //ParameterValues a = new ParameterValues();
                //ParameterDiscreteValue b = new ParameterDiscreteValue();
                //b.Value = _maphieu;
                //a.Add(b);
                //_phieukham.DataDefinition.ParameterFields["@PK_MaPhieu"].ApplyCurrentValues(a);

                string path = Application.StartupPath + "\\RptPhieuKham.rpt";
                _phieukham.FileName = path;

                _phieukham.SetDatabaseLogon("sa", "dmc3star", "TIENTHANH-PC", "phong_kham_benh");
                _phieukham.SetParameterValue("@PK_MaPhieu", _maphieu);
                //_phieukham.SetDataSource(dt);
                crystalReportViewer1.ReportSource = _phieukham;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
