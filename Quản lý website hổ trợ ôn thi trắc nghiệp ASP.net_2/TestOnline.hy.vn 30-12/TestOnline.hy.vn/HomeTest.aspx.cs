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
    public partial class HomeTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string thread=Request.QueryString["threadid"];
            TestOnlineDataContext db=new TestOnlineDataContext();
            tblThread tbl=db.tblThreads.SingleOrDefault(c=>c.ThreadsID.Trim()==thread.Trim());
            if(tbl.Status==1)
            {  this.Title="Ôn luyện";}
             if(tbl.Status==2)
            { this.Title="Thi trực tuyến";

             }
             if(tbl.Status==3)
             { this.Title = "Luyện đề đã thi"; }
        }
    }
}
