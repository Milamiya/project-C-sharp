using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class LoaiNguoiDungInfo
    {
        public LoaiNguoiDungInfo()
        {

        }

        private String m_MaLoai;
        public String MaLoai
        {
            get { return m_MaLoai; }
            set { m_MaLoai = value; }
        }

        private String m_TenLoaiND;
        public String TenLoaiND
        {
            get { return m_TenLoaiND; }
            set { m_TenLoaiND = value; }
        }
    }
}
