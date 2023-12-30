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

public partial class GiaoDien_NhapNCC : System.Web.UI.Page
{
    clsThaoTac cls = new clsThaoTac();
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnNhap_Click(object sender, EventArgs e)
    {
        Manufacture mn = new Manufacture();
        mn.ManufactureName = txtTenNSX.Text;
        mn.Address = txtDiachi.Text;
        mn.Email = txtEmail.Text;
        mn.Logo = FupLogo.PostedFile.FileName;
        db.Manufactures.InsertOnSubmit(mn);
        db.SubmitChanges();
    }
    void xoacontrol()
    {
        txtTenNSX.Text = "";
        txtDiachi.Text = "";
        txtEmail.Text = "";

    }
}
