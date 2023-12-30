using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class LoaiNhanVienInfo
    {
        private String m_MaloaiNV;

	    public String MaloaiNV
	    {
		    get { return m_MaloaiNV;}
		    set { m_MaloaiNV = value;}
	    }

        private String m_TenloaiNV;

        public String TenloaiNV
        {
            get { return m_TenloaiNV; }
            set { m_TenloaiNV = value; }
        }
        private IList<NhanVienInfo> m_DSLoaiNV;

        public IList<NhanVienInfo> DSLoaiNV
        {
            get { return m_DSLoaiNV; }
            set { m_DSLoaiNV = value; }
        }
	
	
	
    }
}
