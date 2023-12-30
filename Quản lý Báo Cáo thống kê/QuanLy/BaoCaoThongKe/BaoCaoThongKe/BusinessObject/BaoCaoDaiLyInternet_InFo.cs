using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class BaoCaoDaiLyInternet_InFo
    {
        private int m_MabaocaoInt;
        public int MabaocaoInt
        {
            get { return m_MabaocaoInt; }
            set { m_MabaocaoInt = value; }
        }
        private LoaiBaoCao_InFo m_loaibaocaoInt;
        public LoaiBaoCao_InFo loaibaocaoInt
        {
            get { return m_loaibaocaoInt; }
            set { m_loaibaocaoInt = value; }
        }

        private MauBaoCaoDaiLyInternet_InFo m_MaubaocaoInt;
        public MauBaoCaoDaiLyInternet_InFo MaubaocaoInt
        {
            get { return m_MaubaocaoInt; }
            set { m_MaubaocaoInt = value; }
        }
        private NhomThueBao_InFo m_ThueBao;
        public NhomThueBao_InFo ThueBao
        {
            get { return m_ThueBao; }
            set { m_ThueBao = value; }
        }
        private DaiLyInternet_InFo m_DaiLyInt;
        public DaiLyInternet_InFo DaiLyInt
        {
            get { return m_DaiLyInt; }
            set { m_DaiLyInt = value; }
        }
        private int m_SoHieu;
        public int SoHieu
        {
            get { return m_SoHieu; }
            set { m_SoHieu = value; }
        }
        private string m_DienThoaiInt;
        public string DienThoaiInt
        {
            get { return m_DienThoaiInt; }
            set { m_DienThoaiInt = value; }
        }
        private string m_GhichuInt;
        public string GhichuInt
        {
            get { return m_GhichuInt; }
            set { m_GhichuInt = value; }
        }
        public BaoCaoDaiLyInternet_InFo()
        {
            m_MaubaocaoInt = new MauBaoCaoDaiLyInternet_InFo();
            m_DaiLyInt = new DaiLyInternet_InFo();
            m_ThueBao = new NhomThueBao_InFo();
        }
    }
}
