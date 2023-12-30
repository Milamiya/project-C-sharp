using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class ChiTietPDHInfo
    {
        private PhieuDatHangInfo m_MaPDH;

        public PhieuDatHangInfo MaPDH
        {
            get { return m_MaPDH; }
            set { m_MaPDH = value; }
        }
        private HangHoaInfo m_HH;

        public HangHoaInfo HH
        {
            get { return m_HH; }
            set { m_HH = value; }
        }
        private int m_SLuong;

        public int SLuong
        {
            get { return m_SLuong; }
            set { m_SLuong = value; }
        }
	
    }
}
