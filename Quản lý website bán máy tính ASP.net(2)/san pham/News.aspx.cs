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
using System.Threading;
using System.Globalization;
public partial class Default3 : System.Web.UI.Page
{
    clsDatabase cls = new clsDatabase();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = cls.LoadDuLieuPKN("select top(3)* from tbNews");
        string tieude1 = "";
        foreach (DataRow  dr in dt.Rows)
        {
            tieude1 += "<div style='padding-left:3px;'><img src='Image/item1.png' width='8px' height='8px'/>&nbsp;<a href='NewsDetails.aspx?NewsID=" + dr[0].ToString() + "' style='color:#00418c; text-decoration:none '>" + dr[1].ToString() + "</a><img src='Image/icon_new.gif'/></div>";
        }
        lbCacbaimoi.Text = tieude1;
        DataTable tb = cls.LoadDuLieuPKN("select * from tbNews");
        string tieude2 = "";
        foreach (DataRow dr in tb.Rows)
        {
            tieude2 += "<div style='padding-left:3px;'><img src='Image/item1.png' width='8px' height='8px'/>&nbsp;<a style='color:#00418c'>" + dr[1].ToString() + "</a></div>";
        }
        lbCacbaidadang.Text = tieude2;
        //LayDuLieu();
        //Label1.Text = GetTopNews();
    }
//    public void LayDuLieu()
//    {
//        DataTable dt = cls.LoadDuLieuPKN("select * from tbNews");
//        string chuoi = "";
//        string title = "";
//        string img = "";
//        foreach (DataRow dr in dt.Rows)
//        {
//            string Newsid = dr[0].ToString();
//            title = dr[1].ToString();
//            img = dr[3].ToString();
//            chuoi = @"            
//            <div class='panelTable'>                            
//            <div style='float:left; margin:2px'>
//                <img src='" + img.ToString().Substring(2) + @"' Height='100px' Width='122px' BorderColor='#999999' BorderStyle='Solid' BorderWidth='2px'/>
//            </div>
//            <div style='margin-left:2px;'>
//                <asp:LinkButton ID='LinkButton3' runat='server' Font-Bold='True' Width='114px' 
//            style='color:#004175; font-weight:bold;'>" + title.ToString() + @"</asp:LinkButton>                                                 
//            </div>;    
//            </div>";
//            Show1.AddHtmlPanel(chuoi);
//        }
//    }
//    public void LayDuLieu()
//    {
//        DataTable dt = cls.LoadDuLieuPKN("select * from tbNews");
//        string chuoi = "";
//        string title = "";
//        string img = "";
//        string description="";
//        foreach (DataRow dr in dt.Rows)
//        {
//            string Newsid = dr[0].ToString();
//            title = dr[1].ToString();
//            img = dr[3].ToString();
//            description=dr[4].ToString();
//            chuoi = @"            
//            <div class='panelTable'>                            
//            <div>
//                <img src='" + img.ToString().Substring(2) + @"' Height='252px' Width='401px' BorderColor='#999999' BorderStyle='Solid' BorderWidth='3px'/>
//            <br/>
//            </div>
//            <div>
//                <asp:LinkButton ID='LinkButton3' runat='server' Font-Size='16pt' Font-Underline='False'
//            CssClass='menu'>" + title.ToString() + @"</asp:LinkButton>                                                 
//            </div>
//            <div>
//                <asp:Label ID='Label1' runat='server' Width='400px' CssClass='menu'>"+description.ToString()+@"</asp:Label>
//            </div>
//            </div>";
//            Show1.AddHtmlPanel(chuoi);
//        }
//    }
    protected override void InitializeCulture()
    {
        string ui = Request.QueryString["lancode"];
        if (string.IsNullOrEmpty(ui))
            ui = "vi";
        string culture = ui == "en" ? "en-us" : ui + "-" + "VN";
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
        base.InitializeCulture();
    }//Download source code tai Sharecode.vn
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
    }
    //private string GetTopNews()
    //{
    //    string strHTML = "";
    //    strHTML += "<img src='Image/tintuc-sukien.png'/><br /><marquee width=\"315px\" height=458px ";
    //    //strHTML += "CssClass=\"menu\"";
    //    strHTML += "style=\"color:#004175; text-align:justify; line-height:25px\"  ";
    //    strHTML += "onmouseover=\"this.stop()\" onmouseout=\"this.start()\" scrollamount=\"2\" scrolldelay=\"1\"    ";
    //    strHTML += "direction=\"up\" loop=\"infinite\">";
    //    DataTable dt = cls.LoadDuLieuPKN("select * from tbNews");
    //    foreach (DataRow dr in dt.Rows)
    //    {
    //        strHTML += "<img src='Image/item2.png'/> <a href='NewsDetails.aspx?NewsID=" + dr[0] + "'>" + dr[1] + "</a><br>";
    //    }
    //    strHTML += "</marquee>";
    //    return strHTML;
    //}

}
