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
public partial class Default2 : System.Web.UI.Page
{
    protected override void InitializeCulture()
    {
        string ui = Request.QueryString["lancode"];
        if (string.IsNullOrEmpty(ui))
            ui = "vi";
        string culture = ui == "en" ? "en-us" : ui + "-" + "VN";
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
        base.InitializeCulture();
    }
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        GoogleMap1.Markers[0].Latitude = GoogleMap1.Latitude;        
        GoogleMap1.Markers[0].Longitude = GoogleMap1.Longitude;
        GoogleMap1.Markers[0].OpenInfoWindowHtml("<h4 > Siêu thị máy tính 3T</h4><h5> Địa chỉ : Hà Trì - Hà Cầu - Hà Nội<br/>Điện thoại: 04 33553355 - Fax: 04 33554862 - Email:truongnt90@gmail.com</h5>");
    }
}
