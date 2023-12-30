using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
    public class Username
    {
        public Username() { }

        public Username(String user, String pass)
        {
            m_User = user;
            m_Pass = pass;
        }

        public Username(String user, String pass, string quyen)
        {
            m_User = user;
            m_Pass = pass;
            m_QuyenTruyCap = quyen;
        }

        private String m_User;

        public String user
        {
            get { return m_User; }
            set { m_User = value; }
        }

        private String m_Pass;

        public String pass
        {
            get { return m_Pass; }
            set { m_Pass = value; }
        }

        private String m_QuyenTruyCap;

        public String quyen
        {
            get { return m_QuyenTruyCap; }
            set { m_QuyenTruyCap = value; }
        }

        private String m_NhanVien;

        public String nhanvien
        {
            get { return m_NhanVien; }
            set { m_NhanVien = value; }
        }
    }
}
