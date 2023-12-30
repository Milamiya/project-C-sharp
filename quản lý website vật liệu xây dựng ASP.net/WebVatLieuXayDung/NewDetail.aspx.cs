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

public partial class NewDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();

        var v = (from d in db.News
                 where d.NewID == int.Parse(Request.QueryString["idNew"].ToString())
                 select d).Take(1);

        foreach (var item in v)
        {
            lbTieuDeTin.Text = item.Title;
            lbMoTa.Text = item.SubTitle;
            lbChiTiet.Text = item.Detail;
            lbTrichDan.Text = item.Author;
        }
    }
}
