using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
public partial class ThongTin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        string act = null;
        if (Request.QueryString.HasKeys())
        {
            act = Request.QueryString["TT"].ToString();
        }
        switch (act)
        {
            case "Album":
                album();
                break;
            case "Music":
                musicmp3();
                break;
            case "Video":
                videomp4();
                break;
            case "NgheSi":
                casi();
                break;
                
            default:
                break;
        }
                     
    }
    public void musicmp3()
    {
        string sql = "select top 10* from Music,Casi,TheLoai where Casi.MaCaSi=Music.MaCaSi and Music.MaTheLoai=TheLoai.MaTheLoai ORDER BY NgayDang Desc";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        Music__.DataSource = ds;
        Music__.DataBind();
        con.Close();
    }
    public void videomp4()
    {
        string sql = "select * from Video,Casi,TheLoai where Casi.MaCaSi=Video.MaCaSi and Video.MaTheLoai=TheLoai.MaTheLoai ";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        Video__.DataSource = ds;
        Video__.DataBind();
        con.Close();
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
    public void casi()
    {
        string sql = "select * from Casi ORDER BY YeuThich Desc";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        NgheSi__.DataSource = ds;
        NgheSi__.DataBind();
        con.Close();
    }

 
}