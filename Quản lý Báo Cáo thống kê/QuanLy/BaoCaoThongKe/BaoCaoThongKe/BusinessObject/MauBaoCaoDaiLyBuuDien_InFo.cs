using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class MauBaoCaoDaiLyBuuDien_InFo
    {
        private IList<BaoCaoDaiLyBuuDien_InFo> m_BaoCaoDaiLyBuuDien;
        public IList<BaoCaoDaiLyBuuDien_InFo> BaoCaoDaiLyBuuDien
        {
            get { return m_BaoCaoDaiLyBuuDien; }
            set { m_BaoCaoDaiLyBuuDien = value; }
        }

        private int m_MaMauBaoCaoDaiLyBuuDien;
        public int MaMauBaoCaoDaiLyBuuDien
        {
            get { return m_MaMauBaoCaoDaiLyBuuDien; }
            set { m_MaMauBaoCaoDaiLyBuuDien = value; }
        }

        private LoaiBaoCao_InFo m_Loaibaocao;
        public LoaiBaoCao_InFo Loaibaocao
        {
            get { return m_Loaibaocao; }
            set { m_Loaibaocao = value; }
        }

        private string m_Tenbaocao;
        public string Tenbaocao
        {
            get { return m_Tenbaocao; }
            set { m_Tenbaocao = value; }
        }

        private int m_6Thang;
        public int m_Thang
        {
            get { return m_6Thang; }
            set { m_6Thang = value; }
        }

        private int m_Nam;
        public int Nambaocao
        {
            get { return m_Nam; }
            set { m_Nam = value; }
        }

        public MauBaoCaoDaiLyBuuDien_InFo()
        {
            m_Loaibaocao = new LoaiBaoCao_InFo();
        }
    }
}
