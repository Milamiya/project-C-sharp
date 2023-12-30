using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PKT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
                Label1.Text = Session["user"].ToString();
            else
                Response.Redirect("khachhang_dangnhap.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
        }
    }
}