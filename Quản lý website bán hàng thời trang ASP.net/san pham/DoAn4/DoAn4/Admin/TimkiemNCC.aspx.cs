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
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Load();
            if (Session["Username"] != null)
            {
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        void Load()
        {
            var a = from s in db.tbl_Suppliers
                    select s;
            GridView1.DataSource = a;
            GridView1.DataBind();
        }
        InfoDataContext db = new InfoDataContext();
        protected void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.Items[0].Selected)
            {
                var a = from s in db.tbl_Suppliers
                        where s.Supplier_ID == int.Parse( txtMaNCC.Text)
                        select new { s.Supplier_ID, s.Supplier_Name, s.Address, s.Phone, s.Email };
                GridView1.DataSource = a;
                GridView1.DataBind();
            }
            if (RadioButtonList1.Items[1].Selected)
            {
                var a = from s in db.tbl_Suppliers
                        where s.Supplier_Name.Contains(txtTenNCC.Text)
                        select new { s.Supplier_ID, s.Supplier_Name, s.Address, s.Phone, s.Email };
                GridView1.DataSource = a;
                GridView1.DataBind();
            }
            if (RadioButtonList1.Items[2].Selected)
            {
                var a = from s in db.tbl_Suppliers
                        where s.Address.Contains(txtDiachi.Text)
                        select new { s.Supplier_ID, s.Supplier_Name, s.Address, s.Phone, s.Email };
                GridView1.DataSource = a;
                GridView1.DataBind();
            }
            if (RadioButtonList1.Items[3].Selected)
            {
                var a = from s in db.tbl_Suppliers
                        where s.Phone == int.Parse( txtSDT.Text)
                        select new { s.Supplier_ID, s.Supplier_Name, s.Address, s.Phone, s.Email };
                GridView1.DataSource = a;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("TimkiemNCC.aspx");
        }

        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
          //  load();
        }

        protected void drMa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
