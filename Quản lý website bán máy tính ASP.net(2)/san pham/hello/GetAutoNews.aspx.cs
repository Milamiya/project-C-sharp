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
using System.Net;
using System.IO;
using System.Xml;
using System.Text;
using System.Text.RegularExpressions;
public partial class hello_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //LoadData(GridView1, "http://vnexpress.net/rss/gl/the-gioi.rss");
            //LoadData(GridView1, "http://vnexpress.net/rss/gl/kinh-doanh.rss");
            //LoadData(GridView1, "http://vnexpress.net/rss/gl/the-thao.rss");
            //LoadData(GridView1, "http://vnexpress.net/rss/gl/khoa-hoc.rss");
            LoadData(GridView1, "http://vnexpress.net/rss/gl/the-thao.rss");
        }
        catch { }
    }
    private void LoadData(GridView grbName, string LienKet)
    {

        grbName.DataSource = BindRSSItem(LienKet);
        grbName.DataBind();
    }
    private DataTable CreateDataTable()
    {
        DataTable myDataTable = new DataTable();
        DataColumn myDataColumn;

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "title";
        myDataTable.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "link";
        myDataTable.Columns.Add(myDataColumn);

        myDataColumn = new DataColumn();
        myDataColumn.DataType = Type.GetType("System.String");
        myDataColumn.ColumnName = "description";
        myDataTable.Columns.Add(myDataColumn);
        return myDataTable;
    }
    private void AddDataToTable(string Title, string link, string Descriptions, DataTable myTable)
    {
        DataRow row;
        row = myTable.NewRow();
        row["title"] = Title;
        row["Link"] = link;
        row["Description"] = Descriptions;
        myTable.Rows.Add(row);
    }
    public DataTable BindRSSItem(string rssURL)
    {
        DataTable myDataTable = CreateDataTable();
        try
        {
            WebRequest myRequest = WebRequest.Create(rssURL);
            WebResponse myResponse = myRequest.GetResponse();

            Stream rssStream = myResponse.GetResponseStream();
            XmlDocument rssDoc = new XmlDocument();
            rssDoc.Load(rssStream);
            XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");
            string title = "";
            string link = "";
            string description = "";
            for (int i = 0; i < rssItems.Count; i++)
            {
                XmlNode rssDetail;
                rssDetail = rssItems.Item(i).SelectSingleNode("title");
                if (rssDetail != null)
                {
                    title = rssDetail.InnerText;
                }
                else
                {
                    title = "";
                }
                rssDetail = rssItems.Item(i).SelectSingleNode("link");
                if (rssDetail != null)
                {
                    link = rssDetail.InnerText;
                }
                else
                {
                    link = "";
                }

                rssDetail = rssItems.Item(i).SelectSingleNode("description");
                if (rssDetail != null)
                {
                    description = rssDetail.InnerText;
                }
                else
                {
                    description = "";
                }
                AddDataToTable(title, link, description, myDataTable);
            }
        }
        catch { }
        return myDataTable;
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (DropDownList1.SelectedIndex)
        {
            
            case 0:
                DataTable dt1 = BindRSSItem("http://dantri.com.vn/the-thao.rss");
                GridView1.DataSource = dt1;
                GridView1.DataBind();
                break;
            case 1:
                DataTable dt2 = BindRSSItem("http://dantri.com.vn/thegioi.rss");
                GridView1.DataSource = dt2;
                GridView1.DataBind();
                break;

            case 2:
                DataTable dt3 = BindRSSItem("http://dantri.com.vn/kinhdoanh.rss");
                GridView1.DataSource = dt3;
                GridView1.DataBind();
                break;
            case 3:
                DataTable dt4 = BindRSSItem("http://dantri.com.vn/otoxemay.rss");
                GridView1.DataSource = dt4;
                GridView1.DataBind();
                break;
        }
    }
}
