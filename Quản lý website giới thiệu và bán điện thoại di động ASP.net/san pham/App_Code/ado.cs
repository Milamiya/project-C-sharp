using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;

/// <summary>
/// Summary description for ado
/// </summary>
public class ado:System.Web.UI.Page
{
    public static OleDbConnection con;
    public static OleDbDataReader rd;
	public ado()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static void ketNoi()
    {
        con = new OleDbConnection();
        con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ToString();
        con.Open();
    }

    public static OleDbDataReader getData(string query)
    {

        OleDbCommand cmd = new OleDbCommand(query, con);
        return cmd.ExecuteReader();
    }

    public static int insertData(string query)
    {
        OleDbCommand cmd = new OleDbCommand(query, con);
        return cmd.ExecuteNonQuery();
    }

    public static int run(string query)
    {
        OleDbCommand cmd = new OleDbCommand(query, con);
        return cmd.ExecuteNonQuery();
    }


    public static void dongKetNoi()
    {
        if (con.State != ConnectionState.Closed)
        {
            con.Close();
            con.Dispose();
        }
    }
}
