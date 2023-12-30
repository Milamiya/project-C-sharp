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
    public partial class frmKetQua : Office2007Form
    {
        #region Fields
        KetQuaCtrl  m_KetQuaCtrl    = new KetQuaCtrl();
        QuyDinh     quyDinh         = new QuyDinh();
        #endregion

        #region Constructor
        public frmKetQua()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmKetQua_Load(object sender, EventArgs e)
        {
            m_KetQuaCtrl.HienThi(dGVKetQua, bindingNavigatorKetQua);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVKetQua.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKetQua.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVKetQua.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row       = m_KetQuaCtrl.ThemDongMoi();
            m_Row["MaKetQua"]   = "KQ" + quyDinh.LaySTT(dGVKetQua.Rows.Count + 1);
            m_Row["TenKetQua"]  = "";
            m_KetQuaCtrl.ThemKetQua(m_Row);
            bindingNavigatorKetQua.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVKetQua.Rows)
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
            if (KiemTraTruocKhiLuu("colMaKetQua")  == true &&
                KiemTraTruocKhiLuu("colTenKetQua") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_KetQuaCtrl.LuuKetQua();
            }
        }
        #endregion

        #region DataError event
        private void dGVKetQua_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion
    }
}