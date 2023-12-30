using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Enums;
using QuanLyDaoTao.DataAccess;
using System.Linq;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Business;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmThemSinhVien : XtraForm
    {
        string _matKhau;
        LogFile log;
        public frmThemSinhVien()
        {
            try
            {
                InitializeComponent();
                _matKhau = string.Empty;
                log = new LogFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Các hàm tiện ích

        /// <summary>
        /// Xóa chữ của các text box
        /// </summary>
        private void ClearText()
        {
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtHoTen.Focus();
        }

        private bool TaoMoi(SinhVien sv)
        {
            try
            {
                sv.MSSV = txtMSSV.Text;
                if (!string.IsNullOrEmpty(txtHoTen.Text))
                    sv.HoTen = txtHoTen.Text;
                else
                {
                    MsgboxUtil.Exclamation("Họ tên sinh viên không được để trống");
                    txtHoTen.Focus();
                    return false;
                }
                if (!string.IsNullOrEmpty(dateNgaySinh.Text))
                    sv.NgaySinh = dateNgaySinh.DateTime;
                if (!string.IsNullOrEmpty(cmbLop.Text))
                    sv.MaLop = cmbLop.EditValue.ToString();
                else
                {
                    MsgboxUtil.Exclamation("Hãy chọn lớp cho sinh viên này");
                    cmbLop.Focus();
                    return false;
                }
                if (!string.IsNullOrEmpty(txtDiaChi.Text))
                    sv.DiaChi = txtDiaChi.Text.Trim();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void TaoMa()
        {
            try
            {
                string lop = cmbLop.EditValue.ToString();
                string dinhDang = lop.Substring(0, 1) + lop.Substring(4, 2);
                if (dinhDang[0] == 'D')
                    dinhDang = dinhDang.Insert(3, (int.Parse(lop.Substring(2, 2)) - 1).ToString());
                else
                    dinhDang = dinhDang.Insert(3, (int.Parse(lop.Substring(2, 2)) - 25).ToString());
                txtMSSV.Text = SinhVienBUS.SinhMa(dinhDang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                cmbLop.Properties.DataSource = LopBUS.DanhSachTuyChinh();
                cmbLop.EditValue = cmbLop.Properties.GetDataSourceValue("MaLop", 0);
                dateNgaySinh.DateTime = DateTime.Now.AddYears(-18);
                TaoMa();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = new SinhVien();
                if (TaoMoi(sv))
                {
                    frmMatKhau frm = new frmMatKhau();
                    frm.truyen += new frmMatKhau.TruyenMatKhau(GetMatKhau);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        NguoiDung user = new NguoiDung()
                        {
                            TenDangNhap = sv.MSSV.ToLower(),
                            MatKhau = UtilitiesClass.MaHoaMD5(_matKhau),
                            TenNguoiDung = sv.HoTen,
                            Quyen = (int)QuyenNguoiDung.SinhVien,
                            MoTaQuyen = "Sinh viên"
                        };
                        NguoiDungBUS.Them(user);
                        SinhVienBUS.Them(sv);
                        StaticClass.LuuThayDoi();
                        log.GhiFile("Thêm mới sinh viên: " + sv.MSSV);
                        MsgboxUtil.Success("Thành công");
                        ClearText();
                        TaoMa();
                    }
                    else
                        MsgboxUtil.Exclamation("Không thể thêm sinh viên khi chưa thiết lập mật khẩu");
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        /// <summary>
        /// Hàm nhận mật khẩu từ form con
        /// </summary>
        private void GetMatKhau(string value)
        {
            _matKhau = value;
        }

        private void cmbLop_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                TaoMa();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}