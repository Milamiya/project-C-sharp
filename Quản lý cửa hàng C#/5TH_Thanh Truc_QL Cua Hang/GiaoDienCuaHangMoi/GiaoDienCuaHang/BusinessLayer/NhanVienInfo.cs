using System;
using System.Collections.Generic;
using System.Text;

namespace GiaoDienCuaHang.BusinessLayer
{
   public class NhanVienInfo
    {
        private String m_MaNV;

        public String MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private String m_HoTen;

        public String HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }
        private String m_Diachi;

        public String Diachi
        {
            get { return m_Diachi; }
            set { m_Diachi = value; }
        }
        private DateTime m_Ngaysinh;

        public DateTime Ngaysinh
        {
            get { return m_Ngaysinh; }
            set { m_Ngaysinh = value; }
        }
        
        private GioiTinhInfo m_Gioitinh;

        public GioiTinhInfo Gioitinh
        {
            get { return m_Gioitinh; }
            set { m_Gioitinh = value; }
        }
	
        private String m_Dienthoai;

        public String Dienthoai
        {
            get { return m_Dienthoai; }
            set { m_Dienthoai = value; }
        }
        private String m_Username;

        public String Username
        {
            get { return m_Username; }
            set { m_Username = value; }
        }
        private String m_Passwords;

        public String Passwords
        {
            get { return m_Passwords; }
            set { m_Passwords = value; }
        }
        private LoaiNhanVienInfo m_loainv;

        public LoaiNhanVienInfo loainv
        {
            get { return m_loainv; }
            set { m_loainv = value; }
        }
	
	
	
    }
}
