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

public partial class DonDatHang : System.Web.UI.Page
{
    WedMayTinhDataContext db = new WedMayTinhDataContext();
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
    protected void Page_Load(object sender, EventArgs e)
    {
        string makh=Request.QueryString["MaKhachHang"];
        double tongtien = 0;
        KhachHang kh = db.KhachHangs.SingleOrDefault(p => p.MaKhachHang.ToString() == makh);
        var dsgiohang = from p in db.GioHangs
                        where p.MaKhachHang.ToString() == makh
                        select new
                        {
                            p.MaSanPham,
                            p.SanPhams.TenSP,
                            p.SoLuong,
                            DonGia = TinhGiamGia( p.SanPhams.SanPham_KhuyenMai.KhuyenMai.GiaCanGiam,Convert.ToDouble( p.SanPhams.GiaBan*p.SoLuong))
                        };
        foreach (var giohang in dsgiohang)
        {
            tongtien = tongtien + Convert.ToDouble(giohang.DonGia);
            
        }
        lblTongTien.Text = HienThiGia(tongtien).ToString();
        lblDiaChi.Text = kh.DiaChi;
        lblEmail.Text = kh.Email;
        lblSoDienThoai.Text = kh.SoDienThoai.ToString();
        lblTenKH.Text = kh.TenKhachHang;
       
        GridView1.DataSource = dsgiohang;
        GridView1.DataBind();


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
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      
      
    }

    protected void GridView1_DataBound(object sender, EventArgs e)
    {

    }

    protected void btnGui_Click(object sender, EventArgs e)
    {

        int makhachhang =
       Convert.ToInt16(Request.QueryString["MaKhachHang"]);
        var dsgiohang = from p in db.GioHangs
                        where p.MaKhachHang == makhachhang
                        select new
                        {
                            p.MaSanPham,
                            p.SanPhams.TenSP,
                            p.SoLuong,
                            DonGia = TinhGiamGia(p.SanPhams.SanPham_KhuyenMai.KhuyenMai.GiaCanGiam, p.SanPhams.GiaBan)
                        };
        double tongtien = 0;
        foreach (var giohang in dsgiohang)
        {
            tongtien = tongtien + Convert.ToDouble(giohang.DonGia);

        }
        DonDatHangs dondathang = new DonDatHangs();
        dondathang.MaKhachHang = makhachhang;
        dondathang.NgayDatHang = DateTime.Now.ToShortDateString();
        dondathang.TinhTrang = "Chưa xử lý";
        dondathang.TongTien = tongtien;
        dondathang.YeuCauKhachHang = TextArea1.Value;
        db.DonDatHangs.InsertOnSubmit(dondathang);
        db.SubmitChanges();
      
        foreach (var giohang in dsgiohang)
        {
            ChiTietDonHang chitiet = new ChiTietDonHang();
            chitiet.MaDonHang = dondathang.MaDonHang;
            chitiet.MaSanPham = giohang.MaSanPham;
            chitiet.SoLuong = Convert.ToInt16(giohang.SoLuong);
            db.ChiTietDonHangs.InsertOnSubmit(chitiet);
            db.SubmitChanges();
        }


        Response.Write("<script> alert('Gửi thành công') </script>");

        Response.Redirect("~/GioHang.aspx?MaKhachHang=" + makhachhang);

    }
}
