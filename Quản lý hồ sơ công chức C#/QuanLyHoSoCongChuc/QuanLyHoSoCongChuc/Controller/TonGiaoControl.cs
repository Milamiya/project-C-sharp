using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class TonGiaoControl
    {
        TonGiaoData m_TonGiaoData = new TonGiaoData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_TonGiaoData.LayDanhSachTonGiao();
            cmb.DisplayMember = "TenTonGiao";
            cmb.ValueMember = "MaTonGiao";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnTonGiao(DataGridViewComboBoxColumn cmbColumnTonGiao)
        {
            cmbColumnTonGiao.DataSource = m_TonGiaoData.LayDanhSachTonGiao();
            cmbColumnTonGiao.DisplayMember = "TenTonGiao";
            cmbColumnTonGiao.ValueMember = "MaTonGiao";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TonGiaoData.LayDanhSachTonGiao();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaTonGiao, TextBox txtTenTonGiao)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TonGiaoData.LayDanhSachTonGiao();
            bS.DataSource = tbl;

            txtMaTonGiao.DataBindings.Clear();
            txtMaTonGiao.DataBindings.Add("Text", bS, "MaTonGiao");
            txtTenTonGiao.DataBindings.Clear();
            txtTenTonGiao.DataBindings.Add("Text", bS, "TenTonGiao");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_TonGiaoData.ThemDongMoi();
        }

        public void ThemTonGiao(DataRow m_Row)
        {
            m_TonGiaoData.ThemTonGiao(m_Row);
        }

        public bool LuuTonGiao()
        {
            return m_TonGiaoData.LuuTonGiao();
        }
    }


}


