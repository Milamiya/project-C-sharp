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
using System.Data.SqlClient;
namespace DoAn4
{
    public class Data
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        SqlCommand cmd;
        string strconnect;
        string qr;
        public Data()
        {

        }
        public void message(System.Web.UI.Page pg, string error)
        {
            string bao = "<script language='javascript'>alert('" + error + "') <\\script>";
            pg.ClientScript.RegisterClientScriptBlock(pg.GetType(), "key", bao.Replace("\\", "/"));
        }
        public Data(string sqlconnect)
        {
            strconnect = sqlconnect;
        }
        public string setstrconnect
        {
            set { strconnect = value; }
            get { return strconnect; }
        }
        public DataSet fillDataSet(string sql)
        {
            ds = new DataSet();
            cmd = new SqlCommand(sql, cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;

        }
        public void MoKetNoi()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
        }
        public SqlDataReader Getcommand(string strquery)
        {
            MoKetNoi();
            SqlCommand Command = new SqlCommand(strquery, cn);
            Command.CommandText = strquery;

            return Command.ExecuteReader();
        }
        public void open()
        {
            cn = new SqlConnection(strconnect);
            cn.Open();
        }
        public string setqr
        {
            set { qr = value; }
            get { return qr; }
        }
        public DataTable gettable()
        {
            da = new SqlDataAdapter(qr, cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable gettable(string qr)
        {
            da = new SqlDataAdapter(qr, cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getsto(string sto)
        {
            cmd = new SqlCommand(sto, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getsto(string sto, SqlParameter[] value)
        {
            cmd = new SqlCommand(sto, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter m in value)
            {
                cmd.Parameters.Add(m);
            }
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insertdata(string qr)
        {
            cmd = new SqlCommand(qr, cn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
               // return false;
                throw;
            }
        }
        public bool getdata(DropDownList dd, string qr, string value, string text)
        {
            try
            {
                cmd = new SqlCommand(qr, cn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dd.DataSource = dt;
                dd.DataTextField = text;
                dd.DataValueField = value;
                dd.DataBind();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
