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
    public partial class WebForm21 : System.Web.UI.Page
    {
        InfoDataContext db = new InfoDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["Order_ID"];
            var a = from s in db.tbl_Orders
                    select new {s.Order_ID,s.Account,s.Date,s.Pay_ID,s.Transport_ID,s.Name_Received,s.Address_Received,s.Phone_Received,s.Name_Pay,s.Address_Pay,s.Phone_Pay,s.Mesage,s.VAT_Gift,s.SumWeight,s.VAT_Transport,s.SumMoney,s.State};
            foreach (var item in a)
            {
                Label2.Text = item.Account;
                Label3.Text = item.Date.ToString();
                Label4.Text = item.Pay_ID.ToString();
                Label5.Text = item.Transport_ID.ToString();
                Label6.Text = item.Name_Received;
                Label7.Text = item.Address_Received;
                Label8.Text = item.Phone_Received.ToString();
                Label9.Text = item.Name_Pay;
                Label10.Text = item.Address_Pay;
                Label11.Text = item.Phone_Pay.ToString();
                Label12.Text = item.Mesage;
                Label13.Text = item.VAT_Gift.ToString();
                Label14.Text = item.SumWeight.ToString();
                Label15.Text = item.VAT_Transport.ToString();
                Label16.Text = item.SumMoney.ToString();
                Label17.Text = item.State;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DanhsachHD.aspx");
        }
    }
}
