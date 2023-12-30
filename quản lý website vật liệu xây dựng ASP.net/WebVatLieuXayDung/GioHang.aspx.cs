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

public partial class GioHang : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    string giatien = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var v = from j in db.AccountProducts
                    where j.AcountName == Request.Cookies["TaiKhoan"]["TenTaiKhoan"]
                    select new { j.ProductID, j.Product.Title, j.Product.Money, j.Number };
            DataTable tb = new DataTable();
            tb.Columns.Add("STT");
            tb.Columns.Add("MaHang");
            tb.Columns.Add("TenMatHang");
            tb.Columns.Add("DonGia");
            tb.Columns.Add("SoLuong");
            tb.Columns.Add("ThanhTien");
            int i = 1;
            foreach (var item in v)
            {
                string thanhtien = (double.Parse(item.Number.ToString()) * double.Parse(item.Money.ToString())).ToString();
                string[] mang = { i.ToString(), item.ProductID.ToString(), item.Title, item.Money, item.Number.ToString(), thanhtien };
                tb.Rows.Add(mang);
                i++;
            }
            rptOrder.DataSource = tb;
            rptOrder.DataBind();
            float tien = 0;
            for (int j = 0; j < rptOrder.Items.Count; j++)
            {
                Label tongtien = (Label)rptOrder.Items[j].FindControl("lbThanhTien");
                tien = tien + float.Parse(tongtien.Text);
            }
            giatien = tien.ToString();
            //Label lbtt = (Label)rptOrder.FindControl("lbTongTien");
            lbTongTien.Text = giatien;
        }
    }
    protected void rptOrder_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        //if (e.CommandName.ToLower().Equals("btnXoa"))
        //{
        Label lb = (Label)e.Item.FindControl("lbMaSP");
        AccountProduct ac = db.AccountProducts.SingleOrDefault(f => f.AcountName == "bientho88" && f.ProductID == long.Parse(lb.Text));
        db.AccountProducts.DeleteOnSubmit(ac);
        db.SubmitChanges();
        Response.Redirect("/WebVatLieuXayDung/GioHang.aspx");
        //}
    }
}
