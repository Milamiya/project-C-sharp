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
public partial class hello_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }
    clsDatabase cls = new clsDatabase();
    public void LoadData()
    {
        DataTable dt;
        DataSet ds;
        SqlDataAdapter sqlDa;
        int sobantintrongtrang = 1;
        dt = cls.LoadDuLieuPKN("select * from tbNews");
        lbTongsobantin.Text = dt.Rows.Count.ToString();
        int sotrang = dt.Rows.Count % sobantintrongtrang == 0 ? dt.Rows.Count / sobantintrongtrang : dt.Rows.Count / sobantintrongtrang + 1;
        lbSobantintrongtrang.Text = Convert.ToString(sotrang);
        int bantin = int.Parse(lbBanTin.Text);
        if (bantin <= sotrang)
        {
            ds = cls.GetDataSet();
            sqlDa = cls.GetDataAdapter();
            sqlDa.Fill(ds, (bantin - 1) * sobantintrongtrang, sobantintrongtrang, "tb");
            DataList1.DataSource = ds.Tables["tb"];
            DataList1.DataBind();
        }
        if (bantin == sotrang)
        {
            lkbNext.Enabled = false;
        }
        else
        {
            lkbNext.Enabled = true;
        }
        if (bantin == 1) lkbPreview.Enabled = false;
        else lkbPreview.Enabled = true;
    }
    protected void lkbPreview_Click(object sender, EventArgs e)
    {
        lbBanTin.Text = (int.Parse(lbBanTin.Text) - 1).ToString();
        LoadData(); 
    }
    protected void lkbNext_Click(object sender, EventArgs e)
    {
        lbBanTin.Text = (int.Parse(lbBanTin.Text) + 1).ToString();
        LoadData(); 
    }    
    protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
    {
       
       
    }
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {        
        //LinkButton l = (LinkButton)e.Item.FindControl("lbtXoa");
        //if (l != null)
        //    l.Attributes.Add("onclick", "return confirm('Bạn có chắc muốn xóa bản tin này không?')");        
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "Sua")
        {
            Label lb = (Label)e.Item.FindControl("TitleLabel");
            Session["Newsid"] = lb.Text;
        }
        //else
        if (e.CommandName == "Xoa")
        {
            SqlDataSource1.DeleteParameters.Clear();
            Label lb = (Label)e.Item.FindControl("NewsIDLabel");
            SqlDataSource1.DeleteParameters.Add("NewsID", TypeCode.Int32, lb.Text);
            SqlDataSource1.Delete();
            SqlDataSource1.DataBind();
            DataList1.DataBind();
        }
    }
    protected void lbtSua_Click(object sender, EventArgs e)
    {        
        //Response.Redirect("EditNews.aspx");
    }
}
