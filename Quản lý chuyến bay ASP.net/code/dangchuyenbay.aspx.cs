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

public partial class dangchuyenbay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        AccessDataSource AccessDataSource1 = new AccessDataSource();
        AccessDataSource1.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        AccessDataSource1.InsertCommandType = SqlDataSourceCommandType.Text;
        AccessDataSource1.InsertCommand = "Insert into chuyenbay values (@macb,@tencb,@vept,@vetg,@hinh,@ttintomtat,@ngaydang,@tam,@chin)";
        AccessDataSource1.InsertParameters.Add("macb", TypeCode.String, TextBox1.Text);
        AccessDataSource1.InsertParameters.Add("tencb", TypeCode.String, TextBox2.Text);
        AccessDataSource1.InsertParameters.Add("vept", TypeCode.String, TextBox3.Text);
        AccessDataSource1.InsertParameters.Add("vetg", TypeCode.String, DropDownList1.SelectedItem.Value.ToString());
        AccessDataSource1.InsertParameters.Add("hinh", TypeCode.String, DropDownList2.SelectedItem.Value.ToString());
        AccessDataSource1.InsertParameters.Add("ttintomtat", TypeCode.String, TextBox6.Text);
        AccessDataSource1.InsertParameters.Add("ngaydang", TypeCode.String, TextBox7.Text);
        AccessDataSource1.InsertParameters.Add("tam", TypeCode.String, TextBox8.Text);
        AccessDataSource1.InsertParameters.Add("chin", TypeCode.String, TextBox9.Text);
        AccessDataSource1.Insert();
        Response.Redirect("dangchuyenbaythanhcong.aspx");
    }
}
