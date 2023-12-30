using System;
using System.Collections.Generic;
using System.Text;

namespace QLThUOC.BusinessObject
{
    public class LoaiThuocINFO
    {
        private String m_MALOAITHUOC;

        public String MALOAITHUOC
        {
            get { return m_MALOAITHUOC; }
            set { m_MALOAITHUOC = value; }
        }
        private String m_TENLOAI;

        public String TENLOAI
        {
            get { return m_TENLOAI; }
            set { m_TENLOAI = value; }
        }
        private long m_HESOLUONG;

        public long HESOLUONG
        {
            get { return m_HESOLUONG; }
            set { m_HESOLUONG = value; }
        }
        private IList<ThuocINFO> m_DSTHUOC;

        public IList<ThuocINFO> DSTHUOC
        {
            get { return m_DSTHUOC; }
            set { m_DSTHUOC = value; }
        }
	
	
	
    }
}
