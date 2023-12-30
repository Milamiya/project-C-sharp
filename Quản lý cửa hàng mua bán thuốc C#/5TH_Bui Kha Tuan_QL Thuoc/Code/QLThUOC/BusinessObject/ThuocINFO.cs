using System;
using System.Collections.Generic;
using System.Text;

namespace QLThUOC.BusinessObject
{
    public class ThuocINFO
    {
        private String m_MATHUOC;

        public String MATHUOC
        {
            get { return m_MATHUOC; }
            set { m_MATHUOC = value; }
        }
        private String m_TENTHUOC;

        public String TENTHUOC
        {
            get { return m_TENTHUOC; }
            set { m_TENTHUOC = value; }
        }
        private String m_MADVT;

        public String MADVT
        {
            get { return m_MADVT; }
            set { m_MADVT = value; }
        }
        private int m_SOLUONG;

        public int SOLUONG
        {
            get { return m_SOLUONG; }
            set { m_SOLUONG = value; }
        }
        private int m_DONGIAMUA;

        public int DONGIAMUA
        {
            get { return m_DONGIAMUA; }
            set { m_DONGIAMUA = value; }
        }
        private int m_DONGIABAN;

        public int DONGIABAN
        {
            get { return m_DONGIABAN; }
            set { m_DONGIABAN = value; }
        }

        private String m_MALOAITHUOC;

        public String MALOAITHUOC
        {
            get { return m_MALOAITHUOC; }
            set { m_MALOAITHUOC = value; }
        }

        private IList<PhanCongINFO> m_DSPHANCONG;

        public IList<PhanCongINFO> DSPHANCONG
        {
            get { return m_DSPHANCONG; }
            set { m_DSPHANCONG = value; }
        }
        private IList<LoThuocINFO> m_DSLOTHUOC;

        public IList<LoThuocINFO> DSLOTHUOC
        {
            get { return m_DSLOTHUOC; }
            set { m_DSLOTHUOC = value; }
        }
        

        private DonViTinhINFO m_DONVITINH;

        public DonViTinhINFO DVTINH
        {
            get { return m_DONVITINH; }
            set { m_DONVITINH = value; }
        }
        private LoaiThuocINFO m_LOAITHUOC;

        public LoaiThuocINFO LOAITHUOC
        {
            get { return m_LOAITHUOC; }
            set { m_LOAITHUOC = value; }
        }
	
	
	
	
	
    }
}
