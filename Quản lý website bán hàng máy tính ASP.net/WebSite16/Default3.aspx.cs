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

public partial class Default3 : System.Web.UI.Page
{
    WedMayTinhDataContext db = new WedMayTinhDataContext();

    //public void ReadTable()
    //{
    //    var dssp = from p in db.SanPhams select p;
        
    //    string s = "<table id="+"ta"+" style=" +"float:left; overflow:hidden; position:relative; z-index:1; left:0px;  height:240px; width:5175px ;"+ align=center">";
        
    //   foreach(SanPhams sanpham in dssp)
    //   {
    //       s = s + "<tr><td class=" + "style4" + "> <a href=ChiTietSanPham.aspx?MaSanPham=" + sanpham.MaSanPham + ">" + sanpham.TenSP + "</a><br /></td></tr>";
               

    //    }
    //   foreach (SanPhams sanpham in dssp)
    //   {
    //       s = s + "<tr><td class=" + "style1" + "> <img  src=" + sanpham.HinhAnh + " style=" + " max-width:190px;" + " />" + "</td></tr>";
    //   }
    //    s = s + "</table>";
    //    con.Close();
    //    Response.Write(s);
    //}
   public void TinKhuyenMai()
    {
        var dskhuyenmai = from p in db.KhuyenMais select p;
        string s = "<table>";
        foreach (KhuyenMai khuyenmai in dskhuyenmai)
        {
            s = s + "<tr><td> <asp:Image ImageUrl='~/image/Alienware-mini366.jpg' /> </td><td>" + khuyenmai.TenKhuyenMai + "</td></tr>";
        }
        s = s + "</table>";
        Response.Write(s);
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
       

        
            dl1.DataBind();
            var dssanphammaydeban = (from p in db.SanPhams where p.LoaiSP == "Máy tính bàn" select p).Take(4);
            dl2.DataSource = dssanphammaydeban;
            dl2.DataBind();

            var dslinhkienmaytinh = (from p in db.SanPhams where p.LoaiSP == "Linh kiện máy tính" select p).Take(4);
            dl3.DataSource = dslinhkienmaytinh;
            dl3.DataBind();

            string clickdangnhap = Request.QueryString["ClickDangNhap"];
            string makh = Request.QueryString["MaKhachHang"];

            if (clickdangnhap != null)
            {
                btnDangNhap.Text = "Tài khoản";
                btnDangKy.Text = "Thoát";
               int sogiohang=(from p in db.GioHangs where p.MaKhachHang.ToString()==makh select p).Count();
               btnGioHangCuaBan.Text = "Giỏ hàng của bạn có " + sogiohang.ToString() + "sản phẩm";
               btnGioHangCuaBan.PostBackUrl ="~/GioHang.aspx?MaKhachHang=" + makh;
            }

        }
    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {


    }

    protected void dl3_EditCommand(object source, DataListCommandEventArgs e)
    {
       
    }
    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
        if (btnDangNhap.Text != "Tài khoản")
        {
            Response.Redirect("~/TrangDangNhap.aspx?ClickDangNhap=true");
        }
        else
        {
        }
       

    }
    protected void btnImg_Click(object sender, EventArgs e)
    {

        string clickdangnhap = Request.QueryString["ClickDangNhap"];
        if (clickdangnhap != null)
        {

        }
        else
        {
        }
    }
    protected void btnDangKy_Click(object sender, EventArgs e)
    {
        if (btnDangKy.Text =="Thoát")
        {
            Response.Redirect("~/Default3.aspx");
        }
    }
    protected void dl1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        LinkButton lable = (LinkButton)e.Item.FindControl("lbtTenSP");
        SanPhams sanpham = db.SanPhams.SingleOrDefault(p => p.TenSP == lable.Text);
        string clickdangnhap = Request.QueryString["ClickDangNhap"];
        if (clickdangnhap == null)
        {
            Response.Redirect("~/TrangDangNhap.aspx?MaSanPham=" + sanpham.MaSanPham);
        }
        else
        {
            string makh = Request.QueryString["MaKhachHang"];
            GioHangs giohang = db.GioHangs.SingleOrDefault(p => p.MaKhachHang.ToString() == makh && p.MaSanPham==sanpham.MaSanPham);
            if (giohang != null)
            {
                giohang.SoLuong = giohang.SoLuong + 1;
                db.SubmitChanges();
            }
            else
            {
                giohang = new GioHangs();
                giohang.SoLuong = 1;
                giohang.MaSanPham = Convert.ToInt32(sanpham.MaSanPham);
                giohang.MaKhachHang = Convert.ToInt32(makh);
                db.GioHangs.InsertOnSubmit(giohang);
                db.SubmitChanges();
            }
            Response.Redirect("~/GioHang.aspx?MaKhachHang="+makh);
        }
    }
    protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
    {
        var dssanphamlaptop = (from p in db.SanPhams where p.LoaiSP == "Lap top" select p).Take(4);



        e.Result = dssanphamlaptop;
    }
    string HienThiGia(double gia)
    {
        string giatrave = "  VND";
        string strgia = gia.ToString();
        int dodai = strgia.Length;
        int sodaucham = strgia.Length / 3;

        for (int i = strgia.Length - 1; i >= 0; i--)
        {
            if ((strgia.Length-1- i) % 3 == 0 && i != strgia.Length - 1)
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
    double TinhGiamGia(string giacamgiam,double giaban)
    {
        double Giasaukhigiam = 0;
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
    protected void dl1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        DataListItem item = e.Item;
    

            Label lbGiaMoi = (Label)item.FindControl("GiaBanMoiLabel");
       
            Label lbGiaBan = (Label)item.FindControl("GiaBanLabel");

            lbGiaBan.Text ="Giá:  "+ HienThiGia(Convert.ToDouble(lbGiaBan.Text));

            LinkButton linkbutton = (LinkButton)item.FindControl("lbtTenSP");
        SanPhams sanpham=db.SanPhams.SingleOrDefault(p=>p.TenSP==linkbutton.Text);

        Label tenkhuyenmai = (Label)item.FindControl("TenKhuyenMai");
        SanPham_KhuyenMai sanphamkhuyenmai = db.SanPham_KhuyenMais.SingleOrDefault(p => p.MaSanPham == sanpham.MaSanPham);

        if (sanphamkhuyenmai != null)
        {
            KhuyenMai khuyenmai = db.KhuyenMais.SingleOrDefault(p => p.MaKhuyenMai == sanphamkhuyenmai.MaKhuyenMai);
            tenkhuyenmai.Text = khuyenmai.NoiDungKhuyenMai;
            if (khuyenmai.NoiDungKhuyenMai.ToString().Length > 30)
            {
                tenkhuyenmai.Text = khuyenmai.NoiDungKhuyenMai.Substring(0, 30) + "...";
            }
            lbGiaBan.Font.Strikeout = true;
            lbGiaMoi.ForeColor = System.Drawing.Color.Red;
            lbGiaMoi.Text ="Giá bán:  "+HienThiGia(Convert.ToDouble(TinhGiamGia(khuyenmai.GiaCanGiam, sanpham.GiaBan).ToString()));
        }
        else
        {
            lbGiaBan.Font.Size = 11;
            lbGiaBan.Font.Bold = true;
        }
       
           
    }
    protected void dl2_ItemCommand(object source, DataListCommandEventArgs e)
    {

        LinkButton lable = (LinkButton)e.Item.FindControl("TenSPLabel");
        SanPhams sanpham = db.SanPhams.SingleOrDefault(p => p.TenSP == lable.Text);
        string clickdangnhap = Request.QueryString["ClickDangNhap"];
        if (clickdangnhap == null)
        {
            Response.Redirect("~/TrangDangNhap.aspx?MaSanPham=" + sanpham.MaSanPham);
        }
        else
        {
            string makh = Request.QueryString["MaKhachHang"];
            GioHangs giohang = db.GioHangs.SingleOrDefault(p => p.MaKhachHang.ToString() == makh && p.MaSanPham == sanpham.MaSanPham);
            if (giohang != null)
            {
                giohang.SoLuong = giohang.SoLuong + 1;
                db.SubmitChanges();
            }
            else
            {
                giohang = new GioHangs();
                giohang.SoLuong = 1;
                giohang.MaSanPham = Convert.ToInt32(sanpham.MaSanPham);
                giohang.MaKhachHang = Convert.ToInt32(makh);
                db.GioHangs.InsertOnSubmit(giohang);
                db.SubmitChanges();
            }
            Response.Redirect("~/GioHang.aspx?MaKhachHang=" + makh);
        }
    }
    protected void dl2_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        DataListItem item = e.Item;


        Label lbGiaMoi = (Label)item.FindControl("GiaBanMoiLabel");

        Label lbGiaBan = (Label)item.FindControl("GiaBanLabel");

        lbGiaBan.Text = "Giá:  " + HienThiGia(Convert.ToDouble(lbGiaBan.Text));

        LinkButton linkbutton = (LinkButton)item.FindControl("TenSPLabel");
        SanPhams sanpham = db.SanPhams.SingleOrDefault(p => p.TenSP == linkbutton.Text);

        Label tenkhuyenmai = (Label)item.FindControl("TenKhuyenMai");
        SanPham_KhuyenMai sanphamkhuyenmai = db.SanPham_KhuyenMais.SingleOrDefault(p => p.MaSanPham == sanpham.MaSanPham);

        if (sanphamkhuyenmai != null)
        {
            KhuyenMai khuyenmai = db.KhuyenMais.SingleOrDefault(p => p.MaKhuyenMai == sanphamkhuyenmai.MaKhuyenMai);
            if (khuyenmai.NoiDungKhuyenMai.ToString().Length > 30)
            {
                tenkhuyenmai.Text = khuyenmai.NoiDungKhuyenMai.Substring(0, 30) + "...";
            }
            else
            {
                tenkhuyenmai.Text = khuyenmai.NoiDungKhuyenMai;
            }
            lbGiaBan.Font.Strikeout = true;

            lbGiaMoi.ForeColor = System.Drawing.Color.Red;
            lbGiaMoi.Text = "Giá bán:  " + HienThiGia(Convert.ToDouble(TinhGiamGia(khuyenmai.GiaCanGiam, sanpham.GiaBan).ToString()));
        }
        else
        {
            lbGiaBan.Font.Size = 11;
            lbGiaBan.Font.Bold = true;
        }
       
    }
}
