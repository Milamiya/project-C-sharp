using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;


namespace QuanLyHoSoCongChuc.Controller
{
    public class LoaiDonViControl
    {
        LoaiDonViData m_LoaiDonViData = new LoaiDonViData();
        public void HienThiComBoBox(ComboBox cmb)
        {
            cmb.DataSource = m_LoaiDonViData.LayDanhSachLoaiDonVi();
            cmb.DisplayMember = "TenLoaiDonVi";
            cmb.ValueMember = "MaLoaiDonVi";
        }
    }
}
