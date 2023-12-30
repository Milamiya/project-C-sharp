using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class DaiLyInternet_InFo
    {
        private int m_MaDaiLyInt;
        public int MaDaiLyInt
        {
            get { return m_MaDaiLyInt; }
            set { m_MaDaiLyInt = value; }
        }

        private string m_TenDaiLyInt;
        public string TenDaiLyInt
        {
            get { return m_TenDaiLyInt; }
            set { m_TenDaiLyInt = value; }
        }

        private Huyen_Thi_InFo m_huyenInt;
        public Huyen_Thi_InFo huyenInt
        {
            get { return m_huyenInt; }
            set { m_huyenInt = value; }
        }

        private Xa_Phuong_InFo m_xaInt;
        public Xa_Phuong_InFo xaInt
        {
            get { return m_xaInt; }
            set { m_xaInt = value; }
        }

        private string m_DiaChiInt;
        public string DiaChiInt
        {
            get { return m_DiaChiInt; }
            set { m_DiaChiInt = value; }
        }

        private string m_DienThoaiInt;
        public string DienThoaiInt
        {
            get { return m_DienThoaiInt; }
            set { m_DienThoaiInt = value; }
        }

        private string m_GhiChuInt;
        public string GhiChuInt
        {
            get { return m_GhiChuInt; }
            set { m_GhiChuInt = value; }
        }
        private string m_SoHieu;
        public string SoHieu
        {
            get { return m_SoHieu; }
            set { m_SoHieu = value; }
        }

         
        private QL_DoanhNghiep_InFo m_DoanhNghiepInt;
        public QL_DoanhNghiep_InFo doanhnghiepInt
        {
            get { return m_DoanhNghiepInt; }
            set { m_DoanhNghiepInt = value; }
        }

        public DaiLyInternet_InFo()
        {
            m_DoanhNghiepInt = new QL_DoanhNghiep_InFo();
            m_huyenInt = new Huyen_Thi_InFo();
            m_xaInt = new Xa_Phuong_InFo();
        }
    }
}
