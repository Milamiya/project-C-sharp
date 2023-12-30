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
    public partial class WebForm2 : System.Web.UI.Page
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
        }

        InfoDataContext db = new InfoDataContext();
        private void load()
        {
            var query = db.tbl_Types;
            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        void rong()
        {
            txtMa.Text = "";
            txttenML.Text = "";
        }


        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            load();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tbl_Type t = new tbl_Type();
            t.Type_Name = txttenML.Text;
            db.tbl_Types.InsertOnSubmit(t);
            db.SubmitChanges();
            load();
            Label1.Text = "Thêm thành công";
            rong();
            txttenML.Focus();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            tbl_Type t = db.tbl_Types.SingleOrDefault(c => c.Type_ID == int.Parse(txtMa.Text));
            t.Type_ID = int.Parse(txtMa.Text);
            t.Type_Name = txttenML.Text;
            db.SubmitChanges();
            load();
            Label1.Text = "Sửa thành công.";
            rong();
            txttenML.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            tbl_Type t = db.tbl_Types.SingleOrDefault(c => c.Type_ID == int.Parse(txtMa.Text));
            db.tbl_Types.DeleteOnSubmit(t);
            db.SubmitChanges();
            load();
            Label1.Text = "Xoá thành công.";
            rong();
            txttenML.Focus();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Response.Redirect("CapnhatMaloai.aspx");
            txttenML.Focus();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Label lblMa = (Label)GridView1.Rows[e.NewEditIndex].FindControl("lbMa");
            tbl_Type p = db.tbl_Types.SingleOrDefault(c => c.Type_ID == int.Parse(lblMa.Text));
            txtMa.Text = p.Type_ID.ToString();
            txttenML.Text = p.Type_Name.ToString();
            GridView1.EditIndex = e.NewEditIndex;
            load();
        }
    }
}
