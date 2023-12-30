using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class GioiTinhInfo
    {
        private String m_gioitinh;

        public String gioitinh
        {
            get { return m_gioitinh; }
            set { m_gioitinh = value; }
        }
        private String m_tengioitinh;

        public String Tengioitinh
        {
            get { return m_tengioitinh; }
            set { m_tengioitinh = value; }
        }
        private IList<NhanVienInfo> m_DSgioitinh;

        public IList<NhanVienInfo> DSgioitinh
        {
            get { return m_DSgioitinh; }
            set { m_DSgioitinh = value; }
        }
	
    }
}
