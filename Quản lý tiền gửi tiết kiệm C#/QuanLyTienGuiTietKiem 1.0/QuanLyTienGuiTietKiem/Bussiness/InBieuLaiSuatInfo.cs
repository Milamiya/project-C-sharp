using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class BieuLaiSuatInfo
    {
        public BieuLaiSuatInfo()
        {
        }

        private LaiSuatTietKiemInfo m_LaiSuatTK;
        public LaiSuatTietKiemInfo LaiSuatTK
        {
            get { return m_LaiSuatTK; }
            set { m_LaiSuatTK = value; }
        }

        private LoaiTietKiemInfo m_LoaiTietKiem;
        public LoaiTietKiemInfo LoaiTietKiem
        {
            get { return m_LoaiTietKiem; }
            set { m_LoaiTietKiem = value; }
        }
      
    }
}
