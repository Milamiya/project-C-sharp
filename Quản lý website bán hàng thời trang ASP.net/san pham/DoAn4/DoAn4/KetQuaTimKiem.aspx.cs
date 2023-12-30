using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class WebForm8 : System.Web.UI.Page
    {
        //Data a = new Data(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        //DataSet ds = new DataSet();
        DataTable dt;
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                phantrang();
            }
        }
        public void phantrang()
        {
            InfoDataContext db = new InfoDataContext();
            DataSet ds = new DataSet();
            dt = ds.Tables["tbl_Product"];
            string dieukien = Convert.ToString(Request.QueryString["DieuKien"]);
            DataRow dr;
            IEnumerable<tbl_Product> tmp = db.ExecuteQuery<tbl_Product>(@"SELECT tbl_Type.*,tbl_Product.*,tbl_Producer.* FROM tbl_Type,tbl_Product,tbl_Producer where tbl_Type.Type_ID=tbl_Product.Type_ID and tbl_Product.Producer_ID=tbl_Producer.Producer_ID and" + dieukien);
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
            TimKiem.DataSource = pdata;
            TimKiem.DataBind();
            int sobanghi = ds.Tables[0].Rows.Count;
            lblTieuDe.Text = "Có " + sobanghi + " kết quả được tìm thấy";
            LbtBack.Enabled = !pdata.IsFirstPage;
            LbtNext.Enabled = !pdata.IsLastPage;
            LblPage.Text = (CurrentP + 1) + "/" + pdata.PageCount;
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
    }
}
