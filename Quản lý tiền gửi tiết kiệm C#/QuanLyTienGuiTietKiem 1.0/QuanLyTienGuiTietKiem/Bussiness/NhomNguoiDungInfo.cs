using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class NhomNguoiDungInfo
    {
        public NhomNguoiDungInfo()
        {
        }

        private String m_MaNhomNguoiDung;
        public String MaNhomNguoiDung
        {
            get { return m_MaNhomNguoiDung; }
            set { m_MaNhomNguoiDung = value; }
        }

        private String m_TenNhomNguoiDung;
        public String TenNhomNguoiDung
        {
            get { return m_TenNhomNguoiDung; }
            set { m_TenNhomNguoiDung = value; }
        }
    }
}
