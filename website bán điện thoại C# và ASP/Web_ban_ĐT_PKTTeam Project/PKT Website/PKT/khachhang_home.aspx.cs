using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace PKT
{
    public partial class khachhang_home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
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
                ngsinh.Text = reader["NgaySinh"].ToString();
                gt.Text = reader["GioiTinh"].ToString();
                cmnd.Text = reader["CMND"].ToString();
                dc.Text = reader["DiaChi"].ToString();
                sdt.Text = reader["DT"].ToString();
                email.Text = reader["Email"].ToString();
            }
            reader.Close();
            conn.Close();
        }
    }
}