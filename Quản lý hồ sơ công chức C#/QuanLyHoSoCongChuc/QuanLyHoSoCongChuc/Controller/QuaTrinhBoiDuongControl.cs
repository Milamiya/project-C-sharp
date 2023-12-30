using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class QuaTrinhBoiDuongControl
    {
        QuaTrinhBoiDuongData m_QTBDData = new QuaTrinhBoiDuongData();
        NhanVienData m_NhanVienData = new NhanVienData();
        public void HienThiDataGridView(DataGridView DGV)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_QTBDData.LayDanhsachQTBD();
            DGV.DataSource = bs;
        }

        public void HienThi(DataGridView DGV, BindingNavigator bN, MaskedTextBox txtMaQTBD, ComboBox cmbMaNhanVien, TextBox txtTenQTBD, TextBox ThoiGian, TextBox txtNoiBoiDuong, TextBox txtLoaiHinhBoiDuong, TextBox txtChungChi)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_QTBDData.LayDanhsachQTBD();
            bS.DataSource = tbl;

            txtMaQTBD.DataBindings.Clear();
            txtMaQTBD.DataBindings.Add("Text", bS, "MaQuaTrinhBoiDuong");

            cmbMaNhanVien.DataBindings.Clear();
            cmbMaNhanVien.DataBindings.Add("SelectedValue", bS, "MaNhanVien");

            txtTenQTBD.DataBindings.Clear();
            txtTenQTBD.DataBindings.Add("Text", bS, "TenQuaTrinhBoiDuong");

            ThoiGian.DataBindings.Clear();
            ThoiGian.DataBindings.Add("Text", bS, "ThoiGian");

            txtNoiBoiDuong.DataBindings.Clear();
            txtNoiBoiDuong.DataBindings.Add("Text", bS, "NoiBoiDuong");

            txtLoaiHinhBoiDuong.DataBindings.Clear();
            txtLoaiHinhBoiDuong.DataBindings.Add("Text", bS, "LoaiHinhBoiDuong");

            txtChungChi.DataBindings.Clear();
            txtChungChi.DataBindings.Add("Text", bS, "ChungChi");

            bN.BindingSource = bS;
            DGV.DataSource = bS;
        }

        public DataRow ThemDongMoi()
        {
            return m_QTBDData.ThemDongMoi();
        }

        public void ThemQTBD(DataRow m_Row)
        {
            m_QTBDData.ThemQTBD(m_Row);
        }

        public bool LuuQTBD()
        {
            return m_QTBDData.LuuQTBD();
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
            DGV.DataSource = m_QTBDData.LayDSNV(maNV);

        }
    }
}
