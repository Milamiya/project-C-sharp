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
    public partial class WebForm5 : System.Web.UI.Page
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
            var query = from a in db.tbl_Transports
                        select a;
            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        void rong()
        {
            txtMa.Text = "";
            txtTenVC.Text = "";
        }

        protected void btnNhap_Click(object sender, EventArgs e)
        {
            tbl_Transport t = new tbl_Transport();
            t.Transport_Name = txtTenVC.Text;
            db.tbl_Transports.InsertOnSubmit(t);
            db.SubmitChanges();
            load();
            Label1.Text = "Thêm thành công";
            rong();
            txtTenVC.Focus();
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            tbl_Transport t = db.tbl_Transports.SingleOrDefault(c => c.Transport_ID == int.Parse(txtMa.Text));
            t.Transport_ID = int.Parse(txtMa.Text);
            t.Transport_Name = txtTenVC.Text;
            db.SubmitChanges();
            load();
            Label1.Text = "Sửa thành công.";
            rong();
            txtTenVC.Focus();
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            tbl_Transport t = db.tbl_Transports.SingleOrDefault(c => c.Transport_ID == int.Parse(txtMa.Text));
            db.tbl_Transports.DeleteOnSubmit(t);
            db.SubmitChanges();
            load();
            Label1.Text = "Xoá thành công.";
            rong();
            txtTenVC.Focus();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Response.Redirect("CapnhatHTVC.aspx");
            txtTenVC.Focus();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Label lblMa = (Label)GridView1.Rows[e.NewEditIndex].FindControl("lbMa");
            tbl_Transport p = db.tbl_Transports.SingleOrDefault(c => c.Transport_ID == int.Parse(lblMa.Text));
            txtMa.Text = p.Transport_ID.ToString();
            txtTenVC.Text = p.Transport_Name.ToString();
            GridView1.EditIndex = e.NewEditIndex;
            load();
        }
    }
}
