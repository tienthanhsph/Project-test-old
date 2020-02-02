using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExePgnFile
{
    class clsDatabase
    {
        string strconnect = "Server=TIENTHANH-PC\\SQLEXPRESS;Database=PGN;User Id=sa;Password=Thanhid1;";
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
                if (sqlcon.State != ConnectionState.Open)
                    sqlcon.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void CloseConnect()
        {
            try
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }
        // xu ly thao tac insert to database, update database, hoac delete database
        public int Execute_NonQuery(string _query)
        {
            int kq = 0;
            try
            {
                OpenConnect();
                sqlcom = new SqlCommand(_query, sqlcon);
                kq = sqlcom.ExecuteNonQuery();
                CloseConnect();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
            return kq;
        }

        public int Execute_Procedure_NonPara(string _query)
        {
            int kq = 0;
            try
            {
                OpenConnect();
                sqlcom = new SqlCommand(_query, sqlcon);
                sqlcom.CommandType = CommandType.StoredProcedure;
                kq = sqlcom.ExecuteNonQuery();
                CloseConnect();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return kq;
        }

        // lay du lieu tu database
        public DataSet GetData(string _query)
        {
            ds.Clear();
            ds.Tables.Clear();
            try
            {
                OpenConnect();
                sqlcom = new SqlCommand(_query, sqlcon);
                sqlda = new SqlDataAdapter(sqlcom);
                sqlda.Fill(ds);
                CloseConnect();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return ds;
        }
    }
}

/*
    CREATE TABLE [dbo].[tblPGN](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Events] [nvarchar](50) NULL,
	[Site] [nvarchar](50) NULL,
	[Date] [nvarchar](50) NULL,
	[Rounds] [nvarchar](50) NULL,
	[White] [nvarchar](50) NULL,
	[Black] [nvarchar](50) NULL,
	[Result] [nvarchar](50) NULL,
	[WhiteElo] [nvarchar](50) NULL,
	[BlackElo] [nvarchar](50) NULL,
	[ECO] [nvarchar](50) NULL,
	[Content] [nvarchar](max) NULL
	)

 * 
 * 
 * 
 * CREATE TABLE [dbo].[tblNguoiChoi](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL
	)
 * 
 * 
 * 
 * 
alter procedure LocDuLieuTrungNhau
as
begin
	if(OBJECT_ID('tempdb..#tmpTam') is not null)
		drop table #tmpTam
		
	SELECT DISTINCT  Events, Site, Date, Rounds, White, Black, Result, WhiteElo, BlackElo, ECO, Content into #tmpTam	FROM tblPGN
	
	delete from tblPGN
	
	insert into tblPGN(Events, Site, Date, Rounds, White, Black, Result, WhiteElo, BlackElo, ECO, Content) select * from #tmpTam
	
	drop table #tmpTam

end
 * 
 * 
 * 
 * 
 * 
*/