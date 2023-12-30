using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class MauBaoCaoDaiLyInternet_InFo
    {
        private IList<BaoCaoDaiLyInternet_InFo> m_BaoCaoDaiLyInt;
        public IList<BaoCaoDaiLyInternet_InFo> BaoCaoDaiLyInt
        {
            get { return m_BaoCaoDaiLyInt; }
            set { m_BaoCaoDaiLyInt = value; }
        }

        private int m_MaMauBaoCaoDaiLyInt;
        public int MaMauBaoCaoDaiLyInt
        {
            get { return m_MaMauBaoCaoDaiLyInt; }
            set { m_MaMauBaoCaoDaiLyInt = value; }
        }

        private LoaiBaoCao_InFo m_LoaibaocaoInt;
        public LoaiBaoCao_InFo LoaibaocaoInt
        {
            get { return m_LoaibaocaoInt; }
            set { m_LoaibaocaoInt = value; }
        }
        private string m_TenbaocaoInt;
        public string TenbaocaoInt
        {
            get { return m_TenbaocaoInt; }
            set { m_TenbaocaoInt = value; }
        }

        private int m_6ThangInt;
        public int m_ThangInt
        {
            get { return m_6ThangInt; }
            set { m_6ThangInt = value; }
        }

        private int m_NamInt;
        public int NambaocaoInt
        {
            get { return m_NamInt; }
            set { m_NamInt = value; }
        }

        public MauBaoCaoDaiLyInternet_InFo()
        {
            m_LoaibaocaoInt = new LoaiBaoCao_InFo();

        }
    }
}
