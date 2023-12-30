using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class NguoiDungInfo
    {
        #region Tên người dùng
        private string m_Username;

        public string Username
        {
            get { return m_Username; }
            set { m_Username = value; }
        } 
        #endregion
        #region Mật khẩu
        private string m_Password;

        public string Password
        {
            get { return m_Password; }
            set { m_Password = value; }
        } 
        #endregion
        private int ma;

        public int Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        private string m_HoTen;

        public string HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }
        private char quyen;

        public char Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }


    }
}
