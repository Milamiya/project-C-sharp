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
    public partial class WebForm20 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {}
            string maHD = Request.QueryString.Get("Order_ID");
            Label1.Text = maHD;
            load();
        }
        InfoDataContext db = new InfoDataContext();
        public void load()
        {
            
            var a = from s in db.tbl_OrderDetials
                    where s.Order_ID == Label1.Text
                    select s;
            GridView1.DataSource = a;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lbma = (Label)GridView1.Rows[e.RowIndex].FindControl("lbMaSP");
            tbl_Product p = db.tbl_Products.SingleOrDefault(c => c.Product_ID == int.Parse( lbma.Text));
            var a = from s in db.tbl_OrderDetials
                    where s.Order_ID == Label1.Text
                    select new { s.Amount};
            foreach (var item in a)
	        {
                p.Amount = p.Amount - int.Parse(item.Amount.ToString());
	        }
            tbl_OrderDetial od = db.tbl_OrderDetials.SingleOrDefault(c => c.Product_ID == int.Parse(lbma.Text));
            od.State = "Đã xử lý";
            load();
            db.SubmitChanges();
        }
    }
}
