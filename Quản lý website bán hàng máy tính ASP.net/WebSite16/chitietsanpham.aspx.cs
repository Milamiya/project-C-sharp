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

public partial class chitietsanpham : System.Web.UI.Page
{
    WedMayTinhDataContext db = new WedMayTinhDataContext();

    

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
 
    protected void Page_Load(object sender, EventArgs e)
    {
       string  masp = Request.QueryString["MaSanPham"];
       SanPhams sanpham = db.SanPhams.SingleOrDefault(p => p.MaSanPham.ToString() == masp);
       lblTenSanPham.Text = sanpham.TenSP;
       lblThongSoTongThe.Text = sanpham.ThongSoKyThuat;

       if (sanpham.SanPham_KhuyenMai.KhuyenMai.GiaCanGiam != null)
       {
              lblGiaBan.Font.Strikeout = true;
            lblGiaMoi.Text ="Giá bán:  "+HienThiGia(Convert.ToDouble(TinhGiamGia(sanpham.SanPham_KhuyenMai.KhuyenMai.GiaCanGiam,sanpham.GiaBan).ToString()));
        
           
       }
       lblGiaBan.Text = HienThiGia(sanpham.GiaBan);
       lblBaoHanh.Text = sanpham.BaoHanh;
       lblKhuyenMai.Text = sanpham.SanPham_KhuyenMai.KhuyenMai.TenKhuyenMai;
       if (sanpham.SoLuong > 0)
       {
           lblKhoHang.Text = "Còn hàng";
       }
       Image6.ImageUrl = sanpham.HinhAnh;
       Image6.DataBind();

       var chitiet = from p in db.ChiTietThongSos where p.ThongSoKyThuat==sanpham.ThongSoKyThuat select p;
        if (chitiet != null)
       {
           DataList1.DataSource = chitiet;
           DataList1.DataBind();
       }

    }
    double TinhGiamGia(string giacamgiam, double giaban)
    {
        double Giasaukhigiam = 0;
        if (giacamgiam[giacamgiam.Length - 1].ToString() == "%")
        {
            Giasaukhigiam = (Convert.ToDouble(giacamgiam.TrimEnd('%')) * giaban) / 100;
            return Giasaukhigiam;
        }
        else
        {
            Giasaukhigiam = giaban - Convert.ToDouble(giacamgiam);
            return Giasaukhigiam;
        }
    }
    protected void btnMua_Click(object sender, ImageClickEventArgs e)
    {
        string masp=Request.QueryString["MaSanPham"];
        SanPhams sanpham = db.SanPhams.SingleOrDefault(p => p.MaSanPham.ToString() == masp);
        Response.Redirect("~/TrangDangNhap.aspx?MaSanPham=" + sanpham.MaSanPham);
    }
}
