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

public partial class Manages_SuaTaiKhoan : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["Login"] == null)
            {
                Response.Redirect("~/Manages/DangNhap.aspx");
            }
            else
            {
                lbTaiKhoan.Text = Request.QueryString["aID"].ToString();
                var f = from h in db.Manages
                        where h.AccountID == Request.QueryString["aID"].ToString()
                        select h;
                foreach (var item in f)
                {
                    txtName.Text = item.FullName;
                    txtBirthDay.Text = item.BirthDay.ToString().Split(' ')[0].ToString();
                    txtHomeTown.Text = item.Address;
                    if (item.Gender == "Nam")
                    {
                        rdMale.Checked = true;
                    }
                    else
                        rdFemale.Checked = true;
                    txtPhoneNumber.Text = item.PhoneNumber;
                    txtEmail.Text = item.Email;
                    break;
                }
            }
        }
    }
    protected void btnUpdateInfomation_Click(object sender, EventArgs e)
    {
        Manage sc = db.Manages.SingleOrDefault(s => s.AccountID == Request.QueryString["aID"].ToString());
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
        db.SubmitChanges();
        Response.Redirect(@"/WebVatLieuXayDung/Manages/QuanLyTaiKhoan.aspx");
    }
}
