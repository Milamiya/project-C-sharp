using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class BaoCaoTHTHDT_InFo
    {
        private int m_Mabaocao;
        public int Mabaocao
        {
            get { return m_Mabaocao; }
            set { m_Mabaocao = value; }
        }

        private MauBaoCaoTHTHDT_InFo m_Maubaocao;
        public MauBaoCaoTHTHDT_InFo Maubaocao
        {
            get { return m_Maubaocao; }
            set { m_Maubaocao = value; }
        }	

        private QL_DuAn_InFo m_Duan;
        public QL_DuAn_InFo Duan
        {
            get { return m_Duan; }
            set { m_Duan = value; }
        }

        private int m_Vondautu;
        public int Vondautu
        {
            get { return m_Vondautu; }
            set { m_Vondautu = value; }
        }

        private int m_Luykevon;
        public int Luykevon
        {
            get { return m_Luykevon; }
            set { m_Luykevon = value; }
        }

        private string m_Ghichu;
        public string Ghichu
        {
            get { return m_Ghichu; }
            set { m_Ghichu = value; }
        }       

        public BaoCaoTHTHDT_InFo()
        {
            m_Maubaocao = new MauBaoCaoTHTHDT_InFo();
            m_Duan = new QL_DuAn_InFo();
        }
    }
}
