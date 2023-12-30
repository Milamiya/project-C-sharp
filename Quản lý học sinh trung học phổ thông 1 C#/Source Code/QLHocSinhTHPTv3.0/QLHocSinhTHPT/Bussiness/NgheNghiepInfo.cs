using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class NgheNghiepInfo
    {
        public NgheNghiepInfo()
        {

        }
        
        private String m_MaNghe;
        public String MaNghe
        {
            get { return m_MaNghe; }
            set { m_MaNghe = value; }
        }

        private String m_TenNghe;
        public String TenNghe
        {
            get { return m_TenNghe; }
            set { m_TenNghe = value; }
        }
    }
}
