using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
namespace PKT
{
    public partial class gopy : System.Web.UI.Page
    {
        public bool bname = false;
        public bool bemail = false;
        public bool badd = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ten.Text = "";
                diachi.Text = "";
                dt.Text = "";
                email.Text = "";
                nd.Text = "";
            }
        }

        protected void gui_Click(object sender, EventArgs e)
        {
            if (bname == false || bemail == false || badd == false)
            {
                Label1.Text = "Vui lòng nhập thông tin cần thiết (có dấu *)";
            }
            else
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionstring);
                string sql = "insert FeedBack(MaFB,ChuDe,HoTen,DiaChi,DT,Email,NoiDung,TinhTrang) values('',@cd,@ht,@dc,@dt,@email,@nd,N'Chưa đọc')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cd", Chude.Text);
                cmd.Parameters.AddWithValue("@ht", ten.Text);
                cmd.Parameters.AddWithValue("@dc", diachi.Text);
                cmd.Parameters.AddWithValue("@dt", dt.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@nd", nd.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ten.Text = "";
                diachi.Text = "";
                dt.Text = "";
                email.Text = "";
                nd.Text = "";
                Label1.Text = "Gửi thành công! Cám ơn bạn đã góp ý!";
                Label2.Text = "";
                Label3.Text = "";
            }
        }

        protected void ten_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(ten.Text, "[a-zA-Z]+$"))
            {
                bname = false;
                Label2.Text = "Tên không được rỗng!";
               
            }
            else
            {
                bname = true;
                Label2.Text = "";
            }
        }

        protected void email_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(email.Text, @"^[A-z0-9_]+([.][A-z0-9_]+)*[@][A-z0-9_]+([.][A-z0-9_]+)*[.][A-z]{2,4}$"))
            {
               Label3.Text = "Bạn đã nhập sai email!";
               bemail = false;
            }
            else
            {
                bemail = true;
                Label3.Text = "";
            }
        }

        protected void nd_TextChanged(object sender, EventArgs e)
        {
            if (nd.Text == "")
            {
                badd = false;
            }
            else
            {
                badd = true;
            }
        }

    }
}