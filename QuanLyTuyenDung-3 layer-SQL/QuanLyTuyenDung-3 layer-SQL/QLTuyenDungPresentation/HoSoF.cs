using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTuyenDungPresentation;
using DTO;
using BUS;
namespace QLTuyenDungPresentation
{
    public partial class HoSoF : Form
    {
        public HoSoF()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void HoSoF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = HoSo_BLL.DSHoSo();
            loadcombobox();
            this.toolTip1.IsBalloon = true;
        }

        private Boolean check()
        {
            if (txtmahs.TextLength < 1 || txthoten.TextLength < 1 || txtmahs.TextLength > 5 || txthoten.TextLength > 30
                || cbohuyen.Text=="" || cboloaihs.Text==""||cboquocgia.Text=="" || cbotinh.Text=="" || cbovitri.Text=="")
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
            txtmahs.Clear();
            txthoten.Clear();
            txtcmnd.Clear();
            cbovitri.ResetText();
            cbotinh.ResetText();
            cboquocgia.ResetText();
            cboloaihs.ResetText();
            cbohuyen.ResetText();            
        }
        private void loadcombobox()
        {
            cbovitri.DisplayMember = "TenViTri";
            cbovitri.ValueMember = "MaViTri";
            cbovitri.DataSource = ViTri_BLL.DSViTri();

            cbotinh.DisplayMember = "TenTinh";
            cbotinh.ValueMember = "MaTinh";
            cbotinh.DataSource = Tinh_BLL.DSTinh();

            cboquocgia.DisplayMember = "TenQG";
            cboquocgia.ValueMember = "MaQG";
            cboquocgia.DataSource = QuocGia_BLL.DSQuocGia();

            cboloaihs.DisplayMember = "TenHS";
            cboloaihs.ValueMember = "MaLoaiHS";
            cboloaihs.DataSource = LoaiHoSo_BLL.DSLoaiHS();

            cbohuyen.DisplayMember = "TenHuyen";
            cbohuyen.ValueMember = "MaHuyen";
            cbohuyen.DataSource = Huyen_BLL.DSHuyen();

            cbomanv.DisplayMember = "TenNV";
            cbomanv.ValueMember = "MaNV";
            cbomanv.DataSource = NhanVien_BLL.DSNhanVien();
        }
        HoSo_DTO hs = new HoSo_DTO();
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                hs.MaHS=txtmahs.Text;
                hs.HoTen = txthoten.Text;
                hs.MaHuyen = cbohuyen.SelectedValue.ToString();
                hs.MaLoaiHS = cboloaihs.SelectedValue.ToString();
                hs.MaQG = cboquocgia.SelectedValue.ToString();
                hs.MaTinh = cbotinh.SelectedValue.ToString();
                hs.MaViTri = cbovitri.SelectedValue.ToString();
                hs.NgayNop = Convert.ToDateTime(mtbngaynop.Value);
                hs.NgaySinh = Convert.ToDateTime(mtbngaysinh.Value);
                hs.CMND = txtcmnd.Text;
                hs.MaNV = cbomanv.SelectedValue.ToString();
                HoSo_BLL.Them1HoSoMoi(hs);
                dgv1.DataSource = HoSo_BLL.DSHoSo();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ hoặc đã tồn tại, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmahs.TextLength<1 || txtmahs.TextLength>5)
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi");
                xoathongtin();
                
            }
            else
            {
                hs.MaHS = txtmahs.Text;                
                HoSo_BLL.Xoa1HoSo(hs);
                dgv1.DataSource = HoSo_BLL.DSHoSo();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                hs.MaHS = txtmahs.Text;
                hs.HoTen = txthoten.Text;
                hs.MaHuyen = cbohuyen.SelectedValue.ToString();
                hs.MaLoaiHS = cboloaihs.SelectedValue.ToString();
                hs.MaQG = cboquocgia.SelectedValue.ToString();
                hs.MaTinh = cbotinh.SelectedValue.ToString();
                hs.MaViTri = cbovitri.SelectedValue.ToString();
                hs.NgayNop = Convert.ToDateTime(mtbngaynop.Value);
                hs.NgaySinh = Convert.ToDateTime(mtbngaysinh.Value);
                hs.CMND = txtcmnd.Text;
                hs.MaNV = cbomanv.SelectedValue.ToString();
                HoSo_BLL.Sua1HoSo(hs);
                dgv1.DataSource = HoSo_BLL.DSHoSo();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}
