using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

namespace PKT
{
    public partial class dangky : System.Web.UI.Page
    {
        public bool bname;
        public bool bphone;
        public bool bemail;
        public bool badd;
        public bool bidcard;
        public bool bpass;
        protected void Page_Load(object sender, EventArgs e)
        {
             
            if (!IsPostBack)
            {
                 Ngay_Load();ten.Focus();
                bname = false;
                bphone = false;
                bemail = true;
                badd = false;
                bidcard = false;
                bpass = false;
            }
            this.MaintainScrollPositionOnPostBack = true;
        }

        protected void Ngay_Load()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            string sql = "select* from Ngay";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            ngay.DataTextField = "Ngay";
            ngay.DataValueField = "Ngay";
            ngay.DataSource = reader;
            ngay.DataBind();
            reader.Close();
            conn.Close();
        }

        protected void ngay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            string sql = "select* from Thang where @ngay<=Ngay";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ngay", ngay.SelectedValue);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            thang.DataTextField = "Thang";
            thang.DataValueField = "Thang";
            thang.DataSource = reader;
            thang.DataBind();
            reader.Close();
            conn.Close();
        }

        protected void nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(ngay.SelectedValue) == 29 && int.Parse(thang.SelectedValue) == 2)
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionstring);
                string sql = "select* from NamNhuan";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                nam.DataTextField = "Nam";
                nam.DataValueField = "Nam";
                nam.DataSource = reader;
                nam.DataBind();
                reader.Close();
                conn.Close();
            }
            else
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionstring);
                string sql = "select* from Nam";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                nam.DataTextField = "Nam";
                nam.DataValueField = "Nam";
                nam.DataSource = reader;
                nam.DataBind();
                reader.Close();
                conn.Close();
            }
        }

        protected void buttom_dangky_Click(object sender, EventArgs e)
        {
            //if (bname == false || bidcard == false || bphone == false || bemail == false || badd == false || bpass == false)
            //{
            //    e10.Text = "Vui lòng nhập thông tin cần thiết";
            //}
            //else 
            if (check.Checked == false)
                e10.Text = "Bạn chưa đồng ý điều khoản!";
            else
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionstring);
                string sql = "insert KhachHang(MaKH,HoTen,NgaySinh,GioiTinh,CMND,DiaChi,DT,Email,PassWord)" +
                    "values('',@ten,@ngay,@gt,@cmnd,@dc,@dt,@email,@pass)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ten", ten.Text);
                cmd.Parameters.AddWithValue("@ngay", thang.SelectedValue + "/" + ngay.SelectedValue + "/" + nam.SelectedValue);
                if (Male.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@gt", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gt", false);
                }
                cmd.Parameters.AddWithValue("@cmnd", cmnd.Text);
                cmd.Parameters.AddWithValue("@dc", diachi.Text);
                cmd.Parameters.AddWithValue("@dt", dt.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@pass", cofirm.Text);
               
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                e10.Text = "Dang ky thanh cong";
            }
        }

        protected void pass_TextChanged(object sender, EventArgs e)
        {
            if (pass.Text.Length < 6 || pass.Text.Length > 15)
            {
                e2.Text = "Pass phải dài từ 6-15 kí tự!";
                bpass = false;
            }
            else
            {
                bpass = true;
                e2.Text = "";
            }
            cofirm.Focus();
        }

        protected void cofirm_TextChanged(object sender, EventArgs e)
        {
            if (cofirm.Text != pass.Text)
                e3.Text = "Cofirmpass và pass phải giống nhau!";
            else e3.Text = "";
        }

        protected void ten_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(ten.Text, "[a-zA-Z]+$"))
            {
                bname = false;
                e4.Text = "Tên không được rỗng!";
            }
            else
            {
                bname = true;
                e4.Text = "";
            }
            cmnd.Focus();
        }

        protected void cmnd_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(cmnd.Text, @"^[0-9]+$"))
            {
                if (cmnd.Text.Length == 9)
                {
                    string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
                    SqlConnection conn = new SqlConnection(connectionstring);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from Admin where CMND=@idcard", conn);
                    cmd.Parameters.AddWithValue("@idcard", cmnd.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        bidcard = false;
                        e5.Text = "CMND này đã được đăng ký!";
                    }
                    else
                    {
                        reader.Close();
                        bidcard = true;
                        e5.Text ="";
                    }
                    conn.Close();
                }
                else
                {
                    bidcard = false;
                    e5.Text = "Bạn đã nhập sai!";
                }
            }
            else
            {
                bidcard = false;
                e5.Text = "Bạn đã nhập sai!";
            }
            diachi.Focus();
        }

        protected void diachi_TextChanged(object sender, EventArgs e)
        {
            if (diachi.Text.Length == 0)
            {
                e6.Text= "Not Null";
                badd = false;
            }
            else
            {
                badd = true;
                e6.Text = "";
            }
        }

        protected void dt_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(dt.Text, @"^[0-9]+$"))
            {
                if (dt.Text.Length >= 10 && dt.Text.Length <= 11)
                {
                    bphone = true;
                    e7.Text = "";
                }
                else
                {
                    bphone = false;
                    e7.Text = "Bạn đã nhập sai!";
                }
            }
            else
            {
                e7.Text = "Bạn đã nhập sai!";
                bphone = false;
            }
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
                {
                    e8.Text = "Email này đã được đăng ký";
                    bemail = false;
                }
                else
                {
                    e8.Text = "";
                    bemail = true;
                }
                conn.Close();
            }
            else
            {
                bemail = false;
                e8.Text = "Bạn đã nhập sai!";
            }
            pass.Focus();
        }
    }
}