using System;
using System.Collections.Generic;
using System.Text;

namespace QLThUOC.BusinessObject
{
    public class PhanCongINFO
    {
        private String m_MATDV;

        public String MATDV
        {
            get { return m_MATDV; }
            set { m_MATDV = value; }
        }
        private String m_MADB;

        public String MADB
        {
            get { return m_MADB; }
            set { m_MADB = value; }
        }
        private String m_MATHUOC;

        public String MATHUOC
        {
            get { return m_MATHUOC; }
            set { m_MATHUOC = value; }
        }
        private TrinhDuocVienINFO m_TRINHDUOCVIEN;

        public TrinhDuocVienINFO TDVIEN
        {
            get { return m_TRINHDUOCVIEN; }
            set { m_TRINHDUOCVIEN = value; }
        }

        private DiaBanINFO m_DIABAN;

        public DiaBanINFO DIABANHD
        {
            get { return m_DIABAN; }
            set { m_DIABAN = value; }
        }
        private ThuocINFO m_THUOC;

        public ThuocINFO THUOC
        {
            get { return m_THUOC; }
            set { m_THUOC = value; }
        }
	
	
	
	
	
    }
}
