using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QuanLyTienGuiTietKiem.DataLayer;
using QuanLyTienGuiTietKiem.General;
using QuanLyTienGuiTietKiem.Bussiness;

namespace QuanLyTienGuiTietKiem.Controller
{
    class GiaoDichVienCtrl
    {
        GiaoDichVienData m_GiaoDichVienData = new GiaoDichVienData();
        NhanVienInfo m_NhanVienInfo = new NhanVienInfo();

        public void HienThiComboBox(ComboBox cbx)
        {
            DataTable m_DT = m_GiaoDichVienData.GetGiaoDichVienTen();
            cbx.DataSource = m_DT;
            cbx.DisplayMember = "HoTen";
            cbx.ValueMember = "MaNV";
        }


        #region hien thi
        public void HienThi(DataGridView Dgv, BindingNavigator bvn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_GiaoDichVienData.GetGiaoDichVien();
            bvn.BindingSource = bs;
            Dgv.DataSource = bs;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaNV,
                            TextBoxX txtHanmucthu,
                            TextBoxX txtHanmucchi,
                            TextBoxX txtMuctonquy
                            )
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_GiaoDichVienData.GetGiaoDichVien();

            txtMaNV.DataBindings.Clear();//SelectedValue
            txtMaNV.DataBindings.Add("Text", bS, "MaNV");

            txtHanmucthu.DataBindings.Clear();
            txtHanmucthu.DataBindings.Add("Text", bS, "HanMucThu");

            txtHanmucchi.DataBindings.Clear();
            txtHanmucchi.DataBindings.Add("Text", bS, "HanMucChi");

            txtMuctonquy.DataBindings.Clear();
            txtMuctonquy.DataBindings.Add("Text", bS, "HanMucTonQuy");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_GiaoDichVienData.ThemDongMoi();
        }
        public void ThemMoi(DataRow m_Row)
        {
           m_GiaoDichVienData.ThemGiaoDichVien(m_Row);
        }
        #endregion

        #region Luu
        public bool LuuGiaoDichVien()
        {
            return m_GiaoDichVienData.LuuGiaoDichVien();
        }
        #endregion
    }
}
