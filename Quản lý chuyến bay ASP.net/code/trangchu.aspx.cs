using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AccessDataSource vd = new AccessDataSource();
        vd.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        vd.SelectCommandType = SqlDataSourceCommandType.Text;
        vd.SelectCommand = "Select * from tinmoi";
        GridView1.DataSource = vd;
        GridView1.DataBind();
    }
    protected void Gridview1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        //phan trang + page index changing ben trang aspx
        GridView1.PageIndex = e.NewPageIndex;
        AccessDataSource vd = new AccessDataSource();
        vd.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        vd.SelectCommandType = SqlDataSourceCommandType.Text;
        vd.SelectCommand = "Select * from tinmoi";
        GridView1.DataSource = vd;
        GridView1.DataBind();
    }

}
