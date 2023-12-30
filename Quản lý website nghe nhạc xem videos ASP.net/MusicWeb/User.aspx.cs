using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

public partial class User : System.Web.UI.Page
{
    public string act;
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        act = null;
        if (Request.QueryString.HasKeys())
        {
            act = Request.QueryString["cmd"].ToString();
        } 
        string imL = null;
        if (Session["DangNhap"] != null)
        {
            string insertquery = "Select * From  UserDaTa Where TenDangNhap ='" + Session["DangNhap"] + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(insertquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                imL = dr["Hinh"].ToString();
                Lab_ten.Text = dr["HoTen"].ToString();
                Lab_taikhoan.Text = dr["TenDangNhap"].ToString();
                Lab_pass.Text=dr["MatKhau"].ToString();
                Lab_ngaysinh.Text = dr["NamSinh"].ToString();
                Lab_gioitinh.Text=dr["GioiTinh"].ToString();
                Lab_chungminh.Text = dr["CMT"].ToString();
                Lab_mail.Text = dr["Email"].ToString();
            }
            con.Close();
            string imgL = "img_user/" + imL;
            Image11.ImageUrl = imgL;
        }
        else
            Response.Redirect("Login.aspx");
    }
    protected void btn_tenmoi_Click(object sender, EventArgs e)
    {
        con.Open();
        string updatequery = "Update  UserDaTa Set HoTen =N'" + txt_tenmoi.Text + "' Where TenDangNhap ='" + Session["DangNhap"] + "'";
        SqlCommand cmd = new SqlCommand(updatequery, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("User.aspx");

    }
    protected void btn_pass_Click(object sender, EventArgs e)
    {
        con.Open();
        string updatequery = "Update  UserDaTa Set MatKhau =N'" + txt_pass.Text + "' Where TenDangNhap ='" + Session["DangNhap"] + "'";
        SqlCommand cmd = new SqlCommand(updatequery, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("User.aspx");
    }
    protected void btn_ngaysinh_Click(object sender, EventArgs e)
    {
        string th = Drop_thang.SelectedValue.ToString();
        string ng = Drop_ngay.SelectedValue.ToString();
        string nam = txt_namsinh.Text;
        string ns = th + "/" + ng + "/" + nam;
        con.Open();
        string updatequery = "Update  UserDaTa Set NamSinh =N'" + ns + "' Where TenDangNhap ='" + Session["DangNhap"] + "'";
        SqlCommand cmd = new SqlCommand(updatequery, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("User.aspx");
    }
    protected void btn_gioitinh_Click(object sender, EventArgs e)
    {
        string gioitinh = Drop_Gioitinh.SelectedValue.ToString();
        con.Open();
        string updatequery = "Update  UserDaTa Set GioiTinh =N'" + gioitinh + "' Where TenDangNhap ='" + Session["DangNhap"] + "'";
        SqlCommand cmd = new SqlCommand(updatequery, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("User.aspx");
    }
    protected void btn_chungminh_Click(object sender, EventArgs e)
    {
        con.Open();
        string updatequery = "Update  UserDaTa Set CMT =N'" + txt_chungminh.Text + "' Where TenDangNhap ='" + Session["DangNhap"] + "'";
        SqlCommand cmd = new SqlCommand(updatequery, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("User.aspx");
    }
    protected void btn_mail_Click(object sender, EventArgs e)
    {
        string email = txt_mail.Text;
        string mail = Drop_mail.SelectedValue.ToString();
        string m = email + "@" + mail;
        con.Open();
        string updatequery = "Update  UserDaTa Set Email =N'" + m + "' Where TenDangNhap ='" + Session["DangNhap"] + "'";
        SqlCommand cmd = new SqlCommand(updatequery, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("User.aspx");
    }
}