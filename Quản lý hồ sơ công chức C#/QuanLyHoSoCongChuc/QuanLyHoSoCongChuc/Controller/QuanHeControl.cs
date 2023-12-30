using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class QuanHeControl
    {
        QuanHeData m_QuanHeData = new QuanHeData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_QuanHeData.LayDsQuanHe();
            cmb.DisplayMember = "TenQuanHe";
            cmb.ValueMember = "MaQuanHe";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnQuanHe(DataGridViewComboBoxColumn cmbColumnQuanHe)
        {
            cmbColumnQuanHe.DataSource = m_QuanHeData.LayDsQuanHe();
            cmbColumnQuanHe.DisplayMember = "TenQuanHe";
            cmbColumnQuanHe.ValueMember = "MaQuanHe";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_QuanHeData.LayDsQuanHe();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaQuanHe, TextBox txtTenQuanHe)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_QuanHeData.LayDsQuanHe();
            bS.DataSource = tbl;

            txtMaQuanHe.DataBindings.Clear();
            txtMaQuanHe.DataBindings.Add("Text", bS, "MaQuanHe");
            txtTenQuanHe.DataBindings.Clear();
            txtTenQuanHe.DataBindings.Add("Text", bS, "TenQuanHe");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_QuanHeData.ThemDongMoi();
        }

        public void ThemQuanHe(DataRow m_Row)
        {
            m_QuanHeData.ThemQuanHe(m_Row);
        }

        public bool LuuQuanHe()
        {
            return m_QuanHeData.LuuQuanHe();
        }
    }


}


