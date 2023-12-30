using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class ChiTietPNHInfo
    {
        private PhieuNhanHangInfo m_PNH;

        public PhieuNhanHangInfo PNH
        {
            get { return m_PNH; }
            set { m_PNH = value; }
        }
        private HangHoaInfo m_Masp;

        public HangHoaInfo Masp
        {
            get { return m_Masp; }
            set { m_Masp = value; }
        }
        private int m_SL;

        public int SL
        {
            get { return m_SL; }
            set { m_SL = value; }
        }

        private int m_dongia;

        public int dongia
        {
            get { return m_dongia; }
            set { m_dongia = value; }
        }

        private int m_thanhtien;

        public int thanhtien
        {
            get { return m_thanhtien; }
            set { m_thanhtien = value; }
        }
        private PhieuDatHangInfo m_mapdh;

        public PhieuDatHangInfo mapdh
        {
            get { return m_mapdh; }
            set { m_mapdh = value; }
        }
	
	

    }
}
