using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class NguoiDung_InFo
    {
        private int m_MaNguoiDung;
        public int MaNguoiDung
        {
            get { return m_MaNguoiDung; }
            set { m_MaNguoiDung = value; }
        }

        private string m_HoTen;
        public string HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }

        private string m_TenDangNhap;
        public string TenDangNhap
        {
            get { return m_TenDangNhap; }
            set { m_TenDangNhap = value; }
        }

        private string m_MatKhau;
        public string MatKhau
        {
            get { return m_MatKhau; }
            set { m_MatKhau = value; }
        }

        private string m_Quyen;
        public string Quyen
        {
            get { return m_Quyen; }
            set { m_Quyen = value; }
        }
    }
}
