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
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;
public partial class _Default : System.Web.UI.Page
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
        //Download source code tai Sharecode.vn
        //SqlConnection sqlCon = new SqlConnection(SqlDataSource1.ConnectionString);
        //sqlCon.Open();
        //SqlCommand sqlCom = new SqlCommand("select count(*) from tbProduct", sqlCon);       
        //lbcount.Text= sqlCom.ExecuteScalar().ToString();
        //lbPageSize.Text = sqlCom.ExecuteScalar().ToString();
        //if (!IsPostBack)
        //{
        //    PhanTrang(1, 3);
        //}
        //PhanTrang(0,1);
    }

    //public void PhanTrang(int x, int y)
    //{

    //    string str = Convert.ToString(Request.QueryString["Manufacturer"]);
    //    SqlConnection sqlCon = new SqlConnection(SqlDataSource1.ConnectionString);
    //    SqlDataAdapter sqlDa = new SqlDataAdapter("select * from tbProduct where Manufacturer= '"+str+"'", sqlCon);
    //    DataSet ds = new DataSet();
    //    sqlDa.Fill(ds, x, y, "tbProduct");
    //    DataList1.DataSource = ds.Tables["tbProduct"].DefaultView;
    //    DataList1.DataBind();
    //    int a = int.Parse(lbPageSize.Text);
    //    if (x == a) lbNext.Enabled = false;
    //    if (x == 0) lbPreview.Enabled = false;
    //}
   
    //protected void lbNext_Click(object sender, EventArgs e)
    //{        
    //    int x = int.Parse(lbCurrentPage.Text);
    //    int y = int.Parse(lbPageSize.Text);
    //    x += 1;
    //    y += 1;
    //    PhanTrang(x, y);
    //    lbCurrentPage.Text = x.ToString();
    //    lbPageSize.Text = y.ToString();
        
    //}
    //protected void lbPreview_Click(object sender, EventArgs e)
    //{
    //    int x = int.Parse(lbCurrentPage.Text);
    //    int y = int.Parse(lbPageSize.Text);
    //    x -= 1;
    //    y -= 1;
    //    PhanTrang(x, y);
    //    lbCurrentPage.Text = x.ToString();
    //    lbPageSize.Text = y.ToString();
    //}
}
