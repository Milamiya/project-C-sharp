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

namespace DoAn4
{
    public partial class WebForm1 : System.Web.UI.Page
    { 
      
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "THỜI TRANG THU PHƯƠNG";
            if (!IsPostBack)
            {
                string productID = Request.QueryString["Product_ID"];
                InfoDataContext db = new InfoDataContext();
                var tmp = (from a in db.tbl_Products
                          from b in db.tbl_Imports
                          from c in db.tbl_ImportDetails
                          orderby b.Date descending
                          where b.Import_ID==c.Import_ID&&a.Product_ID==c.Product_ID
                          select a).Take(3);
                sanpham.DataSource = tmp;
                sanpham.DataBind();
            }
        }
    }
}
