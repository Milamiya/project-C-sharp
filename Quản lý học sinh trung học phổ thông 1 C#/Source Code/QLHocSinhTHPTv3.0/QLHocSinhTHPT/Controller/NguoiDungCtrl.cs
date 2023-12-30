using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLHocSinhTHPT.DataLayer;
using QLHocSinhTHPT.Component;
using QLHocSinhTHPT.Bussiness;

namespace QLHocSinhTHPT.Controller
{
    public class NguoiDungCtrl
    {
        NguoiDungData m_NguoiDungData = new NguoiDungData();
        NguoiDungInfo m_NguoiDungInfo = new NguoiDungInfo();
        LoaiNguoiDungInfo m_LoaiNguoiDungInfo = new LoaiNguoiDungInfo();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_NguoiDungData.LayDsNguoiDung();
            comboBox.DisplayMember = "TenND";
            comboBox.ValueMember = "MaND";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NguoiDungData.LayDsNguoiDung();
            cmbColumn.DisplayMember = "TenND";
            cmbColumn.ValueMember = "MaND";
            cmbColumn.DataPropertyName = "MaND";
            cmbColumn.HeaderText = "Người dùng";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_NguoiDungData.LayDsNguoiDung();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NguoiDungData.ThemDongMoi();
        }

        public void ThemNguoiDung(DataRow m_Row)
        {
            m_NguoiDungData.ThemNguoiDung(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuNguoiDung()
        {
            return m_NguoiDungData.LuuNguoiDung();
        }
        #endregion

        #region Dang nhap
        public int DangNhap(string m_Username, string m_Password)
        {
            DataTable m_DT = m_NguoiDungData.LayDsNguoiDung(m_Username);

            if (m_DT.Rows.Count == 0)
                return 0;

            String m_SysPass = m_DT.Rows[0]["MatKhau"].ToString();

            if (m_SysPass != m_Password)
                return 1;
            else
            {
                m_NguoiDungInfo.TenND       = m_DT.Rows[0]["TenND"].ToString();
                m_LoaiNguoiDungInfo.MaLoai  = m_DT.Rows[0]["MaLoai"].ToString();

                m_NguoiDungInfo.LoaiND = m_LoaiNguoiDungInfo;
                
                Utilities.NguoiDung = m_NguoiDungInfo;
                return 2;
            }
        }
        #endregion

        #region Doi mat khau
        public void ChangePassword(String userName, String newPassword)
        {
            m_NguoiDungData.ChangePassword(userName, newPassword);
        }
        #endregion
    }
}
