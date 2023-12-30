using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using QLHocSinhTHPT.DataLayer;
using QLHocSinhTHPT.Bussiness;

namespace QLHocSinhTHPT.Controller
{
    public class HocSinhCtrl
    {
        HocSinhData m_HocSinhData = new HocSinhData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_HocSinhData.LayDsHocSinh();
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaHocSinh";
        }

        public void HienThiComboBox(String namHoc, String lop, ComboBoxEx comboBox)
        {
            HocSinhData m_HSData = new HocSinhData();

            comboBox.DataSource = m_HSData.LayDsHocSinhTheoLop(namHoc, lop);
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaHocSinh";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_HocSinhData.LayDsHocSinh();
            cmbColumn.DisplayMember = "HoTen";
            cmbColumn.ValueMember = "MaHocSinh";
            cmbColumn.DataPropertyName = "MaHocSinh";
            cmbColumn.HeaderText = "Học sinh";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_HocSinhData.LayDsHocSinh();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaHocSinh,
                            TextBoxX txtTenHocSinh,
                            TextBoxX txtGioiTinh,
                            CheckBoxX ckbGTinhNam,
                            CheckBoxX ckbGTinhNu,
                            DateTimeInput dtpNgaySinh,
                            TextBoxX txtNoiSinh,
                            ComboBoxEx cmbDanToc,
                            ComboBoxEx cmbTonGiao,
                            TextBoxX txtHoTenCha,
                            ComboBoxEx cmbNgheNghiepCha,
                            TextBoxX txtHoTenMe,
                            ComboBoxEx cmbNgheNghiepMe)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinh();

            DataTable dT = m_HocSinhData.LayDsHocSinh();
            bool gioiTinh = Convert.ToBoolean(dT.Rows[0]["GioiTinh"]);

            if (gioiTinh)
                ckbGTinhNu.Checked = true;
            else
                ckbGTinhNam.Checked = true;

            txtMaHocSinh.DataBindings.Clear();
            txtMaHocSinh.DataBindings.Add("Text", bS, "MaHocSinh");

            txtTenHocSinh.DataBindings.Clear();
            txtTenHocSinh.DataBindings.Add("Text", bS, "HoTen");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", bS, "GioiTinh");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bS, "NgaySinh");

            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("Text", bS, "NoiSinh");

            cmbDanToc.DataBindings.Clear();
            cmbDanToc.DataBindings.Add("SelectedValue", bS, "MaDanToc");

            cmbTonGiao.DataBindings.Clear();
            cmbTonGiao.DataBindings.Add("SelectedValue", bS, "MaTonGiao");

            txtHoTenCha.DataBindings.Clear();
            txtHoTenCha.DataBindings.Add("Text", bS, "HoTenCha");
            
            cmbNgheNghiepCha.DataBindings.Clear();
            cmbNgheNghiepCha.DataBindings.Add("SelectedValue", bS, "MaNNghiepCha");

            txtHoTenMe.DataBindings.Clear();
            txtHoTenMe.DataBindings.Add("Text", bS, "HoTenMe");

            cmbNgheNghiepMe.DataBindings.Clear();
            cmbNgheNghiepMe.DataBindings.Add("SelectedValue", bS, "MaNNghiepMe");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        public void HienThiDsHocSinhTheoLop(DataGridViewX dGV, BindingNavigator bN, String namHoc, String lop)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinhTheoLop(namHoc, lop);
            
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThiDsHocSinhTheoLop(String namHoc, String khoiLop, String lop, ListViewEx lV)
        {
            DataTable m_DT = m_HocSinhData.LayDsHocSinhTheoLop(namHoc, khoiLop, lop);

            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["MaHocSinh"].ToString();
                item.SubItems.Add(Row["HoTen"].ToString());
                
                lV.Items.Add(item);
            }
        }

        public DataTable HienThiDsHocSinhTheoNamHoc(String namHoc)
        {
            return m_HocSinhData.LayDsHocSinhTheoNamHoc(namHoc);
        }

        public void XoaHSKhoiBangPhanLop(String namHocCu, String khoiLopCu, String lopCu, ListViewEx hocSinh)
        {
            foreach (ListViewItem item in hocSinh.Items)
            {
                m_HocSinhData.XoaHSKhoiBangPhanLop(namHocCu, khoiLopCu, lopCu, item.SubItems[0].Text.ToString());
            }
        }
        
        public void LuuHSVaoBangPhanLop(String namHocMoi, String khoiLopMoi, String lopMoi, ListViewEx hocSinh)
        {
            foreach (ListViewItem item in hocSinh.Items)
            {
                m_HocSinhData.LuuHSVaoBangPhanLop(namHocMoi, khoiLopMoi, lopMoi, item.SubItems[0].Text.ToString());
            }
        }

        #region Lay danh sach hoc sinh do vao report
        public static IList<HocSinhInfo> LayDsHocSinh()
        {
            HocSinhData m_HSData = new HocSinhData();
            DataTable m_DT = m_HSData.LayDsHocSinhForReport();

            IList<HocSinhInfo> dS = new List<HocSinhInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                HocSinhInfo hs = new HocSinhInfo();

                NgheNghiepInfo nn   = new NgheNghiepInfo();
                nn.MaNghe           = Convert.ToString(Row["MaNghe"]);
                nn.TenNghe          = Convert.ToString(Row["TenNghe"]);

                DanTocInfo dt       = new DanTocInfo();
                dt.MaDanToc         = Convert.ToString(Row["MaDanToc"]);
                dt.TenDanToc        = Convert.ToString(Row["TenDanToc"]);

                TonGiaoInfo tg      = new TonGiaoInfo();
                tg.MaTonGiao        = Convert.ToString(Row["MaTonGiao"]);
                tg.TenTonGiao       = Convert.ToString(Row["TenTonGiao"]);

                hs.MaHocSinh        = Convert.ToString(Row["MaHocSinh"]);
                hs.HoTen            = Convert.ToString(Row["HoTen"]);
                hs.GioiTinh         = Convert.ToBoolean(Row["GioiTinh"]);
                hs.NgaySinh         = Convert.ToDateTime(Row["NgaySinh"]);
                hs.NoiSinh          = Convert.ToString(Row["NoiSinh"]);
                hs.DanToc           = dt;
                hs.TonGiao          = tg;
                hs.HoTenCha         = Convert.ToString(Row["HoTenCha"]);
                hs.NNghiepCha       = nn;
                hs.HoTenMe          = Convert.ToString(Row["HoTenMe"]);
                hs.NNghiepMe        = nn;

                dS.Add(hs);
            }
            return dS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_HocSinhData.ThemDongMoi();
        }

        public void ThemHocSinh(DataRow m_Row)
        {
            m_HocSinhData.ThemHocSinh(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuHocSinh()
        {
            return m_HocSinhData.LuuHocSinh();
        }

        public void LuuHocSinh(String maHocSinh, String hoTen, bool gioiTinh, DateTime ngaySinh, String noiSinh, String maDanToc, String maTonGiao, String hoTenCha, String maNgheCha, String hoTenMe, String maNgheMe)
        {
            m_HocSinhData.LuuHocSinh(maHocSinh, hoTen, gioiTinh, ngaySinh, noiSinh, maDanToc, maTonGiao, hoTenCha, maNgheCha, hoTenMe, maNgheMe);
        }
        #endregion

        #region Tim kiem
        public void TimKiemHocSinh(TextBoxX txtHoTen,
                                   ComboBoxEx cmbTheoNSinh,
                                   TextBoxX txtNoiSinh,
                                   ComboBoxEx cmbTheoDToc,
                                   ComboBoxEx cmbDanToc,
                                   ComboBoxEx cmbTheoTGiao,
                                   ComboBoxEx cmbTonGiao,
                                   DataGridViewX dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.TimKiemHocSinh(txtHoTen.Text, cmbTheoNSinh.Text, txtNoiSinh.Text, cmbTheoDToc.Text, cmbDanToc.Text, cmbTheoTGiao.Text, cmbTonGiao.Text);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void TimTheoMa(String m_MaHocSinh)
        {
            m_HocSinhData.TimTheoMa(m_MaHocSinh);
        }

        public void TimTheoTen(String m_TenHocSinh)
        {
            m_HocSinhData.TimTheoTen(m_TenHocSinh);
        }
        #endregion
    }
}
