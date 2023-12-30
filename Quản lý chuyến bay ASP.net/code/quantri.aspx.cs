using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class quantri : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AccessDataSource vd3 = new AccessDataSource();
        vd3.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        vd3.SelectCommandType = SqlDataSourceCommandType.Text;
        vd3.SelectCommand = "Select * from chuyenbay";
        GridView1.DataSource = vd3;
        GridView1.DataBind();
        
    }
         protected void Gridview1_OnRowDeleting(object sender,GridViewDeleteEventArgs e)
        {
        AccessDataSource vd2 = new AccessDataSource();
        vd2.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        vd2.DeleteCommandType = SqlDataSourceCommandType.Text;
        vd2.DeleteCommand = "Delete from chuyenbay where macb=@TS";
        vd2.DeleteParameters.Add("TS", TypeCode.String, GridView1.Rows[e.RowIndex].Cells[1].Text);
        vd2.Delete();
        AccessDataSource vd3 = new AccessDataSource();
        vd3.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        vd3.SelectCommandType = SqlDataSourceCommandType.Text;
        vd3.SelectCommand = "Select * from chuyenbay";
        GridView1.DataSource = vd3;
        GridView1.DataBind();
    }
    protected void Gridview1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        //phan trang + page index changing ben trang aspx
        GridView1.PageIndex = e.NewPageIndex;
        AccessDataSource vd = new AccessDataSource();
        vd.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        vd.SelectCommandType = SqlDataSourceCommandType.Text;
        vd.SelectCommand = "Select * from chuyenbay";
        GridView1.DataSource = vd;
        GridView1.DataBind();
    }

    
}
