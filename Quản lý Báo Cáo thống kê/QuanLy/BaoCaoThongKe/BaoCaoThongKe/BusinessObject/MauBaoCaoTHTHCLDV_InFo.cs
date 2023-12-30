using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class MauBaoCaoTHTHCLDV_InFo
    {
        private int m_Mabaocao;
        public int Mamaubaocao
        {
            get { return m_Mabaocao; }
            set { m_Mabaocao = value; }
        }

        private IList<BaoCaoTHTHCLDV_InFo> m_BaoCaoTHTHCLDV;
        public IList<BaoCaoTHTHCLDV_InFo> BaoCaoTHTHCLDV
        {
            get { return m_BaoCaoTHTHCLDV; }
            set { m_BaoCaoTHTHCLDV = value; }
        }
        
        private string m_Tenbaocao;
        public string Tenbaocao
        {
            get { return m_Tenbaocao; }
            set { m_Tenbaocao = value; }
        }

        private LoaiBaoCao_InFo m_Loaibaocao;
        public LoaiBaoCao_InFo Loaibaocao
        {
            get { return m_Loaibaocao; }
            set { m_Loaibaocao = value; }
        }

        private int m_Nambaocao;
        public int Nambaocao
        {
            get { return m_Nambaocao; }
            set { m_Nambaocao = value; }
        }

        public MauBaoCaoTHTHCLDV_InFo()
        {
            m_Loaibaocao = new LoaiBaoCao_InFo();
        }
    }
}
