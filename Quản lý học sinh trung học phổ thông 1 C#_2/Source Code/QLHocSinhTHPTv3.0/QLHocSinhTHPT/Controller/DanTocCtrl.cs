using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLHocSinhTHPT.DataLayer;

namespace QLHocSinhTHPT.Controller
{
    public class DanTocCtrl
    {
        DanTocData m_DanTocData = new DanTocData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_DanTocData.LayDsDanToc();
            comboBox.DisplayMember = "TenDanToc";
            comboBox.ValueMember = "MaDanToc";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_DanTocData.LayDsDanToc();
            cmbColumn.DisplayMember = "TenDanToc";
            cmbColumn.ValueMember = "MaDanToc";
            cmbColumn.DataPropertyName = "MaDanToc";
            cmbColumn.HeaderText = "Dân tộc";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_DanTocData.LayDsDanToc();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_DanTocData.ThemDongMoi();
        }

        public void ThemDanToc(DataRow m_Row)
        {
            m_DanTocData.ThemDanToc(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuDanToc()
        {
            return m_DanTocData.LuuDanToc();
        }
        #endregion
    }
}
