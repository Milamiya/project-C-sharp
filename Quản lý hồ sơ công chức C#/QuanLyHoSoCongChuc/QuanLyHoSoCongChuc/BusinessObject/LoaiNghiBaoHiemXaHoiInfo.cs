using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class LoaiNghiBaoHiemXaHoiInfo
    {
        public LoaiNghiBaoHiemXaHoiInfo()
        {
        }
        private String m_MaLoaiNghiBaoHiemXaHoi;
        public String MaLoaiNghiBaoHiemXaHoi
        {
            get { return m_MaLoaiNghiBaoHiemXaHoi; }
            set { m_MaLoaiNghiBaoHiemXaHoi = value; }
        }

        private String m_TenLoaiNghiBaoHiemXaHoi;
        public String TenLoaiNghiBaoHiemXaHoi
        {
            get { return m_TenLoaiNghiBaoHiemXaHoi; }
            set { m_TenLoaiNghiBaoHiemXaHoi = value; }
        }
    }
}
