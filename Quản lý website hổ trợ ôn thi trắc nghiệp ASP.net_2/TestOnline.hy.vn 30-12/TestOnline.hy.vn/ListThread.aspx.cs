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

namespace TestOnline.hy.vn
{
    public partial class ListThread : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["login"].ToString()=="0")
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                string status = Request.QueryString["Status"];
                if (status == "1")
                {
                    this.Title = "Ôn luyện";
                }
                if (status == "2")
                {
                    this.Title = "Thi trực tuyến";
                }
                if (status == "3")
                {
                    this.Title = "Thi đề đã thi";
                }
            }
        }
    }
}
