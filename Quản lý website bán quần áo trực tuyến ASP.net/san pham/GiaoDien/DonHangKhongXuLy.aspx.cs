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

public partial class GiaoDien_DonHangKhongXuLy : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadRPT();
        }

    }

    public void LoadRPT()
    {
        var c = from p in db.Orders
                where p.State ==null
                select p;
        rptDonHang.DataSource = c;
        rptDonHang.DataBind();
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        foreach (RepeaterItem item in rptDonHang.Items)
        {
            Label ma = (Label)item.FindControl("lbMaHD");
            CheckBox xuly = (CheckBox)item.FindControl("ckCheck");
            if (xuly.Checked == true)
            {
                var c = from p in db.DetailOrders
                        where p.OrderID == int.Parse(ma.Text)
                        select p;
                db.DetailOrders.DeleteAllOnSubmit(c);
                db.SubmitChanges();
                var d = (from p in db.Orders
                        where p.OrderID == int.Parse(ma.Text)
                        select p).First();
                db.Orders.DeleteOnSubmit(d);
                db.SubmitChanges();
            }
        }
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
