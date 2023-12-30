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

namespace TestOnline.hy.vn.Control
{
    public partial class ucLogin : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["login"].ToString() == "1")
            {
                //txtUsename.Text = "";
                //txtPass.Text = "";
                //lblHienThi.Text = "Bạn nhập đầy đủ các thông tin";
                pnHide.Visible = false;
                pnShow.Visible = true;
               
                lblUserName.Text = Session.Contents["FullName"].ToString();
            }
            else
            {
                if (Session.Contents["login"].ToString() == "0")
                {
                    //txtUsename.Text = "";
                    //txtPass.Text = "";
                    //lblHienThi.Text = "Bạn nhập đầy đủ các thông tin";
                    pnHide.Visible = true;
                    pnShow.Visible = false;
                }
            }
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            tblStudent tbl = db.tblStudents.SingleOrDefault(c => c.StudentID.ToString().Trim().ToLower() == txtUsename.Text && c.Password.ToString().Trim().ToLower() == txtPass.Text);
            if (tbl != null)
            {
                lblUserName.Text = tbl.StudentName;
                Session.Contents["login"] = "1";
                Session.Contents["FullName"] = tbl.StudentName;
                // lblHide.Text = "a";
                Application.Contents["login"] = "1";
                Session.Contents["AcountID"] = tbl.StudentID;
                pnShow.Visible = true;
                pnHide.Visible = false;
            }
            else
            {
                lblHienThi.Text = "Tài khoản hoặc mật khẩu không đúng";
            }
           
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registry.aspx");
        }

        protected void lblLink_Click(object sender, EventArgs e)
        {
            pnShow.Visible = false;
            pnHide.Visible = true;
            Session.Contents["login"] = "0";
            txtPass.Text = "";
            txtUsename.Text = "";
            lblHienThi.Text = "Nhập đầy đủ các thông tin";
        }
    }
}