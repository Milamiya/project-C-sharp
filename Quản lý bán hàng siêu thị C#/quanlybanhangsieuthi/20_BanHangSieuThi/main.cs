using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20_BanHangSieuThi
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            Data.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Data.Disconnect();
            Application.Exit();
        }

        private void mnuNCC_Click(object sender, EventArgs e)
        {
            DMNhaCC NhaCungCap = new DMNhaCC();
            NhaCungCap.StartPosition=FormStartPosition.CenterScreen;
            NhaCungCap.Show();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            DMHangHoa HangHoa = new DMHangHoa();
            HangHoa.StartPosition = FormStartPosition.CenterParent;
            HangHoa.Show();
        }

        private void mnuNhomHang_Click(object sender, EventArgs e)
        {
            DMNhomHang NhomHang = new DMNhomHang();
            NhomHang.StartPosition = FormStartPosition.CenterScreen;
            NhomHang.Show();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
                DMChatLieu ChatLieu = new DMChatLieu();
                ChatLieu.StartPosition = FormStartPosition.CenterScreen;
                ChatLieu.Show();
        }

        private void mnuCongDung_Click_1(object sender, EventArgs e)
        {
            DMCongDung CongDung = new DMCongDung();
            CongDung.StartPosition = FormStartPosition.CenterScreen;
            CongDung.Show();

        }

       private void mnuTheLoai_Click_1(object sender, EventArgs e)
       {
            DMTheLoai TheLoai = new DMTheLoai();
            TheLoai.StartPosition = FormStartPosition.CenterScreen;
            TheLoai.Show();
        }

        private void mnuCaLam_Click(object sender, EventArgs e)
        {
            DMCaLam CaLam = new DMCaLam();
            CaLam.StartPosition = FormStartPosition.CenterScreen;
            CaLam.Show();
        }

        private void mnuCongViec_Click(object sender, EventArgs e)
        {
            DMCongViec CongViec = new DMCongViec();
            CongViec.StartPosition = FormStartPosition.CenterScreen;
            CongViec.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            DMKhachHang KhachHang = new DMKhachHang();
            KhachHang.StartPosition = FormStartPosition.CenterScreen;
            KhachHang.Show();
        }

        private void mnuDonViTinh_Click(object sender, EventArgs e)
        {
            DMDonVi DonViTinh = new DMDonVi();
            DonViTinh.StartPosition = FormStartPosition.CenterScreen;
            DonViTinh.Show();
        }

        private void mnuNSX_Click(object sender, EventArgs e)
        {
            DMNoiSX NoiSanXuat = new DMNoiSX();
            NoiSanXuat.StartPosition = FormStartPosition.CenterScreen;
            NoiSanXuat.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            DMNhanVien NhanVien = new DMNhanVien();
            NhanVien.StartPosition = FormStartPosition.CenterScreen;
            NhanVien.Show();
        }

        private void mnuNhapHang_Click(object sender, EventArgs e)
        {
            HoaDonNhap NhapHang = new HoaDonNhap();
            NhapHang.StartPosition = FormStartPosition.CenterScreen;
            NhapHang.Show();
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            HoaDonBan BanHang = new HoaDonBan();
            BanHang.StartPosition = FormStartPosition.CenterScreen;
            BanHang.Show();
        }

        private void hàngHóaBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_BC_HH_BanChay bc = new fr_BC_HH_BanChay();
            bc.Show();
        }

        private void báoCáoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_BC_Nam nam = new fr_BC_Nam();
            nam.Show();
        }

        private void báoCáoDoanhThuNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_BC_Nhanvien nv = new fr_BC_Nhanvien();
            nv.Show();
        }

        private void theoQuýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_BC_Quy fr = new fr_BC_Quy();
            fr.Show();
        }

    }
}
