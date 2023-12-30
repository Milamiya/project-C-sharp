using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

namespace DoAn4
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        InfoDataContext db = new InfoDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtTendaydu.Focus();
            Label1.Text = "";
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        protected void btnDangky_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                Label1.Text = "Bạn chưa nhập đầy đủ thông tin.";
            }
            else
            {
                tbl_Customer cu = new tbl_Customer();
                cu.User = txtUser.Text;
                cu.Password = txtPass.Text;
                cu.FullName = txtTendaydu.Text;
                cu.Address = txtDiachi.Text + "-" + txtQuanHuyen.Text + "-" + txtTinhThanh.Text + "-" + txtQuocGia.Text;
                cu.Email = txtEmail.Text;
                //cu.Phone = Convert.ToInt32( txtSDT.Text);
                db.tbl_Customers.InsertOnSubmit(cu);
                db.SubmitChanges();

                Response.Redirect("DangNhap.aspx?");
                txtUser.Text = "";
                txtPass.Text = "";
                txtTendaydu.Text = "";
                txtEmail.Text = "";
                txtDiachi.Text = "";
                txtSDT.Text = "";
            }
        }
    }
}
