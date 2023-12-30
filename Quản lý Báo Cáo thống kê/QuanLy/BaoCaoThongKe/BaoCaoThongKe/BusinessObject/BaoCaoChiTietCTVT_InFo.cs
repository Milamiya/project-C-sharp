using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class BaoCaoChiTietCTVT_InFo
    {
        private BaoCaoTKTHKD_InFo m_Mabaocao;
        public BaoCaoTKTHKD_InFo Mabaocao
        {
            get { return m_Mabaocao; }
            set { m_Mabaocao = value; }
        }

        private CongTrinhVienThong_InFo m_Macongtrinh;
        public CongTrinhVienThong_InFo Macongtrinh
        {
            get { return m_Macongtrinh; }
            set { m_Macongtrinh = value; }
        }

        private int m_Machitiet;
        public int Machitiet
        {
            get { return m_Machitiet; }
            set { m_Machitiet = value; }
        }

        private string m_Diadiem;
        public string Diadiem
        {
            get { return m_Diadiem; }
            set { m_Diadiem = value; }
        }

        private DateTime m_Thoidiem;
        public DateTime Thoidiem
        {
            get { return m_Thoidiem; }
            set { m_Thoidiem = value; }
        }

        private string m_Daitanso;
        public string Daitanso
        {
            get { return m_Daitanso; }
            set { m_Daitanso = value; }
        }

        private string m_Mota;
        public string Mota
        {
            get { return m_Mota; }
            set { m_Mota = value; }
        }

        public BaoCaoChiTietCTVT_InFo()
        {
            m_Mabaocao = new BaoCaoTKTHKD_InFo();
            m_Macongtrinh = new CongTrinhVienThong_InFo();
        }
    }
}
