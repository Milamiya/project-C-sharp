using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class ThanhPhanXuatThanControl
    {
        ThanhPhanXuatThanData m_ThanhPhanXuatThanData = new ThanhPhanXuatThanData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_ThanhPhanXuatThanData.LayDanhSachThanhPhanXuatThan();
            cmb.DisplayMember = "TenThanhPhanXuatThan";
            cmb.ValueMember = "MaThanhPhanXuatThan";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnThanhPhanXuatThan(DataGridViewComboBoxColumn cmbColumnThanhPhanXuatThan)
        {
            cmbColumnThanhPhanXuatThan.DataSource = m_ThanhPhanXuatThanData.LayDanhSachThanhPhanXuatThan();
            cmbColumnThanhPhanXuatThan.DisplayMember = "TenThanhPhanXuatThan";
            cmbColumnThanhPhanXuatThan.ValueMember = "MaThanhPhanXuatThan";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_ThanhPhanXuatThanData.LayDanhSachThanhPhanXuatThan();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaThanhPhanXuatThan, TextBox txtTenThanhPhanXuatThan)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_ThanhPhanXuatThanData.LayDanhSachThanhPhanXuatThan();
            bS.DataSource = tbl;

            txtMaThanhPhanXuatThan.DataBindings.Clear();
            txtMaThanhPhanXuatThan.DataBindings.Add("Text", bS, "MaThanhPhanXuatThan");
            txtTenThanhPhanXuatThan.DataBindings.Clear();
            txtTenThanhPhanXuatThan.DataBindings.Add("Text", bS, "TenThanhPhanXuatThan");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_ThanhPhanXuatThanData.ThemDongMoi();
        }

        public void ThemThanhPhanXuatThan(DataRow m_Row)
        {
            m_ThanhPhanXuatThanData.ThemThanhPhanXuatThan(m_Row);
        }

        public bool LuuThanhPhanXuatThan()
        {
            return m_ThanhPhanXuatThanData.LuuThanhPhanXuatThan();
        }
    }


}


