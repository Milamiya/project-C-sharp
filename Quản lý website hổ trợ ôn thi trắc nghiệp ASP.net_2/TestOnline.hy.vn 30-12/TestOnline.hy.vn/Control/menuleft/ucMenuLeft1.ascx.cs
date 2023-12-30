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
    public partial class ucMenuLeft1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            if (!IsPostBack)
            {
                var cl = (from c in db.tblThreads
                         orderby c.HitCount descending
                         select new { c.ThreadsID, c.TheadName }).Skip(0).Take(10);
                rptListThread.DataSource = cl;
                rptListThread.DataBind();
            }
        }
    }
}