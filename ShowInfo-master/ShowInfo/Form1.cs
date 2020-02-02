using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShowInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon;
        SqlCommand sqlcom;
        SqlDataAdapter sqlDA;
        DataSet ds = new DataSet();
        private void OpenCon()
        {
            try
            {
                string connectionstring = " server =TIENTHANH-PC\\SQLEXPRESS; database = northwind ; User id = sa; Password =1 ";
                    if(sqlcon==null){
                        sqlcon = new SqlConnection(connectionstring);
                    }
                else sqlcon.ConnectionString = connectionstring;
                if(sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
            }
            catch (Exception)
            {
                return;
            }
        }
        private void CloseCon()
        {
            if (sqlcon != null)
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
        }
        private DataSet getData(string query)
        {
            OpenCon();
            if (sqlcom == null)
                sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = query;
            sqlcom.CommandType = CommandType.Text;
            if (sqlDA == null)
                sqlDA = new SqlDataAdapter(sqlcom);
            DataSet dts = new DataSet();
            sqlDA.Fill(dts);
            CloseCon();
            return dts;
        }
        private void Execute(string query)
        {
            OpenCon();
            if (sqlcom == null)
                sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = query;
            sqlcom.CommandType = CommandType.Text;
            sqlcom.ExecuteNonQuery();
            CloseCon();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ds = getData("SELECT top(200) [OrderID] ,[ShipName] FROM [Orders]");
            for (int i = 0; i < 1; i++)
            {
                w("Begin");                
                Refresh();
                ReadEachLine();
                w("End");
                Refresh();
            }
               
            
        }
        private void w(string s)
        {
            DateTime t = DateTime.Now;
            richTextBox1.Text += "\n#" + s + "    " + t.Hour + "h:" + t.Minute + "m:" + t.Second + "s:" + t.Millisecond + "ms";
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
        private void ReadEachLine(){
            DataTable tb = ds.Tables[0];
            string s="";
            if(tb.Rows.Count>0){
                for(int i=0;i<tb.Rows.Count;i++){
                    s="insert into tbl(ID, ShipName) values (N'"+XULYXAU(tb.Rows[i][0].ToString())+"',N'"+ XULYXAU(tb.Rows[i][1].ToString())+"')";
                    Execute(s);
                    w("Add one Rows");
                    Refresh();
                    
                }
            }
        }
        private string XULYXAU(string input)
        {
            string output = input.Replace('\'', ' ');
            return LocDau(output);            
        }
        private  readonly string[] VietNamChar = new string[] 
        { 
            "aAeEoOuUiIdDyY", 
            "áàạảãâấầậẩẫăắằặẳẵ", 
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", 
            "éèẹẻẽêếềệểễ", 
            "ÉÈẸẺẼÊẾỀỆỂỄ", 
            "óòọỏõôốồộổỗơớờợởỡ", 
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", 
            "úùụủũưứừựửữ", 
            "ÚÙỤỦŨƯỨỪỰỬỮ", 
            "íìịỉĩ", 
            "ÍÌỊỈĨ", 
            "đ", 
            "Đ", 
            "ýỳỵỷỹ", 
            "ÝỲỴỶỸ" 
        };
        public  string LocDau(string str)
        {
            //Thay thế và lọc dấu từng char      
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str;
        }
    }
}
