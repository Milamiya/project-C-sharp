using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class KhenThuongControl
    {
        KhenThuongData m_KhenThuongData = new KhenThuongData();
        NhanVienData m_NhanVienData = new NhanVienData();
        public void HienThiDataGridView(DataGridView DGV)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_KhenThuongData.LayDanhsachKhenThuong();
            DGV.DataSource = bs;
        }

        public void HienThi(DataGridView DGV, BindingNavigator bN, MaskedTextBox txtMaKhenThuong, ComboBox cmbMaNhanVien, TextBox txtLoaiKhenThuong,  TextBox txtHinhThucKhenThuong, TextBox txtCapKhenThuong, MaskedTextBox txtNam)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_KhenThuongData.LayDanhsachKhenThuong();
            bS.DataSource = tbl;

            txtMaKhenThuong.DataBindings.Clear();
            txtMaKhenThuong.DataBindings.Add("Text", bS, "MaKhenThuong");

            cmbMaNhanVien.DataBindings.Clear();
            cmbMaNhanVien.DataBindings.Add("SelectedValue", bS, "MaNhanVien");

            txtLoaiKhenThuong.DataBindings.Clear();
            txtLoaiKhenThuong.DataBindings.Add("Text", bS, "LoaiKhenThuong");

            txtHinhThucKhenThuong.DataBindings.Clear();
            txtHinhThucKhenThuong.DataBindings.Add("Text", bS, "HinhThucKhenThuong");

            txtCapKhenThuong.DataBindings.Clear();
            txtCapKhenThuong.DataBindings.Add("Text", bS, "CapKhenThuong");

            txtNam.DataBindings.Clear();
            txtNam.DataBindings.Add("Text", bS, "Nam");

            bN.BindingSource = bS;
            DGV.DataSource = bS;
        }

        public DataRow ThemDongMoi()
        {
            return m_KhenThuongData.ThemDongMoi();
        }

        public void ThemKhenThuong(DataRow m_Row)
        {
            m_KhenThuongData.ThemKhenThuong(m_Row);
        }

        public bool LuuKhenThuong()
        {
            return m_KhenThuongData.LuuKhenThuong();
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
            DGV.DataSource = m_KhenThuongData.LayDSNV(maNV);

        }
    }
}
