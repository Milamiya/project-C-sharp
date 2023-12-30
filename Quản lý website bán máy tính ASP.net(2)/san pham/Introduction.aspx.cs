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
using System.Text;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {        
    }
    
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        //string x = DropDownList3.SelectedValue;
        //DropDownList4.Text = x;
        //Label8.Text = x;
    }
    protected void btnXuat_Click(object sender, EventArgs e)
    {
        xuatWord();
    }
    private void xuatWord()
    {
        HtmlForm form = new HtmlForm();
        string filename = DateTime.Now.ToString("yyyy.MM.dd.hh.mm.ss") + ".doc";

        string attachment = "attachment; filename=" + filename;
        Response.ClearContent();
        Response.AddHeader("content-disposition", attachment);
        Response.ContentType = "application/ms-word";
        StringWriterWithEncoding stringWrite = new StringWriterWithEncoding(Encoding.UTF8);
        HtmlTextWriter htw = new HtmlTextWriter(stringWrite);
        Table1.RenderControl(htw);
        Response.Charset = "UTF-8";
        Response.ContentEncoding = Encoding.UTF8;
        Response.Write(stringWrite.ToString());
        Response.End();
        //logDuLieu(filename, Convert.ToString(Request.QueryString["QuanLyDeThi_MaDT"]));
    }
    public class StringWriterWithEncoding : System.IO.StringWriter
    {
        private Encoding _encoding;

        public StringWriterWithEncoding(Encoding encoding): base()
        {
            _encoding = encoding;
        }

        public override Encoding Encoding
        {
            get
            {
                return _encoding;
            }
        }
    }
}
