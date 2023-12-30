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

public partial class demo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        string password = TextBox2.Text;
        password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
        AccessDataSource vd1 = new AccessDataSource();
        vd1.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        vd1.InsertCommandType = SqlDataSourceCommandType.Text;
        vd1.InsertCommand = "Insert into Table1 values (@tendn,@matkhau,@email,@hoten,@ngaysinh,@gioitinh,@noio,@nghenghiep,@loaind)";
        vd1.InsertParameters.Add("tendn", TypeCode.String, TextBox1.Text);
        vd1.InsertParameters.Add("matkhau", TypeCode.String, password);
        vd1.InsertParameters.Add("email", TypeCode.String, TextBox4.Text);
        vd1.InsertParameters.Add("hoten", TypeCode.String, TextBox5.Text);
        vd1.InsertParameters.Add("ngaysinh", TypeCode.String, TextBox6.Text);
        vd1.InsertParameters.Add("gioitinh", TypeCode.String, DropDownList1.SelectedItem.Value.ToString());
        vd1.InsertParameters.Add("noio", TypeCode.String, TextBox8.Text);
        vd1.InsertParameters.Add("nghenghiep", TypeCode.String, TextBox9.Text);
        vd1.InsertParameters.Add("loaind", TypeCode.String, DropDownList2.SelectedItem.Value.ToString());
        vd1.Insert();
        Response.Redirect("dkthanhcong.aspx");
    }
}
