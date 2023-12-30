using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PKT
{
    public partial class dathang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idcus"] != null)
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionstring);
                string sql = "select * from KhachHang where MaKH=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", Session["idcus"].ToString());
                conn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    ten.Text = r["HoTen"].ToString();
                    cmnd.Text = r["CMND"].ToString();
                    diachi.Text = r["DiaChi"].ToString();
                    dt.Text = r["DT"].ToString();
                    email.Text = r["Email"].ToString();
                }
                r.Close();
                conn.Close();
                check.Enabled = false;
            }
            else
                check.Enabled = true;

            Session["action"] = "loginshop";
        }

        protected void ten_TextChanged(object sender, EventArgs e)
        {
            if (ten.Text.Length == 0)
                e1.Text = "Tên không được rỗng!";
            else e1.Text = "";

            cmnd.Focus();
        }

        protected void cmnd_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(cmnd.Text, @"^[0-9]+$"))
            {
                if (cmnd.Text.Length == 9)
                    e2.Text = "";
                else
                    e2.Text = "CMND bao gồm 9 chữ số!";
            }
            else
                e2.Text = "Chỉ được nhập số tại đây!";

            diachi.Focus();
        }

        protected void diachi_TextChanged(object sender, EventArgs e)
        {
            dt.Focus();
        }

        protected void dt_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(dt.Text, @"^[0-9]+$"))
            {
                if (dt.Text.Length >= 10 && dt.Text.Length <= 11)
                    e4.Text = "";
                else
                    e4.Text = "Số điện thoại phải từ 10 - 11 số";
            }
            else
                e4.Text = "Chỉ được nhập số!";

            email.Focus();
        }

        protected void email_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(email.Text, @"^[A-z0-9_]+([.][A-z0-9_]+)*[@][A-z0-9_]+([.][A-z0-9_]+)*[.][A-z]{2,4}$"))
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionstring);
                string sql = "select * from KhachHang where Email=@email";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", email.Text);
                conn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                    e5.Text = "Email này đã được đăng ký";
                else
                    e5.Text = "";
                r.Close();
                conn.Close();
            }
            else
                e5.Text = "Bạn đã nhập sai!";
            
        }

        protected void buttom_next_Click(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            if (Session["idcus"] == null)
            {
                if (e1.Text.Length != 0 || e2.Text.Length != 0 || e3.Text.Length != 0 || e4.Text.Length != 0 || e5.Text.Length != 0)
                    e6.Text = "Xác nhận thất bại! Vui lòng kiểm tra lại thông tin!";
                else
                {
                    string sql = "insert KhachHang(MaKH,HoTen,CMND,DiaChi,DT,Email,PassWord)" +
                        "values('',@ten,@cmnd,@dc,@dt,@email,@pass)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ten", ten.Text);
                    cmd.Parameters.AddWithValue("@cmnd", cmnd.Text);
                    cmd.Parameters.AddWithValue("@dc", diachi.Text);
                    cmd.Parameters.AddWithValue("@dt", dt.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@pass", "123456abcdef");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "select MaKH from KhachHang where Email=@email";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    string makh = (string)cmd.ExecuteScalar();
                    cmd.CommandText = "update HoaDonBan set MaKH=@makh where MaHDBan=@mahd";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@mahd", Session["idshop"].ToString());
                    cmd.Parameters.AddWithValue("@MaKH", makh);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Response.Redirect("xacnhan.aspx");
                }
            }
            else 
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand( "update HoaDonBan set MaKH=@makh where MaHDBan=@mahd",conn);
                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@mahd", Session["idshop"].ToString());
                cmd1.Parameters.AddWithValue("@MaKH", Session["idcus"].ToString());
                cmd1.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("xacnhan.aspx");
            }
        }
    }
}