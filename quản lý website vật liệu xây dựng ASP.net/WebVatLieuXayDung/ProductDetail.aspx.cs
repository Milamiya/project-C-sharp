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

public partial class ProductDetail : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var v = from i in db.Products
                    where i.ProductID == int.Parse(Request.QueryString["idp"].ToString())
                    select i;
            rpt.DataSource = v.Take(1);
            rpt.DataBind();
        }
        //foreach (var item in v)
        //{
        //    lbTenSanPham.Text = item.Title;
        //    lbGiaTien.Text = item.Money;
        //    lbLoai.Text = item.ProductCategory.SmallProductCategoryName.ToString();
        //    lbXuatXu.Text = item.Xuatxu.ToString();
        //    lbMau.Text = item.Mausac.ToString();
        //    lbHangSanXuat.Text = item.HangSanXuat.ToString();
        //    //lbTinhNang.Text = item.TinhNang;
        //    break;
        //}
    }
    protected void rpt_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (Request.Cookies["TaiKhoan"] != null)
        {
            Response.Redirect("/WebVatLieuXayDung/MuaHang.aspx?MaHang=" + Request.QueryString["idp"].ToString());
        }
        else
        {
            Response.Redirect("/WebVatLieuXayDung/DangNhap.aspx");
        }
    }
}
