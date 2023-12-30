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

public partial class QuanLyTaiKhoan : System.Web.UI.Page
{

    WedMayTinhDataContext db = new WedMayTinhDataContext();
    void load()
    {

        GridView1.DataBind();

    }
     bool kiemtra()
    {
        bool kt = true;
        if (txtTenNhanVien.Text == "")
        {
            CustomValidator1.ErrorMessage = "Bạn hãy nhập tên nhân viên.";
            CustomValidator1.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator1.IsValid = true;
        }

        if (txtMatKhau.Text == "")
        {
            CustomValidator2.ErrorMessage = "Bạn hãy nhập mật khẩu.";
            CustomValidator2.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator2.IsValid = true;
        }
        if (txtTenTaiKhoan.Text == "")
        {
            CustomValidator3.ErrorMessage = "Bạn hãy nhập tên tài khoản";
            CustomValidator3.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator3.IsValid = true;
        }
        if (txtViTri.Text == "")
        {
            CustomValidator4.ErrorMessage = "Bạn hãy nhập vị trí nhân viên";
            CustomValidator4.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator4.IsValid = true;
        }
        try
        {
            for (int i = 0; i <   txtSoDienThoai.Text.Length; i++)
            {
                int a = Convert.ToInt32( txtSoDienThoai.Text[i].ToString());
            }
        }
        catch
        {
           if(txtSoDienThoai.Text!="")
            {
                CustomValidator5.ErrorMessage = "Số điện thoại chỉ nhập số";
                CustomValidator5.IsValid = false;
            }
            kt = false;
        }
        try
        {
            DateTime dt = Convert.ToDateTime(txtNgaySinh.Text);
        }
        catch
        {
            if (txtNgaySinh.Text != "")
            {
                CustomValidator6.ErrorMessage = "Ngày sinh không đúng định dạng";
                CustomValidator6.IsValid = false;
                kt = false;
            }
        }

        return kt;

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        load();
    }
    protected void btnNhap_Click(object sender, EventArgs e)
    {
        if (kiemtra() != false)
        {

            CustomValidator1.IsValid = true;
             var dstennv=from p in db.NhanViens select p.TenDangNhap;
             foreach (string ten in dstennv)
             {
                 if ( txtTenTaiKhoan.Text == ten)
                 {
                     CustomValidator1.ErrorMessage = "Đã tồn  tại tên tài khoản";
                     CustomValidator1.IsValid = false;
                     return;
                 }
             }
             NhanVien nhanvien = new NhanVien();
             nhanvien.TenDangNhap = txtTenTaiKhoan.Text;
             nhanvien.MatKhau = txtMatKhau.Text;
             nhanvien.HoTen = txtTenNhanVien.Text;
             nhanvien.ViTri = txtViTri.Text;
             nhanvien.NgaySinh = txtNgaySinh.Text;
             nhanvien.SoDienThoai = Convert.ToDouble(txtSoDienThoai.Text);
             nhanvien.DiaChi = txtDiaChi.Text;
             nhanvien.GioiTinh = txtGioiTinh.Text;
             nhanvien.HinhAnh = hinhanh.ImageUrl;
             db.NhanViens.InsertOnSubmit(nhanvien);
             db.SubmitChanges();

             ChucNang chucnang = new ChucNang();
             if (CheckBoxList1.Items[0].Selected == true)
             {
                 chucnang.QuanLyNhapHang = "true";
             }
             else
             {
                 chucnang.QuanLyNhapHang = "false";
             }
             if (CheckBoxList1.Items[1].Selected == true)
             {
                 chucnang.QuanLyMatHang = "true";
             }
             else
             {
                 chucnang.QuanLyMatHang = "false";
             }
             if (CheckBoxList1.Items[2].Selected == true)
             {
                 chucnang.QuanLyKhuyenMai = "true";
             }
             else
             {
                 chucnang.QuanLyKhuyenMai = "false";
             }
             if (CheckBoxList1.Items[3].Selected == true)
             {
                 chucnang.QuanLyTaiKhoan = "true";
             }
             else
             {
                 chucnang.QuanLyTaiKhoan= "false";
             }
             if (CheckBoxList1.Items[4].Selected == true)
             {
                 chucnang.QuanLyNhaCungCap = "true";
             }
             else
             {
                 chucnang.QuanLyNhaCungCap = "false";
             }
             if (CheckBoxList1.Items[5].Selected == true)
             {
                 chucnang.QuanLyDonHang = "true";
             }
             else
             {
                 chucnang.QuanLyDonHang = "false";
             }
             if (CheckBoxList1.Items[6].Selected == true)
             {
                 chucnang.ThongKe = "true";
             }
             else
             {
                 chucnang.ThongKe = "false";
             }
             chucnang.MaNhanVien = nhanvien.MaNhanVien;
             db.ChucNangs.InsertOnSubmit(chucnang);
             db.SubmitChanges();
        }
        load();
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (txtHinhAnh.HasFile)
        {
            string add = MapPath("avata") + @"\" + txtHinhAnh.FileName;
            if (!System.IO.File.Exists(add))
            {
                 txtHinhAnh.SaveAs(add);
            }
            hinhanh.ImageUrl = "avata/" + txtHinhAnh.FileName;
            hinhanh.DataBind();
        }
    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        NhanVien nhanvien = db.NhanViens.SingleOrDefault(p => p.MaNhanVien.ToString() == GridView1.Rows[GridView1.SelectedIndex].Cells[0].Text);
        ChucNang chucnang = nhanvien.ChucNang;
        txtTenTaiKhoan.Text = nhanvien.TenDangNhap;
        txtMaTK.Text = nhanvien.MaNhanVien.ToString();
        txtNgaySinh.Text = nhanvien.NgaySinh;
        txtGioiTinh.SelectedItem.Text= nhanvien.GioiTinh;
        txtMatKhau.Text = nhanvien.MatKhau;
        txtSoDienThoai.Text = nhanvien.SoDienThoai.ToString();
        txtViTri.SelectedItem.Text = nhanvien.ViTri;
        txtDiaChi.Text = nhanvien.DiaChi;
        txtTenNhanVien.Text = nhanvien.HoTen;
        hinhanh.ImageUrl = nhanvien.HinhAnh;
        hinhanh.DataBind();
        CheckBoxList1.Items[0].Selected = Convert.ToBoolean(chucnang.QuanLyNhapHang);
        CheckBoxList1.Items[1].Selected = Convert.ToBoolean(chucnang.QuanLyMatHang);
        CheckBoxList1.Items[2].Selected = Convert.ToBoolean(chucnang.QuanLyKhuyenMai);
        CheckBoxList1.Items[3].Selected = Convert.ToBoolean(chucnang.QuanLyTaiKhoan);
        CheckBoxList1.Items[4].Selected = Convert.ToBoolean(chucnang.QuanLyNhaCungCap);
        CheckBoxList1.Items[5].Selected = Convert.ToBoolean(chucnang.QuanLyDonHang);

        CheckBoxList1.Items[6].Selected = Convert.ToBoolean(chucnang.ThongKe);
        btnNhap.Enabled = false;
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        btnNhap.Enabled = true;
        NhanVien nhanvien = db.NhanViens.SingleOrDefault(p => p.MaNhanVien.ToString() == txtMaTK.Text);

        if (nhanvien == null)
        {
            CustomValidator1.ErrorMessage = "Bạn hãy chọn một nhân viên để xóa";
            CustomValidator1.IsValid = false;
        }
        else
        {
            CustomValidator1.IsValid = true;
            db.NhanViens.DeleteOnSubmit(nhanvien);
            db.SubmitChanges();
        }

        txtMaTK.Text = "Mã tự tăng";

    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
        btnNhap.Enabled = true;
        NhanVien nhanvien = db.NhanViens.SingleOrDefault(p => p.MaNhanVien.ToString() == txtMaTK.Text);
        ChucNang chucnang = nhanvien.ChucNang;
        if (nhanvien == null)
        {
            CustomValidator1.ErrorMessage = "Bạn hãy chọn một nhân viên để xóa";
            CustomValidator1.IsValid = false;
        }
        else
        {
            if (kiemtra() == true)
            {
                nhanvien.HoTen = txtTenNhanVien.Text;
                nhanvien.GioiTinh = txtGioiTinh.Text;
                nhanvien.HinhAnh = hinhanh.ImageUrl;
                nhanvien.MatKhau = txtMatKhau.Text;
                nhanvien.NgaySinh = txtNgaySinh.Text;
                nhanvien.SoDienThoai = Convert.ToDouble(txtSoDienThoai.Text);
                nhanvien.TenDangNhap = txtTenTaiKhoan.Text;
                nhanvien.ViTri = txtViTri.SelectedItem.Text;

                if (CheckBoxList1.Items[0].Selected == true)
                {
                    chucnang.QuanLyNhapHang = "true";
                }
                else
                {
                    chucnang.QuanLyNhapHang = "false";
                }
                if (CheckBoxList1.Items[1].Selected == true)
                {
                    chucnang.QuanLyMatHang = "true";
                }
                else
                {
                    chucnang.QuanLyMatHang = "false";
                }
                if (CheckBoxList1.Items[2].Selected == true)
                {
                    chucnang.QuanLyKhuyenMai = "true";
                }
                else
                {
                    chucnang.QuanLyKhuyenMai = "false";
                }
                if (CheckBoxList1.Items[3].Selected == true)
                {
                    chucnang.QuanLyTaiKhoan = "true";
                }
                else
                {
                    chucnang.QuanLyTaiKhoan = "false";
                }
                if (CheckBoxList1.Items[4].Selected == true)
                {
                    chucnang.QuanLyNhaCungCap = "true";
                }
                else
                {
                    chucnang.QuanLyNhaCungCap = "false";
                }
                if (CheckBoxList1.Items[5].Selected == true)
                {
                    chucnang.QuanLyDonHang = "true";
                }
                else
                {
                    chucnang.QuanLyDonHang = "false";
                }
                if (CheckBoxList1.Items[6].Selected == true)
                {
                    chucnang.ThongKe = "true";
                }
                else
                {
                    chucnang.ThongKe = "false";
                }

                db.SubmitChanges();
            }
            load();
            txtMaTK.Text ="Mã tự tăng";
        }
    }
}
