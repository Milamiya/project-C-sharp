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
using System.Threading;
using System.Globalization;
public partial class Default2 : System.Web.UI.Page
{
    protected override void InitializeCulture()
    {
        string ui = Request.QueryString["lancode"];
        if (string.IsNullOrEmpty(ui))
            ui = "vi";
        string culture = ui == "en" ? "en-us" : ui + "-" + "VN";
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
        base.InitializeCulture();
    }
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
    }
    clsDatabase cls = new clsDatabase();
    protected void Page_Load(object sender, EventArgs e)
    {
        lbThongBao.Visible = false;
    }
    protected void btDangKy_Click(object sender, EventArgs e)
    {
        string gioitinh="";
        if(rbNam.Checked)gioitinh="Nam";
        else gioitinh="Nữ";
        if (cls.KiemTraMaTrung("select count(*) from tbCustomer where Email=N'" + txtEmail.Text + "'")==true)
        {
            if (txtMK.Text == txtMK2.Text)
            {
                cls.ThucThiSQL("Insert into tbCustomer values('" + txtEmail.Text + "','" + txtMK.Text + "','" + txtHoTen.Text + "','" + gioitinh + "','" + txtDiaChi.Text + "')");
                Response.Write("<script language='javascript'>alert('" + "Chúc mừng bạn đã đăng ký thành công! Để nâng cao tính bảo mật vui lòng đăng nhập website" + "')</script>");
            }
            else
            {
                Response.Write("<script language='javascript'>alert('" + "Trường mật khẩu không trùng nhau! Nhập lại" + "')</script>");
            }
        }
        else
        {
            lbThongBao.Visible = true;
        }
    }
}
