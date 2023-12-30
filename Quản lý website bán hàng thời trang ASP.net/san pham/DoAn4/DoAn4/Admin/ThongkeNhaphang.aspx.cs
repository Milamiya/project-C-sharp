using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace DoAn4.Admin
{
    public partial class WebForm16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null) { }
            else
                Response.Redirect("Login.aspx");
        }
        InfoDataContext db = new InfoDataContext();
        void tinh()
        {
            double tongtiennhap = 0;
            foreach (GridViewRow gr in GridView1.Rows)
            {
                tongtiennhap += double.Parse(gr.Cells[3].Text);
            }
            Label1.Text = tongtiennhap.ToString("###,###") + "  " + "VNĐ";
        }

        protected void btnThongke_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.Items[0].Selected)
            {
                var a = db.TKHDNTheoNgay(DateTime.Parse(txtNgay.Text));
                GridView1.DataSource = a;
                GridView1.DataBind();
                tinh();
            }
            if (RadioButtonList1.Items[1].Selected)
            {
                var a = db.TKHDNTheoTG(DateTime.Parse(txtTungay.Text),DateTime.Parse(txtDenngay.Text));
                GridView1.DataSource = a;
                GridView1.DataBind();
                tinh();
            }
            if (RadioButtonList1.Items[2].Selected)
            {
                var a = db.TKHDNTheoNam(int.Parse(txtTheonam.Text));
                GridView1.DataSource = a;
                GridView1.DataBind();
                tinh();
            }
        }

        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }
    }
}
