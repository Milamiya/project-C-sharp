using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class ChucVuControl
    {
        ChucVuData m_ChucVuData = new ChucVuData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_ChucVuData.LayDsChucVu();
            cmb.DisplayMember = "TenChucVu";
            cmb.ValueMember = "MaChucVu";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnChucVu(DataGridViewComboBoxColumn cmbColumnChucVu)
        {
            cmbColumnChucVu.DataSource = m_ChucVuData.LayDsChucVu();
            cmbColumnChucVu.DisplayMember = "TenChucVu";
            cmbColumnChucVu.ValueMember = "MaChucVu";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_ChucVuData.LayDsChucVu();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaChucVu, TextBox txtTenChucVu)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_ChucVuData.LayDsChucVu();
            bS.DataSource = tbl;

            txtMaChucVu.DataBindings.Clear();
            txtMaChucVu.DataBindings.Add("Text", bS, "MaChucVu");
            txtTenChucVu.DataBindings.Clear();
            txtTenChucVu.DataBindings.Add("Text", bS, "TenChucVu");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_ChucVuData.ThemDongMoi();
        }

        public void ThemChucVu(DataRow m_Row)
        {
            m_ChucVuData.ThemChucVu(m_Row);
        }

        public bool LuuChucVu()
        {
            return m_ChucVuData.LuuChucVu();
        }
    }


}


