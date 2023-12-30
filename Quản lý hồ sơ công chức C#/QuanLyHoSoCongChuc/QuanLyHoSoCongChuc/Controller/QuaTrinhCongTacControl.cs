using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class QuaTrinhCongTacControl
    {
        QuaTrinhCongTacData m_QTCTData = new QuaTrinhCongTacData();
        NhanVienData m_NhanVienData = new NhanVienData();
        public void HienThiDataGridView(DataGridView DGV)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_QTCTData.LayDanhsachQTCT();
            DGV.DataSource = bs;
        }
        public void HienThi(DataGridView DGV, BindingNavigator bN, TextBox txtMaQTCT, ComboBox cmbMaNhanVien, TextBox txtTenQTCT, DateTimePicker ThoiGianBatDauQTCT, DateTimePicker ThoiGianKetThucQTCT)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_QTCTData.LayDanhsachQTCT();
            bS.DataSource = tbl;

            txtMaQTCT.DataBindings.Clear();
            txtMaQTCT.DataBindings.Add("Text", bS, "MaQuaTrinhCongTac");

            cmbMaNhanVien.DataBindings.Clear();
            cmbMaNhanVien.DataBindings.Add("SelectedValue", bS, "MaNhanVien");

            txtTenQTCT.DataBindings.Clear();
            txtTenQTCT.DataBindings.Add("Text", bS, "TenQuaTrinhCongTac");

            ThoiGianBatDauQTCT.DataBindings.Clear();
            ThoiGianBatDauQTCT.DataBindings.Add("Value", bS, "ThoiGianBatDau");

            ThoiGianKetThucQTCT.DataBindings.Clear();
            ThoiGianKetThucQTCT.DataBindings.Add("Value", bS, "ThoiGianKetThuc");

            bN.BindingSource = bS;
            DGV.DataSource = bS;
        }

        public DataRow ThemDongMoi()
        {
            return m_QTCTData.ThemDongMoi();
        }

        public void ThemQTCT(DataRow m_Row)
        {
            m_QTCTData.ThemQTCT(m_Row);
        }

        public bool LuuQTCT()
        {
            return m_QTCTData.LuuQTCT();
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

        public void HienDSCT(DataGridView DGV, string maNV)
        {
            DGV.DataSource = m_QTCTData.LayDSCT(maNV);

        }

    }
}
