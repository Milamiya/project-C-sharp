using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

public partial class admin_QL_TheLoai : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        string act = null;
        if (Session["DangNhap"] == null)
            Response.Redirect("~/login.aspx");
        if (Request.QueryString.HasKeys())
        {
            act = Request.QueryString["Tl"].ToString();
        }
        switch (act)
        {
            case "Xem":
                MultiView1.ActiveViewIndex = 0;
                break;

            case "Sua":
                MultiView1.ActiveViewIndex = 1;
                break;

            case "Them":
                MultiView1.ActiveViewIndex = 2;
                break;

            default:
                break;
        }
    }
    protected void btn_xoa_theloai_Click(object sender, EventArgs e)
    {
        string insertquery = "Delete From  TheLoai Where MaTheLoai ='" + txt_xoa_theloai.Text + "'";
        SqlCommand cmd = new SqlCommand(insertquery, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script>alert('Xóa Thành Công')</script>");
        Response.Redirect("QL_TheLoai.aspx?Tl=Xem");
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {       
        string updatequery = "Update  TheLoai Set TenTheLoai=N'" + txt_tentheloai
            .Text + "' Where MaTheLoai ='" + txt_tim_theloai.Text + "'";
        con.Open();
        SqlCommand cmd = new SqlCommand(updatequery, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("QL_TheLoai.aspx?Tl=Xem");
    }
    protected void btn_tim_theloai_Click(object sender, EventArgs e)
    {
        string tim = txt_tim_theloai.Text;
        string insertquery = "Select * From  TheLoai Where MaTheLoai ='" + tim + "'";
        con.Open();
        SqlCommand cmd = new SqlCommand(insertquery, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            txt_tentheloai.Text = dr["TenTheLoai"].ToString();         
        }
    }
    protected void btn_add_theloai_Click(object sender, EventArgs e)
    {
        string insert = "insert into TheLoai (TenTheLoai) Values (N'" +txt_add_tentheloai.Text + "')";
        con.Open();
        SqlCommand cmdd = new SqlCommand(insert, con);
        cmdd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("QL_TheLoai.aspx?Tl=Xem");
    }
}