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
    public partial class ucQuyChe : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            if (!IsPostBack)
            {
                var cl = (from c in db.tblRegulations
                          orderby c.CreateDate descending
                         select new { c.Titile,c.RegulationID,c.Url}).Skip(0).Take(4);
                rpt1.DataSource = cl;
                rpt1.DataBind();
            }
        }
    }
}