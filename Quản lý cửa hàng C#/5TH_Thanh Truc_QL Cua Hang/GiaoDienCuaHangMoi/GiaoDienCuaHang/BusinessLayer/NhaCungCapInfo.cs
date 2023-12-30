using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class NhaCungCapInfo
    {
        private String m_MaNCC;

        public String MaNCC
        {
            get { return m_MaNCC; }
            set { m_MaNCC = value; }
        }
        private String m_TenNCC;

        public String TenNCC
        {
            get { return m_TenNCC; }
            set { m_TenNCC = value; }
        }
        private String m_Diachi;

        public String Diachi
        {
            get { return m_Diachi; }
            set { m_Diachi = value; }
        }
        private String m_DienThoai;

        public String DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }
        private IList<PhieuDatHangInfo> m_DSPhieudathang;

        public IList<PhieuDatHangInfo> DSPhieudathang
        {
            get { return m_DSPhieudathang; }
            set { m_DSPhieudathang = value; }
        }
        private IList<PhieuNhanHangInfo> m_DSPhieunhanhang;

        public IList<PhieuNhanHangInfo> DSPhieunhanhang
        {
            get { return m_DSPhieunhanhang; }
            set { m_DSPhieunhanhang = value; }
        }
	
	
	
    }
}
