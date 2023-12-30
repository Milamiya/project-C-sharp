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
    public partial class frmHanhKiem : Office2007Form
    {
        #region Fields
        HanhKiemCtrl m_HanhKiemCtrl = new HanhKiemCtrl();
        QuyDinh      quyDinh        = new QuyDinh();
        #endregion

        #region Constructor
        public frmHanhKiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frmHanhKiem_Load(object sender, EventArgs e)
        {
            m_HanhKiemCtrl.HienThi(dGVHanhKiem, bindingNavigatorHanhKiem);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dGVHanhKiem.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorHanhKiem.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dGVHanhKiem.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row           = m_HanhKiemCtrl.ThemDongMoi();
            m_Row["MaHanhKiem"]     = "HK" + quyDinh.LaySTT(dGVHanhKiem.Rows.Count + 1);
            m_Row["TenHanhKiem"]    = "";
            m_HanhKiemCtrl.ThemHanhKiem(m_Row);
            bindingNavigatorHanhKiem.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dGVHanhKiem.Rows)
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
            if (KiemTraTruocKhiLuu("colMaHanhKiem")  == true &&
                KiemTraTruocKhiLuu("colTenHanhKiem") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_HanhKiemCtrl.LuuHanhKiem();
            }
        }
        #endregion

        #region DataError event
        private void dGVHanhKiem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion
    }
}