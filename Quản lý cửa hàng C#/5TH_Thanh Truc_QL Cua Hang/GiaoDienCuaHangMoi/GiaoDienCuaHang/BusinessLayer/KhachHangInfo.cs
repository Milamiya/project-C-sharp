using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
    public class KhachHangInfo
    {
        public KhachHangInfo()
        {
            m_Dspbh = new List<PhieuBanHangInfo>();
        }


        private String m_Makh;

        public String Makh
        {
            get { return m_Makh; }
            set { m_Makh = value; }
        }
        private String m_Hoten;

        public String hoten
        {
            get { return m_Hoten; }
            set { m_Hoten = value; }
        }
        private String m_Diachi;

        public String diachi
        {
            get { return m_Diachi; }
            set { m_Diachi = value; }
        }

        private String m_Dienthoai;

        public String dienthoai
        {
            get { return m_Dienthoai; }
            set { m_Dienthoai = value; }
        }

        private IList<PhieuBanHangInfo> m_Dspbh;

        public IList<PhieuBanHangInfo> Dspbh
        {
            get { return m_Dspbh; }
            set { m_Dspbh = value; }
        }
    }

}