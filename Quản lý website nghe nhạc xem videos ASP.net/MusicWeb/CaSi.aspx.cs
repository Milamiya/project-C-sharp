using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class CaSi : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        videomp4();
        HienDSNhacofCasy();
        casi();
    }
    public void videomp4()
    {
        string macasi = Request.QueryString["L"].ToString();
        string sql = "select * from Video,Casi,TheLoai where Casi.MaCaSi=Video.MaCaSi and Video.MaTheLoai=TheLoai.MaTheLoai and Casi.MaCaSi='" + macasi + "'";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        Video__.DataSource = ds;
        Video__.DataBind();
        con.Close();
    }
    public void HienDSNhacofCasy()
    {
        string macasi = Request.QueryString["L"].ToString();
        string sql = "select * from Music,Casi,TheLoai where Casi.MaCaSi=Music.MaCaSi and Music.MaTheLoai=TheLoai.MaTheLoai and Casi.MaCaSi='" + macasi + "'";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
        con.Close();
    }
    public void casi()
    {
        string macasi = Request.QueryString["L"].ToString();
        string sql = "select * from Casi Where MaCaSi='" + macasi + "'";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        NgheSi__.DataSource = ds;
        NgheSi__.DataBind();
        con.Close();
    }
}