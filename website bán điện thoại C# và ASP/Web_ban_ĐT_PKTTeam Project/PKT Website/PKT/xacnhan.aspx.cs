using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PKT
{
    public partial class xaxnhan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();
            }
        }

        protected void load()
        {

            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string mahd1 = Session["idshop"].ToString();
            SqlCommand cmd = new SqlCommand("select *,ChiTietHoaDonBan.GiaBan*SLBan as ThanhTien from ChiTietHoaDonBan join SanPham on ChiTietHoaDonBan.MaSP=SanPham.MaSP where MaHDBan=@mahd", conn);
            cmd.Parameters.AddWithValue("@mahd", mahd1);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            data.DataSource = dt.DefaultView;
            data.DataBind();
            Session["count"] = dt.Rows.Count;
            Session["Data"] = dt;
            cmd.CommandText = "select (CASE WHEN sum(ChiTietHoaDonBan.GiaBan*SLBan)>0 THEN sum(ChiTietHoaDonBan.GiaBan*SLBan) ELSE 0 END) as Tong from ChiTietHoaDonBan join HoaDonBan on ChiTietHoaDonBan.MaHDBan=HoaDonBan.MaHDBan where HoaDonBan.MaHDBan=@mahd";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@mahd", mahd1);
            int t;
            t = (int)cmd.ExecuteScalar();
            tong.Text = String.Format("{0:0,000 VNĐ}", t);

            cmd.CommandText = ("select KhachHang.* from HoaDonBan join KhachHang on HoaDonBan.MaKH=KhachHang.MaKH where MaHDBan=@mahd");
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@mahd", mahd1);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read()) 
            {
                ten.Text = (string)r["HoTen"];
                cmnd.Text = r["CMND"].ToString();
                dc.Text = (string)r["DiaChi"];
                sdt.Text = r["DT"].ToString();
                email.Text = (string)r["Email"];
            }
            conn.Close();

        }

        protected void edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("giohang.aspx");
        }

        protected void xacnhan_Click(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string mahd = Session["idshop"].ToString();
            SqlCommand cmd = new SqlCommand("update HoaDonBan set TinhTrang=N'Xác nhận đặt hàng' where MaHDBan=@mahd", conn);
            cmd.Parameters.AddWithValue("@mahd", mahd);
            cmd.ExecuteNonQuery();
            // Cập nhật kho hàng
            SqlDataAdapter adapter = new SqlDataAdapter("select * from ChiTietHoaDonBan where MaHDBan='" + mahd + "'", conn);
            DataTable dtsp = new DataTable();
            adapter.Fill(dtsp);
            adapter.Dispose();
            foreach (DataRow row in dtsp.Rows)
            {
                SqlCommand cmd2 = new SqlCommand("update SanPham set SLTon=SLTon-" + (int)row["SLBan"] + "where MaSP='" + (string)row["MaSP"] + "'", conn);
                cmd2.ExecuteNonQuery();
            }
            conn.Close();
            Session.Remove("idshop");
            Response.Redirect("xacnhan_thanhcong.aspx");
        }
    }
}