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
using System.IO;
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
    clsDatabase cls = new clsDatabase();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {            
            LoadData();         
        }
    }
    public void LoadData()
    {
        DataTable dt;
        DataSet ds;
        SqlDataAdapter sqlDa;
        int sobantintrongtrang = 3;
        string truong = Request.QueryString["ProductID"];
        string tukhoa = ddlTuKhoa.SelectedValue;
        dt = cls.LoadDuLieuPKN("select * from tbProduct where " + tukhoa + " in ( select " + tukhoa + " from tbProduct where ProductID='" + truong + "') and ProductID not in(select '" + truong + "' from tbProduct)");
        lbTongsobantin.Text = dt.Rows.Count.ToString();
        int sotrang = dt.Rows.Count % sobantintrongtrang == 0 ? dt.Rows.Count / sobantintrongtrang : dt.Rows.Count / sobantintrongtrang + 1;
        lbSobantintrongtrang.Text = Convert.ToString(sotrang);        
        int bantin = int.Parse(lbBanTin.Text);
        if (bantin <= sotrang)
        {
            ds = cls.GetDataSet();
            sqlDa = cls.GetDataAdapter();
            sqlDa.Fill(ds, (bantin - 1) * sobantintrongtrang, sobantintrongtrang, "tb");
            dlSPLienQuan.DataSource = ds.Tables["tb"];
            dlSPLienQuan.DataBind();            
        }
        if (bantin == sotrang) lkbNext.Enabled = false;
        if (bantin == 1)
        {
            lkbPreview.Enabled = false;
            lkbNext.Enabled = true;
        }
        else lkbPreview.Enabled = true;
    }
   
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "GioHang")
        {
            DataTable dt;
            clsDatabase cls = new clsDatabase();
            if (Session["GioHang"] == null) dt = cls.GetDataTable();
            else dt = (DataTable)Session["GioHang"];
            string strProductID, strProductName;
            int strPrice;
            int strNumber, strTotal;
            LinkButton lbt = new LinkButton();
            Label lb = new Label();
            //Tên sản phẩm
            lb = (Label)e.Item.FindControl("lbtProductName");
            strProductName = lb.Text;
            //Mã sản phẩm
            strProductID = cls.LoadDuLieu("select ProductID from tbProduct where ProductName='" + strProductName + "'", 0);
            //Giá
            lb = (Label)e.Item.FindControl("lbPrice");
            strPrice = int.Parse(lb.Text);
            //Số lượng
            strNumber = 1;
            //Tổng tiền
            strTotal = strNumber * strPrice;
            cls.DienVaoBang(dt, strProductID, strProductName, strPrice, strNumber, strTotal);
            Session["GioHang"] = dt;
            Response.Redirect("Cart.aspx");
        }
    }
   
    protected void DDL1_SelectedIndexChanged(object sender, EventArgs e)
    {       
        lbBanTin.Text = "1";     
        LoadData();        
    }
    protected void lkbNext_Click(object sender, EventArgs e)
    {
        lbBanTin.Text = (int.Parse(lbBanTin.Text) + 1).ToString();
        LoadData();
    }
    protected void lkbPreview_Click(object sender, EventArgs e)
    {
        lbBanTin.Text = (int.Parse(lbBanTin.Text) - 1).ToString();
        LoadData();
    }
}
