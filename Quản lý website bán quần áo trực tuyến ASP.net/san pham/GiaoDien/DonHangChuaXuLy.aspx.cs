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

public partial class GiaoDien_QuanLyDonHang : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadDH();
        }
    }
    public void LoadDH()
    {
        var c = from p in db.Orders
                where p.State==0
                select p;
        rptDonHang.DataSource = c;
        rptDonHang.DataBind();
    }

    public void LoadSL()
    {
        
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
    protected void btXuLy_Click(object sender, EventArgs e)
    {
        foreach (RepeaterItem item in rptDonHang.Items)
        {
            Label ma = (Label)item.FindControl("lbMaHD");
            CheckBox xuly = (CheckBox)item.FindControl("ckCheck");
            if (xuly.Checked == true)
            {
                Order or = db.Orders.Single(p=>p.OrderID==int.Parse(ma.Text));
                or.State = 1;
                db.SubmitChanges();
                ////var c = from p in db.DetailOrders
                ////        where p.OrderID == int.Parse(ma.Text)
                ////        select new { p.ProductID, p.Number };
                ////foreach (var con in c)
                ////{
                ////    Product pr = db.Products.Single(p => p.ProductID == con.ProductID);
                ////    pr.Number = pr.Number - con.Number;
                ////    db.SubmitChanges();
                ////}
            }
           
        }
        Response.Redirect("DonHangDaXuLy.aspx");
    }


    protected void btnCap_Click(object sender, EventArgs e)
    {
        foreach (RepeaterItem item in rptDonHang.Items)
        {
            Label ma = (Label)item.FindControl("lbMaHD");
            CheckBox xuly = (CheckBox)item.FindControl("ckCheck");
            if (xuly.Checked == true)
            {
                Order or = db.Orders.Single(p => p.OrderID == int.Parse(ma.Text));
                or.State = null;
                db.SubmitChanges();
            }
        }
        Response.Redirect("DonHangKhongXuLy.aspx");
    }
}
