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
public partial class hello_Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Visible = false;
        LoadData();
    }
    clsDatabase cls = new clsDatabase();
    public void LoadData()
    {
        DataTable dt = cls.LoadDuLieuPKN("select ProductName, Manufacturer, Number from tbProduct where Manufacturer='"+DropDownList1.SelectedValue+"' group by ProductName, Manufacturer, Number order by Manufacturer compute min(Number) by Manufacturer");        
        for (int i = 0; i < dt.Rows.Count; i++)
        {            
            int max = int.Parse(dt.Rows[0][2].ToString());
            if (max < Convert.ToInt32(dt.Rows[i][2].ToString()))
            {
                max = Convert.ToInt32(dt.Rows[i][2].ToString());
                lblSoLuong.Text = max.ToString();
            }
            lblSoLuong.Text = max.ToString();
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();
        string chuoi = Request["Label3"];
        //int so = int.Parse(chuoi.ToString());
        DataTable tb = cls.LoadDuLieuPKN("select * from tbProduct where Number='" + lblSoLuong.Text + "' and Manufacturer='" + DropDownList1.SelectedValue + "'");
        DataList1.DataSource = tb;
        DataList1.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label2.Visible = true;
        LoadData();
    }
}
