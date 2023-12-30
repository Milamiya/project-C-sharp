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

public partial class DangKy : System.Web.UI.Page
{
    private void LoadNgay()
    {
        for (int i = 1; i < 32; i++)
        {
            droNgay.Items.Add(i.ToString());
        }
        for (int i = 1; i < 13; i++)
        {
            droThang.Items.Add(i.ToString());
        }

        for (int i = DateTime.Now.Year - 5; i > 1910; i--)
        {
            DropNam.Items.Add(i.ToString());
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LoadNgay();
    }
    DataClassesDataContext db = new DataClassesDataContext();
    protected void btnDangKy_Click(object sender, ImageClickEventArgs e)
    {
        Accounts1 ac = new Accounts1();
        ac.AcountName = txtTaiKhoan.Text;
        ac.Pass = txtMatKhau.Text;
        if (rdoGioiTinh.Items[0].Selected == true)
        {
            ac.Gender = "Nam";
        }
        else
            ac.Gender = "Nữ";
        ac.BirthDay = DateTime.Parse(droNgay.Text + "/" + droThang.Text + "/" + DropNam.Text);
        ac.HomeTown = txtDiaChi.Text;
        ac.Email = txtEmail.Text + groEmail.Text;
        db.Accounts1s.InsertOnSubmit(ac);
        db.SubmitChanges();
        Response.Redirect("/WebVatLieuXayDung/ThanhCong.aspx");
    }

}
