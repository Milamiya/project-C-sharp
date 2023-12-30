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

public partial class doimatkhau : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string password = TextBox2.Text;
        password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
        string password1 = TextBox3.Text;
        password1 = FormsAuthentication.HashPasswordForStoringInConfigFile(password1, "SHA1");
        AccessDataSource vd3 = new AccessDataSource();
        vd3.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        vd3.SelectCommandType = SqlDataSourceCommandType.Text;
        vd3.SelectCommand = "Select Matkhau from Table1 where matkhau=@mk and tendn=@tdn";
        vd3.SelectParameters.Add("mk", TypeCode.String, password);
        vd3.SelectParameters.Add("mk", TypeCode.String, TextBox1.Text);
        GridView1.DataSource = vd3;
        GridView1.DataBind();
        GridView1.Visible = false;

        if (GridView1.Rows.Count == 0)
        {
            Label4.Text = "The information not correct!";
        }
        else
        {
            AccessDataSource vd2 = new AccessDataSource();
            vd2.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
            vd2.UpdateCommandType = SqlDataSourceCommandType.Text;
            vd2.UpdateCommand = "Update Table1 set matkhau=@TS_mk where matkhau=@TS_ten and tendn=@TS_dn";
            vd2.UpdateParameters.Add("TS_mk", TypeCode.String, password1);
            vd2.UpdateParameters.Add("TS_ten", TypeCode.String, password);
            vd2.UpdateParameters.Add("TS_dn", TypeCode.String, TextBox1.Text);
            vd2.Update();
            Response.Redirect("doimkthanhcong.aspx");
        }
    }
}
