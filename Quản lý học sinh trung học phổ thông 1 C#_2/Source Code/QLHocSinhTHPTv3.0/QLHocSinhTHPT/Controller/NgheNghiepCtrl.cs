using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLHocSinhTHPT.DataLayer;

namespace QLHocSinhTHPT.Controller
{
    public class NgheNghiepCtrl
    {
        NgheNghiepData m_NgheNghiepData = new NgheNghiepData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_NgheNghiepData.LayDsNgheNghiep();
            comboBox.DisplayMember = "TenNghe";
            comboBox.ValueMember = "MaNghe";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumnNNCha(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NgheNghiepData.LayDsNgheNghiep();
            cmbColumn.DisplayMember = "TenNghe";
            cmbColumn.ValueMember = "MaNghe";
            cmbColumn.DataPropertyName = "MaNNghiepCha";
            cmbColumn.HeaderText = "Nghề nghiệp cha";
        }

        public void HienThiDataGridViewComboBoxColumnNNMe(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NgheNghiepData.LayDsNgheNghiep();
            cmbColumn.DisplayMember = "TenNghe";
            cmbColumn.ValueMember = "MaNghe";
            cmbColumn.DataPropertyName = "MaNNghiepMe";
            cmbColumn.HeaderText = "Nghề nghiệp mẹ";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_NgheNghiepData.LayDsNgheNghiep();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NgheNghiepData.ThemDongMoi();
        }

        public void ThemNgheNghiep(DataRow m_Row)
        {
            m_NgheNghiepData.ThemNgheNghiep(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuNgheNghiep()
        {
            return m_NgheNghiepData.LuuNgheNghiep();
        }
        #endregion
    }
}
