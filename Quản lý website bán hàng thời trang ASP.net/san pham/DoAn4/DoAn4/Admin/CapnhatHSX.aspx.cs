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
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                load();
            if (Session["Username"] != null)
            {

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        InfoDataContext db = new InfoDataContext();
        private void load()
        {
            var query = from a in db.tbl_Producers
                        select a;
            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        void rong()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            load();
        }

        protected void btnNhap_Click(object sender, EventArgs e)
        {
            tbl_Producer p = new tbl_Producer();
            p.Producer_Name = txtTen.Text;
            db.tbl_Producers.InsertOnSubmit(p);
            db.SubmitChanges();
            load();
            Label2.Text = "Thêm thành công";
            rong();
        }       

        protected void btnSua_Click(object sender, EventArgs e)
        {
            tbl_Producer p = db.tbl_Producers.SingleOrDefault(c => c.Producer_ID == int.Parse(txtMa.Text));
            p.Producer_ID = int.Parse(txtMa.Text);
            p.Producer_Name = txtTen.Text;
            db.SubmitChanges();
            load();
            Label2.Text = "Sửa thành công.";
            rong();
            txtTen.Focus();
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            tbl_Producer p = db.tbl_Producers.SingleOrDefault(c => c.Producer_ID == int.Parse(txtMa.Text));
            db.tbl_Producers.DeleteOnSubmit(p);
            db.SubmitChanges();
            load();
            Label2.Text = "Xoá thành công.";
            rong();
            txtTen.Focus();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Label lblMa = (Label)GridView1.Rows[e.NewEditIndex].FindControl("lbMa");
            tbl_Producer p = db.tbl_Producers.SingleOrDefault(c => c.Producer_ID == int.Parse(lblMa.Text));
            txtMa.Text = p.Producer_ID.ToString();
            txtTen.Text = p.Producer_Name.ToString();
            GridView1.EditIndex = e.NewEditIndex;
            load();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Response.Redirect("CapnhatHSX.aspx");
            txtTen.Focus();
        }
    }
}
