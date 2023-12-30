using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Home : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        musicmp3();
        videomp4();
        album();
        HienBH();
        binhluan();
        nhapbinhluan();
        
    }
    public void musicmp3()
    {
        string sql = "select top 20* from Music,Casi,TheLoai where Casi.MaCaSi=Music.MaCaSi and Music.MaTheLoai=TheLoai.MaTheLoai ORDER BY NgayDang Desc";
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
    public void HienBH()
    {
        string sql = "select * from Music order by LuotXem desc";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
        con.Close();
        //Download source code tai Sharecode.vn
    }
    public void binhluan()
    {
        string sql = "select * from UserDaTa,BinhLuan where UserDaTa.MaUser=BinhLuan.MaUser ORDER BY NgayDang Desc";
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
            //Download source code tai Sharecode.vn
           string insertquery = "Select * From  UserDaTa Where TenDangNhap ='" + Session["DangNhap"] + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(insertquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();             
            string id= dr["MaUser"].ToString();          
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
        string insert = "insert into BinhLuan (MaUser,LoiBinh,NgayDang) Values (N'" + id + "',N'" + txt_binhluan.Text + "',N'" + ngaygio.ToString("MM/dd/yyyy") + " " + tmp + "')";
        con.Open();
        SqlCommand cmdd = new SqlCommand(insert, con);
        cmdd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("Home.aspx");
    }
}
