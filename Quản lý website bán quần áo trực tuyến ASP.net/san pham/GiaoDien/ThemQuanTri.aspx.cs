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

public partial class GiaoDien_ThemQuanTri : System.Web.UI.Page
{

    clsDatabase cls = new clsDatabase();

    protected void Page_Load(object sender, EventArgs e)
    {
        ListItem listItem;
        listItem = new ListItem("cập nhật", "1");
        drlQuyen.Items.Add(listItem);
        listItem = new ListItem("Xuất hàng", "2");
        drlQuyen.Items.Add(listItem);
        listItem = new ListItem("Quản lý chung", "3");
        drlQuyen.Items.Add(listItem);

    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        Response.Write(drlQuyen.Text);
        //Nhập mới User
        try
        {
            cls.ThucThiSQL("insert into QuanTri values('" + txtTenDN.Text + "','" + txtMatKhau.Text + "','" + drlQuyen.Text + "')");
            //lbtbao.Visible = true;
            //lbtbao.Text = "Cập nhật thành công!";
        }
        catch (Exception ex)
        {
            //lbtbao.Text = "Tài khoản này đã có trong cơ sở dữ liệu!";
            //lbtbao.Visible = true;
        }
        //Xoa trang
        txtTenDN.Text = "";
        txtMatKhau.Text = "";
        //drlQuyen.Text = "";
    }
}
