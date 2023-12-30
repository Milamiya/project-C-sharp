using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLHocSinhTHPT.DataLayer;

namespace QLHocSinhTHPT.Controller
{
    public class HanhKiemCtrl
    {
        HanhKiemData m_HanhKiemData = new HanhKiemData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_HanhKiemData.LayDsHanhKiem();
            comboBox.DisplayMember = "TenHanhKiem";
            comboBox.ValueMember = "MaHanhKiem";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_HanhKiemData.LayDsHanhKiem();
            cmbColumn.DisplayMember = "TenHanhKiem";
            cmbColumn.ValueMember = "MaHanhKiem";
            cmbColumn.DataPropertyName = "MaHanhKiem";
            cmbColumn.HeaderText = "Hạnh kiểm";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_HanhKiemData.LayDsHanhKiem();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_HanhKiemData.ThemDongMoi();
        }

        public void ThemHanhKiem(DataRow m_Row)
        {
            m_HanhKiemData.ThemHanhKiem(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuHanhKiem()
        {
            return m_HanhKiemData.LuuHanhKiem();
        }
        #endregion
    }
}
