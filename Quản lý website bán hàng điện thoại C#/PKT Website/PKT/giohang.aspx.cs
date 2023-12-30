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
    public partial class giohang3 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();
                //Response.Write(Request.QueryString["masp"].ToString());
                //Response.Write(Session["idshop"].ToString());
            }
        }

        protected void load()
        {   
            string makh;
            if (Session["idcus"] == null)
            {
                makh = "KH00000";
            }
            else makh = Session["idcus"].ToString();

            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HoaDonBan", conn);
            cmd.ExecuteNonQuery();

            if (Request.QueryString["masp"] != null)
            {
                string masp = Request.QueryString["masp"].ToString();
                if (Session["idshop"] != null)
                {
                    string mahd2 = Session["idshop"].ToString();
                    cmd.CommandText = "select * from ChiTietHoaDonBan where MaSP=@masp and MaHDBan=@mahd2";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@masp", masp);
                    cmd.Parameters.AddWithValue("@mahd2", mahd2);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        cmd.CommandText = "update ChiTietHoaDonBan set SLBan=SLBan+1 where MaSP=@masp and MaHDBan=@mahd2";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@masp", masp);
                        cmd.Parameters.AddWithValue("@mahd2", mahd2);
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                        reader.Close();
                        cmd.CommandText = "insert ChiTietHoaDonBan(MaHDBan,MaSP,SLBan,GiaBan) values(@mahd2,@masp,1,(select GiaBan from SanPham where MaSP=@masp))";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@mahd2", mahd2);
                        cmd.Parameters.AddWithValue("@masp", masp);
                        cmd.ExecuteNonQuery();
                    }
                }

                else
                {
                    cmd.CommandText = "insert HoaDonBan(MaHDBan,MaKH,TinhTrang) values('',@makh,N'Chưa xác nhận')";
                    cmd.Parameters.AddWithValue("@makh", makh);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "select top(1) MaHDBan from HoaDonBan order by MaHDBan desc";
                    string mahd = (string)cmd.ExecuteScalar();

                    cmd.CommandText = "insert ChiTietHoaDonBan(MaHDBan,MaSP,SLBan,GiaBan) values(@mahd,@masp,1,(select GiaBan from SanPham where MaSP=@masp))";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@mahd", mahd);
                    cmd.Parameters.AddWithValue("@masp", masp);
                    cmd.ExecuteNonQuery();

                    Session["idshop"] = mahd;
                }
            }

            if (Session["idshop"] != null)
            {
                string mahd1 = Session["idshop"].ToString();
                cmd.CommandText = "select *,ChiTietHoaDonBan.GiaBan*SLBan as ThanhTien from ChiTietHoaDonBan join SanPham on ChiTietHoaDonBan.MaSP=SanPham.MaSP where MaHDBan=@mahd";
                cmd.Parameters.Clear();
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
                conn.Close();
            }
            else tong.Text = "0 VNĐ";
        }

        protected void update_Click(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();

            string mahd = Session["idshop"].ToString();

            string[] sl = new string[(int)Session["count"]];
            int i = 0;
            foreach (RepeaterItem item in data.Items)
            {
                TextBox txt = item.FindControl("count") as TextBox;
                sl[i] = txt.Text;
                i++;
            }
            i = 0;
            bool[] xoa = new bool[(int)Session["count"]];
            foreach (RepeaterItem item in data.Items)
            {
                CheckBox cb = item.FindControl("delete") as CheckBox;
                if (cb.Checked == true)
                {
                    xoa[i] = true;
                }
                else
                    xoa[i] = false;
                i++;
            }

            int j = 0;
            DataTable dt = Session["data"] as DataTable;
            foreach (DataRow r in dt.Rows)
            {
                if (xoa[j] == true)
                {
                    SqlCommand cmd3 = new SqlCommand("delete ChiTietHoaDonBan where MaSP=@masp", conn);
                    cmd3.Parameters.AddWithValue("@masp", r["MaSP"]);
                    cmd3.ExecuteNonQuery();               
                }
                SqlCommand cmd = new SqlCommand("select SLTon from SanPham where MaSP=@masp", conn);
                cmd.Parameters.AddWithValue("@masp", r["MaSP"]);
                int tt = (int)cmd.ExecuteScalar();
                if (int.Parse(sl[j]) > tt)
                    info.Text = "Hiện tại chúng tôi không đủ hàng cung cấp theo số lượng yêu cầu của bạn. Vui lòng liên hệ để biết thêm chi tiết";
                else
                {
                    cmd.CommandText = "update ChiTietHoaDonBan set SLBan=@sl where MaSP=@masp";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@sl", sl[j]);
                    cmd.Parameters.AddWithValue("@masp", r["MaSP"]);
                    cmd.ExecuteNonQuery();
                    j++;
                }
            }


            SqlCommand cmd2 = new SqlCommand("select *,ChiTietHoaDonBan.GiaBan*SLBan as ThanhTien from ChiTietHoaDonBan join SanPham on ChiTietHoaDonBan.MaSP=SanPham.MaSP where MaHDBan=@mahd", conn);
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@mahd", mahd);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            dt = new DataTable();
            adapter.Fill(dt);
            data.DataSource = dt.DefaultView;
            data.DataBind();
            Session["count"] = dt.Rows.Count;
            Session["Data"] = dt;
            cmd2.CommandText = "select (CASE WHEN sum(ChiTietHoaDonBan.GiaBan*SLBan)>0 THEN sum(ChiTietHoaDonBan.GiaBan*SLBan) ELSE 0 END) as Tong from ChiTietHoaDonBan join HoaDonBan on ChiTietHoaDonBan.MaHDBan=HoaDonBan.MaHDBan where HoaDonBan.MaHDBan=@mahd";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@mahd", mahd);
            int t;
            t = (int)cmd2.ExecuteScalar();
            tong.Text = String.Format("{0:0,000 VNĐ}", t);
            conn.Close();
        }

        protected void buttom_order_Click(object sender, EventArgs e)
        {
            Response.Redirect("dathang.aspx");
        }
    }
}
