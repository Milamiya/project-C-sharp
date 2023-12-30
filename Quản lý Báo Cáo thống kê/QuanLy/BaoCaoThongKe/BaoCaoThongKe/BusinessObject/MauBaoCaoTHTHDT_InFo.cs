using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class MauBaoCaoTHTHDT_InFo
    {
        private IList<BaoCaoTHTHDT_InFo> m_BaoCaoTHTHDT;
        public IList<BaoCaoTHTHDT_InFo> BaoCaoTHTHDT
        {
            get { return m_BaoCaoTHTHDT; }
            set { m_BaoCaoTHTHDT = value; }
        }

        private int m_Mamaubaocao;
        public int Mamaubaocao
        {
            get { return m_Mamaubaocao; }
            set { m_Mamaubaocao = value; }
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
        
        private int m_Qui;
        public int Quibaocao
        {
            get { return m_Qui; }
            set { m_Qui = value; }
        }

        private int m_Nam;
        public int Nambaocao
        {
            get { return m_Nam; }
            set { m_Nam = value; }
        }

        public MauBaoCaoTHTHDT_InFo()
        {
            m_Loaibaocao = new LoaiBaoCao_InFo();
        }
    }
}
