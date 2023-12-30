using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace PKT
{
    public partial class timkiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
            conn.Close();
        }

        protected void key_TextChanged(object sender, EventArgs e)
        {
            search_click1.NavigateUrl = "sanpham.aspx?key=" + key.Text;
        }

        protected void ManuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_click2.NavigateUrl = "sanpham.aspx?manu=" + ManuID.SelectedValue + "&pricef=" + PriceFrom.SelectedValue + "&pricet=" + PriceTo.SelectedValue;
        }

        protected void FriceFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_click2.NavigateUrl = "sanpham.aspx?manu=" + ManuID.SelectedValue + "&pricef=" + PriceFrom.SelectedValue + "&pricet=" + PriceTo.SelectedValue;
        }

        protected void PriceTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_click2.NavigateUrl = "sanpham.aspx?manu=" + ManuID.SelectedValue + "&pricef=" + PriceFrom.SelectedValue + "&pricet=" + PriceTo.SelectedValue;
        }

        protected void ct1_CheckedChanged(object sender, EventArgs e)
        {
            search_click3.NavigateUrl = "sanpham.aspx?ct1=" + ct1.Checked + "&ct3=" + ct3.Checked + "&ct21=" + ct21.Checked + "&ct6=" + ct6.Checked + "&ct19=" + ct19.Checked + "&ct17=" + ct17.Checked + "&ct20=" + ct20.Checked + "&ct5=" + ct5.Checked + "&ct18=" + ct18.Checked;
        }

        protected void ct3_CheckedChanged(object sender, EventArgs e)
        {
            search_click3.NavigateUrl = "sanpham.aspx?ct1=" + ct1.Checked + "&ct3=" + ct3.Checked + "&ct21=" + ct21.Checked + "&ct6=" + ct6.Checked + "&ct19=" + ct19.Checked + "&ct17=" + ct17.Checked + "&ct20=" + ct20.Checked + "&ct5=" + ct5.Checked + "&ct18=" + ct18.Checked;
        }

        protected void ct21_CheckedChanged(object sender, EventArgs e)
        {
            search_click3.NavigateUrl = "sanpham.aspx?ct1=" + ct1.Checked + "&ct3=" + ct3.Checked + "&ct21=" + ct21.Checked + "&ct6=" + ct6.Checked + "&ct19=" + ct19.Checked + "&ct17=" + ct17.Checked + "&ct20=" + ct20.Checked + "&ct5=" + ct5.Checked + "&ct18=" + ct18.Checked;
        }

        protected void ct6_CheckedChanged(object sender, EventArgs e)
        {
            search_click3.NavigateUrl = "sanpham.aspx?ct1=" + ct1.Checked + "&ct3=" + ct3.Checked + "&ct21=" + ct21.Checked + "&ct6=" + ct6.Checked + "&ct19=" + ct19.Checked + "&ct17=" + ct17.Checked + "&ct20=" + ct20.Checked + "&ct5=" + ct5.Checked + "&ct18=" + ct18.Checked;
        }

        protected void ct19_CheckedChanged(object sender, EventArgs e)
        {
            search_click3.NavigateUrl = "sanpham.aspx?ct1=" + ct1.Checked + "&ct3=" + ct3.Checked + "&ct21=" + ct21.Checked + "&ct6=" + ct6.Checked + "&ct19=" + ct19.Checked + "&ct17=" + ct17.Checked + "&ct20=" + ct20.Checked + "&ct5=" + ct5.Checked + "&ct18=" + ct18.Checked;
        }

        protected void ct17_CheckedChanged(object sender, EventArgs e)
        {
            search_click3.NavigateUrl = "sanpham.aspx?ct1=" + ct1.Checked + "&ct3=" + ct3.Checked + "&ct21=" + ct21.Checked + "&ct6=" + ct6.Checked + "&ct19=" + ct19.Checked + "&ct17=" + ct17.Checked + "&ct20=" + ct20.Checked + "&ct5=" + ct5.Checked + "&ct18=" + ct18.Checked;
        }

        protected void ct20_CheckedChanged(object sender, EventArgs e)
        {
            search_click3.NavigateUrl = "sanpham.aspx?ct1=" + ct1.Checked + "&ct3=" + ct3.Checked + "&ct21=" + ct21.Checked + "&ct6=" + ct6.Checked + "&ct19=" + ct19.Checked + "&ct17=" + ct17.Checked + "&ct20=" + ct20.Checked + "&ct5=" + ct5.Checked + "&ct18=" + ct18.Checked;
        }

        protected void ct5_CheckedChanged(object sender, EventArgs e)
        {
            search_click3.NavigateUrl = "sanpham.aspx?ct1=" + ct1.Checked + "&ct3=" + ct3.Checked + "&ct21=" + ct21.Checked + "&ct6=" + ct6.Checked + "&ct19=" + ct19.Checked + "&ct17=" + ct17.Checked + "&ct20=" + ct20.Checked + "&ct5=" + ct5.Checked + "&ct18=" + ct18.Checked;
        }

        protected void ct18_CheckedChanged(object sender, EventArgs e)
        {
            search_click3.NavigateUrl = "sanpham.aspx?ct1=" + ct1.Checked + "&ct3=" + ct3.Checked + "&ct21=" + ct21.Checked + "&ct6=" + ct6.Checked + "&ct19=" + ct19.Checked + "&ct17=" + ct17.Checked + "&ct20=" + ct20.Checked + "&ct5=" + ct5.Checked + "&ct18=" + ct18.Checked;
        }

    }
}