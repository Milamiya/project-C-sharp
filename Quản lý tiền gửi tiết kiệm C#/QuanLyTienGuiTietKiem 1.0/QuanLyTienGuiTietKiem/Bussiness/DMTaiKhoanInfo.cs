using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class DMTaiKhoanInfo
    {
        public DMTaiKhoanInfo()
        {
        }

        private String m_SoHieuTaiKhoan;
        public String SoHieuTaiKhoan
        {
            get { return m_SoHieuTaiKhoan; }
            set { m_SoHieuTaiKhoan = value; }
        }

        private String m_TenTaiKhoan;
        public String TenTaiKhoan
        {
            get { return m_TenTaiKhoan; }
            set { m_TenTaiKhoan = value; }
        }

        private String m_TinhChatSoDu;
        public String TinhChatSoDu
        {
            get { return m_TinhChatSoDu; }
            set { m_TinhChatSoDu = value; }
        }
    }
}
