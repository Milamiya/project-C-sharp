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

public partial class hello_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbThongBao.Enabled = false;
    }
    clsDatabase cls = new clsDatabase();
    protected void btLogin_Click(object sender, EventArgs e)
    {
        if (txtName.Text != "" && txtPass.Text != "")
        {
            int role = cls.KiemTraRole("select * from tbLogin", txtName.Text, txtPass.Text);
            if (role == 1)
            {
                Session["Login"] = "1";
                Session["TenDN"] = txtName.Text;
                Response.Redirect("Product.aspx");
            }
            else if (role == 2)
            //if (role == 2)
            {
                //Session["Login"] == "2";
                Response.Redirect("NewsImport.aspx");
            }
            else
            {
                lbThongBao.Text = "Tài khoản không đúng!";
            }
        }
        else
        {
            lbThongBao.Text = "Tài khoản hoặc mật khẩu trống!";            
        }
    }
}
