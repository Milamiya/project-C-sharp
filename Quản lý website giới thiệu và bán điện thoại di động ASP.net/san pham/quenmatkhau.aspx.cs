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

public partial class quenmatkhau : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btntimmk_Click(object sender, EventArgs e)
    {
        if (txtten.Text != "")
        {
            if (txtemail.Text != "")
            {
                if (txtdc.Text != "")
                {
                    ado.ketNoi();
                    string query = "select * from tbluser where hoten='" + txtten.Text + "' and email='" + txtemail.Text + "' and diachi='" + txtdc.Text + "'";
                    ado.rd = ado.getData(query);
                    lbthongbao.Visible = true;
                    if (ado.rd.Read())
                    {
                        lbthongbao.Text = "Mật khẩu của bạn là: " + ado.rd[1].ToString();
                    }
                    else
                    {
                        lbthongbao.Text = "Không tồn tại tài khoản này!";
                    }
                    ado.rd.Close();
                    ado.dongKetNoi();
                }else  lbthongbao.Text = "Chưa nhập địa chỉ";
            }
            else lbthongbao.Text = "Chưa nhập Email";
        }
        else lbthongbao.Text = "Chưa nhập Tên";
    }
}
