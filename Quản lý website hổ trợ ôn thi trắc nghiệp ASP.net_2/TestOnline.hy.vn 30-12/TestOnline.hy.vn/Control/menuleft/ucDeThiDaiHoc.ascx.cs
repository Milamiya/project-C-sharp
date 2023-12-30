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

namespace TestOnline.hy.vn.Control.menuleft
{
    public partial class ucDeThiDaiHoc : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TestOnlineDataContext db = new TestOnlineDataContext();
                var cl = (from c in db.tblThreads
                          orderby c.CreateDate descending
                          where c.Status == 4
                          select new { c.ThreadsID, c.TheadName }).Skip(0).Take(4);
                rpt2.DataSource = cl;
                rpt2.DataBind();
            }
        }
    }
}