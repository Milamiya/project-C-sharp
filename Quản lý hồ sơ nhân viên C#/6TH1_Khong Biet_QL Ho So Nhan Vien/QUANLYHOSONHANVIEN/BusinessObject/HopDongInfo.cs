using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class HopDongInfo
    {
        public HopDongInfo() { }
        public HopDongInfo(string loai, string tenloai)
        {
            m_MaHD = loai;
            m_TenHD = tenloai;
        }

        private string m_MaHD;

        public string MaHD
        {
            get { return m_MaHD; }
            set { m_MaHD = value; }
        }

        private string  m_TenHD;

        public string  TenHD
        {
            get { return m_TenHD; }
            set { m_TenHD = value; }
        }
    }
}
