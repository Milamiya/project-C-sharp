using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSTPTTHSP.BusinessObjects
{
    public class NienHocInfo
    {
        string m_MaNienHoc;
        string m_TenNienHoc;
        DateTime m_TGBD;
        DateTime m_TGKT;

        public NienHocInfo() { }
        public NienHocInfo(string maNienHoc, string tenNienHoc, DateTime tGBD, DateTime tGKT)
        {
            this.m_MaNienHoc = maNienHoc;
            this.m_TenNienHoc = tenNienHoc;
            this.m_TGBD = tGBD;
            this.m_TGKT = tGKT;
        }
        public string MaNienHoc
        {
            get { return this.m_MaNienHoc; }
            set { this.m_MaNienHoc = value; }
        }
        public string TenNienHoc
        {
            get { return this.m_TenNienHoc; }
            set { this.m_TenNienHoc = value; }
        }
        public DateTime ThoiGianBatDau
        {
            get { return this.m_TGBD; }
            set { this.m_TGBD = value; }
        }
        public DateTime ThoiGianKetThuc
        {
            get { return this.m_TGKT; }
            set { this.m_TGKT = value; }
        }
    }
}
