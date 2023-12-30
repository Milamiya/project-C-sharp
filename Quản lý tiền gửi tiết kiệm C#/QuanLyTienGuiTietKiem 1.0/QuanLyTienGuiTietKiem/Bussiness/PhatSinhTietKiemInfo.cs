using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class PhatSinhTietKiemInfo
    {
        public PhatSinhTietKiemInfo()
        {
        }

        private String m_MaSoTietKiem;
        public String MaSoTietKiem
        {
            get { return m_MaSoTietKiem; }
            set { m_MaSoTietKiem = value; }
        }

        private String m_SoButToan;
        public String SoButToan
        {
            get { return m_SoButToan; }
            set { m_SoButToan = value; }
        }

        private DateTime m_NgayGiaoDich;
        public DateTime NgayGiaoDich
        {
            get { return m_NgayGiaoDich;}
            set { m_NgayGiaoDich = value; }
        }

        private Boolean m_DaDuyet;
        public Boolean DaDuyet
        {
            get { return m_DaDuyet; }
            set { m_DaDuyet = value; }
        }

        private PhongGiaoDichInfo m_MaPhongGD;
        public PhongGiaoDichInfo MaPhongGD
        {
            get { return m_MaPhongGD; }
            set { m_MaPhongGD = value; }
        }

        private NhanVienInfo m_MaNV;
        public NhanVienInfo MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private QuayGiaoDichInfo m_QuayGiaoDich;
        public QuayGiaoDichInfo QuayGiaoDich
        {
            get { return m_QuayGiaoDich; }
            set { m_QuayGiaoDich = value; }
        }


        private DMLoaiGiaoDichInfo m_LoaiGiaoDich;
        public DMLoaiGiaoDichInfo LoaiGiaoDich
        {
            get { return m_LoaiGiaoDich; }
            set { m_LoaiGiaoDich = value; }
        } 
    }
}
