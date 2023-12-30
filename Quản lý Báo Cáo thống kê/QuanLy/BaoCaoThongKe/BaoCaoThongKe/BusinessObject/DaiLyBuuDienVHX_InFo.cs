using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class DaiLyBuuDienVHX_InFo
    {
        private int m_MaDaiLyBuuDien;
        public int MaDaiLyBuuDien
        {
            get { return m_MaDaiLyBuuDien; }
            set { m_MaDaiLyBuuDien = value; }
        }

        private string m_TenDaiLy;
        public string TenDaiLy
        {
            get { return m_TenDaiLy; }
            set { m_TenDaiLy = value; }
        }

        private Huyen_Thi_InFo m_huyen;
        public Huyen_Thi_InFo huyen
        {
            get { return m_huyen; }
            set { m_huyen = value; }
        }

        private Xa_Phuong_InFo m_xa;
        public Xa_Phuong_InFo xa
        {
            get { return m_xa; }
            set { m_xa = value; }
        }

        private string m_DiaChi;
        public string DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private string m_DienThoai;
        public string DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }

        private string m_GhiChu;
        public string GhiChu
        {
            get { return m_GhiChu; }
            set { m_GhiChu = value; }
        }

        private QL_DoanhNghiep_InFo m_DoanhNghiep;
        public QL_DoanhNghiep_InFo doanhnghiep
        {
            get { return m_DoanhNghiep; }
            set { m_DoanhNghiep = value; }
        }

        public DaiLyBuuDienVHX_InFo()
        {
            m_DoanhNghiep = new QL_DoanhNghiep_InFo();
            m_huyen = new Huyen_Thi_InFo();
            m_xa = new Xa_Phuong_InFo();
        }
    }
}
