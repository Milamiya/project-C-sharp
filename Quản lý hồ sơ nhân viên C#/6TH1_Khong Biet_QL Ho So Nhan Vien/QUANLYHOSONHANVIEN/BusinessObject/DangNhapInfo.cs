using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class DangNhapInfo
    {
        private string m_username;
        public string username
        {
            get { return m_username; }
            set { m_username = value; }
        }
        private string m_password;
        public string password
        {
            get { return m_password; }
            set { m_password = value; }
        }
        private string m_tennhom;
        public string tennhom
        {
            get { return m_tennhom; }
            set { m_tennhom = value; }
        }
        private string m_quyen;
        public string quyen
        {
            get { return m_quyen; }
            set { m_quyen = value; }
        }
    
    }
}
