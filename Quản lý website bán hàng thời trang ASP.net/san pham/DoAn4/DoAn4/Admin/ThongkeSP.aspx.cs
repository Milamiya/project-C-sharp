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
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadDG();
            if (Session["Username"] != null)
            { }
            else
                Response.Redirect("Login.aspx");
        }
        InfoDataContext db = new InfoDataContext();
        void tinh()
        {

            var a = (from s in db.tbl_Products
                     select s.Product_ID).Count();
            Label3.Text = a.ToString("###,###");
            var b = (from s in db.tbl_Products
                     select s.Amount).Sum();
            Label5.Text = b.ToString();
            var c = (from s in db.tbl_Products
                     select s.Price_Import).Sum();
            Label2.Text = c.ToString().Replace(',', '.');
        }

        void LoadDG()
        {
            var a = from p in db.tbl_Products
                    from s in db.tbl_Suppliers
                    from t in db.tbl_Types
                    from pr in db.tbl_Producers
                    from st in db.tbl_Styles
                    where p.Supplier_ID == s.Supplier_ID && p.Style_ID == st.Style_ID && p.Producer_ID == pr.Producer_ID && p.Type_ID == t.Type_ID
                    select new { p.Product_ID, p.Product_Name, t.Type_Name, st.Style_Name, s.Supplier_Name, pr.Producer_Name, p.Price_Import, p.Price_Export, p.Amount };
            GridView1.DataSource = a;
            GridView1.DataBind();
            tinh();
        }

        protected void DropDownList1_PreRender(object sender, EventArgs e)
        {
            //DropDownList1.Items.Insert(0, "-----Chọn loại sản phẩm-----");
        }

        protected void btnThongke_Click(object sender, EventArgs e)
        {
            var a = db.ThongkeSP(DropDownList1.Text);
            GridView1.DataSource = a;
            GridView1.DataBind();
            tinhloai();
        }

        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadDG();
        }

        void tinhloai()
        {
            Label3.Text = GridView1.Rows.Count.ToString();
            double tongsoluong = 0;
            double tongtiennhap = 0;
            foreach (GridViewRow gr in GridView1.Rows)
            {
                tongsoluong += double.Parse(gr.Cells[8].Text);
                tongtiennhap += double.Parse(gr.Cells[6].Text);
            }
            Label5.Text = tongsoluong.ToString("###,###");
            Label2.Text = tongtiennhap.ToString("###,###") + "  ";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}