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

public partial class Default2 : System.Web.UI.Page
{
    WedMayTinhDataContext we = new WedMayTinhDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        //var m = from p in we.linkanhs select p;
        //dtv1.DataSource = m;
        //dtv1.DataBind();
     
    }
}
