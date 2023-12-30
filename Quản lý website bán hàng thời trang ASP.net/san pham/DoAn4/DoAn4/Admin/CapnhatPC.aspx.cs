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

namespace DoAn4.Admin
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                load();
            if (Session["Username"] != null)
            { }
            else
                Response.Redirect("Login.aspx");
        }

        InfoDataContext db = new InfoDataContext();
        private void load()
        {
            var query = db.tbl_Styles;
            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        void rong()
        {
            txtMa.Text = "";
            txtTenPC.Text = "";
        }

        bool KT(string ten)
        {
            if (ten == "")
            {
                return false;
            }
            return true;
        }

        protected void btnNhap_Click(object sender, EventArgs e)
        {
            if (KT(txtTenPC.Text))
            {
                tbl_Style s = new tbl_Style();
                s.Style_Name = txtTenPC.Text;
                db.tbl_Styles.InsertOnSubmit(s);
                db.SubmitChanges();
                load();
                Label1.Text = "Thêm thành công";
                rong();
                txtTenPC.Focus();
            }
            else
            {
                Label1.Text = "Chưa nhập tên phong cách.";
            }
        }
        protected void btnSua_Click(object sender, EventArgs e)
        {
             if (KT(txtTenPC.Text))
            {
                tbl_Style s = db.tbl_Styles.SingleOrDefault(c => c.Style_ID == int.Parse(txtMa.Text));
                s.Style_ID = int.Parse(txtMa.Text);
                s.Style_Name = txtTenPC.Text;
                db.SubmitChanges();
                load();
                Label1.Text = "Sửa thành công.";
                rong();
                txtTenPC.Focus();
            } 
            else
            {
                Label1.Text = "Chưa chọn phong cách.";
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            if (KT(txtTenPC.Text))
            {
                tbl_Style t = db.tbl_Styles.SingleOrDefault(c => c.Style_ID == int.Parse(txtMa.Text));
                db.tbl_Styles.DeleteOnSubmit(t);
                db.SubmitChanges();
                load();
                Label1.Text = "Xoá thành công.";
                rong();
                txtTenPC.Focus();
            }
            else
            {
                Label1.Text = "Chưa chọn phong cách.";
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Response.Redirect("CapnhatPC.aspx");
            txtTenPC.Focus();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Label lblMa = (Label)GridView1.Rows[e.NewEditIndex].FindControl("lbMa");
            tbl_Style p = db.tbl_Styles.SingleOrDefault(c => c.Style_ID == int.Parse(lblMa.Text));
            txtMa.Text = (p.Style_ID).ToString();
            txtTenPC.Text = p.Style_Name.ToString();
            GridView1.EditIndex = e.NewEditIndex;
            load();
        }
    }
}
