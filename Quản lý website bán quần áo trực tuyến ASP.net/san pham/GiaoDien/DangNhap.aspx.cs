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

public partial class GiaoDien_DangNhap : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void KTDN(string tenDN, string pass)
    {
        if (tenDN != "" && pass != "")
        {

            var c = (from p in db.Users
                     where p.UserName == tenDN && p.Pass == pass
                     select new { p.UserName, p.Pass }).First();
            if (c.UserName != null)
            {
                Session["DangNhap"] = "T";
                Session["UserName"] = tenDN;
            }


        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        KTDN(txtTenDN.Text, txtMK.Text);
        //Response.Redirect("GioHang.aspx");
        //if (Session["GioHang"] != null)
        //{

            Response.Redirect("GioHang.aspx");
        //}
        //else if (Session["GioHang"] == null)
        //{
        //    Response.Redirect("Trangchu.aspx");
        //}
    }
}