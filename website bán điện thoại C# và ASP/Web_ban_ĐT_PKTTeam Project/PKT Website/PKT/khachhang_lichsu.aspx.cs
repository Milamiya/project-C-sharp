using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PKT
{
    public partial class khachhang_lichsu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }

        protected void load()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            string sql = "select * from HoaDonBan where MaKH=@idcus order by NgayBan desc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idcus", Session["idcus"].ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            data.DataSource = dt.DefaultView;
            data.DataBind();
            int count = dt.Rows.Count;
            string[] mahd= new string[count];
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                mahd[i] = (string)row["MaHDBan"];
                i++;
            }

            i = 0;
            foreach (RepeaterItem item in data.Items)
            {
                Repeater rep = item.FindControl("detail") as Repeater;
                cmd.CommandText = "select *,ChiTietHoaDonBan.GiaBan*SLBan as ThanhTien from ChiTietHoaDonBan join SanPham on ChiTietHoaDonBan.MaSP=SanPham.MaSP where MaHDBan=@mahd";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mahd", mahd[i]);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                rep.DataSource = dt1.DefaultView;
                rep.DataBind();
                i++;
            }

        }
    }
}