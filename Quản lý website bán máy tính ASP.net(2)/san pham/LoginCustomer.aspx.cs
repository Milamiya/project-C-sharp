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
using System.Threading;
using System.Globalization;
public partial class Default2 : System.Web.UI.Page
{
    protected override void InitializeCulture()
    {
        string ui = Request.QueryString["lancode"];
        if (string.IsNullOrEmpty(ui))
            ui = "vi";
        string culture = ui == "en" ? "en-us" : ui + "-" + "VN";
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
        base.InitializeCulture();
    }
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
    }
    clsDatabase cls = new clsDatabase();
    protected void Page_Load(object sender, EventArgs e)
    {
        lbThongBao.Enabled = false;
    }
    protected void imbLogin_Click(object sender, ImageClickEventArgs e)
    {
        if (txtName.Text != "" && txtPass.Text != "")
        {
            if (cls.KiemTraLoginKH("select * from tbCustomer", txtName.Text, txtPass.Text) == true)
            {
                Response.Redirect("Payment.aspx");                
            }
            else
            {
                lbThongBao.Text = "Sai tên đăng nhập hoặc mật khẩu!";
            }
        }
        else
        {            
            lbThongBao.Text="Tên đăng nhập hoặc mật khẩu trống!";
        }
    }    
}
