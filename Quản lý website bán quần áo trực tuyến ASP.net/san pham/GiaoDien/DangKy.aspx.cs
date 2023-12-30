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

public partial class GiaoDien_DangKy : System.Web.UI.Page
{

    clsDatabase cls = new clsDatabase();

    protected void Page_Load(object sender, EventArgs e)
    {
        bool ok = cls.kiemtratontai("select * from Users where UserName='"+txtEmail+"'");
        if (!ok)
        {
            string insert = "insert into Users values('" + txtEmail.Text + "')";
            cls.ThucThiSQL(insert);
            Response.Redirect("DangKyThanhCong.aspx");
        }
        else
        {
            lbThongBao.Text = "Email này đã tồn tại! Vui long chọn 1 tài khoản khác.";
        }
    }
    protected void btnDangKi_Click(object sender, EventArgs e)
    {

    }
}
