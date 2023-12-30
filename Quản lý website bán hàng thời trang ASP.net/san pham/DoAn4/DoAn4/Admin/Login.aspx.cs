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
using System.Data.SqlClient;

namespace DoAn4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
            txtuser.Text = "Ngan";
            txtpass.Text = "dinhngan";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Data da = new Data();
            da.setstrconnect = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            da.open();
            if ((txtuser.Text == "") || (txtpass.Text == ""))
            {
                Label1.Text = "Bạn chưa nhập đủ thông tin ";
            }
            else
            {
                Session["Username"] = txtuser.Text;
                string query = "select * from tbl_Account where Account= '" + txtuser.Text + "' and Password='" + txtpass.Text + "'";
                SqlDataReader dr = da.Getcommand(query);
                if (dr.Read())
                {
                    //string quyen = "select Power from tbl_Account where Account = '" + txtuser.Text + "'";
                    //if (quyen == "Quản lý")
                    //{
                        Response.Redirect("Nhaphang.aspx");
                    //}
                    //else
                    //{
                    //    Response.Redirect("User.aspx");
                    //}
                }
                else
                    Label1.Text = "Bạn nhập sai Tài khoản hoặc Mật khẩu";
            }
        }
    }
}
