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

public partial class GioHang : System.Web.UI.Page
{
    
    WedMayTinhDataContext db = new WedMayTinhDataContext();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            load();

            string MaKhachHang1 = Request.QueryString["MaKhachHang"];
            int sogiohang = (from p in db.GioHangs where p.MaKhachHang.ToString() ==  MaKhachHang1 select p).Count();
            btnGioHangCuaBan.Text = "Giỏ hàng của bạn có " + sogiohang.ToString() + "sản phẩm";
            btnGioHangCuaBan.PostBackUrl = "~/GioHang.aspx?MaKhachHang=" + MaKhachHang1;
            btnDangNhap.Text = "Tài khoản";
            btnDangKy.Text = "Thoát";
        }
    }
    void load()
    {

        GridView1.DataBind();
        double tonggia = 0;
       
        foreach ( GridViewRow dt in GridView1.Rows)
        {
           tonggia=tonggia+Convert.ToDouble(dt.Cells[3].Text);
        }
        lblTongTien.Text = HienThiGia(tonggia);
    }
    string HienThiGia(double gia)
    {
        string giatrave = "  VND";
        string strgia = gia.ToString();
        int dodai = strgia.Length;
        int sodaucham = strgia.Length / 3;

        for (int i = strgia.Length - 1; i >= 0; i--)
        {
            if ((strgia.Length - 1 - i) % 3 == 0 && i != strgia.Length - 1)
            {
                giatrave = strgia[i] + "." + giatrave;
            }
            else
            {

                giatrave = strgia[i] + giatrave;
            }
        }
        return giatrave;
    }
    double TinhGiamGia(string giacamgiam, double giaban)
    {
        double Giasaukhigiam = giaban;
        if (giacamgiam != null)
        {

            if (giacamgiam[giacamgiam.Length - 1].ToString() == "%")
            {
                Giasaukhigiam =giaban- (Convert.ToDouble(giacamgiam.TrimEnd('%')) * giaban) / 100;
                return Giasaukhigiam;
            }
            else
            {
                Giasaukhigiam = giaban - Convert.ToDouble(giacamgiam);
                return Giasaukhigiam;
            }
        }
        return Giasaukhigiam;
    }
    protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
    {
        string MaKhachHang1 = Request.QueryString["MaKhachHang"];
        int MaKhachHang = Convert.ToInt32(MaKhachHang1);
        var ds = from p in db.GioHangs where p.MaKhachHang==MaKhachHang select new { p.MaSanPham, p.SanPhams.TenSP, p.SoLuong, DonGia = TinhGiamGia(p.SanPhams.SanPham_KhuyenMai.KhuyenMai.GiaCanGiam, Convert.ToDouble( p.SoLuong * p.SanPhams.GiaBan)) };
        e.Result=ds;
       
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string MaKhachHang1 = Request.QueryString["MaKhachHang"];
        int MaKhachHang = Convert.ToInt32(MaKhachHang1);
        GioHangs giohang = db.GioHangs.SingleOrDefault(p => p.MaSanPham.ToString() == GridView1.Rows[GridView1.SelectedIndex].Cells[0].Text && p.MaKhachHang == MaKhachHang);
        if (giohang != null)
        {
            db.GioHangs.DeleteOnSubmit(giohang);
            db.SubmitChanges();
            load();
        }
    }
    protected void btnCapNhap_Click(object sender, ImageClickEventArgs e)
    {
        int i = 0;
        string MaKhachHang1 = Request.QueryString["MaKhachHang"];
        int MaKhachHang = Convert.ToInt32(MaKhachHang1);
        var ds = from p in db.GioHangs where p.MaKhachHang == MaKhachHang select p;
        foreach (GioHangs giohang in ds)
        {
            TextBox txtsl = GridView1.Rows[i].FindControl("txtSoLuong") as TextBox;
            giohang.SoLuong = Convert.ToInt32(txtsl.Text);
            i = i + 1;
        }
        db.SubmitChanges();
        load();
        
    }
    protected void lbtMuaTiep_Click(object sender, EventArgs e)
    {
        string MaKhachHang1 = Request.QueryString["MaKhachHang"];
        int MaKhachHang = Convert.ToInt32(MaKhachHang1);
        Response.Redirect("~/Default3.aspx?ClickDangNhap=true+&MaKhachHang=" + MaKhachHang);
    }
    protected void btnDatHang_Click(object sender, ImageClickEventArgs e)
    {
        
        string MaKhachHang1 = Request.QueryString["MaKhachHang"];
        int makhachhang=Convert.ToInt16(MaKhachHang1);
      Response.Redirect("~/DonDatHang.aspx?MaKhachHang=" + makhachhang);
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        string MaKhachHang1 = Request.QueryString["MaKhachHang"];
        int makhachhang = Convert.ToInt16(MaKhachHang1);
        Response.Redirect("~/XemDonDatHang.aspx?MaKhachHang=" + makhachhang);
    }
    protected void btnDangKy_Click(object sender, EventArgs e)
    {
        if (btnDangKy.Text == "Thoát")
        {
            Response.Redirect("~/Default3.aspx");
        }
    }
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
      
    }
}
