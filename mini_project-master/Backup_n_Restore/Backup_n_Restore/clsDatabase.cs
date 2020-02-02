using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjDatNongNghiep
{
    class clsDatabase
    {
        SqlConnection sqlcon;
        SqlDataAdapter sqlda;
        DataSet ds = new DataSet();
        public void OpenCon()
        {
            if (sqlcon == null)
                sqlcon = new SqlConnection();
            sqlcon.ConnectionString = clsConfig.ConnectString;
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
                    System.Windows.Forms.MessageBox.Show("Lỗi GetData \n" + ex.Message);
                }
                CloseCon();
            }

            return ds;
        }
        public int ExecuteSP(string StoreProcedure, string[] Paras, string[] Values)
        {
            int kq=0;
            ds.Tables.Clear();
            if (Paras.Length != Values.Length)
            {
                System.Windows.Forms.MessageBox.Show("Parameter không đúng cặp!");
                return 0;
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
                    kq = sqlcom.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Lỗi GetData \n" + ex.Message);
                }
                CloseCon();
            }

            return kq;
        }
        public string ExecuteQueryScalar(string query)
        {
            string result = "";
            OpenCon();
            try
            {
                SqlCommand sqlcom = sqlcon.CreateCommand();
                sqlcom.CommandText = query;
                if (sqlcom.ExecuteScalar() != null)
                    result = sqlcom.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi ExecuteQueryScalar");
            }
            CloseCon();
            return result;
        }
        public string ExecuteQueryInsertUpdateDelete(string query)
        {
            string result = "";
            OpenCon();
            try
            {
                SqlCommand sqlcom = sqlcon.CreateCommand();
                sqlcom.CommandText = query;
                result =sqlcom.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi ExecuteQueryScalar");
            }
            CloseCon();
            return result;
        }
    }
}
