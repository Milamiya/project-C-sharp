using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace TestOnline.hy.vn.Control
{
    public partial class Banner : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TestOnlineDataContext db = new TestOnlineDataContext();
                rptMenu2.DataSource = (from c in db.Categories
                                       select c).Skip(0).OrderBy(c => c.CategoryOrder);
                rptMenu2.DataBind();

            }
        }
    }
}