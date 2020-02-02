using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Scan
{
    public class clsDatabase
    {
        SqlConnection sqlcon;       
        SqlDataAdapter sqlda;
        DataSet ds = new DataSet();
        public void OpenCon()
        {
            if (sqlcon == null)
                sqlcon = new SqlConnection();
            sqlcon.ConnectionString = clsGlobal.glbConnectionString;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi mở kết nối csdl");
            }
        }

        public void CloseCon()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi đóng kết nối csdl");
            }
        }
        public DataSet ExecuteQuery(string query)
        {
            ds.Tables.Clear();
            OpenCon();
            try
            {                
                SqlCommand sqlcom = sqlcon.CreateCommand();
                sqlcom.CommandText = query;
                sqlda = new SqlDataAdapter(sqlcom);
                sqlda.Fill(ds);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi ExecuteQuery");
            }
            CloseCon();
            return ds;
        }
        public DataSet GetData(string StoreProcedure, string[] Paras, string[] Values)
        {            
            ds.Tables.Clear();
            if (Paras.Length != Values.Length)
            {
                System.Windows.Forms.MessageBox.Show("Parameter không đúng cặp!");
                return null;
            }
            else
            {
                OpenCon();
                try
                {
                    SqlCommand sqlcom = sqlcon.CreateCommand();
                    sqlcom.CommandType = CommandType.StoredProcedure;
                    sqlcom.CommandText = StoreProcedure;
                    for (int i = 0; i < Paras.Length; i++)
                    {
                        SqlParameter sqlpara = new SqlParameter(Paras[i].Trim(), Values[i].Trim());
                        sqlcom.Parameters.Add(sqlpara);
                    }  
                    sqlda = new SqlDataAdapter(sqlcom);
                    sqlda.Fill(ds);
                    
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Lỗi GetData \n"+ex.Message);
                }
                CloseCon();
            }

            return ds;
        }
    }
}
