using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHocSinhTHPT.Controller;
using DevComponents.DotNetBar;

namespace QLHocSinhTHPT
{
    public partial class frmHocKy : Office2007Form
    {
        #region Field
        HocKyCtrl   m_HocKyCtrl   = new HocKyCtrl();
        #endregion

        #region Constructor
        public frmHocKy()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmHocKy_Load(object sender, EventArgs e)
        {
            m_HocKyCtrl.HienThi(dGVHocKy, bindingNavigatorHocKy);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVHocKy.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorHocKy.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVHocKy.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row       = m_HocKyCtrl.ThemDongMoi();
            m_Row["MaHocKy"]    = "";
            m_Row["TenHocKy"]   = "";
            m_Row["HeSo"]       = 0;
            m_HocKyCtrl.ThemHocKy(m_Row);
            bindingNavigatorHocKy.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVHocKy.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "" || str == "0")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng và hệ số phải lớn hơn 0!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaHocKy")  == true &&
                KiemTraTruocKhiLuu("colTenHocKy") == true &&
                KiemTraTruocKhiLuu("colHeSo")     == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_HocKyCtrl.LuuHocKy();
            }
        }
        #endregion

        #region DataError event
        private void dGVHocKy_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion
    }
}