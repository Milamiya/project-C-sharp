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
using System.IO;
using System.Text;
public partial class Default2 : System.Web.UI.Page
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
        Panel3.Visible = false;
        if (IsPostBack == false)
        {
            if (Session["GioHang"] != null)
            {
                DataTable dt = (DataTable)Session["GioHang"];
                if (dt.Rows.Count > 0)
                {
                    BindData();
                }
            }
        }
    }
    public void RemoveRow()
    {
        for (int i = 0; i < gvThanhToan.Rows.Count; i++)
        {
            gvThanhToan.DeleteRow(i);
        }
    }
    public void BindData()
    {
        if (gvThanhToan.Rows.Count > 0) RemoveRow();
        DataTable dt = (DataTable)Session["GioHang"];
        gvThanhToan.DataSource = dt;
        gvThanhToan.DataBind();
    }   
    protected void btDatMuaHang_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        DataTable dt = (DataTable)Session["GioHang"];       
        foreach (DataRow dr in dt.Rows)
        {
            cls.ThucThiSQL("Update tbProduct set Number=Number - '"+dr[3].ToString()+"' where ProductID='"+dr[0].ToString()+"'");
        }
    }
    protected void btInHoaDon_Click(object sender, EventArgs e)
    {                 
        //xuatWord();
    }
    protected void btTiepTuc_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = true;
        lbTenKH.Text = txtTenKH.Text;
        lbDiaChi.Text = txtDiaChi.Text;
        lbEmail.Text = txtEmail.Text;
        lbSDT.Text = txtSDT.Text;
        lbDĐ.Text = txtDĐ.Text;
    }
    //private void xuatWord()
    //{
    //    HtmlForm form = new HtmlForm();
    //    string filename = DateTime.Now.ToString("yyyy.MM.dd.hh.mm.ss") + ".doc";

    //    string attachment = "attachment; filename=" + filename;
    //    Response.ClearContent();
    //    Response.AddHeader("content-disposition", attachment);
    //    Response.ContentType = "application/ms-word";
    //    StringWriterWithEncoding stringWrite = new StringWriterWithEncoding(Encoding.UTF8);
    //    HtmlTextWriter htw = new HtmlTextWriter(stringWrite);
    //    Table1.RenderControl(htw);
    //    Response.Charset = "UTF-8";
    //    Response.ContentEncoding = Encoding.UTF8;
    //    Response.Write(stringWrite.ToString());
    //    Response.End();
    //    //logDuLieu(filename, Convert.ToString(Request.QueryString["Maytinh_MaDT"]));
    //}
    //public class StringWriterWithEncoding : System.IO.StringWriter
    //{
    //    private Encoding _encoding;

    //    public StringWriterWithEncoding(Encoding encoding)
    //        : base()
    //    {
    //        _encoding = encoding;
    //    }

    //    public override Encoding Encoding
    //    {
    //        get
    //        {
    //            return _encoding;
    //        }
    //    }
    //}
}
