using System;
using System.Collections.Generic;
using System.Text;

namespace QLThUOC.BusinessObject
{
    public class LoThuocINFO
    {
        private String m_MALO;

        public String MALO
        {
            get { return m_MALO; }
            set { m_MALO = value; }
        }
        private String m_TENLO;

        public String TENLO
        {
            get { return m_TENLO; }
            set { m_TENLO = value; }
        }
        private DateTime m_NGAYSX;

        public DateTime NGAYSX
        {
            get { return m_NGAYSX; }
            set { m_NGAYSX = value; }
        }
        private DateTime m_NGAYHH;

        public DateTime NGAYHH
        {
            get { return m_NGAYHH; }
            set { m_NGAYHH = value; }
        }
        private int m_SOLUONG;

        public int SOLUONG
        {
            get { return m_SOLUONG; }
            set { m_SOLUONG = value; }
        }
        private String m_MATHUOC;

        public String MATHUOC
        {
            get { return m_MATHUOC; }
            set { m_MATHUOC = value; }
        }
        private int m_THANHTIEN;

        public int THANHTIEN
        {
            get { return m_THANHTIEN; }
            set { m_THANHTIEN = value; }
        }

        private ThuocINFO m_THUOC;

        public ThuocINFO THUOC
        {
            get { return m_THUOC; }
            set { m_THUOC = value; }
        }
	
    }
}
