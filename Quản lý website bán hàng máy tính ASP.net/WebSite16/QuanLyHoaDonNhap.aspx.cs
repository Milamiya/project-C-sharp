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

public partial class QuanLyHoaDonNhap : System.Web.UI.Page
{

    WedMayTinhDataContext db = new WedMayTinhDataContext();
    void load()
    {
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        load();
    }
    protected void btnNhap_Click(object sender, EventArgs e)
    {
        
        CustomValidator2.IsValid = true;
       
       
        try
        {
            DateTime dt = Convert.ToDateTime(txtNgayNhap.Text);
        }
        catch
        {
            CustomValidator2.ErrorMessage = "Ngày nhập không đúng định dạng";
            CustomValidator2.IsValid = false;
            return;
        }
        HoaDonNhap hoadon;
            hoadon = new HoaDonNhap();
            hoadon.NgayNhap = txtNgayNhap.Text;
            hoadon.MaNhanVien = 1;
            db.HoaDonNhaps.InsertOnSubmit(hoadon);
            db.SubmitChanges();
        
        load();
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
        HoaDonNhap hoadon = db.HoaDonNhaps.SingleOrDefault(p => p.SoHoaDon.ToString() == txtSoHD.Text);
        if (txtSoHD.Text== "")
        {
            CustomValidator1.ErrorMessage = "Bạn hãy chọn 1 số hóa đon";
            CustomValidator1.IsValid = false;
        }
        else
        {
            CustomValidator1.IsValid = true;
            hoadon.SoHoaDon = Convert.ToInt32(txtSoHD.Text);
            hoadon.NgayNhap = txtNgayNhap.Text;
            db.SubmitChanges();
        }
        load();
        btnNhap.Enabled = true;
        txtSoHD.Text = "";
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
         HoaDonNhap hoadon = db.HoaDonNhaps.SingleOrDefault(p => p.SoHoaDon.ToString() == txtSoHD.Text);
         if (hoadon == null)
         {
             CustomValidator1.ErrorMessage = "Bạn hãy chọn 1 hóa đon để xóa";
             CustomValidator1.IsValid = false;
         }
         else
         {
             db.HoaDonNhaps.DeleteOnSubmit(hoadon);
             db.SubmitChanges();
         }
         load();
         btnNhap.Enabled = true;
         txtSoHD.Text = "";
    }
    protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
    {
        var dshoadon = from 
                        p in db.HoaDonNhaps
                       select new { p.SoHoaDon, p.NgayNhap, p.NhanVien.HoTen};
        e.Result = dshoadon;

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        HoaDonNhap hoadon = db.HoaDonNhaps.SingleOrDefault(p => p.SoHoaDon.ToString() == GridView1.Rows[GridView1.SelectedIndex].Cells[0].Text);
        txtNgayNhap.Text = hoadon.NgayNhap;
        txtSoHD.Text = hoadon.SoHoaDon.ToString();
        btnNhap.Enabled = false;
    }
    protected void btnLamMoi_Click(object sender, EventArgs e)
    {
        txtNgayNhap.Text = "";
        txtSoHD.Text = "";
        btnNhap.Enabled = true;
    }
}
