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

public partial class GiaoDien_ThongTinDatHang : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.rpt_TTGH.DataSource = getGH();
            this.rpt_TTGH.DataBind();
            tongTien();
            LoadTTKH(dlTTKH);
        }
    }
    public void xoa()
    {
        txtDCNN.Text = "";
        txtEmailNN.Text = "";
        txtSDTNN.Text = "";
        txtTenNN.Text = "";
    }
    public DataTable getGH()
    {
        ShoppingCart gio = (ShoppingCart)Session["GioHang"];
        if (gio != null)
        {
            //int t = gio.Data.Rows.Count;
            return gio.Data;
        }
        else
        {
            return null;
        }

    }

    public void tongTien()
    {
        //long tong = 0;
        int sl = 0;
        long gia = 0;

        ShoppingCart gio = (ShoppingCart)Session["GioHang"];

        for (int i = 0; i < gio.Data.Rows.Count; i++)
        {
            gia = gia + long.Parse(gio.Data.Rows[i][4].ToString());
            sl = sl + int.Parse(gio.Data.Rows[i][2].ToString());
        }
        lbTongSL.Text = sl.ToString();
        lbTongTien.Text = gia.ToString() + "" + "" + "VNĐ";

    }


    public void LoadSL_TongTien()
    {
        //ShoppingCart gio = (ShoppingCart)Session["GioHang"];
        //int sl=0;
        //long tongtien=0;
        //for(int i=0;i<gio.Data.Rows.Count;i++)
        //{
        //    sl=sl+int.Parse(gio.Data.Rows[i][2].ToString());
        //    lbSL.Text = sl.ToString();
        //    tongtien = tongtien + long.Parse(gio.Data.Rows[i][3].ToString());
        //    lbTongTien.Text = tongtien.ToString();
        //}
    }
    public void LoadTTKH(DataList ddl)
    {
        //DataTable tb = new DataTable();
        //tb.Rows.Add("TenDN",typeof(string));

        string user = Session["UserName"].ToString() ;
        var c = from p in db.Users
                 where p.UserName == user
                 select new {p.UserName, p.Name, p.Email, p.Address 
                 };
        ddl.DataSource = c;
        ddl.DataBind();
        
    }

    public void ThemDonHang()
    {
        Order or = new Order();
        or.DateSet = DateTime.Now;
        or.DateDelivery = DateTime.Now.Date.AddDays(5);
        or.UserName = Session["UserName"].ToString();
        
        or.Address = txtDCNN.Text;
        or.Phone =txtSDTNN.Text;
        or.Email = txtEmailNN.Text;
        or.RecipientName = txtTenNN.Text;
        if (rdTTTT.Checked == true)
        {
            or.PaymentID = "PT1";
        }
        if (rdTTQuaThe.Checked == true)
        {
            or.PaymentID = "PT2";
        }
        or.State =0;
        db.Orders.InsertOnSubmit(or);
        db.SubmitChanges();

        var c=from p in db.Orders
              select p.OrderID;
        
        ShoppingCart gio=(ShoppingCart)Session["GioHang"];
        for (int i = 0; i < gio.Data.Rows.Count; i++)
        {
            DetailOrder dto = new DetailOrder();
            int mahd = 0;
            foreach (var con in c)
            {
                mahd =con;
                
            }
            dto.OrderID = mahd;
            dto.ProductID = gio.Data.Rows[i][0].ToString();
            dto.Number =int.Parse(gio.Data.Rows[i][2].ToString());
            db.DetailOrders.InsertOnSubmit(dto);
            db.SubmitChanges();
        }
        

    }
    protected void btnTiepTuc_Click(object sender, EventArgs e)
    {
        ThemDonHang();
        xoa();
        Response.Redirect("HoanThanhDH.aspx");
    }
}
