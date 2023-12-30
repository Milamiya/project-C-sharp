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
using System.Data.SqlClient;
//using System.Web.UI.WebControls.WebParts;

namespace DoAn4.Admin
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
               load();
            if (Session["Username"] != null)
            { }
            else
            {
                Response.Redirect("Login.aspx");
            }
            cb1.Enabled = true;
            cb2.Enabled = true;
            cb3.Enabled = false;
        }

        InfoDataContext db = new InfoDataContext();
        private void load()
        {
            var query = from a in db.tbl_Accounts
                        select a;
            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        void rong()
        {
            txtTaikhoan.Text = "";
            txtPass.Text = "";
        }

        private bool KiemTra(string ma)
        {
            var a = from s in db.tbl_Accounts
                    select new { s.Account};
            foreach (var sub in a)
            {
                if (sub.Account == ma)
                    return false;
            }
            return true;
        }

        private bool Kiemtrarong(string tk, string mk)
        {
            if (tk == "" || mk == "")
            {
                return false;
            }
            return true;
        }

        protected void btnthem_Click(object sender, EventArgs e)
        {
            if (KiemTra(txtTaikhoan.Text))
            {
                if (Kiemtrarong(txtTaikhoan.Text, txtPass.Text) == true)
                {
                    tbl_Account a = new tbl_Account();
                    a.Account = txtTaikhoan.Text;
                    a.Password = txtPass.Text;
                    a.Power = DropDownList1.Text;
                    db.tbl_Accounts.InsertOnSubmit(a);
                    db.SubmitChanges();
                    load();
                    Label1.Text = "Thêm thành công";
                    Label3.Text = "";
                    rong();
                }
                else
                {
                    Label1.Text = "Chưa nhập tài khoản hoặc mật khẩu.";
                    Label3.Text = "";
                }
            }
            else
            {
                Label3.Text = "Tài khoản này đã tồn tại.";
                txtTaikhoan.Focus();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lbTK = (Label)GridView1.Rows[e.RowIndex].FindControl("lbTK");
            tbl_Account a = db.tbl_Accounts.SingleOrDefault(c => c.Account == lbTK.Text);
            db.tbl_Accounts.DeleteOnSubmit(a);
            db.SubmitChanges();
            load();
            txtTaikhoan.Focus();
            Label1.Text = "";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        protected void btnMoi_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThemTaikhoan.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "0")
            {
                cb3.Enabled = true;
            }
            if (DropDownList1.SelectedValue == "1")
            {
                cb1.Enabled = true;
                cb1.Items[0].Selected = true;
                cb1.Items[1].Selected = true;
                cb1.Items[2].Selected = true;
                cb1.Items[3].Selected = true;
                cb1.Items[4].Selected = true;
                cb1.Items[5].Selected = true;
                cb2.Enabled = true;
                cb2.Items[0].Selected = true;
                cb2.Items[1].Selected = true;
                cb2.Items[2].Selected = true;
                cb2.Items[3].Selected = true;
                cb2.Items[4].Selected = true;
                cb2.Items[5].Selected = true;
                cb3.Enabled = true;
                cb3.Items[0].Selected = true;
                cb3.Items[1].Selected = true;
                cb3.Items[2].Selected = true;
            }      
        }
    }
}
