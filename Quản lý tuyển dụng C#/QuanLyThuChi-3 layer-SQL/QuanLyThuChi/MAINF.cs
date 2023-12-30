using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyThuChi.SubForm;
using DTO;
using BUS;
namespace QuanLyThuChi
{
    public partial class MAINF : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static TaiKhoan_DTO k = new TaiKhoan_DTO();
        public MAINF()
        {
            InitializeComponent();
        }
        private void dongkhung(Form frm)
        {
            frm.Width = panel1.Width;
            frm.Height = panel1.Height;
            frm.AutoScroll = true;
            frm.TopLevel = false;
            panel1.Controls.Clear();
        }
        void khongquyen()
        {
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;
            ribQLDanhMuc.Visible = false;
            ribPhieuNhapXuat.Visible = false;
            ribQLThuChi.Visible = false;
            ribTimKiem.Visible = false;
            ribBaoCao.Visible = false;
        }
        void quanly()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            ribQLDanhMuc.Visible = true;
            btnQLNhanVien.Enabled = false;

            ribPhieuNhapXuat.Visible = true;
            ribQLThuChi.Visible = true;
            ribTimKiem.Visible = true;
            ribBaoCao.Visible = false;
        }
        void admin()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            ribQLDanhMuc.Visible = true;
            ribPhieuNhapXuat.Visible = true;
            ribQLThuChi.Visible = true;
            ribTimKiem.Visible = true;
            ribBaoCao.Visible = true;
        }
        void VoHieuHoa()
        {
            int quyen = TaiKhoan_BUS.CheckQuyen1TaiKhoan(k);
            if (quyen != 1 && quyen != 2)
            {
                khongquyen();
            }
            else if (quyen == 1)
            {
                quanly();
            }
            else if (quyen == 2)
            {
                admin();
            }

        }
        private void btnQLKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            KHOF khof=new KHOF();
            dongkhung(khof);
            panel1.Controls.Add(khof);
            khof.Show();
        }

        private void btnQLHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            HANGHOAF hhf = new HANGHOAF();
            dongkhung(hhf);
            panel1.Controls.Add(hhf);
            hhf.Show();
        }
        
        private void btnQLNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            NHANVIENF nvf = new NHANVIENF();
            dongkhung(nvf);
            panel1.Controls.Add(nvf);
            nvf.Show();
        }

        private void btnTaoPhieuNX_ItemClick(object sender, ItemClickEventArgs e)
        {
            PHIEUNHAPXUATF p = new PHIEUNHAPXUATF();
            dongkhung(p);
            panel1.Controls.Add(p);
            p.Show();
        }

        private void btnTaoPhieuTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            PHIEUTHUCHIF p = new PHIEUTHUCHIF();
            dongkhung(p);
            panel1.Controls.Add(p);
            p.Show();
        }

        private void MAINF_Load(object sender, EventArgs e)
        {
            VoHieuHoa();
            if (KetNoi.thucnn() == false)
            {
                frmConnection cn = new frmConnection();
                if (cn.ShowDialog() == DialogResult.OK)
                { }
                else
                this.Dispose();
            }
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            DANGNHAP dn = new DANGNHAP();

            if (dn.ShowDialog() == DialogResult.OK)
            {
                VoHieuHoa();
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == r)
                this.Close();
        }

        private void btnDangKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            DangKy dk = new DangKy();
            dongkhung(dk);
            panel1.Controls.Add(dk);
            dk.Show();
        }

        private void btnInPhieuTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            InPhieuThuChiF ip = new InPhieuThuChiF();
            ip.Show();
        }

        private void btnInPhieuNX_ItemClick(object sender, ItemClickEventArgs e)
        {
            InPhieuNhapXuat ip = new InPhieuNhapXuat();
            ip.Show();
        }

        private void btnTimHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            TimHangHoa thh = new TimHangHoa();
            dongkhung(thh);
            panel1.Controls.Add(thh);
            thh.Show();
        }
    }
}