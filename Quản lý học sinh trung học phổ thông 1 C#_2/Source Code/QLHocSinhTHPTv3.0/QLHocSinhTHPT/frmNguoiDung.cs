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
    public partial class frmNguoiDung : Office2007Form
    {
        #region Fields
        NguoiDungCtrl       m_NguoiDungCtrl     = new NguoiDungCtrl();
        LoaiNguoiDungCtrl   m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        QuyDinh             quyDinh             = new QuyDinh();
        #endregion

        #region Constructor
        public frmNguoiDung()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaLoai);
            m_NguoiDungCtrl.HienThi(dGVNguoiDung, bindingNavigatorNguoiDung);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNguoiDung.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row       = m_NguoiDungCtrl.ThemDongMoi();
            m_Row["MaND"]       = "ND" + quyDinh.LaySTT(dGVNguoiDung.Rows.Count + 1);
            m_Row["MaLoai"]     = "";
            m_Row["TenND"]      = "";
            m_Row["TenDNhap"]   = "";
            m_Row["MatKhau"]    = "";
            m_NguoiDungCtrl.ThemNguoiDung(m_Row);
            bindingNavigatorNguoiDung.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVNguoiDung.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin người dùng không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaND")       == true &&
                KiemTraTruocKhiLuu("colMaLoai")     == true &&
                KiemTraTruocKhiLuu("colTenND")      == true &&
                KiemTraTruocKhiLuu("colTenDNhap")   == true &&
                KiemTraTruocKhiLuu("colMatKhau")    == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_NguoiDungCtrl.LuuNguoiDung();
            }
        }
        #endregion

        #region DataError event
        private void dGVNguoiDung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Click event
        private void btnThemLoaiND_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormLoaiNguoiDung();
            m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaLoai);
        }
        #endregion
    }
}