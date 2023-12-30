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

public partial class khachsan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        AccessDataSource vd3 = new AccessDataSource();
        vd3.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        vd3.SelectCommandType = SqlDataSourceCommandType.Text;
        vd3.SelectCommand = "Select * from khachsan where thanhpho=@noidi and hang=@noiden";
        vd3.SelectParameters.Add("noidi", TypeCode.String, DropDownList1.SelectedItem.Value.ToString());
        vd3.SelectParameters.Add("noiden", TypeCode.String, DropDownList2.SelectedItem.Value.ToString());
        GridView1.DataSource = vd3;
        GridView1.DataBind();
    }
}
