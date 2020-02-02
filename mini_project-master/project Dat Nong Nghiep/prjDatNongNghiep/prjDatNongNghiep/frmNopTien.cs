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
    public partial class frmNopTien : Form
    {
        public frmNopTien()
        {
            InitializeComponent();
        }

        private void frmNopTien_Load(object sender, EventArgs e)
        {

        }
        public int IDThuaDat { get; set; }

        private void btnThue_Click(object sender, EventArgs e)
        {
            try{
                if(textBox1.Text.Trim() != "" || IDThuaDat != 0)
                {
                    string query = " update tblThuaDatCapGCNDatNN set TienDaNop = TienDaNop +" + textBox1.Text.Trim() +" where ID ="+IDThuaDat;
                    clsDatabase cls = new clsDatabase();
                    cls.ExecuteQueryInsertUpdateDelete(query);
                    this.Close();
                }
            }
            catch(Exception ex)
            {MessageBox.Show(ex.Message);}
            
        }
    }
}
