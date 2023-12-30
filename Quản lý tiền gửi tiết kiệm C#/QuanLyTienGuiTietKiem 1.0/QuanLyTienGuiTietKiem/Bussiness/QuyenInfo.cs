using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class QuyenInfo
    {
        public QuyenInfo()
        {
        }

        private String m_MaLoai;
        public String MaLoai
        {
            get { return m_MaLoai; }
            set { m_MaLoai = value; }
        }

        private String m_TenLoai;
        public String TenLoai
        {
            get { return m_TenLoai; }
            set { m_TenLoai = value; }
        }
        
    }
}
