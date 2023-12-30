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

public partial class GiaoDien_ChiTietDH : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            string ma=Session["MaHD"].ToString();
            lblMaHD.Text = ma;
            
            LoadChiTiet(ma);
        }

    }
    //public void LoadMaHD()
    //{
    //    lblMaHD.Text=Session["MaHD"];
    //}
    public void LoadChiTiet(string mahd)
    {
       
        var c = from p in db.DetailOrders
                where p.OrderID == int.Parse(mahd)
                select new { p.ProductID, p.Number, p.Product.ProductName, p.Product.Price};

        rpt_CTHD.DataSource = c;
        rpt_CTHD.DataBind();
        long TongTienTB = 0;
        int TongSP = 0;
        foreach (RepeaterItem item in rpt_CTHD.Items)
        {
            Label gia = (Label)item.FindControl("lbGia");
            Label SL = (Label)item.FindControl("lbSL");
            Label tongtien = (Label)item.FindControl("lbTong");
            tongtien.Text=(long.Parse(gia.Text)*int.Parse(SL.Text)).ToString();
            TongTienTB = TongTienTB + long.Parse(tongtien.Text);
            TongSP = TongSP + int.Parse(SL.Text);
        }
        lbTongTien.Text = TongTienTB.ToString()+" "+" "+"VNĐ";
        lbTongSL.Text = TongSP.ToString();



        // load len datalist thong tin khách hàng
        var d = from p in db.Orders
                where p.OrderID == int.Parse(mahd)
                select new { p.User.Name, p.User.Phone, p.User.Address, p.User.Email };
        dlTTKH.DataSource = d;
        dlTTKH.DataBind();
        // load lên datalist người nhận

        var e = from p in db.Orders
                where p.OrderID == int.Parse(mahd)
                select new { p.Paymnet.PaymentName, p.Phone, p.Address, p.RecipientName,p.Email };
        dlTTNguoiNhan.DataSource = e;
        dlTTNguoiNhan.DataBind();
        //
        var f = (from p in db.Orders
                where p.OrderID == int.Parse(mahd)
                select p.State).First();
        if (f == 0)
        {
            btXuLy.Visible = true;
            rdHuyDH.Visible = true;
            rdXLTC.Visible = true;
        }
        if (f == null)
        {
            btXuLy.Visible = false;
            rdHuyDH.Visible = false;
            rdXLTC.Visible = false;
        }


    }
    protected void dlTTKH_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btXuLy_Click(object sender, EventArgs e)
    {
        if (rdXLTC.Checked == true)
        {
            Order or = db.Orders.Single(p=>p.OrderID==int.Parse(lblMaHD.Text));
            or.State = 1;
            db.SubmitChanges();
        }
        if (rdHuyDH.Checked == true)
        {
            Order or = db.Orders.Single(p=>p.OrderID==int.Parse(lblMaHD.Text));
            or.State = null;
            db.SubmitChanges();
        }
        //var c = from p in db.DetailOrders
        //        where p.OrderID == int.Parse(lblMaHD.Text)
        //        select new { p.ProductID, p.Number };
        //foreach (var con in c)
        //{
        //    Product pr = db.Products.Single(p=>p.ProductID==con.ProductID);
        //    pr.Number = pr.Number - con.Number;
        //    db.SubmitChanges();
        //}
    }
    protected void rdXLTC_CheckedChanged(object sender, EventArgs e)
    {
        if (IsPostBack == true)
        {
            if (rdXLTC.Checked == true)
            {
                rdHuyDH.Checked = false;
            }
            else rdHuyDH.Checked = true;
        }
        
    }
    protected void rdHuyDH_CheckedChanged(object sender, EventArgs e)
    {
        if (IsPostBack == true)
        {
            if (rdHuyDH.Checked == true)
            {
                rdXLTC.Checked = false;
            }
            else rdXLTC.Checked = true;
        }
    }
    protected void btBack_Click(object sender, EventArgs e)
    {
        var c = from p in db.Orders
                where p.OrderID == int.Parse(lblMaHD.Text)
                select p.State;
        foreach (var con in c)
        {
            if (con == null)
            {
                Response.Redirect("DonHangKhongXuLy.aspx");
            }
            if (con == 1)
            {
                Response.Redirect("DonHangDaXuLy.aspx");
            }
            if (con == 0)
            {
                Response.Redirect("DonHangChuaXuLy.aspx");
            }
        }
    }
}
