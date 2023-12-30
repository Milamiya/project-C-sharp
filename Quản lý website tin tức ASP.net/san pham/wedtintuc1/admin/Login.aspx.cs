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

public partial class admin_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //MaHoa a = new MaHoa();
        //txtUserName.Text = a.Encrypt("tk6se", "111111");
    }
    protected void btlogin_Click(object sender, EventArgs e)
    {
        MaHoa a = new MaHoa();
        User b = new User();
        int dangnhap = 0;
        DataTable dtbDn = new DataTable();
        dtbDn = b.User_DangNhap(txtUserName.Text.Trim() + "", a.Encrypt("tk6se", txtPassWord.Text.Trim() + ""));
        if (dtbDn.Rows.Count >= 0)
        {
            dangnhap = int.Parse("0" + dtbDn.Rows[0]["KetQua"]);
            switch (dangnhap)
            {
                case 0:
                    Session["UserName"] = txtUserName.Text.ToUpper();
                    Session["Password"] = txtPassWord.Text + "";
                    Response.Redirect("Default.aspx");
                    break;
                case 1:
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Tên đăng nhập không đúng, bạn kiểm tra lại');", true);
                    break;
                case 2:
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Sai password');", true);
                    break;
                case 3:
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Tài khoản đã bị locked');", true);
                    break;
            }
        }
        a = null;
        b = null;
    }
}
