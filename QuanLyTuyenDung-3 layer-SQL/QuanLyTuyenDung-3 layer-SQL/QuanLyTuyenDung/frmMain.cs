using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using System.Data.SqlClient;
using PresentationLayer;
using DTO;
using PresentationLayer;
namespace PresentationLayer
{
    public partial class frmMain : RibbonForm
    {
        public static TaiKhoan_DTO k=new TaiKhoan_DTO();

        public frmMain()
        {
            InitializeComponent();
            InitSkinGallery();    
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        void khongquyen()
        {
            btnDangXuat.Enabled = false;
            ribbonQLTD.Visible = false;
            ribbonQLDanhMuc.Visible = false;
            ribbonThongKe.Visible = false;
            btnNguoiDung.Enabled = false;
            btnSaoLuu.Enabled=false;
            naTuyenDung.Visible = false;
            naBaoCao.Visible = false;
        }
        void quyenadmin()
        {
            btnDangXuat.Enabled = true;
            btnDangXuat.Enabled = true;
            ribbonQLTD.Visible = true;
            ribbonQLDanhMuc.Visible = true;
            ribbonThongKe.Visible = true;
            btnNguoiDung.Enabled = true;
            btnSaoLuu.Enabled = true;
            naTuyenDung.Visible = true;
            naBaoCao.Visible = true;
        }
        void quyenquanly()
        {
            btnDangXuat.Enabled = true;
            btnDangXuat.Enabled = true;
            ribbonQLTD.Visible = false;
            ribbonQLDanhMuc.Visible = true;
            ribbonThongKe.Visible = true;
            btnTkeUVienTrungTuyen.Enabled = false;
            btnNguoiDung.Enabled = false;
            btnSaoLuu.Enabled = true;
            naTuyenDung.Visible = false;
            naBaoCao.Visible = false;
        }
        void VoHieuHoa()
        {  
            int quyen=TaiKhoan_BLL.CheckQuyen1TaiKhoan(k);
            if (quyen != 1 && quyen != 2)
            {
                khongquyen();   
            }
            else if (quyen ==1)
            {
                quyenquanly();
            }
            else if (quyen == 2)
            {
                quyenadmin();
            }
               
        }

        
        private void frmMain_Load(object sender, EventArgs e)
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
            r = MessageBox.Show("Bạn có chắc muốn thoát không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void btnHuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            HuyenF h = new HuyenF();
            dongkhung(h);
            panel1.Controls.Clear();
            panel1.Controls.Add(h);            
            h.Show();
        }

        private void btnUVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            HoSoF hsf = new HoSoF();
            dongkhung(hsf);
            panel1.Controls.Add(hsf);
            hsf.Show();
        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void dongkhung(Form frm)
        {
            frm.Width = panel1.Width;
            frm.Height = panel1.Height;
            frm.AutoScroll = true;
            frm.TopLevel = false;
            panel1.Controls.Clear();
        }
        private void btnDangKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            DangKy dn = new DangKy();
            dongkhung(dn);
            panel1.Controls.Add(dn);
            dn.Show();
            
        }

        private void btnTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            TinhF t = new TinhF();
            dongkhung(t);
            panel1.Controls.Add(t);
            t.Show();
        }

        private void btnQuocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuocGiaF qg = new QuocGiaF();
            dongkhung(qg);
            panel1.Controls.Add(qg);
            qg.Show();
        }

        private void btnViTri_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViTriF vt = new ViTriF();
            dongkhung(vt);
            panel1.Controls.Add(vt);
            vt.Show();
        }

        private void btnTrinhDo_ItemClick(object sender, ItemClickEventArgs e)
        {
            TrinhDoF td = new TrinhDoF();
            dongkhung(td);
            panel1.Controls.Add(td);
            td.Show();
        }

        private void btnLoaiHoSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoaiHSF lhs = new LoaiHSF();
            dongkhung(lhs);
            panel1.Controls.Add(lhs);
            lhs.Show();
        }

        private void btnPhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            PhongBanF pb = new PhongBanF();
            dongkhung(pb);
            panel1.Controls.Add(pb);
            pb.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            NganhF ng = new NganhF();
            dongkhung(ng);
            panel1.Controls.Add(ng);
            ng.Show();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            MucDoF md = new MucDoF();
            dongkhung(md);
            panel1.Controls.Add(md);
            md.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongBaoF tb = new ThongBaoF();
            dongkhung(tb);
            panel1.Controls.Add(tb);
            tb.Show();
        }
    }
}