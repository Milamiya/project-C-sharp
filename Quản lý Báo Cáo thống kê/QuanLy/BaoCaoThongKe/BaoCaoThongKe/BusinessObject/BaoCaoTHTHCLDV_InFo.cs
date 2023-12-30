using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class BaoCaoTHTHCLDV_InFo
    {
        private int m_Mabaocao;
        public int Mabaocao
        {
            get { return m_Mabaocao; }
            set { m_Mabaocao = value; }
        }

        private MauBaoCaoTHTHCLDV_InFo m_Maubaocao;
        public MauBaoCaoTHTHCLDV_InFo Maubaocao
        {
            get { return m_Maubaocao; }
            set { m_Maubaocao = value; }
        }

        private DichVuBuuChinh_VienThong_InFo m_Dichvubuuchinh;
        public DichVuBuuChinh_VienThong_InFo Dichvubuuchinh
        {
            get { return m_Dichvubuuchinh; }
            set { m_Dichvubuuchinh = value; }
        }

        private string  m_Thuocdanhmucbuuchinh;
        public string  Thuocdanhmucbuuchinh
        {
            get { return m_Thuocdanhmucbuuchinh; }
            set { m_Thuocdanhmucbuuchinh = value; }
        }

        private TieuChuanChatLuong_InFo m_Tieuchuanchatluong;
        public TieuChuanChatLuong_InFo Tieuchuanchatluong
        {
            get { return m_Tieuchuanchatluong; }
            set { m_Tieuchuanchatluong = value; }
        }

        private string m_Vanbancongbo;
        public string Vanbancongbo
        {
            get { return m_Vanbancongbo; }
            set { m_Vanbancongbo = value; }
        }

        private string m_Doanhnghiepcongbo;
        public string Doanhnghiepcongbo
        {
            get { return m_Doanhnghiepcongbo; }
            set { m_Doanhnghiepcongbo = value; }
        }

        private string m_Ghichu;
        public string Ghichu
        {
            get { return m_Ghichu; }
            set { m_Ghichu = value; }
        }

        public BaoCaoTHTHCLDV_InFo()
        {
            m_Dichvubuuchinh = new DichVuBuuChinh_VienThong_InFo();
            m_Maubaocao = new MauBaoCaoTHTHCLDV_InFo();
            m_Tieuchuanchatluong = new TieuChuanChatLuong_InFo();
        }
    }
}
