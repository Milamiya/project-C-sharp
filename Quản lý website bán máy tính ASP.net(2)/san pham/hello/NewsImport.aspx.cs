
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

public partial class hello_Default : System.Web.UI.Page
{
    clsDatabase cls = new clsDatabase();
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }
    
    protected void btLuu_Click1(object sender, EventArgs e)
    {
        string day = ddlDay.Text;
        string month = ddlMonth.Text;
        string year = ddlYear.Text;
        string ngaydang = month + "/" + day + "/" + year;
        string anhurl = "~/Image/"+ FileUpload1.FileName;
        cls.ThucThiSQL("Insert into tbNews values(N'" + txtTieuDe.Text + "',N'"+DropDownList1.Text+"',N'"+anhurl+"',N'" + FCKMota.Value + "',N'" + FCKNoiDung.Value + "',N'" + ngaydang + "',N'" + txtNguoiDang.Text + "')");        
        Response.Write("<script language='javascript'>alert('"+"Đăng tin thành công"+"')</script>");
    }
}
