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
    public partial class ucListThread_DaThi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string subjectID = Request.QueryString["SubjectID"];
            TestOnlineDataContext db = new TestOnlineDataContext();
            if (!IsPostBack)
            {
                rptList.DataSource = from c in db.tblThreads
                                     where c.SubjectID==subjectID
                                     orderby c.DateTest descending
                                     where c.Status == 3
                                     select c;
                rptList.DataBind();
                if (rptList != null)
                {
                    lblThongBao.Text = "";
                }
                else
                {
                    lblThongBao.Text = "Chưa có cuộc thi nào";
                    lblThongBao.Visible = true;
                }

            }
        }
    }
}