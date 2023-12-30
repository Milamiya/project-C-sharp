using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace PKT
{
    public partial class khachhang_thaydoithongtin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Ngay_Load();load(); 
            }
        }

        protected void load()
        {
            
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            string sql = "select  (CASE WHEN GioiTinh='1' THEN 'Nam' ELSE N'Nữ' END) as GioiTinh,CONVERT(varchar, NgaySinh, 103) as NgaySinh,* from Khachhang where MaKH=@makh";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@makh", Session["idcus"].ToString());
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ten.Text = reader["HoTen"].ToString();
                string ngsinh = reader["NgaySinh"].ToString();
                ngay.Text = ngsinh.Split('/')[0];
                thang.Text = ngsinh.Split('/')[1];
                nam.Text = ngsinh.Split('/')[2];
                if (reader["GioiTinh"].ToString() == "Nam")
                    gtnam.Checked = true;
                else
                    nu.Checked = true;
                cmnd.Text = reader["CMND"].ToString();
                dc.Text = reader["DiaChi"].ToString();
                sdt.Text = reader["DT"].ToString();
                email.Text = reader["Email"].ToString();
            }
            reader.Close();
            conn.Close();
        }

        protected void sumit_Click(object sender, EventArgs e)
        {
            if (ten.Text.Length == 0 || cmnd.Text.Length == 0 || dc.Text.Length == 0 || sdt.Text.Length == 0 || email.Text.Length == 0)
            {
                e10.Text = "Thay đổi không thành công! Hãy kiểm tra lại các vùng dữ liệu không được rỗng!";
            }
            else if (e5.Text.Length != 0 || e5.Text.Length != 0 || e5.Text.Length != 0 || e5.Text.Length != 0 || e5.Text.Length != 0)
            {
                e10.Text = "Thay đổi không thành công! Hãy kiểm tra lại các thông tin!";
            }
            else
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionstring);
                string sql = "update KhachHang set HoTen=@ten,NgaySinh=@ngaysinh,GioiTinh=@gt,CMND=@cmnd,DiaChi=@dc,DT=@dt,Email=@email where MaKH=@makh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@makh", Session["idcus"].ToString());
                cmd.Parameters.AddWithValue("@ten", ten.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", thang.Text + "/" + ngay.Text + "/" + nam.Text);
                if (gtnam.Checked == true)
                    cmd.Parameters.AddWithValue("@gt", true);
                else
                    cmd.Parameters.AddWithValue("@gt", false);
                cmd.Parameters.AddWithValue("@cmnd", cmnd.Text);
                cmd.Parameters.AddWithValue("@dc", dc.Text);
                cmd.Parameters.AddWithValue("@dt", sdt.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                e10.Text = "Thay đổi thành công!";
            }
        }

        protected void sumit2_Click(object sender, EventArgs e)
        {
            if (pass.Text.Length == 0 || passnew.Text.Length == 0 || cofirm.Text.Length == 0)
                e4.Text = "Mời nhập mật khẩu mới!";
            else if (e1.Text.Length != 0 || e2.Text.Length != 0 || e3.Text.Length != 0)
                e4.Text = "Thay đổi mật khẩu không thành công! Hãy kiểm tra lại!";
            else
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionstring);
                string sql = "update KhachHang set PassWord=@pass where MaKH=@makh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@makh", Session["idcus"].ToString());
                cmd.Parameters.AddWithValue("@pass", cofirm.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                e4.Text = "Thay đổi mật khẩu thành công!";
            }
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
            cmd.CommandText = "select * from Thang";
            conn.Open();
            reader = cmd.ExecuteReader();
            thang.DataTextField = "Thang";
            thang.DataValueField = "Thang";
            thang.DataSource = reader;
            thang.DataBind();
            reader.Close();
            conn.Close();
            cmd.CommandText = "select * from Nam";
            conn.Open();
            reader = cmd.ExecuteReader();
            nam.DataTextField = "Nam";
            nam.DataValueField = "Nam";
            nam.DataSource = reader;
            nam.DataBind();
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

        protected void pass_TextChanged(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            string sql = "select  * from Khachhang where MaKH=@makh and PassWord=@pass";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@makh", Session["idcus"].ToString());
            cmd.Parameters.AddWithValue("@pass", pass.Text);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                e1.Text = "";
            }
            else 
            {
                reader.Close();
                e1.Text = "Sai mật khẩu!";
            }
            conn.Close();
        }

        protected void passnew_TextChanged(object sender, EventArgs e)
        {
            if (passnew.Text.Length < 6 || passnew.Text.Length > 15)
                e2.Text = "Pass phải dài từ 6-15 kí tự!";
            else e2.Text = "";
            cofirm.Focus();
        }

        protected void cofirm_TextChanged(object sender, EventArgs e)
        {
            if (cofirm.Text != pass.Text)
                e3.Text = "Cofirmpass và pass phải giống nhau!";
            else e3.Text = "";
            sumit2.Focus();
        }

        protected void email_TextChanged(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            string sql = "select  * from Khachhang where MaKH<>@makh and Email=@email";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@makh", Session["idcus"].ToString());
            cmd.Parameters.AddWithValue("@email", email.Text);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                e9.Text = "Email này đã được người khác đăng kí";
            }
            reader.Close();
            conn.Close();
        }

        protected void cmnd_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(cmnd.Text, @"^[0-9]+$"))
            {
                if (cmnd.Text.Length == 9)
                    e6.Text = "";
                else
                    e6.Text = "Bạn đã nhập sai!";
            }
            else
                e6.Text = "Bạn đã nhập sai!";

            dc.Focus();
        }

        protected void ten_TextChanged(object sender, EventArgs e)
        {
            if (ten.Text.Length == 0)
                e5.Text = "Tên không được rỗng!";
            else e5.Text = "";
            cmnd.Focus();
        }

        protected void dc_TextChanged(object sender, EventArgs e)
        {
            sdt.Focus();
        }

        protected void sdt_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(sdt.Text, @"^[0-9]+$"))
            {
                if (sdt.Text.Length >= 10 && sdt.Text.Length <= 11)
                    e8.Text = "";
                else
                    e8.Text = "Bạn đã nhập sai!";
            }
            else
                e8.Text = "Bạn đã nhập sai!";

            email.Focus();
        }



        
    }
}