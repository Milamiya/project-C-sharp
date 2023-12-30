namespace QuanLyDiem
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.ribbonControl9 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocPhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhomHocPhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnKetQuaSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuongDan = new DevExpress.XtraBars.BarButtonItem();
            this.btnLienHe = new DevExpress.XtraBars.BarButtonItem();
            this.btnTDDT = new DevExpress.XtraBars.BarButtonItem();
            this.btnHeDT = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoiLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnKHGD = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKe = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemDiemLop = new DevExpress.XtraBars.BarButtonItem();
            this.pageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pgHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pgDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pgChucNang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbgXemDiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageTimKiem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pgTimKiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageTroGiup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pgTroGiup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnXemDiemNhomHP = new DevExpress.XtraBars.BarButtonItem();
            this.SuspendLayout();
            // 
            // ribbonControl9
            // 
            this.ribbonControl9.ApplicationIcon = null;
            this.ribbonControl9.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnPhanQuyen,
            this.btnThoat,
            this.btnGiangVien,
            this.btnSinhVien,
            this.btnHocPhan,
            this.btnNhomHocPhan,
            this.btnLop,
            this.btnQuanLyDiem,
            this.btnBaoCao,
            this.btnXemDiem,
            this.btnKetQuaSV,
            this.btnThongTin,
            this.btnHuongDan,
            this.btnLienHe,
            this.btnTDDT,
            this.btnHeDT,
            this.btnKhoiLop,
            this.btnKHGD,
            this.btnHocKy,
            this.btnThongKe,
            this.btnXemDiemLop,
            this.btnXemDiemNhomHP});
            this.ribbonControl9.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl9.MaxItemId = 25;
            this.ribbonControl9.Name = "ribbonControl9";
            this.ribbonControl9.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageHeThong,
            this.pageDanhMuc,
            this.pageChucNang,
            this.pageTimKiem,
            this.pageTroGiup});
            this.ribbonControl9.SelectedPage = this.pageHeThong;
            this.ribbonControl9.ShowToolbarCustomizeItem = false;
            this.ribbonControl9.Size = new System.Drawing.Size(784, 141);
            this.ribbonControl9.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl9.SelectedPageChanged += new System.EventHandler(this.ribbonControl1_SelectedPageChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Glyph")));
            this.btnDangNhap.Id = 0;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.CausesValidation = true;
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Glyph")));
            this.btnDangXuat.Id = 1;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Caption = "Phân Quyền";
            this.btnPhanQuyen.Enabled = false;
            this.btnPhanQuyen.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPhanQuyen.Glyph")));
            this.btnPhanQuyen.Id = 2;
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhanQuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhanQuyen_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.Glyph")));
            this.btnThoat.Id = 3;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Caption = "Giảng Viên";
            this.btnGiangVien.Enabled = false;
            this.btnGiangVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGiangVien.Glyph")));
            this.btnGiangVien.Id = 4;
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnGiangVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiangVien_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh Viên";
            this.btnSinhVien.Enabled = false;
            this.btnSinhVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.Glyph")));
            this.btnSinhVien.Id = 5;
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // btnHocPhan
            // 
            this.btnHocPhan.Caption = "Học Phần";
            this.btnHocPhan.Enabled = false;
            this.btnHocPhan.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHocPhan.Glyph")));
            this.btnHocPhan.Id = 6;
            this.btnHocPhan.Name = "btnHocPhan";
            this.btnHocPhan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHocPhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocPhan_ItemClick);
            // 
            // btnNhomHocPhan
            // 
            this.btnNhomHocPhan.Caption = "Nhóm Học Phần";
            this.btnNhomHocPhan.Enabled = false;
            this.btnNhomHocPhan.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhomHocPhan.Glyph")));
            this.btnNhomHocPhan.Id = 7;
            this.btnNhomHocPhan.Name = "btnNhomHocPhan";
            this.btnNhomHocPhan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhomHocPhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhomHocPhan_ItemClick);
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Enabled = false;
            this.btnLop.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLop.Glyph")));
            this.btnLop.Id = 8;
            this.btnLop.Name = "btnLop";
            this.btnLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnQuanLyDiem
            // 
            this.btnQuanLyDiem.Caption = "Quản Lý Điểm";
            this.btnQuanLyDiem.Enabled = false;
            this.btnQuanLyDiem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLyDiem.Glyph")));
            this.btnQuanLyDiem.Id = 9;
            this.btnQuanLyDiem.Name = "btnQuanLyDiem";
            this.btnQuanLyDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQuanLyDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyDiem_ItemClick);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Caption = "Báo Cáo";
            this.btnBaoCao.Enabled = false;
            this.btnBaoCao.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Glyph")));
            this.btnBaoCao.Id = 10;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBaoCao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKe_ItemClick);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Caption = "Xem Điểm SV";
            this.btnXemDiem.Enabled = false;
            this.btnXemDiem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXemDiem.Glyph")));
            this.btnXemDiem.Id = 11;
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnXemDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemDiem_ItemClick);
            // 
            // btnKetQuaSV
            // 
            this.btnKetQuaSV.Caption = "Điểm Của SV";
            this.btnKetQuaSV.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKetQuaSV.Glyph")));
            this.btnKetQuaSV.Id = 12;
            this.btnKetQuaSV.Name = "btnKetQuaSV";
            this.btnKetQuaSV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKetQuaSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKetQuaSV_ItemClick);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Caption = "Thông Tin";
            this.btnThongTin.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThongTin.Glyph")));
            this.btnThongTin.Id = 13;
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThongTin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongTin_ItemClick);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Caption = "Hướng Dẫn Sử Dụng";
            this.btnHuongDan.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHuongDan.Glyph")));
            this.btnHuongDan.Id = 14;
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHuongDan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuongDan_ItemClick);
            // 
            // btnLienHe
            // 
            this.btnLienHe.Caption = "Liên Hệ Với Khoa";
            this.btnLienHe.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLienHe.Glyph")));
            this.btnLienHe.Id = 15;
            this.btnLienHe.Name = "btnLienHe";
            this.btnLienHe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLienHe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLienHe_ItemClick);
            // 
            // btnTDDT
            // 
            this.btnTDDT.Caption = "Trình Độ Đào Tạo";
            this.btnTDDT.Enabled = false;
            this.btnTDDT.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTDDT.Glyph")));
            this.btnTDDT.Id = 16;
            this.btnTDDT.Name = "btnTDDT";
            this.btnTDDT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTDDT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTDDT_ItemClick);
            // 
            // btnHeDT
            // 
            this.btnHeDT.Caption = "Hệ Đào Tạo";
            this.btnHeDT.Enabled = false;
            this.btnHeDT.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHeDT.Glyph")));
            this.btnHeDT.Id = 17;
            this.btnHeDT.Name = "btnHeDT";
            this.btnHeDT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHeDT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHeDT_ItemClick);
            // 
            // btnKhoiLop
            // 
            this.btnKhoiLop.Caption = "Khối Lớp";
            this.btnKhoiLop.Enabled = false;
            this.btnKhoiLop.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKhoiLop.Glyph")));
            this.btnKhoiLop.Id = 18;
            this.btnKhoiLop.Name = "btnKhoiLop";
            this.btnKhoiLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKhoiLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoiLop_ItemClick);
            // 
            // btnKHGD
            // 
            this.btnKHGD.Caption = "Kế Hoạch Giảng Dạy";
            this.btnKHGD.Enabled = false;
            this.btnKHGD.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKHGD.Glyph")));
            this.btnKHGD.Id = 19;
            this.btnKHGD.Name = "btnKHGD";
            this.btnKHGD.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKHGD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKHGD_ItemClick);
            // 
            // btnHocKy
            // 
            this.btnHocKy.Caption = "Học Kỳ";
            this.btnHocKy.Enabled = false;
            this.btnHocKy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHocKy.Glyph")));
            this.btnHocKy.Id = 20;
            this.btnHocKy.Name = "btnHocKy";
            this.btnHocKy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHocKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocKy_ItemClick);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Caption = "Thống Kê";
            this.btnThongKe.Enabled = false;
            this.btnThongKe.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Glyph")));
            this.btnThongKe.Id = 21;
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThongKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKe_ItemClick_1);
            // 
            // btnXemDiemLop
            // 
            this.btnXemDiemLop.Caption = "Xem Điểm Lớp";
            this.btnXemDiemLop.Enabled = false;
            this.btnXemDiemLop.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXemDiemLop.Glyph")));
            this.btnXemDiemLop.Id = 23;
            this.btnXemDiemLop.Name = "btnXemDiemLop";
            this.btnXemDiemLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnXemDiemLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemDiemLop_ItemClick);
            // 
            // pageHeThong
            // 
            this.pageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pgHeThong});
            this.pageHeThong.Name = "pageHeThong";
            this.pageHeThong.Text = "Hệ Thống";
            // 
            // pgHeThong
            // 
            this.pgHeThong.ItemLinks.Add(this.btnDangNhap);
            this.pgHeThong.ItemLinks.Add(this.btnDangXuat);
            this.pgHeThong.ItemLinks.Add(this.btnPhanQuyen);
            this.pgHeThong.ItemLinks.Add(this.btnThoat);
            this.pgHeThong.Name = "pgHeThong";
            this.pgHeThong.ShowCaptionButton = false;
            // 
            // pageDanhMuc
            // 
            this.pageDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pgDanhMuc});
            this.pageDanhMuc.Name = "pageDanhMuc";
            this.pageDanhMuc.Text = "Danh Mục";
            // 
            // pgDanhMuc
            // 
            this.pgDanhMuc.ItemLinks.Add(this.btnTDDT);
            this.pgDanhMuc.ItemLinks.Add(this.btnHeDT);
            this.pgDanhMuc.ItemLinks.Add(this.btnKhoiLop);
            this.pgDanhMuc.ItemLinks.Add(this.btnKHGD);
            this.pgDanhMuc.ItemLinks.Add(this.btnHocKy);
            this.pgDanhMuc.ItemLinks.Add(this.btnGiangVien);
            this.pgDanhMuc.ItemLinks.Add(this.btnSinhVien);
            this.pgDanhMuc.ItemLinks.Add(this.btnHocPhan);
            this.pgDanhMuc.ItemLinks.Add(this.btnNhomHocPhan);
            this.pgDanhMuc.ItemLinks.Add(this.btnLop);
            this.pgDanhMuc.Name = "pgDanhMuc";
            this.pgDanhMuc.ShowCaptionButton = false;
            // 
            // pageChucNang
            // 
            this.pageChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pgChucNang,
            this.rbgXemDiem});
            this.pageChucNang.Name = "pageChucNang";
            this.pageChucNang.Text = "Chức Năng";
            // 
            // pgChucNang
            // 
            this.pgChucNang.ItemLinks.Add(this.btnQuanLyDiem);
            this.pgChucNang.ItemLinks.Add(this.btnBaoCao);
            this.pgChucNang.ItemLinks.Add(this.btnThongKe);
            this.pgChucNang.Name = "pgChucNang";
            this.pgChucNang.ShowCaptionButton = false;
            // 
            // rbgXemDiem
            // 
            this.rbgXemDiem.ItemLinks.Add(this.btnXemDiem);
            this.rbgXemDiem.ItemLinks.Add(this.btnXemDiemLop);
            this.rbgXemDiem.ItemLinks.Add(this.btnXemDiemNhomHP);
            this.rbgXemDiem.Name = "rbgXemDiem";
            this.rbgXemDiem.ShowCaptionButton = false;
            // 
            // pageTimKiem
            // 
            this.pageTimKiem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pgTimKiem});
            this.pageTimKiem.Name = "pageTimKiem";
            this.pageTimKiem.Text = "Tìm Kiếm";
            // 
            // pgTimKiem
            // 
            this.pgTimKiem.ItemLinks.Add(this.btnKetQuaSV);
            this.pgTimKiem.ItemLinks.Add(this.btnThongTin);
            this.pgTimKiem.Name = "pgTimKiem";
            this.pgTimKiem.ShowCaptionButton = false;
            // 
            // pageTroGiup
            // 
            this.pageTroGiup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pgTroGiup});
            this.pageTroGiup.Name = "pageTroGiup";
            this.pageTroGiup.Text = "Trợ Giúp";
            // 
            // pgTroGiup
            // 
            this.pgTroGiup.ItemLinks.Add(this.btnHuongDan);
            this.pgTroGiup.ItemLinks.Add(this.btnLienHe);
            this.pgTroGiup.Name = "pgTroGiup";
            this.pgTroGiup.ShowCaptionButton = false;
            // 
            // btnXemDiemNhomHP
            // 
            this.btnXemDiemNhomHP.Caption = "Xem Điểm Nhóm HP";
            this.btnXemDiemNhomHP.Enabled = false;
            this.btnXemDiemNhomHP.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXemDiemNhomHP.Glyph")));
            this.btnXemDiemNhomHP.Id = 24;
            this.btnXemDiemNhomHP.Name = "btnXemDiemNhomHP";
            this.btnXemDiemNhomHP.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnXemDiemNhomHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemDiemNhomHP_ItemClick);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.ribbonControl9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Điểm Khoa CNTT";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl9;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnPhanQuyen;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageTimKiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgTimKiem;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageTroGiup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgTroGiup;
        private DevExpress.XtraBars.BarButtonItem btnGiangVien;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnHocPhan;
        private DevExpress.XtraBars.BarButtonItem btnNhomHocPhan;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyDiem;
        private DevExpress.XtraBars.BarButtonItem btnBaoCao;
        private DevExpress.XtraBars.BarButtonItem btnXemDiem;
        private DevExpress.XtraBars.BarButtonItem btnKetQuaSV;
        private DevExpress.XtraBars.BarButtonItem btnThongTin;
        private DevExpress.XtraBars.BarButtonItem btnHuongDan;
        private DevExpress.XtraBars.BarButtonItem btnLienHe;
        private DevExpress.XtraBars.BarButtonItem btnTDDT;
        private DevExpress.XtraBars.BarButtonItem btnHeDT;
        private DevExpress.XtraBars.BarButtonItem btnKhoiLop;
        private DevExpress.XtraBars.BarButtonItem btnKHGD;
        private DevExpress.XtraBars.BarButtonItem btnHocKy;
        private DevExpress.XtraBars.BarButtonItem btnThongKe;
        private DevExpress.XtraBars.BarButtonItem btnXemDiemLop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgXemDiem;
        private DevExpress.XtraBars.BarButtonItem btnXemDiemNhomHP;

    }
}

