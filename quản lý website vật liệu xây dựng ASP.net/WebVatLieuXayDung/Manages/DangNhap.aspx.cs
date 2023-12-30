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

public partial class Manages_DangNhap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    DataClassesDataContext db = new DataClassesDataContext();
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        var f = from i in db.Manages
                select i;
        bool kt = false;
        string taikhoan = "";
        string quyen = "";
        foreach (var item in f)
        {
            if (item.AccountID ==txtTaiKhoan.Text && item.AccountPass == txtMatKhau.Text)
            {
                taikhoan = item.AccountID.ToString();
                quyen = item.Powers;
                kt = true;
                break;
            }
        }
        if (kt == true)
        {
            Response.Cookies.Remove("Login");
            Response.Cookies["Login"]["State"] = "1";
            Response.Cookies["Login"]["TaiKhoan"] = taikhoan;
            Response.Cookies["Login"]["Quyen"] = quyen;
            Response.Redirect(@"../Manages/Default.aspx");
        }
        else
        {
            lbthongbao.InnerText = "Tài khoản chưa đúng";

        }
    }
}
