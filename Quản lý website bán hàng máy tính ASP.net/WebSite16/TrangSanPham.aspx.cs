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

public partial class TrangSanPham : System.Web.UI.Page
{
    WedMayTinhDataContext db = new WedMayTinhDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            var dssanpham = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text select p).Take(12);

            dl1.DataSource = dssanpham;
            dl1.DataBind();
        }
      

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnHinhAnh_Click(object sender, EventArgs e)
    {
    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
   
    }
    protected void txtTrang_SelectedIndexChanged(object sender, EventArgs e)
    {
       
            if (SapXep.SelectedItem.Text == "---Sắp xếp---")
            {
                var dssp = (from p in db.SanPhams where p.LoaiSP==drSanPham.SelectedItem.Text select p).Skip((txtTrang.SelectedIndex) * 12).Take(12);
                dl1.DataSource = dssp;
                dl1.DataBind();
            }
            if (SapXep.SelectedItem.Text == "Giá tăng dần")
            {
                var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderBy(p => p.GiaBan);
                dl1.DataSource = dssp;
                dl1.DataBind();
            }
            if (SapXep.SelectedItem.Text == "Giá giảm dần")
            {
                var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderByDescending(p => p.GiaBan);
                dl1.DataSource = dssp;
                dl1.DataBind();
            }
      
    }
    protected void SapXep_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(SapXep.SelectedItem.Text == "---Sắp xếp---")
        {
            if (drSanPham.Items.Count != 0)
            {
                var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text select p).Skip((txtTrang.SelectedIndex) * 12).Take(12);
                dl1.DataSource = dssp;
                dl1.DataBind();
            }
        }
        if (SapXep.SelectedItem.Text == "Giá tăng dần")
        {
            var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderBy(p => p.GiaBan);
            dl1.DataSource = dssp;
            dl1.DataBind();
        }
        if (SapXep.SelectedItem.Text == "Giá giảm dần")
        {
            var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderByDescending(p => p.GiaBan);
            dl1.DataSource = dssp;
            dl1.DataBind();
        }
       

       
    }
    protected void lbt24_Click(object sender, EventArgs e)
    {

        if (drSanPham.SelectedIndex != 0)
        {
            var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text & p.GiaBan >= 2000000 & p.GiaBan <= 4000000 select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderBy(p => p.GiaBan);

            dl1.DataSource = dssp;
            dl1.DataBind();
        }
       
    }
    protected void drSanPham_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        var toanbosp = from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text select p;
        float sotrang = toanbosp.Count() / 12;
        float sole = toanbosp.Count() % 12;
        if (sole != 0)
        {
            sotrang = sotrang + 1;
        }


        txtTrang.Items.Clear();
        for (int i = 1; i <= sotrang; i++)
        {
            txtTrang.Items.Add(i.ToString());
        }
        var dssanpham = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text select p).Take(12);

        dl1.DataSource = dssanpham;
        dl1.DataBind();
        SapXep.SelectedItem.Text = "---Sắp xếp---";
        if (txtTrang.Items.Count != 0)
        {
            txtTrang.SelectedItem.Text = "1";
        }
    }
    protected void lbt46_Click(object sender, EventArgs e)
    {

        var dssp = (from p in db.SanPhams where p.LoaiSP==drSanPham.SelectedItem.Text& p.GiaBan >= 4000000 & p.GiaBan <= 6000000 select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderBy(p => p.GiaBan);
        dl1.DataSource = dssp;
        dl1.DataBind();
    }
    protected void lbt68_Click(object sender, EventArgs e)
    {
        var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text & p.GiaBan >= 6000000 & p.GiaBan <= 8000000 select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderBy(p => p.GiaBan);
        dl1.DataSource = dssp;
        dl1.DataBind();
    }
    protected void lbt810_Click(object sender, EventArgs e)
    {
        var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text & p.GiaBan >= 8000000 & p.GiaBan <= 10000000 select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderBy(p => p.GiaBan);
        dl1.DataSource = dssp;
        dl1.DataBind();
    }
    protected void lbt1012_Click(object sender, EventArgs e)
    {
        var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text & p.GiaBan >= 10000000 & p.GiaBan <= 12000000 select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderBy(p => p.GiaBan);
        dl1.DataSource = dssp;
        dl1.DataBind();
    }
    protected void lbt1214_Click(object sender, EventArgs e)
    {
        var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text & p.GiaBan >= 12000000 & p.GiaBan <= 14000000 select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderBy(p => p.GiaBan);
        dl1.DataSource = dssp;
        dl1.DataBind();
    }
    protected void lbt1416_Click(object sender, EventArgs e)
    {
        var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text & p.GiaBan >= 14000000 & p.GiaBan <= 16000000 select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderBy(p => p.GiaBan);
        dl1.DataSource = dssp;
        dl1.DataBind();
    }
    protected void lbt1620_Click(object sender, EventArgs e)
    {
        var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text & p.GiaBan >= 16000000 & p.GiaBan <= 20000000 select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderBy(p => p.GiaBan);
        dl1.DataSource = dssp;
        dl1.DataBind();
    }
    protected void lbt20_Click(object sender, EventArgs e)
    {
        var dssp = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text & p.GiaBan >= 20000000 select p).Skip((txtTrang.SelectedIndex) * 12).Take(12).OrderBy(p => p.GiaBan);
        dl1.DataSource = dssp;
        dl1.DataBind();
    }
    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
       
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
         Label lable  = ( Label)e.Item.FindControl("TenNhaSanXuat");
         var dssanpham = (from p in db.SanPhams where p.LoaiSP == drSanPham.SelectedItem.Text&p.NhaSanXuat==lable.Text select p).Take(12);
        
         dl1.DataSource = dssanpham;
         dl1.DataBind();
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
    protected void dl1_ItemDataBound(object sender, DataListItemEventArgs e)
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
            tenkhuyenmai.Text = khuyenmai.NoiDungKhuyenMai;
            if (khuyenmai.NoiDungKhuyenMai.ToString().Length > 30)
            {
                tenkhuyenmai.Text = khuyenmai.NoiDungKhuyenMai.Substring(0, 30) + "...";
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
    protected void dl1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        DataListItem item = e.Item;
        LinkButton linkbutton = (LinkButton)item.FindControl("TenSPLabel");
        SanPhams sanpham = db.SanPhams.SingleOrDefault(p => p.TenSP == linkbutton.Text);
        Response.Redirect("~/TrangDangNhap.aspx?MaSanPham=" + sanpham.MaSanPham);
    }
}
