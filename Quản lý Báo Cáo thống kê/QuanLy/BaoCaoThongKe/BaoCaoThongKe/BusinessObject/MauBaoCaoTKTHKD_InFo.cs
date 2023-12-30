using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class MauBaoCaoTKTHKD_InFo
    {
        private IList<BaoCaoTKTHKD_InFo> m_BaoCaoTKTHKD;
        public IList<BaoCaoTKTHKD_InFo> BaoCaoTKTHKD
        {
            get { return m_BaoCaoTKTHKD; }
            set { m_BaoCaoTKTHKD = value; }
        }


        private int m_Mamaubaocao;
        public int Mamaubaocao
        {
            get { return m_Mamaubaocao; }
            set { m_Mamaubaocao = value; }
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

        public MauBaoCaoTKTHKD_InFo()
        {
            m_Loaibaocao = new LoaiBaoCao_InFo();
        }
    }
}
