using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


public partial class ChuDe : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        DisPlayMusic();
        Tentheloai();
           
    }
    public void Tentheloai()
    {
        string matheloai = Request.QueryString["L"].ToString();
        string Theloai = null;
        string sql = "select * from TheLoai where MaTheLoai='" + matheloai + "'";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader dr = cmd.ExecuteReader();
        //Download source code tai Sharecode.vn
        while (dr.Read())
        {
            Theloai = dr["TenTheLoai"].ToString();
        }
        Label1.Text = "Thể loại " + Theloai;
        con.Close();
    }
    public void DisPlayMusic()
    {
        string matheloai = Request.QueryString["L"].ToString();
        string sql = "select * from Music Where MaTheLoai='" + matheloai + "'";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataList5.DataSource = ds;
        DataList5.DataBind();
        con.Close();
    }
}