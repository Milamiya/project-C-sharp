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
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //load();
            if(Session["Username"]!=null)
            {
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        InfoDataContext db = new InfoDataContext();
        //void load()
        //{
        //    //var a = db.TKSPbanchaytheongay(DateTime.Parse(txtTheongay.Text));
        //    var a = from s in db.tbl_Orders
        //            from d in db.tbl_OrderDetials
        //            where s.Order_ID == d.Order_ID
        //            //orderby s.Date ascending
        //            select new { Ngày_bán = s.Date, Mã_sản_phẩm = d.Product_ID, Số_lượng = d.Amount, Giá_bán = d.Price_Export, Thành_tiền = d.Money };
        //    GridView1.DataSource = a;
        //    GridView1.DataBind();
        //}

        protected void btnThongke_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.Items[0].Selected)
            {
                var a = db.TKSPbanchaytheongay(DateTime.Parse(txtTheongay.Text));
                GridView1.DataSource = a;
                GridView1.DataBind();
            }
            if (RadioButtonList1.Items[1].Selected)
            {
                var a = db.TKSPbanchaytheoTG(DateTime.Parse(txtTungay.Text), DateTime.Parse(txtDenngay.Text));
                GridView1.DataSource = a;
                GridView1.DataBind();
            }
            if (RadioButtonList1.Items[2].Selected)
            {
                var a = db.TKSPbanchaytheonam(int.Parse(txtTheonam.Text));
                GridView1.DataSource = a;
                GridView1.DataBind();
            }
        }
    }
}
