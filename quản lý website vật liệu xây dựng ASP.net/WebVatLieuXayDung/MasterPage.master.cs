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
using System.IO;
public partial class MasterPage : System.Web.UI.MasterPage
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        StreamReader sr = new StreamReader(Server.MapPath("count_visit.txt"));
        string[] s = sr.ReadLine().Split('#');
        string s1 = s[0].ToString();
        string s2 = s[1].ToString();
        lbDa.Text = s1.ToString();
        lbDang.Text = s2.ToString(); ;
        sr.Close();

        var v = from d in db.Categories
                select d;

        rptDanhMuc1.DataSource = v;
        rptDanhMuc1.DataBind();

        var v1 = from d in db.News
                 select d;
        rptNews.DataSource = v1.Take(7);
        rptNews.DataBind();
        if (Request.Cookies["TaiKhoan"] != null)
        {
            idDangNhap();
        }
        else
        {
            NotIdDangNhap();
        }
    }
    private void idDangNhap()
    {
        btnDangKy.Visible = false;
        btnDangNhap.Visible = false;
        btnGioHang.Visible = true;
        btnTaiKhoan.Visible = true;
        btnThoat.Visible = true;
        btnTaiKhoan.Text = "Xin chào: " + Request.Cookies["TaiKhoan"]["TenTaiKhoan"].ToString();
    }
    private void NotIdDangNhap()
    {
        btnDangKy.Visible = true;
        btnDangNhap.Visible = true;
        btnGioHang.Visible = false;
        btnTaiKhoan.Visible = false;
        btnThoat.Visible = false;
    }
    protected void rptDanhMuc1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        Label lb1 = (Label)e.Item.FindControl("lbma");
        Repeater rp = (Repeater)e.Item.FindControl("rptDanhMuc2");

        var v = from d in db.ProductCategories
                where d.CategoryID == int.Parse(lb1.Text.ToString())
                select d;
        rp.DataSource = v;
        rp.DataBind();
    }
    protected void btnThoat_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["TaiKhoan"] != null)
        {
            Response.Cookies["TaiKhoan"].Expires = DateTime.Now.AddDays(-1d);
            Response.Redirect("/WebVatLieuXayDung/Default.aspx");
        }
    }
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        Response.Redirect("/WebVatLieuXayDung/DangNhap.aspx");
    }
}
