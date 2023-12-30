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

public partial class QuanLySamPham : System.Web.UI.Page
{
    WedMayTinhDataContext db = new WedMayTinhDataContext();
    void LoadTatCaSP()
    {
        //hien thi toan bo san pham
        //var dssanpham = from p in db.SanPhams select p;// new { p.MaSanPham, p.TenSP, p.LoaiSP, p.NhaSanXuat,  p.MaNhaCungCap, p.BaoHanh, p.SoLuong, p.ThongSoKyThuat, p.GiaBan, p.HinhAnh, p.GhiChu };
        //GridView2.DataSource = dssanpham;
        GridView2.DataBind();
        GridView3.DataBind();
        if (IsPostBack != true)
        {
            // hien thi tensp trong combobox
            var dstensp = from p in db.SanPhams select p.TenSP;
            txtTenSP.DataSource = dstensp;
            txtTenSP.DataBind();
            //hien thi ten nha cung cap trong combobox
            var dstennhacungcap = from p in db.NhaCungCaps select p.TenNhaCungCap;
            txtNhaCungCap.DataSource = dstennhacungcap;
            txtNhaCungCap.DataBind();
            // hien thi ten nha san xuat trong combobox
            var dstennhasanxuat = from p in db.NhaSanXuats select p.TenNhaSanXuat;
            txtNhaSanXuat.DataSource = dstennhasanxuat;
            txtNhaSanXuat.DataBind();
            ////hien thi loai san pham trong combobox
            //var dsloaisanpham = (from p in db.SanPhams select p.LoaiSP).Distinct();
            //txtLoaiSP.DataSource = dsloaisanpham;
            //txtLoaiSP.DataBind();
            //hien thi hoa don trong combobox
            var dshoadon = from p in db.HoaDonNhaps select p.SoHoaDon;
            if (dshoadon.Count() != 0)
            {
                txtSoHD.DataSource = dshoadon;
                txtSoHD.DataBind();
            }
            //hien thi khuyen mai trong combobox
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        LoadTatCaSP();
    }
    bool kiemtra()
    {
        bool kt = true;
        if (txtTenSP.Text == "")
        {
            CustomValidator1.ErrorMessage = "-Bạn hãy nhập tên sản phẩm";
            CustomValidator1.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator1.IsValid = true;
        }
        if (txtLoaiSP.Text == "")
        {
            CustomValidator2.ErrorMessage = "-Bạn hãy nhập loại sản phẩm";
            CustomValidator2.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator2.IsValid = true;
        }
        if (txtNhaSanXuat.Text == "")
        {
            CustomValidator3.ErrorMessage = "-Bạn hãy nhập tên nhà sản xuất";
            CustomValidator3.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator3.IsValid = true;
        }
        if (txtThongSoKyThuat.Text == "")
        {
            CustomValidator4.ErrorMessage = "-Bạn hãy nhập thông số kỹ thuật cho sản phẩm";
            CustomValidator4.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator4.IsValid = true;
        }
        if (txtNhaCungCap.Text == "")
        {
            CustomValidator5.ErrorMessage = "-Bạn hãy nhập nhà cung cấp cho sản phẩm";
            CustomValidator5.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator5.IsValid = true;
        }
        if (txtGiaNhap.Text == "")
        {
            CustomValidator6.ErrorMessage = "-Bạn hãy nhập giá nhập cho sản phẩm";
            CustomValidator6.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator6.IsValid = true;
        }
        if (txtSoLuong.Text == "")
        {
            CustomValidator7.ErrorMessage = "-Bạn hãy nhập số luong";
            CustomValidator7.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator7.IsValid = true;
        }

        if (txtSoHD.Text == "")
        {
            CustomValidator8.ErrorMessage = "-Bạn hãy chọn số hóa đon";
            CustomValidator8.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator8.IsValid = true;
        }

       


        try
        {
            for (int i = 0; i < txtSoLuong.Text.Length; i++)
            {
                int a = Convert.ToInt32(txtSoLuong.Text[i].ToString());
            }
        }
        catch
        {
            if (CustomValidator7.IsValid == true)
            {
                CustomValidator7.ErrorMessage = "-Số luong chỉ nhập số";
                CustomValidator7.IsValid = false;
            }
            kt = false;
        }
        try
        {
            for (int j = 0; j < txtGiaNhap.Text.Length; j++)
            {
                int b = Convert.ToInt32(txtGiaNhap.Text[j].ToString());
            }
        }
        catch
        {
            if (CustomValidator6.IsValid == true)
            {
                CustomValidator6.ErrorMessage = "-Giá nhập chỉ nhập số";
                CustomValidator6.IsValid = false;
            }
            kt = false;
        }
        bool tontai = false;
        var dssohoadon = from p in db.HoaDonNhaps select p.SoHoaDon;
        foreach ( double sohoadon in dssohoadon)
        {
            if (sohoadon.ToString() ==  txtSoHD.Text)
            {

             
                tontai = true;

                break;
            }
            else
            {
                tontai = false;
            }
        }
        if (tontai == false)
        {
            CustomValidator8.ErrorMessage = "-Không tồn tại số hóa đon bạn vùa nhập!";
            CustomValidator8.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator8.IsValid = true;
        }
        return kt;

    }
    void updatesoluongsp(string type, ChiTietNhap chitietnhap)
    {
        SanPhams sp = db.SanPhams.SingleOrDefault(p => p.MaSanPham == chitietnhap.MaSanPham);
        if (type == "insert")
        {
            sp.SoLuong = sp.SoLuong + Convert.ToInt16(txtSoLuong.Text);
            db.SubmitChanges();
        }
        if (type == "update")
        {
            sp.SoLuong = sp.SoLuong -chitietnhap.SoLuongNhap + Convert.ToInt32(txtSoLuong.Text);
            db.SubmitChanges();
        }
        if (type == "delete")
        {
            sp.SoLuong = sp.SoLuong - chitietnhap.SoLuongNhap;
            db.SubmitChanges();
        }
    }
    protected void btnNhap_Click(object sender, EventArgs e)
    {
        if (kiemtra() == true)
        {
            NhaCungCap nhacungcap = db.NhaCungCaps.SingleOrDefault(p => p.TenNhaCungCap == txtNhaCungCap.Text);
          SanPhams Sanpham=db.SanPhams.SingleOrDefault(p=>p.TenSP==txtTenSP.Text);
                if (Sanpham != null)
                {
                    ChiTietNhap chitietnhap = db.ChiTietNhaps.SingleOrDefault(p => p.MaSanPham == Sanpham.MaSanPham && p.SoHoaDon.ToString() == txtSoHD.Text);
                     
                    if (chitietnhap!=null)
                    {
                        chitietnhap.SoLuongNhap = chitietnhap.SoLuongNhap + Convert.ToInt16(txtSoLuong.Text);
                        chitietnhap.GiaNhap = chitietnhap.GiaNhap + Convert.ToDouble(txtGiaNhap.Text);
                        db.SubmitChanges();
                        updatesoluongsp("insert", chitietnhap);

                    }
                    else
                    {
                        ChiTietNhap Chitietnhap = new ChiTietNhap();
                        Chitietnhap.SoLuongNhap = Convert.ToInt16(txtSoLuong.Text);
                        Chitietnhap.SoHoaDon = Convert.ToInt16(txtSoHD.Text);
                        Chitietnhap.GhiChu = txtGhichu.Text;
                        Chitietnhap.GiaNhap = Convert.ToDouble(txtGiaNhap.Text);


                        if (nhacungcap != null)
                        {
                            Chitietnhap.MaNhaCungCap = nhacungcap.MaNhaCungCap;
                        }
                        Chitietnhap.MaSanPham = Sanpham.MaSanPham;
                        Chitietnhap.NgayNhap = DateTime.Now.ToShortDateString();
                        db.ChiTietNhaps.InsertOnSubmit(Chitietnhap);
                        db.SubmitChanges();
                        updatesoluongsp("insert", Chitietnhap);

                    }
                }
            else
                {

                

                SanPhams sanpham = new SanPhams();
                sanpham.TenSP = txtTenSP.Text;
                sanpham.ThongSoKyThuat = txtThongSoKyThuat.Text;
                sanpham.NhaSanXuat = txtNhaSanXuat.Text;
                sanpham.LoaiSP = txtLoaiSP.Text;
                sanpham.HinhAnh = hinhanh.ImageUrl;
                sanpham.BaoHanh = txtBaoHanh.Text;
                sanpham.SoLuong = Convert.ToInt16(txtSoLuong.Text);

                db.SanPhams.InsertOnSubmit(sanpham);
                db.SubmitChanges();

                ChiTietNhap chitietnhap = new ChiTietNhap();
                chitietnhap.SoLuongNhap = Convert.ToInt16(txtSoLuong.Text);
                chitietnhap.SoHoaDon = Convert.ToInt16(txtSoHD.Text);
                chitietnhap.GhiChu = txtGhichu.Text;
                chitietnhap.GiaNhap = Convert.ToDouble(txtGiaNhap.Text);


                if (nhacungcap != null)
                {
                    chitietnhap.MaNhaCungCap = nhacungcap.MaNhaCungCap;
                }
                chitietnhap.MaSanPham = sanpham.MaSanPham;
                chitietnhap.NgayNhap = DateTime.Now.ToShortDateString();
                db.ChiTietNhaps.InsertOnSubmit(chitietnhap);
                db.SubmitChanges();
            }

        }
        LoadTatCaSP();
    }


    protected void btnupload_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string add = MapPath("image")+ @"\" +FileUpload1.FileName;
            if (!System.IO.File.Exists(add))
            {
                FileUpload1.SaveAs(add);
            }
            hinhanh.ImageUrl = "image/" + FileUpload1.FileName;
            hinhanh.DataBind();
        }
        
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void CustomValidator8_ServerValidate(object source, ServerValidateEventArgs args)
    {

    }
    protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
    {
        var dssp = from p in db.ChiTietNhaps where p.SoHoaDon.ToString() == txtSoHD.Text select new {p.MaSanPham, p.NhaCungCap.TenNhaCungCap, p.SoLuongNhap, p.SanPhams.TenSP, p.NgayNhap, p.GiaNhap, p.SoHoaDon, p.GhiChu };
        e.Result = dssp;
    }
    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        SanPhams sanpham = db.SanPhams.SingleOrDefault(p => p.MaSanPham.ToString() == GridView3.Rows[GridView3.SelectedIndex].Cells[0].Text.ToString());

        ChiTietNhap chitietnhap = db.ChiTietNhaps.SingleOrDefault(p => p.MaSanPham == sanpham.MaSanPham && p.SoHoaDon.ToString() == GridView3.Rows[GridView3.SelectedIndex].Cells[6].Text);

        txtSoHD.Enabled = false;
        txtThongSoKyThuat.Enabled = false;
        txtTenSP.Enabled = false;
        txtNhaSanXuat.Enabled = false;
        txtLoaiSP.Enabled = false;
        FileUpload1.Enabled = false;
        btnupload.Enabled = false;
        txtNhaSanXuat.Enabled = false;
        txtThongSoKyThuat.Enabled = false;
        txtBaoHanh.Enabled = false;

        if (sanpham.HinhAnh != null)
        {
            hinhanh.ImageUrl = sanpham.HinhAnh;
            hinhanh.DataBind();
        }

        txtNhaSanXuat.SelectedItem.Text = sanpham.NhaSanXuat;


        txtSoHD.SelectedItem.Text = chitietnhap.SoHoaDon.ToString();
        txtNhaCungCap.SelectedItem.Text = chitietnhap.NhaCungCap.TenNhaCungCap;
        txtSoLuong.Text = chitietnhap.SoLuongNhap.ToString();
        txtTenSP.SelectedItem.Text = sanpham.TenSP;
        txtGiaNhap.Text = chitietnhap.GiaNhap.ToString();
        txtGhichu.Text = chitietnhap.GhiChu;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        txtSoHD.Enabled = true;
        txtThongSoKyThuat.Enabled = true;
        txtTenSP.Enabled = true;
        txtNhaSanXuat.Enabled = true;
        txtLoaiSP.Enabled = true;
        FileUpload1.Enabled = true;
        btnupload.Enabled = true;
        txtNhaSanXuat.Enabled = true;

        txtSoHD.SelectedItem.Value = "";
        txtThongSoKyThuat.Text = "";
        txtTenSP.SelectedItem.Value = "";
       


        txtLoaiSP.SelectedItem.Value = "";
        txtNhaSanXuat.SelectedItem.Value = "";
        txtNhaCungCap.SelectedItem.Value = "";
        txtGhichu.Text = "";
        //txtGiaNhap.Text = "";
        // txtKhuyenMai.SelectedItem.Value = "";
        txtSoLuong.Text = "";
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        SanPhams sanpham=db.SanPhams.SingleOrDefault(p=>p.TenSP==txtTenSP.Text);
      
        ChiTietNhap chitietnhap = db.ChiTietNhaps.SingleOrDefault(p => p.SoHoaDon.ToString() == txtSoHD.Text && p.MaSanPham == sanpham.MaSanPham);

        if (chitietnhap == null)
        {
            CustomValidator1.ErrorMessage = "Bạn hãy chọn một chi tiết nhập để xóa";
            CustomValidator1.IsValid = false;
        }
        else
        {
            CustomValidator1.IsValid = true;
            db.ChiTietNhaps.DeleteOnSubmit(chitietnhap);

            updatesoluongsp("delete", chitietnhap);

            db.SubmitChanges();
            LoadTatCaSP();
        }

        txtSoHD.Enabled = true;
        txtThongSoKyThuat.Enabled = true;
        txtTenSP.Enabled = true;
        txtNhaSanXuat.Enabled = true;
        txtLoaiSP.Enabled = true;
        FileUpload1.Enabled = true;
        btnupload.Enabled = true;
        txtNhaSanXuat.Enabled = true;
        txtThongSoKyThuat.Enabled = true;
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {

        SanPhams sanpham = db.SanPhams.SingleOrDefault(p => p.TenSP == txtTenSP.Text);

        ChiTietNhap chitietnhap = db.ChiTietNhaps.SingleOrDefault(p => p.SoHoaDon.ToString() == txtSoHD.Text && p.MaSanPham == sanpham.MaSanPham);

        if (chitietnhap == null)
        {
            CustomValidator1.ErrorMessage = "Bạn hãy chọn một chi tiết nhập để sửa ";
            CustomValidator1.IsValid = false;
        }
        else
        {
            updatesoluongsp("update", chitietnhap);
            chitietnhap.SoLuongNhap = Convert.ToInt32(txtSoLuong.Text);
            chitietnhap.GiaNhap = Convert.ToDouble(txtGiaNhap.Text);
            db.SubmitChanges();
           
            LoadTatCaSP();
        }

        txtSoHD.Enabled = true;
        txtThongSoKyThuat.Enabled = true;
        txtTenSP.Enabled = true;
        txtNhaSanXuat.Enabled = true;
        txtLoaiSP.Enabled = true;
        FileUpload1.Enabled = true;
        btnupload.Enabled = true;
        txtNhaSanXuat.Enabled = true;
        txtThongSoKyThuat.Enabled = true;
    }
    protected void txtTenSP_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}