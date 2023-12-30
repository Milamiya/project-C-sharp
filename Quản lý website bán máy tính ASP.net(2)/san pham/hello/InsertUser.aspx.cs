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
    protected void btThem_Click(object sender, EventArgs e)
    {        
        int role=0;
        if (rbAdmin.Checked) role = 1;
        else role = 2;
        cls.ThucThiSQL("Insert into tbLogin values('" + txtUserName.Text + "','" + txtPass.Text + "','" + role + "','" + txtFullName.Text + "','" + txtBirthday.Text + "','" + txtEmail.Text + "')");        
        Response.Write("<script language='javascript'>alert('" + "Thêm tài khoản thành công!" + "')</script>");  
    }
}
