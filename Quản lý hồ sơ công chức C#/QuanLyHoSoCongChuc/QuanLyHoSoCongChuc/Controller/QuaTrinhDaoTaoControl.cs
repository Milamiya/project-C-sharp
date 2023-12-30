using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class QuaTrinhDaoTaoControl
    {
        QuaTrinhDaoTaoData m_QTDTData = new QuaTrinhDaoTaoData();
        NhanVienData m_NhanVienData = new NhanVienData();
        public void HienThiDataGridView(DataGridView DGV)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_QTDTData.LayDanhsachQTDT();
            DGV.DataSource = bs;
        }
      
        public void HienThi(DataGridView DGV, BindingNavigator bN, TextBox txtMaQTDT, ComboBox cmbMaNhanVien, TextBox txtTenQTDT, DateTimePicker ThoiGianBatDauQTDT, DateTimePicker ThoiGianKetThucQTDT, TextBox txtHinhThucDT, TextBox txtBangCap)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_QTDTData.LayDanhsachQTDT();
            bS.DataSource = tbl;

            txtMaQTDT.DataBindings.Clear();
            txtMaQTDT.DataBindings.Add("Text", bS, "MaQuaTrinhDaoTao");

            cmbMaNhanVien.DataBindings.Clear();
            cmbMaNhanVien.DataBindings.Add("SelectedValue", bS, "MaNhanVien");

            txtTenQTDT.DataBindings.Clear();
            txtTenQTDT.DataBindings.Add("Text", bS, "TenQuaTrinhDaoTao");

            ThoiGianBatDauQTDT.DataBindings.Clear();
            ThoiGianBatDauQTDT.DataBindings.Add("Value", bS, "ThoiGianBatDauDaoTao");

            ThoiGianKetThucQTDT.DataBindings.Clear();
            ThoiGianKetThucQTDT.DataBindings.Add("Value", bS, "ThoiGianKetThucDaoTao");

            txtHinhThucDT.DataBindings.Clear();
            txtHinhThucDT.DataBindings.Add("Text", bS, "HinhThucDaoTao");

            txtBangCap.DataBindings.Clear();
            txtBangCap.DataBindings.Add("Text", bS, "BangCap");

            bN.BindingSource = bS;
            DGV.DataSource = bS;
        }

        public DataRow ThemDongMoi()
        {
            return m_QTDTData.ThemDongMoi();
        }

        public void ThemQTDT(DataRow m_Row)
        {
            m_QTDTData.ThemQTDT(m_Row);
        }

        public bool LuuQTDT()
        {
            return m_QTDTData.LuuQTDT();
        }


        public void HienThiTreeView(TreeView tv)
        {
            DataTable table = m_NhanVienData.LayDanhSachNhanVien();
            System.Windows.Forms.TreeNode n0 = new TreeNode();
            n0.Text = "Danh sách Nhân Viên";
            foreach (DataRow row in table.Rows)
            {
                System.Windows.Forms.TreeNode n1 = new TreeNode();
                n1.Text = row["HoTenNhanVien"].ToString();
                n1.Tag = row["MaNhanVien"].ToString();
                n0.Nodes.Add(n1);
            }

            tv.Nodes.Add(n0);
        }

        public void HienDSDT(DataGridView DGV, string maNV)
        {
            DGV.DataSource = m_QTDTData.LayDSNV(maNV);

        }

    }
}
