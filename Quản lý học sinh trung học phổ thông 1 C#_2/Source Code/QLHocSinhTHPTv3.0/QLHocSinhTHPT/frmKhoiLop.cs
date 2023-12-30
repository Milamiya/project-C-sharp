using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using QLHocSinhTHPT.Controller;
using DevComponents.DotNetBar;

namespace QLHocSinhTHPT
{
    public partial class frmKhoiLop : Office2007Form
    {
        #region Field
        KhoiLopCtrl m_KhoiLopCtrl   = new KhoiLopCtrl();
        #endregion

        #region constructor
        public frmKhoiLop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmKhoiLop_Load(object sender, EventArgs e)
        {
            m_KhoiLopCtrl.HienThi(dGVKhoiLop, bindingNavigatorKhoiLop);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVKhoiLop.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKhoiLop.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVKhoiLop.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row       = m_KhoiLopCtrl.ThemDongMoi();
            m_Row["MaKhoiLop"]  = "";
            m_Row["TenKhoiLop"] = "";
            m_KhoiLopCtrl.ThemKhoiLop(m_Row);
            bindingNavigatorKhoiLop.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVKhoiLop.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaKhoiLop")  == true &&
                KiemTraTruocKhiLuu("colTenkhoiLop") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_KhoiLopCtrl.LuuKhoiLop();
            }
        }
        #endregion

        #region DataError event
        private void dGVKhoiLop_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion
    }
}
