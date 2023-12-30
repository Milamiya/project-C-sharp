using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class PhanNhomNguoiDungInfo
    {
        public PhanNhomNguoiDungInfo()
        {
        }

        private NhanVienInfo m_MaNV;
        public NhanVienInfo  MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private NhomNguoiDungInfo m_MaNhomNguoiDung;
        public NhomNguoiDungInfo MaNhomNguoiDung
        {
            get { return m_MaNhomNguoiDung; }
            set { m_MaNhomNguoiDung = value; }
        }
        
    }
}
