using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

public partial class Default3 : System.Web.UI.Page
{
    DataTable dt; GioHangData gh;
    protected void Page_Load(object sender, EventArgs e)
    {

        ado.ketNoi();
        string query = "SELECT * FROM tblSanPham where tensp='" + Request.QueryString.Get("tensp") + "'";
        ado.rd = ado.getData(query);
        if (ado.rd.Read())
        {
            lblTenSP.Text = ado.rd["TenSP"].ToString();
            lblMoTa.Text = ado.rd["dacdiem"].ToString();

            lbbh.Text += ado.rd["Baohanh"].ToString();

            lblGia.Text = ado.rd["Gia"].ToString();

            if (Convert.ToDouble(ado.rd["soluong"]) > 0)
            {
                lblKho.Text = "Còn hàng";
            }
            else
            {
                lblKho.Text = "Hết hàng";
            }
            lblkm.Text = ado.rd["khuyenmai"].ToString();
            imgSP.ImageUrl = "dienthoai/" + ado.rd["Anh"].ToString();
        }
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        //gh = new GioHangData();
        //DataTable tb;
        //if (Session["GioHang"] == null)
        //    tb = gh.setTable();
        //else
        //    tb = (DataTable)Session["GioHang"];
        //string query = "select * from tblSanPham where masp='" + lblTenSP.Text + "'";

        //OleDbDataAdapter da = new OleDbDataAdapter(query, ado.con);
        //DataTable dt = new DataTable();
        //da.Fill(dt);
        //foreach (DataRow dr in dt.Rows)
        //{
        //    tb = gh.dienVaoBang(tb, dr[10].ToString(), dr["TenSP"].ToString(), 1, Convert.ToDouble(dr["Gia"]), dr["masp"].ToString());
        //    Session["GioHang"] = tb;

        //}     
    }
    protected void ImageButton2_Command(object sender, CommandEventArgs e)
    {
        gh = new GioHangData();
        DataTable tb;
        if (Session["GioHang"] == null)
            tb = gh.setTable();
        else
            tb = (DataTable)Session["GioHang"];
        string query = "select * from tblSanPham where masp='" + lblTenSP.Text + "'";

        OleDbDataAdapter da = new OleDbDataAdapter(query, ado.con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            tb = gh.dienVaoBang(tb, dr[10].ToString(), dr["TenSP"].ToString(), 1, Convert.ToDouble(dr["Gia"]), dr["masp"].ToString());
            Session["GioHang"] = tb;
            //Download source code tại Sharecode.vn
        }
    }
}
