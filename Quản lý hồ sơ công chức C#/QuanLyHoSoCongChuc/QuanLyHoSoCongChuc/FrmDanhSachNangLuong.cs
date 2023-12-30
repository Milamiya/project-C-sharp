using System;
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
    public partial class FrmDanhSachNangLuong : DockContent
    {
        NhanVienInfo m_NhanVienInfo = new NhanVienInfo();
        NhanVienControl m_NhanVienCtrl = new NhanVienControl();
        NhanVienData m_NhanVienData = new NhanVienData();
        FrmNhanVien frm = new FrmNhanVien();
        LuongInfo m_LuongInfo = new LuongInfo();
        LuongControl m_LuongCtrl = new LuongControl();
        public FrmDanhSachNangLuong()
        {
            InitializeComponent();
        }

        private void btnLapDanhSach_Click(object sender, EventArgs e)
        {
            DataService.OpenConnection();
            m_LuongCtrl.DanhSachNhanVien(DGVDanhSachNV, dtTinhDenNgay.Value);

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DGVDanhSachNV.RowCount; i++)
            {
                m_LuongCtrl.CapNhatCanSu(dtTinhDenNgay.Value);
                m_LuongCtrl.CapNhatChuyenVien(dtTinhDenNgay.Value);
            }
        }

        private void Xem_Click(object sender, EventArgs e)
        {
            FrmLuong frm = new FrmLuong();
            frm.Show(DockPanel);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}