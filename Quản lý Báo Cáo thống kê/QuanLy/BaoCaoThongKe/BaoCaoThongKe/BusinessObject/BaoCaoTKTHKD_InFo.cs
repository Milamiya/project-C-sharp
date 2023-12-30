using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class BaoCaoTKTHKD_InFo
    {
        private IList<BaoCaoChiTietCTVT_InFo> m_Machitiet;
        public IList<BaoCaoChiTietCTVT_InFo> Machitiet
        {
            get { return m_Machitiet; }
            set { m_Machitiet = value; }
        }


        private MauBaoCaoTKTHKD_InFo m_Maubaocao;
        public MauBaoCaoTKTHKD_InFo Maubaocao
        {
            get { return m_Maubaocao; }
            set { m_Maubaocao = value; }
        }

        private CongTrinhVienThong_InFo m_Congtrinh;
        public CongTrinhVienThong_InFo Congtrinh
        {
            get { return m_Congtrinh; }
            set { m_Congtrinh = value; }
        }

        private int m_Soluong;
        public int Soluong

        {
            get { return m_Soluong; }
            set { m_Soluong = value; }
        }

        private string m_Ghichu;
        public string Ghichu
        {
            get { return m_Ghichu; }
            set { m_Ghichu = value; }
        }

        public BaoCaoTKTHKD_InFo()
        {
            m_Congtrinh = new CongTrinhVienThong_InFo();
            m_Maubaocao = new MauBaoCaoTKTHKD_InFo();
        }
    }
}
