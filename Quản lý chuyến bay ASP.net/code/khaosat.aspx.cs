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

public partial class khaosat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        AccessDataSource AccessDataSource1 = new AccessDataSource();
        AccessDataSource1.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        AccessDataSource1.InsertCommandType = SqlDataSourceCommandType.Text;
        AccessDataSource1.InsertCommand = "Insert into khaosat values (@macb,@tencb,@vept,@vetg,@hinh,@ttintomtat,ttinchitiet,@ngaydang)";
        AccessDataSource1.InsertParameters.Add("macb", TypeCode.String, TextBox1.Text);
        AccessDataSource1.InsertParameters.Add("tencb", TypeCode.String, TextBox2.Text);
        AccessDataSource1.InsertParameters.Add("vept", TypeCode.String, TextBox3.Text);
        AccessDataSource1.InsertParameters.Add("vetg", TypeCode.String, DropDownList1.SelectedItem.Value.ToString());
        AccessDataSource1.InsertParameters.Add("hinh", TypeCode.String, DropDownList2.SelectedItem.Value.ToString());
        AccessDataSource1.InsertParameters.Add("ttintomtat", TypeCode.String, DropDownList3.SelectedItem.Value.ToString());
        AccessDataSource1.InsertParameters.Add("ttinchitiet", TypeCode.String, DropDownList4.SelectedItem.Value.ToString());
        AccessDataSource1.InsertParameters.Add("ngaydang", TypeCode.String, TextBox4.Text);
        AccessDataSource1.Insert();
        Response.Redirect("ksthanhcong.aspx");
    }
}
