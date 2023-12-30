using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using QuanLyDaoTao.Utilities;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using System.IO;
using WBrowser;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Enums;


namespace QuanLyDaoTao.Presentation
{
    public partial class frmChinh : RibbonForm
    {
        public frmChinh()
        {
            // Kiểm tra kết nối CSDL
            if (!frmAddConnection.TestConnect())
            {
                if (frmAddConnection.Show() != DialogResult.OK)
                    Environment.Exit(1);
                else
                    return;
            }
            InitializeComponent();
            InitSkinGallery();
        }

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        #region Xử lý add form vào xtra tab control

        protected void TabCreating(string tabTitle, XtraForm frm)
        {
            int Index = KiemTraTonTai(tabTitle);
            if (Index >= 0)
            {
                xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[Index];
                xtraTabControl1.SelectedTabPage.Text = tabTitle;
            }
            else
            {
                XtraTabPage TabPage = new XtraTabPage { Text = tabTitle };
                TabPage.AutoScroll = true;
                xtraTabControl1.TabPages.Add(TabPage);
                xtraTabControl1.SelectedTabPage = TabPage;
                TabPage.AutoScroll = true;
                //TabPage.AutoScrollMargin = new Size(20, 20);
                TabPage.AutoScrollMinSize = new Size(TabPage.Width, TabPage.Height);

                frm.TopLevel = false;
                frm.Parent = TabPage;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private int KiemTraTonTai(string tabName)
        {
            int temp = -1;
            for (int i = 0; i < xtraTabControl1.TabPages.Count; i++)
            {
                if (xtraTabControl1.TabPages[i].Text == tabName)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                XtraTabControl TabControl = (XtraTabControl)sender;
                int i = TabControl.SelectedTabPageIndex;
                TabControl.TabPages[i].Dispose();
                if (i > 0)
                    TabControl.SelectedTabPageIndex = i - 1;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        #endregion

        #region Các hàm không phải hàm xử lý sự kiện

        private void PhanQuyen()
        {
            try
            {
                if (StaticClass.DangNhap)
                {
                    btnDangNhap.Enabled = false;
                    btnDangXuat.Enabled = true;
                    btnDoiMatKhau.Enabled = true;
                    btnThongTin.Enabled = true;

                    if (StaticClass.User.Quyen == (int)QuyenNguoiDung.Admin)
                    {
                        rpSinhVien.Visible = true;
                        rpGiangVien.Visible = true;
                        rpGiaoVu.Visible = true;
                        rpAdmin.Visible = true;
                        return;
                    }
                    if (StaticClass.User.Quyen == (int)QuyenNguoiDung.GiaoVu)
                    {
                        rpSinhVien.Visible = false;
                        rpGiangVien.Visible = false;
                        rpGiaoVu.Visible = true;
                        rpAdmin.Visible = false;
                        return;
                    }
                    if (StaticClass.User.Quyen == (int)QuyenNguoiDung.GiangVien)
                    {
                        rpSinhVien.Visible = false;
                        rpGiangVien.Visible = true;
                        rpGiaoVu.Visible = false;
                        rpAdmin.Visible = false;
                        return;
                    }
                    if (StaticClass.User.Quyen == (int)QuyenNguoiDung.SinhVien)
                    {
                        rpSinhVien.Visible = true;
                        rpGiangVien.Visible = false;
                        rpGiaoVu.Visible = false;
                        rpAdmin.Visible = false;
                        return;
                    }
                }
                else//chua dang nhap
                {
                    btnDangNhap.Enabled = true;
                    btnDangXuat.Enabled = false;
                    btnDoiMatKhau.Enabled = false;
                    btnThongTin.Enabled = false;

                    rpSinhVien.Visible = false;
                    rpGiangVien.Visible = false;
                    rpGiaoVu.Visible = false;
                    rpAdmin.Visible = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void NhanForm(XtraForm frm)
        {
            try
            {
                TabCreating(frm.Text, frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        #endregion

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmDangNhap frm = new frmDangNhap();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lblQuyen.Caption = StaticClass.User.MoTaQuyen + ":";
                    lblTen.Caption = StaticClass.User.TenNguoiDung;
                }
                else
                {
                    lblQuyen.Caption = "Bạn chưa đăng nhập.";
                    lblTen.Caption = "Vui lòng đăng nhập để sử dụng hệ thống.";
                }
                PhanQuyen();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime now=DateTime.Now;
                lblNgayGio.Caption = now.ToString("HH:mm") + " ngày " + now.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            try
            {

                timer1_Tick(null, null);
                //đăng nhập và phân quyền
                frmDangNhap frm = new frmDangNhap();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lblQuyen.Caption = StaticClass.User.MoTaQuyen + ":";
                    lblTen.Caption = StaticClass.User.TenNguoiDung;
                }
                PhanQuyen();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void btnCauHinhCSDL_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmAddConnection frm = new frmAddConnection();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    StaticClass.Log.GhiFile("Cấu hình kết nối CSDL");
                    if (xtraTabControl1.TabPages.Count > 0)
                    {
                        MsgboxUtil.Info("Chương trình sẽ đóng tất cả trang hiện tại để cấu hình CSDL");
                        xtraTabControl1.TabPages.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void btnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string path = "";
                string fileName = "";
                DataProvider dp = new DataProvider();
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Backup file (*.bak)|*.bak";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    path = save.FileName;
                    fileName = Path.GetFileName(path);
                    path = path.Substring(0, path.Length - (fileName.Length + 1));
                    if (dp.BackupDatabase(fileName, path))
                    {
                        this.Cursor = Cursors.Default;
                        StaticClass.Log.GhiFile("Sao lưu CSDL vào: " + path);
                        MsgboxUtil.Success("Sao lưu CSDL thành công!");
                    }
                }

            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string path = "";
                DataProvider dp = new DataProvider();
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Backup file (*.bak)|*.bak";
                open.Multiselect = false;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    path = open.FileName;
                    if (dp.RestoreDatabase(path))
                    {
                        this.Cursor = Cursors.Default;
                        StaticClass.Log.GhiFile("Phục hồi CSDL từ: "+ path);
                        MsgboxUtil.Success("Phục hồi CSDL thành công!");
                    }
                }

            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                StaticClass.Log.GhiFile("Đăng xuất");
                StaticClass.DangNhap = false;
                StaticClass.User = null;
                PhanQuyen();
                xtraTabControl1.TabPages.Clear();
                lblQuyen.Caption = "Bạn chưa đăng nhập.";
                lblTen.Caption = "Vui lòng đăng nhập để sử dụng hệ thống.";
                MsgboxUtil.Info("Bạn đã đăng xuất.\nVui lòng đăng nhập để sử dụng hệ thống.");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmDoiMatKhau frm = new frmDoiMatKhau();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MsgboxUtil.YesNo("Bạn muốn thoát chương trình?") == DialogResult.Yes)
            {
                if (StaticClass.DangNhap)
                    StaticClass.Log.GhiFile("Thoát chương trình mà không đăng xuất");
                Application.Exit();
            }
        }

        private void btnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongTinNguoiDung frm = new frmThongTinNguoiDung();
            frm.ShowDialog();
        }

        private void btnWeb_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                WBrowser.WBrowser frm = new WBrowser.WBrowser();
                TabCreating("Duyệt web", frm);
                if(StaticClass.DangNhap)
                    StaticClass.Log.GhiFile("Duyệt web");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void btnRSS_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmRSS frm = new frmRSS();
                TabCreating("Tin tức", frm);
                if (StaticClass.DangNhap)
                    StaticClass.Log.GhiFile("Đọc tin tức");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void btnSuaKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }        

        private void btnTTCT_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThongTinChuongTrinh frm = new frmThongTinChuongTrinh();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThemSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThemSinhVien frm = new frmThemSinhVien();
                TabCreating("Thêm sinh viên", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnNganhHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThemNganhHoc frm = new frmThemNganhHoc();
                TabCreating("Ngành học mới", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThemLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThemLopHoc frm = new frmThemLopHoc();
                TabCreating("Lớp học mới", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnTrinhDo_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThemTrinhDo frm = new frmThemTrinhDo();
                TabCreating("Trình độ mới", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnGiangVienMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThemGiangVien frm = new frmThemGiangVien();
                TabCreating("Giảng viên mới", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThemMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThemMonHoc frm = new frmThemMonHoc();
                TabCreating("Môn học mới", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnPhanCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmPhanCongGiangDay frm = new frmPhanCongGiangDay();
                TabCreating("Phân công giảng dạy", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThemDeNghi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThemDeNghi frm = new frmThemDeNghi();
                TabCreating("Đề nghị giảng dạy", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnXemDeNghi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmXemDeNghi frm = new frmXemDeNghi();
                TabCreating("Xem đề nghị giảng dạy", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnXepTKB_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmXepThoiKhoaBieu frm = new frmXepThoiKhoaBieu();
                TabCreating("Xếp thời khóa biểu", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnXemNhatKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmXemNhatKy frm = new frmXemNhatKy();
                TabCreating("Nhật ký hệ thống", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmDanhMucNguoiDung frm = new frmDanhMucNguoiDung();
                TabCreating("Danh mục người dùng", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnNhapXuatDuLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmNhapXuatDuLieuNangCao frm = new frmNhapXuatDuLieuNangCao();
                TabCreating("Nhập xuất dữ liệu", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnXemTKBSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmXemThoiKhoaBieuSinhVien frm = new frmXemThoiKhoaBieuSinhVien();
                TabCreating("Sinh viên xem thời khóa biểu tuần", frm);
                StaticClass.Log.GhiFile("Xem thời khóa biểu tuần");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnXemTKBGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmXemThoiKhoaBieuGiangVien frm = new frmXemThoiKhoaBieuGiangVien();
                TabCreating("Giảng viên xem thời khóa biểu tuần", frm);
                StaticClass.Log.GhiFile("Xem thời khóa biểu tuần");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnXemTKB_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmXemThoiKhoaBieuGiangVien frm = new frmXemThoiKhoaBieuGiangVien();
                TabCreating("Giáo vụ xem thời khóa biểu tuần", frm);
                StaticClass.Log.GhiFile("Xem thời khóa biểu");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnNhapPhieuGiangDay_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmNhapPhieuGiangDay frm = new frmNhapPhieuGiangDay();
                TabCreating("Nhập phiếu giảng dạy", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnXemPhieuGiangDay_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmXemPhieuGiangDay frm = new frmXemPhieuGiangDay();
                TabCreating("GV xem phiếu giảng dạy", frm);
                StaticClass.Log.GhiFile("Xem phiếu giảng dạy");
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThanhToanLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThanhToanLuong frm = new frmThanhToanLuong();
                TabCreating("Thanh toán lương", frm);
                frm.truyen = new frmThanhToanLuong.TruyenForm(NhanForm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnPhongHocMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThemPhongHoc frm = new frmThemPhongHoc();
                TabCreating("Phòng học mới", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnReStart_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if(StaticClass.DangNhap)
                    StaticClass.Log.GhiFile("Khởi động lại chương trình");
                Application.Restart();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnTTTG_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmGioiThieu frm = new frmGioiThieu();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnCapNhatSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmCapNhatSinhVien frm = new frmCapNhatSinhVien();
                TabCreating("Cập nhật thông tin sinh viên", frm);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnThongTinCSDL_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                frmThongTinCauHinhCSDL frm = new frmThongTinCauHinhCSDL();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}