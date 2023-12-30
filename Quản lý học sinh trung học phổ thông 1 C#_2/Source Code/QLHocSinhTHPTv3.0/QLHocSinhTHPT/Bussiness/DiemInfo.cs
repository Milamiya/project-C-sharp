using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class DiemInfo
    {
        public DiemInfo()
        {
            m_HocSinh   = new HocSinhInfo();
            m_MonHoc    = new MonHocInfo();
            m_HocKy     = new HocKyInfo();
            m_NamHoc    = new NamHocInfo();
            m_LoaiDiem  = new LoaiDiemInfo();
            m_Lop       = new LopInfo();
            m_Diem      = 0;
        }

        private HocSinhInfo m_HocSinh;
        public HocSinhInfo HocSinh
        {
            get { return m_HocSinh; }
            set { m_HocSinh = value; }
        }

        private MonHocInfo m_MonHoc;
        public MonHocInfo MonHoc
        {
            get { return m_MonHoc; }
            set { m_MonHoc = value; }
        }

        private HocKyInfo m_HocKy;
        public HocKyInfo HocKy
        {
            get { return m_HocKy; }
            set { m_HocKy = value; }
        }

        private NamHocInfo m_NamHoc;
        public NamHocInfo NamHoc
        {
            get { return m_NamHoc; }
            set { m_NamHoc = value; }
        }

        private LopInfo m_Lop;
        public LopInfo Lop
        {
            get { return m_Lop; }
            set { m_Lop = value; }
        }

        private LoaiDiemInfo m_LoaiDiem;
        public LoaiDiemInfo LoaiDiem
        {
            get { return m_LoaiDiem; }
            set { m_LoaiDiem = value; }
        }

        private float m_Diem;
        public float Diem
        {
            get { return m_Diem; }
            set { m_Diem = value; }
        }
    }
}
