using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGridView();

        }
        private void LoadGridView()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var product = from p in db.Products
                          select p;
            dataGridView1.DataSource = product;
        }
        private void GridViewStyle()
        {
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    if (i % 2 == 0)
            //        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
            //    //else
            //        //dataGridView1.Rows[i].DefaultCellStyle.BackColor = SystemColors.Control;
            //}

            bg_dtg();

        }




        public void bg_dtg()
        {
            try
            {

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (IsOdd(i))
                    {

                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        Info info = new Info();
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Detail detail = new Detail();
            detail.label1.Text = "THÔNG TIN SẢN PHẨM \n\n" + ShowInfo(e.RowIndex);
            detail.Show();
            
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {

            info.Show();
            info.Location = new Point(Cursor.Position.X + 10, Cursor.Position.Y - 20);    
            info.label1.Text = ShowInfo(e.RowIndex);          

        }
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            info.Hide();
        }
        private string ShowInfo(int row_index)
        {
            string s = "";
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                s += dataGridView1.Columns[i].HeaderText+": "+ dataGridView1.Rows[row_index].Cells[i].Value.ToString() +"\n";
            }
            return s;
        }
        
       

    }
}
