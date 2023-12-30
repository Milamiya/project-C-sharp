using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QLTuyenDungPresentation
{
    public partial class NhanVienF : Form
    {
        public NhanVienF()
        {
            InitializeComponent();
        }
        private Boolean check()
        {
            if (txtmanv.TextLength < 1 || txttennv.TextLength < 1 || txtmanv.TextLength > 5 || txttennv.TextLength > 30
                || cbohuyen.Text == "" || cbothongbao.Text == "" || cboquocgia.Text == "" || cbotinh.Text == "" || cbochucvu.Text == ""||cbomaphong.Text==""||cbomatintuyendung.Text=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void xoathongtin()
        {
            txtmanv.Clear();
            txttennv.Clear();            
            cbothongbao.ResetText();
            cbomaphong.ResetText();
            cbochucvu.ResetText();
            cbohuyen.ResetText();
            cbotinh.ResetText();
            cboquocgia.ResetText();
            cbomatintuyendung.ResetText();
        }
        private void loadcombobox()
        {
            //Thông báo
            cbothongbao.DisplayMember = "LoaiTB";
            cbothongbao.ValueMember = "MaTB";
            cbothongbao.DataSource = ThongBao_BLL.DSThongBao();

            // Tỉnh
            cbotinh.DisplayMember = "TenTinh";
            cbotinh.ValueMember = "MaTinh";
            cbotinh.DataSource = Tinh_BLL.DSTinh();
            //Quốc gia
            cboquocgia.DisplayMember = "TenQG";
            cboquocgia.ValueMember = "MaQG";
            cboquocgia.DataSource = QuocGia_BLL.DSQuocGia();
            // Huyện
            cbohuyen.DisplayMember = "TenHuyen";
            cbohuyen.ValueMember = "MaHuyen";
            cbohuyen.DataSource = Huyen_BLL.DSHuyen();

            // Phòng
            cbomaphong.DisplayMember = "TenPB";
            cbomaphong.ValueMember = "MaPB";
            cbomaphong.DataSource = PhongBan_BLL.DSPhongBan();
            
            // Vị trí
            cbochucvu.DisplayMember = "TenViTri";
            cbochucvu.ValueMember = "MaViTri";
            cbochucvu.DataSource = ViTri_BLL.DSViTri();
            //Tin tuyển dụng
            cbomatintuyendung.DisplayMember = "TenTT";
            cbomatintuyendung.ValueMember = "MaTT";
            cbomatintuyendung.DataSource = ThongTinTuyenDung_BLL.DSTiNTuyenDung();
        }
        NhanVien_DTO nv = new NhanVien_DTO();
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                nv.MaNV = txtmanv.Text;
                nv.ChucVu = cbochucvu.SelectedValue.ToString();
                nv.MaHuyen = cbohuyen.SelectedValue.ToString();
                nv.MaPB = cbohuyen.SelectedValue.ToString();
                nv.MaQG = cboquocgia.SelectedValue.ToString();
                nv.MaTB = cbothongbao.SelectedValue.ToString();
                nv.MaTinh = cbotinh.SelectedValue.ToString();
                nv.MaTT = cbomatintuyendung.SelectedValue.ToString();
                nv.NgaySinh = mtbngaysinh.Value;
                nv.TenNV = txttennv.Text;
                NhanVien_BLL.Them1NhanVien(nv);
                dgv1.DataSource = NhanVien_BLL.DSNhanVien();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmanv.TextLength < 1 || txtmanv.TextLength > 5)
            {
                
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
            else
            {
                nv.MaNV = txtmanv.Text;
                NhanVien_BLL.Xoa1NhanVien(nv);
                dgv1.DataSource = NhanVien_BLL.DSNhanVien();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                nv.MaNV = txtmanv.Text;
                nv.ChucVu = cbochucvu.SelectedValue.ToString();
                nv.MaHuyen = cbohuyen.SelectedValue.ToString();
                nv.MaPB = cbohuyen.SelectedValue.ToString();
                nv.MaQG = cboquocgia.SelectedValue.ToString();
                nv.MaTB = cbothongbao.SelectedValue.ToString();
                nv.MaTinh = cbotinh.SelectedValue.ToString();
                nv.MaTT = cbomatintuyendung.SelectedValue.ToString();
                nv.NgaySinh = mtbngaysinh.Value;
                nv.TenNV = txttennv.Text;
                NhanVien_BLL.Sua1NhanVien(nv);
                dgv1.DataSource = NhanVien_BLL.DSNhanVien();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NhanVienF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            loadcombobox();
            dgv1.DataSource = NhanVien_BLL.DSNhanVien();
        }
    }
}
