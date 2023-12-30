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
public partial class _Default : System.Web.UI.Page
{
    clsDatabase cls = new clsDatabase();
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
   
    protected void Page_Load(object sender, EventArgs e)
    {                
        if (IsPostBack == false)
        {            
            if (Session["GioHang"] != null)
            {
                lbThongbao.Visible = false;       
                DataTable dt = (DataTable)Session["GioHang"];
                if (dt.Rows.Count > 0)
                {                                        
                    BindData();
                }
            }
            else
            {
                lbThongbao.Enabled = true;
            }
        }               
    }

    protected void lbTongTien_Load(object sender, EventArgs e)
    {
        int tong = 0;
        foreach (GridViewRow gvr in gvCart.Rows)
        {
            tong += int.Parse(gvr.Cells[4].Text);
        }
        lbTongTien.Text = tong.ToString();
        if (tong <=0)
            lbThongbao.Visible = true;
    }
    public void RemoveRow()
    {
        for (int i = 0; i < gvCart.Rows.Count; i++)
        {
            gvCart.DeleteRow(i);
        }
    }
    public void BindData()
    {
        if (gvCart.Rows.Count > 0) RemoveRow();
        DataTable dt = (DataTable)Session["GioHang"];
        gvCart.DataSource = dt;
        gvCart.DataBind();
    }
    protected void gvCart_RowCommand(object sender, GridViewCommandEventArgs e)
    {        
        if (e.CommandName == "Sua")
        {
            int khohang = int.Parse(cls.LoadDuLieu("select * from tbProduct", 5));
            DataTable dt = (DataTable)Session["GioHang"];
            int hang = Convert.ToInt32(e.CommandArgument);
            string ma = gvCart.Rows[hang].Cells[0].Text;
            int soluong =int.Parse(((TextBox) gvCart.Rows[hang].Cells[3].Controls[1]).Text);
            if (soluong < khohang)
            {
                dt.Rows[hang].SetField(3, soluong);
                int gia = int.Parse(gvCart.Rows[hang].Cells[2].Text);
                int tien = gia * soluong;
                dt.Rows[hang].SetField(4, tien);
                //cls.UpdateNumber(dt, ma, soluong);
                Session["GioHang"] = dt;
                gvCart.DataSource = dt;
                gvCart.DataBind();
                lbTongTien_Load(sender, e);
            }
            else Response.Write("<script>alert('" + "Số lượng trong kho không đủ!" + "')</script>");
        }
    }
    protected void gvCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataTable dt = (DataTable)Session["GioHang"];
        string ma = gvCart.Rows[e.RowIndex].Cells[0].Text;        
        cls.DeleteRow(dt, ma);        
        gvCart.DataSource = dt;
        gvCart.DataBind();
        lbTongTien_Load(sender, e);        
    }
    protected void gvCart_RowEditing(object sender, GridViewEditEventArgs e)
    {
        this.gvCart.EditIndex = e.NewEditIndex;
        DataTable dt = (DataTable)Session["GioHang"];
        BindData();
    }
    
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        int x = int.Parse(lbTongTien.Text);
        if (x == 0)
        {
            string message = "<script language='javascript'>alert('" + "Bạn chưa mua hàng!" + "')</script>";
            Response.Write(message);
        }
        else
        {
            Response.Redirect("LoginCustomer.aspx");
        }
    }
}
