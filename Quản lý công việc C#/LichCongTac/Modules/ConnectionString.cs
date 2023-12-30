using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace LichCongTac.Modules
{
    public class ConnectionString
    {
        public ConnectionString()
        { }

        public string strServerName = "", strDatabaseName = "", strUserName = "", strPass = "";
        public SqlConnection sqlCNN = null;

        private void ReadXML()
        {
            string strPath = Path.GetFullPath("Server.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(strPath);

            if((ds != null) && (ds.Tables[0].Rows.Count>0))
            {
                strServerName = ds.Tables[0].Rows[0]["ServerName"].ToString().Trim();
                strDatabaseName = ds.Tables[0].Rows[0]["Database"].ToString().Trim();
                strUserName = ds.Tables[0].Rows[0]["UserName"].ToString().Trim();
                strPass = ds.Tables[0].Rows[0]["PassWord"].ToString().Trim();
            }
        }

        public void getConnectionString()
        {
            ReadXML();
            string strConn = "Server='" + strServerName + "';Initial Catalog='" + strDatabaseName + "';User Id='" + strUserName + "';pwd ='" + strPass + "'";
            sqlCNN = new SqlConnection(strConn);
            if ((sqlCNN != null) && (sqlCNN.State == ConnectionState.Closed))
            {
                sqlCNN.Open();
            }
        }
    }
}
