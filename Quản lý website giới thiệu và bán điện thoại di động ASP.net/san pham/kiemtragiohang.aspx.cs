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
using System.Data.OleDb;

public partial class kiemtragiohang : System.Web.UI.Page
{
    bool kt = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        ado.ketNoi();
        if (Session["hoten"] != null)
            lbTenKhachHang.Text = Session["hoten"].ToString();
        else
            lbTenKhachHang.Text = "Chưa rõ tên.";
        if (Session["diachi"] != null)
            lbdiachiKH.Text = Session["diachi"].ToString();
        else
            lbdiachiKH.Text = "Chưa rõ địa chỉ.";
        string ngay = System.DateTime.Now.ToString();
        ngay = ngay.Substring(0, ngay.IndexOf(" "));
        lbNgayDat.Text = ngay;
        DataTable tb = (DataTable)Session["hangmua"];
        GridView1.DataSource = tb;
        GridView1.DataBind();
        lbtien.Text = Session["tong"].ToString() + "VND";
        string s = "";
        foreach (DataRow r in tb.Rows)
        {
            string query = "select SoLuong from tblSanPham where masp='"+r[0].ToString()+"'"  ;
            OleDbDataReader dr = ado.getData(query);
            if (dr.Read())
            {
                if (Convert.ToInt64(dr[0].ToString()) < Convert.ToInt64(r[1].ToString()))
                    s += "+ Số lượng sản phẩm " + r[0].ToString() + " trong kho chỉ còn " + dr[0].ToString() + "sản phẩm.</br>";
            }
            dr.Dispose();
            dr.Close();
        }
        if (s != "")
        {
            s += "Mong quý khách thông cảm!";
            kt = true;
        }
        else
            s = "Số lượng sản phẩm trong kho đáp ứng được yêu cầu của quý khách!";
        lbthongbao.Text = s;       
    }

    protected void btndathang_Click(object sender, EventArgs e)
    {
        if (kt == true)
            Response.Redirect("GioHang.aspx");
        else
            Response.Redirect("thanhtoan.aspx");
    }
    protected void btndatlaihang_Click(object sender, EventArgs e)
    {
        Response.Redirect("giohang.aspx");
    }
}
