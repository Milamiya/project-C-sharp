using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class PhieuBanHangInfo
    {
       public PhieuBanHangInfo()
       {
          m_CTPBH = new List<ChiTietPBHInfo>();
       }
       private String m_MaPhieu;

        public String MaPhieu
        {
            get { return m_MaPhieu; }
            set { m_MaPhieu = value; }
        }
       
	
        private KhachHangInfo m_Kh;

        public KhachHangInfo Kh
        {
            get { return m_Kh; }
            set { m_Kh = value; }
        }

        private NhanVienInfo m_NV;

        public NhanVienInfo NV
        {
            get { return m_NV; }
            set { m_NV = value; }
        }
	    
        private DateTime m_NgayLap;

        public DateTime NgayLap
        {
            get { return m_NgayLap; }
            set { m_NgayLap = value; }
        }
        private int m_TongTien;

        public int TongTien
        {
            get { return m_TongTien; }
            set { m_TongTien = value; }
        }
        private IList<ChiTietPBHInfo> m_CTPBH;

        public IList<ChiTietPBHInfo> CTPBH
        {
            get { return m_CTPBH; }
            set { m_CTPBH = value; }
        }
	
        
   }
}
