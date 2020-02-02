using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB
{
    public class clsDatabase
    {
        string strconnect = "Server=TIENTHANH-PC;Database=phong_kham_benh;User Id=sa;Password=dmc3star;";
        SqlConnection sqlcon;
        SqlCommand sqlcom;
        SqlDataAdapter sqlda;
        SqlDataReader sqldr;
        DataSet ds = new DataSet();


        public void OpenConnect()
        {
            try
            {
                
                sqlcon = new SqlConnection(strconnect);
                sqlcon.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Không mở được kết nối!");
            }
        }

        public void CloseConnect()
        {
            if(sqlcon.State == ConnectionState.Open)
                sqlcon.Close();
        }

        public void Execute_NonQuery(string strsql)
        {
            OpenConnect();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqlcom.ExecuteNonQuery();
            CloseConnect();


        }
        public string Execute_Reader(string strsql)
        {
            string strketqua = "";
            OpenConnect();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {                
                    strketqua = sqldr[0].ToString();
            }
            CloseConnect();
            return strketqua;
        }

        public void loaddatagridview(DataGridView dg, string strselect)
        {
            OpenConnect();
            ds.Clear();
            sqlda = new SqlDataAdapter(strselect, strconnect);
            sqlda.Fill(ds);
            dg.DataSource = ds.Tables[0];
            CloseConnect();
        }

        public void loadcombobox(ComboBox cb, string strselect, byte chiso)
        {
            OpenConnect();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr[chiso].ToString());
            }
            CloseConnect();
        }

        public bool kttrungkhoa(string dauvao, string strsql)
        {
            bool ok = false;
            OpenConnect();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    ok = true;
            }
            CloseConnect();
            return ok;
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcom);               
                sqlDataAdapter.Fill(dtResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOI!________________________________________________\n"+ex.Message);                
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
