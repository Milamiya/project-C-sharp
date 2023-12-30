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

public partial class timchuyenbay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
            AccessDataSource vd3 = new AccessDataSource();
            vd3.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
            vd3.SelectCommandType = SqlDataSourceCommandType.Text;
            vd3.SelectCommand = "Select * from chuyenbay where noidi=@noidi and noiden=@noiden and ngaydi=@ngaydi";
            vd3.SelectParameters.Add("noidi", TypeCode.String, DropDownList1.SelectedItem.Value.ToString());
            vd3.SelectParameters.Add("noiden", TypeCode.String, DropDownList2.SelectedItem.Value.ToString());
            vd3.SelectParameters.Add("ngaydi", TypeCode.String, Calendar1.SelectedDate.DayOfWeek.ToString());
            GridView1.DataSource = vd3;
            GridView1.DataBind();
            
        
        if (RadioButtonList1.SelectedValue == "khuhoi")
        {
            AccessDataSource vd2 = new AccessDataSource();
            vd2.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
             vd2.SelectCommandType = SqlDataSourceCommandType.Text;
             vd2.SelectCommand = "Select * from chuyenbay where noidi=@noidi and noiden=@noiden and ngaydi=@ngaydi";
             vd2.SelectParameters.Add("noidi", TypeCode.String, DropDownList2.SelectedItem.Value.ToString());
             vd2.SelectParameters.Add("noiden", TypeCode.String, DropDownList1.SelectedItem.Value.ToString());
             vd2.SelectParameters.Add("ngaydi", TypeCode.String, Calendar2.SelectedDate.DayOfWeek.ToString());
             GridView2.DataSource = vd2;
             GridView2.DataBind();
        }
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(RadioButtonList1.SelectedValue=="motchieu")
        Calendar2.Visible=false;
        Label6.Visible = false;
        if(RadioButtonList1.SelectedValue=="khuhoi")
        Calendar2.Visible=true;
    }
}
