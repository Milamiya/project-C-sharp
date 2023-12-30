using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Chat : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        binhluan();
        nhapbinhluan();
    }
    public void binhluan()
    {
        string sql = "select * from UserDaTa,Chat where UserDaTa.MaUser=Chat.MaUsert ORDER BY NgayDang Desc";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataList_binhluan.DataSource = ds;
        DataList_binhluan.DataBind();
        con.Close();
    }
    public void nhapbinhluan()
    {
        if (Session["DangNhap"] != null)
        {
            string imL = null;
            string insertquery = "Select * From  UserDaTa Where TenDangNhap ='" + Session["DangNhap"] + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(insertquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                imL = dr["Hinh"].ToString();
                lab_tenuser.Text = dr["HoTen"].ToString();
            }
            string imgL = "img_user/" + imL;
            Image_user.ImageUrl = imgL;
            con.Close();
        }
    }
    protected void btn_gui_Click(object sender, EventArgs e)
    {
        if (Session["DangNhap"] != null)
        {
            string insertquery = "Select * From  UserDaTa Where TenDangNhap ='" + Session["DangNhap"] + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(insertquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string id = dr["MaUser"].ToString();
            con.Close();
            xacnhan(id);
        }
        else
            Response.Redirect("Login.aspx");
    }
    public void xacnhan(string id)
    {
        DateTime ngaygio = DateTime.Now;
        string tmp = null;
        int gio = DateTime.Now.Hour;
        int phut = DateTime.Now.Minute;
        tmp = gio + ":" + phut;
        string insert = "insert into Chat (MaUsert,LoiBinh,NgayDang) Values (N'" + id + "',N'" + txt_binhluan.Text + "',N'" + ngaygio.ToString("MM/dd/yyyy") + " " + tmp + "')";
        con.Open();
        SqlCommand cmdd = new SqlCommand(insert, con);
        cmdd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("Chat.aspx");
    }

}