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
public partial class _Default : System.Web.UI.Page
{
    clsDatabase cls = new clsDatabase();
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
        Panel2.Visible = false;
        LoadData();
        //string truong = Request.QueryString["ComponentName"];
        //DataList1.DataSource = cls.LoadDuLieuPKN("select tbComponentDetails.ComponentDetailsID, tbComponentDetails.Parameter, tbComponentDetails.ImageURL, tbComponentDetails.Price FROM tbComponentDetails INNER JOIN tbComponents ON tbComponentDetails.ComponentID = tbComponents.ComponentID AND tbComponents.ComponentName = '" + truong + "'");
        //DataList1.DataBind();
        //LoadData();

    }
    
    protected void Timkiem_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = true;
        string truong = Request.QueryString["ComponentName"];
        DataList2.DataSource = cls.LoadDuLieuPKN("select cd.* from tbComponentDetails cd, tbComponents c where cd.ComponentID=c.ComponentID and c.ComponentName = N'"+truong+"%' or cd.Capacity like '"+txtTimKiem.Text+"%'");
        DataList2.DataBind();
    }

    //public void LoadData()
    //{
    //    string truong = Request.QueryString["ComponentName"];
    //    switch (ddlSapXep.SelectedIndex)
    //    {
    //        case 0: break;
    //        case 1:
    //            SqlDataSource1.SelectCommand = "select tbComponentDetails.ComponentDetailsID, tbComponentDetails.Parameter, tbComponentDetails.ImageURL, tbComponentDetails.Price FROM tbComponentDetails INNER JOIN tbComponents ON tbComponentDetails.ComponentID = tbComponents.ComponentID AND tbComponents.ComponentName = '" + truong + "' order by tbComponentDetails.Price asc";
    //            SqlDataSource1.DataBind();
    //            DataList1.DataBind();
    //            break;
    //        case 2:
    //            SqlDataSource1.SelectCommand = "select tbComponentDetails.ComponentDetailsID, tbComponentDetails.Parameter, tbComponentDetails.ImageURL, tbComponentDetails.Price FROM tbComponentDetails INNER JOIN tbComponents ON tbComponentDetails.ComponentID = tbComponents.ComponentID AND tbComponents.ComponentName = '" + truong + "' order by tbComponentDetails.Price desc ";
    //            SqlDataSource1.DataBind();
    //            DataList1.DataBind();
    //            break;
    //        default:
    //            SqlDataSource1.SelectCommand = "select tbComponentDetails.ComponentDetailsID, tbComponentDetails.Parameter, tbComponentDetails.ImageURL, tbComponentDetails.Price FROM tbComponentDetails INNER JOIN tbComponents ON tbComponentDetails.ComponentID = tbComponents.ComponentID AND tbComponents.ComponentName = '" + truong + "'";
    //            SqlDataSource1.DataBind();
    //            break;
    //    }
    //}
    public void LoadData()
    {
        string truong = Request.QueryString["ComponentName"];
        DataList1.DataSource = cls.LoadDuLieuPKN("select tbComponentDetails.ComponentDetailsID, tbComponentDetails.Parameter, tbComponentDetails.ImageURL, tbComponentDetails.Price FROM tbComponentDetails INNER JOIN tbComponents ON tbComponentDetails.ComponentID = tbComponents.ComponentID AND tbComponents.ComponentName = '" + truong + "'");
        DataList1.DataBind();        
        switch (ddlSapXep.SelectedIndex)
        {
            case 0:
                DataList1.DataSource = cls.LoadDuLieuPKN("select tbComponentDetails.ComponentDetailsID, tbComponentDetails.Parameter, tbComponentDetails.ImageURL, tbComponentDetails.Price FROM tbComponentDetails INNER JOIN tbComponents ON tbComponentDetails.ComponentID = tbComponents.ComponentID AND tbComponents.ComponentName = '" + truong + "'");
                DataList1.DataBind();
                break;
            case 1:
                DataList1.DataSource = cls.LoadDuLieuPKN("select tbComponentDetails.ComponentDetailsID, tbComponentDetails.Parameter, tbComponentDetails.ImageURL, tbComponentDetails.Price FROM tbComponentDetails INNER JOIN tbComponents ON tbComponentDetails.ComponentID = tbComponents.ComponentID AND tbComponents.ComponentName = '" + truong + "' order by tbComponentDetails.Price asc ");
                DataList1.DataBind();
                break;
            case 2:
                DataList1.DataSource = cls.LoadDuLieuPKN("select tbComponentDetails.ComponentDetailsID, tbComponentDetails.Parameter, tbComponentDetails.ImageURL, tbComponentDetails.Price FROM tbComponentDetails INNER JOIN tbComponents ON tbComponentDetails.ComponentID = tbComponents.ComponentID AND tbComponents.ComponentName = '" + truong + "' order by tbComponentDetails.Price desc ");
                DataList1.DataBind();
                break;
                break;
            default:
                SqlDataSource1.SelectCommand = "select tbComponentDetails.ComponentDetailsID, tbComponentDetails.Parameter, tbComponentDetails.ImageURL, tbComponentDetails.Price FROM tbComponentDetails INNER JOIN tbComponents ON tbComponentDetails.ComponentID = tbComponents.ComponentID AND tbComponents.ComponentName = '" + truong + "'";
                SqlDataSource1.DataBind();
                break;
        }
    }
}
