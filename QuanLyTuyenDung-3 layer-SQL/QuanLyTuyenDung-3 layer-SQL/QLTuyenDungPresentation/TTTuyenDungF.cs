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
    public partial class TTTuyenDungF : Form
    {
        public TTTuyenDungF()
        {
            InitializeComponent();
        }

        private void xoathongtin()
        {
            txtmatt.Clear();
            txttentt.Clear();
            cbotrinhdo.ResetText();
            cbovitri.ResetText();
            cbonganh.ResetText();
            cbomucdo.ResetText();
            txtsolg.Clear();
            txtmucluong.Clear();
            txtmota.Clear();
            txtnoilamviec.Clear();
        }
        private void loadcombobox()
        {
            //Trình độ
            cbotrinhdo.DisplayMember = "TenTrinhDo";
            cbotrinhdo.ValueMember = "MaTrinhDo";
            cbotrinhdo.DataSource = TrinhDo_BLL.DSTrinhDo();

            // Vị Trí
            cbovitri.DisplayMember = "TenViTri";
            cbovitri.ValueMember = "MaViTri";
            cbovitri.DataSource = ViTri_BLL.DSViTri();
            //Ngành
            cbonganh.DisplayMember = "TenNganh";
            cbonganh.ValueMember = "MaNganh";
            cbonganh.DataSource = Nganh_BLL.DSNganh();
            // Mức độ
            cbomucdo.DisplayMember = "MucDo";
            cbomucdo.ValueMember = "MaMucDo";
            cbomucdo.DataSource = MucDo_BLL.DSMucDo();

        }
        private Boolean check()
        {
            if (txtmatt.TextLength < 1 || txttentt.TextLength < 1 || txtmatt.TextLength > 10 || txttentt.TextLength > 100
                || cbotrinhdo.Text == "" || cbovitri.Text == "" || cbonganh.Text == "" || cbomucdo.Text == "" 
                || txtsolg.Text == "" || txtmota.Text == "" || txtnoilamviec.Text == ""||txtmucluong.Text=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        ThongTinTuyenDung_DTO tttd = new ThongTinTuyenDung_DTO();
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmatt.TextLength < 1 || txtmatt.TextLength > 10)
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
            else
            {
                tttd.MaMucDo = cbomucdo.SelectedValue.ToString();
                ThongTinTuyenDung_BLL.Xoa1ThongTinTuyenDung(tttd);
                dgv1.DataSource = ThongTinTuyenDung_BLL.DSTiNTuyenDung();
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                tttd.MaMucDo = cbomucdo.SelectedValue.ToString();
                tttd.MaNganh = cbonganh.SelectedValue.ToString();
                tttd.MaTT = txtmatt.Text;
                tttd.MaTrinhDo = cbotrinhdo.SelectedValue.ToString();
                tttd.MaViTri = cbovitri.SelectedValue.ToString();
                tttd.MoTaCongViec = txtmota.Text;
                tttd.MucLuong = Convert.ToInt32(txtmucluong.Text);
                tttd.NoiLamViec = txtnoilamviec.Text;
                tttd.NgayHetHan = mtbngayhethan.Value;
                tttd.NgayYeuCau = mtbngayyeucau.Value;
                tttd.SoLuong = Convert.ToInt32(txtsolg.Text);
                tttd.TenTT = txttentt.Text;
                ThongTinTuyenDung_BLL.Them1ThongTinTuyenDung(tttd);
                dgv1.DataSource = ThongTinTuyenDung_BLL.DSTiNTuyenDung();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                tttd.MaMucDo = cbomucdo.SelectedValue.ToString();
                tttd.MaNganh = cbonganh.SelectedValue.ToString();
                tttd.MaTT = txtmatt.Text;
                tttd.MaTrinhDo = cbotrinhdo.SelectedValue.ToString();
                tttd.MaViTri = cbovitri.SelectedValue.ToString();
                tttd.MoTaCongViec = txtmota.Text;
                tttd.MucLuong = Convert.ToInt32(txtmucluong.Text);
                tttd.NoiLamViec = txtnoilamviec.Text;
                tttd.NgayHetHan = mtbngayhethan.Value;
                tttd.NgayYeuCau = mtbngayyeucau.Value;
                tttd.SoLuong = Convert.ToInt32(txtsolg.Text);
                tttd.TenTT = txttentt.Text;
                ThongTinTuyenDung_BLL.Sua1ThongTinTuyenDung(tttd);
                dgv1.DataSource = ThongTinTuyenDung_BLL.DSTiNTuyenDung();
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

        private void TTTuyenDungF_Load(object sender, EventArgs e)
        {
            dgv1.DataSource = ThongTinTuyenDung_BLL.DSTiNTuyenDung();
            this.ControlBox = false;
            this.Text = String.Empty;
            loadcombobox();
        }
    }
}
