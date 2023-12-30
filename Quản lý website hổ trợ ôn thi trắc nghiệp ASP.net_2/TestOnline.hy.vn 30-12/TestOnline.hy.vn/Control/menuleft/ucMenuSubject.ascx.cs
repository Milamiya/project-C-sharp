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
    public partial class ucMenuSubject : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            if (!IsPostBack)
            {
                var cl = from c in db.tblSubjects
                         select c;
                rpt1.DataSource = cl;
                rpt1.DataBind();
                rpt2.DataSource = cl;
                rpt2.DataBind();
                rpt3.DataSource = cl;
                rpt3.DataBind();
            }
         }
    }
}