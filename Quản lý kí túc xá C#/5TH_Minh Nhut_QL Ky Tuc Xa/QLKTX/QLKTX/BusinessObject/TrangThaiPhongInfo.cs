using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class TrangThaiPhongInfo
    {
        private int m_MaTrangThai;

        public int MaTrangThai
        {
            get { return m_MaTrangThai; }
            set { m_MaTrangThai = value; }
        }
        private string m_tenTrangThai;

        public string TenTrangThai
        {
            get { return m_tenTrangThai; }
            set { m_tenTrangThai = value; }
        }

    }
}
