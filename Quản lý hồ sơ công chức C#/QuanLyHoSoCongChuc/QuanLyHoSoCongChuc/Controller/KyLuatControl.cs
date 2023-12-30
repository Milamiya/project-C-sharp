using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class KyLuatControl
    {
        KyLuatData m_KyLuatData = new KyLuatData();
        NhanVienData m_NhanVienData = new NhanVienData();
        public void HienThiDataGridView(DataGridView DGV)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_KyLuatData.LayDanhsachKyLuat();
            DGV.DataSource = bs;
        }

        public void HienThi(DataGridView DGV, BindingNavigator bN, MaskedTextBox txtMaKyLuat, ComboBox cmbMaNhanVien, TextBox txtHinhThucKyLuat, DateTimePicker NgayKyLuat, TextBox txtCoQuanRaQuyetDinh, TextBox txtNguyenNhan, TextBox txtCoQuanSauKyLuat)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_KyLuatData.LayDanhsachKyLuat();
            bS.DataSource = tbl;

            txtMaKyLuat.DataBindings.Clear();
            txtMaKyLuat.DataBindings.Add("Text", bS, "MaKyLuat");

            cmbMaNhanVien.DataBindings.Clear();
            cmbMaNhanVien.DataBindings.Add("SelectedValue", bS, "MaNhanVien");

            txtHinhThucKyLuat.DataBindings.Clear();
            txtHinhThucKyLuat.DataBindings.Add("Text", bS, "HinhThucKyLuat");

            NgayKyLuat.DataBindings.Clear();
            NgayKyLuat.DataBindings.Add("Value", bS, "NgayKyLuat");

            txtCoQuanRaQuyetDinh.DataBindings.Clear();
            txtCoQuanRaQuyetDinh.DataBindings.Add("Text", bS, "CoQuanRaQuyetDinh");

            txtNguyenNhan.DataBindings.Clear();
            txtNguyenNhan.DataBindings.Add("Text", bS, "NguyenNhan");

            txtCoQuanSauKyLuat.DataBindings.Clear();
            txtCoQuanSauKyLuat.DataBindings.Add("Text", bS, "CoQuanSauKyLuat");

            bN.BindingSource = bS;
            DGV.DataSource = bS;
        }

        public DataRow ThemDongMoi()
        {
            return m_KyLuatData.ThemDongMoi();
        }

        public void ThemKyLuat(DataRow m_Row)
        {
            m_KyLuatData.ThemKyLuat(m_Row);
        }

        public bool LuuKyLuat()
        {
            return m_KyLuatData.LuuKyLuat();
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
            DGV.DataSource = m_KyLuatData.LayDSNV(maNV);

        }
    }
}
