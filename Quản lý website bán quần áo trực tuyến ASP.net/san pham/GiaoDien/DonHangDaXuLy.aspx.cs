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

public partial class GiaoDien_DonHangDaXuLy : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadLenRPT();
        }
    }
    public void LoadLenRPT()
    {
        var c = from p in db.Orders
                where p.State == 1
                select p;
        rptDonHang.DataSource = c;
        rptDonHang.DataBind();
    }
    protected void btBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("DonHangChuaXuLy.aspx");
    }
    protected void rptDonHang_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "ChiTiet")
        {
            Session["MaHD"] = e.CommandArgument.ToString();
            //Response.Write("123456");
            Response.Redirect("ChiTietDH.aspx");
        }
    }
}
