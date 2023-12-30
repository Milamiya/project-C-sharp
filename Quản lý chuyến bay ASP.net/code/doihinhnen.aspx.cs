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

public partial class doihinhnen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        FileUpload1.PostedFile.SaveAs(Server.MapPath("hinh anh\\" + "2 copy.jpg"));
        Response.Redirect("trangchu.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        FileUpload2.PostedFile.SaveAs(Server.MapPath("hinh anh\\" + "banner2 copy.png"));
        Response.Redirect("trangchu.aspx");
    }
}
