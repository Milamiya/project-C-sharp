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

namespace DoAn4.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Literal1.Text = "Xin chào: " + Session["Username"].ToString();
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Session["Username"] = null;
            Response.Redirect("~/Trangchu.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
        }
    }
}
