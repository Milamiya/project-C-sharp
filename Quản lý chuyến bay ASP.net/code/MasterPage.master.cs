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

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        AccessDataSource truycap = new AccessDataSource();
        truycap.DataFile = Server.MapPath(".") + "//app_data/db1.mdb";
        truycap.SelectCommandType = SqlDataSourceCommandType.Text;
        truycap.SelectCommand = "select count from demtruycap";
        luottruycap.DataSource = truycap;
        luottruycap.DataBind();
        
        
        
        
        Label2.Text = Session["tendn"].ToString();
        Label3.Text =  Application["skv"].ToString();
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session["tendn"] = " ";
        Response.Redirect("trangchu.aspx");
    }
}
