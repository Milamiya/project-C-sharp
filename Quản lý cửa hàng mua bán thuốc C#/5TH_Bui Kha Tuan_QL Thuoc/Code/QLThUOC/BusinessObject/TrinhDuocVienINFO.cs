using System;
using System.Collections.Generic;
using System.Text;

namespace QLThUOC.BusinessObject
{
    public class TrinhDuocVienINFO
    {
        private String m_MATDV;

        public String MATDV
        {
            get { return m_MATDV; }
            set { m_MATDV = value; }
        }
        private String m_HOTENTDV;

        public String HOTENTDV
        {
            get { return m_HOTENTDV; }
            set { m_HOTENTDV = value; }
        }
        private String m_GIOITINH;

        public String GIOITINH
        {
            get { return m_GIOITINH; }
            set { m_GIOITINH = value; }
        }
        private String m_DIACHI;

        public String DIACHI
        {
            get { return m_DIACHI; }
            set { m_DIACHI = value; }
        }
        private String m_DIENTHOAI;

        public String DIENTHOAI
        {
            get { return m_DIENTHOAI; }
            set { m_DIENTHOAI = value; }
        }
        private int m_LUONGCANBAN;

        public int LUONGCANBAN
        {
            get { return m_LUONGCANBAN; }
            set { m_LUONGCANBAN = value; }
        }
        private IList<PhanCongINFO> m_DSPHANCONG;

        public IList<PhanCongINFO> DSPHANCONG
        {
            get { return m_DSPHANCONG; }
            set { m_DSPHANCONG = value; }
        }
	
	
	
	
	
	
    }
}
