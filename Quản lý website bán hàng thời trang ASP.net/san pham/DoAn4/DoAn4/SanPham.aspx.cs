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

namespace DoAn4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DataTable dt;
        protected void DataList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void phantrang()
        {
            InfoDataContext db = new InfoDataContext();
            DataSet ds = new DataSet();
            dt = ds.Tables["tbl_Product"];
           
            DataRow dr;
            var tmp = from a in db.tbl_Products
                      from b in db.tbl_Types
                      where a.Type_ID == b.Type_ID && b.Type_ID.ToString() == Request.QueryString["Type_ID"]
                      select new { a.Product_ID,a.Product_Name, a.Image, a.Price_Export };
            foreach (var n in tmp)
            {
                dr = dt.NewRow();
                dr[0] = n.Product_ID;
                dr[1] = n.Product_Name;
                dr[2] = n.Image;
                dr[3] = n.Price_Export.ToString("###,###").Replace(',', '.');
                dt.Rows.Add(dr);
            }
            PagedDataSource pdata = new PagedDataSource();
            pdata.DataSource = ds.Tables[0].DefaultView;
            pdata.PageSize = 9;
            pdata.AllowPaging = true;
            pdata.CurrentPageIndex = CurrentP;
            sanpham.DataSource = pdata;
            sanpham.DataBind();
            LbtBack.Enabled = !pdata.IsFirstPage;
            LbtNext.Enabled = !pdata.IsLastPage;
            LblPage.Text = (CurrentP + 1) + "/" + pdata.PageCount;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string typeID = Request.QueryString["Type_ID"];
                InfoDataContext db = new InfoDataContext();
                tbl_Type type = db.tbl_Types.SingleOrDefault(t => t.Type_ID.ToString() == typeID.Trim());
                if (type != null)
                {
                    lblTieuDe.Text = type.Type_Name;
                }
                phantrang();
            }
        }
        public int CurrentP
        {
            set
            {
                this.ViewState["cp"] = value;
            }
            get
            {
                if (this.ViewState["cp"] == null)
                {
                    this.ViewState["cp"] = 0;
                    return 0;
                }
                else
                {
                    return (int)this.ViewState["cp"];
                }
            }
        }

        protected void LbtBack_Click(object sender, EventArgs e)
        {
            CurrentP -= 1;
            phantrang();
        }

        protected void LbtNext_Click(object sender, EventArgs e)
        {
            CurrentP += 1;
            phantrang();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}
