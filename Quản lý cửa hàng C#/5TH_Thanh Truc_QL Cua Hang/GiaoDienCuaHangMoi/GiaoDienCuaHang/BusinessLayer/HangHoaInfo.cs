using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class HangHoaInfo
    {
        private String m_MaHH;

        public String MaHH
        {
            get { return m_MaHH; }
            set { m_MaHH = value; }
        }
        private String m_TenHang;

        public String TenHang
        {
            get { return m_TenHang; }
            set { m_TenHang = value; }
        }
        private DonViTinhInfo m_dvt;

        public DonViTinhInfo dvt
        {
            get { return m_dvt; }
            set { m_dvt = value; }
        }
        private int m_SoLuong;

        public int SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }

        private int m_SLgiam;

        public int SLgiam
        {
            get { return m_SLgiam; }
            set { m_SLgiam = value; }
        }
        private int m_Tilegiam;

        public int Tilegiam
        {
            get { return m_Tilegiam; }
            set { m_Tilegiam = value; }
        }
	
	
	
    }
}
