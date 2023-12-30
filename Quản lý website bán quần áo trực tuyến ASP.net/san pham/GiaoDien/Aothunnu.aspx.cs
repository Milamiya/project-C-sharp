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

public partial class GiaoDien_Aothunnu : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var a = from c in db.Products where c.ProductGroup.ProductGroupID == 9 && c.Status==1 select new { c.Price, c.Images, c.ProductID, c.ProductName };
            //var a = from c in db.Products where c.ProductID.StartsWith("A") && c.ProductID.Contains("tn") select new { c.ProductID, c.ProductName, c.Price, c.Images, c.Manufacture.ManufactureName, c.ManufactureID, c.ProductGroupID, c.ProductGroup.ProductGroupName, c.Color, c.Date, c.Size, c.Status, c.Number };
            dlAothunu.DataSource = a;
            dlAothunu.DataBind();
        }
    }
    protected void dlAothunu_ItemCommand(object source, DataListCommandEventArgs e)
    {
        
            if (e.CommandName == "Them")
            { 
                ShoppingCart gio=(ShoppingCart)Session["GioHang"];
                Label masp = (Label)e.Item.FindControl("lbMaSP");
                Label tensp = (Label)e.Item.FindControl("lbTenSP");
                Label gia = (Label)e.Item.FindControl("lbGia");
                gio.ADD(masp.Text, tensp.Text, 1, long.Parse(gia.Text));
                Response.Redirect("GioHang.aspx");
            }
        
    }
}