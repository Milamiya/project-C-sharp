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

public partial class Manages_ThemTaiKhoan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["Login"] == null)
            {
                Response.Redirect("~/Manages/DangNhap.aspx");
            }
        }
    }
    DataClassesDataContext db = new DataClassesDataContext();
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Manage sc = new Manage();
        sc.AccountID = txtPersonPostNewCode.Text;
        sc.AccountPass = txtPassWord.Text;
        sc.Email = txtEmail.Text;
        sc.FullName = txtName.Text;
        sc.BirthDay = DateTime.Parse(txtBirthDay.Text);
        if (rdMale.Checked == true)
        {
            sc.Gender = "Nam";
        }
        else
            sc.Gender = "Nữ";
        sc.PhoneNumber = txtPhoneNumber.Text;
        sc.Address = txtHomeTown.Text;

        db.Manages.InsertOnSubmit(sc);
        db.SubmitChanges();

        Response.Redirect(@"/WebVatLieuXayDung/Manages/QuanLyTaiKhoan.aspx");
    }
}
