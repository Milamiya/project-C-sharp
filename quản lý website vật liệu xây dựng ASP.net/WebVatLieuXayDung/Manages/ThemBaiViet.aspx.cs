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
using System.IO;

public partial class Manages_ThemBaiViet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) { }
    }
    DataClassesDataContext db = new DataClassesDataContext();
    protected void btnThem_Click(object sender, EventArgs e)
    {
        New n = new New();
        n.Title = txtTieuDe.Text;
        n.SubTitle = txtMoTa.Text;
        n.Image = anh;
        n.KeyWord = txtTuKhoa.Text;
        n.CreateDate = DateTime.Now;
        n.TotalView = 0;
        n.IsPost = false;
        n.PostDate = DateTime.Now;
        n.Author = txtNguon.Text;
        n.Detail = fckNoiDung.Value;
        n.Account = Request.Cookies["Login"]["TaiKhoan"].ToString();
        db.News.InsertOnSubmit(n);
        db.SubmitChanges();
    }
    string anh = "";
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

    private bool CheckFileType(string FileName)
    {
        string ext = FileName;
        if (ext.Equals(".png"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    protected void Thoát_Click(object sender, EventArgs e)
    {

    }


}
