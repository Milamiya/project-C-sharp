using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLHocSinhTHPT.Controller;
using DevComponents.DotNetBar;

namespace QLHocSinhTHPT.Component
{
    public partial class frmQuyDinh : Office2007Form
    {
        #region Field
        QuyDinhCtrl m_QuyDinhCtrl = new QuyDinhCtrl();
        #endregion

        #region Constructor
        public frmQuyDinh()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
        }
        #endregion

        #region Click event
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (tabControlPanelSiSo.CanSelect)
            {
                if (txtSiSoCanDuoi.Value <= 10 || txtSiSoCanTren.Value >= 60)
                    MessageBoxEx.Show("Sỉ số phải nằm trong khoảng giới hạn 10 - 60!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhSiSo(txtSiSoCanDuoi.Value, txtSiSoCanTren.Value);
                    MessageBoxEx.Show("Cập nhật thành công quy định về sỉ số!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
                }
            }
            else if (tabControlPanelDoTuoi.CanSelect)
            {
                if (txtDoTuoiCanDuoi.Value <= 10 || txtDoTuoiCanTren.Value >= 30)
                    MessageBoxEx.Show("Độ tuổi phải nằm trong khoảng giới hạn 10 - 30!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhDoTuoi(txtDoTuoiCanDuoi.Value, txtDoTuoiCanTren.Value);
                    MessageBoxEx.Show("Cập nhật thành công quy định về độ tuổi!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
                }
            }
            else if (tabControlPanelTruong.CanSelect)
            {
                if (txtTenTruong.Text == "")
                    MessageBoxEx.Show("Tên trường học là giá trị bắt buộc phải nhập!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txtDiaChiTruong.Text == "")
                    MessageBoxEx.Show("Địa chỉ trường là giá trị bắt buộc phải nhập!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhTruong(txtTenTruong.Text, txtDiaChiTruong.Text);
                    MessageBoxEx.Show("Cập nhật thành công thông tin trường học!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
                }
            }
            else if (tabControlPanelThangDiem.CanSelect)
            {
                if (ckbThang10.Checked == true)
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhThangDiem(10);
                    MessageBoxEx.Show("Cập nhật thành công quy định về thang điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
                }
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhThangDiem(100);
                    MessageBoxEx.Show("Cập nhật thành công quy định về thang điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(txtSiSoCanDuoi, txtSiSoCanTren, txtDoTuoiCanDuoi, txtDoTuoiCanTren, ckbThang10, ckbThang100, txtTenTruong, txtDiaChiTruong);
                }
            }
        }
        #endregion
    }
}