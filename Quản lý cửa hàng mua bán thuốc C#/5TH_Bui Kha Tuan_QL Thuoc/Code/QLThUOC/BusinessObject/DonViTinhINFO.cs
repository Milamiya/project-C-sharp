using System;
using System.Collections.Generic;
using System.Text;

namespace QLThUOC.BusinessObject
{
    public class DonViTinhINFO
    {
        private String m_MADVT;

        public String MADVT
        {
            get { return m_MADVT; }
            set { m_MADVT = value; }
        }
        private String m_TENDVT;

        public String TENDVT
        {
            get { return m_TENDVT; }
            set { m_TENDVT = value; }
        }
        private IList<ThuocINFO> m_DSTHUOC;

        public IList<ThuocINFO> DSTHUOC
        {
            get { return m_DSTHUOC; }
            set { m_DSTHUOC = value; }
        }
	
	    
	
    }
}
