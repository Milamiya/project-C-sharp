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

public partial class TrangDangNhap : System.Web.UI.Page
{

    WedMayTinhDataContext db = new WedMayTinhDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void bntDangNhap_Click(object sender, EventArgs e)
    {
        var dskhachanh = from p in db.KhachHangs select p;
        foreach (KhachHang khachhang in dskhachanh)
        {
            if (khachhang.TenDangNhap == txtUser.Text && khachhang.MatKhau == txtPass.Text)
            {
                string masp = Request.QueryString["MaSanPham"];
                if (masp != null)
                {
                    GioHangs giohang = db.GioHangs.SingleOrDefault(p => p.MaKhachHang == khachhang.MaKhachHang && p.MaSanPham.ToString() == masp);
                    if (giohang != null)
                    {
                        giohang.SoLuong = giohang.SoLuong + 1;
                        db.SubmitChanges();
                    }
                    else
                    {
                        giohang = new GioHangs();
                        giohang.SoLuong = 1;
                        giohang.MaSanPham = Convert.ToInt32(masp);
                        giohang.MaKhachHang = khachhang.MaKhachHang;
                        db.GioHangs.InsertOnSubmit(giohang);
                        db.SubmitChanges();
                    }
                }
                string clickdangnhap = Request.QueryString["ClickDangNhap"];
                if (clickdangnhap == null)
                {
                    Response.Redirect("~/GioHang.aspx?MaKhachHang=" + khachhang.MaKhachHang);
                }
                else
                {
                    Response.Redirect("~/Default3.aspx?ClickDangNhap=true+&MaKhachHang=" + khachhang.MaKhachHang);
                  
                }

            }

            else
            {
                CustomValidator1.ErrorMessage = "Tên đăng nhập hoặc mật khẩu không đúng";
                CustomValidator1.IsValid = false;
            }
        }
    }
}
