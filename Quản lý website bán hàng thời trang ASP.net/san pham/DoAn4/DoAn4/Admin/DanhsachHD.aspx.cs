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

namespace DoAn4.Admin
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadHD();
        }
        InfoDataContext db = new InfoDataContext();
        public void LoadHD()
        {
            var a = from s in db.tbl_Orders
                    select new { s.Order_ID, s.Date, s.Name_Received, s.Name_Pay, s.SumMoney, s.State };
            GridView1.DataSource = a;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lbMa = (Label)GridView1.Rows[e.RowIndex].FindControl("Label1");
            //tbl_Order o = db.tbl_Orders.SingleOrDefault(c => c.Order_ID == lbMa.Text);
            
            //db.SubmitChanges();
            //LoadHD();
            Response.Redirect("ThongtinHD.aspx?Order_ID=" + lbMa.Text + "");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
    }
}
