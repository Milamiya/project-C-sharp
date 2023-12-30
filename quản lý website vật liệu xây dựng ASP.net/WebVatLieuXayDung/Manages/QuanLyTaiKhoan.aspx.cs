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

public partial class Manages_QuanLyTaiKhoan : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["Login"] != null)
            {
                if (Request.Cookies["Login"]["Quyen"].ToLower() == "admin")
                {
                    var v = from d in db.Manages
                            select new { d.AccountID, d.Email, d.FullName, d.PhoneNumber };
                    grid.DataSource = v;
                    grid.DataBind();
                    Panel1.Visible = true;

                }
                else
                {
                    var v = from d in db.Manages
                            where d.AccountID == Request.Cookies["Login"]["TaiKhoan"].ToString()
                            select new { d.AccountID, d.Email, d.FullName, d.PhoneNumber };
                    grid.DataSource = v;
                    grid.DataBind();
                    //grid.Columns.RemoveAt(5);
                    Panel1.Visible = false;


                }
            }
            else
                Response.Redirect("~/Manages/DangNhap.aspx");
        }
    }
    protected void grid_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "btnSua")
        {
            Response.Redirect(@"/WebVatLieuXayDung/Manages/SuaTaiKhoan.aspx?aID=" + grid.Rows[int.Parse(e.CommandArgument.ToString())].Cells[1].Text);
        }
        if (e.CommandName == "btnXoa")
        {
            if (Request.Cookies["Login"]["Quyen"].ToLower() == "admin")
            {
                var v = from d in db.Manages
                        where d.Powers == "Admin"
                        select new { d.AccountID };
                string taikhoan = "";
                bool kt1 = false;
                foreach (var item in v)
                {
                    if (item.AccountID == grid.Rows[int.Parse(e.CommandArgument.ToString())].Cells[1].Text)
                    {
                        kt1 = true;
                        break;
                    }
                }
                if (kt1 == false)
                {
                    Manage sc = db.Manages.SingleOrDefault(s => s.AccountID == grid.Rows[int.Parse(e.CommandArgument.ToString())].Cells[1].Text);
                    db.Manages.DeleteOnSubmit(sc);
                    db.SubmitChanges();
                    Response.Redirect(@"/WebVatLieuXayDung/Manages/QuanLyTaiKhoan.aspx");
                }
            }

        }
    }
}
