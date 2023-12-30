using System.Windows.Forms;
using QLKTX.Phong;
using QLKTX.Day;
using QLKTX.KTX;
namespace QLKTX
{
    partial class frmMainForm
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
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.RibbonBar barHeThong_HeThong;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.btnHeThong_DangNhap = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_DangXuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_Thoat = new DevComponents.DotNetBar.ButtonItem();
            this.tabMainTool = new DevComponents.DotNetBar.TabControl();
            this.tabpQLDay = new DevComponents.DotNetBar.TabControlPanel();
            this.barQlDay_ThongKeKTX = new DevComponents.DotNetBar.RibbonBar();
            this.labelItem28 = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer44 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer45 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer46 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem30 = new DevComponents.DotNetBar.LabelItem();
            this.comboBoxItem17 = new DevComponents.DotNetBar.ComboBoxItem();
            this.buttonItem63 = new DevComponents.DotNetBar.ButtonItem();
            this.barQlDay_ThongKeDay = new DevComponents.DotNetBar.RibbonBar();
            this.labelItem25 = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer41 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer42 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer43 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem27 = new DevComponents.DotNetBar.LabelItem();
            this.comboBoxItem15 = new DevComponents.DotNetBar.ComboBoxItem();
            this.buttonItem62 = new DevComponents.DotNetBar.ButtonItem();
            this.barQlDay_Day = new DevComponents.DotNetBar.RibbonBar();
            this.btn_Day_ThemDay = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Day_KTX = new DevComponents.DotNetBar.ButtonItem();
            this.tabQLDay = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabpQLPhong = new DevComponents.DotNetBar.TabControlPanel();
            this.barQLPhong_ThongKe = new DevComponents.DotNetBar.RibbonBar();
            this.labelItem14 = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer30 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer31 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer32 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem16 = new DevComponents.DotNetBar.LabelItem();
            this.cmb_QLPHG_ThongKe_Phong = new DevComponents.DotNetBar.ComboBoxItem();
            this.buttonItem60 = new DevComponents.DotNetBar.ButtonItem();
            this.barQLPhong_DanhGiaPhong = new DevComponents.DotNetBar.RibbonBar();
            this.cntQLPhong_DanhGiaPhong1 = new DevComponents.DotNetBar.ItemContainer();
            this.cntQLPhong_DanhGiaPhong2 = new DevComponents.DotNetBar.ItemContainer();
            this.lblQLPhong_DanhGiaPhong = new DevComponents.DotNetBar.LabelItem();
            this.cmbQLPhong_DanhGiaPhong = new DevComponents.DotNetBar.ComboBoxItem();
            this.btnQLPhong_DanhGiaPhong_NhapDiem = new DevComponents.DotNetBar.ButtonItem();
            this.barQLPhong_Phong = new DevComponents.DotNetBar.RibbonBar();
            this.btnQLPhong_ThemPhong = new DevComponents.DotNetBar.ButtonItem();
            this.tabQLPhong = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabpQLSV = new DevComponents.DotNetBar.TabControlPanel();
            this.barQLSV_ThongKe = new DevComponents.DotNetBar.RibbonBar();
            this.lblQLSV_ThongKe = new DevComponents.DotNetBar.LabelItem();
            this.cntQLSV_Thongke1 = new DevComponents.DotNetBar.ItemContainer();
            this.cntQLSV_Thongke2 = new DevComponents.DotNetBar.ItemContainer();
            this.lblQLSV_ThongKe1 = new DevComponents.DotNetBar.LabelItem();
            this.cmbQLSV_ThongKe = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.btnQLSV_ThongKe = new DevComponents.DotNetBar.ButtonItem();
            this.barQLSV_DanhGia = new DevComponents.DotNetBar.RibbonBar();
            this.cntQLSV_DanhGia1 = new DevComponents.DotNetBar.ItemContainer();
            this.btnQLSV_KyLuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnQLSV_KhenThuong = new DevComponents.DotNetBar.ButtonItem();
            this.cntQLSV_DanhGia2 = new DevComponents.DotNetBar.ItemContainer();
            this.btnQLSV_DanhGia = new DevComponents.DotNetBar.ButtonItem();
            this.btnQLSV_HoatDong = new DevComponents.DotNetBar.ButtonItem();
            this.barQLSV_QuanLy = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.btnQLSV_QuanLy_DiemDanh = new DevComponents.DotNetBar.ButtonItem();
            this.btnQLSV_QuanLy_ChuyenPhong = new DevComponents.DotNetBar.ButtonItem();
            this.btnQLSV_QuanLy_XepPhong = new DevComponents.DotNetBar.ButtonItem();
            this.barQLSV_TraCuu = new DevComponents.DotNetBar.RibbonBar();
            this.cntQLSV_TraCuu = new DevComponents.DotNetBar.ItemContainer();
            this.btnQLSV_TraCuu_Phong1 = new DevComponents.DotNetBar.ButtonItem();
            this.cmbQLSV_TraCuu_Phong = new DevComponents.DotNetBar.ComboBoxItem();
            this.btnQLSV_TraCuu_Phong = new DevComponents.DotNetBar.ButtonItem();
            this.btnQLSV_TraCuu_Day1 = new DevComponents.DotNetBar.ButtonItem();
            this.cmbQLSV_TraCuu_Day = new DevComponents.DotNetBar.ComboBoxItem();
            this.btnQLSV_TraCuu_Day = new DevComponents.DotNetBar.ButtonItem();
            this.btnQLSV_TraCuu_Chung = new DevComponents.DotNetBar.ButtonItem();
            this.barQLSV_SinhVien = new DevComponents.DotNetBar.RibbonBar();
            this.btnQLSV_ThemSinhVien = new DevComponents.DotNetBar.ButtonItem();
            this.btnQLSV_SuaSinhVien = new DevComponents.DotNetBar.ButtonItem();
            this.tabQLSV = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabpHeThong = new DevComponents.DotNetBar.TabControlPanel();
            this.barHeThong_HienThi = new DevComponents.DotNetBar.RibbonBar();
            this.btnHeThong_HienThi = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_Ngang = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_Doc = new DevComponents.DotNetBar.ButtonItem();
            this.barHeThong_NguoiDung = new DevComponents.DotNetBar.RibbonBar();
            this.lblHeThong_NguoiDung = new DevComponents.DotNetBar.LabelItem();
            this.cntHeThong_NguoiDung = new DevComponents.DotNetBar.ItemContainer();
            this.btnHeThong_NguoiDung = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_CBQL = new DevComponents.DotNetBar.ButtonItem();
            this.barHeThong_QLDanhMuc = new DevComponents.DotNetBar.RibbonBar();
            this.cntHeThong_QLDanhMuc1 = new DevComponents.DotNetBar.ItemContainer();
            this.btnHeThong_NgayThangNam = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_NamHoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_HocKy = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_QuocTich = new DevComponents.DotNetBar.ButtonItem();
            this.btn_HeThong_TonGiao = new DevComponents.DotNetBar.ButtonItem();
            this.btn_HeThong_DanToc = new DevComponents.DotNetBar.ButtonItem();
            this.btn_HeThong_QuocTich = new DevComponents.DotNetBar.ButtonItem();
            this.cntHeThong_QLDanhMuc2 = new DevComponents.DotNetBar.ItemContainer();
            this.btnHeThong_KhenThuongKyLuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_KyLuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_KhenThuong = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_DanhGia = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_DanhGiaXepLoai = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem28 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem27 = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_HoatDong = new DevComponents.DotNetBar.ButtonItem();
            this.barHeThong_QLDuLieu = new DevComponents.DotNetBar.RibbonBar();
            this.btnHeThong_SaoLuu = new DevComponents.DotNetBar.ButtonItem();
            this.btnHeThong_PhucHoi = new DevComponents.DotNetBar.ButtonItem();
            this.tabHeThong = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabpTraCuu = new DevComponents.DotNetBar.TabControlPanel();
            this.barQlTraCuu_KTX = new DevComponents.DotNetBar.RibbonBar();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer19 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer39 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem24 = new DevComponents.DotNetBar.LabelItem();
            this.comboBoxItem6 = new DevComponents.DotNetBar.ComboBoxItem();
            this.buttonItem38 = new DevComponents.DotNetBar.ButtonItem();
            this.barQlTraCuu_Day = new DevComponents.DotNetBar.RibbonBar();
            this.labelItem7 = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer18 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer37 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem22 = new DevComponents.DotNetBar.LabelItem();
            this.comboBoxItem5 = new DevComponents.DotNetBar.ComboBoxItem();
            this.buttonItem37 = new DevComponents.DotNetBar.ButtonItem();
            this.barQlTraCuu_Phong = new DevComponents.DotNetBar.RibbonBar();
            this.labelItem6 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem36 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer17 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer35 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem19 = new DevComponents.DotNetBar.LabelItem();
            this.comboBoxItem4 = new DevComponents.DotNetBar.ComboBoxItem();
            this.barQlTraCuu_SinhVien = new DevComponents.DotNetBar.RibbonBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer16 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer33 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem18 = new DevComponents.DotNetBar.LabelItem();
            this.comboBoxItem3 = new DevComponents.DotNetBar.ComboBoxItem();
            this.itemContainer34 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer40 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem23 = new DevComponents.DotNetBar.LabelItem();
            this.textBoxItem4 = new DevComponents.DotNetBar.TextBoxItem();
            this.buttonItem35 = new DevComponents.DotNetBar.ButtonItem();
            this.tabTraCuu = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabpTroGiup = new DevComponents.DotNetBar.TabControlPanel();
            this.barQlTroGiup_TroGiup = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem61 = new DevComponents.DotNetBar.ButtonItem();
            this.btnGioiThieu = new DevComponents.DotNetBar.ButtonItem();
            this.tabTroGiup = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabExplorer = new DevComponents.DotNetBar.ExpandablePanel();
            this.expandablePanel6 = new DevComponents.DotNetBar.ExpandablePanel();
            this.taskTab_XepLoai = new XPExplorerBar.TaskItem();
            this.taskTab_DanhGia = new XPExplorerBar.TaskItem();
            this.taskTab_HoatDong = new XPExplorerBar.TaskItem();
            this.expandablePanel5 = new DevComponents.DotNetBar.ExpandablePanel();
            this.taskTab_TroGiup = new XPExplorerBar.TaskItem();
            this.expandablePanel4 = new DevComponents.DotNetBar.ExpandablePanel();
            this.taskTab_TraCuuPhong = new XPExplorerBar.TaskItem();
            this.taskTab_TraCuuSinhVien = new XPExplorerBar.TaskItem();
            this.expandablePanel3 = new DevComponents.DotNetBar.ExpandablePanel();
            this.taskTab_HoatDongSinhVien = new XPExplorerBar.TaskItem();
            this.taskTab_ThongTinPhong = new XPExplorerBar.TaskItem();
            this.taskTab_DiemDanh = new XPExplorerBar.TaskItem();
            this.taskTab_ThongTinSinhVien = new XPExplorerBar.TaskItem();
            this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
            this.taskTab_HienThi = new XPExplorerBar.TaskItem();
            this.taskTab_NguoiDung = new XPExplorerBar.TaskItem();
            this.taskTab_Thoat = new XPExplorerBar.TaskItem();
            this.taskTab_DangXuat = new XPExplorerBar.TaskItem();
            this.taskTab_DangNhap = new XPExplorerBar.TaskItem();
            this.itemContainer8 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem14 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer9 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer10 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer11 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer12 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer13 = new DevComponents.DotNetBar.ItemContainer();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong_DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHeThong_NguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong_tab = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHeThong_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV_ThemSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV_SuaSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV_XoaSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLSV_TraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLSV_QuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV_DiemDanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV_ChuyenPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV_DanhGia1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV_HoatDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV_DanhGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV_KhenThuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSV_KyLuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLPhong_ThemPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLPhong_SuaPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLPhong_XoaPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLPhong_DanhGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLPhong_KWDien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLPhong_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLPhong_ThuTien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLPhong_TienDien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLPhong_TienPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDay_ThemDay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDay_SuaDay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDay_XoaDay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLDay_ThemKTX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDay_SuaKTX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDay_XoaKTX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLDay_ThongKeDay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDay_ThongKeKTX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDay_TraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDay_TraCuuDay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDay_TraCuuKTX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraCuu_SinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraCuu_Phong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraCuu_Day = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraCuu_KTX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup_TroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup_GioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxItem5 = new DevComponents.DotNetBar.TextBoxItem();
            this.textBoxItem7 = new DevComponents.DotNetBar.TextBoxItem();
            this.toolMenuBar = new System.Windows.Forms.ToolStrip();
            this.btnMainTool_DangNhap = new System.Windows.Forms.ToolStripButton();
            this.btnMainTool_DangXuat = new System.Windows.Forms.ToolStripButton();
            this.btnMainTool_Thoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ngangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMainTool_ThemSinhVien = new System.Windows.Forms.ToolStripButton();
            this.btnMainTool_SuaSinhVien = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMainTool_TraCuu = new System.Windows.Forms.ToolStripSplitButton();
            this.btnToolMenuBar_TraCuu_SinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolMenuBar_TraCuu_Phong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolMenuBar_TraCuu_Day = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolMenuBar_TraCuu_KTX = new System.Windows.Forms.ToolStripMenuItem();
            this.XPExplorer = new DevComponents.DotNetBar.ExpandablePanel();
            this.taskPane1 = new XPExplorerBar.TaskPane();
            this.expando1 = new XPExplorerBar.Expando();
            this.taskXP_HienThi = new XPExplorerBar.TaskItem();
            this.taskXP_DangNhap = new XPExplorerBar.TaskItem();
            this.taskXP_DangXuat = new XPExplorerBar.TaskItem();
            this.taskXP_NguoiDung = new XPExplorerBar.TaskItem();
            this.taskXP_Thoat = new XPExplorerBar.TaskItem();
            this.expando2 = new XPExplorerBar.Expando();
            this.taskXP_ThongTinSinhVien = new XPExplorerBar.TaskItem();
            this.taskXP_DiemDanh = new XPExplorerBar.TaskItem();
            this.taskXP_ThongTinPhong = new XPExplorerBar.TaskItem();
            this.taskXP_HoatDongSinhVien = new XPExplorerBar.TaskItem();
            this.expando3 = new XPExplorerBar.Expando();
            this.taskXP_TraCuuSinhVien = new XPExplorerBar.TaskItem();
            this.taskXP_TraCuuPhong = new XPExplorerBar.TaskItem();
            this.expando4 = new XPExplorerBar.Expando();
            this.taskXP_TroGiup = new XPExplorerBar.TaskItem();
            this.expando5 = new XPExplorerBar.Expando();
            this.taskXP_Thang = new XPExplorerBar.TaskItem();
            this.taskXP_HoatDong = new XPExplorerBar.TaskItem();
            this.taskXP_DanhGia = new XPExplorerBar.TaskItem();
            this.taskXP_XepLoai = new XPExplorerBar.TaskItem();
            this.textBoxItem1 = new DevComponents.DotNetBar.TextBoxItem();
            this.sprHuongDan = new DevComponents.DotNetBar.SuperTooltip();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnFull = new DevComponents.DotNetBar.ButtonItem();
            this.btnNormal = new DevComponents.DotNetBar.ButtonItem();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.contextMenuBar2 = new DevComponents.DotNetBar.ContextMenuBar();
            barHeThong_HeThong = new DevComponents.DotNetBar.RibbonBar();
            ((System.ComponentModel.ISupportInitialize)(this.tabMainTool)).BeginInit();
            this.tabMainTool.SuspendLayout();
            this.tabpQLDay.SuspendLayout();
            this.tabpQLPhong.SuspendLayout();
            this.tabpQLSV.SuspendLayout();
            this.tabpHeThong.SuspendLayout();
            this.tabpTraCuu.SuspendLayout();
            this.tabpTroGiup.SuspendLayout();
            this.tabExplorer.SuspendLayout();
            this.expandablePanel6.SuspendLayout();
            this.expandablePanel5.SuspendLayout();
            this.expandablePanel4.SuspendLayout();
            this.expandablePanel3.SuspendLayout();
            this.expandablePanel2.SuspendLayout();
            this.mnuMainMenu.SuspendLayout();
            this.toolMenuBar.SuspendLayout();
            this.XPExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskPane1)).BeginInit();
            this.taskPane1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expando1)).BeginInit();
            this.expando1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expando2)).BeginInit();
            this.expando2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expando3)).BeginInit();
            this.expando3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expando4)).BeginInit();
            this.expando4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expando5)).BeginInit();
            this.expando5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // barHeThong_HeThong
            // 
            barHeThong_HeThong.AutoOverflowEnabled = true;
            barHeThong_HeThong.DialogLauncherVisible = true;
            barHeThong_HeThong.Dock = System.Windows.Forms.DockStyle.Left;
            barHeThong_HeThong.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            barHeThong_HeThong.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHeThong_DangNhap,
            this.btnHeThong_DangXuat,
            this.btnHeThong_Thoat});
            barHeThong_HeThong.Location = new System.Drawing.Point(1, 1);
            barHeThong_HeThong.Name = "barHeThong_HeThong";
            barHeThong_HeThong.Size = new System.Drawing.Size(178, 86);
            barHeThong_HeThong.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            barHeThong_HeThong.TabIndex = 0;
            barHeThong_HeThong.Text = "Hệ thống";
            barHeThong_HeThong.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // btnHeThong_DangNhap
            // 
            this.btnHeThong_DangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong_DangNhap.Image")));
            this.btnHeThong_DangNhap.ImagePaddingHorizontal = 8;
            this.btnHeThong_DangNhap.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHeThong_DangNhap.Name = "btnHeThong_DangNhap";
            this.btnHeThong_DangNhap.RibbonWordWrap = false;
            this.btnHeThong_DangNhap.SubItemsExpandWidth = 14;
            this.btnHeThong_DangNhap.Text = "Đăng nhập";
            this.btnHeThong_DangNhap.Click += new System.EventHandler(this.btnHeThong_DangNhap_Click);
            // 
            // btnHeThong_DangXuat
            // 
            this.btnHeThong_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong_DangXuat.Image")));
            this.btnHeThong_DangXuat.ImagePaddingHorizontal = 8;
            this.btnHeThong_DangXuat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHeThong_DangXuat.Name = "btnHeThong_DangXuat";
            this.btnHeThong_DangXuat.RibbonWordWrap = false;
            this.btnHeThong_DangXuat.SubItemsExpandWidth = 14;
            this.btnHeThong_DangXuat.Text = "Đăng xuất";
            this.btnHeThong_DangXuat.Click += new System.EventHandler(this.btnHeThong_DangXuat_Click);
            // 
            // btnHeThong_Thoat
            // 
            this.btnHeThong_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong_Thoat.Image")));
            this.btnHeThong_Thoat.ImagePaddingHorizontal = 8;
            this.btnHeThong_Thoat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHeThong_Thoat.Name = "btnHeThong_Thoat";
            this.btnHeThong_Thoat.SubItemsExpandWidth = 14;
            this.btnHeThong_Thoat.Text = "Thoát";
            this.btnHeThong_Thoat.Click += new System.EventHandler(this.buttonItem17_Click);
            // 
            // tabMainTool
            // 
            this.tabMainTool.CanReorderTabs = true;
            this.tabMainTool.Controls.Add(this.tabpHeThong);
            this.tabMainTool.Controls.Add(this.tabpQLSV);
            this.tabMainTool.Controls.Add(this.tabpQLDay);
            this.tabMainTool.Controls.Add(this.tabpTroGiup);
            this.tabMainTool.Controls.Add(this.tabpTraCuu);
            this.tabMainTool.Controls.Add(this.tabpQLPhong);
            this.tabMainTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMainTool.FixedTabSize = new System.Drawing.Size(0, 27);
            this.tabMainTool.Location = new System.Drawing.Point(0, 0);
            this.tabMainTool.Name = "tabMainTool";
            this.tabMainTool.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabMainTool.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabMainTool.SelectedTabIndex = 0;
            this.tabMainTool.Size = new System.Drawing.Size(804, 118);
            this.tabMainTool.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock;
            this.tabMainTool.TabIndex = 0;
            this.tabMainTool.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabMainTool.Tabs.Add(this.tabHeThong);
            this.tabMainTool.Tabs.Add(this.tabQLSV);
            this.tabMainTool.Tabs.Add(this.tabQLPhong);
            this.tabMainTool.Tabs.Add(this.tabQLDay);
            this.tabMainTool.Tabs.Add(this.tabTraCuu);
            this.tabMainTool.Tabs.Add(this.tabTroGiup);
            this.tabMainTool.Text = "tabTraCuu";
            this.tabMainTool.Click += new System.EventHandler(this.tabMainTool_Click);
            // 
            // tabpQLDay
            // 
            this.tabpQLDay.Controls.Add(this.barQlDay_ThongKeKTX);
            this.tabpQLDay.Controls.Add(this.barQlDay_ThongKeDay);
            this.tabpQLDay.Controls.Add(this.barQlDay_Day);
            this.tabpQLDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpQLDay.Location = new System.Drawing.Point(0, 30);
            this.tabpQLDay.Name = "tabpQLDay";
            this.tabpQLDay.Padding = new System.Windows.Forms.Padding(1);
            this.tabpQLDay.Size = new System.Drawing.Size(804, 88);
            this.tabpQLDay.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabpQLDay.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabpQLDay.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabpQLDay.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabpQLDay.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabpQLDay.Style.GradientAngle = 90;
            this.tabpQLDay.TabIndex = 4;
            this.tabpQLDay.TabItem = this.tabQLDay;
            // 
            // barQlDay_ThongKeKTX
            // 
            this.barQlDay_ThongKeKTX.AutoOverflowEnabled = true;
            this.barQlDay_ThongKeKTX.DialogLauncherVisible = true;
            this.barQlDay_ThongKeKTX.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQlDay_ThongKeKTX.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barQlDay_ThongKeKTX.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem28,
            this.itemContainer44});
            this.barQlDay_ThongKeKTX.Location = new System.Drawing.Point(308, 1);
            this.barQlDay_ThongKeKTX.Name = "barQlDay_ThongKeKTX";
            this.barQlDay_ThongKeKTX.Size = new System.Drawing.Size(173, 86);
            this.barQlDay_ThongKeKTX.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQlDay_ThongKeKTX.TabIndex = 5;
            this.barQlDay_ThongKeKTX.Text = "Thống kê theo KTX";
            this.barQlDay_ThongKeKTX.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem28
            // 
            this.labelItem28.Image = ((System.Drawing.Image)(resources.GetObject("labelItem28.Image")));
            this.labelItem28.Name = "labelItem28";
            // 
            // itemContainer44
            // 
            this.itemContainer44.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer44.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer44.Name = "itemContainer44";
            this.itemContainer44.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer45,
            this.itemContainer46,
            this.buttonItem63});
            // 
            // itemContainer45
            // 
            this.itemContainer45.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer45.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer45.Name = "itemContainer45";
            // 
            // itemContainer46
            // 
            this.itemContainer46.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer46.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer46.Name = "itemContainer46";
            this.itemContainer46.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem30,
            this.comboBoxItem17});
            // 
            // labelItem30
            // 
            this.labelItem30.Name = "labelItem30";
            this.labelItem30.Text = "KTX:";
            // 
            // comboBoxItem17
            // 
            this.comboBoxItem17.DropDownHeight = 106;
            this.comboBoxItem17.Name = "comboBoxItem17";
            this.comboBoxItem17.Text = "comboBoxItem17";
            // 
            // buttonItem63
            // 
            this.buttonItem63.ImagePaddingHorizontal = 8;
            this.buttonItem63.Name = "buttonItem63";
            this.buttonItem63.Text = "Thống kê";
            this.buttonItem63.Click += new System.EventHandler(this.buttonItem63_Click);
            // 
            // barQlDay_ThongKeDay
            // 
            this.barQlDay_ThongKeDay.AutoOverflowEnabled = true;
            this.barQlDay_ThongKeDay.DialogLauncherVisible = true;
            this.barQlDay_ThongKeDay.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQlDay_ThongKeDay.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barQlDay_ThongKeDay.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem25,
            this.itemContainer41});
            this.barQlDay_ThongKeDay.Location = new System.Drawing.Point(152, 1);
            this.barQlDay_ThongKeDay.Name = "barQlDay_ThongKeDay";
            this.barQlDay_ThongKeDay.Size = new System.Drawing.Size(156, 86);
            this.barQlDay_ThongKeDay.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQlDay_ThongKeDay.TabIndex = 4;
            this.barQlDay_ThongKeDay.Text = "Thống kê theo Dãy";
            this.barQlDay_ThongKeDay.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem25
            // 
            this.labelItem25.Image = ((System.Drawing.Image)(resources.GetObject("labelItem25.Image")));
            this.labelItem25.Name = "labelItem25";
            // 
            // itemContainer41
            // 
            this.itemContainer41.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer41.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer41.Name = "itemContainer41";
            this.itemContainer41.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer42,
            this.itemContainer43,
            this.buttonItem62});
            // 
            // itemContainer42
            // 
            this.itemContainer42.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer42.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer42.Name = "itemContainer42";
            // 
            // itemContainer43
            // 
            this.itemContainer43.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer43.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer43.Name = "itemContainer43";
            this.itemContainer43.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem27,
            this.comboBoxItem15});
            // 
            // labelItem27
            // 
            this.labelItem27.Name = "labelItem27";
            this.labelItem27.Text = "Dãy:";
            // 
            // comboBoxItem15
            // 
            this.comboBoxItem15.DropDownHeight = 106;
            this.comboBoxItem15.Name = "comboBoxItem15";
            this.comboBoxItem15.Text = "comboBoxItem15";
            // 
            // buttonItem62
            // 
            this.buttonItem62.ImagePaddingHorizontal = 8;
            this.buttonItem62.Name = "buttonItem62";
            this.buttonItem62.Text = "Thống kê";
            this.buttonItem62.Click += new System.EventHandler(this.buttonItem62_Click);
            // 
            // barQlDay_Day
            // 
            this.barQlDay_Day.AutoOverflowEnabled = true;
            this.barQlDay_Day.DialogLauncherVisible = true;
            this.barQlDay_Day.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQlDay_Day.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_Day_ThemDay,
            this.btn_Day_KTX});
            this.barQlDay_Day.Location = new System.Drawing.Point(1, 1);
            this.barQlDay_Day.Name = "barQlDay_Day";
            this.barQlDay_Day.Size = new System.Drawing.Size(151, 86);
            this.barQlDay_Day.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQlDay_Day.TabIndex = 0;
            this.barQlDay_Day.Text = "Quản Lý";
            this.barQlDay_Day.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // btn_Day_ThemDay
            // 
            this.btn_Day_ThemDay.Image = ((System.Drawing.Image)(resources.GetObject("btn_Day_ThemDay.Image")));
            this.btn_Day_ThemDay.ImagePaddingHorizontal = 8;
            this.btn_Day_ThemDay.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Day_ThemDay.Name = "btn_Day_ThemDay";
            this.btn_Day_ThemDay.RibbonWordWrap = false;
            this.btn_Day_ThemDay.SubItemsExpandWidth = 14;
            this.btn_Day_ThemDay.Text = "Quản lý Dãy";
            this.btn_Day_ThemDay.Click += new System.EventHandler(this.btn_Day_ThemDay_Click);
            // 
            // btn_Day_KTX
            // 
            this.btn_Day_KTX.Image = ((System.Drawing.Image)(resources.GetObject("btn_Day_KTX.Image")));
            this.btn_Day_KTX.ImagePaddingHorizontal = 8;
            this.btn_Day_KTX.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Day_KTX.Name = "btn_Day_KTX";
            this.btn_Day_KTX.RibbonWordWrap = false;
            this.btn_Day_KTX.SubItemsExpandWidth = 14;
            this.btn_Day_KTX.Text = "Quản lý KTX";
            this.btn_Day_KTX.Click += new System.EventHandler(this.btn_Day_KTX_Click);
            // 
            // tabQLDay
            // 
            this.tabQLDay.AttachedControl = this.tabpQLDay;
            this.tabQLDay.Image = ((System.Drawing.Image)(resources.GetObject("tabQLDay.Image")));
            this.tabQLDay.Name = "tabQLDay";
            this.tabQLDay.Text = "Quản Lý &Dãy";
            this.tabQLDay.Tooltip = "Quản lý dãy của KTX";
            this.tabQLDay.Click += new System.EventHandler(this.tabMainTool_Click);
            // 
            // tabpQLPhong
            // 
            this.tabpQLPhong.Controls.Add(this.barQLPhong_ThongKe);
            this.tabpQLPhong.Controls.Add(this.barQLPhong_DanhGiaPhong);
            this.tabpQLPhong.Controls.Add(this.barQLPhong_Phong);
            this.tabpQLPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpQLPhong.Location = new System.Drawing.Point(0, 30);
            this.tabpQLPhong.Name = "tabpQLPhong";
            this.tabpQLPhong.Padding = new System.Windows.Forms.Padding(1);
            this.tabpQLPhong.Size = new System.Drawing.Size(804, 88);
            this.tabpQLPhong.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabpQLPhong.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabpQLPhong.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabpQLPhong.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabpQLPhong.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabpQLPhong.Style.GradientAngle = 90;
            this.tabpQLPhong.TabIndex = 3;
            this.tabpQLPhong.TabItem = this.tabQLPhong;
            // 
            // barQLPhong_ThongKe
            // 
            this.barQLPhong_ThongKe.AutoOverflowEnabled = true;
            this.barQLPhong_ThongKe.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQLPhong_ThongKe.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barQLPhong_ThongKe.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem14,
            this.itemContainer30});
            this.barQLPhong_ThongKe.Location = new System.Drawing.Point(222, 1);
            this.barQLPhong_ThongKe.Name = "barQLPhong_ThongKe";
            this.barQLPhong_ThongKe.Size = new System.Drawing.Size(159, 86);
            this.barQLPhong_ThongKe.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQLPhong_ThongKe.TabIndex = 5;
            this.barQLPhong_ThongKe.Text = "Thống kê";
            this.barQLPhong_ThongKe.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem14
            // 
            this.labelItem14.Image = ((System.Drawing.Image)(resources.GetObject("labelItem14.Image")));
            this.labelItem14.Name = "labelItem14";
            // 
            // itemContainer30
            // 
            this.itemContainer30.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer30.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer30.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer30.Name = "itemContainer30";
            this.itemContainer30.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer31,
            this.itemContainer32,
            this.buttonItem60});
            // 
            // itemContainer31
            // 
            this.itemContainer31.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer31.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer31.Name = "itemContainer31";
            // 
            // itemContainer32
            // 
            this.itemContainer32.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer32.Name = "itemContainer32";
            this.itemContainer32.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem16,
            this.cmb_QLPHG_ThongKe_Phong});
            // 
            // labelItem16
            // 
            this.labelItem16.Name = "labelItem16";
            this.labelItem16.Text = "Phòng:";
            // 
            // cmb_QLPHG_ThongKe_Phong
            // 
            this.cmb_QLPHG_ThongKe_Phong.DropDownHeight = 106;
            this.cmb_QLPHG_ThongKe_Phong.Name = "cmb_QLPHG_ThongKe_Phong";
            this.cmb_QLPHG_ThongKe_Phong.Text = "comboBoxItem13";
            // 
            // buttonItem60
            // 
            this.buttonItem60.ImagePaddingHorizontal = 8;
            this.buttonItem60.Name = "buttonItem60";
            this.buttonItem60.Text = "Thông kê";
            this.buttonItem60.Click += new System.EventHandler(this.buttonItem60_Click);
            // 
            // barQLPhong_DanhGiaPhong
            // 
            this.barQLPhong_DanhGiaPhong.AutoOverflowEnabled = true;
            this.barQLPhong_DanhGiaPhong.DialogLauncherVisible = true;
            this.barQLPhong_DanhGiaPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQLPhong_DanhGiaPhong.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barQLPhong_DanhGiaPhong.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cntQLPhong_DanhGiaPhong1});
            this.barQLPhong_DanhGiaPhong.Location = new System.Drawing.Point(95, 1);
            this.barQLPhong_DanhGiaPhong.Name = "barQLPhong_DanhGiaPhong";
            this.barQLPhong_DanhGiaPhong.Size = new System.Drawing.Size(127, 86);
            this.barQLPhong_DanhGiaPhong.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQLPhong_DanhGiaPhong.TabIndex = 2;
            this.barQLPhong_DanhGiaPhong.Text = "Đánh giá phòng";
            this.barQLPhong_DanhGiaPhong.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // cntQLPhong_DanhGiaPhong1
            // 
            this.cntQLPhong_DanhGiaPhong1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.cntQLPhong_DanhGiaPhong1.MinimumSize = new System.Drawing.Size(0, 0);
            this.cntQLPhong_DanhGiaPhong1.Name = "cntQLPhong_DanhGiaPhong1";
            this.cntQLPhong_DanhGiaPhong1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cntQLPhong_DanhGiaPhong2,
            this.btnQLPhong_DanhGiaPhong_NhapDiem});
            // 
            // cntQLPhong_DanhGiaPhong2
            // 
            this.cntQLPhong_DanhGiaPhong2.MinimumSize = new System.Drawing.Size(0, 0);
            this.cntQLPhong_DanhGiaPhong2.Name = "cntQLPhong_DanhGiaPhong2";
            this.cntQLPhong_DanhGiaPhong2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblQLPhong_DanhGiaPhong,
            this.cmbQLPhong_DanhGiaPhong});
            // 
            // lblQLPhong_DanhGiaPhong
            // 
            this.lblQLPhong_DanhGiaPhong.Name = "lblQLPhong_DanhGiaPhong";
            this.lblQLPhong_DanhGiaPhong.Text = "Phòng:";
            // 
            // cmbQLPhong_DanhGiaPhong
            // 
            this.cmbQLPhong_DanhGiaPhong.DropDownHeight = 106;
            this.cmbQLPhong_DanhGiaPhong.Name = "cmbQLPhong_DanhGiaPhong";
            this.cmbQLPhong_DanhGiaPhong.Text = "comboBoxItem11";
            // 
            // btnQLPhong_DanhGiaPhong_NhapDiem
            // 
            this.btnQLPhong_DanhGiaPhong_NhapDiem.ImagePaddingHorizontal = 8;
            this.btnQLPhong_DanhGiaPhong_NhapDiem.Name = "btnQLPhong_DanhGiaPhong_NhapDiem";
            this.btnQLPhong_DanhGiaPhong_NhapDiem.SubItemsExpandWidth = 14;
            this.btnQLPhong_DanhGiaPhong_NhapDiem.Text = "Nhập điểm kiểm tra";
            this.btnQLPhong_DanhGiaPhong_NhapDiem.Click += new System.EventHandler(this.btnQLPhong_DanhGiaPhong_NhapDiem_Click);
            // 
            // barQLPhong_Phong
            // 
            this.barQLPhong_Phong.AutoOverflowEnabled = true;
            this.barQLPhong_Phong.DialogLauncherVisible = true;
            this.barQLPhong_Phong.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQLPhong_Phong.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQLPhong_ThemPhong});
            this.barQLPhong_Phong.Location = new System.Drawing.Point(1, 1);
            this.barQLPhong_Phong.Name = "barQLPhong_Phong";
            this.barQLPhong_Phong.Size = new System.Drawing.Size(94, 86);
            this.barQLPhong_Phong.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQLPhong_Phong.TabIndex = 0;
            this.barQLPhong_Phong.Text = "Quản lý";
            this.barQLPhong_Phong.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // btnQLPhong_ThemPhong
            // 
            this.btnQLPhong_ThemPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnQLPhong_ThemPhong.Image")));
            this.btnQLPhong_ThemPhong.ImagePaddingHorizontal = 8;
            this.btnQLPhong_ThemPhong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQLPhong_ThemPhong.Name = "btnQLPhong_ThemPhong";
            this.btnQLPhong_ThemPhong.RibbonWordWrap = false;
            this.btnQLPhong_ThemPhong.SubItemsExpandWidth = 14;
            this.btnQLPhong_ThemPhong.Text = "Quản lý phòng";
            this.btnQLPhong_ThemPhong.Click += new System.EventHandler(this.btnQLPhong_ThemPhong_Click_1);
            // 
            // tabQLPhong
            // 
            this.tabQLPhong.AttachedControl = this.tabpQLPhong;
            this.tabQLPhong.Image = ((System.Drawing.Image)(resources.GetObject("tabQLPhong.Image")));
            this.tabQLPhong.Name = "tabQLPhong";
            this.tabQLPhong.Text = "Quản Lý &Phòng";
            this.tabQLPhong.Tooltip = "Quản lý phòng trong KTX";
            this.tabQLPhong.Click += new System.EventHandler(this.tabMainTool_Click);
            // 
            // tabpQLSV
            // 
            this.tabpQLSV.Controls.Add(this.barQLSV_ThongKe);
            this.tabpQLSV.Controls.Add(this.barQLSV_DanhGia);
            this.tabpQLSV.Controls.Add(this.barQLSV_QuanLy);
            this.tabpQLSV.Controls.Add(this.barQLSV_TraCuu);
            this.tabpQLSV.Controls.Add(this.barQLSV_SinhVien);
            this.tabpQLSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpQLSV.Location = new System.Drawing.Point(0, 30);
            this.tabpQLSV.Name = "tabpQLSV";
            this.tabpQLSV.Padding = new System.Windows.Forms.Padding(1);
            this.tabpQLSV.Size = new System.Drawing.Size(804, 88);
            this.tabpQLSV.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabpQLSV.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabpQLSV.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabpQLSV.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabpQLSV.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabpQLSV.Style.GradientAngle = 90;
            this.tabpQLSV.TabIndex = 2;
            this.tabpQLSV.TabItem = this.tabQLSV;
            // 
            // barQLSV_ThongKe
            // 
            this.barQLSV_ThongKe.AutoOverflowEnabled = true;
            this.barQLSV_ThongKe.DialogLauncherVisible = true;
            this.barQLSV_ThongKe.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQLSV_ThongKe.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblQLSV_ThongKe,
            this.cntQLSV_Thongke1});
            this.barQLSV_ThongKe.Location = new System.Drawing.Point(578, 1);
            this.barQLSV_ThongKe.Name = "barQLSV_ThongKe";
            this.barQLSV_ThongKe.Size = new System.Drawing.Size(173, 86);
            this.barQLSV_ThongKe.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQLSV_ThongKe.TabIndex = 9;
            this.barQLSV_ThongKe.Text = "Thống kê";
            this.barQLSV_ThongKe.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // lblQLSV_ThongKe
            // 
            this.lblQLSV_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("lblQLSV_ThongKe.Image")));
            this.lblQLSV_ThongKe.Name = "lblQLSV_ThongKe";
            // 
            // cntQLSV_Thongke1
            // 
            this.cntQLSV_Thongke1.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.cntQLSV_Thongke1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.cntQLSV_Thongke1.MinimumSize = new System.Drawing.Size(0, 0);
            this.cntQLSV_Thongke1.Name = "cntQLSV_Thongke1";
            this.cntQLSV_Thongke1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cntQLSV_Thongke2,
            this.btnQLSV_ThongKe});
            // 
            // cntQLSV_Thongke2
            // 
            this.cntQLSV_Thongke2.MinimumSize = new System.Drawing.Size(0, 0);
            this.cntQLSV_Thongke2.Name = "cntQLSV_Thongke2";
            this.cntQLSV_Thongke2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblQLSV_ThongKe1,
            this.cmbQLSV_ThongKe});
            // 
            // lblQLSV_ThongKe1
            // 
            this.lblQLSV_ThongKe1.Name = "lblQLSV_ThongKe1";
            this.lblQLSV_ThongKe1.Text = "Theo:";
            // 
            // cmbQLSV_ThongKe
            // 
            this.cmbQLSV_ThongKe.ComboWidth = 84;
            this.cmbQLSV_ThongKe.DropDownHeight = 106;
            this.cmbQLSV_ThongKe.Items.AddRange(new object[] {
            this.comboItem3,
            this.comboItem4,
            this.comboItem5});
            this.cmbQLSV_ThongKe.Name = "cmbQLSV_ThongKe";
            this.cmbQLSV_ThongKe.Text = "comboBoxItem7";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Phòng";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Dãy";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "KTX";
            // 
            // btnQLSV_ThongKe
            // 
            this.btnQLSV_ThongKe.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLSV_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_ThongKe.Image")));
            this.btnQLSV_ThongKe.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnQLSV_ThongKe.ImagePaddingHorizontal = 8;
            this.btnQLSV_ThongKe.Name = "btnQLSV_ThongKe";
            this.btnQLSV_ThongKe.Text = "Thống kê";
            this.btnQLSV_ThongKe.Click += new System.EventHandler(this.btnQLSV_ThongKe_Click);
            // 
            // barQLSV_DanhGia
            // 
            this.barQLSV_DanhGia.AutoOverflowEnabled = true;
            this.barQLSV_DanhGia.DialogLauncherVisible = true;
            this.barQLSV_DanhGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQLSV_DanhGia.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barQLSV_DanhGia.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cntQLSV_DanhGia1,
            this.cntQLSV_DanhGia2});
            this.barQLSV_DanhGia.Location = new System.Drawing.Point(388, 1);
            this.barQLSV_DanhGia.Name = "barQLSV_DanhGia";
            this.barQLSV_DanhGia.Size = new System.Drawing.Size(190, 86);
            this.barQLSV_DanhGia.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQLSV_DanhGia.TabIndex = 8;
            this.barQLSV_DanhGia.Text = "Đánh Giá";
            this.barQLSV_DanhGia.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // cntQLSV_DanhGia1
            // 
            this.cntQLSV_DanhGia1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.cntQLSV_DanhGia1.MinimumSize = new System.Drawing.Size(0, 0);
            this.cntQLSV_DanhGia1.Name = "cntQLSV_DanhGia1";
            this.cntQLSV_DanhGia1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQLSV_KyLuat,
            this.btnQLSV_KhenThuong});
            // 
            // btnQLSV_KyLuat
            // 
            this.btnQLSV_KyLuat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLSV_KyLuat.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_KyLuat.Image")));
            this.btnQLSV_KyLuat.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnQLSV_KyLuat.ImagePaddingHorizontal = 8;
            this.btnQLSV_KyLuat.Name = "btnQLSV_KyLuat";
            this.btnQLSV_KyLuat.SubItemsExpandWidth = 14;
            this.btnQLSV_KyLuat.Text = "Kỹ luật";
            this.btnQLSV_KyLuat.Click += new System.EventHandler(this.btnQLSV_KyLuat_Click);
            // 
            // btnQLSV_KhenThuong
            // 
            this.btnQLSV_KhenThuong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLSV_KhenThuong.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_KhenThuong.Image")));
            this.btnQLSV_KhenThuong.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnQLSV_KhenThuong.ImagePaddingHorizontal = 8;
            this.btnQLSV_KhenThuong.Name = "btnQLSV_KhenThuong";
            this.btnQLSV_KhenThuong.SubItemsExpandWidth = 14;
            this.btnQLSV_KhenThuong.Text = "Khen Thưởng";
            this.btnQLSV_KhenThuong.Click += new System.EventHandler(this.btnQLSV_KhenThuong_Click);
            // 
            // cntQLSV_DanhGia2
            // 
            this.cntQLSV_DanhGia2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.cntQLSV_DanhGia2.MinimumSize = new System.Drawing.Size(0, 0);
            this.cntQLSV_DanhGia2.Name = "cntQLSV_DanhGia2";
            this.cntQLSV_DanhGia2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQLSV_DanhGia,
            this.btnQLSV_HoatDong});
            // 
            // btnQLSV_DanhGia
            // 
            this.btnQLSV_DanhGia.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLSV_DanhGia.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_DanhGia.Image")));
            this.btnQLSV_DanhGia.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnQLSV_DanhGia.ImagePaddingHorizontal = 8;
            this.btnQLSV_DanhGia.Name = "btnQLSV_DanhGia";
            this.btnQLSV_DanhGia.SubItemsExpandWidth = 14;
            this.btnQLSV_DanhGia.Text = "Đánh giá";
            this.btnQLSV_DanhGia.Click += new System.EventHandler(this.btnQLSV_DanhGia_Click);
            // 
            // btnQLSV_HoatDong
            // 
            this.btnQLSV_HoatDong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLSV_HoatDong.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_HoatDong.Image")));
            this.btnQLSV_HoatDong.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnQLSV_HoatDong.ImagePaddingHorizontal = 8;
            this.btnQLSV_HoatDong.Name = "btnQLSV_HoatDong";
            this.btnQLSV_HoatDong.Text = "Hoạt động";
            this.btnQLSV_HoatDong.Click += new System.EventHandler(this.btnQLSV_HoatDong_Click);
            // 
            // barQLSV_QuanLy
            // 
            this.barQLSV_QuanLy.AutoOverflowEnabled = true;
            this.barQLSV_QuanLy.DialogLauncherVisible = true;
            this.barQLSV_QuanLy.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQLSV_QuanLy.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barQLSV_QuanLy.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2});
            this.barQLSV_QuanLy.Location = new System.Drawing.Point(282, 1);
            this.barQLSV_QuanLy.Name = "barQLSV_QuanLy";
            this.barQLSV_QuanLy.Size = new System.Drawing.Size(106, 86);
            this.barQLSV_QuanLy.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQLSV_QuanLy.TabIndex = 6;
            this.barQLSV_QuanLy.Text = "Quản Lý";
            this.barQLSV_QuanLy.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // itemContainer2
            // 
            this.itemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer2.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQLSV_QuanLy_DiemDanh,
            this.btnQLSV_QuanLy_ChuyenPhong,
            this.btnQLSV_QuanLy_XepPhong});
            // 
            // btnQLSV_QuanLy_DiemDanh
            // 
            this.btnQLSV_QuanLy_DiemDanh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLSV_QuanLy_DiemDanh.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_QuanLy_DiemDanh.Image")));
            this.btnQLSV_QuanLy_DiemDanh.ImagePaddingHorizontal = 8;
            this.btnQLSV_QuanLy_DiemDanh.Name = "btnQLSV_QuanLy_DiemDanh";
            this.btnQLSV_QuanLy_DiemDanh.Text = "Điểm Danh";
            this.btnQLSV_QuanLy_DiemDanh.Click += new System.EventHandler(this.btnQLSV_QuanLy_DiemDanh_Click_1);
            // 
            // btnQLSV_QuanLy_ChuyenPhong
            // 
            this.btnQLSV_QuanLy_ChuyenPhong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLSV_QuanLy_ChuyenPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_QuanLy_ChuyenPhong.Image")));
            this.btnQLSV_QuanLy_ChuyenPhong.ImagePaddingHorizontal = 8;
            this.btnQLSV_QuanLy_ChuyenPhong.Name = "btnQLSV_QuanLy_ChuyenPhong";
            this.btnQLSV_QuanLy_ChuyenPhong.SubItemsExpandWidth = 14;
            this.btnQLSV_QuanLy_ChuyenPhong.Text = "Chuyển Phòng";
            this.btnQLSV_QuanLy_ChuyenPhong.Click += new System.EventHandler(this.btnQLSV_QuanLy_ChuyenPhong_Click);
            // 
            // btnQLSV_QuanLy_XepPhong
            // 
            this.btnQLSV_QuanLy_XepPhong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLSV_QuanLy_XepPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_QuanLy_XepPhong.Image")));
            this.btnQLSV_QuanLy_XepPhong.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnQLSV_QuanLy_XepPhong.ImagePaddingHorizontal = 8;
            this.btnQLSV_QuanLy_XepPhong.Name = "btnQLSV_QuanLy_XepPhong";
            this.btnQLSV_QuanLy_XepPhong.SubItemsExpandWidth = 14;
            this.btnQLSV_QuanLy_XepPhong.Text = "Xếp phòng";
            this.btnQLSV_QuanLy_XepPhong.Click += new System.EventHandler(this.btnQLSV_QuanLy_XepPhong_Click);
            // 
            // barQLSV_TraCuu
            // 
            this.barQLSV_TraCuu.AutoOverflowEnabled = true;
            this.barQLSV_TraCuu.DialogLauncherVisible = true;
            this.barQLSV_TraCuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQLSV_TraCuu.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barQLSV_TraCuu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cntQLSV_TraCuu});
            this.barQLSV_TraCuu.Location = new System.Drawing.Point(169, 1);
            this.barQLSV_TraCuu.Name = "barQLSV_TraCuu";
            this.barQLSV_TraCuu.Size = new System.Drawing.Size(113, 86);
            this.barQLSV_TraCuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQLSV_TraCuu.TabIndex = 4;
            this.barQLSV_TraCuu.Text = "Tra Cứu";
            this.barQLSV_TraCuu.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // cntQLSV_TraCuu
            // 
            this.cntQLSV_TraCuu.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.cntQLSV_TraCuu.MinimumSize = new System.Drawing.Size(0, 0);
            this.cntQLSV_TraCuu.Name = "cntQLSV_TraCuu";
            this.cntQLSV_TraCuu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQLSV_TraCuu_Phong1,
            this.btnQLSV_TraCuu_Day1,
            this.btnQLSV_TraCuu_Chung});
            // 
            // btnQLSV_TraCuu_Phong1
            // 
            this.btnQLSV_TraCuu_Phong1.AutoExpandOnClick = true;
            this.btnQLSV_TraCuu_Phong1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLSV_TraCuu_Phong1.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_TraCuu_Phong1.Image")));
            this.btnQLSV_TraCuu_Phong1.ImagePaddingHorizontal = 8;
            this.btnQLSV_TraCuu_Phong1.Name = "btnQLSV_TraCuu_Phong1";
            this.btnQLSV_TraCuu_Phong1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cmbQLSV_TraCuu_Phong,
            this.btnQLSV_TraCuu_Phong});
            this.btnQLSV_TraCuu_Phong1.SubItemsExpandWidth = 14;
            this.btnQLSV_TraCuu_Phong1.Text = "Theo Phòng";
            // 
            // cmbQLSV_TraCuu_Phong
            // 
            this.cmbQLSV_TraCuu_Phong.AutoCollapseOnClick = false;
            this.cmbQLSV_TraCuu_Phong.DropDownHeight = 106;
            this.cmbQLSV_TraCuu_Phong.Name = "cmbQLSV_TraCuu_Phong";
            this.cmbQLSV_TraCuu_Phong.Text = "Nhập tên phòng";
            // 
            // btnQLSV_TraCuu_Phong
            // 
            this.btnQLSV_TraCuu_Phong.ImagePaddingHorizontal = 8;
            this.btnQLSV_TraCuu_Phong.Name = "btnQLSV_TraCuu_Phong";
            this.btnQLSV_TraCuu_Phong.Text = "Tìm";
            this.btnQLSV_TraCuu_Phong.Click += new System.EventHandler(this.btnQLSV_TraCuu_Phong_Click);
            // 
            // btnQLSV_TraCuu_Day1
            // 
            this.btnQLSV_TraCuu_Day1.AutoExpandOnClick = true;
            this.btnQLSV_TraCuu_Day1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLSV_TraCuu_Day1.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_TraCuu_Day1.Image")));
            this.btnQLSV_TraCuu_Day1.ImagePaddingHorizontal = 8;
            this.btnQLSV_TraCuu_Day1.Name = "btnQLSV_TraCuu_Day1";
            this.btnQLSV_TraCuu_Day1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cmbQLSV_TraCuu_Day,
            this.btnQLSV_TraCuu_Day});
            this.btnQLSV_TraCuu_Day1.SubItemsExpandWidth = 14;
            this.btnQLSV_TraCuu_Day1.Text = "Theo Dãy";
            // 
            // cmbQLSV_TraCuu_Day
            // 
            this.cmbQLSV_TraCuu_Day.AutoCollapseOnClick = false;
            this.cmbQLSV_TraCuu_Day.DropDownHeight = 106;
            this.cmbQLSV_TraCuu_Day.Name = "cmbQLSV_TraCuu_Day";
            this.cmbQLSV_TraCuu_Day.Text = "Nhập dãy:";
            this.cmbQLSV_TraCuu_Day.Click += new System.EventHandler(this.cmdQLSV_TraCuu_Day_Click);
            // 
            // btnQLSV_TraCuu_Day
            // 
            this.btnQLSV_TraCuu_Day.ImagePaddingHorizontal = 8;
            this.btnQLSV_TraCuu_Day.Name = "btnQLSV_TraCuu_Day";
            this.btnQLSV_TraCuu_Day.Text = "Tìm";
            this.btnQLSV_TraCuu_Day.Click += new System.EventHandler(this.btnQLSV_TraCuu_Day_Click);
            // 
            // btnQLSV_TraCuu_Chung
            // 
            this.btnQLSV_TraCuu_Chung.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQLSV_TraCuu_Chung.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_TraCuu_Chung.Image")));
            this.btnQLSV_TraCuu_Chung.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnQLSV_TraCuu_Chung.ImagePaddingHorizontal = 8;
            this.btnQLSV_TraCuu_Chung.Name = "btnQLSV_TraCuu_Chung";
            this.btnQLSV_TraCuu_Chung.Text = "Tra cứu chung";
            this.btnQLSV_TraCuu_Chung.Click += new System.EventHandler(this.btnQLSV_TraCuu_Chung_Click);
            // 
            // barQLSV_SinhVien
            // 
            this.barQLSV_SinhVien.AutoOverflowEnabled = true;
            this.barQLSV_SinhVien.DialogLauncherVisible = true;
            this.barQLSV_SinhVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQLSV_SinhVien.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barQLSV_SinhVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQLSV_ThemSinhVien,
            this.btnQLSV_SuaSinhVien});
            this.barQLSV_SinhVien.Location = new System.Drawing.Point(1, 1);
            this.barQLSV_SinhVien.Name = "barQLSV_SinhVien";
            this.barQLSV_SinhVien.Size = new System.Drawing.Size(168, 86);
            this.barQLSV_SinhVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQLSV_SinhVien.TabIndex = 0;
            this.barQLSV_SinhVien.Text = "Sinh Viên";
            this.barQLSV_SinhVien.ItemClick += new System.EventHandler(this.ribbonBar1_ItemClick);
            // 
            // btnQLSV_ThemSinhVien
            // 
            this.btnQLSV_ThemSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_ThemSinhVien.Image")));
            this.btnQLSV_ThemSinhVien.ImagePaddingHorizontal = 8;
            this.btnQLSV_ThemSinhVien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQLSV_ThemSinhVien.Name = "btnQLSV_ThemSinhVien";
            this.btnQLSV_ThemSinhVien.SubItemsExpandWidth = 14;
            this.btnQLSV_ThemSinhVien.Text = "Thêm Sinh Viên";
            this.btnQLSV_ThemSinhVien.Tooltip = "Lập phiếu đăng ký KTX";
            this.btnQLSV_ThemSinhVien.Click += new System.EventHandler(this.btnQLSV_ThemSinhVien_Click);
            // 
            // btnQLSV_SuaSinhVien
            // 
            this.btnQLSV_SuaSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV_SuaSinhVien.Image")));
            this.btnQLSV_SuaSinhVien.ImagePaddingHorizontal = 8;
            this.btnQLSV_SuaSinhVien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQLSV_SuaSinhVien.Name = "btnQLSV_SuaSinhVien";
            this.btnQLSV_SuaSinhVien.SubItemsExpandWidth = 14;
            this.btnQLSV_SuaSinhVien.Text = "Sửa thông tin Sinh viên";
            this.btnQLSV_SuaSinhVien.Tooltip = "Sửa thông tin Sinh viên";
            this.btnQLSV_SuaSinhVien.Click += new System.EventHandler(this.btnQLSV_SuaSinhVien_Click);
            // 
            // tabQLSV
            // 
            this.tabQLSV.AttachedControl = this.tabpQLSV;
            this.tabQLSV.Image = ((System.Drawing.Image)(resources.GetObject("tabQLSV.Image")));
            this.tabQLSV.Name = "tabQLSV";
            this.tabQLSV.Text = "Quản Lý &Sinh Viên";
            this.tabQLSV.Tooltip = "Quản lý Sinh viên";
            this.tabQLSV.Click += new System.EventHandler(this.tabMainTool_Click);
            // 
            // tabpHeThong
            // 
            this.tabpHeThong.Controls.Add(this.barHeThong_HienThi);
            this.tabpHeThong.Controls.Add(this.barHeThong_NguoiDung);
            this.tabpHeThong.Controls.Add(this.barHeThong_QLDanhMuc);
            this.tabpHeThong.Controls.Add(this.barHeThong_QLDuLieu);
            this.tabpHeThong.Controls.Add(barHeThong_HeThong);
            this.tabpHeThong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpHeThong.Location = new System.Drawing.Point(0, 30);
            this.tabpHeThong.Name = "tabpHeThong";
            this.tabpHeThong.Padding = new System.Windows.Forms.Padding(1);
            this.tabpHeThong.Size = new System.Drawing.Size(804, 88);
            this.tabpHeThong.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabpHeThong.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabpHeThong.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabpHeThong.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabpHeThong.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabpHeThong.Style.GradientAngle = 90;
            this.tabpHeThong.TabIndex = 1;
            this.tabpHeThong.TabItem = this.tabHeThong;
            // 
            // barHeThong_HienThi
            // 
            this.barHeThong_HienThi.AutoOverflowEnabled = true;
            this.barHeThong_HienThi.DialogLauncherVisible = true;
            this.barHeThong_HienThi.Dock = System.Windows.Forms.DockStyle.Left;
            this.barHeThong_HienThi.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barHeThong_HienThi.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHeThong_HienThi});
            this.barHeThong_HienThi.Location = new System.Drawing.Point(663, 1);
            this.barHeThong_HienThi.Name = "barHeThong_HienThi";
            this.barHeThong_HienThi.Size = new System.Drawing.Size(106, 86);
            this.barHeThong_HienThi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barHeThong_HienThi.TabIndex = 5;
            this.barHeThong_HienThi.Text = "Trình bày Form";
            this.barHeThong_HienThi.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // btnHeThong_HienThi
            // 
            this.btnHeThong_HienThi.AutoExpandOnClick = true;
            this.btnHeThong_HienThi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHeThong_HienThi.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong_HienThi.Image")));
            this.btnHeThong_HienThi.ImagePaddingHorizontal = 8;
            this.btnHeThong_HienThi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHeThong_HienThi.Name = "btnHeThong_HienThi";
            this.btnHeThong_HienThi.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHeThong_Ngang,
            this.btnHeThong_Doc});
            this.btnHeThong_HienThi.SubItemsExpandWidth = 14;
            this.btnHeThong_HienThi.Text = "Hiển thị";
            // 
            // btnHeThong_Ngang
            // 
            this.btnHeThong_Ngang.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong_Ngang.Image")));
            this.btnHeThong_Ngang.ImagePaddingHorizontal = 8;
            this.btnHeThong_Ngang.Name = "btnHeThong_Ngang";
            this.btnHeThong_Ngang.Text = "Ngang";
            this.btnHeThong_Ngang.Click += new System.EventHandler(this.btnHeThong_Ngang_Click);
            // 
            // btnHeThong_Doc
            // 
            this.btnHeThong_Doc.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong_Doc.Image")));
            this.btnHeThong_Doc.ImagePaddingHorizontal = 8;
            this.btnHeThong_Doc.Name = "btnHeThong_Doc";
            this.btnHeThong_Doc.Text = "Dọc";
            this.btnHeThong_Doc.Click += new System.EventHandler(this.btnHeThong_Doc_Click);
            // 
            // barHeThong_NguoiDung
            // 
            this.barHeThong_NguoiDung.AutoOverflowEnabled = true;
            this.barHeThong_NguoiDung.DialogLauncherVisible = true;
            this.barHeThong_NguoiDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.barHeThong_NguoiDung.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barHeThong_NguoiDung.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblHeThong_NguoiDung,
            this.cntHeThong_NguoiDung});
            this.barHeThong_NguoiDung.Location = new System.Drawing.Point(508, 1);
            this.barHeThong_NguoiDung.Name = "barHeThong_NguoiDung";
            this.barHeThong_NguoiDung.Size = new System.Drawing.Size(155, 86);
            this.barHeThong_NguoiDung.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barHeThong_NguoiDung.TabIndex = 4;
            this.barHeThong_NguoiDung.Text = "Người dùng";
            this.barHeThong_NguoiDung.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            this.barHeThong_NguoiDung.ItemClick += new System.EventHandler(this.barHeThong_NguoiDung_ItemClick);
            // 
            // lblHeThong_NguoiDung
            // 
            this.lblHeThong_NguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("lblHeThong_NguoiDung.Image")));
            this.lblHeThong_NguoiDung.Name = "lblHeThong_NguoiDung";
            // 
            // cntHeThong_NguoiDung
            // 
            this.cntHeThong_NguoiDung.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.cntHeThong_NguoiDung.MinimumSize = new System.Drawing.Size(0, 0);
            this.cntHeThong_NguoiDung.Name = "cntHeThong_NguoiDung";
            this.cntHeThong_NguoiDung.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHeThong_NguoiDung,
            this.btnHeThong_CBQL});
            // 
            // btnHeThong_NguoiDung
            // 
            this.btnHeThong_NguoiDung.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHeThong_NguoiDung.Image = global::QLKTX.Properties.Resources.QuanLy32;
            this.btnHeThong_NguoiDung.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnHeThong_NguoiDung.ImagePaddingHorizontal = 8;
            this.btnHeThong_NguoiDung.Name = "btnHeThong_NguoiDung";
            this.btnHeThong_NguoiDung.SubItemsExpandWidth = 14;
            this.btnHeThong_NguoiDung.Text = "Người dùng";
            this.btnHeThong_NguoiDung.Click += new System.EventHandler(this.btnHeThong_NguoiDung_Click);
            // 
            // btnHeThong_CBQL
            // 
            this.btnHeThong_CBQL.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHeThong_CBQL.Image = global::QLKTX.Properties.Resources.NguoiDung;
            this.btnHeThong_CBQL.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnHeThong_CBQL.ImagePaddingHorizontal = 8;
            this.btnHeThong_CBQL.Name = "btnHeThong_CBQL";
            this.btnHeThong_CBQL.SubItemsExpandWidth = 14;
            this.btnHeThong_CBQL.Text = "Cán bộ  Quản lý";
            this.btnHeThong_CBQL.Click += new System.EventHandler(this.btnHeThong_CBQL_Click);
            // 
            // barHeThong_QLDanhMuc
            // 
            this.barHeThong_QLDanhMuc.AutoOverflowEnabled = true;
            this.barHeThong_QLDanhMuc.DialogLauncherVisible = true;
            this.barHeThong_QLDanhMuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.barHeThong_QLDanhMuc.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barHeThong_QLDanhMuc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cntHeThong_QLDanhMuc1,
            this.cntHeThong_QLDanhMuc2});
            this.barHeThong_QLDanhMuc.Location = new System.Drawing.Point(294, 1);
            this.barHeThong_QLDanhMuc.Name = "barHeThong_QLDanhMuc";
            this.barHeThong_QLDanhMuc.Size = new System.Drawing.Size(214, 86);
            this.barHeThong_QLDanhMuc.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barHeThong_QLDanhMuc.TabIndex = 2;
            this.barHeThong_QLDanhMuc.Text = "Quản lý Danh mục";
            this.barHeThong_QLDanhMuc.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // cntHeThong_QLDanhMuc1
            // 
            this.cntHeThong_QLDanhMuc1.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.cntHeThong_QLDanhMuc1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.cntHeThong_QLDanhMuc1.MinimumSize = new System.Drawing.Size(0, 0);
            this.cntHeThong_QLDanhMuc1.Name = "cntHeThong_QLDanhMuc1";
            this.cntHeThong_QLDanhMuc1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHeThong_QuocTich,
            this.btnHeThong_NgayThangNam});
            this.cntHeThong_QLDanhMuc1.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // btnHeThong_NgayThangNam
            // 
            this.btnHeThong_NgayThangNam.AutoExpandOnClick = true;
            this.btnHeThong_NgayThangNam.ImagePaddingHorizontal = 8;
            this.btnHeThong_NgayThangNam.Name = "btnHeThong_NgayThangNam";
            this.btnHeThong_NgayThangNam.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHeThong_NamHoc,
            this.btnHeThong_HocKy});
            this.btnHeThong_NgayThangNam.Text = "Năm học";
            // 
            // btnHeThong_NamHoc
            // 
            this.btnHeThong_NamHoc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHeThong_NamHoc.ImagePaddingHorizontal = 8;
            this.btnHeThong_NamHoc.Name = "btnHeThong_NamHoc";
            this.btnHeThong_NamHoc.Text = "Quản Lý Năm học";
            this.btnHeThong_NamHoc.Click += new System.EventHandler(this.btnHeThong_NamHoc_Click);
            // 
            // btnHeThong_HocKy
            // 
            this.btnHeThong_HocKy.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHeThong_HocKy.ImagePaddingHorizontal = 8;
            this.btnHeThong_HocKy.Name = "btnHeThong_HocKy";
            this.btnHeThong_HocKy.Text = "Quản Lý Học kỳ";
            this.btnHeThong_HocKy.Click += new System.EventHandler(this.btnHeThong_HocKy_Click);
            // 
            // btnHeThong_QuocTich
            // 
            this.btnHeThong_QuocTich.AutoExpandOnClick = true;
            this.btnHeThong_QuocTich.ImagePaddingHorizontal = 8;
            this.btnHeThong_QuocTich.Name = "btnHeThong_QuocTich";
            this.btnHeThong_QuocTich.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_HeThong_TonGiao,
            this.btn_HeThong_DanToc,
            this.btn_HeThong_QuocTich});
            this.btnHeThong_QuocTich.Text = "Quốc Tịch";
            // 
            // btn_HeThong_TonGiao
            // 
            this.btn_HeThong_TonGiao.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_HeThong_TonGiao.ImagePaddingHorizontal = 8;
            this.btn_HeThong_TonGiao.Name = "btn_HeThong_TonGiao";
            this.btn_HeThong_TonGiao.Text = "Quản Lý Tôn giáo";
            this.btn_HeThong_TonGiao.Click += new System.EventHandler(this.btn_HeThong_TonGiao_Click);
            // 
            // btn_HeThong_DanToc
            // 
            this.btn_HeThong_DanToc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_HeThong_DanToc.ImagePaddingHorizontal = 8;
            this.btn_HeThong_DanToc.Name = "btn_HeThong_DanToc";
            this.btn_HeThong_DanToc.Text = "Quản Lý Dân tộc";
            this.btn_HeThong_DanToc.Click += new System.EventHandler(this.btn_HeThong_DanToc_Click);
            // 
            // btn_HeThong_QuocTich
            // 
            this.btn_HeThong_QuocTich.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_HeThong_QuocTich.ImagePaddingHorizontal = 8;
            this.btn_HeThong_QuocTich.Name = "btn_HeThong_QuocTich";
            this.btn_HeThong_QuocTich.Text = "Quản Lý Quốc tịch";
            this.btn_HeThong_QuocTich.Click += new System.EventHandler(this.btn_HeThong_QuocTich_Click);
            // 
            // cntHeThong_QLDanhMuc2
            // 
            this.cntHeThong_QLDanhMuc2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.cntHeThong_QLDanhMuc2.MinimumSize = new System.Drawing.Size(0, 0);
            this.cntHeThong_QLDanhMuc2.Name = "cntHeThong_QLDanhMuc2";
            this.cntHeThong_QLDanhMuc2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHeThong_KhenThuongKyLuat,
            this.btnHeThong_DanhGiaXepLoai,
            this.btnHeThong_HoatDong});
            // 
            // btnHeThong_KhenThuongKyLuat
            // 
            this.btnHeThong_KhenThuongKyLuat.AutoExpandOnClick = true;
            this.btnHeThong_KhenThuongKyLuat.ImagePaddingHorizontal = 8;
            this.btnHeThong_KhenThuongKyLuat.Name = "btnHeThong_KhenThuongKyLuat";
            this.btnHeThong_KhenThuongKyLuat.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHeThong_KyLuat,
            this.btnHeThong_KhenThuong,
            this.btnHeThong_DanhGia});
            this.btnHeThong_KhenThuongKyLuat.Text = "Khen thường Kỹ luật";
            // 
            // btnHeThong_KyLuat
            // 
            this.btnHeThong_KyLuat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHeThong_KyLuat.ImagePaddingHorizontal = 8;
            this.btnHeThong_KyLuat.Name = "btnHeThong_KyLuat";
            this.btnHeThong_KyLuat.Text = "Quản Lý Kỷ Luật";
            this.btnHeThong_KyLuat.Click += new System.EventHandler(this.btnHeThong_KyLuat_Click);
            // 
            // btnHeThong_KhenThuong
            // 
            this.btnHeThong_KhenThuong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHeThong_KhenThuong.ImagePaddingHorizontal = 8;
            this.btnHeThong_KhenThuong.Name = "btnHeThong_KhenThuong";
            this.btnHeThong_KhenThuong.Text = "Quản Lý Khen Thưởng";
            this.btnHeThong_KhenThuong.Click += new System.EventHandler(this.btnHeThong_KhenThuong_Click);
            // 
            // btnHeThong_DanhGia
            // 
            this.btnHeThong_DanhGia.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHeThong_DanhGia.ImagePaddingHorizontal = 8;
            this.btnHeThong_DanhGia.Name = "btnHeThong_DanhGia";
            this.btnHeThong_DanhGia.Text = "Quản Lý Mức Đánh giá";
            this.btnHeThong_DanhGia.Click += new System.EventHandler(this.btnHeThong_DanhGia_Click);
            // 
            // btnHeThong_DanhGiaXepLoai
            // 
            this.btnHeThong_DanhGiaXepLoai.AutoExpandOnClick = true;
            this.btnHeThong_DanhGiaXepLoai.ImagePaddingHorizontal = 8;
            this.btnHeThong_DanhGiaXepLoai.Name = "btnHeThong_DanhGiaXepLoai";
            this.btnHeThong_DanhGiaXepLoai.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem28,
            this.buttonItem27});
            this.btnHeThong_DanhGiaXepLoai.Text = "Đánh giá Xếp loại";
            // 
            // buttonItem28
            // 
            this.buttonItem28.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem28.ImagePaddingHorizontal = 8;
            this.buttonItem28.Name = "buttonItem28";
            this.buttonItem28.Text = "Quản Lý Đánh giá";
            this.buttonItem28.Click += new System.EventHandler(this.buttonItem28_Click);
            // 
            // buttonItem27
            // 
            this.buttonItem27.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem27.ImagePaddingHorizontal = 8;
            this.buttonItem27.Name = "buttonItem27";
            this.buttonItem27.Text = "Quản Lý Xếp loại";
            this.buttonItem27.Click += new System.EventHandler(this.buttonItem27_Click);
            // 
            // btnHeThong_HoatDong
            // 
            this.btnHeThong_HoatDong.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHeThong_HoatDong.ImagePaddingHorizontal = 8;
            this.btnHeThong_HoatDong.Name = "btnHeThong_HoatDong";
            this.btnHeThong_HoatDong.Text = "Quản Lý Hoạt động";
            this.btnHeThong_HoatDong.Click += new System.EventHandler(this.btnHeThong_HoatDong_Click);
            // 
            // barHeThong_QLDuLieu
            // 
            this.barHeThong_QLDuLieu.AutoOverflowEnabled = true;
            this.barHeThong_QLDuLieu.DialogLauncherVisible = true;
            this.barHeThong_QLDuLieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.barHeThong_QLDuLieu.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barHeThong_QLDuLieu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHeThong_SaoLuu,
            this.btnHeThong_PhucHoi});
            this.barHeThong_QLDuLieu.Location = new System.Drawing.Point(179, 1);
            this.barHeThong_QLDuLieu.Name = "barHeThong_QLDuLieu";
            this.barHeThong_QLDuLieu.Size = new System.Drawing.Size(115, 86);
            this.barHeThong_QLDuLieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barHeThong_QLDuLieu.TabIndex = 1;
            this.barHeThong_QLDuLieu.Text = "Quản lý Dữ liệu";
            this.barHeThong_QLDuLieu.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // btnHeThong_SaoLuu
            // 
            this.btnHeThong_SaoLuu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHeThong_SaoLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong_SaoLuu.Image")));
            this.btnHeThong_SaoLuu.ImagePaddingHorizontal = 8;
            this.btnHeThong_SaoLuu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHeThong_SaoLuu.Name = "btnHeThong_SaoLuu";
            this.btnHeThong_SaoLuu.RibbonWordWrap = false;
            this.btnHeThong_SaoLuu.SubItemsExpandWidth = 14;
            this.btnHeThong_SaoLuu.Text = "Sao lưu";
            this.btnHeThong_SaoLuu.Click += new System.EventHandler(this.btnHeThong_SaoLuu_Click);
            // 
            // btnHeThong_PhucHoi
            // 
            this.btnHeThong_PhucHoi.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHeThong_PhucHoi.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong_PhucHoi.Image")));
            this.btnHeThong_PhucHoi.ImagePaddingHorizontal = 8;
            this.btnHeThong_PhucHoi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHeThong_PhucHoi.Name = "btnHeThong_PhucHoi";
            this.btnHeThong_PhucHoi.RibbonWordWrap = false;
            this.btnHeThong_PhucHoi.SubItemsExpandWidth = 14;
            this.btnHeThong_PhucHoi.Text = "Phục hồi";
            this.btnHeThong_PhucHoi.Click += new System.EventHandler(this.btnHeThong_PhucHoi_Click);
            // 
            // tabHeThong
            // 
            this.tabHeThong.AttachedControl = this.tabpHeThong;
            this.tabHeThong.Image = ((System.Drawing.Image)(resources.GetObject("tabHeThong.Image")));
            this.tabHeThong.Name = "tabHeThong";
            this.tabHeThong.Text = "&Hệ Thống";
            this.tabHeThong.Tooltip = "Thông tin chung của hệ thống";
            this.tabHeThong.Click += new System.EventHandler(this.tabMainTool_Click);
            // 
            // tabpTraCuu
            // 
            this.tabpTraCuu.Controls.Add(this.barQlTraCuu_KTX);
            this.tabpTraCuu.Controls.Add(this.barQlTraCuu_Day);
            this.tabpTraCuu.Controls.Add(this.barQlTraCuu_Phong);
            this.tabpTraCuu.Controls.Add(this.barQlTraCuu_SinhVien);
            this.tabpTraCuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpTraCuu.Location = new System.Drawing.Point(0, 30);
            this.tabpTraCuu.Name = "tabpTraCuu";
            this.tabpTraCuu.Padding = new System.Windows.Forms.Padding(1);
            this.tabpTraCuu.Size = new System.Drawing.Size(804, 88);
            this.tabpTraCuu.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabpTraCuu.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabpTraCuu.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabpTraCuu.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabpTraCuu.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabpTraCuu.Style.GradientAngle = 90;
            this.tabpTraCuu.TabIndex = 5;
            this.tabpTraCuu.TabItem = this.tabTraCuu;
            // 
            // barQlTraCuu_KTX
            // 
            this.barQlTraCuu_KTX.AutoOverflowEnabled = true;
            this.barQlTraCuu_KTX.DialogLauncherVisible = true;
            this.barQlTraCuu_KTX.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQlTraCuu_KTX.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem8,
            this.itemContainer19});
            this.barQlTraCuu_KTX.Location = new System.Drawing.Point(558, 1);
            this.barQlTraCuu_KTX.Name = "barQlTraCuu_KTX";
            this.barQlTraCuu_KTX.Size = new System.Drawing.Size(184, 86);
            this.barQlTraCuu_KTX.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQlTraCuu_KTX.TabIndex = 8;
            this.barQlTraCuu_KTX.Text = "Ký túc xá";
            this.barQlTraCuu_KTX.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem8
            // 
            this.labelItem8.Image = ((System.Drawing.Image)(resources.GetObject("labelItem8.Image")));
            this.labelItem8.Name = "labelItem8";
            // 
            // itemContainer19
            // 
            this.itemContainer19.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer19.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer19.Name = "itemContainer19";
            this.itemContainer19.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer39,
            this.buttonItem38});
            // 
            // itemContainer39
            // 
            this.itemContainer39.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer39.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer39.Name = "itemContainer39";
            this.itemContainer39.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem24,
            this.comboBoxItem6});
            // 
            // labelItem24
            // 
            this.labelItem24.Name = "labelItem24";
            this.labelItem24.Text = "Theo:";
            // 
            // comboBoxItem6
            // 
            this.comboBoxItem6.ComboWidth = 70;
            this.comboBoxItem6.DropDownHeight = 106;
            this.comboBoxItem6.Name = "comboBoxItem6";
            this.comboBoxItem6.Text = "comboBoxItem6";
            // 
            // buttonItem38
            // 
            this.buttonItem38.ImagePaddingHorizontal = 8;
            this.buttonItem38.Name = "buttonItem38";
            this.buttonItem38.Text = "Tra cứu";
            // 
            // barQlTraCuu_Day
            // 
            this.barQlTraCuu_Day.AutoOverflowEnabled = true;
            this.barQlTraCuu_Day.DialogLauncherVisible = true;
            this.barQlTraCuu_Day.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQlTraCuu_Day.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem7,
            this.itemContainer18});
            this.barQlTraCuu_Day.Location = new System.Drawing.Point(371, 1);
            this.barQlTraCuu_Day.Name = "barQlTraCuu_Day";
            this.barQlTraCuu_Day.Size = new System.Drawing.Size(187, 86);
            this.barQlTraCuu_Day.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQlTraCuu_Day.TabIndex = 6;
            this.barQlTraCuu_Day.Text = "Dãy";
            this.barQlTraCuu_Day.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem7
            // 
            this.labelItem7.Image = ((System.Drawing.Image)(resources.GetObject("labelItem7.Image")));
            this.labelItem7.Name = "labelItem7";
            // 
            // itemContainer18
            // 
            this.itemContainer18.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer18.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer18.Name = "itemContainer18";
            this.itemContainer18.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer37,
            this.buttonItem37});
            // 
            // itemContainer37
            // 
            this.itemContainer37.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer37.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer37.Name = "itemContainer37";
            this.itemContainer37.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem22,
            this.comboBoxItem5});
            // 
            // labelItem22
            // 
            this.labelItem22.Name = "labelItem22";
            this.labelItem22.Text = "Theo:";
            // 
            // comboBoxItem5
            // 
            this.comboBoxItem5.ComboWidth = 70;
            this.comboBoxItem5.DropDownHeight = 106;
            this.comboBoxItem5.Name = "comboBoxItem5";
            this.comboBoxItem5.Text = "comboBoxItem5";
            // 
            // buttonItem37
            // 
            this.buttonItem37.ImagePaddingHorizontal = 8;
            this.buttonItem37.Name = "buttonItem37";
            this.buttonItem37.Text = "Tra cứu";
            // 
            // barQlTraCuu_Phong
            // 
            this.barQlTraCuu_Phong.AutoOverflowEnabled = true;
            this.barQlTraCuu_Phong.DialogLauncherVisible = true;
            this.barQlTraCuu_Phong.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQlTraCuu_Phong.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem6,
            this.buttonItem36,
            this.itemContainer17});
            this.barQlTraCuu_Phong.Location = new System.Drawing.Point(189, 1);
            this.barQlTraCuu_Phong.Name = "barQlTraCuu_Phong";
            this.barQlTraCuu_Phong.Size = new System.Drawing.Size(182, 86);
            this.barQlTraCuu_Phong.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQlTraCuu_Phong.TabIndex = 4;
            this.barQlTraCuu_Phong.Text = "Phòng";
            this.barQlTraCuu_Phong.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // labelItem6
            // 
            this.labelItem6.Image = ((System.Drawing.Image)(resources.GetObject("labelItem6.Image")));
            this.labelItem6.Name = "labelItem6";
            // 
            // buttonItem36
            // 
            this.buttonItem36.ImagePaddingHorizontal = 8;
            this.buttonItem36.Name = "buttonItem36";
            this.buttonItem36.Text = "Tra cứu";
            // 
            // itemContainer17
            // 
            this.itemContainer17.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer17.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer17.Name = "itemContainer17";
            this.itemContainer17.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer35});
            // 
            // itemContainer35
            // 
            this.itemContainer35.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer35.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer35.Name = "itemContainer35";
            this.itemContainer35.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem19,
            this.comboBoxItem4});
            // 
            // labelItem19
            // 
            this.labelItem19.Name = "labelItem19";
            this.labelItem19.Text = "Theo:";
            // 
            // comboBoxItem4
            // 
            this.comboBoxItem4.ComboWidth = 70;
            this.comboBoxItem4.DropDownHeight = 106;
            this.comboBoxItem4.Name = "comboBoxItem4";
            this.comboBoxItem4.Text = "comboBoxItem4";
            // 
            // barQlTraCuu_SinhVien
            // 
            this.barQlTraCuu_SinhVien.AutoOverflowEnabled = true;
            this.barQlTraCuu_SinhVien.DialogLauncherVisible = true;
            this.barQlTraCuu_SinhVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQlTraCuu_SinhVien.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barQlTraCuu_SinhVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.itemContainer16});
            this.barQlTraCuu_SinhVien.Location = new System.Drawing.Point(1, 1);
            this.barQlTraCuu_SinhVien.Name = "barQlTraCuu_SinhVien";
            this.barQlTraCuu_SinhVien.Size = new System.Drawing.Size(188, 86);
            this.barQlTraCuu_SinhVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQlTraCuu_SinhVien.TabIndex = 0;
            this.barQlTraCuu_SinhVien.Text = "Sinh viên";
            // 
            // labelItem1
            // 
            this.labelItem1.Image = ((System.Drawing.Image)(resources.GetObject("labelItem1.Image")));
            this.labelItem1.Name = "labelItem1";
            // 
            // itemContainer16
            // 
            this.itemContainer16.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer16.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer16.Name = "itemContainer16";
            this.itemContainer16.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer33,
            this.itemContainer34,
            this.buttonItem35});
            // 
            // itemContainer33
            // 
            this.itemContainer33.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer33.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer33.Name = "itemContainer33";
            this.itemContainer33.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem18,
            this.comboBoxItem3});
            // 
            // labelItem18
            // 
            this.labelItem18.Name = "labelItem18";
            this.labelItem18.Text = "Theo:";
            // 
            // comboBoxItem3
            // 
            this.comboBoxItem3.ComboWidth = 70;
            this.comboBoxItem3.DropDownHeight = 106;
            this.comboBoxItem3.Name = "comboBoxItem3";
            this.comboBoxItem3.Text = "comboBoxItem3";
            // 
            // itemContainer34
            // 
            this.itemContainer34.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer34.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer34.Name = "itemContainer34";
            this.itemContainer34.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer40});
            // 
            // itemContainer40
            // 
            this.itemContainer40.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer40.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer40.Name = "itemContainer40";
            this.itemContainer40.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem23,
            this.textBoxItem4});
            // 
            // labelItem23
            // 
            this.labelItem23.Name = "labelItem23";
            this.labelItem23.Text = "Nội dung:";
            // 
            // textBoxItem4
            // 
            this.textBoxItem4.Name = "textBoxItem4";
            this.textBoxItem4.Text = "textBoxItem4";
            this.textBoxItem4.TextBoxWidth = 70;
            // 
            // buttonItem35
            // 
            this.buttonItem35.ImagePaddingHorizontal = 8;
            this.buttonItem35.Name = "buttonItem35";
            this.buttonItem35.Text = "Tra cứu";
            // 
            // tabTraCuu
            // 
            this.tabTraCuu.AttachedControl = this.tabpTraCuu;
            this.tabTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("tabTraCuu.Image")));
            this.tabTraCuu.Name = "tabTraCuu";
            this.tabTraCuu.Text = "&Tra Cứu";
            this.tabTraCuu.Tooltip = "Tra cứu thông tin";
            this.tabTraCuu.Click += new System.EventHandler(this.tabMainTool_Click);
            // 
            // tabpTroGiup
            // 
            this.tabpTroGiup.Controls.Add(this.barQlTroGiup_TroGiup);
            this.tabpTroGiup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpTroGiup.Location = new System.Drawing.Point(0, 30);
            this.tabpTroGiup.Name = "tabpTroGiup";
            this.tabpTroGiup.Padding = new System.Windows.Forms.Padding(1);
            this.tabpTroGiup.Size = new System.Drawing.Size(804, 88);
            this.tabpTroGiup.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabpTroGiup.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabpTroGiup.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabpTroGiup.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabpTroGiup.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabpTroGiup.Style.GradientAngle = 90;
            this.tabpTroGiup.TabIndex = 6;
            this.tabpTroGiup.TabItem = this.tabTroGiup;
            // 
            // barQlTroGiup_TroGiup
            // 
            this.barQlTroGiup_TroGiup.AutoOverflowEnabled = true;
            this.barQlTroGiup_TroGiup.DialogLauncherVisible = true;
            this.barQlTroGiup_TroGiup.Dock = System.Windows.Forms.DockStyle.Left;
            this.barQlTroGiup_TroGiup.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.barQlTroGiup_TroGiup.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem61,
            this.btnGioiThieu});
            this.barQlTroGiup_TroGiup.Location = new System.Drawing.Point(1, 1);
            this.barQlTroGiup_TroGiup.Name = "barQlTroGiup_TroGiup";
            this.barQlTroGiup_TroGiup.Size = new System.Drawing.Size(151, 86);
            this.barQlTroGiup_TroGiup.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.barQlTroGiup_TroGiup.TabIndex = 0;
            this.barQlTroGiup_TroGiup.Text = "Trợ Giúp";
            this.barQlTroGiup_TroGiup.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // buttonItem61
            // 
            this.buttonItem61.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem61.Image")));
            this.buttonItem61.ImagePaddingHorizontal = 8;
            this.buttonItem61.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem61.Name = "buttonItem61";
            this.buttonItem61.RibbonWordWrap = false;
            this.buttonItem61.SubItemsExpandWidth = 14;
            this.buttonItem61.Text = "Trợ giúp";
            this.buttonItem61.Click += new System.EventHandler(this.buttonItem61_Click);
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.Image = ((System.Drawing.Image)(resources.GetObject("btnGioiThieu.Image")));
            this.btnGioiThieu.ImagePaddingHorizontal = 8;
            this.btnGioiThieu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.RibbonWordWrap = false;
            this.btnGioiThieu.SubItemsExpandWidth = 14;
            this.btnGioiThieu.Text = "Giới thiệu";
            this.btnGioiThieu.Click += new System.EventHandler(this.btnGioiThieu_Click);
            // 
            // tabTroGiup
            // 
            this.tabTroGiup.AttachedControl = this.tabpTroGiup;
            this.tabTroGiup.Image = ((System.Drawing.Image)(resources.GetObject("tabTroGiup.Image")));
            this.tabTroGiup.Name = "tabTroGiup";
            this.tabTroGiup.Text = "Trợ Giúp";
            this.tabTroGiup.Click += new System.EventHandler(this.tabMainTool_Click);
            // 
            // tabExplorer
            // 
            this.tabExplorer.AutoScroll = true;
            this.tabExplorer.CanvasColor = System.Drawing.SystemColors.Control;
            this.tabExplorer.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.tabExplorer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tabExplorer.Controls.Add(this.expandablePanel6);
            this.tabExplorer.Controls.Add(this.expandablePanel5);
            this.tabExplorer.Controls.Add(this.expandablePanel4);
            this.tabExplorer.Controls.Add(this.expandablePanel3);
            this.tabExplorer.Controls.Add(this.expandablePanel2);
            this.tabExplorer.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabExplorer.Location = new System.Drawing.Point(0, 118);
            this.tabExplorer.Name = "tabExplorer";
            this.tabExplorer.Size = new System.Drawing.Size(169, 460);
            this.tabExplorer.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.tabExplorer.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.tabExplorer.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.tabExplorer.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabExplorer.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.tabExplorer.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.tabExplorer.Style.GradientAngle = 90;
            this.tabExplorer.TabIndex = 2;
            this.tabExplorer.TitleHeight = 15;
            this.tabExplorer.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.tabExplorer.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.tabExplorer.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.tabExplorer.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.tabExplorer.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.tabExplorer.TitleStyle.BorderWidth = 0;
            this.tabExplorer.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.tabExplorer.TitleStyle.GradientAngle = 90;
            this.tabExplorer.TitleText = " ";
            this.tabExplorer.ExpandedChanged += new DevComponents.DotNetBar.ExpandChangeEventHandler(this.tabExplorer_ExpandedChanged);
            // 
            // expandablePanel6
            // 
            this.expandablePanel6.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel6.Controls.Add(this.taskTab_XepLoai);
            this.expandablePanel6.Controls.Add(this.taskTab_DanhGia);
            this.expandablePanel6.Controls.Add(this.taskTab_HoatDong);
            this.expandablePanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel6.Expanded = false;
            this.expandablePanel6.ExpandedBounds = new System.Drawing.Rectangle(0, 134, 169, 107);
            this.expandablePanel6.Location = new System.Drawing.Point(0, 257);
            this.expandablePanel6.Name = "expandablePanel6";
            this.expandablePanel6.Size = new System.Drawing.Size(169, 26);
            this.expandablePanel6.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel6.Style.GradientAngle = 90;
            this.expandablePanel6.TabIndex = 4;
            this.expandablePanel6.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel6.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel6.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel6.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel6.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel6.TitleStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.expandablePanel6.TitleStyle.GradientAngle = 90;
            this.expandablePanel6.TitleText = "Danh mục";
            // 
            // taskTab_XepLoai
            // 
            this.taskTab_XepLoai.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_XepLoai.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_XepLoai.Image")));
            this.taskTab_XepLoai.Location = new System.Drawing.Point(13, 81);
            this.taskTab_XepLoai.Name = "taskTab_XepLoai";
            this.taskTab_XepLoai.Size = new System.Drawing.Size(139, 16);
            this.taskTab_XepLoai.TabIndex = 4;
            this.taskTab_XepLoai.Text = "Xếp loại...";
            this.taskTab_XepLoai.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_XepLoai.UseVisualStyleBackColor = false;
            this.taskTab_XepLoai.Click += new System.EventHandler(this.taskTab_XepLoai_Click);
            // 
            // taskTab_DanhGia
            // 
            this.taskTab_DanhGia.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_DanhGia.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_DanhGia.Image")));
            this.taskTab_DanhGia.Location = new System.Drawing.Point(13, 59);
            this.taskTab_DanhGia.Name = "taskTab_DanhGia";
            this.taskTab_DanhGia.Size = new System.Drawing.Size(162, 14);
            this.taskTab_DanhGia.TabIndex = 3;
            this.taskTab_DanhGia.Text = "Đánh giá...";
            this.taskTab_DanhGia.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_DanhGia.UseVisualStyleBackColor = false;
            this.taskTab_DanhGia.Click += new System.EventHandler(this.taskTab_DanhGia_Click);
            // 
            // taskTab_HoatDong
            // 
            this.taskTab_HoatDong.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_HoatDong.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_HoatDong.Image")));
            this.taskTab_HoatDong.Location = new System.Drawing.Point(13, 37);
            this.taskTab_HoatDong.Name = "taskTab_HoatDong";
            this.taskTab_HoatDong.Size = new System.Drawing.Size(150, 16);
            this.taskTab_HoatDong.TabIndex = 2;
            this.taskTab_HoatDong.Text = "Hoạt động...";
            this.taskTab_HoatDong.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_HoatDong.UseVisualStyleBackColor = false;
            this.taskTab_HoatDong.Click += new System.EventHandler(this.taskTab_HoatDong_Click);
            // 
            // expandablePanel5
            // 
            this.expandablePanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel5.Controls.Add(this.taskTab_TroGiup);
            this.expandablePanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel5.Expanded = false;
            this.expandablePanel5.ExpandedBounds = new System.Drawing.Rectangle(0, 102, 169, 71);
            this.expandablePanel5.Location = new System.Drawing.Point(0, 225);
            this.expandablePanel5.Name = "expandablePanel5";
            this.expandablePanel5.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.expandablePanel5.Size = new System.Drawing.Size(169, 32);
            this.expandablePanel5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel5.Style.GradientAngle = 90;
            this.expandablePanel5.TabIndex = 3;
            this.expandablePanel5.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel5.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel5.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel5.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel5.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel5.TitleStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.expandablePanel5.TitleStyle.GradientAngle = 90;
            this.expandablePanel5.TitleText = "Trợ giúp";
            // 
            // taskTab_TroGiup
            // 
            this.taskTab_TroGiup.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_TroGiup.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_TroGiup.Image")));
            this.taskTab_TroGiup.Location = new System.Drawing.Point(13, 44);
            this.taskTab_TroGiup.Name = "taskTab_TroGiup";
            this.taskTab_TroGiup.Size = new System.Drawing.Size(150, 16);
            this.taskTab_TroGiup.TabIndex = 1;
            this.taskTab_TroGiup.Text = "Trợ giúp...";
            this.taskTab_TroGiup.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_TroGiup.UseVisualStyleBackColor = false;
            // 
            // expandablePanel4
            // 
            this.expandablePanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel4.Controls.Add(this.taskTab_TraCuuPhong);
            this.expandablePanel4.Controls.Add(this.taskTab_TraCuuSinhVien);
            this.expandablePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel4.Expanded = false;
            this.expandablePanel4.ExpandedBounds = new System.Drawing.Rectangle(0, 73, 169, 88);
            this.expandablePanel4.Location = new System.Drawing.Point(0, 196);
            this.expandablePanel4.Name = "expandablePanel4";
            this.expandablePanel4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.expandablePanel4.Size = new System.Drawing.Size(169, 29);
            this.expandablePanel4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel4.Style.GradientAngle = 90;
            this.expandablePanel4.TabIndex = 2;
            this.expandablePanel4.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel4.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel4.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel4.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel4.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel4.TitleStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.expandablePanel4.TitleStyle.GradientAngle = 90;
            this.expandablePanel4.TitleText = "Tra cứu";
            // 
            // taskTab_TraCuuPhong
            // 
            this.taskTab_TraCuuPhong.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_TraCuuPhong.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_TraCuuPhong.Image")));
            this.taskTab_TraCuuPhong.Location = new System.Drawing.Point(13, 61);
            this.taskTab_TraCuuPhong.Name = "taskTab_TraCuuPhong";
            this.taskTab_TraCuuPhong.Size = new System.Drawing.Size(150, 18);
            this.taskTab_TraCuuPhong.TabIndex = 2;
            this.taskTab_TraCuuPhong.Text = "Tra cứu Phòng...";
            this.taskTab_TraCuuPhong.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_TraCuuPhong.UseVisualStyleBackColor = false;
            // 
            // taskTab_TraCuuSinhVien
            // 
            this.taskTab_TraCuuSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_TraCuuSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_TraCuuSinhVien.Image")));
            this.taskTab_TraCuuSinhVien.Location = new System.Drawing.Point(12, 39);
            this.taskTab_TraCuuSinhVien.Name = "taskTab_TraCuuSinhVien";
            this.taskTab_TraCuuSinhVien.Size = new System.Drawing.Size(139, 15);
            this.taskTab_TraCuuSinhVien.TabIndex = 1;
            this.taskTab_TraCuuSinhVien.Text = "Tra cứu Sinh Viên...";
            this.taskTab_TraCuuSinhVien.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_TraCuuSinhVien.UseVisualStyleBackColor = false;
            this.taskTab_TraCuuSinhVien.Click += new System.EventHandler(this.taskTab_TraCuuSinhVien_Click);
            // 
            // expandablePanel3
            // 
            this.expandablePanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel3.Controls.Add(this.taskTab_HoatDongSinhVien);
            this.expandablePanel3.Controls.Add(this.taskTab_ThongTinPhong);
            this.expandablePanel3.Controls.Add(this.taskTab_DiemDanh);
            this.expandablePanel3.Controls.Add(this.taskTab_ThongTinSinhVien);
            this.expandablePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel3.Expanded = false;
            this.expandablePanel3.ExpandedBounds = new System.Drawing.Rectangle(0, 44, 169, 150);
            this.expandablePanel3.Location = new System.Drawing.Point(0, 167);
            this.expandablePanel3.Name = "expandablePanel3";
            this.expandablePanel3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.expandablePanel3.Size = new System.Drawing.Size(169, 29);
            this.expandablePanel3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel3.Style.GradientAngle = 90;
            this.expandablePanel3.TabIndex = 1;
            this.expandablePanel3.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel3.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel3.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel3.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel3.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel3.TitleStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.expandablePanel3.TitleStyle.GradientAngle = 90;
            this.expandablePanel3.TitleText = "Quản lý";
            // 
            // taskTab_HoatDongSinhVien
            // 
            this.taskTab_HoatDongSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_HoatDongSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_HoatDongSinhVien.Image")));
            this.taskTab_HoatDongSinhVien.Location = new System.Drawing.Point(13, 115);
            this.taskTab_HoatDongSinhVien.Name = "taskTab_HoatDongSinhVien";
            this.taskTab_HoatDongSinhVien.Size = new System.Drawing.Size(162, 16);
            this.taskTab_HoatDongSinhVien.TabIndex = 4;
            this.taskTab_HoatDongSinhVien.Text = "Hoạt đông Sinh viên...";
            this.taskTab_HoatDongSinhVien.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_HoatDongSinhVien.UseVisualStyleBackColor = false;
            this.taskTab_HoatDongSinhVien.Click += new System.EventHandler(this.taskTab_HoatDongSinhVien_Click);
            // 
            // taskTab_ThongTinPhong
            // 
            this.taskTab_ThongTinPhong.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_ThongTinPhong.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_ThongTinPhong.Image")));
            this.taskTab_ThongTinPhong.Location = new System.Drawing.Point(12, 92);
            this.taskTab_ThongTinPhong.Name = "taskTab_ThongTinPhong";
            this.taskTab_ThongTinPhong.Size = new System.Drawing.Size(151, 16);
            this.taskTab_ThongTinPhong.TabIndex = 3;
            this.taskTab_ThongTinPhong.Text = "Thông tin Phòng...";
            this.taskTab_ThongTinPhong.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_ThongTinPhong.UseVisualStyleBackColor = false;
            this.taskTab_ThongTinPhong.Click += new System.EventHandler(this.taskTab_ThongTinPhong_Click);
            // 
            // taskTab_DiemDanh
            // 
            this.taskTab_DiemDanh.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_DiemDanh.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_DiemDanh.Image")));
            this.taskTab_DiemDanh.Location = new System.Drawing.Point(12, 69);
            this.taskTab_DiemDanh.Name = "taskTab_DiemDanh";
            this.taskTab_DiemDanh.Size = new System.Drawing.Size(134, 17);
            this.taskTab_DiemDanh.TabIndex = 2;
            this.taskTab_DiemDanh.Text = "Điểm danh...";
            this.taskTab_DiemDanh.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_DiemDanh.UseVisualStyleBackColor = false;
            this.taskTab_DiemDanh.Click += new System.EventHandler(this.taskTab_DiemDanh_Click);
            // 
            // taskTab_ThongTinSinhVien
            // 
            this.taskTab_ThongTinSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_ThongTinSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_ThongTinSinhVien.Image")));
            this.taskTab_ThongTinSinhVien.Location = new System.Drawing.Point(12, 45);
            this.taskTab_ThongTinSinhVien.Name = "taskTab_ThongTinSinhVien";
            this.taskTab_ThongTinSinhVien.Size = new System.Drawing.Size(137, 18);
            this.taskTab_ThongTinSinhVien.TabIndex = 1;
            this.taskTab_ThongTinSinhVien.Text = "Thông tin Sinh viên...";
            this.taskTab_ThongTinSinhVien.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_ThongTinSinhVien.UseVisualStyleBackColor = false;
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel2.Controls.Add(this.taskTab_HienThi);
            this.expandablePanel2.Controls.Add(this.taskTab_NguoiDung);
            this.expandablePanel2.Controls.Add(this.taskTab_Thoat);
            this.expandablePanel2.Controls.Add(this.taskTab_DangXuat);
            this.expandablePanel2.Controls.Add(this.taskTab_DangNhap);
            this.expandablePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel2.Location = new System.Drawing.Point(0, 15);
            this.expandablePanel2.Name = "expandablePanel2";
            this.expandablePanel2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.expandablePanel2.Size = new System.Drawing.Size(169, 152);
            this.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel2.Style.GradientAngle = 90;
            this.expandablePanel2.TabIndex = 1;
            this.expandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel2.TitleStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.expandablePanel2.TitleStyle.GradientAngle = 90;
            this.expandablePanel2.TitleText = "Hệ Thống";
            this.expandablePanel2.Click += new System.EventHandler(this.expandablePanel2_Click);
            // 
            // taskTab_HienThi
            // 
            this.taskTab_HienThi.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_HienThi.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_HienThi.Image")));
            this.taskTab_HienThi.Location = new System.Drawing.Point(13, 107);
            this.taskTab_HienThi.Name = "taskTab_HienThi";
            this.taskTab_HienThi.Size = new System.Drawing.Size(133, 16);
            this.taskTab_HienThi.TabIndex = 5;
            this.taskTab_HienThi.Text = "Hiển thị dạng Menu";
            this.taskTab_HienThi.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_HienThi.UseVisualStyleBackColor = false;
            this.taskTab_HienThi.Click += new System.EventHandler(this.taskItem13_Click);
            // 
            // taskTab_NguoiDung
            // 
            this.taskTab_NguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_NguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_NguoiDung.Image")));
            this.taskTab_NguoiDung.Location = new System.Drawing.Point(13, 86);
            this.taskTab_NguoiDung.Name = "taskTab_NguoiDung";
            this.taskTab_NguoiDung.Size = new System.Drawing.Size(124, 13);
            this.taskTab_NguoiDung.TabIndex = 4;
            this.taskTab_NguoiDung.Text = "Người dùng...";
            this.taskTab_NguoiDung.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_NguoiDung.UseVisualStyleBackColor = false;
            this.taskTab_NguoiDung.Click += new System.EventHandler(this.taskItem12_Click);
            // 
            // taskTab_Thoat
            // 
            this.taskTab_Thoat.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_Thoat.Image")));
            this.taskTab_Thoat.Location = new System.Drawing.Point(13, 130);
            this.taskTab_Thoat.Name = "taskTab_Thoat";
            this.taskTab_Thoat.Size = new System.Drawing.Size(139, 16);
            this.taskTab_Thoat.TabIndex = 3;
            this.taskTab_Thoat.Text = "Thoát";
            this.taskTab_Thoat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_Thoat.UseVisualStyleBackColor = false;
            this.taskTab_Thoat.Click += new System.EventHandler(this.taskItem2_Click);
            // 
            // taskTab_DangXuat
            // 
            this.taskTab_DangXuat.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_DangXuat.Image")));
            this.taskTab_DangXuat.Location = new System.Drawing.Point(12, 64);
            this.taskTab_DangXuat.Name = "taskTab_DangXuat";
            this.taskTab_DangXuat.Size = new System.Drawing.Size(139, 16);
            this.taskTab_DangXuat.TabIndex = 2;
            this.taskTab_DangXuat.Text = "Đăng xuất";
            this.taskTab_DangXuat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_DangXuat.UseVisualStyleBackColor = false;
            this.taskTab_DangXuat.Click += new System.EventHandler(this.taskTab_DangXuat_Click);
            // 
            // taskTab_DangNhap
            // 
            this.taskTab_DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.taskTab_DangNhap.Image = ((System.Drawing.Image)(resources.GetObject("taskTab_DangNhap.Image")));
            this.taskTab_DangNhap.Location = new System.Drawing.Point(12, 41);
            this.taskTab_DangNhap.Name = "taskTab_DangNhap";
            this.taskTab_DangNhap.Size = new System.Drawing.Size(139, 16);
            this.taskTab_DangNhap.TabIndex = 1;
            this.taskTab_DangNhap.Text = "Đăng nhập...";
            this.taskTab_DangNhap.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskTab_DangNhap.UseVisualStyleBackColor = false;
            this.taskTab_DangNhap.Click += new System.EventHandler(this.taskTab_ĐăngNhap_Click);
            // 
            // itemContainer8
            // 
            this.itemContainer8.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer8.Name = "itemContainer8";
            // 
            // buttonItem14
            // 
            this.buttonItem14.ImagePaddingHorizontal = 8;
            this.buttonItem14.Name = "buttonItem14";
            this.buttonItem14.SubItemsExpandWidth = 14;
            this.buttonItem14.Text = "buttonItem14";
            // 
            // itemContainer9
            // 
            this.itemContainer9.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer9.Name = "itemContainer9";
            // 
            // itemContainer10
            // 
            this.itemContainer10.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer10.Name = "itemContainer10";
            // 
            // itemContainer11
            // 
            this.itemContainer11.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer11.Name = "itemContainer11";
            // 
            // itemContainer12
            // 
            this.itemContainer12.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer12.Name = "itemContainer12";
            // 
            // itemContainer13
            // 
            this.itemContainer13.MinimumSize = new System.Drawing.Size(0, 0);
            this.itemContainer13.Name = "itemContainer13";
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "comboItem7";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "comboItem8";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "comboItem9";
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "comboItem10";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQLSV,
            this.mnuQLPhong,
            this.mnuQLDay,
            this.mnuTraCuu,
            this.mnuTroGiup});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(804, 24);
            this.mnuMainMenu.TabIndex = 5;
            this.mnuMainMenu.Text = "menuStrip1";
            this.mnuMainMenu.Visible = false;
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong_DangNhap,
            this.mnuHeThong_DangXuat,
            this.toolStripSeparator10,
            this.mnuHeThong_NguoiDung,
            this.mnuHeThong_tab,
            this.toolStripSeparator11,
            this.mnuHeThong_Thoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(72, 20);
            this.mnuHeThong.Text = "&Hệ Thống";
            // 
            // mnuHeThong_DangNhap
            // 
            this.mnuHeThong_DangNhap.Image = ((System.Drawing.Image)(resources.GetObject("mnuHeThong_DangNhap.Image")));
            this.mnuHeThong_DangNhap.Name = "mnuHeThong_DangNhap";
            this.mnuHeThong_DangNhap.Size = new System.Drawing.Size(169, 22);
            this.mnuHeThong_DangNhap.Text = "Đăng nhập...";
            this.mnuHeThong_DangNhap.Click += new System.EventHandler(this.mnuHeThong_DangNhap_Click);
            // 
            // mnuHeThong_DangXuat
            // 
            this.mnuHeThong_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("mnuHeThong_DangXuat.Image")));
            this.mnuHeThong_DangXuat.Name = "mnuHeThong_DangXuat";
            this.mnuHeThong_DangXuat.Size = new System.Drawing.Size(169, 22);
            this.mnuHeThong_DangXuat.Text = "Đăng xuất";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(166, 6);
            // 
            // mnuHeThong_NguoiDung
            // 
            this.mnuHeThong_NguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("mnuHeThong_NguoiDung.Image")));
            this.mnuHeThong_NguoiDung.Name = "mnuHeThong_NguoiDung";
            this.mnuHeThong_NguoiDung.Size = new System.Drawing.Size(169, 22);
            this.mnuHeThong_NguoiDung.Text = "Người dùng...";
            this.mnuHeThong_NguoiDung.Click += new System.EventHandler(this.mnuHeThong_NguoiDung_Click);
            // 
            // mnuHeThong_tab
            // 
            this.mnuHeThong_tab.Image = ((System.Drawing.Image)(resources.GetObject("mnuHeThong_tab.Image")));
            this.mnuHeThong_tab.Name = "mnuHeThong_tab";
            this.mnuHeThong_tab.Size = new System.Drawing.Size(169, 22);
            this.mnuHeThong_tab.Text = "Hiển thị dạng Tab";
            this.mnuHeThong_tab.Click += new System.EventHandler(this.hiêToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(166, 6);
            // 
            // mnuHeThong_Thoat
            // 
            this.mnuHeThong_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuHeThong_Thoat.Image")));
            this.mnuHeThong_Thoat.Name = "mnuHeThong_Thoat";
            this.mnuHeThong_Thoat.Size = new System.Drawing.Size(169, 22);
            this.mnuHeThong_Thoat.Text = "Thoát";
            // 
            // mnuQLSV
            // 
            this.mnuQLSV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLSV_ThemSV,
            this.mnuQLSV_SuaSV,
            this.mnuQLSV_XoaSinhVien,
            this.toolStripSeparator4,
            this.mnuQLSV_TraCuu,
            this.mnuQLSV_ThongKe,
            this.toolStripSeparator5,
            this.mnuQLSV_QuanLy,
            this.mnuQLSV_DanhGia1});
            this.mnuQLSV.Name = "mnuQLSV";
            this.mnuQLSV.Size = new System.Drawing.Size(111, 20);
            this.mnuQLSV.Text = "Quản lý &Sinh viên";
            // 
            // mnuQLSV_ThemSV
            // 
            this.mnuQLSV_ThemSV.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_ThemSV.Image")));
            this.mnuQLSV_ThemSV.Name = "mnuQLSV_ThemSV";
            this.mnuQLSV_ThemSV.Size = new System.Drawing.Size(186, 22);
            this.mnuQLSV_ThemSV.Text = "Lập hồ sơ Sinh viên...";
            this.mnuQLSV_ThemSV.Click += new System.EventHandler(this.mnuQLSV_ThemSV_Click);
            // 
            // mnuQLSV_SuaSV
            // 
            this.mnuQLSV_SuaSV.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_SuaSV.Image")));
            this.mnuQLSV_SuaSV.Name = "mnuQLSV_SuaSV";
            this.mnuQLSV_SuaSV.Size = new System.Drawing.Size(186, 22);
            this.mnuQLSV_SuaSV.Text = "Sửa hồ sơ Sinh viên...";
            this.mnuQLSV_SuaSV.Click += new System.EventHandler(this.mnuQLSV_SuaSV_Click);
            // 
            // mnuQLSV_XoaSinhVien
            // 
            this.mnuQLSV_XoaSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_XoaSinhVien.Image")));
            this.mnuQLSV_XoaSinhVien.Name = "mnuQLSV_XoaSinhVien";
            this.mnuQLSV_XoaSinhVien.Size = new System.Drawing.Size(186, 22);
            this.mnuQLSV_XoaSinhVien.Text = "Xóa hồ sơ Sinh viên...";
            this.mnuQLSV_XoaSinhVien.Click += new System.EventHandler(this.mnuQLSV_XoaSinhVien_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuQLSV_TraCuu
            // 
            this.mnuQLSV_TraCuu.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_TraCuu.Image")));
            this.mnuQLSV_TraCuu.Name = "mnuQLSV_TraCuu";
            this.mnuQLSV_TraCuu.Size = new System.Drawing.Size(186, 22);
            this.mnuQLSV_TraCuu.Text = "Tra cứu...";
            this.mnuQLSV_TraCuu.Click += new System.EventHandler(this.mnuQLSV_TraCuu_Click);
            // 
            // mnuQLSV_ThongKe
            // 
            this.mnuQLSV_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_ThongKe.Image")));
            this.mnuQLSV_ThongKe.Name = "mnuQLSV_ThongKe";
            this.mnuQLSV_ThongKe.Size = new System.Drawing.Size(186, 22);
            this.mnuQLSV_ThongKe.Text = "Thống kê...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuQLSV_QuanLy
            // 
            this.mnuQLSV_QuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLSV_DiemDanh,
            this.mnuQLSV_ChuyenPhong});
            this.mnuQLSV_QuanLy.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_QuanLy.Image")));
            this.mnuQLSV_QuanLy.Name = "mnuQLSV_QuanLy";
            this.mnuQLSV_QuanLy.Size = new System.Drawing.Size(186, 22);
            this.mnuQLSV_QuanLy.Text = "Quản lý";
            // 
            // mnuQLSV_DiemDanh
            // 
            this.mnuQLSV_DiemDanh.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_DiemDanh.Image")));
            this.mnuQLSV_DiemDanh.Name = "mnuQLSV_DiemDanh";
            this.mnuQLSV_DiemDanh.Size = new System.Drawing.Size(162, 22);
            this.mnuQLSV_DiemDanh.Text = "Điểm danh...";
            this.mnuQLSV_DiemDanh.Click += new System.EventHandler(this.mnuQLSV_DiemDanh_Click);
            // 
            // mnuQLSV_ChuyenPhong
            // 
            this.mnuQLSV_ChuyenPhong.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_ChuyenPhong.Image")));
            this.mnuQLSV_ChuyenPhong.Name = "mnuQLSV_ChuyenPhong";
            this.mnuQLSV_ChuyenPhong.Size = new System.Drawing.Size(162, 22);
            this.mnuQLSV_ChuyenPhong.Text = "Chuyển phòng...";
            this.mnuQLSV_ChuyenPhong.Click += new System.EventHandler(this.mnuQLSV_ChuyenPhong_Click);
            // 
            // mnuQLSV_DanhGia1
            // 
            this.mnuQLSV_DanhGia1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLSV_HoatDong,
            this.mnuQLSV_DanhGia,
            this.mnuQLSV_KhenThuong,
            this.mnuQLSV_KyLuat});
            this.mnuQLSV_DanhGia1.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_DanhGia1.Image")));
            this.mnuQLSV_DanhGia1.Name = "mnuQLSV_DanhGia1";
            this.mnuQLSV_DanhGia1.Size = new System.Drawing.Size(186, 22);
            this.mnuQLSV_DanhGia1.Text = "Đáng giá";
            // 
            // mnuQLSV_HoatDong
            // 
            this.mnuQLSV_HoatDong.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_HoatDong.Image")));
            this.mnuQLSV_HoatDong.Name = "mnuQLSV_HoatDong";
            this.mnuQLSV_HoatDong.Size = new System.Drawing.Size(152, 22);
            this.mnuQLSV_HoatDong.Text = "Hoạt động...";
            // 
            // mnuQLSV_DanhGia
            // 
            this.mnuQLSV_DanhGia.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_DanhGia.Image")));
            this.mnuQLSV_DanhGia.Name = "mnuQLSV_DanhGia";
            this.mnuQLSV_DanhGia.Size = new System.Drawing.Size(152, 22);
            this.mnuQLSV_DanhGia.Text = "Đánh giá...";
            this.mnuQLSV_DanhGia.Click += new System.EventHandler(this.mnuQLSV_DanhGia_Click);
            // 
            // mnuQLSV_KhenThuong
            // 
            this.mnuQLSV_KhenThuong.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_KhenThuong.Image")));
            this.mnuQLSV_KhenThuong.Name = "mnuQLSV_KhenThuong";
            this.mnuQLSV_KhenThuong.Size = new System.Drawing.Size(152, 22);
            this.mnuQLSV_KhenThuong.Text = "Khen thưởng...";
            // 
            // mnuQLSV_KyLuat
            // 
            this.mnuQLSV_KyLuat.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLSV_KyLuat.Image")));
            this.mnuQLSV_KyLuat.Name = "mnuQLSV_KyLuat";
            this.mnuQLSV_KyLuat.Size = new System.Drawing.Size(152, 22);
            this.mnuQLSV_KyLuat.Text = "Kỷ luật...";
            // 
            // mnuQLPhong
            // 
            this.mnuQLPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLPhong_ThemPhong,
            this.mnuQLPhong_SuaPhong,
            this.mnuQLPhong_XoaPhong,
            this.toolStripSeparator6,
            this.mnuQLPhong_DanhGia,
            this.mnuQLPhong_KWDien,
            this.mnuQLPhong_ThongKe,
            this.toolStripSeparator7,
            this.mnuQLPhong_ThuTien});
            this.mnuQLPhong.Name = "mnuQLPhong";
            this.mnuQLPhong.Size = new System.Drawing.Size(98, 20);
            this.mnuQLPhong.Text = "Quản lý &Phòng";
            // 
            // mnuQLPhong_ThemPhong
            // 
            this.mnuQLPhong_ThemPhong.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLPhong_ThemPhong.Image")));
            this.mnuQLPhong_ThemPhong.Name = "mnuQLPhong_ThemPhong";
            this.mnuQLPhong_ThemPhong.Size = new System.Drawing.Size(174, 22);
            this.mnuQLPhong_ThemPhong.Text = "Thêm Phòng...";
            // 
            // mnuQLPhong_SuaPhong
            // 
            this.mnuQLPhong_SuaPhong.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLPhong_SuaPhong.Image")));
            this.mnuQLPhong_SuaPhong.Name = "mnuQLPhong_SuaPhong";
            this.mnuQLPhong_SuaPhong.Size = new System.Drawing.Size(174, 22);
            this.mnuQLPhong_SuaPhong.Text = "Sửa Phòng...";
            // 
            // mnuQLPhong_XoaPhong
            // 
            this.mnuQLPhong_XoaPhong.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLPhong_XoaPhong.Image")));
            this.mnuQLPhong_XoaPhong.Name = "mnuQLPhong_XoaPhong";
            this.mnuQLPhong_XoaPhong.Size = new System.Drawing.Size(174, 22);
            this.mnuQLPhong_XoaPhong.Text = "Xóa Phòng...";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(171, 6);
            // 
            // mnuQLPhong_DanhGia
            // 
            this.mnuQLPhong_DanhGia.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLPhong_DanhGia.Image")));
            this.mnuQLPhong_DanhGia.Name = "mnuQLPhong_DanhGia";
            this.mnuQLPhong_DanhGia.Size = new System.Drawing.Size(174, 22);
            this.mnuQLPhong_DanhGia.Text = "Đánh giá...";
            // 
            // mnuQLPhong_KWDien
            // 
            this.mnuQLPhong_KWDien.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLPhong_KWDien.Image")));
            this.mnuQLPhong_KWDien.Name = "mnuQLPhong_KWDien";
            this.mnuQLPhong_KWDien.Size = new System.Drawing.Size(174, 22);
            this.mnuQLPhong_KWDien.Text = "Nhập số KW điện...";
            // 
            // mnuQLPhong_ThongKe
            // 
            this.mnuQLPhong_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLPhong_ThongKe.Image")));
            this.mnuQLPhong_ThongKe.Name = "mnuQLPhong_ThongKe";
            this.mnuQLPhong_ThongKe.Size = new System.Drawing.Size(174, 22);
            this.mnuQLPhong_ThongKe.Text = "Thống kê...";
            this.mnuQLPhong_ThongKe.Click += new System.EventHandler(this.mnuQLPhong_ThongKe_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(171, 6);
            // 
            // mnuQLPhong_ThuTien
            // 
            this.mnuQLPhong_ThuTien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLPhong_TienDien,
            this.mnuQLPhong_TienPhong});
            this.mnuQLPhong_ThuTien.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLPhong_ThuTien.Image")));
            this.mnuQLPhong_ThuTien.Name = "mnuQLPhong_ThuTien";
            this.mnuQLPhong_ThuTien.Size = new System.Drawing.Size(174, 22);
            this.mnuQLPhong_ThuTien.Text = "Thu tiền";
            // 
            // mnuQLPhong_TienDien
            // 
            this.mnuQLPhong_TienDien.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLPhong_TienDien.Image")));
            this.mnuQLPhong_TienDien.Name = "mnuQLPhong_TienDien";
            this.mnuQLPhong_TienDien.Size = new System.Drawing.Size(144, 22);
            this.mnuQLPhong_TienDien.Text = "Tiền điện...";
            // 
            // mnuQLPhong_TienPhong
            // 
            this.mnuQLPhong_TienPhong.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLPhong_TienPhong.Image")));
            this.mnuQLPhong_TienPhong.Name = "mnuQLPhong_TienPhong";
            this.mnuQLPhong_TienPhong.Size = new System.Drawing.Size(144, 22);
            this.mnuQLPhong_TienPhong.Text = "Tiền phòng...";
            // 
            // mnuQLDay
            // 
            this.mnuQLDay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLDay_ThemDay,
            this.mnuQLDay_SuaDay,
            this.mnuQLDay_XoaDay,
            this.toolStripSeparator8,
            this.mnuQLDay_ThemKTX,
            this.mnuQLDay_SuaKTX,
            this.mnuQLDay_XoaKTX,
            this.toolStripSeparator9,
            this.mnuQLDay_ThongKeDay,
            this.mnuQLDay_ThongKeKTX,
            this.mnuQLDay_TraCuu});
            this.mnuQLDay.Name = "mnuQLDay";
            this.mnuQLDay.Size = new System.Drawing.Size(83, 20);
            this.mnuQLDay.Text = "Quản lý &Dãy";
            // 
            // mnuQLDay_ThemDay
            // 
            this.mnuQLDay_ThemDay.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLDay_ThemDay.Image")));
            this.mnuQLDay_ThemDay.Name = "mnuQLDay_ThemDay";
            this.mnuQLDay_ThemDay.Size = new System.Drawing.Size(157, 22);
            this.mnuQLDay_ThemDay.Text = "Thêm dãy...";
            // 
            // mnuQLDay_SuaDay
            // 
            this.mnuQLDay_SuaDay.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLDay_SuaDay.Image")));
            this.mnuQLDay_SuaDay.Name = "mnuQLDay_SuaDay";
            this.mnuQLDay_SuaDay.Size = new System.Drawing.Size(157, 22);
            this.mnuQLDay_SuaDay.Text = "Sửa dãy...";
            // 
            // mnuQLDay_XoaDay
            // 
            this.mnuQLDay_XoaDay.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLDay_XoaDay.Image")));
            this.mnuQLDay_XoaDay.Name = "mnuQLDay_XoaDay";
            this.mnuQLDay_XoaDay.Size = new System.Drawing.Size(157, 22);
            this.mnuQLDay_XoaDay.Text = "Xóa dãy...";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(154, 6);
            // 
            // mnuQLDay_ThemKTX
            // 
            this.mnuQLDay_ThemKTX.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLDay_ThemKTX.Image")));
            this.mnuQLDay_ThemKTX.Name = "mnuQLDay_ThemKTX";
            this.mnuQLDay_ThemKTX.Size = new System.Drawing.Size(157, 22);
            this.mnuQLDay_ThemKTX.Text = "Thêm KTX...";
            // 
            // mnuQLDay_SuaKTX
            // 
            this.mnuQLDay_SuaKTX.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLDay_SuaKTX.Image")));
            this.mnuQLDay_SuaKTX.Name = "mnuQLDay_SuaKTX";
            this.mnuQLDay_SuaKTX.Size = new System.Drawing.Size(157, 22);
            this.mnuQLDay_SuaKTX.Text = "Sửa KTX...";
            // 
            // mnuQLDay_XoaKTX
            // 
            this.mnuQLDay_XoaKTX.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLDay_XoaKTX.Image")));
            this.mnuQLDay_XoaKTX.Name = "mnuQLDay_XoaKTX";
            this.mnuQLDay_XoaKTX.Size = new System.Drawing.Size(157, 22);
            this.mnuQLDay_XoaKTX.Text = "Xóa KTX...";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(154, 6);
            // 
            // mnuQLDay_ThongKeDay
            // 
            this.mnuQLDay_ThongKeDay.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLDay_ThongKeDay.Image")));
            this.mnuQLDay_ThongKeDay.Name = "mnuQLDay_ThongKeDay";
            this.mnuQLDay_ThongKeDay.Size = new System.Drawing.Size(157, 22);
            this.mnuQLDay_ThongKeDay.Text = "Thống kê dãy...";
            this.mnuQLDay_ThongKeDay.Click += new System.EventHandler(this.mnuQLDay_ThongKeDay_Click);
            // 
            // mnuQLDay_ThongKeKTX
            // 
            this.mnuQLDay_ThongKeKTX.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLDay_ThongKeKTX.Image")));
            this.mnuQLDay_ThongKeKTX.Name = "mnuQLDay_ThongKeKTX";
            this.mnuQLDay_ThongKeKTX.Size = new System.Drawing.Size(157, 22);
            this.mnuQLDay_ThongKeKTX.Text = "Thống kê KTX...";
            this.mnuQLDay_ThongKeKTX.Click += new System.EventHandler(this.mnuQLDay_ThongKeKTX_Click);
            // 
            // mnuQLDay_TraCuu
            // 
            this.mnuQLDay_TraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLDay_TraCuuDay,
            this.mnuQLDay_TraCuuKTX});
            this.mnuQLDay_TraCuu.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLDay_TraCuu.Image")));
            this.mnuQLDay_TraCuu.Name = "mnuQLDay_TraCuu";
            this.mnuQLDay_TraCuu.Size = new System.Drawing.Size(157, 22);
            this.mnuQLDay_TraCuu.Text = "Tra cứu";
            // 
            // mnuQLDay_TraCuuDay
            // 
            this.mnuQLDay_TraCuuDay.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLDay_TraCuuDay.Image")));
            this.mnuQLDay_TraCuuDay.Name = "mnuQLDay_TraCuuDay";
            this.mnuQLDay_TraCuuDay.Size = new System.Drawing.Size(147, 22);
            this.mnuQLDay_TraCuuDay.Text = "Tra cứu Dãy...";
            // 
            // mnuQLDay_TraCuuKTX
            // 
            this.mnuQLDay_TraCuuKTX.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLDay_TraCuuKTX.Image")));
            this.mnuQLDay_TraCuuKTX.Name = "mnuQLDay_TraCuuKTX";
            this.mnuQLDay_TraCuuKTX.Size = new System.Drawing.Size(147, 22);
            this.mnuQLDay_TraCuuKTX.Text = "Tra cứu KTX...";
            // 
            // mnuTraCuu
            // 
            this.mnuTraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTraCuu_SinhVien,
            this.mnuTraCuu_Phong,
            this.mnuTraCuu_Day,
            this.mnuTraCuu_KTX});
            this.mnuTraCuu.Name = "mnuTraCuu";
            this.mnuTraCuu.Size = new System.Drawing.Size(59, 20);
            this.mnuTraCuu.Text = "&Tra cứu";
            // 
            // mnuTraCuu_SinhVien
            // 
            this.mnuTraCuu_SinhVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuTraCuu_SinhVien.Image")));
            this.mnuTraCuu_SinhVien.Name = "mnuTraCuu_SinhVien";
            this.mnuTraCuu_SinhVien.Size = new System.Drawing.Size(174, 22);
            this.mnuTraCuu_SinhVien.Text = "Tra cứu Sinh viên...";
            // 
            // mnuTraCuu_Phong
            // 
            this.mnuTraCuu_Phong.Image = ((System.Drawing.Image)(resources.GetObject("mnuTraCuu_Phong.Image")));
            this.mnuTraCuu_Phong.Name = "mnuTraCuu_Phong";
            this.mnuTraCuu_Phong.Size = new System.Drawing.Size(174, 22);
            this.mnuTraCuu_Phong.Text = "Tra cứu Phòng...";
            // 
            // mnuTraCuu_Day
            // 
            this.mnuTraCuu_Day.Image = ((System.Drawing.Image)(resources.GetObject("mnuTraCuu_Day.Image")));
            this.mnuTraCuu_Day.Name = "mnuTraCuu_Day";
            this.mnuTraCuu_Day.Size = new System.Drawing.Size(174, 22);
            this.mnuTraCuu_Day.Text = "Tra cứu Dãy...";
            // 
            // mnuTraCuu_KTX
            // 
            this.mnuTraCuu_KTX.Image = ((System.Drawing.Image)(resources.GetObject("mnuTraCuu_KTX.Image")));
            this.mnuTraCuu_KTX.Name = "mnuTraCuu_KTX";
            this.mnuTraCuu_KTX.Size = new System.Drawing.Size(174, 22);
            this.mnuTraCuu_KTX.Text = "Tra cứu KTX...";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTroGiup_TroGiup,
            this.mnuTroGiup_GioiThieu});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(64, 20);
            this.mnuTroGiup.Text = "Trợ &giúp";
            // 
            // mnuTroGiup_TroGiup
            // 
            this.mnuTroGiup_TroGiup.Image = ((System.Drawing.Image)(resources.GetObject("mnuTroGiup_TroGiup.Image")));
            this.mnuTroGiup_TroGiup.Name = "mnuTroGiup_TroGiup";
            this.mnuTroGiup_TroGiup.Size = new System.Drawing.Size(134, 22);
            this.mnuTroGiup_TroGiup.Text = "Trợ giúp...";
            this.mnuTroGiup_TroGiup.Click += new System.EventHandler(this.mnuTroGiup_TroGiup_Click);
            // 
            // mnuTroGiup_GioiThieu
            // 
            this.mnuTroGiup_GioiThieu.Image = ((System.Drawing.Image)(resources.GetObject("mnuTroGiup_GioiThieu.Image")));
            this.mnuTroGiup_GioiThieu.Name = "mnuTroGiup_GioiThieu";
            this.mnuTroGiup_GioiThieu.Size = new System.Drawing.Size(134, 22);
            this.mnuTroGiup_GioiThieu.Text = "Giới thiệu...";
            // 
            // textBoxItem5
            // 
            this.textBoxItem5.Name = "textBoxItem5";
            this.textBoxItem5.Text = "textBoxItem5";
            this.textBoxItem5.TextBoxWidth = 100;
            // 
            // textBoxItem7
            // 
            this.textBoxItem7.Name = "textBoxItem7";
            this.textBoxItem7.Text = "textBoxItem7";
            // 
            // toolMenuBar
            // 
            this.toolMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMainTool_DangNhap,
            this.btnMainTool_DangXuat,
            this.btnMainTool_Thoat,
            this.toolStripSeparator1,
            this.toolStripSplitButton1,
            this.toolStripSeparator2,
            this.btnMainTool_ThemSinhVien,
            this.btnMainTool_SuaSinhVien,
            this.toolStripSeparator3,
            this.btnMainTool_TraCuu});
            this.toolMenuBar.Location = new System.Drawing.Point(169, 118);
            this.toolMenuBar.Name = "toolMenuBar";
            this.toolMenuBar.Size = new System.Drawing.Size(635, 52);
            this.toolMenuBar.TabIndex = 7;
            this.toolMenuBar.Text = "toolStrip1";
            this.toolMenuBar.Visible = false;
            // 
            // btnMainTool_DangNhap
            // 
            this.btnMainTool_DangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnMainTool_DangNhap.Image")));
            this.btnMainTool_DangNhap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMainTool_DangNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMainTool_DangNhap.Name = "btnMainTool_DangNhap";
            this.btnMainTool_DangNhap.Size = new System.Drawing.Size(69, 49);
            this.btnMainTool_DangNhap.Text = "Đăng nhập";
            this.btnMainTool_DangNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainTool_DangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMainTool_DangNhap.Click += new System.EventHandler(this.btnMainTool_DangNhap_Click);
            // 
            // btnMainTool_DangXuat
            // 
            this.btnMainTool_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnMainTool_DangXuat.Image")));
            this.btnMainTool_DangXuat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMainTool_DangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMainTool_DangXuat.Name = "btnMainTool_DangXuat";
            this.btnMainTool_DangXuat.Size = new System.Drawing.Size(64, 49);
            this.btnMainTool_DangXuat.Text = "Đăng xuất";
            this.btnMainTool_DangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnMainTool_Thoat
            // 
            this.btnMainTool_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btnMainTool_Thoat.Image")));
            this.btnMainTool_Thoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMainTool_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMainTool_Thoat.Name = "btnMainTool_Thoat";
            this.btnMainTool_Thoat.Size = new System.Drawing.Size(42, 49);
            this.btnMainTool_Thoat.Text = "Thoát";
            this.btnMainTool_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMainTool_Thoat.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngangToolStripMenuItem,
            this.docToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(106, 49);
            this.toolStripSplitButton1.Text = "Chế độ Hiển thị";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ngangToolStripMenuItem
            // 
            this.ngangToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ngangToolStripMenuItem.Image")));
            this.ngangToolStripMenuItem.Name = "ngangToolStripMenuItem";
            this.ngangToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ngangToolStripMenuItem.Text = "Ngang";
            this.ngangToolStripMenuItem.Click += new System.EventHandler(this.ngangToolStripMenuItem_Click);
            // 
            // docToolStripMenuItem
            // 
            this.docToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("docToolStripMenuItem.Image")));
            this.docToolStripMenuItem.Name = "docToolStripMenuItem";
            this.docToolStripMenuItem.ShowShortcutKeys = false;
            this.docToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.docToolStripMenuItem.Text = "Dọc";
            this.docToolStripMenuItem.Click += new System.EventHandler(this.docToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // btnMainTool_ThemSinhVien
            // 
            this.btnMainTool_ThemSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnMainTool_ThemSinhVien.Image")));
            this.btnMainTool_ThemSinhVien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMainTool_ThemSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMainTool_ThemSinhVien.Name = "btnMainTool_ThemSinhVien";
            this.btnMainTool_ThemSinhVien.Size = new System.Drawing.Size(89, 49);
            this.btnMainTool_ThemSinhVien.Text = "Tạo Hồ sơ mới";
            this.btnMainTool_ThemSinhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMainTool_ThemSinhVien.ToolTipText = "Tạo Hồ sơ mới cho Sinh viên";
            this.btnMainTool_ThemSinhVien.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // btnMainTool_SuaSinhVien
            // 
            this.btnMainTool_SuaSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnMainTool_SuaSinhVien.Image")));
            this.btnMainTool_SuaSinhVien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMainTool_SuaSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMainTool_SuaSinhVien.Name = "btnMainTool_SuaSinhVien";
            this.btnMainTool_SuaSinhVien.Size = new System.Drawing.Size(79, 49);
            this.btnMainTool_SuaSinhVien.Text = "Thông tin SV";
            this.btnMainTool_SuaSinhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // btnMainTool_TraCuu
            // 
            this.btnMainTool_TraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolMenuBar_TraCuu_SinhVien,
            this.btnToolMenuBar_TraCuu_Phong,
            this.btnToolMenuBar_TraCuu_Day,
            this.btnToolMenuBar_TraCuu_KTX});
            this.btnMainTool_TraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btnMainTool_TraCuu.Image")));
            this.btnMainTool_TraCuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMainTool_TraCuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMainTool_TraCuu.Name = "btnMainTool_TraCuu";
            this.btnMainTool_TraCuu.Size = new System.Drawing.Size(63, 49);
            this.btnMainTool_TraCuu.Text = "Tra cứu";
            this.btnMainTool_TraCuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnToolMenuBar_TraCuu_SinhVien
            // 
            this.btnToolMenuBar_TraCuu_SinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnToolMenuBar_TraCuu_SinhVien.Image")));
            this.btnToolMenuBar_TraCuu_SinhVien.Name = "btnToolMenuBar_TraCuu_SinhVien";
            this.btnToolMenuBar_TraCuu_SinhVien.Size = new System.Drawing.Size(131, 22);
            this.btnToolMenuBar_TraCuu_SinhVien.Text = "Sinh viên...";
            this.btnToolMenuBar_TraCuu_SinhVien.Click += new System.EventHandler(this.btnToolMenuBar_TraCuu_SinhVien_Click);
            // 
            // btnToolMenuBar_TraCuu_Phong
            // 
            this.btnToolMenuBar_TraCuu_Phong.Image = ((System.Drawing.Image)(resources.GetObject("btnToolMenuBar_TraCuu_Phong.Image")));
            this.btnToolMenuBar_TraCuu_Phong.Name = "btnToolMenuBar_TraCuu_Phong";
            this.btnToolMenuBar_TraCuu_Phong.Size = new System.Drawing.Size(131, 22);
            this.btnToolMenuBar_TraCuu_Phong.Text = "Phòng...";
            // 
            // btnToolMenuBar_TraCuu_Day
            // 
            this.btnToolMenuBar_TraCuu_Day.Image = ((System.Drawing.Image)(resources.GetObject("btnToolMenuBar_TraCuu_Day.Image")));
            this.btnToolMenuBar_TraCuu_Day.Name = "btnToolMenuBar_TraCuu_Day";
            this.btnToolMenuBar_TraCuu_Day.Size = new System.Drawing.Size(131, 22);
            this.btnToolMenuBar_TraCuu_Day.Text = "Dãy...";
            // 
            // btnToolMenuBar_TraCuu_KTX
            // 
            this.btnToolMenuBar_TraCuu_KTX.Image = ((System.Drawing.Image)(resources.GetObject("btnToolMenuBar_TraCuu_KTX.Image")));
            this.btnToolMenuBar_TraCuu_KTX.Name = "btnToolMenuBar_TraCuu_KTX";
            this.btnToolMenuBar_TraCuu_KTX.Size = new System.Drawing.Size(131, 22);
            this.btnToolMenuBar_TraCuu_KTX.Text = "Ký túc xá...";
            // 
            // XPExplorer
            // 
            this.XPExplorer.CanvasColor = System.Drawing.SystemColors.Control;
            this.XPExplorer.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.XPExplorer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.XPExplorer.Controls.Add(this.taskPane1);
            this.XPExplorer.Dock = System.Windows.Forms.DockStyle.Left;
            this.XPExplorer.Location = new System.Drawing.Point(169, 118);
            this.XPExplorer.Name = "XPExplorer";
            this.XPExplorer.Size = new System.Drawing.Size(202, 460);
            this.XPExplorer.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.XPExplorer.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.XPExplorer.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.XPExplorer.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.XPExplorer.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.XPExplorer.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.XPExplorer.Style.GradientAngle = 90;
            this.XPExplorer.TabIndex = 8;
            this.XPExplorer.TitleHeight = 15;
            this.XPExplorer.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.XPExplorer.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.XPExplorer.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.XPExplorer.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.XPExplorer.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.XPExplorer.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.XPExplorer.TitleStyle.GradientAngle = 90;
            this.XPExplorer.TitleText = " ";
            this.XPExplorer.Visible = false;
            // 
            // taskPane1
            // 
            this.taskPane1.AutoScroll = true;
            this.taskPane1.AutoScrollMargin = new System.Drawing.Size(12, 12);
            this.taskPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskPane1.Expandos.AddRange(new XPExplorerBar.Expando[] {
            this.expando1,
            this.expando2,
            this.expando3,
            this.expando4,
            this.expando5});
            this.taskPane1.Location = new System.Drawing.Point(0, 15);
            this.taskPane1.Name = "taskPane1";
            this.taskPane1.Size = new System.Drawing.Size(202, 445);
            this.taskPane1.TabIndex = 5;
            this.taskPane1.Text = "taskPane1";
            // 
            // expando1
            // 
            this.expando1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expando1.ExpandedHeight = 180;
            this.expando1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.expando1.Items.AddRange(new System.Windows.Forms.Control[] {
            this.taskXP_HienThi,
            this.taskXP_DangNhap,
            this.taskXP_DangXuat,
            this.taskXP_NguoiDung,
            this.taskXP_Thoat});
            this.expando1.Location = new System.Drawing.Point(12, 12);
            this.expando1.Name = "expando1";
            this.expando1.Size = new System.Drawing.Size(161, 180);
            this.expando1.TabIndex = 0;
            this.expando1.Text = "Hệ Thống";
            this.expando1.TitleImage = ((System.Drawing.Image)(resources.GetObject("expando1.TitleImage")));
            // 
            // taskXP_HienThi
            // 
            this.taskXP_HienThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_HienThi.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_HienThi.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_HienThi.Image")));
            this.taskXP_HienThi.Location = new System.Drawing.Point(16, 98);
            this.taskXP_HienThi.Name = "taskXP_HienThi";
            this.taskXP_HienThi.Size = new System.Drawing.Size(774, 16);
            this.taskXP_HienThi.TabIndex = 0;
            this.taskXP_HienThi.Text = "Hiển thị dạng Tab";
            this.taskXP_HienThi.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_HienThi.UseVisualStyleBackColor = false;
            this.taskXP_HienThi.Click += new System.EventHandler(this.taskItem14_Click_1);
            // 
            // taskXP_DangNhap
            // 
            this.taskXP_DangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_DangNhap.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_DangNhap.Image")));
            this.taskXP_DangNhap.Location = new System.Drawing.Point(16, 35);
            this.taskXP_DangNhap.Name = "taskXP_DangNhap";
            this.taskXP_DangNhap.Size = new System.Drawing.Size(774, 16);
            this.taskXP_DangNhap.TabIndex = 1;
            this.taskXP_DangNhap.Text = "Đăng nhập...";
            this.taskXP_DangNhap.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_DangNhap.UseVisualStyleBackColor = false;
            this.taskXP_DangNhap.Click += new System.EventHandler(this.taskXP_DangNhap_Click);
            // 
            // taskXP_DangXuat
            // 
            this.taskXP_DangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_DangXuat.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_DangXuat.Image")));
            this.taskXP_DangXuat.Location = new System.Drawing.Point(16, 57);
            this.taskXP_DangXuat.Name = "taskXP_DangXuat";
            this.taskXP_DangXuat.Size = new System.Drawing.Size(774, 16);
            this.taskXP_DangXuat.TabIndex = 2;
            this.taskXP_DangXuat.Text = "Đăng xuất";
            this.taskXP_DangXuat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_DangXuat.UseVisualStyleBackColor = false;
            // 
            // taskXP_NguoiDung
            // 
            this.taskXP_NguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_NguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_NguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_NguoiDung.Image")));
            this.taskXP_NguoiDung.Location = new System.Drawing.Point(16, 79);
            this.taskXP_NguoiDung.Name = "taskXP_NguoiDung";
            this.taskXP_NguoiDung.Size = new System.Drawing.Size(774, 13);
            this.taskXP_NguoiDung.TabIndex = 3;
            this.taskXP_NguoiDung.Text = "Người dùng...";
            this.taskXP_NguoiDung.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_NguoiDung.UseVisualStyleBackColor = false;
            this.taskXP_NguoiDung.Click += new System.EventHandler(this.taskXP_NguoiDung_Click);
            // 
            // taskXP_Thoat
            // 
            this.taskXP_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_Thoat.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_Thoat.Image")));
            this.taskXP_Thoat.Location = new System.Drawing.Point(16, 120);
            this.taskXP_Thoat.Name = "taskXP_Thoat";
            this.taskXP_Thoat.Size = new System.Drawing.Size(774, 17);
            this.taskXP_Thoat.TabIndex = 4;
            this.taskXP_Thoat.Text = "Thoát";
            this.taskXP_Thoat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_Thoat.UseVisualStyleBackColor = false;
            // 
            // expando2
            // 
            this.expando2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expando2.ExpandedHeight = 130;
            this.expando2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.expando2.Items.AddRange(new System.Windows.Forms.Control[] {
            this.taskXP_ThongTinSinhVien,
            this.taskXP_DiemDanh,
            this.taskXP_ThongTinPhong,
            this.taskXP_HoatDongSinhVien});
            this.expando2.Location = new System.Drawing.Point(12, 204);
            this.expando2.Name = "expando2";
            this.expando2.Size = new System.Drawing.Size(161, 130);
            this.expando2.TabIndex = 1;
            this.expando2.Text = "Quản lý";
            this.expando2.TitleImage = ((System.Drawing.Image)(resources.GetObject("expando2.TitleImage")));
            // 
            // taskXP_ThongTinSinhVien
            // 
            this.taskXP_ThongTinSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_ThongTinSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_ThongTinSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_ThongTinSinhVien.Image")));
            this.taskXP_ThongTinSinhVien.Location = new System.Drawing.Point(16, 35);
            this.taskXP_ThongTinSinhVien.Name = "taskXP_ThongTinSinhVien";
            this.taskXP_ThongTinSinhVien.Size = new System.Drawing.Size(1385, 16);
            this.taskXP_ThongTinSinhVien.TabIndex = 0;
            this.taskXP_ThongTinSinhVien.Text = "Thông tin Sinh viên...";
            this.taskXP_ThongTinSinhVien.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_ThongTinSinhVien.UseVisualStyleBackColor = false;
            // 
            // taskXP_DiemDanh
            // 
            this.taskXP_DiemDanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_DiemDanh.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_DiemDanh.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_DiemDanh.Image")));
            this.taskXP_DiemDanh.Location = new System.Drawing.Point(16, 57);
            this.taskXP_DiemDanh.Name = "taskXP_DiemDanh";
            this.taskXP_DiemDanh.Size = new System.Drawing.Size(1381, 16);
            this.taskXP_DiemDanh.TabIndex = 1;
            this.taskXP_DiemDanh.Text = "Điểm danh...";
            this.taskXP_DiemDanh.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_DiemDanh.UseVisualStyleBackColor = false;
            // 
            // taskXP_ThongTinPhong
            // 
            this.taskXP_ThongTinPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_ThongTinPhong.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_ThongTinPhong.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_ThongTinPhong.Image")));
            this.taskXP_ThongTinPhong.Location = new System.Drawing.Point(16, 79);
            this.taskXP_ThongTinPhong.Name = "taskXP_ThongTinPhong";
            this.taskXP_ThongTinPhong.Size = new System.Drawing.Size(1381, 16);
            this.taskXP_ThongTinPhong.TabIndex = 2;
            this.taskXP_ThongTinPhong.Text = "Thông tin Phòng...";
            this.taskXP_ThongTinPhong.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_ThongTinPhong.UseVisualStyleBackColor = false;
            // 
            // taskXP_HoatDongSinhVien
            // 
            this.taskXP_HoatDongSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_HoatDongSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_HoatDongSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_HoatDongSinhVien.Image")));
            this.taskXP_HoatDongSinhVien.Location = new System.Drawing.Point(16, 101);
            this.taskXP_HoatDongSinhVien.Name = "taskXP_HoatDongSinhVien";
            this.taskXP_HoatDongSinhVien.Size = new System.Drawing.Size(1382, 16);
            this.taskXP_HoatDongSinhVien.TabIndex = 3;
            this.taskXP_HoatDongSinhVien.Text = "Hoạt đông Sinh viên...";
            this.taskXP_HoatDongSinhVien.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_HoatDongSinhVien.UseVisualStyleBackColor = false;
            // 
            // expando3
            // 
            this.expando3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expando3.Collapsed = true;
            this.expando3.ExpandedHeight = 90;
            this.expando3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.expando3.Items.AddRange(new System.Windows.Forms.Control[] {
            this.taskXP_TraCuuSinhVien,
            this.taskXP_TraCuuPhong});
            this.expando3.Location = new System.Drawing.Point(12, 346);
            this.expando3.Name = "expando3";
            this.expando3.Size = new System.Drawing.Size(161, 32);
            this.expando3.TabIndex = 2;
            this.expando3.Text = "Tra cứu";
            this.expando3.TitleImage = ((System.Drawing.Image)(resources.GetObject("expando3.TitleImage")));
            // 
            // taskXP_TraCuuSinhVien
            // 
            this.taskXP_TraCuuSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_TraCuuSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_TraCuuSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_TraCuuSinhVien.Image")));
            this.taskXP_TraCuuSinhVien.Location = new System.Drawing.Point(8, 42);
            this.taskXP_TraCuuSinhVien.Name = "taskXP_TraCuuSinhVien";
            this.taskXP_TraCuuSinhVien.Size = new System.Drawing.Size(1406, 16);
            this.taskXP_TraCuuSinhVien.TabIndex = 0;
            this.taskXP_TraCuuSinhVien.Text = "Tra cứu Sinh viên...";
            this.taskXP_TraCuuSinhVien.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_TraCuuSinhVien.UseVisualStyleBackColor = false;
            // 
            // taskXP_TraCuuPhong
            // 
            this.taskXP_TraCuuPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_TraCuuPhong.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_TraCuuPhong.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_TraCuuPhong.Image")));
            this.taskXP_TraCuuPhong.Location = new System.Drawing.Point(8, 65);
            this.taskXP_TraCuuPhong.Name = "taskXP_TraCuuPhong";
            this.taskXP_TraCuuPhong.Size = new System.Drawing.Size(1435, 19);
            this.taskXP_TraCuuPhong.TabIndex = 1;
            this.taskXP_TraCuuPhong.Text = "Tra cứu Phòng...";
            this.taskXP_TraCuuPhong.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_TraCuuPhong.UseVisualStyleBackColor = false;
            // 
            // expando4
            // 
            this.expando4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expando4.Collapsed = true;
            this.expando4.ExpandedHeight = 60;
            this.expando4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.expando4.Items.AddRange(new System.Windows.Forms.Control[] {
            this.taskXP_TroGiup});
            this.expando4.Location = new System.Drawing.Point(12, 390);
            this.expando4.Name = "expando4";
            this.expando4.Size = new System.Drawing.Size(161, 32);
            this.expando4.TabIndex = 3;
            this.expando4.Text = "Trợ giúp";
            this.expando4.TitleImage = ((System.Drawing.Image)(resources.GetObject("expando4.TitleImage")));
            // 
            // taskXP_TroGiup
            // 
            this.taskXP_TroGiup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_TroGiup.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_TroGiup.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_TroGiup.Image")));
            this.taskXP_TroGiup.Location = new System.Drawing.Point(16, 40);
            this.taskXP_TroGiup.Name = "taskXP_TroGiup";
            this.taskXP_TroGiup.Size = new System.Drawing.Size(1435, 16);
            this.taskXP_TroGiup.TabIndex = 0;
            this.taskXP_TroGiup.Text = "Trợ giúp...";
            this.taskXP_TroGiup.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_TroGiup.UseVisualStyleBackColor = false;
            // 
            // expando5
            // 
            this.expando5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expando5.Collapsed = true;
            this.expando5.ExpandedHeight = 135;
            this.expando5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.expando5.Items.AddRange(new System.Windows.Forms.Control[] {
            this.taskXP_Thang,
            this.taskXP_HoatDong,
            this.taskXP_DanhGia,
            this.taskXP_XepLoai});
            this.expando5.Location = new System.Drawing.Point(12, 434);
            this.expando5.Name = "expando5";
            this.expando5.Size = new System.Drawing.Size(161, 32);
            this.expando5.TabIndex = 4;
            this.expando5.Text = "Danh mục";
            this.expando5.TitleImage = ((System.Drawing.Image)(resources.GetObject("expando5.TitleImage")));
            // 
            // taskXP_Thang
            // 
            this.taskXP_Thang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_Thang.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_Thang.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_Thang.Image")));
            this.taskXP_Thang.Location = new System.Drawing.Point(16, 37);
            this.taskXP_Thang.Name = "taskXP_Thang";
            this.taskXP_Thang.Size = new System.Drawing.Size(1435, 18);
            this.taskXP_Thang.TabIndex = 0;
            this.taskXP_Thang.Text = "Tháng...";
            this.taskXP_Thang.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_Thang.UseVisualStyleBackColor = false;
            // 
            // taskXP_HoatDong
            // 
            this.taskXP_HoatDong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_HoatDong.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_HoatDong.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_HoatDong.Image")));
            this.taskXP_HoatDong.Location = new System.Drawing.Point(16, 60);
            this.taskXP_HoatDong.Name = "taskXP_HoatDong";
            this.taskXP_HoatDong.Size = new System.Drawing.Size(1435, 17);
            this.taskXP_HoatDong.TabIndex = 1;
            this.taskXP_HoatDong.Text = "Hoạt động...";
            this.taskXP_HoatDong.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_HoatDong.UseVisualStyleBackColor = false;
            // 
            // taskXP_DanhGia
            // 
            this.taskXP_DanhGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_DanhGia.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_DanhGia.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_DanhGia.Image")));
            this.taskXP_DanhGia.Location = new System.Drawing.Point(16, 83);
            this.taskXP_DanhGia.Name = "taskXP_DanhGia";
            this.taskXP_DanhGia.Size = new System.Drawing.Size(1435, 18);
            this.taskXP_DanhGia.TabIndex = 2;
            this.taskXP_DanhGia.Text = "Đánh giá...";
            this.taskXP_DanhGia.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_DanhGia.UseVisualStyleBackColor = false;
            // 
            // taskXP_XepLoai
            // 
            this.taskXP_XepLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskXP_XepLoai.BackColor = System.Drawing.Color.Transparent;
            this.taskXP_XepLoai.Image = ((System.Drawing.Image)(resources.GetObject("taskXP_XepLoai.Image")));
            this.taskXP_XepLoai.Location = new System.Drawing.Point(16, 107);
            this.taskXP_XepLoai.Name = "taskXP_XepLoai";
            this.taskXP_XepLoai.Size = new System.Drawing.Size(1435, 16);
            this.taskXP_XepLoai.TabIndex = 3;
            this.taskXP_XepLoai.Text = "Xếp loại...";
            this.taskXP_XepLoai.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskXP_XepLoai.UseVisualStyleBackColor = false;
            // 
            // textBoxItem1
            // 
            this.textBoxItem1.Name = "textBoxItem1";
            this.textBoxItem1.TextBoxWidth = 100;
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnFull,
            this.btnNormal});
            this.buttonItem1.Text = "buttonItem1";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // btnFull
            // 
            this.btnFull.Image = ((System.Drawing.Image)(resources.GetObject("btnFull.Image")));
            this.btnFull.ImagePaddingHorizontal = 8;
            this.btnFull.Name = "btnFull";
            this.btnFull.Text = "Bung rộng";
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.ImagePaddingHorizontal = 8;
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Text = "Thu hẹp";
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.Location = new System.Drawing.Point(458, 371);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(88, 25);
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.contextMenuBar1.TabIndex = 10;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // contextMenuBar2
            // 
            this.contextMenuBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.contextMenuBar2.Location = new System.Drawing.Point(424, 191);
            this.contextMenuBar2.Name = "contextMenuBar2";
            this.contextMenuBar2.Size = new System.Drawing.Size(84, 25);
            this.contextMenuBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.contextMenuBar2.TabIndex = 12;
            this.contextMenuBar2.TabStop = false;
            this.contextMenuBar2.Text = "contextMenuBar2";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 578);
            this.contextMenuBar2.SetContextMenuEx(this, this.buttonItem1);
            this.Controls.Add(this.contextMenuBar2);
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.XPExplorer);
            this.Controls.Add(this.toolMenuBar);
            this.Controls.Add(this.tabExplorer);
            this.Controls.Add(this.tabMainTool);
            this.Controls.Add(this.mnuMainMenu);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainForm";
            this.Text = "Quan ly Ky tuc xa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabMainTool)).EndInit();
            this.tabMainTool.ResumeLayout(false);
            this.tabpQLDay.ResumeLayout(false);
            this.tabpQLPhong.ResumeLayout(false);
            this.tabpQLSV.ResumeLayout(false);
            this.tabpHeThong.ResumeLayout(false);
            this.tabpTraCuu.ResumeLayout(false);
            this.tabpTroGiup.ResumeLayout(false);
            this.tabExplorer.ResumeLayout(false);
            this.expandablePanel6.ResumeLayout(false);
            this.expandablePanel5.ResumeLayout(false);
            this.expandablePanel4.ResumeLayout(false);
            this.expandablePanel3.ResumeLayout(false);
            this.expandablePanel2.ResumeLayout(false);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.toolMenuBar.ResumeLayout(false);
            this.toolMenuBar.PerformLayout();
            this.XPExplorer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskPane1)).EndInit();
            this.taskPane1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expando1)).EndInit();
            this.expando1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expando2)).EndInit();
            this.expando2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expando3)).EndInit();
            this.expando3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expando4)).EndInit();
            this.expando4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expando5)).EndInit();
            this.expando5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabMainTool;
        private DevComponents.DotNetBar.TabControlPanel tabpHeThong;
        private DevComponents.DotNetBar.TabItem tabHeThong;
        private DevComponents.DotNetBar.TabControlPanel tabpQLDay;
        private DevComponents.DotNetBar.TabItem tabQLDay;
        private DevComponents.DotNetBar.TabControlPanel tabpQLPhong;
        private DevComponents.DotNetBar.TabItem tabQLPhong;
        private DevComponents.DotNetBar.TabControlPanel tabpQLSV;
        private DevComponents.DotNetBar.TabItem tabQLSV;
        private DevComponents.DotNetBar.TabControlPanel tabpTraCuu;
        private DevComponents.DotNetBar.TabItem tabTraCuu;
        private DevComponents.DotNetBar.TabControlPanel tabpTroGiup;
        private DevComponents.DotNetBar.TabItem tabTroGiup;
        private DevComponents.DotNetBar.RibbonBar barQLSV_SinhVien;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_ThemSinhVien;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_SuaSinhVien;
        private DevComponents.DotNetBar.ExpandablePanel tabExplorer;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel3;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel4;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_DangNhap;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_DangXuat;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_Thoat;
        private DevComponents.DotNetBar.RibbonBar barQLSV_DanhGia;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_DanhGia;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_KhenThuong;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_KyLuat;
        private DevComponents.DotNetBar.RibbonBar barQLSV_TraCuu;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_TraCuu_Phong1;
        private DevComponents.DotNetBar.ComboBoxItem cmbQLSV_TraCuu_Phong;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_TraCuu_Phong;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_TraCuu_Day1;
        private DevComponents.DotNetBar.ComboBoxItem cmbQLSV_TraCuu_Day;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_TraCuu_Day;
        private DevComponents.DotNetBar.RibbonBar barQLPhong_DanhGiaPhong;
        private DevComponents.DotNetBar.RibbonBar barQLPhong_Phong;
        private DevComponents.DotNetBar.RibbonBar barQlTraCuu_SinhVien;
        private DevComponents.DotNetBar.RibbonBar barQlTraCuu_KTX;
        private DevComponents.DotNetBar.RibbonBar barQlTraCuu_Day;
        private DevComponents.DotNetBar.RibbonBar barQlTraCuu_Phong;
        private DevComponents.DotNetBar.RibbonBar barQlDay_ThongKeDay;
        private DevComponents.DotNetBar.RibbonBar barQlDay_Day;
        private DevComponents.DotNetBar.RibbonBar barQlTroGiup_TroGiup;
        private XPExplorerBar.TaskItem taskTab_DangNhap;
        private XPExplorerBar.TaskItem taskTab_TraCuuSinhVien;
        private XPExplorerBar.TaskItem taskTab_ThongTinPhong;
        private XPExplorerBar.TaskItem taskTab_DiemDanh;
        private XPExplorerBar.TaskItem taskTab_ThongTinSinhVien;
        private XPExplorerBar.TaskItem taskTab_Thoat;
        private XPExplorerBar.TaskItem taskTab_DangXuat;
        private XPExplorerBar.TaskItem taskTab_TraCuuPhong;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel5;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel6;
        private XPExplorerBar.TaskItem taskTab_NguoiDung;
        private DevComponents.DotNetBar.RibbonBar barQLSV_QuanLy;
        private DevComponents.DotNetBar.ItemContainer cntQLSV_TraCuu;
        private DevComponents.DotNetBar.RibbonBar barHeThong_QLDuLieu;
        private DevComponents.DotNetBar.ItemContainer itemContainer8;
        private DevComponents.DotNetBar.ButtonItem buttonItem14;
        private DevComponents.DotNetBar.ItemContainer itemContainer9;
        private DevComponents.DotNetBar.ItemContainer itemContainer10;
        private DevComponents.DotNetBar.ItemContainer itemContainer11;
        private DevComponents.DotNetBar.ItemContainer itemContainer12;
        private DevComponents.DotNetBar.ItemContainer itemContainer13;
        private DevComponents.DotNetBar.ItemContainer cntQLSV_DanhGia1;
        private DevComponents.DotNetBar.ItemContainer cntQLSV_DanhGia2;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_HoatDong;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_QuanLy_ChuyenPhong;
        private DevComponents.DotNetBar.RibbonBar barHeThong_QLDanhMuc;
        private DevComponents.DotNetBar.RibbonBar barHeThong_NguoiDung;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.Editors.ComboItem comboItem10;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_NguoiDung;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_CBQL;
        private DevComponents.DotNetBar.ItemContainer cntHeThong_NguoiDung;
        private DevComponents.DotNetBar.TextBoxItem textBoxItem1;
        private DevComponents.DotNetBar.LabelItem lblHeThong_NguoiDung;
        private DevComponents.DotNetBar.LabelItem labelItem6;
        private DevComponents.DotNetBar.ItemContainer itemContainer17;
        private DevComponents.DotNetBar.ComboBoxItem comboBoxItem4;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem labelItem7;
        private DevComponents.DotNetBar.ItemContainer itemContainer18;
        private DevComponents.DotNetBar.ComboBoxItem comboBoxItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem37;
        private DevComponents.DotNetBar.ButtonItem buttonItem36;
        private DevComponents.DotNetBar.LabelItem labelItem8;
        private DevComponents.DotNetBar.ItemContainer itemContainer19;
        private DevComponents.DotNetBar.ComboBoxItem comboBoxItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem38;
        private DevComponents.DotNetBar.ItemContainer cntHeThong_QLDanhMuc1;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_NgayThangNam;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_NamHoc;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_HocKy;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_QuocTich;
        private DevComponents.DotNetBar.ButtonItem btn_HeThong_TonGiao;
        private DevComponents.DotNetBar.ButtonItem btn_HeThong_DanToc;
        private DevComponents.DotNetBar.ButtonItem btn_HeThong_QuocTich;
        private DevComponents.DotNetBar.ItemContainer cntHeThong_QLDanhMuc2;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_KhenThuongKyLuat;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_KyLuat;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_KhenThuong;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_DanhGia;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_DanhGiaXepLoai;
        private DevComponents.DotNetBar.ButtonItem buttonItem28;
        private DevComponents.DotNetBar.ButtonItem buttonItem27;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_HoatDong;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_SaoLuu;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_PhucHoi;
        private DevComponents.DotNetBar.RibbonBar barQLSV_ThongKe;
        private DevComponents.DotNetBar.LabelItem lblQLSV_ThongKe;
        private DevComponents.DotNetBar.ButtonItem btnQLPhong_ThemPhong;
        private DevComponents.DotNetBar.ButtonItem btn_Day_ThemDay;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDay;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuu;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private DevComponents.DotNetBar.ItemContainer cntQLSV_Thongke1;
        private DevComponents.DotNetBar.ItemContainer cntQLSV_Thongke2;
        private DevComponents.DotNetBar.LabelItem lblQLSV_ThongKe1;
        private DevComponents.DotNetBar.ComboBoxItem cmbQLSV_ThongKe;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_ThongKe;
        private DevComponents.DotNetBar.TextBoxItem textBoxItem5;
        private DevComponents.DotNetBar.ItemContainer cntQLPhong_DanhGiaPhong1;
        private DevComponents.DotNetBar.ButtonItem btnQLPhong_DanhGiaPhong_NhapDiem;
        private DevComponents.DotNetBar.ItemContainer cntQLPhong_DanhGiaPhong2;
        private DevComponents.DotNetBar.LabelItem lblQLPhong_DanhGiaPhong;
        private DevComponents.DotNetBar.ComboBoxItem cmbQLPhong_DanhGiaPhong;
        private DevComponents.DotNetBar.TextBoxItem textBoxItem7;
        private DevComponents.DotNetBar.RibbonBar barQLPhong_ThongKe;
        private XPExplorerBar.TaskItem taskTab_HienThi;
        private System.Windows.Forms.ToolStrip toolMenuBar;
        private DevComponents.DotNetBar.ExpandablePanel XPExplorer;
        private XPExplorerBar.TaskPane taskPane1;
        private XPExplorerBar.Expando expando1;
        private XPExplorerBar.TaskItem taskXP_HienThi;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong_DangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong_NguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong_tab;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong_Thoat;
        private DevComponents.DotNetBar.LabelItem labelItem14;
        private DevComponents.DotNetBar.ItemContainer itemContainer30;
        private DevComponents.DotNetBar.ItemContainer itemContainer31;
        private DevComponents.DotNetBar.ItemContainer itemContainer32;
        private DevComponents.DotNetBar.LabelItem labelItem16;
        private DevComponents.DotNetBar.ButtonItem buttonItem60;
        private DevComponents.DotNetBar.ComboBoxItem cmb_QLPHG_ThongKe_Phong;
        private DevComponents.DotNetBar.ItemContainer itemContainer39;
        private DevComponents.DotNetBar.LabelItem labelItem24;
        private DevComponents.DotNetBar.ItemContainer itemContainer37;
        private DevComponents.DotNetBar.LabelItem labelItem22;
        private DevComponents.DotNetBar.ItemContainer itemContainer35;
        private DevComponents.DotNetBar.LabelItem labelItem19;
        private DevComponents.DotNetBar.ItemContainer itemContainer16;
        private DevComponents.DotNetBar.ItemContainer itemContainer33;
        private DevComponents.DotNetBar.LabelItem labelItem18;
        private DevComponents.DotNetBar.ComboBoxItem comboBoxItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem35;
        private System.Windows.Forms.ToolStripButton btnMainTool_DangNhap;
        private System.Windows.Forms.ToolStripButton btnMainTool_DangXuat;
        private System.Windows.Forms.ToolStripButton btnMainTool_Thoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem ngangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docToolStripMenuItem;
        private DevComponents.DotNetBar.RibbonBar barQlDay_ThongKeKTX;
        private DevComponents.DotNetBar.ButtonItem buttonItem61;
        private DevComponents.DotNetBar.ButtonItem btnGioiThieu;
        private DevComponents.DotNetBar.LabelItem labelItem28;
        private DevComponents.DotNetBar.ItemContainer itemContainer44;
        private DevComponents.DotNetBar.ItemContainer itemContainer45;
        private DevComponents.DotNetBar.ItemContainer itemContainer46;
        private DevComponents.DotNetBar.LabelItem labelItem30;
        private DevComponents.DotNetBar.ComboBoxItem comboBoxItem17;
        private DevComponents.DotNetBar.ButtonItem buttonItem63;
        private DevComponents.DotNetBar.LabelItem labelItem25;
        private DevComponents.DotNetBar.ItemContainer itemContainer41;
        private DevComponents.DotNetBar.ItemContainer itemContainer42;
        private DevComponents.DotNetBar.ItemContainer itemContainer43;
        private DevComponents.DotNetBar.LabelItem labelItem27;
        private DevComponents.DotNetBar.ComboBoxItem comboBoxItem15;
        private DevComponents.DotNetBar.ButtonItem buttonItem62;
        private XPExplorerBar.TaskItem taskXP_DangNhap;
        private XPExplorerBar.TaskItem taskXP_DangXuat;
        private XPExplorerBar.TaskItem taskXP_NguoiDung;
        private XPExplorerBar.TaskItem taskXP_Thoat;
        private XPExplorerBar.Expando expando2;
        private XPExplorerBar.TaskItem taskXP_ThongTinSinhVien;
        private XPExplorerBar.TaskItem taskXP_DiemDanh;
        private XPExplorerBar.TaskItem taskXP_ThongTinPhong;
        private XPExplorerBar.Expando expando3;
        private XPExplorerBar.TaskItem taskTab_HoatDongSinhVien;
        private XPExplorerBar.TaskItem taskXP_HoatDongSinhVien;
        private XPExplorerBar.TaskItem taskXP_TraCuuSinhVien;
        private XPExplorerBar.TaskItem taskXP_TraCuuPhong;
        private XPExplorerBar.Expando expando4;
        private XPExplorerBar.Expando expando5;
        private XPExplorerBar.TaskItem taskXP_Thang;
        private XPExplorerBar.TaskItem taskXP_HoatDong;
        private XPExplorerBar.TaskItem taskXP_DanhGia;
        private XPExplorerBar.TaskItem taskXP_XepLoai;
        private XPExplorerBar.TaskItem taskTab_XepLoai;
        private XPExplorerBar.TaskItem taskTab_DanhGia;
        private XPExplorerBar.TaskItem taskTab_HoatDong;
        private XPExplorerBar.TaskItem taskTab_TroGiup;
        private XPExplorerBar.TaskItem taskXP_TroGiup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnMainTool_ThemSinhVien;
        private System.Windows.Forms.ToolStripButton btnMainTool_SuaSinhVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_ThemSV;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_SuaSV;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_XoaSinhVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_QuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_DiemDanh;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_ChuyenPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_DanhGia1;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_HoatDong;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_DanhGia;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_TraCuu;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_KhenThuong;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSV_KyLuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhong_ThemPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhong_SuaPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhong_XoaPhong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhong_DanhGia;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhong_KWDien;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhong_ThuTien;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhong_ThongKe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhong_TienDien;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhong_TienPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDay_ThemDay;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDay_SuaDay;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDay_XoaDay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDay_ThemKTX;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDay_SuaKTX;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDay_XoaKTX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDay_ThongKeDay;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDay_ThongKeKTX;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDay_TraCuu;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDay_TraCuuDay;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDay_TraCuuKTX;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuu_SinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuu_Phong;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuu_Day;
        private System.Windows.Forms.ToolStripMenuItem mnuTraCuu_KTX;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup_TroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup_GioiThieu;
        private DevComponents.DotNetBar.SuperTooltip sprHuongDan;
        private DevComponents.DotNetBar.RibbonBar barHeThong_HienThi;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_HienThi;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_Ngang;
        private DevComponents.DotNetBar.ButtonItem btnHeThong_Doc;
        private System.Windows.Forms.ToolStripSplitButton btnMainTool_TraCuu;
        private System.Windows.Forms.ToolStripMenuItem btnToolMenuBar_TraCuu_SinhVien;
        private System.Windows.Forms.ToolStripMenuItem btnToolMenuBar_TraCuu_Phong;
        private System.Windows.Forms.ToolStripMenuItem btnToolMenuBar_TraCuu_Day;
        private System.Windows.Forms.ToolStripMenuItem btnToolMenuBar_TraCuu_KTX;




        #region Sinh Vien

        /// <summary>
        /// Them Mot Sinh vien moi
        /// </summary>
        public void ThemSinhVien()
        {
            if (FormChung.themSinhVien == null || FormChung.themSinhVien.IsDisposed)
                FormChung.themSinhVien = new frmThemSinhVien();
            FormChung.themSinhVien.MdiParent = this;
            FormChung.themSinhVien.Show();
            FormChung.themSinhVien.Focus();
        }
        public void SuaSinhVien()
        {
            if (FormChung.suaSinhVien == null || FormChung.suaSinhVien.IsDisposed)
                FormChung.suaSinhVien = new frmSuaSinhVien();
            FormChung.suaSinhVien.MdiParent = this;
            FormChung.suaSinhVien.Show();
            FormChung.suaSinhVien.Focus();
        }
        public void XoaSinhVien()
        {
            if (FormChung.xoaSinhVien == null || FormChung.xoaSinhVien.IsDisposed)
                FormChung.xoaSinhVien = new frmXoaSinhVien();
            FormChung.xoaSinhVien.MdiParent = this;
            FormChung.xoaSinhVien.Show();
            FormChung.xoaSinhVien.Focus();

        }
        public void TraCuuSinhVien()
        {
            if (FormChung.traCuuSinhVien == null || FormChung.traCuuSinhVien.IsDisposed)
                FormChung.traCuuSinhVien = new frmTraCuuSinhVien();
            FormChung.traCuuSinhVien.MdiParent = this;
            FormChung.traCuuSinhVien.Show();
            FormChung.traCuuSinhVien.Focus();
        }
        public void TraCuuSinhVienTheoPhong(string tenphong)
        {
            if (FormChung.traCuuSinhVien == null || FormChung.traCuuSinhVien.IsDisposed)
                FormChung.traCuuSinhVien = new frmTraCuuSinhVien();
            FormChung.traCuuSinhVien.MdiParent = this;
            FormChung.traCuuSinhVien.TraCuuTheoPhong(tenphong);
            FormChung.traCuuSinhVien.Show();
            FormChung.traCuuSinhVien.Focus();
        }
        public void TraCuuSinhVienTheoDay(string tenday)
        {
            if (FormChung.traCuuSinhVien == null || FormChung.traCuuSinhVien.IsDisposed)
                FormChung.traCuuSinhVien = new frmTraCuuSinhVien();
            FormChung.traCuuSinhVien.MdiParent = this;
            FormChung.traCuuSinhVien.TraCuuTheoDay(tenday);
            FormChung.traCuuSinhVien.Show();
            FormChung.traCuuSinhVien.Focus();
        }
        public void ChuyenPhongSinhVien()
        {
            if (FormChung.chuyenPhongSinhVien == null || FormChung.chuyenPhongSinhVien.IsDisposed)
                FormChung.chuyenPhongSinhVien = new frmChuyenPhongSinhVien();
            FormChung.chuyenPhongSinhVien.MdiParent = this;
            FormChung.chuyenPhongSinhVien.Show();
            FormChung.chuyenPhongSinhVien.Focus();
        }
        public void XepPhongSinhVien()
        {
            if (FormChung.xepphong == null || FormChung.xepphong.IsDisposed)
                FormChung.xepphong = new SinhVien.frmXepPhongSinhVien();
            FormChung.xepphong.MdiParent = this;
            FormChung.xepphong.Show();
            FormChung.xepphong.Focus();
        }
        public void DanhGiaSinhVien()
        {
            if (FormChung.danhGiaSinhVien == null || FormChung.danhGiaSinhVien.IsDisposed)
                FormChung.danhGiaSinhVien = new frmDanhGiaSinhVien();
            FormChung.danhGiaSinhVien.MdiParent = this;
            FormChung.danhGiaSinhVien.Show();
            FormChung.danhGiaSinhVien.Focus();
        }
        public void KyLuatSinhVien()
        {
            if (FormChung.kyLuatSinhVien == null || FormChung.kyLuatSinhVien.IsDisposed)
                FormChung.kyLuatSinhVien = new frmKyLuatSinhVien();
            FormChung.kyLuatSinhVien.MdiParent = this;
            FormChung.kyLuatSinhVien.Show();
            FormChung.kyLuatSinhVien.Focus();
        }
        public void DiemDanhSinhVien()
        {
            if (FormChung.diemDanhSinhVien == null || FormChung.diemDanhSinhVien.IsDisposed)
                FormChung.diemDanhSinhVien = new frmDiemDanhSinhVien();
            FormChung.diemDanhSinhVien.MdiParent = this;
            FormChung.diemDanhSinhVien.Show();
            FormChung.diemDanhSinhVien.Focus();
        }

        public void ThongKeSinhVienThuocPhong()
        {
            if (FormChung.thongKeSinhVienThuocPhong == null || FormChung.thongKeSinhVienThuocPhong.IsDisposed)
                FormChung.thongKeSinhVienThuocPhong = new QLKTX.Phong.frmThongKeSinhVienThuocPhong();
            FormChung.thongKeSinhVienThuocPhong.MdiParent = this;
            FormChung.thongKeSinhVienThuocPhong.Show();
            FormChung.thongKeSinhVienThuocPhong.Focus();
        }
        public void ThongKeSinhVienThuocDay()
        {
            if (FormChung.thongKeSinhVienThuocDay == null || FormChung.thongKeSinhVienThuocDay.IsDisposed)
                FormChung.thongKeSinhVienThuocDay = new QLKTX.Day.frmThongKeSinhVienThuocDay();
            FormChung.thongKeSinhVienThuocDay.MdiParent = this;
            FormChung.thongKeSinhVienThuocDay.Show();
            FormChung.thongKeSinhVienThuocDay.Focus();
        }
        public void ThongKeSinhVienThuocKTX()
        {
            if (FormChung.thongKeSinhVienThuocKTX == null || FormChung.thongKeSinhVienThuocKTX.IsDisposed)
                FormChung.thongKeSinhVienThuocKTX = new QLKTX.KTX.frmThongKeSinhVienThuocKTX();
            FormChung.thongKeSinhVienThuocKTX.MdiParent = this;
            FormChung.thongKeSinhVienThuocKTX.Show();
            FormChung.thongKeSinhVienThuocKTX.Focus();
        }
        
        #endregion

        #region He Thong
        public void DangXuat()
        {
            //MessageBox.Show("Dang xuat");
            VoHieuHoa();
            foreach (Form frm in this.MdiChildren)
                frm.Dispose();
        }
        public void SaoLuu()
        {
            if (FormChung.backup == null || FormChung.backup.IsDisposed)
                FormChung.backup = new frmBackup();
            FormChung.backup.MdiParent = this;
            FormChung.backup.Show();
            FormChung.backup.Focus();
        }
        public void PhucHoi()
        {
            if (FormChung.restore == null || FormChung.restore.IsDisposed)
                FormChung.restore = new frmRestore();
            FormChung.restore.MdiParent = this;
            FormChung.restore.Show();
            FormChung.restore.Focus();
            Application.Exit();
        }

        public void NamHoc()
        {
            if (FormChung.namHoc == null || FormChung.namHoc.IsDisposed)
                FormChung.namHoc = new frmNamHoc();
            FormChung.namHoc.MdiParent = this;
            FormChung.namHoc.Show();
            FormChung.namHoc.Focus();
        }
        public void HocKy()
        {
            if (FormChung.hocKy == null || FormChung.hocKy.IsDisposed)
                FormChung.hocKy = new frmHocKi();
            FormChung.hocKy.MdiParent = this;
            FormChung.hocKy.Show();
            FormChung.hocKy.Focus();
            FormChung.hocKy.Focus();
        }
        public void DanToc()
        {
            if (FormChung.dantoc == null || FormChung.dantoc.IsDisposed)
                FormChung.dantoc = new frmDanToc();
            FormChung.dantoc.MdiParent = this;
            FormChung.dantoc.Show();
            FormChung.dantoc.Focus();
            FormChung.dantoc.Focus();
        }
        public void TonGiao()
        {
            if (FormChung.tongiao == null || FormChung.tongiao.IsDisposed)
                FormChung.tongiao = new frmTonGiao();
            FormChung.tongiao.MdiParent = this;
            FormChung.tongiao.Show();
            FormChung.tongiao.Focus();
            FormChung.tongiao.Focus();
        }
        public void QuocTich()
        {
            if (FormChung.quoctich == null || FormChung.quoctich.IsDisposed)
                FormChung.quoctich = new frmQuocTich();
            FormChung.quoctich.MdiParent = this;
            FormChung.quoctich.Show();
            FormChung.quoctich.Focus();
            FormChung.quoctich.Focus();
        }

        public void CanBo()
        {
            if (FormChung.canbo == null || FormChung.canbo.IsDisposed)
                FormChung.canbo = new frmCanBo();
            FormChung.canbo.MdiParent = this;
            FormChung.canbo.Show();
            FormChung.canbo.Focus();            
        }
        public void NguoiDung()
        {
            if (FormChung.nguoidung == null || FormChung.nguoidung.IsDisposed)
                FormChung.nguoidung = new frmNguoiDung();
            FormChung.nguoidung.MdiParent = this;
            FormChung.nguoidung.Show();
            FormChung.nguoidung.Focus();
        }
        public void HoatDong()
        {
            if (FormChung.hoatdong == null || FormChung.hoatdong.IsDisposed)
                FormChung.hoatdong = new QLKTX.Dialog.DiaLog_HoatDong();
            FormChung.hoatdong.MdiParent = this;
            FormChung.hoatdong.FormBorderStyle = FormBorderStyle.Sizable;
            FormChung.hoatdong.Show();
            FormChung.hoatdong.Focus();
           
        }
        public void HoatDongSinhVien()
        {
            if (FormChung.hoatdongsinhvien == null || FormChung.hoatdongsinhvien.IsDisposed)
                FormChung.hoatdongsinhvien = new frmHoatDongSinhVien();
            FormChung.hoatdongsinhvien.MdiParent = this;
            FormChung.hoatdongsinhvien.FormBorderStyle = FormBorderStyle.Sizable;
            FormChung.hoatdongsinhvien.Show();
            FormChung.hoatdongsinhvien.Focus();

        }
        public void KyLuat()
        {
            if (FormChung.kyluat == null || FormChung.kyluat.IsDisposed)
                FormChung.kyluat = new frmKyLuat();
            FormChung.kyluat.MdiParent = this;
            FormChung.kyluat.FormBorderStyle = FormBorderStyle.Sizable;
            FormChung.kyluat.Show();
            FormChung.kyluat.Focus();

        }
        public void KhenThuong()
        {
            if (FormChung.khenthuong == null || FormChung.khenthuong.IsDisposed)
                FormChung.khenthuong = new QLKTX.Dialog.DiaLog_KhenThuong();
            FormChung.khenthuong.MdiParent = this;
            FormChung.khenthuong.FormBorderStyle = FormBorderStyle.Sizable;
            FormChung.khenthuong.Show();
            FormChung.khenthuong.Focus();

        }
        public void KhenThuongSinhVien()
        {
            if (FormChung.khenthuongsinhvien== null || FormChung.khenthuongsinhvien.IsDisposed)
                FormChung.khenthuongsinhvien = new frmKhenThuongSinhVien();
            FormChung.khenthuongsinhvien.MdiParent = this;
            FormChung.khenthuongsinhvien.FormBorderStyle = FormBorderStyle.Sizable;
            FormChung.khenthuongsinhvien.Show();
            FormChung.khenthuongsinhvien.Focus();

        }
        public void Cap()
        {
            if (FormChung.cap == null || FormChung.cap.IsDisposed)
                FormChung.cap = new QLKTX.Dialog.DiaLog_Cap();
            FormChung.cap.MdiParent = this;
            FormChung.cap.FormBorderStyle = FormBorderStyle.Sizable;
            FormChung.cap.Show();
            FormChung.cap.Focus();

        }
        public void DanhGia()
        {
            if (FormChung.danhgia == null || FormChung.danhgia.IsDisposed)
                FormChung.danhgia = new frmDanhGia();
            FormChung.danhgia.MdiParent = this;
            FormChung.danhgia.FormBorderStyle = FormBorderStyle.Sizable;
            FormChung.danhgia.Show();
            FormChung.danhgia.Focus();

        }
        public void XepLoai()
        {
            if (FormChung.xeploai == null || FormChung.xeploai.IsDisposed)
                FormChung.xeploai = new frmXepLoai();
            FormChung.xeploai.MdiParent = this;            
            FormChung.xeploai.Show();
            FormChung.xeploai.Focus();

        }

        #endregion

        #region Phong
        public void Phong()
        {
            if (FormChung.phong == null || FormChung.phong.IsDisposed)
                FormChung.phong = new frmPhong();
            FormChung.phong.MdiParent = this;
            FormChung.phong.Show();
            FormChung.phong.Focus();
        }
        public void NhapDiem()
        {
            if (FormChung.nhapdiem == null || FormChung.nhapdiem.IsDisposed)
                FormChung.nhapdiem = new frmNhapDiem_Phong();
            FormChung.nhapdiem.MdiParent = this;
            FormChung.nhapdiem.Show();
            FormChung.nhapdiem.Focus();
        }
        #endregion

        public void Day()
        {
            if (FormChung.day == null || FormChung.day.IsDisposed)
                FormChung.day = new frmDay();
            FormChung.day.MdiParent = this;
            FormChung.day.Show();
            FormChung.day.Focus();
        }

        public void KTX()
        {
            if (FormChung.ktx == null || FormChung.ktx.IsDisposed)
                FormChung.ktx = new frmKTX();
            FormChung.ktx.MdiParent = this;
            FormChung.ktx.Show();
            FormChung.ktx.Focus();
        }

        #region Tro giup
        public void GioiThieu()
        {
            if (FormChung.gioiThieu == null || FormChung.gioiThieu.IsDisposed)
                FormChung.gioiThieu = new frmGioiThieu();
            FormChung.gioiThieu.MdiParent = this;
            FormChung.gioiThieu.Show();
            FormChung.gioiThieu.Focus();
        }
        /// <summary>
        /// Hàm dùng để đăng nhập vào hệ thống
        /// </summary>
        public void DangNhap()
        {
            if (FormChung.dangNhap == null || FormChung.dangNhap.IsDisposed)
                FormChung.dangNhap = new frmDangNhap();
            //FormChung.dangNhap.MdiParent = this;
            FormChung.dangNhap.WindowState = FormWindowState.Normal;
            FormChung.dangNhap.ShowDialog();
            FormChung.dangNhap.Focus();
            if (FormChung.dangNhap.DialogResult == DialogResult.OK)//Dang nhap thanh cong
            {
                CoHieuLuc();
            }
            else
            {
                VoHieuHoa();
            }
        }        
        #endregion

        public void VoHieuHoa()
        {
            #region ToolBar Tab

            #region Tool HeTHong
            btnHeThong_DangNhap.Enabled = true;
            btnHeThong_DangXuat.Enabled = false;
            barHeThong_QLDuLieu.Enabled = false;
            barHeThong_QLDanhMuc.Enabled = false;
            barHeThong_NguoiDung.Enabled = false;
            #endregion
            #region QL Sinh Vien
            barQLSV_SinhVien.Enabled = false;
            barQLSV_DanhGia.Enabled = false;
            barQLSV_QuanLy.Enabled = false;
            barQLSV_TraCuu.Enabled = false;
            barQLSV_ThongKe.Enabled = false;
            #endregion
            #region Ql Phong
            barQLPhong_Phong.Enabled = false;
            barQLPhong_ThongKe.Enabled = false;            
            barQLPhong_DanhGiaPhong.Enabled = false;
            #endregion
            #region Day
            barQlDay_Day.Enabled = false;
            
            barQlDay_ThongKeDay.Enabled = false;
            barQlDay_ThongKeKTX.Enabled = false;
            #endregion
            #region TraCuu
            barQlTraCuu_Day.Enabled = false;
            barQlTraCuu_KTX.Enabled = false;
            barQlTraCuu_Phong.Enabled = false;
            barQlTraCuu_SinhVien.Enabled = false;
            #endregion

            #endregion
            #region Explorer Tab
            #region HeThong
            taskTab_DangNhap.Enabled=true;
            taskTab_DangXuat.Enabled=false;
            taskTab_NguoiDung.Enabled=false;
            //taskTab_HienThi.Enabled=false;
            taskTab_Thoat.Enabled = false;
            #endregion
            #region Quan Ly
            taskTab_ThongTinSinhVien.Enabled = false;
            taskTab_DiemDanh.Enabled = false;
            taskTab_ThongTinPhong.Enabled = false;
            taskTab_HoatDongSinhVien.Enabled = false; ;

            #endregion
            #region TraCuu
            taskTab_TraCuuSinhVien.Enabled = false;
            taskTab_TraCuuPhong.Enabled = false;
            #endregion
            #region Tro Giup
            taskTab_TroGiup.Enabled = false;
            #endregion
            #region DanhMuc
            taskTab_HoatDong.Enabled = false;
            taskTab_DanhGia.Enabled = false;
            taskTab_XepLoai.Enabled = false;
            #endregion
            #endregion
            #region Explorer XP
            #region HeThong
            taskXP_DangNhap.Enabled = true;
            taskXP_DangXuat.Enabled = false;
            taskXP_NguoiDung.Enabled = false;
            //taskXP_HienThi.Enabled=false;
            taskXP_Thoat.Enabled = false;
            #endregion
            #region Quan Ly
            taskXP_ThongTinSinhVien.Enabled = false;
            taskXP_DiemDanh.Enabled = false;
            taskXP_ThongTinPhong.Enabled = false;
            taskXP_HoatDongSinhVien.Enabled = false; ;

            #endregion
            #region TraCuu
            taskXP_TraCuuSinhVien.Enabled = false;
            taskXP_TraCuuPhong.Enabled = false;
            #endregion
            #region Tro Giup
            taskXP_TroGiup.Enabled = false;
            #endregion
            #region DanhMuc
            taskXP_HoatDong.Enabled = false;
            taskXP_DanhGia.Enabled = false;
            taskXP_XepLoai.Enabled = false;
            #endregion
            #endregion
            #region Tool XP
            btnMainTool_DangNhap.Enabled=true;
            btnMainTool_DangXuat.Enabled=false;
            btnMainTool_SuaSinhVien.Enabled=false;
            btnMainTool_ThemSinhVien.Enabled=false;
            btnMainTool_TraCuu.Enabled=false;
            btnMainTool_TraCuu.Enabled=false;            
            #endregion
            #region Menue XP

            mnuHeThong_DangNhap.Enabled = true;
            mnuHeThong_DangXuat.Enabled = false;
            mnuHeThong_Thoat.Enabled = false;

            mnuQLSV_ThemSV.Enabled = false;
            mnuQLSV_SuaSV.Enabled = false;
            mnuQLSV_ChuyenPhong.Enabled = false;
            mnuQLSV_DanhGia1.Enabled = false;
            mnuQLSV_DiemDanh.Enabled = false;
            mnuQLSV_HoatDong.Enabled = false;
            mnuQLSV_KhenThuong.Enabled = false;
            mnuQLSV_KyLuat.Enabled = false;
            mnuQLSV_QuanLy.Enabled = false;
            mnuQLSV_SuaSV.Enabled = false;
            mnuQLSV_ThemSV.Enabled = false;
            mnuQLSV_QuanLy.Enabled = false;
            mnuQLSV_SuaSV.Enabled = false;
            mnuQLSV_ThemSV.Enabled = false;
            mnuQLSV_QuanLy.Enabled = false;
            mnuQLSV_SuaSV.Enabled = false;
            mnuQLSV_ThemSV.Enabled = false;
            mnuQLSV_ThongKe.Enabled = false;
            mnuQLSV_XoaSinhVien.Enabled = false;
            mnuQLSV_TraCuu.Enabled = false;

            mnuTraCuu_Day.Enabled = false;
            mnuTraCuu_KTX.Enabled = false;
            mnuTraCuu_Phong.Enabled = false;
            mnuTraCuu_SinhVien.Enabled = false;          
            

            mnuQLDay_SuaDay.Enabled = false;
            mnuQLDay_SuaKTX.Enabled = false;
            mnuQLDay_ThemDay.Enabled = false;
            mnuQLDay_ThemKTX.Enabled = false;
            mnuQLDay_ThongKeDay.Enabled = false;
            mnuQLDay_ThongKeKTX.Enabled = false;
            mnuQLDay_TraCuu.Enabled = false;
            mnuQLDay_TraCuuDay.Enabled = false;
            mnuQLDay_TraCuuKTX.Enabled = false;
            mnuQLDay_XoaDay.Enabled = false;
            mnuQLDay_XoaKTX.Enabled = false;

            mnuQLPhong_DanhGia.Enabled = false;
            mnuQLPhong_KWDien.Enabled = false;
            mnuQLPhong_SuaPhong.Enabled = false;
            mnuQLPhong_ThemPhong.Enabled = false;
            mnuQLPhong_ThongKe.Enabled = false;
            mnuQLPhong_ThuTien.Enabled = false;
            mnuQLPhong_TienDien.Enabled = false;
            mnuQLPhong_TienPhong.Enabled = false;
            mnuQLPhong_XoaPhong.Enabled = false;

            #endregion

        }
        public void CoHieuLuc()
        {
            #region ToolBar Tab

            #region Tool HeTHong
            btnHeThong_DangNhap.Enabled = false;
            btnHeThong_DangXuat.Enabled = true;
            barHeThong_QLDuLieu.Enabled = true;
            barHeThong_QLDanhMuc.Enabled = true;
            barHeThong_NguoiDung.Enabled = true;
            #endregion
            #region QL Sinh Vien
            barQLSV_SinhVien.Enabled = true;
            barQLSV_DanhGia.Enabled = true;
            barQLSV_QuanLy.Enabled = true;
            barQLSV_TraCuu.Enabled = true;
            barQLSV_ThongKe.Enabled = true;
            #endregion
            #region Ql Phong
            barQLPhong_Phong.Enabled = true;
            barQLPhong_ThongKe.Enabled = true;                        
            barQLPhong_DanhGiaPhong.Enabled = true;
            #endregion
            #region Day
            barQlDay_Day.Enabled = true;            
            barQlDay_ThongKeDay.Enabled = true;
            barQlDay_ThongKeKTX.Enabled = true;
            #endregion
            #region TraCuu
            barQlTraCuu_Day.Enabled = true;
            barQlTraCuu_KTX.Enabled = true;
            barQlTraCuu_Phong.Enabled = true;
            barQlTraCuu_SinhVien.Enabled = true;
            #endregion

            #endregion
            #region Explorer Tab
            #region HeThong
            taskTab_DangNhap.Enabled = false;
            taskTab_DangXuat.Enabled = true;
            taskTab_NguoiDung.Enabled = true;
            //taskTab_HienThi.Enabled=true;
            taskTab_Thoat.Enabled = true;
            #endregion
            #region Quan Ly
            taskTab_ThongTinSinhVien.Enabled = true;
            taskTab_DiemDanh.Enabled = true;
            taskTab_ThongTinPhong.Enabled = true;
            taskTab_HoatDongSinhVien.Enabled = true; ;

            #endregion
            #region TraCuu
            taskTab_TraCuuSinhVien.Enabled = true;
            taskTab_TraCuuPhong.Enabled = true;
            #endregion
            #region Tro Giup
            taskTab_TroGiup.Enabled = true;
            #endregion
            #region DanhMuc
            taskTab_HoatDong.Enabled = true;
            taskTab_DanhGia.Enabled = true;
            taskTab_XepLoai.Enabled = true;
            #endregion
            #endregion
            #region Explorer XP
            #region HeThong
            taskXP_DangNhap.Enabled = false;
            taskXP_DangXuat.Enabled = true;
            taskXP_NguoiDung.Enabled = true;
            //taskXP_HienThi.Enabled=true;
            taskXP_Thoat.Enabled = true;
            #endregion
            #region Quan Ly
            taskXP_ThongTinSinhVien.Enabled = true;
            taskXP_DiemDanh.Enabled = true;
            taskXP_ThongTinPhong.Enabled = true;
            taskXP_HoatDongSinhVien.Enabled = true; ;

            #endregion
            #region TraCuu
            taskXP_TraCuuSinhVien.Enabled = true;
            taskXP_TraCuuPhong.Enabled = true;
            #endregion
            #region Tro Giup
            taskXP_TroGiup.Enabled = true;
            #endregion
            #region DanhMuc
            taskXP_HoatDong.Enabled = true;
            taskXP_DanhGia.Enabled = true;
            taskXP_XepLoai.Enabled = true;
            #endregion
            #endregion
            #region Tool XP
            btnMainTool_DangNhap.Enabled = false;
            btnMainTool_DangXuat.Enabled = true;
            btnMainTool_SuaSinhVien.Enabled = true;
            btnMainTool_ThemSinhVien.Enabled = true;
            btnMainTool_TraCuu.Enabled = true;
            btnMainTool_TraCuu.Enabled = true;
            #endregion
            #region Menue XP

            mnuHeThong_DangNhap.Enabled = false;
            mnuHeThong_DangXuat.Enabled = true;
            mnuHeThong_Thoat.Enabled = true;

            mnuQLSV_ThemSV.Enabled = true;
            mnuQLSV_SuaSV.Enabled = true;
            mnuQLSV_ChuyenPhong.Enabled = true;
            mnuQLSV_DanhGia1.Enabled = true;
            mnuQLSV_DiemDanh.Enabled = true;
            mnuQLSV_HoatDong.Enabled = true;
            mnuQLSV_KhenThuong.Enabled = true;
            mnuQLSV_KyLuat.Enabled = true;
            mnuQLSV_QuanLy.Enabled = true;
            mnuQLSV_SuaSV.Enabled = true;
            mnuQLSV_ThemSV.Enabled = true;
            mnuQLSV_QuanLy.Enabled = true;
            mnuQLSV_SuaSV.Enabled = true;
            mnuQLSV_ThemSV.Enabled = true;
            mnuQLSV_QuanLy.Enabled = true;
            mnuQLSV_SuaSV.Enabled = true;
            mnuQLSV_ThemSV.Enabled = true;
            mnuQLSV_ThongKe.Enabled = true;
            mnuQLSV_XoaSinhVien.Enabled = true;
            mnuQLSV_TraCuu.Enabled = true;

            mnuTraCuu_Day.Enabled = true;
            mnuTraCuu_KTX.Enabled = true;
            mnuTraCuu_Phong.Enabled = true;
            mnuTraCuu_SinhVien.Enabled = true;


            mnuQLDay_SuaDay.Enabled = true;
            mnuQLDay_SuaKTX.Enabled = true;
            mnuQLDay_ThemDay.Enabled = true;
            mnuQLDay_ThemKTX.Enabled = true;
            mnuQLDay_ThongKeDay.Enabled = true;
            mnuQLDay_ThongKeKTX.Enabled = true;
            mnuQLDay_TraCuu.Enabled = true;
            mnuQLDay_TraCuuDay.Enabled = true;
            mnuQLDay_TraCuuKTX.Enabled = true;
            mnuQLDay_XoaDay.Enabled = true;
            mnuQLDay_XoaKTX.Enabled = true;

            mnuQLPhong_DanhGia.Enabled = true;
            mnuQLPhong_KWDien.Enabled = true;
            mnuQLPhong_SuaPhong.Enabled = true;
            mnuQLPhong_ThemPhong.Enabled = true;
            mnuQLPhong_ThongKe.Enabled = true;
            mnuQLPhong_ThuTien.Enabled = true;
            mnuQLPhong_TienDien.Enabled = true;
            mnuQLPhong_TienPhong.Enabled = true;
            mnuQLPhong_XoaPhong.Enabled = true;

            #endregion
        }

        private DevComponents.DotNetBar.ButtonItem btnQLSV_TraCuu_Chung;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_QuanLy_DiemDanh;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnFull;
        private DevComponents.DotNetBar.ButtonItem btnNormal;
        private DevComponents.DotNetBar.ItemContainer itemContainer34;
        private DevComponents.DotNetBar.ItemContainer itemContainer40;
        private DevComponents.DotNetBar.LabelItem labelItem23;
        private DevComponents.DotNetBar.TextBoxItem textBoxItem4;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.DotNetBar.ButtonItem btnQLSV_QuanLy_XepPhong;
        private DevComponents.DotNetBar.ButtonItem btn_Day_KTX;
    }





}

