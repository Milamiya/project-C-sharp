using System;
using System.Collections.Generic;
using System.Text;

namespace QLThUOC.BusinessObject
{
    public class DiaBanINFO
    {
        private String m_MADB;

        public String MADB
        {
            get { return m_MADB; }
            set { m_MADB = value; }
        }
        private String m_DIACHIDB;

        public String DIACHIDB
        {
            get { return m_DIACHIDB; }
            set { m_DIACHIDB = value; }
        }
        private String m_GHICHU;

        public String GHICHU
        {
            get { return m_GHICHU; }
            set { m_GHICHU = value; }
        }
        private IList<PhanCongINFO> m_DSPHANCONG;

        public IList<PhanCongINFO> DSPHANCONG
        {
            get { return m_DSPHANCONG; }
            set { m_DSPHANCONG = value; }
        }
	
	
	
	
    }
}
