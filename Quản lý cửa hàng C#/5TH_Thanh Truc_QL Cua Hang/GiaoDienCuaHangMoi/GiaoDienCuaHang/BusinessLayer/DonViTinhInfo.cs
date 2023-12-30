using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class DonViTinhInfo
    {
        private String m_MaDVT;

        public String MaDVT
        {
            get { return m_MaDVT; }
            set { m_MaDVT = value; }
        }
        private String m_TenDVT;

        public String TenDVT
        {
            get { return m_TenDVT; }
            set { m_TenDVT = value; }
        }
        private IList<HangHoaInfo> m_DSHanghoa;

        public IList<HangHoaInfo> DSHanghoa
        {
            get { return m_DSHanghoa; }
            set { m_DSHanghoa = value; }
        }
	

	
    }
}
