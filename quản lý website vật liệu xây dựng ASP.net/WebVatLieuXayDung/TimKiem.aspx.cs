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

public partial class TimKiem : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        var v = from d in db.Products
                where d.Title==txtTuKhoa.Text
                select d;
        dtlProducts.DataSource = v.Take(12);
        dtlProducts.DataBind();
        var v1 = from d in db.News
                select d;
        rptNews.DataSource = v1.Take(8);
        rptNews.DataBind();
    }
    protected void dtlProducts_ItemDataBound(object sender, DataListItemEventArgs e)
    {

    }
}
