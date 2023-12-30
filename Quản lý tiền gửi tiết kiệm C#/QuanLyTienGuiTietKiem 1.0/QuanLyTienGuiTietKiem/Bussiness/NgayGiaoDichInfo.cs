using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class NgatGiaoDichInfo
    {
        public NgatGiaoDichInfo()
        {
        }

        private DateTime m_NgayGiaoDich;
        public DateTime NgayGiaoDich
        {
            get { return m_NgayGiaoDich; }
            set { m_NgayGiaoDich = value; }
        }

        private bool m_NgatGiaoDich;
        public bool NgatGiaoDich
        {
            get { return m_NgatGiaoDich; }
            set { m_NgatGiaoDich = value; }
        }
    }
}
