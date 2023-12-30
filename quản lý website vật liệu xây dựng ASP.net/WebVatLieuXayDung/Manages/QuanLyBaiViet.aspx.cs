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

public partial class Manages_QuanLyBaiViet : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Request.Cookies["Login"] == null)
        //{
        //    Response.Redirect("~/Manages/DangNhap.aspx");
        //}
        //else
        //{
        var d = from i in db.News
                select i;
        grvTin.DataSource = d;
        grvTin.DataBind();
        //}
    }
    protected void btnTimKiem_Click(object sender, EventArgs e)
    {
        var d = from i in db.News

                select i;
        grvTin.DataSource = d;
        grvTin.DataBind();
    }
    protected void grvTin_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "btnSua")
        {
            Response.Redirect(@"/WebVatLieuXayDung/Manages/SuaBaiViet.aspx?Newid=" + grvTin.Rows[int.Parse(e.CommandArgument.ToString())].Cells[2].Text + "");
        }
        if (e.CommandName == "btnXoa")
        {
            New n = db.News.SingleOrDefault(s => s.NewID == long.Parse(grvTin.Rows[int.Parse(e.CommandArgument.ToString())].Cells[2].Text.ToString()));
            db.News.DeleteOnSubmit(n);
            db.SubmitChanges();
            Response.Redirect(@"/WebVatLieuXayDung/Manages/QuanLyBaiViet.aspx");

        }
    }

    protected void grvTin_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grvTin.PageIndex = e.NewPageIndex;
        grvTin.DataBind();
    }
}
