using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace DoAn4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string productID = Request.QueryString["Product_ID"];
                InfoDataContext db = new InfoDataContext();
                tbl_Product pro = db.tbl_Products.SingleOrDefault(t => t.Product_ID.ToString() == productID.Trim());
                if (pro != null)
                {
                    hdf.Value = pro.Product_ID.ToString();
                    lblImage.ImageUrl = "~/AnhSanPham/" + pro.Image;
                    lblType_Name.Text = pro.tbl_Type.Type_Name;
                    lblStyle_Name.Text = pro.tbl_Style.Style_Name;
                    lblColor.Text = pro.Color;
                    txtTotal.Text = "1";
                    lblSL.Text = pro.Amount.ToString();
                    lblMaterial.Text = pro.Material;
                    lblSize.Text = pro.Size;
                    lblPrice.Text = pro.Price_Export.ToString("###,###").Replace(',', '.') + " VNĐ";
                    lblTieuDe.Text = "Chi tiết sản phẩm: " + pro.Product_Name;
                }
                var tmp = from a in db.tbl_Products
                          where a.Type_ID == pro.Type_ID && a.Product_ID != pro.Product_ID
                          select a;
                sanpham.DataSource = tmp;
                sanpham.DataBind();
            }
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            
            if (kt == true)
            {
                double total = 0;
                int soluong = 0;
                InfoDataContext db = new InfoDataContext();
                tbl_Product pro = db.tbl_Products.SingleOrDefault(t => t.Product_ID.ToString() == hdf.Value.ToString());
                if (pro != null)
                {
                    GioHang gh = (GioHang)Session["giohang"];
                    soluong = int.Parse(txtTotal.Text);
                    total = pro.Price_Export * Convert.ToDouble(txtTotal.Text.Trim());
                    gh.dienVaoBang(pro.Product_Name, Convert.ToDouble(txtTotal.Text.Trim()), pro.Price_Export, pro.Size, pro.Color, pro.Material, pro.Weight.ToString(), pro.Product_ID.ToString(), total);
                    Session["giohang"] = gh;
                    DataTable tb = gh.GetDataTable();
                    Response.Redirect("GioHang.aspx");

                }
            }
        }
        bool kt = true;
        protected void CtvThongBao_ServerValidate(object source, ServerValidateEventArgs args)
        {
            kt = true;
            string chuoi = args.Value.Trim();
            if (args.Value == null || args.Value.ToString() == "") kt = false;
            else
            {
                if (int.Parse(args.Value) > int.Parse(lblSL.Text)) kt = false;
            }
            for (int i = 0; i < args.Value.Length; i++)
            {
                if (args.Value[i].ToString() != "1" && args.Value[i].ToString() != "2" && args.Value[i].ToString() != "3" && args.Value[i].ToString() != "4" && args.Value[i].ToString() != "5" && args.Value[i].ToString() != "6" && args.Value[i].ToString() != "7" && args.Value[i].ToString() != "8" && args.Value[i].ToString() != "8" && args.Value[i].ToString() != "9")
                {
                    kt = false;
                    break;
                }
            }
            if (kt == false) args.IsValid = false;
            else args.IsValid = true;
        }
    }
}
