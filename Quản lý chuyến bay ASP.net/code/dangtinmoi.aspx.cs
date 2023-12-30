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

public partial class dangtinmoi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Calendar1.SelectedDate = DateTime.Today;
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        AccessDataSource AccessDataSource1 = new AccessDataSource();
        AccessDataSource1.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        AccessDataSource1.InsertCommandType = SqlDataSourceCommandType.Text;
        AccessDataSource1.InsertCommand = "Insert into tinmoi values (@macb,@tencb,@vept,@vetg,@hinh,@ttintomtat,@ngaydang,@lichbay,@giobay,@ttinchitiet)";
        AccessDataSource1.InsertParameters.Add("macb", TypeCode.String, TextBox1.Text);
        AccessDataSource1.InsertParameters.Add("tencb", TypeCode.String, TextBox2.Text);
        AccessDataSource1.InsertParameters.Add("vept", TypeCode.String, TextBox3.Text);
        AccessDataSource1.InsertParameters.Add("vetg", TypeCode.String, TextBox4.Text);
        AccessDataSource1.InsertParameters.Add("hinh", "hinhtintuc\\" + FileUpload1.FileName);
        AccessDataSource1.InsertParameters.Add("ttintomtat", TypeCode.String, TextBox5.Text);
        AccessDataSource1.InsertParameters.Add("ttinchitiet", TypeCode.String, TextBox6.Text);
        AccessDataSource1.InsertParameters.Add("ngaydang", TypeCode.String, Calendar1.TodaysDate.ToShortDateString());
        AccessDataSource1.InsertParameters.Add("lichbay", TypeCode.String, DropDownList1.SelectedItem.Value.ToString());
        AccessDataSource1.InsertParameters.Add("giobay", TypeCode.String, DropDownList2.SelectedItem.Value.ToString());
        AccessDataSource1.Insert();
        Response.Redirect("dangtinmoithanhcong.aspx");
    }
}
