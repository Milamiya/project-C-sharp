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

public partial class Manages_SuaBaiViet : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        var f = from d in db.News
                where d.NewID ==long.Parse(Request.QueryString["Newid"].ToString())
                select d; 
        foreach (var item in f)
        {
            txtTieuDe.Text = item.Title;
            txtMoTa.Text = item.SubTitle;
            lbNguoiDang.Text = Request.Cookies["Login"]["TaiKhoan"].ToString();
            txtTuKhoa.Text=item.KeyWord;
            txtNguon.Text = item.Author;
            imAnh.ImageUrl = "../"+item.Image;
            fckNoiDung.Value = item.Detail;
            break;
        }
    }
    protected void btnUpLoad_Click(object sender, EventArgs e)
    {
        if (fuAnh.HasFile)
        {
            fuAnh.SaveAs(Server.MapPath("~/Images/Products/" + fuAnh.PostedFile.FileName.ToString()));
            string str = "../Images/Products/" + fuAnh.PostedFile.FileName.ToString();
            anh = str;
            imAnh.ImageUrl = str;

        }
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        New n = db.News.SingleOrDefault(s => s.NewID == long.Parse(Request.QueryString["Newid"].ToString()));
        n.Title = txtTieuDe.Text;
        n.SubTitle = txtMoTa.Text;
        n.Image = anh;
        n.KeyWord = txtTuKhoa.Text;
        n.CreateDate = DateTime.Now;
        n.TotalView = 0;
        n.IsPost = false;
        n.PostDate = DateTime.Now;
        n.Author = lbNguoiDang.Text;
        n.Detail = fckNoiDung.Value;
        db.SubmitChanges();
    }
    string anh = "";
    protected void Thoát_Click(object sender, EventArgs e)
    {

    }
}
