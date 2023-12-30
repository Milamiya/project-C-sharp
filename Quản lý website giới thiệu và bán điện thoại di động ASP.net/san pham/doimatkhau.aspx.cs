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

public partial class doimatkhau : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ChangePasswordPushButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtcu.Text != "")
            {
                if (txtmoi.Text!="")
                   
                {
                    if (txtxacnhan.Text != "")
                    {
                        if ((txtmoi.Text == txtxacnhan.Text))
                        {
                            ado.ketNoi();
                            OleDbCommand cmd = new OleDbCommand("select * from tbluser", ado.con);
                            cmd.CommandText = "UPDATE tbluser SET matkhau='" + txtmoi.Text + "' WHERE matkhau='" + txtcu.Text + "'";
                            cmd.ExecuteNonQuery();
                            Response.Redirect("doimatkhauthanhcong.aspx");
                        }
                        else lbltb.Text = "xác nhận mật khẩu chưa đúng";
                    }
                    else lbltb.Text = "Bạn chưa xác nhận mật khẩu";
                }
                else lbltb.Text = "Bạn chưa nhập mật khẩu cũ";
            }
            else lbltb.Text = "Bạn chưa nhập mật khẩu mới";
            
        }
        catch (Exception ex)
        { Response.Write(ex); }
       

    }
    protected void CancelPushButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("thongtintaikhoan.aspx");
    }
}
