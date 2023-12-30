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

public partial class GiaoDien_Trangchu : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //DataTable tb = new DataTable();
            //tb.Columns.Add("STT", typeof(string));
            //tb.Columns.Add("MaSP", typeof(string));
            //tb.Columns.Add("TenSP", typeof(string));
            //tb.Columns.Add("SoLuong", typeof(int));
            //tb.Columns.Add("Gia", typeof(int));
            //tb.Columns.Add("Tong", typeof(int));
            //Session["GioHang"] = tb;

            var c = from p in db.Products where p.Status == 1 select new { p.ProductID, p.ProductName, p.Price, p.Images };
            dlSPMoi.DataSource = c;
            dlSPMoi.DataBind();
        }
    }



    protected void dlSPMoi_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void dlSPMoi_ItemCommand(object source, DataListCommandEventArgs e)
    {
        
        if (e.CommandName == "Them")
        {
            
            ShoppingCart gio =  (ShoppingCart)Session ["GioHang"];
            Label ma = (Label)e.Item.FindControl("lbMaSP");
            Label ten = (Label)e.Item.FindControl("lbTenSP");
            Label gia = (Label)e.Item.FindControl("lbGia");
            int sl = 1;
            gio.ADD(ma.Text, ten.Text, sl, long.Parse(gia.Text));
            Response.Redirect("GioHang.aspx");
        }
    }
}
