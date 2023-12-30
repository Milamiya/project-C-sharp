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

public partial class guiykien : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        AccessDataSource AccessDataSource1 = new AccessDataSource();
        AccessDataSource1.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        AccessDataSource1.InsertCommandType = SqlDataSourceCommandType.Text;
        AccessDataSource1.InsertCommand = "Insert into ykien values (@macb)";
        AccessDataSource1.InsertParameters.Add("macb", TypeCode.String, TextBox1.Text);
        AccessDataSource1.Insert();
        Response.Redirect("guiykienthanhcong.aspx");
    }
}
