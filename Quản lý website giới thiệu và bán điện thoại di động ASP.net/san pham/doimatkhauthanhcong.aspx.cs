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
using System.Data.OleDb;

public partial class doimatkhauthanhcong : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btndangnhap_Click(object sender, EventArgs e)
    {
        ado.ketNoi();
        string query = "select * from tbluser where email='" + txtemail.Text + "' and matkhau='" + txtpass.Text + "'";
        ado.rd = ado.getData(query);
        if (ado.rd.Read())
        {
            FormsAuthentication.SetAuthCookie(txtemail.Text, true);
            Session["email"] = txtemail.Text;
            Session["matkhau"] = ado.rd[1].ToString();
            Session["quyen"] = ado.rd[2].ToString();
            Session["hoten"] = ado.rd[3].ToString();
            Session["diachi"] = ado.rd[4].ToString();
            Session["dienthoai"] = ado.rd[5].ToString();
            Session["soCMND"] = ado.rd[6].ToString();
            Session["mataikhoan"] = ado.rd[7].ToString();

            if (Session["quyen"].ToString() == "admin")
                Response.Redirect("themqtri.aspx");
            else
                Response.Redirect("thongtintaikhoan.aspx", true);
        }
        else
        {
            txtemail.Focus();
        }

        ado.rd.Dispose();
        ado.dongKetNoi();
    }
   
}
