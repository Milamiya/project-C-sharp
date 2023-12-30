using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace TestOnline.hy.vn.Control.Manager
{
    public partial class ucCategories : System.Web.UI.UserControl
    {
        TestOnlineDataContext db = new TestOnlineDataContext();
        /// <summary>
        /// Load dữ liệu lên gridview
        /// </summary>
        void LoadGrid()
        {
            var cl = from c in db.Categories
                     select c;
            grvHinhThuc.DataSource = cl;
            grvHinhThuc.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
           
            Category tbl = new Category();
            tbl.CategoryID = txtCategorID.Text;
            tbl.CategoryName = txtCategoriName.Text;
            tbl.CategoryOrder =int.Parse(txtCategoriOrder.Text);
            tbl.Description = txtDiscriptio.Text;
            db.Categories.InsertOnSubmit(tbl);
            db.SubmitChanges();
            LoadGrid();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtCategorID.Text = "";
            txtCategoriName.Text = "";
            txtCategoriOrder.Text = "";
            txtDiscriptio.Text = "";

           
        }

        protected void grvHinhThuc_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            //Xóa 1 hàng trong gridview
            if (e.CommandName == "Delete")
            {
                Category doc = db.Categories.SingleOrDefault(d => d.CategoryID.ToString().Trim() == e.CommandArgument.ToString().Trim());
                if (doc != null)
                {
                    db.Categories.DeleteOnSubmit(doc);
                    db.SubmitChanges();
                    LoadGrid();
                    lblThongBao.Visible = true;
                    lblThongBao.Text = "Bạn đã xóa thành công";
                }

            }
        }

        protected void grvHinhThuc_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LoadGrid();
        }
    }
}