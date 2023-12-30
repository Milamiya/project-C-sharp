using System;
using System.Drawing;
using DevExpress.XtraEditors;
using Util;

namespace QLHS
{
    public partial class FrmHome : XtraForm
    {
        private FrmMain _frmMainInstance;

        public FrmHome()
        {
            InitializeComponent();
        }

        private void frmGUIDE_Resize(object sender, EventArgs e)
        {
            panelControl1.Location = new Point(Size.Width/2
                                               - panelControl1.Size.Width/2, panelControl1.Location.Y);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            _frmMainInstance = ParentForm as FrmMain;
        }

        #region Phân quyền, ẩn hiện các button

        /// <summary>
        /// Ẩn hiện tất cả menu cần thiết
        /// </summary>
        /// <param name="enableAllMenu">True - Hiển thị / False - Ẩn</param>
        private void EnableAllMenu(bool enableAllMenu)
        {
            // Quản lý hồ sơ - Hồ sơ năm học
            btnHomeKhaiBao.Enabled = enableAllMenu;
            btnHomeNamHoc.Enabled = enableAllMenu;
            btnHomeMonHoc.Enabled = enableAllMenu;
            btnHomeLop.Enabled = enableAllMenu;
            btnHomeGiaoVien.Enabled = enableAllMenu;
            // Quản lý hồ sơ - Hồ sơ học sinh
            btnHomeHocSinh.Enabled = enableAllMenu;
            btnHomeTimKiem.Enabled = enableAllMenu;
            btnHomePhanLop.Enabled = enableAllMenu;
            // Quản lý học tập - Quản lý điểm
            btnHomeNhapDiem.Enabled = enableAllMenu;
            btnHomeXuatBD.Enabled = enableAllMenu;
            // Quản lý học tập - Báo cáo tổng kết
            btnHomeTKDiemHK.Enabled = enableAllMenu;
            btnHomeTKMonHoc.Enabled = enableAllMenu;
        }

        /// <summary>
        /// Phân quyền người dùng, tùy thuộc từng quyền mà có những chức năng khác nhau
        /// </summary>
        public void PhanQuyenNguoiDung()
        {
            EnableAllMenu(true);
            switch (ObjectUtil.User.LoaiNguoiDung.MaLoai)
            {
                    // Administrator
                case "quantri":
                    // Ban giám hiệu
                case "hieutruong":
                case "phohieutruong":
                    NhomAdministrator();
                    break;
                    // Giáo viên
                case "giaovien":
                    NhomGiaoVien();
                    break;
                    // Giáo vụ
                case "giaovu":
                    NhomGiaoVu();
                    break;
                    // mặc định ẩn hết menu
                default:
                    EnableAllMenu(false);
                    break;
            }
        }

        /// <summary>
        /// Diable menu không thuộc nhóm Administrator
        /// </summary>
        private void NhomAdministrator()
        {
            // nhóm administrator toàn quyền
        }

        /// <summary>
        /// Diable menu không thuộc nhóm giáo viên
        /// </summary>
        private void NhomGiaoVien()
        {
            // Quản lý hồ sơ - Hồ sơ năm học
            btnHomeKhaiBao.Enabled = false;
            btnHomeNamHoc.Enabled = false;
            btnHomeMonHoc.Enabled = false;
            btnHomeLop.Enabled = false;
            btnHomeGiaoVien.Enabled = false;
            // Quản lý hồ sơ - Hồ sơ học sinh
            btnHomeHocSinh.Enabled = false;
            btnHomePhanLop.Enabled = false;
            // Quản lý học tập - Quản lý điểm
            btnHomeNhapDiem.Enabled = false;
            btnHomeXuatBD.Enabled = false;
            // Quản lý học tập - Báo cáo tổng kết
            btnHomeTKDiemHK.Enabled = false;
            btnHomeTKMonHoc.Enabled = false;
        }

        /// <summary>
        /// Diable menu không thuộc nhóm giáo vụ
        /// </summary>
        private void NhomGiaoVu()
        {
            btnHomeKhaiBao.Enabled = false;
        }

        #endregion

        #region Home introduce button

        private void btnHomeNamHoc_Click(object sender, EventArgs e)
        {
            _frmMainInstance.ShowMdiChildForm<FrmNamHoc>();
        }

        private void btnHomeGiaoVien_Click(object sender, EventArgs e)
        {
            _frmMainInstance.ShowMdiChildForm<FrmGiaoVien>();
        }

        private void btnHomeKhaiBao_Click(object sender, EventArgs e)
        {
            _frmMainInstance.ShowMdiChildForm<FrmQuyDinhDauNam>();
        }

        private void btnHomeHocSinh_Click(object sender, EventArgs e)
        {
            _frmMainInstance.ShowMdiChildForm<FrmHocSinh>();
        }

        private void btnHomeLop_Click(object sender, EventArgs e)
        {
            _frmMainInstance.ShowMdiChildForm<FrmLapDsLop>();
        }

        private void btnHomePhanLop_Click(object sender, EventArgs e)
        {
            _frmMainInstance.ShowMdiChildForm<FrmPhanLop>();
        }

        private void btnHomeTimKiem_Click(object sender, EventArgs e)
        {
            _frmMainInstance.ShowMdiChildForm<FrmTimHocSinh>();
        }

        private void btnHomeNhapDiem_Click(object sender, EventArgs e)
        {
            _frmMainInstance.ShowMdiChildForm<FrmBangDiemMonHoc>();
        }

        private void btnHomeMonHoc_Click(object sender, EventArgs e)
        {
            _frmMainInstance.ShowMdiChildForm<FrmMonHoc>();
        }

        private void btnHomeTKDiemHK_Click(object sender, EventArgs e)
        {
            _frmMainInstance.ShowMdiChildForm<FrmBcTongKetHocKy>();
        }

        private void btnHomeXuatBD_Click(object sender, EventArgs e)
        {
            _frmMainInstance.ShowMdiChildForm<FrmBcBangDiemHocKy>();
        }

        private void btnHomeTKMonHoc_Click(object sender, EventArgs e)
        {
            _frmMainInstance.ShowMdiChildForm<FrmBcTongKetMon>();
        }

        #endregion
    }
}