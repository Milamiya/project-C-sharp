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
    public partial class WebForm17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void tinhtoan()
        {
            double tongtiennhap = 0;
            foreach (GridViewRow gr in GridView1.Rows)
            {
                tongtiennhap += double.Parse(gr.Cells[4].Text);
            }
            Label1.Text = tongtiennhap.ToString("###,###") + "  " + "VNĐ";
        }
        InfoDataContext db = new InfoDataContext();

        protected void btnThongke_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.Items[0].Selected)
            {
                var kq = db.TkDoanhthutheongay(DateTime.Parse(txtNgay.Text));
                GridView1.DataSource = kq;
                GridView1.DataBind();
                tinhtoan();

            }
            if (RadioButtonList1.Items[1].Selected)
            {
                var kq = db.TkDoanhthutheoTG(DateTime.Parse(txtTungay.Text), DateTime.Parse(txtDenngay.Text));
                GridView1.DataSource = kq;
                GridView1.DataBind();
                tinhtoan();
            }
            if (RadioButtonList1.Items[2].Selected)
            {
                var kq = db.TkDoanhthutheonam(int.Parse(txtNam.Text));
                GridView1.DataSource = kq;
                GridView1.DataBind();
                tinhtoan();
            }
        }
    }
}
