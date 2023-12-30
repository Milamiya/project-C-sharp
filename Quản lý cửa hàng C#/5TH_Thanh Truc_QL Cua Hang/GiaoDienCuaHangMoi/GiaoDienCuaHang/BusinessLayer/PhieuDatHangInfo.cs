using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class PhieuDatHangInfo
    {
        private String m_Mapdh;

        public String Mapdh
        {
            get { return m_Mapdh; }
            set { m_Mapdh = value; }
        }
        private DateTime m_Ngay;

        public DateTime Ngay
        {
            get { return m_Ngay; }
            set { m_Ngay = value; }
        }
        private NhaCungCapInfo m_mancc;

        public NhaCungCapInfo mancc
        {
            get { return m_mancc; }
            set { m_mancc = value; }
        }
        private NhanVienInfo m_Manv;

        public NhanVienInfo Manv
        {
            get { return m_Manv; }
            set { m_Manv = value; }
        }
        private IList<ChiTietPDHInfo> m_CTPDH;

        public IList<ChiTietPDHInfo> CTPDH
        {
            get { return m_CTPDH; }
            set { m_CTPDH = value; }
        }
	
    }
}
