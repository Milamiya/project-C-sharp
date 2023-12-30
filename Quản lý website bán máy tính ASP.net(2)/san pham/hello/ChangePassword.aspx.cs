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

public partial class hello_Default : System.Web.UI.Page
{
    clsDatabase cls = new clsDatabase();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btThayDoi_Click(object sender, EventArgs e)
    {
        if (txtNewPass.Text == txtNew2Pass.Text)
        {
            string newpass = "";
            newpass = txtNewPass.Text;
            cls.ThucThiSQL("Update tbLogin set Password='" + newpass + "' where UserName='"+ Session["TenDN"].ToString()+"'");
            Response.Write("<script language='javascript'>alert('" + "Thay đổi pass thành công!" + "')</script>");
        }
    }
}
