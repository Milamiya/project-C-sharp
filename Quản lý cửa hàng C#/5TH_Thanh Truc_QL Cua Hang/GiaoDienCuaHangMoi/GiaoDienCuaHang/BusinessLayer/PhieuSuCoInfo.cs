using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class PhieuSuCoInfo
    {
        private String m_Mapsc;

        public String Mapsc
        {
            get { return m_Mapsc; }
            set { m_Mapsc = value; }
        }

        private HangHoaInfo m_Masp;

        public HangHoaInfo Masp
        {
            get { return m_Masp; }
            set { m_Masp = value; }
        }
	
        private DateTime m_Ngayhuhong;

        public DateTime Ngayhuhong
        {
            get { return m_Ngayhuhong; }
            set { m_Ngayhuhong = value; }
        }

        private String m_Lydo;

        public String Lydo
        {
            get { return m_Lydo; }
            set { m_Lydo = value; }
        }
        private int m_SLhuhong;

        public int SLhuhong
        {
            get { return m_SLhuhong; }
            set { m_SLhuhong = value; }
        }
        private int m_DGia;

        public int DGia
        {
            get { return m_DGia; }
            set { m_DGia = value; }
        }
	
        private int m_Tongtienhuhong;

        public int Tongtienhuhong
        {
            get { return m_Tongtienhuhong; }
            set { m_Tongtienhuhong = value; }
        }
        
	
    }
}
