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
    public partial class ucMenuLeft : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            if (!IsPostBack)
            {
                var cl = (from c in db.tblThreads
                          orderby c.DateTest descending
                         where c.Status == 3
                         select new { c.ThreadsID }).Skip(0).Take(1);
                foreach (var item in cl)
                {
                    rptListName.DataSource = (from c in db.tblResultsIDs
                                              orderby c.Score descending
                                             where c.ThreadsID == item.ThreadsID
                                             select new { c.tblStudent.StudentName,c.Score }).Skip(0).Take(15);
                    rptListName.DataBind();
                }
            }
        }
    }
}