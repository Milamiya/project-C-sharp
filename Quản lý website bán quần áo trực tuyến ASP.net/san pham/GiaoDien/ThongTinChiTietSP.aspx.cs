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

public partial class GiaoDien_ThongTinChiTietSP : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    clsThaoTac cls = new clsThaoTac();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string masp = Request.QueryString["ProductID"];
            cls.LoadChiTietSP(masp,dlCTSP);
            cls.LoadSPCL(masp,dlSPCL);
         
        }

        
    }
    protected void dlCTSP_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Them")
        {
            ShoppingCart gio=(ShoppingCart)Session["GioHang"];
            Label ma = (Label)e.Item.FindControl("lblMaSP");
            Label tensp = (Label)e.Item.FindControl("lblTenSP");
            Label gia = (Label)e.Item.FindControl("lblGia");
            TextBox sl = (TextBox)e.Item.FindControl("txtSL");
            gio.ADD(ma.Text,tensp.Text,int.Parse(sl.Text),long.Parse(gia.Text));
            Response.Redirect("GioHang.aspx");
        }
    }
    protected void dlSPCL_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Them")
        {

            ShoppingCart gio = (ShoppingCart)Session["GioHang"];
            Label ma = (Label)e.Item.FindControl("lbMaSP");
            Label ten = (Label)e.Item.FindControl("lbTenSP");
            Label gia = (Label)e.Item.FindControl("lbGia");
            int sl = 1;
            gio.ADD(ma.Text, ten.Text, sl, long.Parse(gia.Text));
            Response.Redirect("GioHang.aspx");
        }
    }
}
