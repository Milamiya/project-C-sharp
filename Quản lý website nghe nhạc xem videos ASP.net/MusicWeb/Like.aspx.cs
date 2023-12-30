using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Like : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        string L = Request.QueryString["L"].ToString();
        string sql = "select * from Casi where MaCaSi='" + L + "'";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        int sLike =dr["YeuThich"].GetHashCode();
        int like2 = Convert.ToInt32(sLike);
        int like3=like2 +1;
        con.Close();
        update(like3);   
    }
    public void update(int like3)
    {
        string L = Request.QueryString["L"].ToString();
        string updatequery = "Update  Casi Set YeuThich =N'" + like3 + "' Where MaCaSi ='" + L + "'";
        con.Open();
        SqlCommand cmd = new SqlCommand(updatequery, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("ThongTin.aspx?TT=NgheSi");
    }
}