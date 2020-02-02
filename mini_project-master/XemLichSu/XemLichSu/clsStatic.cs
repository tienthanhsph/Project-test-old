using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace XemLichSu
{
    public static class clsStatic
    {
        public static string Username{get;set;}
        public static string MaQuyen { get; set; }


                
        public static void GiamSatNhapLieu_save(string mahs,  string thaotac, string danhmuc, string noidung)
        {
            string query = " INSERT INTO [dbo].[tblGiamSatNhapLieu] " +
              "  ([ThoiDiem] " +
              "  ,[Username] " +
              "  ,[MaHoSo] " +
              "  ,[ThaoTac] " +
              "  ,[DanhMuc] " +
              "  ,[NoiDung]) " +
            "  VALUES " +
              "  (N'" + DateTime.Now.ToString() + "' " +
              "  ,N'" + Username + "' " +
              "  ,N'" + mahs + "' " +
              "  ,N'" + thaotac + "' " +
              "  ,N'" + danhmuc + "' " +
              "  ,N'" + noidung + "' )";
            clsDatabase cls = new clsDatabase();
            cls.ExecuteQueryInsertUpdateDelete(query);
        }




        public static void TrangThaiBanDau(Control ctrl)
        {
            if (ctrl.Controls.Count > 0)
            { 
                for(int i=0;i< ctrl.Controls.Count;i++)
                {
                    ctrl.Controls[i].Enabled=false;
                    
                }
            }
            
        }
        public static void TrangThaiChucNang(Control ctrl)
        {
            if (ctrl.Controls.Count > 0)
            { 
                for(int i=0;i< ctrl.Controls.Count;i++)
                {
                    ctrl.Controls[i].Enabled=true;
                    
                }
            }
            
        }
        public static void TrangThaiKetThuc(Control ctrl)
        {
            if (ctrl.Controls.Count > 0)
            {
                for (int i = 0; i < ctrl.Controls.Count; i++)
                {
                    ctrl.Controls[i].Enabled = false;

                }
            }
            
        }
        
        public static void LoadDataGridView(DataGridView grv, string query)
        {
            clsDatabase cls = new clsDatabase();
            grv.DataSource = cls.ExecuteQuery(query).Tables[0];
        }
        public static void LoadData(DataGridView grv,int RowIndex, string[] Paras, Control[] Ctrls)
        {
            try {
                if (Paras.Length == Ctrls.Length)
                {
                    for (int i = 0; i < Paras.Length; i++)
                    {
                        if (Ctrls[i] is TextBox || Ctrls[i] is RichTextBox || Ctrls[i] is ComboBox)
                        {
                            Ctrls[i].Text = grv.Rows[RowIndex].Cells[Paras[i]].Value.ToString();
                        }
                        if (Ctrls[i] is DateTimePicker)
                        {
                            ((DateTimePicker)Ctrls[i]).Value = Convert.ToDateTime(grv.Rows[RowIndex].Cells[Paras[i]].Value.ToString());
                        }
                    }
                
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
