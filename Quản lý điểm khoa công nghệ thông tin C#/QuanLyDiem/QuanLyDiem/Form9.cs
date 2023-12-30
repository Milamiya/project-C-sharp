using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        BLL.ClassBLL business = new BLL.ClassBLL();
        public static int quyen;
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
        public void PhanQuyenMenu()
        {
            switch (quyen)
            {
                case 1 :
                    btnTDDT.Enabled = true;
                    btnHeDT.Enabled = true;
                    btnHocKy.Enabled = true;
                    btnKHGD.Enabled = true;
                    btnKhoiLop.Enabled = true;
                    btnDangNhap.Enabled = false;
                    btnDangXuat.Enabled = true;
                    btnPhanQuyen.Enabled = true;
                    btnGiangVien.Enabled = true;
                    btnHocPhan.Enabled = true;
                    btnLop.Enabled = true;
                    btnNhomHocPhan.Enabled = true;
                    btnSinhVien.Enabled = true;
                    btnQuanLyDiem.Enabled = true;
                    btnXemDiemLop.Enabled = false;
                    btnXemDiemNhomHP.Enabled = true ;
                    btnBaoCao.Enabled = true;
                    btnThongKe.Enabled = true;
                    btnXemDiem.Enabled = true;
                    btnXemDiemLop.Enabled = true;
                    break;
                case 2 :
                    btnDangNhap.Enabled = false;
                    btnDangXuat.Enabled = true;
                    btnBaoCao.Enabled = false;
                    btnThongKe.Enabled = false;
                    btnXemDiem.Enabled = true;
                    btnXemDiemNhomHP.Enabled = false;
                    break;
                default:
                    btnTDDT.Enabled = false;
                    btnHeDT.Enabled = false;
                    btnHocKy.Enabled = false;
                    btnKHGD.Enabled = false;
                    btnKhoiLop.Enabled = false;
                    btnDangNhap.Enabled = true;
                    btnDangXuat.Enabled = false;
                    btnPhanQuyen.Enabled = false;
                    btnGiangVien.Enabled = false;
                    btnHocPhan.Enabled = false;
                    btnLop.Enabled = false;
                    btnNhomHocPhan.Enabled = false;
                    btnSinhVien.Enabled = false;
                    btnQuanLyDiem.Enabled = false;
                    btnThongKe.Enabled = false;
                    btnXemDiemLop.Enabled = false;
                    btnBaoCao.Enabled = false;
                    btnXemDiemNhomHP.Enabled = false;
                    btnXemDiem.Enabled = false;
                    break;
            }
        }
        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            quyen = -1;
            CloseForm("Form9");
            Form9_Load(sender,e);
        }
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormDangNhap f = new FormDangNhap();
            f.MdiParent = this;
            f.Show();
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            PhanQuyenMenu();
        }
        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormPhanQuyen f = new FormPhanQuyen();
            f.MdiParent = this;
            f.Show();
        }
        public  void CloseForm(string form_hienthoi)
        {
            // duyet qua tung form con dang mo
            foreach (Form frm in this.MdiChildren)
            {
                // neu hok phai form dang mo thi dong lai
                if (!frm.Name.Equals(form_hienthoi))
                    frm.Close();
            }
        }
        private void btnHuongDan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormHDSD f = new FormHDSD();
            f.MdiParent = this;
            f.Show();
        }
        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            CloseForm("Form9");
        }
        private void btnLienHe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormLienHe f = new FormLienHe();
            f.MdiParent = this;
            f.Show();
        }
        private void btnTDDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormTDDT f = new FormTDDT();
            f.MdiParent = this;
            f.Show();
        }

        private void btnHeDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormHeDaoTao f = new FormHeDaoTao();
            f.MdiParent = this;
            f.Show();
        }

        private void btnHocKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormHocKy f = new FormHocKy();
            f.MdiParent = this;
            f.Show();
        }

        private void btnGiangVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormGiangVien f = new FormGiangVien();
            f.MdiParent = this;
            f.Show();
        }

        private void btnHocPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormHocPhan f = new FormHocPhan();
            f.MdiParent = this;
            f.Show();
        }

        private void btnKhoiLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormKhoiLop f = new FormKhoiLop();
            f.MdiParent = this;
            f.Show();
        }

        private void btnKHGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormKHGD f = new FormKHGD();
            f.MdiParent = this;
            f.Show();
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormSinhVien f = new FormSinhVien();
            f.MdiParent = this;
            f.Show();
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormLop f = new FormLop();
            f.MdiParent = this;
            f.Show();
        }

        private void btnNhomHocPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormNhomHocPhan f = new FormNhomHocPhan();
            f.MdiParent = this;
            f.Show();
        }

        private void btnKetQuaSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormTimKiemDiemSV f = new FormTimKiemDiemSV();
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormTimKiemThongTin f = new FormTimKiemThongTin();
            f.MdiParent = this;
            f.Show();
        }

        private void btnQuanLyDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormQuanLyDiem f = new FormQuanLyDiem();
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormBaoCao f = new FormBaoCao();
            f.MdiParent = this;
            f.Show();
        }

        private void btnXemDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormXemDiem f = new FormXemDiem();
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongKe_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormThongKe f = new FormThongKe();
            f.MdiParent = this;
            f.Show();
        }

        private void btnXemDiemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormXemDiemLop f = new FormXemDiemLop();
            f.MdiParent = this;
            f.Show();
        }

        private void btnXemDiemNhomHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseForm("Form9");
            FormXemDiemNhomHP f = new FormXemDiemNhomHP();
            f.MdiParent = this;
            f.Show();
        }       
    }
}
