using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class GiaoDichVienInfo
    {
        public GiaoDichVienInfo()
        {
        }

        private NhanVienInfo m_MaNV;
        public NhanVienInfo MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }
    }
}
