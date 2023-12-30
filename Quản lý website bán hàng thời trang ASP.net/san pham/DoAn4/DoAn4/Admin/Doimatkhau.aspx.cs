using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

namespace DoAn4.Admin
{
    public partial class WebForm19 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtTK.Text = Session["Username"].ToString();
        }
        InfoDataContext db = new InfoDataContext();

        bool KTTK(string tk, string pass)
        {
            var query = from a in this.db.tbl_Accounts
                        select new { a.Account, a.Password };
            foreach (var sub in query)
            {
                if (sub.Account == tk && sub.Password == pass)
                {
                    return true;
                }
            }
            return false;
        }

        bool KTrong(string mkc, string mkm, string xn)
        {
            if (mkc == "" || mkm == "" || xn == "")
            {
                return false;
            }
            return true;
        }

        protected void btnDoi_Click(object sender, EventArgs e)
        {
            if (KTrong(txtMKcu.Text, txtMKM.Text, txtXN.Text))
            {
                if (KTTK(txtTK.Text, txtMKcu.Text) == false)
                {
                    if (txtMKM.Text == txtXN.Text)
                    {
                        tbl_Account ac = db.tbl_Accounts.SingleOrDefault(c => c.Account == txtTK.Text);
                        // ac.Account = txtTK.Text;
                        ac.Password = txtMKM.Text;
                        db.SubmitChanges();
                        Label1.Text = "Thay đổi thành công.";
                    }
                    else
                    {
                        Label1.Text = "Hai mật khẩu khác nhau.";
                    }
                }
                else
                {
                    Label1.Text = "Mật khẩu không đúng";
                }
            }
            else
                Label1.Text = "Bạn chưa nhập đủ thông tin.";
        }
    }
}
