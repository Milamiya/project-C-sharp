namespace QuanLyThuChi
{
    partial class MAINF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoPhieuNX = new DevExpress.XtraBars.BarButtonItem();
            this.btnInPhieuNX = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoPhieuTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnInPhieuTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.ribHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribHeThong1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribQLDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribQLKho = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribQLHangHoa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribQLNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPhieuNhapXuat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribTaoPhieuNhapXuat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rinInPhieuNhapXuat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribQLThuChi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribTaoPhieuThuChi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribInPhieuThuChi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribTimKiem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rinTimHangHoa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribBaoCaoThang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnThoat,
            this.btnQLKho,
            this.btnQLHangHoa,
            this.btnQLNhanVien,
            this.btnTaoPhieuNX,
            this.btnInPhieuNX,
            this.btnTaoPhieuTC,
            this.btnInPhieuTC,
            this.btnTimNhanVien,
            this.btnTimHangHoa,
            this.btnBaoCao,
            this.btnDangKy,
            this.btnDoiMK});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribHeThong,
            this.ribQLDanhMuc,
            this.ribPhieuNhapXuat,
            this.ribQLThuChi,
            this.ribTimKiem,
            this.ribBaoCao});
            this.ribbon.Size = new System.Drawing.Size(966, 144);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Glyph = global::QuanLyThuChi.Properties.Resources.contact_icon;
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.LargeGlyph = global::QuanLyThuChi.Properties.Resources.contact_icon;
            this.btnDangNhap.LargeWidth = 80;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 2;
            this.btnDangXuat.LargeGlyph = global::QuanLyThuChi.Properties.Resources.Very_Basic_link_broken_icon;
            this.btnDangXuat.LargeWidth = 80;
            this.btnDangXuat.Name = "btnDangXuat";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 3;
            this.btnThoat.LargeGlyph = global::QuanLyThuChi.Properties.Resources.Button_Turn_Off_icon;
            this.btnThoat.LargeWidth = 80;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnQLKho
            // 
            this.btnQLKho.Caption = "Kho";
            this.btnQLKho.Id = 4;
            this.btnQLKho.LargeGlyph = global::QuanLyThuChi.Properties.Resources.box1;
            this.btnQLKho.LargeWidth = 80;
            this.btnQLKho.Name = "btnQLKho";
            this.btnQLKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLKho_ItemClick);
            // 
            // btnQLHangHoa
            // 
            this.btnQLHangHoa.Caption = "Hàng";
            this.btnQLHangHoa.Id = 5;
            this.btnQLHangHoa.LargeGlyph = global::QuanLyThuChi.Properties.Resources.product;
            this.btnQLHangHoa.LargeWidth = 80;
            this.btnQLHangHoa.Name = "btnQLHangHoa";
            this.btnQLHangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLHangHoa_ItemClick);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Caption = "Nhân viên";
            this.btnQLNhanVien.Id = 6;
            this.btnQLNhanVien.LargeGlyph = global::QuanLyThuChi.Properties.Resources.administrator;
            this.btnQLNhanVien.LargeWidth = 80;
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLNhanVien_ItemClick);
            // 
            // btnTaoPhieuNX
            // 
            this.btnTaoPhieuNX.Caption = "Tạo";
            this.btnTaoPhieuNX.Id = 7;
            this.btnTaoPhieuNX.LargeGlyph = global::QuanLyThuChi.Properties.Resources.Add_icon_6;
            this.btnTaoPhieuNX.LargeWidth = 120;
            this.btnTaoPhieuNX.Name = "btnTaoPhieuNX";
            this.btnTaoPhieuNX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoPhieuNX_ItemClick);
            // 
            // btnInPhieuNX
            // 
            this.btnInPhieuNX.Caption = "In";
            this.btnInPhieuNX.Id = 8;
            this.btnInPhieuNX.LargeGlyph = global::QuanLyThuChi.Properties.Resources.Icon_Printer;
            this.btnInPhieuNX.LargeWidth = 120;
            this.btnInPhieuNX.Name = "btnInPhieuNX";
            this.btnInPhieuNX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInPhieuNX_ItemClick);
            // 
            // btnTaoPhieuTC
            // 
            this.btnTaoPhieuTC.Caption = "Tạo";
            this.btnTaoPhieuTC.Id = 9;
            this.btnTaoPhieuTC.LargeGlyph = global::QuanLyThuChi.Properties.Resources.Add_icon_6;
            this.btnTaoPhieuTC.LargeWidth = 120;
            this.btnTaoPhieuTC.Name = "btnTaoPhieuTC";
            this.btnTaoPhieuTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoPhieuTC_ItemClick);
            // 
            // btnInPhieuTC
            // 
            this.btnInPhieuTC.Caption = "In";
            this.btnInPhieuTC.Id = 10;
            this.btnInPhieuTC.LargeGlyph = global::QuanLyThuChi.Properties.Resources.Icon_Printer;
            this.btnInPhieuTC.LargeWidth = 120;
            this.btnInPhieuTC.Name = "btnInPhieuTC";
            this.btnInPhieuTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInPhieuTC_ItemClick);
            // 
            // btnTimNhanVien
            // 
            this.btnTimNhanVien.Caption = "Nhân viên";
            this.btnTimNhanVien.Id = 11;
            this.btnTimNhanVien.LargeGlyph = global::QuanLyThuChi.Properties.Resources.Male_user_search_icon;
            this.btnTimNhanVien.LargeWidth = 120;
            this.btnTimNhanVien.Name = "btnTimNhanVien";
            // 
            // btnTimHangHoa
            // 
            this.btnTimHangHoa.Caption = "Hàng hóa";
            this.btnTimHangHoa.Id = 12;
            this.btnTimHangHoa.LargeGlyph = global::QuanLyThuChi.Properties.Resources.Magnifying_glass_icon;
            this.btnTimHangHoa.LargeWidth = 120;
            this.btnTimHangHoa.Name = "btnTimHangHoa";
            this.btnTimHangHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTimHangHoa_ItemClick);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Caption = "Thu chi tháng trước";
            this.btnBaoCao.Id = 13;
            this.btnBaoCao.LargeGlyph = global::QuanLyThuChi.Properties.Resources.report_check;
            this.btnBaoCao.LargeWidth = 120;
            this.btnBaoCao.Name = "btnBaoCao";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Caption = "Đăng ký";
            this.btnDangKy.Id = 14;
            this.btnDangKy.LargeGlyph = global::QuanLyThuChi.Properties.Resources.Add_Male_User_icon;
            this.btnDangKy.LargeWidth = 80;
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKy_ItemClick);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "Đổi mật khẩu";
            this.btnDoiMK.Id = 15;
            this.btnDoiMK.LargeGlyph = global::QuanLyThuChi.Properties.Resources.Edit_Male_User_icon;
            this.btnDoiMK.LargeWidth = 80;
            this.btnDoiMK.Name = "btnDoiMK";
            // 
            // ribHeThong
            // 
            this.ribHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribHeThong1,
            this.ribTaiKhoan});
            this.ribHeThong.Name = "ribHeThong";
            this.ribHeThong.Text = "Hệ thống";
            // 
            // ribHeThong1
            // 
            this.ribHeThong1.ItemLinks.Add(this.btnDangNhap);
            this.ribHeThong1.ItemLinks.Add(this.btnDangXuat);
            this.ribHeThong1.ItemLinks.Add(this.btnThoat);
            this.ribHeThong1.Name = "ribHeThong1";
            this.ribHeThong1.Text = "Hệ thống";
            // 
            // ribTaiKhoan
            // 
            this.ribTaiKhoan.ItemLinks.Add(this.btnDangKy);
            this.ribTaiKhoan.ItemLinks.Add(this.btnDoiMK);
            this.ribTaiKhoan.Name = "ribTaiKhoan";
            this.ribTaiKhoan.Text = "Tài khoản";
            // 
            // ribQLDanhMuc
            // 
            this.ribQLDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribQLKho,
            this.ribQLHangHoa,
            this.ribQLNhanVien});
            this.ribQLDanhMuc.Name = "ribQLDanhMuc";
            this.ribQLDanhMuc.Text = "Quản lý danh mục";
            // 
            // ribQLKho
            // 
            this.ribQLKho.ItemLinks.Add(this.btnQLKho);
            this.ribQLKho.Name = "ribQLKho";
            this.ribQLKho.Text = "Kho hàng";
            // 
            // ribQLHangHoa
            // 
            this.ribQLHangHoa.ItemLinks.Add(this.btnQLHangHoa);
            this.ribQLHangHoa.Name = "ribQLHangHoa";
            this.ribQLHangHoa.Text = "Hàng hóa";
            // 
            // ribQLNhanVien
            // 
            this.ribQLNhanVien.ItemLinks.Add(this.btnQLNhanVien);
            this.ribQLNhanVien.Name = "ribQLNhanVien";
            this.ribQLNhanVien.Text = "Nhân viên";
            // 
            // ribPhieuNhapXuat
            // 
            this.ribPhieuNhapXuat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribTaoPhieuNhapXuat,
            this.rinInPhieuNhapXuat});
            this.ribPhieuNhapXuat.Name = "ribPhieuNhapXuat";
            this.ribPhieuNhapXuat.Text = "Viết phiếu nhập xuất";
            // 
            // ribTaoPhieuNhapXuat
            // 
            this.ribTaoPhieuNhapXuat.ItemLinks.Add(this.btnTaoPhieuNX);
            this.ribTaoPhieuNhapXuat.Name = "ribTaoPhieuNhapXuat";
            this.ribTaoPhieuNhapXuat.Text = "Tạo phiếu nhập xuất";
            // 
            // rinInPhieuNhapXuat
            // 
            this.rinInPhieuNhapXuat.ItemLinks.Add(this.btnInPhieuNX);
            this.rinInPhieuNhapXuat.Name = "rinInPhieuNhapXuat";
            this.rinInPhieuNhapXuat.Text = "In phiếu nhập xuất";
            // 
            // ribQLThuChi
            // 
            this.ribQLThuChi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribTaoPhieuThuChi,
            this.ribInPhieuThuChi});
            this.ribQLThuChi.Name = "ribQLThuChi";
            this.ribQLThuChi.Text = "Viết phiếu thu chi";
            // 
            // ribTaoPhieuThuChi
            // 
            this.ribTaoPhieuThuChi.ItemLinks.Add(this.btnTaoPhieuTC);
            this.ribTaoPhieuThuChi.Name = "ribTaoPhieuThuChi";
            this.ribTaoPhieuThuChi.Text = "Tạo phiếu thu chi";
            // 
            // ribInPhieuThuChi
            // 
            this.ribInPhieuThuChi.ItemLinks.Add(this.btnInPhieuTC);
            this.ribInPhieuThuChi.Name = "ribInPhieuThuChi";
            this.ribInPhieuThuChi.Text = "In phiếu thu chi";
            // 
            // ribTimKiem
            // 
            this.ribTimKiem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rinTimHangHoa});
            this.ribTimKiem.Name = "ribTimKiem";
            this.ribTimKiem.Text = "Tìm kiếm";
            // 
            // rinTimHangHoa
            // 
            this.rinTimHangHoa.ItemLinks.Add(this.btnTimHangHoa);
            this.rinTimHangHoa.Name = "rinTimHangHoa";
            this.rinTimHangHoa.Text = "Hàng hóa";
            // 
            // ribBaoCao
            // 
            this.ribBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribBaoCaoThang});
            this.ribBaoCao.Name = "ribBaoCao";
            this.ribBaoCao.Text = "Báo cáo thu chi";
            // 
            // ribBaoCaoThang
            // 
            this.ribBaoCaoThang.ItemLinks.Add(this.btnBaoCao);
            this.ribBaoCaoThang.Name = "ribBaoCaoThang";
            this.ribBaoCaoThang.Text = "Thu chi tháng trước";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 426);
            this.panel1.TabIndex = 1;
            // 
            // MAINF
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MAINF";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thu chi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MAINF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribHeThong1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnQLKho;
        private DevExpress.XtraBars.BarButtonItem btnQLHangHoa;
        private DevExpress.XtraBars.BarButtonItem btnQLNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnTaoPhieuNX;
        private DevExpress.XtraBars.BarButtonItem btnInPhieuNX;
        private DevExpress.XtraBars.BarButtonItem btnTaoPhieuTC;
        private DevExpress.XtraBars.BarButtonItem btnInPhieuTC;
        private DevExpress.XtraBars.BarButtonItem btnTimNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnTimHangHoa;
        private DevExpress.XtraBars.BarButtonItem btnBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribQLDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribQLKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribQLHangHoa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribQLNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPhieuNhapXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribTaoPhieuNhapXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rinInPhieuNhapXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribQLThuChi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribTaoPhieuThuChi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribInPhieuThuChi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribTimKiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rinTimHangHoa;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribBaoCaoThang;
        private DevExpress.XtraBars.BarButtonItem btnDangKy;
        private DevExpress.XtraBars.BarButtonItem btnDoiMK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribTaiKhoan;
        private DevExpress.XtraEditors.PanelControl panel1;
    }
}