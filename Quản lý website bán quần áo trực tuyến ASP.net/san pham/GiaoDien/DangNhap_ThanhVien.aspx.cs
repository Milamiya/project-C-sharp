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
    clsDatabase cls = new clsDatabase();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        bool tontai = cls.kiemtratontai("select * from Users where UserName='" + txtTenDN.Text + "' and Pass='" + txtMK.Text + "'");
        if (tontai)
        {
            Session.Contents["UserName"] = "'" + txtTenDN.Text + "'";
            DataTable dt = cls.Datatable_Laydulieu("Select UserName From Users where UserName='" + txtTenDN.Text + "'", "KH");
            Session.Contents["KH"] = dt.Rows[0][0].ToString();
            Response.Redirect("~/GioHang.aspx");

        }
        else
        {

        }
    }
}
