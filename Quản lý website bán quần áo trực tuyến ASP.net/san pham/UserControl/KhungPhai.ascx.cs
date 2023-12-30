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

public partial class UserControl_KhungPhai : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int tongsp = 0;
            long TongTien = 0;
            ShoppingCart gio = (ShoppingCart)Session["GioHang"];


            for (int i = 0; i < gio.Data.Rows.Count; i++)
            {
                tongsp = tongsp + int.Parse(gio.Data.Rows[i][2].ToString());
                TongTien = TongTien + long.Parse(gio.Data.Rows[i][4].ToString());
            }
            lblSL.Text = tongsp.ToString();
            lbTongTien.Text = TongTien.ToString() + "" + "VNĐ";



        }
    }
}
