using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class DMKyLaiTKInfo
    {
        public DMKyLaiTKInfo()
        {
        }

        private String m_MaKyTinhLai;
        public String MaKyTinhLai
        {
            get { return m_MaKyTinhLai; }
            set { m_MaKyTinhLai = value; }
        }

        private String m_LoaiKyTinhLai;
        public String LoaiKyTinhLai
        {
            get { return m_LoaiKyTinhLai; }
            set { m_LoaiKyTinhLai = value; }
        }
    }
}
