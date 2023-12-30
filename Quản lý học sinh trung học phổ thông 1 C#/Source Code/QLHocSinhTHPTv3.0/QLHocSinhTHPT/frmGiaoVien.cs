using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHocSinhTHPT.Controller;
using QLHocSinhTHPT.Component;
using DevComponents.DotNetBar;

namespace QLHocSinhTHPT
{
    public partial class frmGiaoVien : Office2007Form
    {
        #region Fields
        GiaoVienCtrl    m_GiaoVienCtrl  = new GiaoVienCtrl();
        MonHocCtrl      m_MonHocCtrl    = new MonHocCtrl();
        QuyDinh         quyDinh         = new QuyDinh();
        #endregion

        #region Constructor
        public frmGiaoVien()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThiComboBox(cmbMonHoc);
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(colMaMonHoc);
            
            m_GiaoVienCtrl.HienThi(dGVGiaoVien, bindingNavigatorGiaoVien, txtMaGiaoVien, txtTenGiaoVien, txtDiaChi, txtDienThoai, cmbMonHoc);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVGiaoVien.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorGiaoVien.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVGiaoVien.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row       = m_GiaoVienCtrl.ThemDongMoi();
            m_Row["MaGiaoVien"] = "GV" + quyDinh.LaySTT(dGVGiaoVien.Rows.Count + 1);
            m_Row["TenGiaoVien"]= "";
            m_Row["DiaChi"]     = "";
            m_Row["DienThoai"]  = "";
            m_Row["MaMonHoc"]   = "";
            m_GiaoVienCtrl.ThemGiaoVien(m_Row);
            bindingNavigatorGiaoVien.BindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            m_GiaoVienCtrl.HienThi(dGVGiaoVien, bindingNavigatorGiaoVien, txtMaGiaoVien, txtTenGiaoVien, txtDiaChi, txtDienThoai, cmbMonHoc);
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVGiaoVien.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin giáo viên " + row.Cells["colTenGiaoVien"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaGiaoVien")     == true &&
                KiemTraTruocKhiLuu("colTenGiaoVien")    == true &&
                KiemTraTruocKhiLuu("colDiaChi")         == true &&
                KiemTraTruocKhiLuu("colDienThoai")      == true &&
                KiemTraTruocKhiLuu("colMaMonHoc")       == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_GiaoVienCtrl.LuuGiaoVien();
            }
        }
        #endregion

        #region DataError event
        private void dGVGiaoVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Tìm kiếm giáo viên
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemGiaoVien();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemGiaoVien();
        }

        void TimKiemGiaoVien()
        {
            if (chkTimTheoMa.Checked == true)
            {
                m_GiaoVienCtrl.TimTheoMa(txtTimKiem.Text);
            }
            else
            {
                m_GiaoVienCtrl.TimTheoTen(txtTimKiem.Text);
            }
        }
        #endregion

        #region Click event
        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormMonHoc();
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(colMaMonHoc);
        }

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            if (txtTenGiaoVien.Text     != "" &&
                txtDiaChi.Text          != "" &&
                txtDienThoai.Text       != "" &&
                cmbMonHoc.SelectedValue != null)
            {
                m_GiaoVienCtrl.LuuGiaoVien(txtMaGiaoVien.Text, txtTenGiaoVien.Text, txtDiaChi.Text, txtDienThoai.Text, cmbMonHoc.SelectedValue.ToString());
                m_GiaoVienCtrl.HienThi(dGVGiaoVien, bindingNavigatorGiaoVien, txtMaGiaoVien, txtTenGiaoVien, txtDiaChi, txtDienThoai, cmbMonHoc);
                
                bindingNavigatorGiaoVien.BindingSource.MoveLast();
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}