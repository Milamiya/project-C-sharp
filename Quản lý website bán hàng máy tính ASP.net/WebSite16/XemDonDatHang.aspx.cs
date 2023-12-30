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

public partial class XemDonDatHang : System.Web.UI.Page
{
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

    WedMayTinhDataContext db = new WedMayTinhDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
        string makh= Request.QueryString["MaKhachHang"];
        var dsdonhang = from p in db.DonDatHangs where p.MaKhachHang.ToString()==makh select new { p.MaDonHang, p.KhachHang.TenKhachHang, p.NgayDatHang, p.TongTien, p.TinhTrang };

        GridView1.DataSource = dsdonhang;
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DonDatHangs dondathang = db.DonDatHangs.SingleOrDefault(p => p.MaDonHang.ToString() == GridView1.Rows[GridView1.SelectedIndex].Cells[0].Text);


        int makh = dondathang.MaKhachHang;
        double tongtien = 0;
        KhachHang kh = db.KhachHangs.SingleOrDefault(p => p.MaKhachHang == makh);

        var dschitiet = from p in db.ChiTietDonHangs
                        where p.MaDonHang == dondathang.MaDonHang
                        select new
                        {
                            p.MaSanPham,
                            p.SanPhams.TenSP,
                            p.SoLuong,

                            DonGia = TinhGiamGia(p.SanPhams.SanPham_KhuyenMai.KhuyenMai.GiaCanGiam, Convert.ToDouble(p.SanPhams.GiaBan * p.SoLuong))
                        };


        foreach (var giohang in dschitiet)
        {
            tongtien = tongtien + Convert.ToDouble(giohang.DonGia);

        }
        lblTongTien.Text = HienThiGia(tongtien).ToString();
        lblDiaChi.Text = kh.DiaChi;
        lblEmail.Text = kh.Email;
        lblSoDienThoai.Text = kh.SoDienThoai.ToString();
        lblTenKH.Text = kh.TenKhachHang;
        TextArea1.Value = dondathang.YeuCauKhachHang;
        GridView2.DataSource = dschitiet;
        GridView2.DataBind();

      
        if (dondathang.TinhTrang == "Chưa sử lý")
        {
            btnHuyBo.Enabled = false;
        }
        if (dondathang.TinhTrang == "Sử lý xong")
        {
            btnHuyBo.Enabled = false;
        }
    }
    protected void btnHuyBo_Click(object sender, EventArgs e)
    {

        string makh = Request.QueryString["MaKhachHang"];
        DonDatHangs dondathang = db.DonDatHangs.SingleOrDefault(p => p.MaDonHang.ToString() == GridView1.Rows[GridView1.SelectedIndex].Cells[0].Text);
        dondathang.TinhTrang = "Chưa sử lý";
        db.SubmitChanges();
        var dsdonhang = from p in db.DonDatHangs where p.MaKhachHang.ToString() == makh select new { p.MaDonHang, p.KhachHang.TenKhachHang, p.NgayDatHang, p.TongTien, p.TinhTrang };

        GridView1.DataSource = dsdonhang;
        GridView1.DataBind();
    }
}
