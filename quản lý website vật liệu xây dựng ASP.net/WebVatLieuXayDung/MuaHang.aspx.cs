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

public partial class MuaHang : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    string masp = "";
    string mahang = "";
    string tenhang = "";
    string dongia = "";
    string soluong = "";
    DataTable tbMatHang;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Response.Cookies["TT"]["Status"] = "1";
            tbMatHang = new DataTable();
            tbMatHang.Columns.Add("MatHang");
            tbMatHang.Columns.Add("TenMatHang");
            tbMatHang.Columns.Add("DonGia");
            tbMatHang.Columns.Add("SoLuong");
            tbMatHang.Columns.Add("ThanhTien");

            //Download source code tai Sharecode.vn
            masp = Request.QueryString["MaHang"].ToString();
            DataTable tbOne = new DataTable();
            tbOne.Columns.Add("STT");
            tbOne.Columns.Add("MaHang");
            tbOne.Columns.Add("TenMatHang");
            tbOne.Columns.Add("DonGia");
            tbOne.Columns.Add("SoLuong");
            tbOne.Columns.Add("ThanhTien");

            var v = (from d in db.Products
                     where d.ProductID == long.Parse(masp)
                     select d).Take(1);
            foreach (var item in v)
            {
                string thanhtien = (1 * double.Parse(item.Money.ToString())).ToString();
                string[] mang = { "1", item.ProductID.ToString(), item.Title.ToString(), item.Money.ToString(), "1", thanhtien };
                mahang = item.ProductID.ToString();
                tenhang = item.Title.ToString();
                dongia = item.Money.ToString();

                tbOne.Rows.Add(mang);
                break;
            }
            rptOrder.DataSource = tbOne;
            rptOrder.DataBind();
        }

    }
    protected void btnThanhToan_Click(object sender, EventArgs e)
    {
        Response.Redirect("/WebVatLieuXayDung/GioHang.aspx");
      
    }
   
    protected void btnTiepTucMuahang_Click(object sender, EventArgs e)
    {

    }
    protected void btnTiepTucMuaHang_Click(object sender, EventArgs e)
    {

        for (int i = 0; i < rptOrder.Items.Count; i++)
        {
            TextBox txt = (TextBox)rptOrder.Items[i].FindControl("txtSoLuong");
            Label lb = (Label)rptOrder.Items[i].FindControl("lbGiaTien");
            Label lbtt = (Label)rptOrder.Items[i].FindControl("lbThanhTien");
            if (txt != null)
            {
                string thanhtien = (double.Parse(txt.Text.ToString()) * double.Parse(lb.Text.ToString())).ToString();
                //string[] mang = { mahang, tenhang, lb.Text, txt.Text.ToString(), thanhtien };
                //Label4.Text = tbMatHang.Rows.Count.ToString();
                var v = from j in db.AccountProducts
                        select j;
                bool kt = false;
                foreach (var item in v)
                {
                    if (item.AcountName == Request.Cookies["TaiKhoan"]["TenTaiKhoan"].ToString() && item.ProductID == long.Parse(Request.QueryString["MaHang"].ToString()))
                    {
                        kt = true;
                        break;
                    }
                }
                if (kt == true)
                {
                    AccountProduct ac = db.AccountProducts.SingleOrDefault(s => s.ProductID == long.Parse(Request.QueryString["MaHang"].ToString()) && s.AcountName == Request.Cookies["TaiKhoan"]["TenTaiKhoan"].ToString());
                    //ac.Date = DateTime.Now;
                    ac.Status = false;
                    ac.Number = int.Parse(txt.Text);
                    db.SubmitChanges();
                }
                else
                {
                    AccountProduct ac = new AccountProduct();
                    ac.AcountName = Request.Cookies["TaiKhoan"]["TenTaiKhoan"].ToString();
                    //Label3.Text = masp;
                    ac.ProductID = long.Parse(Request.QueryString["MaHang"].ToString());
                    ac.Date = DateTime.Now;
                    ac.Status = false;
                    ac.Number = int.Parse(txt.Text);
                    db.AccountProducts.InsertOnSubmit(ac);
                    db.SubmitChanges();
                }
            }
            break;
        }
        Response.Redirect("/WebVatLieuXayDung/Default.aspx");
    }
    string soluong1 = "";
    int i = 0;

    protected void rptOrder_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
    protected void rptOrder_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

    }
}
