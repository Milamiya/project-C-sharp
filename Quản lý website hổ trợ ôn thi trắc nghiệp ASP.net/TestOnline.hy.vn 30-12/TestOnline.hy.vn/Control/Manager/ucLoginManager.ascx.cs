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

namespace TestOnline.hy.vn.Control.Manager
{
    public partial class ucLoginManager : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            tblAcount tbl = db.tblAcounts.SingleOrDefault(c => c.AcountID.Trim().ToLower() == txtUserName.Text.Trim().ToLower() && c.Pass==txtPass.Text);
            if (tbl != null)
            {
                Session.Contents["loginManager"] = "1";
                Response.Redirect("HomeManagement.aspx");
            }
            else
            {
                lblError.Text = "Tài khoản hoặc mật khẩu không đúng";
            }

        }

        protected void btnHuybo_Click(object sender, EventArgs e)
        {

        }
    }
}