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

public partial class admin_ThongTinCaNhan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            lblUser.Text = "Thông tin cá nhân: " + Session["UserName"].ToString();
            if (!IsPostBack)
            {
                LoadText(Session["UserName"].ToString());
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
    private void LoadText(string Username)
    {
        User a = new User();
        DataTable dtb = a.User_SelectByUserName(Username);
        if (dtb.Rows.Count > 0)
        {
            txtTenDN.Text = dtb.Rows[0]["UserName"].ToString();
            txtQuyen.Text = dtb.Rows[0]["RoleName"].ToString();
            txtHoTen.Text = dtb.Rows[0]["FullName"].ToString();
            txtEmail.Text = dtb.Rows[0]["Email"].ToString();
            lblRoleName.Text = dtb.Rows[0]["RoleCode"].ToString();
        }
        a = null;
    }
    protected void butCapNhat_Click(object sender, EventArgs e)
    {
        string loi = "";
        User a = new User();
        a.User_Edit(txtTenDN.Text + "", "", lblRoleName.Text + "", txtHoTen.Text + "", txtEmail.Text + "", 1, ref loi);
        if (loi + "" != "")
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('" + loi + "');", true);
            LoadText(Session["UserName"].ToString());
        }
        a = null;
        
    }
    protected void butDoiMk_Click(object sender, EventArgs e)
    {
        if (txtNewPass.Text + "" == txtNewPassAgain.Text + "")
        {
            string loi = "";
            MaHoa mh = new MaHoa();
            User us = new User();
            us.User_ChanePass(txtTenDN.Text + "", mh.Encrypt("tk6se", txtOldPass.Text) + "", mh.Encrypt("tk6se", txtNewPass.Text) + "", ref loi);
            if (loi + "" != null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('" + loi + "');", true);
                LoadText(Session["UserName"].ToString());
            }
            mh = null;
            us = null;
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Alert", "alert('Xác nhận mật khẩu chưa đúng');", true);
        }
    }
}
