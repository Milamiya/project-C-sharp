using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLHocSinhTHPT.DataLayer;

namespace QLHocSinhTHPT.Controller
{
    public class MonHocCtrl
    {
        MonHocData m_MonHocData = new MonHocData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_MonHocData.LayDsMonHoc();
            comboBox.DisplayMember = "TenMonHoc";
            comboBox.ValueMember = "MaMonHoc";
        }

        public void HienThiComboBox(String namHoc, String lop, ComboBoxEx comboBox)
        {
            MonHocData m_MHData = new MonHocData();

            comboBox.DataSource = m_MHData.LayDsMonHoc(namHoc, lop);
            comboBox.DisplayMember = "TenMonHoc";
            comboBox.ValueMember = "MaMonHoc";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_MonHocData.LayDsMonHoc();
            cmbColumn.DisplayMember = "TenMonHoc";
            cmbColumn.ValueMember = "MaMonHoc";
            cmbColumn.DataPropertyName = "MaMonHoc";
            cmbColumn.HeaderText = "Môn học";
        }

        public void HienThiDataGridViewComboBoxColumnGiaoVien(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_MonHocData.LayDsMonHoc();
            cmbColumn.DisplayMember = "TenMonHoc";
            cmbColumn.ValueMember = "MaMonHoc";
            cmbColumn.DataPropertyName = "MaMonHoc";
            cmbColumn.HeaderText = "Chuyên môn";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_MonHocData.LayDsMonHoc();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_MonHocData.ThemDongMoi();
        }

        public void ThemMonHoc(DataRow m_Row)
        {
            m_MonHocData.ThemMonHoc(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuMonHoc()
        {
            return m_MonHocData.LuuMonHoc();
        }
        #endregion
    }
}
