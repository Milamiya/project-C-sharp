using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;

namespace QuanLyHoSoCongChuc
{
    public partial class FrmLuong : DockContent
    {
        NhanVienControl m_NhanVienControl = new NhanVienControl();
        public FrmLuong()
        {
            InitializeComponent();
        }

        private void FrmLuong_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_NhanVienControl.HienThiTTLuong(DGVLuong, txtHoTenNhanVien, cbxDonVi, cbxGioiTinh, cbxChucVu, cbxNgachCongChuc, txtMaNghach, txtBacLuong, txtHeSoLuong, cbxHuong85, txtCLBLHeSoLuong, dtHuongTuNgay, dtMocTinhNangLuongLanSau, txtHeSoPhuCapChucVu, txtHeSoPhuCapThamNienVuotKhung, txtHeSoPhuCapKiemNhiem, txtHeSoPhuCapKhac);
            m_NhanVienControl.HienThiComboBoxLuong(cbxGioiTinh, cbxDonVi, cbxChucVu, cbxNgachCongChuc, cbxHuong85);
        }

    }
}