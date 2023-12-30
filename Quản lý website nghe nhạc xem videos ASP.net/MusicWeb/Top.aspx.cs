using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
//Download source code tai Sharecode.vn
public partial class Top : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        string act = null;
        if (Request.QueryString.HasKeys())
        {
            act = Request.QueryString["T"].ToString();
        }
        switch (act)
        {
            case "Album":
                album();
                break;
           /* case "Music":
                musicmp3();
                break;
            case "Video":
                videomp4();
                break;*/
            default:
                break;
        }
    }
    public void album()
    {
        string sql = "select * from Album";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        Album__.DataSource = ds;
        Album__.DataBind();
        con.Close();
    }
}