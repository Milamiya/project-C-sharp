using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class ChiTietPBHInfo
    {
       public ChiTietPBHInfo()
       {
           //PBH = new PhieuBanHangInfo();
           //SP = new HangHoaInfo();
       }
        private PhieuBanHangInfo m_PBH;

        public PhieuBanHangInfo PBH
        {
            get { return m_PBH; }
            set { m_PBH = value; }
        }
        private HangHoaInfo m_SP;

        public HangHoaInfo SP
        {
            get { return m_SP; }
            set { m_SP = value; }
        }
        private int m_DonGia;

        public int DonGia
        {
            get { return m_DonGia; }
            set { m_DonGia = value; }
        }
        private int m_SL;

        public int SL
        {
            get { return m_SL; }
            set { m_SL = value; }
        }
        private int m_TT;

        public int TT
        {
            get { return m_TT; }
            set { m_TT = value; }
        }
	
	
	
	
    }
}
