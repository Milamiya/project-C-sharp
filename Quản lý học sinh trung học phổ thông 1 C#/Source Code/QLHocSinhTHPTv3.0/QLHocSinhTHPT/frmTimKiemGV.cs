using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHocSinhTHPT.Controller;
using DevComponents.DotNetBar;

namespace QLHocSinhTHPT
{
    public partial class frmTimKiemGV : Office2007Form
    {
        #region Fields
        MonHocCtrl      m_MonHocCtrl    = new MonHocCtrl();
        GiaoVienCtrl    m_GiaoVienCtrl  = new GiaoVienCtrl();
        #endregion

        #region Constructor
        public frmTimKiemGV()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmTimKiemGV_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThiComboBox(cmbCMon);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Tìm kiếm giáo viên
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            m_GiaoVienCtrl.TimKiemGiaoVien(txtHoTen, cmbTheoDChi, txtDiaChi, cmbTheoCMon, cmbCMon, dGVKetQuaTimKiem, bindingNavigatorKetQuaTimKiem);
            
            if (dGVKetQuaTimKiem.RowCount == 0)
                MessageBoxEx.Show("Không có giáo viên cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}