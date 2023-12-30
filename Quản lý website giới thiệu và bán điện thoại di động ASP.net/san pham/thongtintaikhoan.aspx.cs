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

public partial class thongtintaikhoan : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //lblthongbao.Text = "Xin chào," + Session["hoten"].ToString()+" .Dưới đây là những thông etin của bạn.Từ bây giờ bạn có thể thay đổi mật khẩu để tăng cường bảo mật tài khoản của mình nếu bạn muốn.";
        lblthongbao.Text = Session["hoten"].ToString();
        lbldiachi.Text = Session["diachi"].ToString();
        lbldienthoai.Text = Session["dienthoai"].ToString();
        lblemail.Text = Session["email"].ToString();
        lblhoten.Text = Session["hoten"].ToString();
        lblcmt.Text = Session["soCMND"].ToString();
        lblmatkhau.Text = Session["matkhau"].ToString();
        lblmataikhoan.Text = Session["mataikhoan"].ToString();
    }
    
}
