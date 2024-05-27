using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AnalysisServices.AdomdClient;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WebApplication
{
    public class XULYDULIEU
    {
        OleDbConnection CON;
        public XULYDULIEU()
        {
            CON = new OleDbConnection();
            CON.ConnectionString = @"Provider=MSOLEDBSQL.1;Data Source=PHUCDO\MSSQLSERVER2019;Integrated Security=SSPI;Initial Catalog=dbKiemTra";
        }

        public void Open()
        {
            if (this.CON.State == ConnectionState.Closed)
                this.CON.Open();
        }
        public void Close()
        {
            if (this.CON.State == ConnectionState.Open)
                this.CON.Close();
        }

        public DataTable getTable(String SQL)
        {
            this.Open();
            DataTable tb = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(SQL, this.CON);
            adp.Fill(tb);
            this.Close();
            return tb;
        }

        public DataTable getPredicted(String SQL)
        {
            DataTable tb = new DataTable();
            AdomdConnection myconnect = new AdomdConnection(@"Provider=MSOLAP.8;Data Source=PHUCDO\MSSQLSERVER2019;Integrated Security=SSPI;Initial Catalog=Attrition_Analysis_Model");
            AdomdDataAdapter mycommand = new AdomdDataAdapter();
            mycommand.SelectCommand = new AdomdCommand();
            mycommand.SelectCommand.Connection = myconnect;

            mycommand.SelectCommand.CommandText = SQL;
            myconnect.Open();
            mycommand.Fill(tb);
            myconnect.Close();
            return tb;
        }

        
    }
}