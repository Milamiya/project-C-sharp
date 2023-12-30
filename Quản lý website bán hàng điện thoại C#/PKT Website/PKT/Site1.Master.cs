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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                load_ManuID();
            }
        }

        protected void load_ManuID()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            string sql = "select* from NhaSanXuat order by MaSX";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            ManuID.DataTextField = "TenSX";
            ManuID.DataValueField = "MaSX";
            ManuID.DataSource = reader;
            ManuID.DataBind();
            reader.Close();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select* from NhaSanXuat where MaSX<>'SX00' order by MaSX", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            listsx.DataSource = dt.DefaultView;
            listsx.DataBind();
            conn.Close();
            //search_click.NavigateUrl = "sanpham.aspx?key=" + key.Text;
            if (Session["namecus"] != null)
            {
                name.Text = Session["namecus"].ToString().Split(' ')[Session["namecus"].ToString().Split(' ').Length-1];
                home.NavigateUrl = "khachhang_home.aspx";
                exit.NavigateUrl = "index.aspx?action=exit";
                login.Visible = false;
            }
            else
            {
                home.Visible = false;
                exit.Visible = false;
                login.Visible = true;
                login.NavigateUrl = "dangky.aspx";
            }

            if (Request.QueryString["action"] !=null)
            {
                Session.Remove("namecus");
                Session.Remove("idcus");
                Response.Redirect("index.aspx");
            }

            // Search
            search_click.NavigateUrl = "sanpham.aspx?manu=" + ManuID.SelectedValue + "&pricef=" + PriceFrom.SelectedValue + "&pricet=" + PriceTo.SelectedValue + "&key=" + key.Text;
        }

        protected void key_TextChanged(object sender, EventArgs e)
        {
            search_click.NavigateUrl = "sanpham.aspx?manu=" + ManuID.SelectedValue + "&pricef=" + PriceFrom.SelectedValue + "&pricet=" + PriceTo.SelectedValue +"&key=" + key.Text;
        }

        protected void ManuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_click.NavigateUrl = "sanpham.aspx?manu=" + ManuID.SelectedValue + "&pricef=" + PriceFrom.SelectedValue + "&pricet=" + PriceTo.SelectedValue + "&key=" + key.Text;
        }

        protected void FriceFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_click.NavigateUrl = "sanpham.aspx?manu=" + ManuID.SelectedValue + "&pricef=" + PriceFrom.SelectedValue + "&pricet=" + PriceTo.SelectedValue + "&key=" + key.Text;
        }

        protected void PriceTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_click.NavigateUrl = "sanpham.aspx?manu=" + ManuID.SelectedValue + "&pricef=" + PriceFrom.SelectedValue + "&pricet=" + PriceTo.SelectedValue + "&key=" + key.Text;
        }
    }
}