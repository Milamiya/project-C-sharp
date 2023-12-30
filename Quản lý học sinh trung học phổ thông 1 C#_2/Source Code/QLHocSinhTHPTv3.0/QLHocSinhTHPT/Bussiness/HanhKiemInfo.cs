using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class HanhKiemInfo
    {
        public HanhKiemInfo()
        {

        }

        private String m_MaHanhKiem;
        public String MaHanhKiem
        {
            get { return m_MaHanhKiem; }
            set { m_MaHanhKiem = value; }
        }

        private String m_TenHanhKiem;
        public String TenHanhKiem
        {
            get { return m_TenHanhKiem; }
            set { m_TenHanhKiem = value; }
        }
    }
}
