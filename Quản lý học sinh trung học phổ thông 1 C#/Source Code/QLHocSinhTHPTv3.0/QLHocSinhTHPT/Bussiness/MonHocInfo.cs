using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class MonHocInfo
    {
        public MonHocInfo()
        {

        }

        private String m_MaMonHoc;
        public String MaMonHoc
        {
            get { return m_MaMonHoc; }
            set { m_MaMonHoc = value; }
        }

        private String m_TenMonHoc;
        public String TenMonHoc
        {
            get { return m_TenMonHoc; }
            set { m_TenMonHoc = value; }
        }

        private int m_SoTiet;
        public int SoTiet
        {
            get { return m_SoTiet; }
            set { m_SoTiet = value; }
        }

        private int m_HeSo;
        public int HeSo
        {
            get { return m_HeSo; }
            set { m_HeSo = value; }
        }
    }
}
