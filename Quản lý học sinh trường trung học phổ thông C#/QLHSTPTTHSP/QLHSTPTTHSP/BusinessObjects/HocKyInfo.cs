using System;
using System.Collections.Generic;
using System.Text;

namespace QLHSTPTTHSP.BusinessObjects
{
    public class HocKyInfo
    {
        int m_Id;
        string m_TenHocKy;
        DateTime m_TGBD;
        DateTime m_TGKT;
        string m_MaNienHoc;

        public HocKyInfo() { }

        public HocKyInfo(int id, string tenHocKy, DateTime tGBD, DateTime tGKT, string maNienHoc)
        {
            this.m_Id = id;
            this.m_TenHocKy = tenHocKy;
            this.m_TGBD = tGBD;
            this.m_TGKT = tGKT;
            this.m_MaNienHoc = maNienHoc;
        }
        public int Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }
        public string TenHocKy
        {
            get { return this.m_TenHocKy; }
            set { this.m_TenHocKy = value; }
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
        public string MaNienhoc
        {
            get { return this.m_MaNienHoc; }
            set { this.m_MaNienHoc = value; }
        }
    }
}
