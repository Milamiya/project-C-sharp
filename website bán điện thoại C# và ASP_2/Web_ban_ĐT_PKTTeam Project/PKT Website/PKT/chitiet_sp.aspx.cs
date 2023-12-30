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
    public partial class chitie_sp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            load(Request.QueryString["id"].ToString());
        }

        protected void load(string masp)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("select SanPham.*,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where MaSP=@masp", conn);
            cmd.Parameters.AddWithValue("@masp", masp);
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            Chitiet.DataSource = dt.DefaultView;
            Chitiet.DataBind();
            cmd.CommandText = "select SLTon from SanPham where MaSP=@masp";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@masp", masp);
            conn.Open();
            int slton = (int)cmd.ExecuteScalar();
            conn.Close();
            if (slton != 0)
            {
                foreach (RepeaterItem item in Chitiet.Items)
                {
                    Label lb = item.FindControl("slt") as Label;
                    lb.Text = "Còn hàng";
                    foreach (RepeaterItem item1 in Chitiet.Items)
                    {
                        HyperLink l = item.FindControl("link") as HyperLink;
                        l.Visible = true;
                        l.NavigateUrl="giohang.aspx?masp="+ masp;
                    }
                }
            }
            else 
            {
                foreach (RepeaterItem item in Chitiet.Items)
                {
                    Label lb = item.FindControl("slt") as Label;
                    lb.Text = "Hết hàng";
                    foreach (RepeaterItem item1 in Chitiet.Items)
                    {
                        HyperLink l = item.FindControl("link") as HyperLink;
                        l.Visible = false;
                    }
                }
            }
        }

        protected void Chitiet_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}