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

public partial class GiaoDien_GioHang : System.Web.UI.Page
{
    //DataTable dt = new DataTable("tbGH");
    DataClassesDataContext db = new DataClassesDataContext();
    //DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            this.rpt_giohang.DataSource = getGH();
            this.rpt_giohang.DataBind();
            tongTien();
            //lbTongTien.Text = gio.TotalMoney().ToString();
        }

       
    }

    public DataTable getGH()
    {
        ShoppingCart gio = (ShoppingCart)Session["GioHang"];
        if (gio != null)
        {
            //int t = gio.Data.Rows.Count;
            return gio.Data;
        }
        else
        {
            return null;
        }

    }
    public void tongTien()
    {
        //long tong = 0;
        int sl = 0;
        long gia = 0;

        ShoppingCart gio = (ShoppingCart)Session["GioHang"];

        for (int i = 0; i < gio.Data.Rows.Count; i++)
        {
            gia = gia + long.Parse(gio.Data.Rows[i][4].ToString());
            sl = sl + int.Parse(gio.Data.Rows[i][2].ToString());
        }
        //lbSL.Text = sl.ToString();
        lbTongTien.Text = gia.ToString() + "" + "" + "VNĐ";

    }


    ////public bool KiemTra(string productID)
    ////{
    ////    bool kt = true;
    ////    tb = (DataTable)Session["GioHang"];
    ////    for (int i = 0; i < tb.Rows.Count; i++)
    ////    {
    ////        if (tb.Rows[i]["ProductID"].ToString() == productID)
    ////        {
    ////            kt = false;
    ////            break;
    ////        }
    ////    }
    ////    return kt;
    ////}
    ////public string TongTien(DataTable dt)
    ////{
    ////    int tongtien = 0;
    ////    for (int i = 0; i < tb.Rows.Count; i++)
    ////    {
    ////        tongtien = tongtien + int.Parse(tb.Rows[i][5].ToString());
    ////    }
    ////    return tongtien.ToString();
    ////}


    protected void btnThanhToan_Click1(object sender, EventArgs e)
    {

        ShoppingCart gio = (ShoppingCart)Session["GioHang"];
        if (gio.Data.Rows.Count != 0)
        {
            if (Session["DangNhap"] == "T")
            {
                Response.Redirect("ThongTinDatHang.aspx");
            }
            else if (Session["DangNhap"] == "F")
            {
                Response.Redirect("DangNhap.aspx");
            }
        }
        else Response.Redirect("Trangchu.aspx");
    }
    protected void rpt_giohang_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (IsPostBack == true)
        {

            if (e.CommandName == "Xoa")
            {
                ShoppingCart gio = (ShoppingCart)Session["GioHang"];
                gio.Remove(e.CommandArgument.ToString());

                Response.Redirect("GioHang.aspx");


            }
        }

    }
    protected void btnCapNhat_Click(object sender, EventArgs e)
    {
        if (this.IsPostBack==true)
        {

            ShoppingCart gio = (ShoppingCart)Session["GioHang"];


            foreach (RepeaterItem item in rpt_giohang.Items)
            {
                var sl = (TextBox)item.FindControl("txtSL");
                //string ma = item.TemplateControl.ID.ToString();
                var id = (Label)item.FindControl("lbID");
                //Response.Write(sl.Text);
                //Response.Write(id.Text);


                gio.UpdateQuantity(id.Text, int.Parse(sl.Text));
                

            }
           
            Response.Redirect("GioHang.aspx");
        }
    }
    protected void btnTiepTuc_Click(object sender, EventArgs e)
    {
        Response.Redirect("Trangchu.aspx");
    }
}