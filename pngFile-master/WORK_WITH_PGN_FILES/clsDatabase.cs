using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WORK_WITH_PGN_FILES
{
    class clsDatabase
    {
        string strconnect = "Server=TIENTHANH\\SQLEXPRESS2012;Database=WORK_WITH_PGN_FILE;User Id=sa;Password=1;";
        SqlConnection sqlcon;
        SqlCommand sqlcom;
        SqlDataAdapter sqlda;
        SqlDataReader sqldr;
        DataSet ds = new DataSet();


        public void OpenConnect()
        {
            sqlcon = new SqlConnection(strconnect);
            if (sqlcon.State != ConnectionState.Open)
                sqlcon.Open();
        }

        public void CloseConnect()
        {
            if (sqlcon.State == ConnectionState.Open)
                sqlcon.Close();
        }

        public int Execute_NonQuery(string strsql)
        {
            OpenConnect();
            sqlcom = new SqlCommand(strsql, sqlcon);
            int kq = sqlcom.ExecuteNonQuery();
            CloseConnect();
            return kq;
        }
        public string Execute_Reader(string procedureName, string TenKienTuong)
        {
            OpenConnect();
            sqlcom = new SqlCommand(procedureName, sqlcon);
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.Parameters.Add("@TenKienTuong",SqlDbType.NVarChar);
            sqlcom.Parameters["@TenKienTuong"].Value = TenKienTuong;
            sqldr = sqlcom.ExecuteReader();
            string strketqua = "";
            while (sqldr.Read())
            {
                strketqua += sqldr[1] + "\n";
                strketqua += sqldr[2] + "\n";
                strketqua += sqldr[3] + "\n";
                strketqua += sqldr[4] + "\n";
                strketqua += sqldr[5] + "\n";
                strketqua += sqldr[6] + "\n";
                strketqua += sqldr[7] + "\n";
                strketqua += sqldr[8] + "\n";
                strketqua += sqldr[9] + "\n";
                strketqua += sqldr[10] + "\n";
                strketqua += sqldr[11] + "\n";
                strketqua += "\n";
            }
            CloseConnect();
            return strketqua;

            
        }
        public int Execute_Scalar(string strsql)
        {
            int _return = 0;
            OpenConnect();
            sqlcom = new SqlCommand(strsql, sqlcon);
            string kq = sqlcom.ExecuteScalar().ToString();
            if (kq != "")
                _return = 1;
            CloseConnect();
            return _return;
        }
       

        public string[] ReadFromTable(string TableName)
        {
            string sqlCount = "select Count(*) from " + TableName;
            OpenConnect();
            sqlcom = new SqlCommand(sqlCount);
            int Count = Convert.ToInt32(sqlcom.ExecuteScalar());
            CloseConnect();


            string[] strketqua = new string[Count * 11];
            OpenConnect();
            sqlcom = new SqlCommand("Select * from " + TableName);
            sqldr = sqlcom.ExecuteReader();
            int i = 0;
            while (sqldr.Read())
            {
                strketqua[i] = sqldr[1].ToString();
                strketqua[i + 1] = sqldr[2].ToString();
                strketqua[i + 2] = sqldr[3].ToString();
                strketqua[i + 3] = sqldr[4].ToString();
                strketqua[i + 4] = sqldr[5].ToString();
                strketqua[i + 5] = sqldr[6].ToString();
                strketqua[i + 6] = sqldr[7].ToString();
                strketqua[i + 7] = sqldr[8].ToString();
                strketqua[i + 8] = sqldr[9].ToString();
                strketqua[i + 9] = sqldr[10].ToString();
                strketqua[i + 10] = sqldr[11].ToString();
                i += 11;
            }
            CloseConnect();
            return strketqua;
        }

        
        public void getValue(ref DataTable dtResult, string strSP, string[] strPara, string[] strValues)
        {
            try
            {

                sqlcom = new SqlCommand();
                sqlcom.Connection = sqlcon;
                sqlcom.CommandTimeout = 0;
                sqlcom.CommandType = CommandType.StoredProcedure;
                sqlcom.CommandText = strSP;
                SqlParameter sqlPara = null;
                for (int i = 0; i <= strPara.Length - 1; i++)
                {
                    sqlPara = new SqlParameter(strPara[i], strValues[i]);
                    sqlcom.Parameters.Add(sqlPara);
                }
                sqlda = new SqlDataAdapter(sqlcom);
                int _dem = sqlda.Fill(dtResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOI!________________________________________________\n" + ex.Message);
            }
        }
        public void ExecuteSP(string strSP, string[] strParameters, string[] strValues, ref string strResult)
        {
            try
            {
                sqlcom = new SqlCommand();
                sqlcom.Connection = sqlcon;
                sqlcom.CommandTimeout = 60;
                sqlcom.CommandType = CommandType.StoredProcedure;
                sqlcom.CommandText = strSP;
                SqlParameter sqlPara = null;
                for (int i = 0; i <= strValues.Length - 1; i++)
                {
                    sqlPara = new SqlParameter(strParameters[i], strValues[i]);
                    sqlcom.Parameters.Add(sqlPara);
                }
                strResult = Convert.ToString(sqlcom.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOI!________________________________________________\n" + ex.Message);
            }
        }
    }
}
