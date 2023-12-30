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

public partial class hello_Default : System.Web.UI.Page
{
    clsDatabase cls = new clsDatabase();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btLuu_Click(object sender, EventArgs e)
    {
        string duongdananh = FileUpload1.FileName;
        cls.ThucThiSQL("Insert into tbProduct values('" + txtTenSP.Text + "','" + duongdananh + "','" + txtKhuyenMai.Text + "','" + txtGia.Text + "','" + txtSL.Text + "','" + ddlNSX.SelectedValue + "','" + txtBVSL.Text + "','" + txtRam.Text + "','" + txtOcung.Text + "','" + txtHDH.Text + "','" + txtManHinh.Text + "','" + txtCamera.Text + "','" + txtCard.Text + "','" + txtPin.Text + "','" + txtKhoiLuong.Text + "','" + txtXuatSu.Text + "','" + txtBaoHanh.Text + "')");
        Response.Write("<script language='javascript'>alert('" + "Lưu thông tin thành công!" + "')</script>");
    }
}
