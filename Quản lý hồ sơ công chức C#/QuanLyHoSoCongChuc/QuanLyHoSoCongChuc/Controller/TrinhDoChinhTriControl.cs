using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class TrinhDoChinhTriControl
    {
        TrinhDoChinhTriData m_TrinhDoChinhTriData = new TrinhDoChinhTriData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_TrinhDoChinhTriData.LayDanhSachTrinhDoChinhTri();
            cmb.DisplayMember = "TenTrinhDoChinhTri";
            cmb.ValueMember = "MaTrinhDoChinhTri";
        }

        //        
        public void HienThiDataGridViewComboBoxColumnTrinhDoChinhTri(DataGridViewComboBoxColumn cmbColumnTrinhDoChinhTri)
        {
            cmbColumnTrinhDoChinhTri.DataSource = m_TrinhDoChinhTriData.LayDanhSachTrinhDoChinhTri();
            cmbColumnTrinhDoChinhTri.DisplayMember = "TenTrinhDoChinhTri";
            cmbColumnTrinhDoChinhTri.ValueMember = "MaTrinhDoChinhTri";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TrinhDoChinhTriData.LayDanhSachTrinhDoChinhTri();
            bS.DataSource = tbl;
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        //Hien thi DataGirdView     
        public void HienThi(DataGridView dGV, BindingNavigator bN, TextBox txtMaTrinhDoChinhTri, TextBox txtTenTrinhDoChinhTri)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_TrinhDoChinhTriData.LayDanhSachTrinhDoChinhTri();
            bS.DataSource = tbl;

            txtMaTrinhDoChinhTri.DataBindings.Clear();
            txtMaTrinhDoChinhTri.DataBindings.Add("Text", bS, "MaTrinhDoChinhTri");
            txtTenTrinhDoChinhTri.DataBindings.Clear();
            txtTenTrinhDoChinhTri.DataBindings.Add("Text", bS, "TenTrinhDoChinhTri");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_TrinhDoChinhTriData.ThemDongMoi();
        }

        public void ThemTrinhDoChinhTri(DataRow m_Row)
        {
            m_TrinhDoChinhTriData.ThemTrinhDoChinhTri(m_Row);
        }

        public bool LuuTrinhDoChinhTri()
        {
            return m_TrinhDoChinhTriData.LuuTrinhDoChinhTri();
        }
    }


}


