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



using System.Runtime.InteropServices;

public partial class QuanLyKhuyenMai : System.Web.UI.Page
{
    

    public class MsgBox
    {
        [DllImport("User32.dll")]

        public static extern int MessageBox(int h, String s, String s1, int type);


    }
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadTrang();
    }
    void LoadTrang()
    {
        
        GridView2.DataBind();
    }
    bool kiemtra()
    {
        bool kt = true;
        if (txtTenKhuyenMai.Text == "")
        {
            CustomValidator1.ErrorMessage = "-Bạn hãy nhập tên khuyến mại";
            CustomValidator1.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator1.IsValid = true;
        }
        int sokituphantram=0;
        try
        {
            for (int j = 0; j < txtGiaCanGiam.Text.Length; j++)
            {
                if (txtGiaCanGiam.Text[j].ToString() != "%")
                {
                    int b = Convert.ToInt32(txtGiaCanGiam.Text[j].ToString());
                }
                else
                {
                    sokituphantram = sokituphantram + 1;
                    if (sokituphantram == 2||j!=txtGiaCanGiam.Text.Length-1)
                    {

                        CustomValidator2.ErrorMessage = "-Bạn hãy chỉ nhập 1 ký tự % ở cuối";
                        CustomValidator2.IsValid = false;
                        kt = false;
                        break;
                    }
                }

            }
        }
        catch
        {
            if ( txtGiaCanGiam.Text!="")
            {
                CustomValidator2.ErrorMessage = "-Giá cần giảm chỉ nhập số hoặc %";
                CustomValidator2.IsValid = false;
                kt = false;
            }
        }
        try
        {
            DateTime dt = Convert.ToDateTime(txtNgayBatDau.Text);
        }
        catch
        {
            if (txtNgayBatDau.Text != "")
            {
                CustomValidator3.ErrorMessage = "-Ngày bắt đầu không đúng định dạng";
                CustomValidator3.IsValid = false;
                kt = false;
            }
        }
        try
        {
            DateTime dt = Convert.ToDateTime(txtNgayKetThuc.Text);
        }
        catch
        {
            if (txtNgayKetThuc.Text != "")
            {
                CustomValidator4.ErrorMessage = "-Ngày kết  thúc không đúng định dạng";
                CustomValidator4.IsValid = false;
                kt = false;
            }
        }
        if (txtNoiDungKhuyenMai.Text == "")
        {
            CustomValidator5.ErrorMessage = "-Bạn hãy nhập thông tin khuyến mại";
            CustomValidator5.IsValid = false;
            kt = false;
        }
        else
        {
            CustomValidator5.IsValid = true;
        }
        return kt;

    }
    void lammoi()
    {
        txtGiaCanGiam.Text = "";
        txtMaKhuyenMai.Text = "Mã tự tăng";
        txtNgayBatDau.Text = "";
        txtNgayKetThuc.Text = "";
        txtNoiDungKhuyenMai.Text = "";
        txtTenKhuyenMai.Text = "";
    }
    WedMayTinhDataContext db = new WedMayTinhDataContext();
    protected void btnNhap_Click(object sender, EventArgs e)
    {
        //Response.Write("<script language='javascript' > if ( confirm('Are you sure to delete?') ){} else { return false }  </script>");
        if (kiemtra() != false)
        {
            KhuyenMai khuyenmai = new KhuyenMai();
            khuyenmai.TenKhuyenMai = txtTenKhuyenMai.Text;
            khuyenmai.NoiDungKhuyenMai = txtNoiDungKhuyenMai.Text;
            khuyenmai.NgayTao = DateTime.Now.ToShortDateString();
            if (txtNgayBatDau.Text != "")
            
            {
                khuyenmai.NgayBatDau = txtNgayBatDau.Text;
            }
            if (txtNgayKetThuc.Text != "")
            {
                khuyenmai.NgayKetThuc = txtNgayKetThuc.Text;
            }
            if (txtGiaCanGiam.Text != "")
            {
                khuyenmai.GiaCanGiam = txtGiaCanGiam.Text;
            }
            db.KhuyenMais.InsertOnSubmit(khuyenmai);
            luucheck(khuyenmai);
            db.SubmitChanges();
           // KhuyenMai khuyenmai1 = db.KhuyenMais.SingleOrDefault(p => p.MaKhuyenMai == khuyenmai.MaKhuyenMai);
            
            lammoi();
            LoadTrang();
            clearcheck();
            CheckBox chkhd = (CheckBox)GridView3.HeaderRow.FindControl("chkApDunghd");
            chkhd.Checked = false;
            Response.Write("<script> alert('Nhập thành công') </script>");
        }
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
        
            KhuyenMai khuyenmai = db.KhuyenMais.SingleOrDefault(p => p.MaKhuyenMai.ToString() == txtMaKhuyenMai.Text);
            if (khuyenmai != null)
            {
                if (kiemtra() == true)
                {
                khuyenmai.TenKhuyenMai = txtTenKhuyenMai.Text;
                khuyenmai.NoiDungKhuyenMai = txtNoiDungKhuyenMai.Text;
                khuyenmai.NgayTao = DateTime.Now.ToShortDateString();
                if (txtNgayBatDau.Text != "")
                {
                    khuyenmai.NgayBatDau = txtNgayBatDau.Text;
                }
                if (txtNgayKetThuc.Text != "")
                {
                    khuyenmai.NgayKetThuc = txtNgayKetThuc.Text;
                }
                if (txtGiaCanGiam.Text != "")
                {
                    khuyenmai.GiaCanGiam = txtGiaCanGiam.Text;
                }

                luucheck(khuyenmai);
                db.SubmitChanges();
                LoadTrang();
                lammoi();
                btnNhap.Enabled = true;
                txtMaKhuyenMai.Text = "";
                clearcheck();

                CheckBox chkhd = (CheckBox)GridView3.HeaderRow.FindControl("chkApDunghd");
                chkhd.Checked = false;
                Response.Write("<script> alert('Sửa thành công') </script>");
            }
            }
            else
            {
                CustomValidator1.ErrorMessage = "Bạn hãy chọn một khuyến mại để sửa";
                CustomValidator1.IsValid = false;
            }
        
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {
        KhuyenMai khuyenmai = db.KhuyenMais.SingleOrDefault(p =>p.MaKhuyenMai.ToString() == txtMaKhuyenMai.Text);
        if (khuyenmai != null)
        {
            db.KhuyenMais.DeleteOnSubmit(khuyenmai);
            db.SubmitChanges();
            LoadTrang();
            lammoi();
            btnNhap.Enabled = true;
            txtMaKhuyenMai.Text = "";
            CheckBox chkhd = (CheckBox)GridView3.HeaderRow.FindControl("chkApDunghd");
            chkhd.Checked = false;

            clearcheck();

            Response.Write("<script> alert('Xóa thành công') </script>");
        }
        else
        {
            CustomValidator1.ErrorMessage = "Bạn hãy chọn một khuyến mại để xóa";
            CustomValidator1.IsValid = false;
        }
    }

    void clearcheck()
    {
        foreach (GridViewRow dr in GridView3.Rows)
        {
          
                    CheckBox chk = (CheckBox)dr.FindControl("chkApDung");
                    chk.Checked = false;
           

        }
    }
    void loadcheck(KhuyenMai khuyenmai)
    {
        clearcheck();
        var masanphamkhuyenmai = from p in db.SanPham_KhuyenMais where p.MaKhuyenMai == khuyenmai.MaKhuyenMai select p.MaSanPham;

        if (masanphamkhuyenmai != null)
        {
            foreach (GridViewRow dr in GridView3.Rows)
            {
                foreach (int masanpham in masanphamkhuyenmai)
                {

                    if (dr.Cells[1].Text == masanpham.ToString())
                    {
                        CheckBox chk = (CheckBox)dr.FindControl("chkApDung");
                        chk.Checked = true;
                        break;
                    }
                   
                }

            }
        }
    }
    void luucheck(KhuyenMai khuyenmai)
    {
        if (txtMaKhuyenMai.Text != "")
        {
            var masanphamkhuyenmai = from p in db.SanPham_KhuyenMais where p.MaKhuyenMai == khuyenmai.MaKhuyenMai select p.MaSanPham;

            if (masanphamkhuyenmai != null)
            {
                foreach (GridViewRow dr in GridView3.Rows)
                {
                    CheckBox chk = (CheckBox)dr.FindControl("chkApDung");
                    if (chk.Checked == true)
                    {
                        //kiemtra xem sampham_khuyenmai  do da ton tai chua
                        SanPham_KhuyenMai spkm = db.SanPham_KhuyenMais.SingleOrDefault(p => p.MaKhuyenMai == khuyenmai.MaKhuyenMai && p.MaSanPham.ToString() == dr.Cells[1].Text);
                        if (spkm == null)
                        {


                            //neu chua ton tai
                            //kiem tra xem san pham nay da duoc ap dung khuyen mai nao chua

                            SanPham_KhuyenMai spkmtruoc = db.SanPham_KhuyenMais.SingleOrDefault(p => p.MaSanPham.ToString() == dr.Cells[1].Text);

                            //neu da dc khuyen mai thi xoa di

                            if (spkmtruoc != null)
                            {
                                db.SanPham_KhuyenMais.DeleteOnSubmit(spkmtruoc);
                                db.SubmitChanges();
                            }

                            SanPham_KhuyenMai spkmmoi = new SanPham_KhuyenMai();
                            spkmmoi.MaKhuyenMai = khuyenmai.MaKhuyenMai;
                            spkmmoi.MaSanPham = Convert.ToInt32(dr.Cells[1].Text);
                            db.SanPham_KhuyenMais.InsertOnSubmit(spkmmoi);
                            db.SubmitChanges();

                        }
                    }
                    else
                    {
                        //kiemtra xem sampham_khuyenmai  do da ton tai chua
                        SanPham_KhuyenMai spkm = db.SanPham_KhuyenMais.SingleOrDefault(p => p.MaKhuyenMai == khuyenmai.MaKhuyenMai && p.MaSanPham.ToString() == dr.Cells[1].Text);
                        if (spkm != null)
                        {
                            //neu da ton tai thi  xoa di
                            db.SanPham_KhuyenMais.DeleteOnSubmit(spkm);
                            db.SubmitChanges();
                        }
                    }



                }
            }
        }
        else
        {
            foreach (GridViewRow dr in GridView3.Rows)
            {
                CheckBox chk = (CheckBox)dr.FindControl("chkApDung");
                if (chk.Checked == true)
                {
                    //kiemtra xem sampham_khuyenmai  do da ton tai chua
                    SanPham_KhuyenMai spkm = db.SanPham_KhuyenMais.SingleOrDefault(p => p.MaKhuyenMai == khuyenmai.MaKhuyenMai && p.MaSanPham.ToString() == dr.Cells[1].Text);
                    if (spkm == null)
                    {


                        //neu chua ton tai
                        //kiem tra xem san pham nay da duoc ap dung khuyen mai nao chua

                        SanPham_KhuyenMai spkmtruoc = db.SanPham_KhuyenMais.SingleOrDefault(p => p.MaSanPham.ToString() == dr.Cells[1].Text);

                        //neu da dc khuyen mai thi xoa di

                        if (spkmtruoc != null)
                        {
                            db.SanPham_KhuyenMais.DeleteOnSubmit(spkmtruoc);
                            db.SubmitChanges();
                        }

                        SanPham_KhuyenMai spkmmoi = new SanPham_KhuyenMai();
                        spkmmoi.MaKhuyenMai = khuyenmai.MaKhuyenMai;
                        spkmmoi.MaSanPham = Convert.ToInt32(dr.Cells[1].Text);
                        db.SanPham_KhuyenMais.InsertOnSubmit(spkmmoi);
                        db.SubmitChanges();

                    }
                }
                else
                {
                    //kiemtra xem sampham_khuyenmai  do da ton tai chua
                    SanPham_KhuyenMai spkm = db.SanPham_KhuyenMais.SingleOrDefault(p => p.MaKhuyenMai == khuyenmai.MaKhuyenMai && p.MaSanPham.ToString() == dr.Cells[1].Text);
                    if (spkm != null)
                    {
                        //neu da ton tai thi  xoa di
                        db.SanPham_KhuyenMais.DeleteOnSubmit(spkm);
                        db.SubmitChanges();
                    }
                }



            }
        }
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        KhuyenMai khuyenmai = db.KhuyenMais.SingleOrDefault(p => p.MaKhuyenMai.ToString() == GridView2.Rows[GridView2.SelectedIndex].Cells[0].Text);
     
        if (khuyenmai != null)
        {
            txtTenKhuyenMai.Text = khuyenmai.TenKhuyenMai;
            txtNoiDungKhuyenMai.Text = khuyenmai.NoiDungKhuyenMai;
            txtMaKhuyenMai.Text = khuyenmai.MaKhuyenMai.ToString();
            if (khuyenmai.GiaCanGiam != "")
            {
                txtGiaCanGiam.Text = khuyenmai.GiaCanGiam;
            }
            if (khuyenmai.NgayBatDau != "")
            {
                txtNgayBatDau.Text = khuyenmai.NgayBatDau;
            }
            if (khuyenmai.NgayKetThuc != "")
            {
                txtNgayKetThuc.Text = khuyenmai.NgayKetThuc;
            }
            
        }
        loadcheck(khuyenmai);
        btnNhap.Enabled = false;
    }
    protected void chkApDunghd_OnCheckedChanged(object sender, EventArgs e)
    {
        CheckBox chkhd = (CheckBox)GridView3.HeaderRow.FindControl("chkApDunghd");

        if (chkhd.Checked == true)
        {
            foreach (GridViewRow dr in GridView3.Rows)
            {
                CheckBox chk = (CheckBox)dr.FindControl("chkApDung");
                chk.Checked = true;
            }
        }
        else
        {
            foreach (GridViewRow dr in GridView3.Rows)
            {

                CheckBox chk = (CheckBox)dr.FindControl("chkApDung");
                chk.Checked = false;
            }
        }
    }
    protected void GridView3_Load(object sender, EventArgs e)
    {
        
    }
    protected void GridView3_PageIndexChanged(object sender, EventArgs e)
    {
               
    }
    protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (txtMaKhuyenMai.Text!= "")
        {
            KhuyenMai khuyenmai = db.KhuyenMais.SingleOrDefault(p => p.MaKhuyenMai.ToString() == txtMaKhuyenMai.Text);
            loadcheck(khuyenmai);
        }
    }
    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView3_PageIndexChanged1(object sender, EventArgs e)
    {
         
        if (MsgBox.MessageBox(0, "Ban co muon luu lai cac thay doi truoc khi sang trang du lieu", "Canh bao", 1) == 1)
        {
            if (txtMaKhuyenMai.Text != "")
            {
                
          
                KhuyenMai khuyenmai = db.KhuyenMais.SingleOrDefault(p => p.MaKhuyenMai.ToString() == txtMaKhuyenMai.Text);
                luucheck(khuyenmai);
            }
            else
            {
               
            }
           
            
        }
        else
        {
        }
    }
}
