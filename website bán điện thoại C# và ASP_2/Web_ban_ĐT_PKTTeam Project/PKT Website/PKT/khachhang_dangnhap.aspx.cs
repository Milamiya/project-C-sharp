using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PKT
{
    public partial class khachhang_dangnhap : System.Web.UI.Page
    {
        string act = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();   
            }
            if(Session["action"]!=null)
            act = Session["action"].ToString();
        }

        protected void load()
        {
            if (Request.Cookies["username"] != null)
            {
                HttpCookie c = Request.Cookies["username"];
                username.Text = c.Value;
            }
        }

        protected void login_Click(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            string sql = "select* from Khachhang where Email=@email";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", username.Text);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool kt = reader.Read(); reader.Close();
            if (kt)
            {
                cmd.CommandText = "select* from KhachHang where Email=@email and PassWord=@pass";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@email", username.Text);
                cmd.Parameters.AddWithValue("@pass", pass.Text);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Session["namecus"] = (string)reader["HoTen"];
                    Session["idcus"] = (string)reader["MaKH"];
                    HttpCookie c = new HttpCookie("username", username.Text);
                    c.Expires = DateTime.Now.AddDays(1D);
                    Response.Cookies.Add(c);
                    reader.Close();
                    Response.Write(act);
                    if (act == "loginshop")
                    {
                        Response.Redirect("dathang.aspx");
                    }
                    else
                    {
                        Response.Redirect("index.aspx");
                    }
                }
                else error.Text = "Sai password!";
            }
            else error.Text = "Email không tồn tại!";
        }

        protected void pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}