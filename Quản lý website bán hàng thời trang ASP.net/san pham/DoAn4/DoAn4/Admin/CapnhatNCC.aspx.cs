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

namespace DoAn4.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                load();
            if (Session["Username"] != null)
            {  }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        InfoDataContext db = new InfoDataContext();
        private void load()
        {
            var query = from a in db.tbl_Suppliers
                        select a;
            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        void rong()
        {
            txtMa.Text = "";
            txtTenNCC.Text = "";
            txtDiachi.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        bool KT(string tensp, string diachi, string sdt)
        {
            if (tensp == "" || diachi == "" || sdt == "")
            {
                return false;
            }
            return true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (KT(txtTenNCC.Text, txtDiachi.Text, txtPhone.Text))
            {
                tbl_Supplier s = new tbl_Supplier();
                s.Supplier_Name = txtTenNCC.Text;
                s.Address = txtDiachi.Text;
                if (txtPhone.Text == "")
                {
                    s.Phone = null;
                }
                else
                    s.Phone = int.Parse(txtPhone.Text);
                s.Email = txtEmail.Text;
                var query = from a in db.tbl_Suppliers
                            select a;
                db.tbl_Suppliers.InsertOnSubmit(s);
                db.SubmitChanges();
                load();
                Label2.Text = "Thêm thành công";
                rong();
            }
            else
            {
                Label2.Text = "Chưa nhập đủ thông tin.";
            }
        }
  
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (KT(txtTenNCC.Text, txtDiachi.Text, txtPhone.Text))
            {
                tbl_Supplier s = db.tbl_Suppliers.SingleOrDefault(a => a.Supplier_ID == int.Parse(txtMa.Text));
                s.Supplier_ID = int.Parse(txtMa.Text);
                s.Supplier_Name = txtTenNCC.Text;
                s.Address = txtDiachi.Text;
                s.Phone = int.Parse(txtPhone.Text);
                s.Email = txtEmail.Text;
                db.SubmitChanges();
                load();
                Label2.Text = "Sửa thành công";
                rong();
            }
            else
            {
                Label2.Text = "Bạn chưa chọn nhà cung cấp.";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (KT(txtTenNCC.Text, txtDiachi.Text, txtPhone.Text))
            {
                tbl_Supplier s = db.tbl_Suppliers.SingleOrDefault(a => a.Supplier_ID == int.Parse(txtMa.Text));
                db.tbl_Suppliers.DeleteOnSubmit(s);
                db.SubmitChanges();
                load();
                Label2.Text = "Xoá thành công";
                rong();
                txtTenNCC.Focus();
            }
            else
            {
                Label2.Text = "Bạn chưa chọn nhà cung cấp.";
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            load();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Label lblMa = (Label)GridView1.Rows[e.NewEditIndex].FindControl("lbMa");
            tbl_Supplier s = db.tbl_Suppliers.SingleOrDefault(c => c.Supplier_ID == int.Parse(lblMa.Text));
            txtMa.Text = (s.Supplier_ID).ToString();
            txtTenNCC.Text = s.Supplier_Name.ToString();
            txtDiachi.Text = s.Address.ToString();
            txtPhone.Text = s.Phone.ToString();
            txtEmail.Text = s.Email.ToString();
            GridView1.EditIndex = e.NewEditIndex;
            load();
            Label2.Text = "";
        }

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            Response.Redirect("CapnhatNCC.aspx");
            txtTenNCC.Focus();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
