using System;
using System.Collections.Generic;
using System.Text;

namespace QLThUOC.BusinessObject
{
    public class KhachHangINFO
    {
        private String m_MAKH;

        public String MAKH
        {
            get { return m_MAKH; }
            set { m_MAKH = value; }
        }
        private String m_HOTENKH;

        public String HOTENKH
        {
            get { return m_HOTENKH; }
            set { m_HOTENKH = value; }
        }
        private String m_DIACHIKH;

        public String DIACHIKH
        {
            get { return m_DIACHIKH; }
            set { m_DIACHIKH = value; }
        }
        private String m_DIENTHOAI;

        public String DIENTHOAI
        {
            get { return m_DIENTHOAI; }
            set { m_DIENTHOAI = value; }
        }
        private String m_MALOAIKH;

        public String MALOAIKH
        {
            get { return m_MALOAIKH; }
            set { m_MALOAIKH = value; }
        }
        private LoaiKhachHangINFO m_LOAIKHACHHANG;

        public LoaiKhachHangINFO LOAIKH
        {
            get { return m_LOAIKHACHHANG; }
            set { m_LOAIKHACHHANG = value; }
        }

	
	
	
    }
}
