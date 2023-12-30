using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Business;
using QuanLyDaoTao.DataAccess;
using System.Windows.Forms;
using QuanLyDaoTao.Enums;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThemGiangVien : XtraForm
    {
        LogFile log;
        string _matKhau;
        public frmThemGiangVien()
        {
            InitializeComponent();
            log = new LogFile();
            _matKhau = string.Empty;
        }

        private bool TaoMoi(GiangVien gv)
        {
            try
            {
                gv.MaGV = txtMaGV.Text;
                if (!string.IsNullOrEmpty(txtHoTen.Text))
                    gv.HoTen = txtHoTen.Text;
                else
                {
                    MsgboxUtil.Exclamation("Họ tên giảng viên không được để trống");
                    txtHoTen.Focus();
                    return false;
                }
                if (rdgGioiTinh.SelectedIndex == 0)
                    gv.GioiTinh = false;
                else gv.GioiTinh = true;
                gv.MaTrinhDo = cmbTrinhDo.EditValue.ToString();
                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                    gv.DiaChi = txtDiaChi.Text.Trim();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmThemGiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTrinhDo.Properties.DataSource = TrinhDoBUS.DanhSachTrinhDo();
                cmbTrinhDo.EditValue = cmbTrinhDo.Properties.GetDataSourceValue("MaTrinhDo", 0);
                txtMaGV.Text = GiangVienBUS.SinhMa();
                txtHoTen.Focus();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                GiangVien gv = new GiangVien();
                if (TaoMoi(gv))
                {
                    frmMatKhau frm = new frmMatKhau();
                    frm.truyen += new frmMatKhau.TruyenMatKhau(GetMatKhau);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        NguoiDung user = new NguoiDung()
                        {
                            TenDangNhap = gv.MaGV.ToLower(),
                            MatKhau = UtilitiesClass.MaHoaMD5(_matKhau),
                            TenNguoiDung = gv.HoTen,
                            Quyen = (int)QuyenNguoiDung.GiangVien,
                            MoTaQuyen = "Giảng viên"
                        };
                        NguoiDungBUS.Them(user);
                        GiangVienBUS.Them(gv);
                        StaticClass.LuuThayDoi();
                        log.GhiFile("Thêm mới giảng viên: " + gv.MaGV);
                        MsgboxUtil.Success("Thành công");
                        ClearText();
                        txtMaGV.Text = GiangVienBUS.SinhMa();
                    }
                    else
                        MsgboxUtil.Exclamation("Không thể thêm giảng viên khi chưa thiết lập mật khẩu");
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        /// <summary>
        /// Hàm nhận mật khẩu từ form con
        /// </summary>
        private void GetMatKhau(string value)
        {
            _matKhau = value;
        }

        private void ClearText()
        {
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtHoTen.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}