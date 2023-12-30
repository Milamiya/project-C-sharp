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
    public partial class WebForm6 : System.Web.UI.Page
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
            var query = db.tbl_Payments;
            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        void rong()
        {
            txtMa.Text = "";
            txtTenTT.Text = "";
        }

        protected void btnNhap_Click(object sender, EventArgs e)
        {
            tbl_Payment t = new tbl_Payment();
            t.Pay_Name = txtTenTT.Text;
            db.tbl_Payments.InsertOnSubmit(t);
            db.SubmitChanges();
            load();
            Label3.Text = "Thêm thành công";
            rong();
            txtTenTT.Focus();
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            tbl_Payment t = db.tbl_Payments.SingleOrDefault(c => c.Pay_ID == int.Parse(txtMa.Text));
            t.Pay_ID = int.Parse(txtMa.Text);
            t.Pay_Name = txtTenTT.Text;
            db.SubmitChanges();
            load();
            Label3.Text = "Sửa thành công.";
            rong();
            txtTenTT.Focus();
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            tbl_Payment t = db.tbl_Payments.SingleOrDefault(c => c.Pay_ID == int.Parse(txtMa.Text));
            db.tbl_Payments.DeleteOnSubmit(t);
            db.SubmitChanges();
            load();
            Label3.Text = "Xoá thành công.";
            rong();
            txtTenTT.Focus();
        }
      
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Response.Redirect("CapnhatHSX.aspx");
            txtTenTT.Focus();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Label lblMa = (Label)GridView1.Rows[e.NewEditIndex].FindControl("lbMa");
            tbl_Payment p = db.tbl_Payments.SingleOrDefault(c => c.Pay_ID == int.Parse(lblMa.Text));
            txtMa.Text = p.Pay_ID.ToString();
            txtTenTT.Text = p.Pay_Name.ToString();
            GridView1.EditIndex = e.NewEditIndex;
            load();
        }
    }
}
