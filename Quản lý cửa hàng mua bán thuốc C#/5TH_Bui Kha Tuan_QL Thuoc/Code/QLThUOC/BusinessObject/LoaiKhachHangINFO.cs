using System;
using System.Collections.Generic;
using System.Text;

namespace QLThUOC.BusinessObject
{
    public class LoaiKhachHangINFO
    {
        private KhachHangINFO m_KHACHHANG;

        public KhachHangINFO KHACHHANG
        {
            get { return m_KHACHHANG; }
            set { m_KHACHHANG = value; }
        }
        private String m_MALOAIKH;

        public String MALOAIKH
        {
            get { return m_MALOAIKH; }
            set { m_MALOAIKH = value; }
        }
        private String m_TENLOAIKH;

        public String TENLOAIKH
        {
            get { return m_TENLOAIKH; }
            set { m_TENLOAIKH = value; }
        }
        private IList<KhachHangINFO> m_DSKHACHHANG;

        public IList<KhachHangINFO> DSKHACHHANG
        {
            get { return m_DSKHACHHANG; }
            set { m_DSKHACHHANG = value; }
        }

	
        
	    
    }
}
