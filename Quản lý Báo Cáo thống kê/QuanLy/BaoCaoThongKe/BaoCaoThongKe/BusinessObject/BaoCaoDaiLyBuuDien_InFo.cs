using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class BaoCaoDaiLyBuuDien_InFo
    {
        private int m_Mabaocao;
        public int Mabaocao
        {
            get { return m_Mabaocao; }
            set { m_Mabaocao = value; }
        }
        private LoaiBaoCao_InFo m_loaibaocao;
        public LoaiBaoCao_InFo loaibaocao
        {
            get { return m_loaibaocao; }
            set { m_loaibaocao = value; }
        }

        private  MauBaoCaoDaiLyBuuDien_InFo m_Maubaocao;
        public MauBaoCaoDaiLyBuuDien_InFo Maubaocao
        {
            get { return m_Maubaocao; }
            set { m_Maubaocao = value; }
        }

        private DaiLyBuuDien_InFo m_DaiLyBuuDien;
        public DaiLyBuuDien_InFo DaiLyBuuDien
        {
            get { return m_DaiLyBuuDien; }
            set { m_DaiLyBuuDien = value; }
        }

        private string m_DienThoai;
        public string DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }
        private string m_Ghichu;
        public string Ghichu
        {
            get { return m_Ghichu; }
            set { m_Ghichu = value; }
        }

        public BaoCaoDaiLyBuuDien_InFo()
        {
            m_Maubaocao = new MauBaoCaoDaiLyBuuDien_InFo();
            m_DaiLyBuuDien = new DaiLyBuuDien_InFo();
        }
    }
}
