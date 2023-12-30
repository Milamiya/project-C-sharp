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

namespace TestOnline.hy.vn.manager
{
    public partial class HomeManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["loginManager"].ToString() == "1")
            {
                this.Title = "Trang quản trị thi trắc nghiệm trực tuyến";
            }
            else
            {
                Response.Redirect("LoginManager.aspx");
            }
        }
    }
}
