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
    public partial class frmDanToc : Office2007Form
    {
        #region Fields
        DanTocCtrl  m_DanTocCtrl = new DanTocCtrl();
        QuyDinh     quyDinh      = new QuyDinh();
        #endregion

        #region Constructor
        public frmDanToc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmDanToc_Load(object sender, EventArgs e)
        {
            m_DanTocCtrl.HienThi(dGVDanToc, bindingNavigatorDanToc);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVDanToc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorDanToc.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVDanToc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row       = m_DanTocCtrl.ThemDongMoi();
            m_Row["MaDanToc"]   = "DT" + quyDinh.LaySTT(dGVDanToc.Rows.Count + 1);
            m_Row["TenDanToc"]  = "";
            m_DanTocCtrl.ThemDanToc(m_Row);
            bindingNavigatorDanToc.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVDanToc.Rows)
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
            if (KiemTraTruocKhiLuu("colMaDanToc")   == true &&
                KiemTraTruocKhiLuu("colTenDanToc")  == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_DanTocCtrl.LuuDanToc();
            }
        }
        #endregion

        #region DataError event
        private void dGVDanToc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion
    }
}