using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjMenuHeThong
{
    public class clsDatabase
    {
        public SqlConnection sqlcon = new SqlConnection();
        public SqlCommand sqlcom;
        public  SqlDataReader reader;
        public SqlDataAdapter adt;
        public DataTable tbl = new DataTable();
        public DataSet ds = new DataSet();
        public void OpenConnection()
        {
            try
            {
                if (sqlcon.ConnectionString.Trim() == "")
                    sqlcon.ConnectionString = Global._connectionString;
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CloseConnection()
        {
            if (sqlcon.State == ConnectionState.Open)
                sqlcon.Close();
        }
        public int _ExecuteNonQuery(string query)
        {
            OpenConnection();
            sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = query;
            int kq = sqlcom.ExecuteNonQuery();
            CloseConnection();
            return kq;
        }
        public DataSet _ExecuteQuery(string query)
        {
            DataSet ds = new DataSet();
            ds.Clear();
            OpenConnection();
            sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = query;
            adt = new SqlDataAdapter(sqlcom);
            adt.Fill(ds);
            CloseConnection();
            return ds;
        }
        public string[] _ExecuteReader(string query, string OutColumns)
        {
            string _output = "";
            OpenConnection();
            sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = query;
            SqlDataReader _reader = sqlcom.ExecuteReader();
            while (_reader.Read())
            {
                _output += _reader[OutColumns]+";";
            }            
            CloseConnection();
            string[] Output = _output.Split(';');
            return Output;
        }
       
        public DataSet _Execute(string query)
        {           
            OpenConnection();
            sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = query;
            adt = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            adt.Fill(ds);
            CloseConnection();
            return ds;
        }

        public string _ExecuteScalar(string query)
        {
            string _result = "";
            OpenConnection();
            sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = query;
            _result = sqlcom.ExecuteScalar().ToString();           
            CloseConnection();
            return _result;
        }
        public string _ChayThuTuc(string StoreProcedureName)
        {

            string _result = "";
            OpenConnection();
            sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = StoreProcedureName;
            sqlcom.CommandType = CommandType.StoredProcedure;
            _result = sqlcom.ExecuteNonQuery().ToString();
            CloseConnection();
            return _result;
        }
    }
}
