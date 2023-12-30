using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class NgheNghiepInfo
    {
        private int m_MaNgheNghiep;

        public int MaNgheNghiep
        {
            get { return m_MaNgheNghiep; }
            set { m_MaNgheNghiep = value; }
        }
        private String  m_TenNgheNghiep;

        public String  TenNgheNghep
        {
            get { return m_TenNgheNghiep; }
            set { m_TenNgheNghiep = value; }
        }

    }
}
