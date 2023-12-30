using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class DMLoaiGiaoDichInfo
    {
        public DMLoaiGiaoDichInfo()
        {
        }

        private String m_MaLoaiGiaoDich;
        public String MaLoaiGiaoDich
        {
            get { return m_MaLoaiGiaoDich; }
            set { m_MaLoaiGiaoDich = value; }
        }

        private String m_TenGiaoDich;
        public String TenGiaoDich
        {
            get { return m_TenGiaoDich; }
            set { m_TenGiaoDich = value; }
        }

        
        
    }
}
