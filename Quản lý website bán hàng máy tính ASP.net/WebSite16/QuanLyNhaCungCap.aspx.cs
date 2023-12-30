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

public partial class QuanLyNhaCungCap : System.Web.UI.Page
{
    WedMayTinhDataContext db = new WedMayTinhDataContext();
    void HienThi()
    {
        var dsnhacungcap = from p in db.NhaCungCaps select new {MaNhaCungCap= p.MaNhaCungCap, p.DiaChi, p.SoDienThoai, p.TenNhaCungCap };
        grdNhaCungCap.DataSource = dsnhacungcap;
        grdNhaCungCap.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        HienThi();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int manhacungcap = Convert.ToInt32(grdNhaCungCap.Rows[grdNhaCungCap.SelectedIndex].Cells[0].Text);
        NhaCungCap nhacungcap = db.NhaCungCaps.SingleOrDefault(p => p.MaNhaCungCap == manhacungcap);
        txtDiaChi.Text = nhacungcap.DiaChi;
        txtSoDienThoai.Text = nhacungcap.SoDienThoai;
        txtTenNhaCungCap.Text = nhacungcap.TenNhaCungCap;
        btnNhap.Enabled = false;
        txtMaNhaCungCap.Text = manhacungcap.ToString();
    }
    protected void btnNhap_Click(object sender, EventArgs e)
    {

        if (kiemtra() == false)
        {
            db = new WedMayTinhDataContext();
            return;
        }
        else
        {
            NhaCungCap nhacungcap = new NhaCungCap();
            nhacungcap.TenNhaCungCap = txtTenNhaCungCap.Text;
            nhacungcap.DiaChi = txtDiaChi.Text;
            nhacungcap.SoDienThoai = txtSoDienThoai.Text;
            if ((from p in db.NhaCungCaps select p.MaNhaCungCap).Count() == 0)
            {
                nhacungcap.MaNhaCungCap = 0;
            }
            else
            {
                nhacungcap.MaNhaCungCap = (from p in db.NhaCungCaps select p.MaNhaCungCap).Max() + 1;
            }
           
            db.NhaCungCaps.InsertOnSubmit(nhacungcap);
            db.SubmitChanges();
            HienThi();
        }
    }
    bool kiemtra()
    {
        bool kt = true;
       // var dstennhacungcap = from p in db.NhaCungCaps select p.TenNhaCungCap;
        //foreach (string tennhacungcap in dstennhacungcap)
        //{
        //    if (tennhacungcap == txtTenNhaCungCap.Text)
        //    {
        //        kt= false;
        //    }
        //}
        try
        {
            string sodienthoai = txtSoDienThoai.Text;

            for (int i = 0; i < sodienthoai.Length; i++)
            {

                int a = Convert.ToInt32(sodienthoai[i]);
            }
        }
        catch
        {
           kt = false;
        }
        if (txtTenNhaCungCap.Text == "")
        {
            kt = false;
        }
        return kt;
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        var dstennhacungcap = from p in db.NhaCungCaps select p.TenNhaCungCap;
        foreach (string tennhacungcap in dstennhacungcap)
        {
            if (tennhacungcap == args.Value)
            {

                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
   
    }
    protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
    {
        try
        {
            string sodienthoai = txtSoDienThoai.Text;

            for (int i = 0; i < sodienthoai.Length; i++)
            {

                int a = Convert.ToInt32(sodienthoai[i].ToString());
            }
            args.IsValid = true;
        }
        catch
        {
            args.IsValid = false;
        }
        
    }
    protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (txtTenNhaCungCap.Text == "")
        {
            CustomValidator1.ErrorMessage = "Tên nhà cung cấp không để trống";
            args.IsValid = false;
        }
        else
        {
            args.IsValid = true;
        }
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        if (txtMaNhaCungCap.Text == "")
        {
            CustomValidator1.ErrorMessage = "Hãy chọn một nhà cung cấp để xóa!";
            CustomValidator1.IsValid = false;
        }
        else
        {
            CustomValidator1.IsValid = true;
            NhaCungCap nhacungcap = db.NhaCungCaps.SingleOrDefault(p => p.MaNhaCungCap == Convert.ToInt32(txtMaNhaCungCap.Text));
            if (nhacungcap != null)
            {
                db.NhaCungCaps.DeleteOnSubmit(nhacungcap);
                db.SubmitChanges();
                HienThi();
            }
        }
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
        if (kiemtra() == false)
        {
            return;
        }
        if (txtMaNhaCungCap.Text == "")
        {
            CustomValidator1.ErrorMessage = "Bạn hãy chọn một nhà cung cấp để sủa";
            CustomValidator1.IsValid = false;
            return;
        }
        else
        {
            CustomValidator1.IsValid = true;
            NhaCungCap nhacungcap = db.NhaCungCaps.SingleOrDefault(p => p.MaNhaCungCap == Convert.ToInt32(txtMaNhaCungCap.Text));
            if (nhacungcap != null)
            {
                nhacungcap.TenNhaCungCap = txtTenNhaCungCap.Text;
                nhacungcap.SoDienThoai = txtSoDienThoai.Text;
                nhacungcap.DiaChi = txtDiaChi.Text;
                db.SubmitChanges();
                
                HienThi();
            }
        }
    }
    protected void txtMaNhaCungCap_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        txtDiaChi.Text = "";
        txtMaNhaCungCap.Text = "";
        txtSoDienThoai.Text = "";
        txtTenNhaCungCap.Text = "";
        btnNhap.Enabled = true;
        txtMaNhaCungCap.Enabled = true;
    }
}
