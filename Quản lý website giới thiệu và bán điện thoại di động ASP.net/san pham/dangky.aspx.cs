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

public partial class dangky : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtemail.Text != "")
            {
                if ((txtemail.Text.LastIndexOf("@") != -1) && (txtemail.Text.LastIndexOf(".")) != -1)
                {
                    if (txtpass.Text != "")
                    {
                        if (txtpass.Text == TextBox3.Text)
                        {
                            ado.ketNoi();

                            string query = "INSERT INTO tbluser VALUES('" + txtemail.Text + "','" + txtpass.Text + "','khach','" + txthoten.Text + "','" + txtdc.Text + "','" + txtdt.Text + "','" +
                                 txtcmt.Text + "','" + txtnganhang.Text + "','" + txtmabuudien.Text + "')";
                            OleDbCommand cmd = new OleDbCommand(query, ado.con);
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                                Response.Redirect("dangkythanhcong.aspx", true);
                            ado.dongKetNoi();
                        }
                        else Lblthongbao.Text = "Xác nhận mật khẩu chưa đúng";

                    }
                    else Lblthongbao.Text = "Bạn chưa nhập vào mật khẩu";
                }
                else Lblthongbao.Text = "Email nhập chưa đúng";
            }
            else Lblthongbao.Text = "Bạn chưa nhập Email";
        }
        catch (Exception )
        {
            
        }
    }
}
