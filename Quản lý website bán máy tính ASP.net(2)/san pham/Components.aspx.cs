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
using System.Threading;
using System.Globalization;
public partial class Default2 : System.Web.UI.Page
{
    clsDatabase cls = new clsDatabase();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt;
        if (Session["GioHang"] == null)
        {
            dt = cls.GetDataTable();
        }
        else
        {
            dt = (DataTable)Session["GioHang"];
        }      
    }
    protected override void InitializeCulture()
    {
        string ui = Request.QueryString["lancode"];
        if (string.IsNullOrEmpty(ui))
            ui = "vi";
        string culture = ui == "en" ? "en-us" : ui + "-" + "VN";
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);        
        base.InitializeCulture();
    }
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "GioHang")
        {
            DataTable dt;
            clsDatabase cls = new clsDatabase();
            if (Session["GioHang"] == null) dt = cls.GetDataTable();
            else dt = (DataTable)Session["GioHang"];
            string strComponentDetailsID, strParameter;
            int strPrice;
            int strNumber, strTotal;
            LinkButton lbt = new LinkButton();
            Label lb = new Label();
            //Tên sản phẩm
            lbt = (LinkButton)e.Item.FindControl("lblParameter");
            strParameter = lbt.Text;
            //Mã sản phẩm
            strComponentDetailsID = cls.LoadDuLieu("select ComponentDetailsID from tbComponentDetails where Parameter='" + strParameter + "'", 0);
            //Giá
            lb = (Label)e.Item.FindControl("lblPrice");
            strPrice = int.Parse(lb.Text);
            //Số lượng
            strNumber = 1;
            //Tổng tiền
            strTotal = strNumber * strPrice;
            cls.DienVaoBang(dt, strComponentDetailsID, strParameter, strPrice, strNumber, strTotal);
            Session["GioHang"] = dt;
            Response.Redirect("Cart.aspx");
        }
    }
}
