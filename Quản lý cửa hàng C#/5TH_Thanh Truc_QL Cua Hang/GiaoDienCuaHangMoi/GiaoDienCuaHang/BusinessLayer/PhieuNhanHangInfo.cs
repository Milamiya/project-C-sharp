using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class PhieuNhanHangInfo
    {
        private String m_maphieu;

        public String maphieu
        {
            get { return m_maphieu; }
            set { m_maphieu = value; }
        }
        private NhanVienInfo m_manv;

        public NhanVienInfo manv
        {
            get { return m_manv; }
            set { m_manv = value; }
        }
        private DateTime m_date;

        public DateTime date
        {
            get { return m_date; }
            set { m_date = value; }
        }
        private int m_tongtien;

        public int tongtien
        {
            get { return m_tongtien; }
            set { m_tongtien = value; }
        }
        private IList<ChiTietPNHInfo> m_CTPNH;

        public IList<ChiTietPNHInfo> CTPNH
        {
            get { return m_CTPNH; }
            set { m_CTPNH = value; }
        }
	
	 
    }
}
