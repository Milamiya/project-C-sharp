using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class LuongControl
    {
        NhanVienData m_NhanVienData = new NhanVienData();
        NhanVienInfo m_NhanVienInfo = new NhanVienInfo();
        LuongData m_LuongData = new LuongData();
        LuongInfo LuongInfo = new LuongInfo();
        public void DanhSachNhanVien(DataGridView DGV, DateTime dt)
        {
            BindingSource bS = new BindingSource();
            DataTable tbl = m_LuongData.LayDSNV(dt);
            bS.DataSource = tbl;
            DGV.DataSource = bS;
        }
        public void CapNhatCanSu(DateTime dt)
        {
            m_LuongData.CapNhatCanSu(dt);
        }
        public void CapNhatChuyenVien(DateTime dt)
        {
            m_LuongData.CapNhatChuyenVien(dt);
        }
    }
}
